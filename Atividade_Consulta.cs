using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(150, 150);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightBlue);
                using (Font font = new Font("Arial", 10, FontStyle.Bold))
                {
                    g.DrawString("Foto Cliente", font, Brushes.Black, new PointF(30, 65));
                }
            }
            pictureBox.Image = bmp;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            txtCodigo.Text = "001";
            txtNome.Text = "Maria Oliveira";
            txtRG.Text = "12.345.678-9";
            txtCPF.Text = "123.456.789-00";
            txtTelResidencial.Text = "(11) 3333-4444";
            txtTelCelular.Text = "(11) 98888-7777";
            rdbFeminino.Checked = true;

            txtCEP.Text = "01001-000";
            txtLogradouro.Text = "Praça da Sé";
            txtNumero.Text = "100";
            txtBairro.Text = "Centro";
            txtCidade.Text = "São Paulo";
            txtEstado.Text = "SP";

            chkEmail.Checked = true;
            txtEmail.Text = "maria.oliveira@email.com";

            chkFacebook.Checked = true;
            txtFacebook.Text = "facebook.com/maria.oliveira";

            chkTwitter.Checked = false;
            txtTwitter.Clear();


            button2_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Nenhum nome está no cadastro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            txtCodigo.Clear();
            txtNome.Clear();
            txtRG.Clear();
            txtCPF.Clear();
            txtTelResidencial.Clear();
            txtTelCelular.Clear();

            rdbMasculino.Checked = false;
            rdbFeminino.Checked = false;

            txtCEP.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();

            chkEmail.Checked = false;
            chkFacebook.Checked = false;
            chkTwitter.Checked = false;

            txtEmail.Clear();
            txtFacebook.Clear();
            txtTwitter.Clear();

            button2_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtEmail.Enabled = chkEmail.Checked;
            if (!chkEmail.Checked) txtEmail.Clear();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            txtFacebook.Enabled = chkFacebook.Checked;
            if (!chkFacebook.Checked) txtFacebook.Clear();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            txtTwitter.Enabled = chkTwitter.Checked;
            if (!chkTwitter.Checked) txtTwitter.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
                pictureBox.Image = null;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string sexo = rdbMasculino.Checked ? "Masculino" : (rdbFeminino.Checked ? "Feminino" : "Não informado");

            // Exibe todas as informações num MessageBox[cite: 3]
            string info = $"DADOS PESSOAIS:\n" +
                          $"Código: {txtCodigo.Text}\n" +
                          $"Nome: {txtNome.Text}\n" +
                          $"R.G.: {txtRG.Text}\n" +
                          $"C.P.F.: {txtCPF.Text}\n" +
                          $"Tel. Residencial: {txtTelResidencial.Text}\n" +
                          $"Tel. Celular: {txtTelCelular.Text}\n" +
                          $"Sexo: {sexo}\n\n" +
                          $"ENDEREÇO:\n" +
                          $"CEP: {txtCEP.Text}\n" +
                          $"Logradouro: {txtLogradouro.Text}, Nº: {txtNumero.Text}\n" +
                          $"Bairro: {txtBairro.Text}\n" +
                          $"Cidade: {txtCidade.Text} - {txtEstado.Text}\n\n" +
                          $"DADOS EXTRAS:\n" +
                          $"E-Mail: {(chkEmail.Checked ? txtEmail.Text : "N/A")}\n" +
                          $"Facebook: {(chkFacebook.Checked ? txtFacebook.Text : "N/A")}\n" +
                          $"Twitter: {(chkTwitter.Checked ? txtTwitter.Text : "N/A")}";

            MessageBox.Show(info, "Informações Cadastradas", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

    }

    

    

