namespace AppJournalisteClient
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.nomLbl = new System.Windows.Forms.Label();
            this.motDePassLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ValidationBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomLbl
            // 
            this.nomLbl.AutoSize = true;
            this.nomLbl.Location = new System.Drawing.Point(181, 98);
            this.nomLbl.Name = "nomLbl";
            this.nomLbl.Size = new System.Drawing.Size(38, 13);
            this.nomLbl.TabIndex = 0;
            this.nomLbl.Text = "Nom : ";
            this.nomLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // motDePassLbl
            // 
            this.motDePassLbl.AutoSize = true;
            this.motDePassLbl.Location = new System.Drawing.Point(172, 152);
            this.motDePassLbl.Name = "motDePassLbl";
            this.motDePassLbl.Size = new System.Drawing.Size(77, 13);
            this.motDePassLbl.TabIndex = 1;
            this.motDePassLbl.Text = "Mot de passe :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(305, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(305, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(196, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // ValidationBtn
            // 
            this.ValidationBtn.Location = new System.Drawing.Point(426, 178);
            this.ValidationBtn.Name = "ValidationBtn";
            this.ValidationBtn.Size = new System.Drawing.Size(75, 23);
            this.ValidationBtn.TabIndex = 4;
            this.ValidationBtn.Text = "Valider";
            this.ValidationBtn.UseVisualStyleBackColor = true;
            this.ValidationBtn.Click += new System.EventHandler(this.ValidationBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppJournalisteClient.Properties.Resources.AuthentificationIcon1;
            this.pictureBox1.Location = new System.Drawing.Point(2, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(273, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom : mohamed , mot de passe : abcd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(273, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom : youssef, mot de passe : efgh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(68, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(447, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Acces aux journalistes : Ajout,Suppression des articles";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 213);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ValidationBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.motDePassLbl);
            this.Controls.Add(this.nomLbl);
            this.Name = "Form1";
            this.Text = "Authentification";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomLbl;
        private System.Windows.Forms.Label motDePassLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ValidationBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

