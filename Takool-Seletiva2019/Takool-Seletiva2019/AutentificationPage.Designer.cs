namespace Takool_Seletiva2019
{
    partial class AutentificationPage
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
            this.pictureCredential = new System.Windows.Forms.PictureBox();
            this.tittlePage = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkKeyboard = new System.Windows.Forms.LinkLabel();
            this.labelCredential = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.linkSingUp = new System.Windows.Forms.LinkLabel();
            this.labelCapsLock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCredential)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureCredential
            // 
            this.pictureCredential.Image = global::Takool_Seletiva2019.Properties.Resources.user;
            this.pictureCredential.InitialImage = null;
            this.pictureCredential.Location = new System.Drawing.Point(339, 229);
            this.pictureCredential.Name = "pictureCredential";
            this.pictureCredential.Size = new System.Drawing.Size(110, 100);
            this.pictureCredential.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureCredential.TabIndex = 4;
            this.pictureCredential.TabStop = false;
            // 
            // tittlePage
            // 
            this.tittlePage.AutoSize = true;
            this.tittlePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.tittlePage.Location = new System.Drawing.Point(207, 36);
            this.tittlePage.Name = "tittlePage";
            this.tittlePage.Size = new System.Drawing.Size(378, 44);
            this.tittlePage.TabIndex = 0;
            this.tittlePage.Text = "Bem-vindo ao Takool";
            this.tittlePage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(371, 126);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(43, 13);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "Usuário";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.Leave += new System.EventHandler(this.searchCredential);
            // 
            // linkKeyboard
            // 
            this.linkKeyboard.AutoSize = true;
            this.linkKeyboard.Location = new System.Drawing.Point(525, 151);
            this.linkKeyboard.Name = "linkKeyboard";
            this.linkKeyboard.Size = new System.Drawing.Size(78, 13);
            this.linkKeyboard.TabIndex = 3;
            this.linkKeyboard.TabStop = true;
            this.linkKeyboard.Text = "Teclado Virtual";
            this.linkKeyboard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkKeyboard_LinkClicked);
            // 
            // labelCredential
            // 
            this.labelCredential.AutoSize = true;
            this.labelCredential.Location = new System.Drawing.Point(366, 213);
            this.labelCredential.Name = "labelCredential";
            this.labelCredential.Size = new System.Drawing.Size(57, 13);
            this.labelCredential.TabIndex = 1;
            this.labelCredential.Text = "Credencial";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(316, 341);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(159, 40);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Entrar";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // linkSingUp
            // 
            this.linkSingUp.AutoSize = true;
            this.linkSingUp.Location = new System.Drawing.Point(366, 419);
            this.linkSingUp.Name = "linkSingUp";
            this.linkSingUp.Size = new System.Drawing.Size(63, 13);
            this.linkSingUp.TabIndex = 3;
            this.linkSingUp.TabStop = true;
            this.linkSingUp.Text = "Cadastre-se";
            this.linkSingUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSingUp_LinkClicked);
            // 
            // labelCapsLock
            // 
            this.labelCapsLock.AutoSize = true;
            this.labelCapsLock.ForeColor = System.Drawing.Color.Red;
            this.labelCapsLock.Location = new System.Drawing.Point(281, 167);
            this.labelCapsLock.Name = "labelCapsLock";
            this.labelCapsLock.Size = new System.Drawing.Size(143, 13);
            this.labelCapsLock.TabIndex = 6;
            this.labelCapsLock.Text = "O CAPSLOCK ESTÁ ATIVO!";
            this.labelCapsLock.Visible = false;
            // 
            // AutentificationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCapsLock);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.pictureCredential);
            this.Controls.Add(this.linkSingUp);
            this.Controls.Add(this.linkKeyboard);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelCredential);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.tittlePage);
            this.Name = "AutentificationPage";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCredential)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittlePage;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkKeyboard;
        private System.Windows.Forms.Label labelCredential;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.LinkLabel linkSingUp;
        private System.Windows.Forms.Label labelCapsLock;
        private System.Windows.Forms.PictureBox pictureCredential;
    }
}