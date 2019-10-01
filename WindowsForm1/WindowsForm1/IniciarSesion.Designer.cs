namespace WindowsFormsApplication1
{
    partial class IniciarSesion
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
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.contraseñaBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iniciarsesionBtn = new System.Windows.Forms.Button();
            this.registrarseBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RecordatorioButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(576, 277);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(100, 20);
            this.nombreBox.TabIndex = 0;
            // 
            // contraseñaBox
            // 
            this.contraseñaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaBox.Location = new System.Drawing.Point(576, 321);
            this.contraseñaBox.Name = "contraseñaBox";
            this.contraseñaBox.PasswordChar = '*';
            this.contraseñaBox.Size = new System.Drawing.Size(100, 20);
            this.contraseñaBox.TabIndex = 1;
            this.contraseñaBox.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(580, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(593, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // iniciarsesionBtn
            // 
            this.iniciarsesionBtn.BackColor = System.Drawing.Color.White;
            this.iniciarsesionBtn.Location = new System.Drawing.Point(714, 277);
            this.iniciarsesionBtn.Name = "iniciarsesionBtn";
            this.iniciarsesionBtn.Size = new System.Drawing.Size(100, 22);
            this.iniciarsesionBtn.TabIndex = 4;
            this.iniciarsesionBtn.Text = "Iniciar sesión";
            this.iniciarsesionBtn.UseVisualStyleBackColor = false;
            this.iniciarsesionBtn.Click += new System.EventHandler(this.iniciarsesionBtn_Click);
            // 
            // registrarseBtn
            // 
            this.registrarseBtn.BackColor = System.Drawing.Color.White;
            this.registrarseBtn.Location = new System.Drawing.Point(714, 321);
            this.registrarseBtn.Name = "registrarseBtn";
            this.registrarseBtn.Size = new System.Drawing.Size(100, 22);
            this.registrarseBtn.TabIndex = 5;
            this.registrarseBtn.Text = "Registrarse";
            this.registrarseBtn.UseVisualStyleBackColor = false;
            this.registrarseBtn.Click += new System.EventHandler(this.registrarseBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "VERSION 3.0 SIMULADOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "© 2017 Grupo M2 Info 2 ALL RIGHTS RESERVED";
            // 
            // RecordatorioButton
            // 
            this.RecordatorioButton.Location = new System.Drawing.Point(626, 349);
            this.RecordatorioButton.Name = "RecordatorioButton";
            this.RecordatorioButton.Size = new System.Drawing.Size(133, 23);
            this.RecordatorioButton.TabIndex = 8;
            this.RecordatorioButton.Text = "Recordar Contraseña";
            this.RecordatorioButton.UseVisualStyleBackColor = true;
            this.RecordatorioButton.Click += new System.EventHandler(this.RecordatorioButton_Click);
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 395);
            this.Controls.Add(this.RecordatorioButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registrarseBtn);
            this.Controls.Add(this.iniciarsesionBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contraseñaBox);
            this.Controls.Add(this.nombreBox);
            this.Name = "IniciarSesion";
            this.Text = "Simulador Vuelo/IniciarSesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.TextBox contraseñaBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button iniciarsesionBtn;
        private System.Windows.Forms.Button registrarseBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RecordatorioButton;
    }
}