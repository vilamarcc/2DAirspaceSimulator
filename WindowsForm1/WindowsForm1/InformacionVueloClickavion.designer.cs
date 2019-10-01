namespace WindowsFormsApplication1
{
    partial class InformacionVueloClickavion
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
            this.button1 = new System.Windows.Forms.Button();
            this.idbox = new System.Windows.Forms.TextBox();
            this.compbox = new System.Windows.Forms.TextBox();
            this.velbox = new System.Windows.Forms.TextBox();
            this.posinbox = new System.Windows.Forms.TextBox();
            this.posactbox = new System.Windows.Forms.TextBox();
            this.posfinbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelogo = new System.Windows.Forms.Panel();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.telefbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(124, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(154, 164);
            this.idbox.Name = "idbox";
            this.idbox.ReadOnly = true;
            this.idbox.Size = new System.Drawing.Size(130, 20);
            this.idbox.TabIndex = 1;
            // 
            // compbox
            // 
            this.compbox.Location = new System.Drawing.Point(154, 190);
            this.compbox.Name = "compbox";
            this.compbox.ReadOnly = true;
            this.compbox.Size = new System.Drawing.Size(130, 20);
            this.compbox.TabIndex = 2;
            // 
            // velbox
            // 
            this.velbox.Location = new System.Drawing.Point(154, 216);
            this.velbox.Name = "velbox";
            this.velbox.ReadOnly = true;
            this.velbox.Size = new System.Drawing.Size(130, 20);
            this.velbox.TabIndex = 3;
            // 
            // posinbox
            // 
            this.posinbox.Location = new System.Drawing.Point(154, 242);
            this.posinbox.Name = "posinbox";
            this.posinbox.ReadOnly = true;
            this.posinbox.Size = new System.Drawing.Size(130, 20);
            this.posinbox.TabIndex = 4;
            // 
            // posactbox
            // 
            this.posactbox.Location = new System.Drawing.Point(154, 268);
            this.posactbox.Name = "posactbox";
            this.posactbox.ReadOnly = true;
            this.posactbox.Size = new System.Drawing.Size(130, 20);
            this.posactbox.TabIndex = 5;
            // 
            // posfinbox
            // 
            this.posfinbox.Location = new System.Drawing.Point(154, 294);
            this.posfinbox.Name = "posfinbox";
            this.posfinbox.ReadOnly = true;
            this.posfinbox.Size = new System.Drawing.Size(130, 20);
            this.posfinbox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(39, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(39, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Compañia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(39, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Velocidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(39, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Posición Inicial (X,Y):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(39, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Posición Actual (X,Y):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(39, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Posición Final (X,Y):";
            // 
            // panelogo
            // 
            this.panelogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelogo.BackColor = System.Drawing.Color.White;
            this.panelogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelogo.Location = new System.Drawing.Point(24, 30);
            this.panelogo.Name = "panelogo";
            this.panelogo.Size = new System.Drawing.Size(106, 104);
            this.panelogo.TabIndex = 13;
            // 
            // emailbox
            // 
            this.emailbox.Location = new System.Drawing.Point(220, 70);
            this.emailbox.Name = "emailbox";
            this.emailbox.ReadOnly = true;
            this.emailbox.Size = new System.Drawing.Size(100, 20);
            this.emailbox.TabIndex = 14;
            // 
            // telefbox
            // 
            this.telefbox.Location = new System.Drawing.Point(220, 114);
            this.telefbox.Name = "telefbox";
            this.telefbox.ReadOnly = true;
            this.telefbox.Size = new System.Drawing.Size(100, 20);
            this.telefbox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(147, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(147, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Telefono:";
            // 
            // InformacionVueloClickavion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 369);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.telefbox);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.panelogo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.posfinbox);
            this.Controls.Add(this.posactbox);
            this.Controls.Add(this.posinbox);
            this.Controls.Add(this.velbox);
            this.Controls.Add(this.compbox);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.button1);
            this.Name = "InformacionVueloClickavion";
            this.Text = "Simulador Vuelo/InformaciónVuelo";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.TextBox compbox;
        private System.Windows.Forms.TextBox velbox;
        private System.Windows.Forms.TextBox posinbox;
        private System.Windows.Forms.TextBox posactbox;
        private System.Windows.Forms.TextBox posfinbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelogo;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.TextBox telefbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}