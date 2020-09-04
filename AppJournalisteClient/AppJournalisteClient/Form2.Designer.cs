namespace AppJournalisteClient
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titreLbl = new System.Windows.Forms.Label();
            this.texteLbl = new System.Windows.Forms.Label();
            this.titreTextBox = new System.Windows.Forms.TextBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.UploadImgBtn = new System.Windows.Forms.Button();
            this.AddArticleBtn = new System.Windows.Forms.Button();
            this.nbreArticleLbl = new System.Windows.Forms.Label();
            this.CompteurLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Texte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // titreLbl
            // 
            this.titreLbl.AutoSize = true;
            this.titreLbl.Location = new System.Drawing.Point(24, 39);
            this.titreLbl.Name = "titreLbl";
            this.titreLbl.Size = new System.Drawing.Size(28, 13);
            this.titreLbl.TabIndex = 0;
            this.titreLbl.Text = "Titre";
            // 
            // texteLbl
            // 
            this.texteLbl.AutoSize = true;
            this.texteLbl.Location = new System.Drawing.Point(24, 117);
            this.texteLbl.Name = "texteLbl";
            this.texteLbl.Size = new System.Drawing.Size(34, 13);
            this.texteLbl.TabIndex = 1;
            this.texteLbl.Text = "Texte";
            // 
            // titreTextBox
            // 
            this.titreTextBox.Location = new System.Drawing.Point(77, 39);
            this.titreTextBox.Name = "titreTextBox";
            this.titreTextBox.Size = new System.Drawing.Size(389, 20);
            this.titreTextBox.TabIndex = 2;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(77, 82);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(389, 115);
            this.TextBox.TabIndex = 3;
            // 
            // UploadImgBtn
            // 
            this.UploadImgBtn.Location = new System.Drawing.Point(521, 204);
            this.UploadImgBtn.Name = "UploadImgBtn";
            this.UploadImgBtn.Size = new System.Drawing.Size(244, 23);
            this.UploadImgBtn.TabIndex = 5;
            this.UploadImgBtn.Text = "Charger Image";
            this.UploadImgBtn.UseVisualStyleBackColor = true;
            this.UploadImgBtn.Click += new System.EventHandler(this.UploadImgBtn_Click);
            // 
            // AddArticleBtn
            // 
            this.AddArticleBtn.Location = new System.Drawing.Point(304, 204);
            this.AddArticleBtn.Name = "AddArticleBtn";
            this.AddArticleBtn.Size = new System.Drawing.Size(162, 23);
            this.AddArticleBtn.TabIndex = 6;
            this.AddArticleBtn.Text = "Ajouter Article";
            this.AddArticleBtn.UseVisualStyleBackColor = true;
            this.AddArticleBtn.Click += new System.EventHandler(this.AddArticleBtn_Click);
            // 
            // nbreArticleLbl
            // 
            this.nbreArticleLbl.AutoSize = true;
            this.nbreArticleLbl.Location = new System.Drawing.Point(74, 209);
            this.nbreArticleLbl.Name = "nbreArticleLbl";
            this.nbreArticleLbl.Size = new System.Drawing.Size(131, 13);
            this.nbreArticleLbl.TabIndex = 7;
            this.nbreArticleLbl.Text = "Nombre d\'articles ajoutes :";
            // 
            // CompteurLbl
            // 
            this.CompteurLbl.AutoSize = true;
            this.CompteurLbl.Location = new System.Drawing.Point(212, 209);
            this.CompteurLbl.Name = "CompteurLbl";
            this.CompteurLbl.Size = new System.Drawing.Size(0, 13);
            this.CompteurLbl.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(493, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 161);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titre,
            this.Texte,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(77, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(644, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.Sorted += new System.EventHandler(this.AddArticleBtn_Click);
            // 
            // Titre
            // 
            this.Titre.HeaderText = "Titre";
            this.Titre.Name = "Titre";
            this.Titre.ReadOnly = true;
            this.Titre.Width = 150;
            // 
            // Texte
            // 
            this.Texte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Texte.HeaderText = "Texte";
            this.Texte.Name = "Texte";
            this.Texte.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CompteurLbl);
            this.Controls.Add(this.nbreArticleLbl);
            this.Controls.Add(this.AddArticleBtn);
            this.Controls.Add(this.UploadImgBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.titreTextBox);
            this.Controls.Add(this.texteLbl);
            this.Controls.Add(this.titreLbl);
            this.Name = "Form2";
            this.Text = "Gestion d\'articles";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titreLbl;
        private System.Windows.Forms.Label texteLbl;
        private System.Windows.Forms.TextBox titreTextBox;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UploadImgBtn;
        private System.Windows.Forms.Button AddArticleBtn;
        private System.Windows.Forms.Label nbreArticleLbl;
        private System.Windows.Forms.Label CompteurLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Texte;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}