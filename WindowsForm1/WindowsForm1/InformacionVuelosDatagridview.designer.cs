namespace WindowsFormsApplication1
{
    partial class InformacionVuelosDatagridview
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
            this.panelgrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(587, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelgrid
            // 
            this.panelgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.panelgrid.Location = new System.Drawing.Point(16, 32);
            this.panelgrid.Name = "panelgrid";
            this.panelgrid.Size = new System.Drawing.Size(646, 164);
            this.panelgrid.TabIndex = 1;
            this.panelgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.panelgrid_CellContentClick);
            this.panelgrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.panelgrid_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Puedes cambiar la velocidad de los aviones simplemente escribiendo una nueva.";
            // 
            // InformacionVuelosDatagridview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelgrid);
            this.Controls.Add(this.button1);
            this.Name = "InformacionVuelosDatagridview";
            this.Text = "Simulador Vuelo/InformaciónVuelos";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView panelgrid;
        private System.Windows.Forms.Label label1;
    }
}