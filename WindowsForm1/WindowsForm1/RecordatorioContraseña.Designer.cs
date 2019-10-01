namespace WindowsFormsApplication1
{
    partial class RecordatorioContraseña
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
            this.EnviarEmailButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EnviarEmailButton
            // 
            this.EnviarEmailButton.Location = new System.Drawing.Point(123, 120);
            this.EnviarEmailButton.Name = "EnviarEmailButton";
            this.EnviarEmailButton.Size = new System.Drawing.Size(75, 23);
            this.EnviarEmailButton.TabIndex = 0;
            this.EnviarEmailButton.Text = "ACEPTAR";
            this.EnviarEmailButton.UseVisualStyleBackColor = true;
            this.EnviarEmailButton.Click += new System.EventHandler(this.EnviarEmailButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escribir dirección electrónica";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(88, 75);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(149, 20);
            this.emailBox.TabIndex = 2;
            // 
            // RecordatorioContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 166);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnviarEmailButton);
            this.Name = "RecordatorioContraseña";
            this.Text = "Simulador Vuelo/RecordarContraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnviarEmailButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailBox;
    }
}