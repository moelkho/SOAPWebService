using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppJournalisteClient
{
    public partial class Form2 : Form

    {
        int i = 1;
        string picloc;

        public Form2()
        {
            InitializeComponent();
        }

        private void AddArticleBtn_Click(object sender, EventArgs e)
        {
            if (titreTextBox.Text == "" || TextBox.Text == "")
            {
                MessageBox.Show("Les 2 champs sont obligatoires");
                return;
            }

            ServiceReference1.GestionArticleWebServiceClient service = new ServiceReference1.GestionArticleWebServiceClient();
            ServiceReference1.article a = new ServiceReference1.article();
            a.title = titreTextBox.Text;
            a.texte = TextBox.Text;
            FileStream fstream = new FileStream(picloc, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            a.image = br.ReadBytes((int)fstream.Length);


            if (service.AjouterArticle(a))
            {
                CompteurLbl.Text = i.ToString();

                MessageBox.Show("Article ajoute avec succès");

            

                
               

                titreTextBox.Text = "";
                TextBox.Text = "";
                pictureBox1.Image = null;
                i++;
            }
            else
            {
                MessageBox.Show("Votre demande a été refusée");
            }


            MySqlConnection cnx = new MySqlConnection();
            cnx.ConnectionString = "Server=localhost; Uid=user;Pwd=1234; Database=articlesdatabase";
            cnx.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT TITRE,TEXTE FROM article");
            cmd.Connection = cnx;
            MySqlDataReader dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr["TITRE"];
                dataGridView1.Rows[n].Cells[1].Value = dr["TEXTE"];

            }

            cnx.Close();


        }

        private void UploadImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picloc = dlg.FileName.ToString();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                pictureBox1.Image = Bitmap.FromFile(dlg.FileName);
              


            }
        }

       

        private void ajouterArticleResponseBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Voulez vous supprimer cet article ?", "message",
                  MessageBoxButtons.YesNo, MessageBoxIcon.
                  Question) == DialogResult.Yes)
                {

                    ServiceReference1.GestionArticleWebServiceClient service2 = new ServiceReference1.GestionArticleWebServiceClient();

                    if (service2.SupprimerArticle(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()))
                    {
                        MySqlConnection cnx = new MySqlConnection();
                        cnx.ConnectionString = "Server=localhost; Uid=user;Pwd=1234; Database=articlesdatabase";
                        cnx.Open();
                        MySqlCommand cmd = new MySqlCommand("SELECT TITRE,TEXTE FROM article");
                        cmd.Connection = cnx;
                        MySqlDataReader dr = cmd.ExecuteReader();
                        dataGridView1.Rows.Clear();
                        while (dr.Read())
                        {
                            int n = dataGridView1.Rows.Add();
                            dataGridView1.Rows[n].Cells[0].Value = dr["TITRE"];
                            dataGridView1.Rows[n].Cells[1].Value = dr["TEXTE"];

                        }

                        cnx.Close();
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
