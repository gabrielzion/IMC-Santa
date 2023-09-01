using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication5.Classes;

namespace WebApplication5.Forms
{
    public partial class Index : System.Web.UI.Page
    {
        public static List<Paciente> pacientes = new List<Paciente>();

        protected void Page_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "Calculadora IMC (" + pacientes.Count + ")";


        }

        protected void btOk_Click(object sender, EventArgs e)
        {
            Paciente p = null;



            if (txCodigo.Text.Trim() == String.Empty)
            {
                lbResultado.Text = "Favor digitar o código do paciente!";
                return;
            }

            foreach (Paciente paciente in pacientes)
            {
                if (paciente.codigo.Trim() == txCodigo.Text.Trim())
                {
                    p = paciente;
                    break;
                }
            }

            if (p == null)
            {
                if (!rbFem.Checked && !rbMasc.Checked)
                {
                    lbResultado.Text = "Favor selecionar o sexo do paciente!";
                    return;
                }

                if (txNome.Text.Trim() == String.Empty)
                {
                    lbResultado.Text = "Favor digitar o nome do paciente!";
                    return;
                }
            }
            else
            {
                txNome.Text = p.nome;
                rbFem.Checked = p.sexo == 'F';
                rbMasc.Checked = p.sexo == 'M';

                //   if (p.sexo == 'F') rbFem.Checked = true;
                //  else rbMasc.Checked = true;


            }

            float altura;
            float peso;

            if (!float.TryParse(txAltura.Text, out altura))
            {
                lbResultado.Text = "Valor altura digitado inválido";
                return;
            }
            if (!float.TryParse(txPeso.Text, out peso))
            {
                lbResultado.Text = "Valor peso digitado inválido";
                return;
            }

            if (peso < 40 || peso > 200)
            {
                lbResultado.Text = "Valor do peso inválido";
                return;
            }

            if (altura < 1 || altura > 2)
            {
                lbResultado.Text = "Valor de altura inválido";
                return;
            }

            IMC imc = new IMC(peso, altura, rbMasc.Checked ? 'M' : 'F');


            if (p == null)
            {
                p = new Paciente(txCodigo.Text, txNome.Text,

                    rbMasc.Checked ? 'M' : 'F', imc);

                pacientes.Add(p);
            }
            else
            {
                p.imc = imc;
            }

            lbTitulo.Text = "Calculadora IMC (" + pacientes.Count + ")";

            lbResultado.Text = imc.diagnostico();

            if (imc.Imc > 40)
            {
                lbResultado.ForeColor = Color.Brown;
            }
            else
            {
                lbResultado.ForeColor = Color.DarkBlue;
            }
        }



        protected void btnGerarRelatorio_Click1(object sender, EventArgs e)
        {
            string relatorio = "Relatório de Pacientes:\n\n";

            foreach (Paciente paciente in pacientes)
            {
                relatorio += "Código: " + paciente.codigo + "\n";
                relatorio += "Nome: " + paciente.nome + "\n";
                relatorio += "Sexo: " + (paciente.sexo == 'M' ? "Masculino" : "Feminino") + "\n";
                relatorio += "IMC: " + paciente.imc.Imc.ToString("F2") + "\n";
                relatorio += "Diagnóstico: " + paciente.imc.diagnostico() + "\n\n";
            }

            lbRelatorio.Text = relatorio;
        }

        protected void btnLimparPacientes_Click(object sender, EventArgs e)
        {
            pacientes.Clear();

            lbTitulo.Text = "Calculadora IMC (" + pacientes.Count + ")";
            lbRelatorio.Text = "";

            txCodigo.Text = "";
            txNome.Text = "";
            rbFem.Checked = false;
            rbMasc.Checked = false;
            txAltura.Text = "";
            txPeso.Text = "";
            lbResultado.Text = "";
            lbResultado.ForeColor = Color.Black;
        }
    }
}