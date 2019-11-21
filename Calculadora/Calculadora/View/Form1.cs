using Calculadora.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double Classes = Convert.ToDouble(txtip1.Text);
            // acha a classe a 
            if (Classes >= 0 && 128 > Classes)
            {
                txtMascara.Text = "255.0.0.0";
                txtClasses.Text = "A";
                txtBinario.Text = "11111111.00000000.00000000.00000000";
                carregarSubrede();
            }
            //************************  PARA  CLASSE B **********************************
            else if (Classes >= 128 && 192 > Classes)
            {
                txtMascara.Text = "255.255.0.0";
                txtClasses.Text = "B";
                txtBinario.Text = "11111111.11111111.00000000.00000000";
                carregarSubrede();
            }
            //************************  PARA CLASSE C **********************************
            else if (Classes >= 192 && 224 > Classes)
            {
                txtMascara.Text = "255.255.255.0";
                txtClasses.Text = "C";
                txtBinario.Text = "11111111.11111111.11111111.00000000";
                carregarSubrede();
            }
            else if (Classes >= 224)
            {
                MessageBox.Show("Fora do intervalo Número de IP", " Ip de rede", MessageBoxButtons.OKCancel);
                txtip1.Text = "";
                txtip2.Text = "";
                txtip3.Text = "";
                txtip4.Text = "";
                txtSubrede.Text = "";
            }
            
        }
        public void carregarSubrede()
        {
            //***** numero de subrede total: 0,2,6,14,30,62 --> (2^i )- 2 = resultado
            Double NumSubredTotal = 0;
            Double num1Subred = 0;
            Double num2Subred = 0;
            int SubredIngresada = Convert.ToInt32(txtSubrede.Text);
            // O 999 ele nao tem um limite de subrede
            for (int i = 1; i < 999; i++)
            {
                //******************TOTAL DE SUBREDE *****************
                NumSubredTotal = (Math.Pow(2, i) - 2);
                if (SubredIngresada <= NumSubredTotal)
                {
                     
                    //************* número de bits usados *******************
                    num1Subred = Math.Pow(2, 8 - i);
                    num2Subred = Math.Pow(2, i);

                    listarId_Red(num1Subred, num2Subred);
                    listarId_Broadcast(num2Subred, num1Subred);
                    listarIp_Configuracao(num2Subred, num1Subred);
                    pintarSubred(SubredIngresada);
                    break;
                }
            }
        }
        Double conthost1;
        Double conthost2;
        Double conthost3;
        
        String ipRed = "";

        String binarioip1 = "";
        String binarioip2 = "";
        String binarioip3 = "";
        String binarioip4 = "";
        
        String valorBinario = "";
        public void listarId_Red(Double numSubred, Double NumSubred)
        {
            

            conthost1 = 0;
            conthost2 = 0;
            conthost3 = 0;
            
            for (int i = 0; i < NumSubred; i++)
            {
                //************************PARA  CLASSE A *************************
                if (txtClasses.Text.Equals("A"))
                {
                    ipRed = txtip1.Text + "." + Convert.ToString(conthost1) + "." + Convert.ToString(conthost2) + "." + Convert.ToString(conthost3);
                    
                    binarioip1 = txtip1.Text;
                    binarioip2 = Convert.ToString(conthost1);
                    binarioip3 = Convert.ToString(conthost2);
                    binarioip4 = Convert.ToString(conthost3);

                    
                    binarioip1 = Conversao.DecimalParaBinario(binarioip1);
                    binarioip2 = Conversao.DecimalParaBinario(binarioip2);
                    binarioip3 = Conversao.DecimalParaBinario(binarioip3);
                    binarioip4 = Conversao.DecimalParaBinario(binarioip4);
                    valorBinario = binarioip1 + "." + binarioip2 + "." + binarioip3 + "." + binarioip4;

                    conthost1 = conthost1 + numSubred;

                }
                //************************PARA CLASSE B *************************
                else if (txtClasses.Text.Equals("B"))
                {
                    ipRed = txtip1.Text + "." + txtip2.Text + "." + Convert.ToString(conthost2) + "." + Convert.ToString(conthost3);

                    binarioip1 = txtip1.Text;
                    binarioip2 = txtip2.Text;
                    binarioip3 = Convert.ToString(conthost2);
                    binarioip4 = Convert.ToString(conthost3);


                    binarioip1 = Conversao.DecimalParaBinario(binarioip1);
                    binarioip2 = Conversao.DecimalParaBinario(binarioip2);
                    binarioip3 = Conversao.DecimalParaBinario(binarioip3);
                    binarioip4 = Conversao.DecimalParaBinario(binarioip4);
                    valorBinario = binarioip1 + "." + binarioip2 + "." + binarioip3 + "." + binarioip4;

                    conthost2 = conthost2 + numSubred;
                }
                //************************PARA  CLASSE C *************************
                else if (txtClasses.Text.Equals("C"))
                {
                    ipRed = txtip1.Text + "." + txtip2.Text + "." + txtip3.Text + "." + Convert.ToString(conthost3);

                    binarioip1 = txtip1.Text;
                    binarioip2 = txtip2.Text;
                    binarioip3 = txtip3.Text;
                    binarioip4 = Convert.ToString(conthost3);


                    binarioip1 = Conversao.DecimalParaBinario(binarioip1);
                    binarioip2 = Conversao.DecimalParaBinario(binarioip2);
                    binarioip3 = Conversao.DecimalParaBinario(binarioip3);
                    binarioip4 = Conversao.DecimalParaBinario(binarioip4);
                    valorBinario = binarioip1 + "." + binarioip2 + "." + binarioip3 + "." + binarioip4;
                    conthost3 = conthost3 + numSubred;
                }

                dgvtabelaSubrede.Rows.Add();
                dgvtabelaSubrede.Rows[i].Cells[0].Value = i;
                dgvtabelaSubrede.Rows[i].Cells[1].Value = ipRed;
                dgvtabelaSubrede.Rows[i].Cells[4].Value = valorBinario;

            }
        }

        ////************************** LISTA DE DADOS DE ALCANCE IP_CONFIGURAÇÃO ****************************

        String ipRed1 = "";
        String ipRed2 = "";
        public void listarIp_Configuracao(Double NumSubred, Double numSubred)
        {
            conthost1 = 0;
            conthost2 = 0;
            conthost3 = 0;

            for (int i = 0; i < NumSubred; i++)
            {
                //************************PARA  CLASSE A *************************
                if (txtClasses.Text.Equals("A"))
                {
                    ipRed1 = txtip1.Text + "." + Convert.ToString(conthost1) + "." + Convert.ToString(conthost2) + "." + Convert.ToString(conthost3 + 1);
                    conthost1 = conthost1 + numSubred;
                    ipRed2 = txtip1.Text + "." + Convert.ToString(conthost1 - 1) + "." + Convert.ToString(conthost2 + 255) + "." + Convert.ToString((conthost3 + 255) - 1);
                }
                //************************PARA  CLASSE B *************************
                else if (txtClasses.Text.Equals("B"))
                {
                    ipRed1 = txtip1.Text + "." + txtip2.Text + "." + Convert.ToString(conthost2) + "." + Convert.ToString(conthost3 + 1);
                    conthost2 = conthost2 + numSubred;
                    //contultimo = contultimo + numSubred;
                    ipRed2 = txtip1.Text + "." + txtip2.Text + "." + Convert.ToString(conthost2 - 2) + "." + Convert.ToString((conthost3 + 255) - 1);
                }
                //************************PARA CLASSE C *************************
                else if (txtClasses.Text.Equals("C"))
                {
                    ipRed1 = txtip1.Text + "." + txtip2.Text + "." + txtip3.Text + "." + Convert.ToString(conthost3 + 1);
                    conthost3 = conthost3 + numSubred;
                    ipRed2 = txtip1.Text + "." + txtip2.Text + "." + txtip3.Text + "." + Convert.ToString(conthost3 - 2);
                }

                String ipalcancoRed = ipRed1 + " -- " + ipRed2;
                dgvtabelaSubrede.Rows.Add();
                dgvtabelaSubrede.Rows[i].Cells[2].Value = ipalcancoRed;

            }

        }

        //************************** LISTANDO OS DADOS ID_BROADCAST ****************************

        public void listarId_Broadcast(Double NumSubred, Double numSubred)
        {
            conthost1 = 0;
            conthost2 = 0;
            conthost3 = 0;
            for (int i = 0; i < NumSubred; i++)
            {
                //************************PARA CLASSE A *************************
                if (txtClasses.Text.Equals("A"))
                {
                    conthost1 = conthost1 + numSubred;
                    ipRed = txtip1.Text + "." + Convert.ToString(conthost1 - 1) + "." + Convert.ToString(conthost3 + 255) + "." + Convert.ToString(conthost3 + 255);

                    binarioip1 = txtip1.Text;
                    binarioip2 = Convert.ToString(conthost1 -1);
                    binarioip3 = Convert.ToString(conthost2 + 255);
                    binarioip4 = Convert.ToString(conthost3 + 255);


                    binarioip1 = Conversao.DecimalParaBinario(binarioip1);
                    binarioip2 = Conversao.DecimalParaBinario(binarioip2);
                    binarioip3 = Conversao.DecimalParaBinario(binarioip3);
                    binarioip4 = Conversao.DecimalParaBinario(binarioip4);
                    valorBinario = binarioip1 + "." + binarioip2 + "." + binarioip3 + "." + binarioip4;

                }
                //************************PARA CLASSE B *************************
                else if (txtClasses.Text.Equals("B"))
                {
                    conthost2 = conthost2 + numSubred;
                    ipRed = txtip1.Text + "." + txtip2.Text + "." + Convert.ToString(conthost2 - 1) + "." + Convert.ToString(conthost3 + 255);
                }
                //************************PARA CLASSE C *************************
                else if (txtClasses.Text.Equals("C"))
                {
                    conthost3 = conthost3 + numSubred;
                    ipRed = txtip1.Text + "." + txtip2.Text + "." + txtip3.Text + "." + Convert.ToString(conthost3 - 1);
                }
                dgvtabelaSubrede.Rows.Add();
                dgvtabelaSubrede.Rows[i].Cells[3].Value = ipRed;
                dgvtabelaSubrede.Rows[i].Cells[5].Value = valorBinario;
                

            }
        }
        public void pintarSubred(double subred)
        {
            for (int i = 0; i < subred; i++)
            {
                //dgvtabelaSubrede.Rows[i + 1].DefaultCellStyle.Equals(BackColor = Color.Red);
                dgvtabelaSubrede.Rows[i + 1].DefaultCellStyle.BackColor = Color.Orange;
               //dgvtabelaSubrede.RowsDefaultCellStyle.BackColor = Color.Blue;
            }
        }

        public void listarNinarioIP(Double numSubred)
        {
            //for ()
            //{
            //    binario = txtip1.Text + Convert.ToString(conthost1) + Convert.ToString(conthost2) + Convert.ToString(conthost3);
            //    valorBinario = Conversao.DecimalParaBinario(binario);
            //    conthost1 = conthost1 + numSubred;
            //}


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
