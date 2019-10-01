namespace WindowsFormsApplication1
{
    partial class Demo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Demo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearFlightPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarFicheroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarFondoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.positiontext = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripMover = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPausa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDeshacer = new System.Windows.Forms.ToolStripButton();
            this.toolStripStep = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonConflictos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Restart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButtonGuardar = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonRestart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtoninformacion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonGestioncompañias = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPDF = new System.Windows.Forms.ToolStripButton();
            this.toolStripEnviar = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(354, 151);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 437);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(350, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lat: 43 Lon: 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(1114, 594);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lat: 40 Lon: 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(1152, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "580x285";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.ayudaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1311, 35);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearFlightPlanToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.cargarFicheroToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // crearFlightPlanToolStripMenuItem
            // 
            this.crearFlightPlanToolStripMenuItem.Name = "crearFlightPlanToolStripMenuItem";
            this.crearFlightPlanToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.crearFlightPlanToolStripMenuItem.Text = "Crear FlightPlan";
            this.crearFlightPlanToolStripMenuItem.Click += new System.EventHandler(this.crearFlightPlanToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            this.seguridadToolStripMenuItem.Click += new System.EventHandler(this.seguridadToolStripMenuItem_Click);
            // 
            // cargarFicheroToolStripMenuItem
            // 
            this.cargarFicheroToolStripMenuItem.Name = "cargarFicheroToolStripMenuItem";
            this.cargarFicheroToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.cargarFicheroToolStripMenuItem.Text = "Cargar fichero";
            this.cargarFicheroToolStripMenuItem.Click += new System.EventHandler(this.cargarFicheroToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarFondoToolStripMenuItem1,
            this.aboutUsToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // cambiarFondoToolStripMenuItem1
            // 
            this.cambiarFondoToolStripMenuItem1.Name = "cambiarFondoToolStripMenuItem1";
            this.cambiarFondoToolStripMenuItem1.Size = new System.Drawing.Size(204, 30);
            this.cambiarFondoToolStripMenuItem1.Text = "Cambiar fondo";
            this.cambiarFondoToolStripMenuItem1.Click += new System.EventHandler(this.cambiarFondoToolStripMenuItem1_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(204, 30);
            this.aboutUsToolStripMenuItem.Text = "About us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click_1);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(204, 30);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(75, 29);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            this.ayudaToolStripMenuItem1.Click += new System.EventHandler(this.ayudaToolStripMenuItem1_Click);
            // 
            // positiontext
            // 
            this.positiontext.BackColor = System.Drawing.Color.Transparent;
            this.positiontext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.positiontext.Location = new System.Drawing.Point(18, 466);
            this.positiontext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.positiontext.Name = "positiontext";
            this.positiontext.Size = new System.Drawing.Size(326, 122);
            this.positiontext.TabIndex = 5;
            this.positiontext.Text = "Posicion Cursor:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(820, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 9;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMover,
            this.toolStripSeparator1,
            this.toolStripButtonPausa,
            this.toolStripSeparator2,
            this.toolStripButtonDeshacer,
            this.toolStripStep,
            this.toolStripSeparator3,
            this.toolStripButtonConflictos,
            this.toolStripSeparator4,
            this.Restart,
            this.toolStripSeparator5,
            this.ToolStripButtonGuardar,
            this.ToolStripButtonRestart,
            this.toolStripSeparator6,
            this.toolStripButtoninformacion,
            this.toolStripSeparator7,
            this.toolStripButtonGestioncompañias,
            this.toolStripSeparator8,
            this.toolStripPDF,
            this.toolStripEnviar});
            this.toolStrip1.Location = new System.Drawing.Point(1286, 35);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(25, 665);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripMover
            // 
            this.toolStripMover.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMover.Image = global::WindowsFormsApplication1.Properties.Resources.start;
            this.toolStripMover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMover.Name = "toolStripMover";
            this.toolStripMover.Size = new System.Drawing.Size(20, 20);
            this.toolStripMover.Text = "Run";
            this.toolStripMover.Click += new System.EventHandler(this.toolStripMover_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(20, 6);
            // 
            // toolStripButtonPausa
            // 
            this.toolStripButtonPausa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPausa.Image = global::WindowsFormsApplication1.Properties.Resources.pausa;
            this.toolStripButtonPausa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPausa.Name = "toolStripButtonPausa";
            this.toolStripButtonPausa.Size = new System.Drawing.Size(20, 20);
            this.toolStripButtonPausa.Text = "Pausa";
            this.toolStripButtonPausa.Click += new System.EventHandler(this.toolStripButtonPausa_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(20, 6);
            // 
            // toolStripButtonDeshacer
            // 
            this.toolStripButtonDeshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeshacer.Image = global::WindowsFormsApplication1.Properties.Resources.atras;
            this.toolStripButtonDeshacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeshacer.Name = "toolStripButtonDeshacer";
            this.toolStripButtonDeshacer.Size = new System.Drawing.Size(20, 20);
            this.toolStripButtonDeshacer.Text = "Deshacer";
            this.toolStripButtonDeshacer.Click += new System.EventHandler(this.toolStripButtonDeshacer_Click);
            // 
            // toolStripStep
            // 
            this.toolStripStep.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStep.Image = global::WindowsFormsApplication1.Properties.Resources.adelante;
            this.toolStripStep.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripStep.Name = "toolStripStep";
            this.toolStripStep.Size = new System.Drawing.Size(20, 20);
            this.toolStripStep.Text = "Step";
            this.toolStripStep.Click += new System.EventHandler(this.toolStripStep_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(20, 6);
            // 
            // toolStripButtonConflictos
            // 
            this.toolStripButtonConflictos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonConflictos.Image = global::WindowsFormsApplication1.Properties.Resources.choque;
            this.toolStripButtonConflictos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConflictos.Name = "toolStripButtonConflictos";
            this.toolStripButtonConflictos.Size = new System.Drawing.Size(20, 20);
            this.toolStripButtonConflictos.Text = "Conflictos";
            this.toolStripButtonConflictos.Click += new System.EventHandler(this.toolStripButtonConflictos_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(20, 6);
            // 
            // Restart
            // 
            this.Restart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Restart.Image = global::WindowsFormsApplication1.Properties.Resources.restart;
            this.Restart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(20, 20);
            this.Restart.Text = "Restart";
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(20, 6);
            // 
            // ToolStripButtonGuardar
            // 
            this.ToolStripButtonGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonGuardar.Image")));
            this.ToolStripButtonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonGuardar.Name = "ToolStripButtonGuardar";
            this.ToolStripButtonGuardar.Size = new System.Drawing.Size(20, 20);
            this.ToolStripButtonGuardar.Text = "Guardar";
            this.ToolStripButtonGuardar.Click += new System.EventHandler(this.ToolStripButtonGuardar_Click);
            // 
            // ToolStripButtonRestart
            // 
            this.ToolStripButtonRestart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonRestart.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonRestart.Image")));
            this.ToolStripButtonRestart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonRestart.Name = "ToolStripButtonRestart";
            this.ToolStripButtonRestart.Size = new System.Drawing.Size(20, 20);
            this.ToolStripButtonRestart.Text = "Reanudar";
            this.ToolStripButtonRestart.Click += new System.EventHandler(this.ToolStripButtonRestart_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(20, 6);
            // 
            // toolStripButtoninformacion
            // 
            this.toolStripButtoninformacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtoninformacion.Image = global::WindowsFormsApplication1.Properties.Resources.information;
            this.toolStripButtoninformacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtoninformacion.Name = "toolStripButtoninformacion";
            this.toolStripButtoninformacion.Size = new System.Drawing.Size(20, 20);
            this.toolStripButtoninformacion.Text = "Información vuelos";
            this.toolStripButtoninformacion.Click += new System.EventHandler(this.toolStripButtoninformacion_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(20, 6);
            // 
            // toolStripButtonGestioncompañias
            // 
            this.toolStripButtonGestioncompañias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGestioncompañias.Image = global::WindowsFormsApplication1.Properties.Resources.Gestionar;
            this.toolStripButtonGestioncompañias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGestioncompañias.Name = "toolStripButtonGestioncompañias";
            this.toolStripButtonGestioncompañias.Size = new System.Drawing.Size(20, 20);
            this.toolStripButtonGestioncompañias.Text = "Gestión compañías";
            this.toolStripButtonGestioncompañias.Click += new System.EventHandler(this.toolStripButtonGestioncompañias_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(20, 6);
            // 
            // toolStripPDF
            // 
            this.toolStripPDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPDF.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPDF.Image")));
            this.toolStripPDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPDF.Name = "toolStripPDF";
            this.toolStripPDF.Size = new System.Drawing.Size(20, 20);
            this.toolStripPDF.Text = "Exportar compañias a PDF";
            this.toolStripPDF.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripEnviar
            // 
            this.toolStripEnviar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripEnviar.Image = global::WindowsFormsApplication1.Properties.Resources.email_send_512;
            this.toolStripEnviar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEnviar.Name = "toolStripEnviar";
            this.toolStripEnviar.Size = new System.Drawing.Size(20, 20);
            this.toolStripEnviar.Text = "Enviar informe";
            this.toolStripEnviar.Click += new System.EventHandler(this.toolStripEnviar_Click);
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 700);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.positiontext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Demo";
            this.Text = "Simulador Vuelo";
            this.Load += new System.EventHandler(this.Demo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.Label positiontext;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem crearFlightPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem cargarFicheroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripMover;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPausa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeshacer;
        private System.Windows.Forms.ToolStripButton toolStripStep;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonConflictos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton Restart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton ToolStripButtonRestart;
        private System.Windows.Forms.ToolStripButton ToolStripButtonGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButtoninformacion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButtonGestioncompañias;
        private System.Windows.Forms.ToolStripButton toolStripPDF;
        private System.Windows.Forms.ToolStripButton toolStripEnviar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem cambiarFondoToolStripMenuItem1;
    }
}

