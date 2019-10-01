namespace WindowsFormsApplication1
{
    partial class AñadirFP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.yfinbox = new System.Windows.Forms.TextBox();
            this.vbox = new System.Windows.Forms.TextBox();
            this.xinbox = new System.Windows.Forms.TextBox();
            this.compbox = new System.Windows.Forms.TextBox();
            this.yinbox = new System.Windows.Forms.TextBox();
            this.xfinbox = new System.Windows.Forms.TextBox();
            this.IDbox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(52, 378);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(100, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(84, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Velocidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(478, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Posicion Y Inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(478, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Posicion Y Final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(274, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Posicion X Inicial";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(274, 271);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Posicion X Final";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(84, 271);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Compañia";
            // 
            // yfinbox
            // 
            this.yfinbox.Location = new System.Drawing.Point(468, 311);
            this.yfinbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yfinbox.Name = "yfinbox";
            this.yfinbox.Size = new System.Drawing.Size(148, 26);
            this.yfinbox.TabIndex = 9;
            // 
            // vbox
            // 
            this.vbox.Location = new System.Drawing.Point(42, 198);
            this.vbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vbox.Name = "vbox";
            this.vbox.Size = new System.Drawing.Size(148, 26);
            this.vbox.TabIndex = 10;
            // 
            // xinbox
            // 
            this.xinbox.Location = new System.Drawing.Point(264, 198);
            this.xinbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xinbox.Name = "xinbox";
            this.xinbox.Size = new System.Drawing.Size(148, 26);
            this.xinbox.TabIndex = 11;
            // 
            // compbox
            // 
            this.compbox.Location = new System.Drawing.Point(42, 311);
            this.compbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.compbox.Name = "compbox";
            this.compbox.Size = new System.Drawing.Size(148, 26);
            this.compbox.TabIndex = 12;
            // 
            // yinbox
            // 
            this.yinbox.Location = new System.Drawing.Point(468, 198);
            this.yinbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yinbox.Name = "yinbox";
            this.yinbox.Size = new System.Drawing.Size(148, 26);
            this.yinbox.TabIndex = 13;
            // 
            // xfinbox
            // 
            this.xfinbox.Location = new System.Drawing.Point(264, 311);
            this.xfinbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xfinbox.Name = "xfinbox";
            this.xfinbox.Size = new System.Drawing.Size(148, 26);
            this.xfinbox.TabIndex = 16;
            // 
            // IDbox
            // 
            this.IDbox.Location = new System.Drawing.Point(42, 69);
            this.IDbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(148, 26);
            this.IDbox.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(678, 194);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 35);
            this.button2.TabIndex = 20;
            this.button2.Text = "AutoRellenar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(675, 252);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 35);
            this.button3.TabIndex = 21;
            this.button3.Text = "AutoRellenar2";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(675, 311);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 35);
            this.button4.TabIndex = 22;
            this.button4.Text = "AutoRellenar3";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AñadirFP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 451);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.IDbox);
            this.Controls.Add(this.xfinbox);
            this.Controls.Add(this.yinbox);
            this.Controls.Add(this.compbox);
            this.Controls.Add(this.xinbox);
            this.Controls.Add(this.vbox);
            this.Controls.Add(this.yfinbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AñadirFP";
            this.Text = "Simulador Vuelo/AñadirFlightPlan";
            this.Load += new System.EventHandler(this.AñadirFP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox yfinbox;
        private System.Windows.Forms.TextBox vbox;
        private System.Windows.Forms.TextBox xinbox;
        private System.Windows.Forms.TextBox compbox;
        private System.Windows.Forms.TextBox yinbox;
        private System.Windows.Forms.TextBox xfinbox;
        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}