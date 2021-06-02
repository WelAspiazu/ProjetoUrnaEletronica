using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica
{
    public partial class Form1 : Form
    {
        int cont, vtAdilson, vtAle, vtFabio, vtRodrigo, vtalfredinho;
        int n1, n2, n3, n4, n5;

        private void btn_1_Click(object sender, EventArgs e)
        {
            cont = cont + 1;
            if (cont == 1)
            {
                n1 = 1;
                txtb_Num1.Text = n1.ToString();
            }
            else if (cont == 2)
            {
                n2 = 1;
                txtb_Num2.Text = n2.ToString();
            }
            else if (cont == 3)
            {
                n3 = 1;
                txtb_Num3.Text = n3.ToString();
            }
            else if (cont == 4)
            {
                n4 = 1;
                txtb_Num4.Text = n4.ToString();
            }
            else if (cont == 5)
            {
                n5 = 1;
                txtb_Num5.Text = n5.ToString();
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            cont = cont + 1;
            if (cont == 1)
            {
                n1 = 2;
                txtb_Num1.Text = n1.ToString();
            }
            else if (cont == 2)
            {
                n2 = 2;
                txtb_Num2.Text = n2.ToString();
            }
            else if (cont == 3)
            {
                n3 = 2;
                txtb_Num3.Text = n3.ToString();
            }
            else if (cont == 4)
            {
                n4 = 2;
                txtb_Num4.Text = n4.ToString();
            }
            else if (cont == 5)
            {
                n5 = 2;
                txtb_Num5.Text = n5.ToString();
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            cont = cont + 1;
            if (cont == 1)
            {
                n1 = 3;
                txtb_Num1.Text = n1.ToString();
            }
            else if (cont == 2)
            {
                n2 = 3;
                txtb_Num2.Text = n2.ToString();
            }
            else if (cont == 3)
            {
                n3 = 3;
                txtb_Num3.Text = n3.ToString();
            }
            else if (cont == 4)
            {
                n4 = 3;
                txtb_Num4.Text = n4.ToString();
            }
            else if (cont == 5)
            {
                n5 = 3;
                txtb_Num5.Text = n5.ToString();
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            cont = cont + 1;
            if (cont == 1)
            {
                n1 = 4;
                txtb_Num1.Text = n1.ToString();
            }
            else if (cont == 2)
            {
                n2 = 4;
                txtb_Num2.Text = n2.ToString();
            }
            else if (cont == 3)
            {
                n3 = 4;
                txtb_Num3.Text = n3.ToString();
            }
            else if (cont == 4)
            {
                n4 = 4;
                txtb_Num4.Text = n4.ToString();
            }
            else if (cont == 5)
            {
                n5 = 4;
                txtb_Num5.Text = n5.ToString();
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            cont = cont + 1;
            if (cont == 1)
            {
                n1 = 5;
                txtb_Num1.Text = n1.ToString();
            }
            else if (cont == 2)
            {
                n2 = 5;
                txtb_Num2.Text = n2.ToString();
            }
            else if (cont == 3)
            {
                n3 = 5;
                txtb_Num3.Text = n3.ToString();
            }
            else if (cont == 4)
            {
                n4 = 5;
                txtb_Num4.Text = n4.ToString();
            }
            else if (cont == 5)
            {
                n5 = 5;
                txtb_Num5.Text = n5.ToString();
            }

        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            cont = cont + 1;
            if (cont == 1)
            {
                n1 = 6;
                txtb_Num1.Text = n1.ToString();
            }
            else if (cont == 2)
            {
                n2 = 6;
                txtb_Num2.Text = n2.ToString();
            }
            else if (cont == 3)
            {
                n3 = 6;
                txtb_Num3.Text = n3.ToString();
            }
            else if (cont == 4)
            {
                n4 = 6;
                txtb_Num4.Text = n4.ToString();
            }
            else if (cont == 5)
            {
                n5 = 6;
                txtb_Num5.Text = n5.ToString();
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            cont = cont + 1;
            if (cont == 1)
            {
                n1 = 7;
                txtb_Num1.Text = n1.ToString();
            }
            else if (cont == 2)
            {
                n2 = 7;
                txtb_Num2.Text = n2.ToString();
            }
            else if (cont == 3)
            {
                n3 = 7;
                txtb_Num3.Text = n3.ToString();
            }
            else if (cont == 4)
            {
                n4 = 7;
                txtb_Num4.Text = n4.ToString();
            }
            else if (cont == 5)
            {
                n5 = 7;
                txtb_Num5.Text = n5.ToString();
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            cont = cont + 1;
            if (cont == 1)
            {
                n1 = 8;
                txtb_Num1.Text = n1.ToString();
            }
            else if (cont == 2)
            {
                n2 = 8;
                txtb_Num2.Text = n2.ToString();
            }
            else if (cont == 3)
            {
                n3 = 8;
                txtb_Num3.Text = n3.ToString();
            }
            else if (cont == 4)
            {
                n4 = 8;
                txtb_Num4.Text = n4.ToString();
            }
            else if (cont == 5)
            {
                n5 = 8;
                txtb_Num5.Text = n5.ToString();
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            cont = cont + 1;
            if (cont == 1)
            {
                n1 = 9;
                txtb_Num1.Text = n1.ToString();
            }
            else if (cont == 2)
            {
                n2 = 9;
                txtb_Num2.Text = n2.ToString();
            }
            else if (cont == 3)
            {
                n3 = 9;
                txtb_Num3.Text = n3.ToString();
            }
            else if (cont == 4)
            {
                n4 = 9;
                txtb_Num4.Text = n4.ToString();
            }
            else if (cont == 5)
            {
                n5 = 9;
                txtb_Num5.Text = n5.ToString();
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            cont = cont + 1;
            if (cont == 1)
            {
                n1 = 0;
                txtb_Num1.Text = n1.ToString();
            }
            else if (cont == 2)
            {
                n2 = 0;
                txtb_Num2.Text = n2.ToString();
            }
            else if (cont == 3)
            {
                n3 = 0;
                txtb_Num3.Text = n3.ToString();
            }
            else if (cont == 4)
            {
                n4 = 0;
                txtb_Num4.Text = n4.ToString();
            }
            else if (cont == 5)
            {
                n5 = 0;
                txtb_Num5.Text = n5.ToString();
            }
        }

        private void btn_Confirma_Click(object sender, EventArgs e)
        {
            if (txtb_Num1.Text == "" || txtb_Num2.Text == "" || txtb_Num3.Text == "" || txtb_Num4.Text == "" || txtb_Num5.Text == "")
            {
                MessageBox.Show("INFORME O NÚMERO DO CANDIDATO!");
            }
            else if (txtb_Num1.Text == "2" && txtb_Num3.Text == "4" && txtb_Num5.Text == "0")
            {
                lb1__.Text = "ADILSON AMADEU";
                lb2__.Text = "DEM";
                pb_Imagem.Image = Properties.Resources.amadeu;
                vtAdilson += 1;
                MessageBox.Show("FIM");

                string connetionString = null;
                MySqlConnection cnn;
                connetionString = "server =127.0.0.1; Database =test;User=test; Password = ";
                //connetionString = "server=127.0.0.1;database=test;User Id=test;Password=;";
                cnn = new MySqlConnection(connetionString);
                try
                {
                    cnn.Open();
                    MessageBox.Show("Connection Open ! ");
                    string commandStr = "INSERT INTO candidato (nome,partido)" +
                                "VALUES('" + lb1__.Text + "','" + lb2__.Text + "')";
                    MessageBox.Show(commandStr);
                    MySqlCommand command = new MySqlCommand(commandStr, cnn);

                    int value = command.ExecuteNonQuery();
                    Console.WriteLine("ExecuteNonQuery : " + value);
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! " + ex.Message);
                }
            }
            else if (txtb_Num1.Text == "1" && txtb_Num3.Text == "1" && txtb_Num5.Text == "1")
            {
                lb1__.Text = "ALESANDRO GUEDES";
                lb2__.Text = "PT";
                pb_Imagem.Image = Properties.Resources.guedes;
                vtAle += 1;
                MessageBox.Show("FIM");

                string connetionString = null;
                MySqlConnection cnn;
                connetionString = "server =127.0.0.1; Database =test;User=test; Password = ";
                //connetionString = "server=127.0.0.1;database=test;User Id=test;Password=;";
                cnn = new MySqlConnection(connetionString);
                try
                {
                    cnn.Open();
                    MessageBox.Show("Connection Open ! ");
                    string commandStr = "INSERT INTO candidato (nome,partido)" +
                                "VALUES('" + lb1__.Text + "','" + lb2__.Text + "')";
                    MessageBox.Show(commandStr);
                    MySqlCommand command = new MySqlCommand(commandStr, cnn);

                    int value = command.ExecuteNonQuery();
                    Console.WriteLine("ExecuteNonQuery : " + value);
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! " + ex.Message);
                }
            }
            else if (txtb_Num1.Text == "9" && txtb_Num3.Text == "9" && txtb_Num5.Text == "2")
            {
                lb1__.Text = "FÁBIO RIVA";
                lb2__.Text = "PSDB";
                pb_Imagem.Image = Properties.Resources.riva;
                vtFabio += 1;
                MessageBox.Show("FIM");

                string connetionString = null;
                MySqlConnection cnn;
                connetionString = "server =127.0.0.1; Database =test;User=test; Password = ";
                //connetionString = "server=127.0.0.1;database=test;User Id=test;Password=;";
                cnn = new MySqlConnection(connetionString);
                try
                {
                    cnn.Open();
                    MessageBox.Show("Connection Open ! ");
                    string commandStr = "INSERT INTO candidato (nome,partido)" +
                                "VALUES('" + lb1__.Text + "','" + lb2__.Text + "')";
                    MessageBox.Show(commandStr);
                    MySqlCommand command = new MySqlCommand(commandStr, cnn);

                    int value = command.ExecuteNonQuery();
                    Console.WriteLine("ExecuteNonQuery : " + value);
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! " + ex.Message);
                }
            }
            else if (txtb_Num1.Text == "4" && txtb_Num3.Text == "8" && txtb_Num5.Text == "3")
            {
                lb1__.Text = "RODRIGO GOULART";
                lb2__.Text = "PSD";
                pb_Imagem.Image = Properties.Resources.rodrigo;
                vtRodrigo += 1;
                MessageBox.Show("FIM");

                string connetionString = null;
                MySqlConnection cnn;
                connetionString = "server =127.0.0.1; Database =test;User=test; Password = ";
                //connetionString = "server=127.0.0.1;database=test;User Id=test;Password=;";
                cnn = new MySqlConnection(connetionString);
                try
                {
                    cnn.Open();
                    MessageBox.Show("Connection Open ! ");
                    string commandStr = "INSERT INTO candidato (nome,partido)" +
                                "VALUES('" + lb1__.Text + "','" + lb2__.Text + "')";
                    MessageBox.Show(commandStr);
                    MySqlCommand command = new MySqlCommand(commandStr, cnn);

                    int value = command.ExecuteNonQuery();
                    Console.WriteLine("ExecuteNonQuery : " + value);
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! " + ex.Message);
                }
            }
            else if (txtb_Num1.Text == "2" && txtb_Num3.Text == "0" && txtb_Num5.Text == "4")
            {
                lb1__.Text = "ALFREDINHO";
                lb2__.Text = "PT";
                pb_Imagem.Image = Properties.Resources.alfredinho;
                vtalfredinho += 1;
                MessageBox.Show("FIM");

                string connetionString = null;
                MySqlConnection cnn;
                connetionString = "server =127.0.0.1; Database =test;User=test; Password = ";
                //connetionString = "server=127.0.0.1;database=test;User Id=test;Password=;";
                cnn = new MySqlConnection(connetionString);
                try
                {
                    cnn.Open();
                    MessageBox.Show("Connection Open ! ");
                    string commandStr = "INSERT INTO candidato (nome,partido)" +
                                "VALUES('" + lb1__.Text + "','" + lb2__.Text + "')";
                    MessageBox.Show(commandStr);
                    MySqlCommand command = new MySqlCommand(commandStr, cnn);

                    int value = command.ExecuteNonQuery();
                    Console.WriteLine("ExecuteNonQuery : " + value);
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("VERIFIQUE O NUMERO DO VEREADOR!", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }

        private void btn_candidatos_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
            formulario2 = new Thread(newform2); // criar uma nova tread para o formulario2
            formulario2.SetApartmentState(ApartmentState.STA);  // indico que será uma Single thread
            formulario2.Start();  // Start
        }
        
        private void newform2(Object obj)
        {
            Application.Run(new Form2(vtAdilson, vtAle, vtFabio, vtRodrigo, vtalfredinho));
        }
    
        private void btn_Corrige_Click(object sender, EventArgs e)
        {
            txtb_Num1.Clear();
            txtb_Num2.Clear();
            txtb_Num3.Clear();
            txtb_Num4.Clear();
            txtb_Num5.Clear();
            txtb_Num1.Focus();
            cont = 0;
            lb1__.Text = "____________________________";
            lb2__.Text = "____________________________";
            pb_Imagem.Image = null;


        }

        private void btn_Branco_Click(object sender, EventArgs e)
        {
            lb1__.Text = "VOTO EM BRNACO";
        }

        Thread formulario2;

        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cont = 0;
        }
        
    }
}
