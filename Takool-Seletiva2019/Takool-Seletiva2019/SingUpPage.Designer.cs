namespace Takool_Seletiva2019
{
    partial class SingUpPage
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
            System.Windows.Forms.PictureBox pictureCredential;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingUpPage));
            this.tittlePage = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textMail = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelCredential = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSelectCredential = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            pictureCredential = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureCredential)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureCredential
            // 
            pictureCredential.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            pictureCredential.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureCredential.BackgroundImage")));
            pictureCredential.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureCredential.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureCredential.InitialImage")));
            pictureCredential.Location = new System.Drawing.Point(289, 251);
            pictureCredential.Name = "pictureCredential";
            pictureCredential.Size = new System.Drawing.Size(100, 87);
            pictureCredential.TabIndex = 5;
            pictureCredential.TabStop = false;
            // 
            // tittlePage
            // 
            this.tittlePage.AutoSize = true;
            this.tittlePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.tittlePage.Location = new System.Drawing.Point(281, 25);
            this.tittlePage.Name = "tittlePage";
            this.tittlePage.Size = new System.Drawing.Size(226, 44);
            this.tittlePage.TabIndex = 1;
            this.tittlePage.Text = "Cadastre-se";
            this.tittlePage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelName.Location = new System.Drawing.Point(238, 90);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Nome";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(289, 89);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(253, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPhone.Location = new System.Drawing.Point(219, 142);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(64, 17);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Telefone";
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(289, 115);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(253, 20);
            this.textMail.TabIndex = 3;
            this.textMail.Leave += new System.EventHandler(this.textMail_Leave);
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMail.Location = new System.Drawing.Point(238, 116);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(42, 17);
            this.labelMail.TabIndex = 2;
            this.labelMail.Text = "Email";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(289, 141);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(253, 20);
            this.textBoxPhone.TabIndex = 3;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUser.Location = new System.Drawing.Point(226, 167);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(57, 17);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "Usuário";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(289, 167);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(253, 20);
            this.textBoxUser.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(187, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data de nasc.";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(289, 194);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // labelCredential
            // 
            this.labelCredential.AutoSize = true;
            this.labelCredential.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCredential.Location = new System.Drawing.Point(205, 288);
            this.labelCredential.Name = "labelCredential";
            this.labelCredential.Size = new System.Drawing.Size(75, 17);
            this.labelCredential.TabIndex = 2;
            this.labelCredential.Text = "Credencial";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(287, 401);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(253, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSelectCredential
            // 
            this.btnSelectCredential.Location = new System.Drawing.Point(395, 261);
            this.btnSelectCredential.Name = "btnSelectCredential";
            this.btnSelectCredential.Size = new System.Drawing.Size(112, 25);
            this.btnSelectCredential.TabIndex = 6;
            this.btnSelectCredential.Text = "Selecione";
            this.btnSelectCredential.UseVisualStyleBackColor = true;
            this.btnSelectCredential.Click += new System.EventHandler(this.btnSelectCredential_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(548, 167);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(69, 43);
            this.btnUser.TabIndex = 6;
            this.btnUser.Text = "Gerar aleatório";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // SingUpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnSelectCredential);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(pictureCredential);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelCredential);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.textMail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.tittlePage);
            this.Name = "SingUpPage";
            this.Text = "SingUpPage";
            ((System.ComponentModel.ISupportInitialize)(pictureCredential)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittlePage;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelCredential;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSelectCredential;
        private System.Windows.Forms.Button btnUser;
    }
}