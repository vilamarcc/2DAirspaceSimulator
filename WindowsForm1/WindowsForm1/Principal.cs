using System;
using utm;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using FlightPlanClass;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class Demo : Form
    {
        ListFlightPlan listFP = new ListFlightPlan();
        List<PictureBox> imagenes = new List<PictureBox>();
        List<Label> leyendas = new List<Label>();
        Stack<ListFlightPlan> pilaFP = new Stack<ListFlightPlan>();
        int num = 0;
        int interval = 0; //tiempo de ciclo
        int dseg = 0; //distancia de seguridad
        bool conflictoscomprobados = false; //he comprobado conflictos o no
        string usuario; //usuario que ha iniciado sesión
        int fondo = 2; //Para cambiar de fondo (por defecto: fondo=2)
        bool informegenerado; //he generado el informe o no

        public Demo()
        {
            //Le ponemos por defecto un fondo que el usuario puede cambiar
            this.BackgroundImage = Properties.Resources.nubes;
            BackgroundImageLayout = ImageLayout.Stretch;

            InitializeComponent();

            //Mensaje ayuda
            MessageBox.Show("Bienvenido a la Versión 3" + "\n" + "\n" + "\n" + "Instrucciones:" + "\n" + "\n" + "* Pulsa Opciones para desplegar el menú. Las opciones son las siguientes:" + "\n" + "\t" + "-Crear Flight Plan --> Añadir un plan de vuelo" + "\n" + "\t" + "-Seguridad --> Añadir parámetros de seguridad" + "\n" + "\t" + "-Cargar Fichero --> Carga un fichero de texto con planes de vuelo" + "\n" + "\n" + "* Funcionalidades de los botones. Si colocas el ratón encima del botón te dice cuál es:" + "\n" + "\t" + "-Run --> Inicia/Continúa la simulación" + "\n" + "\t" + "-Pausa --> Detiene la simulación" + "\n" + "\t" + "-Deshacer --> Deshace el último paso efectuado y vuelve atrás un ciclo" + "\n" + "\t" + "-Step --> Mueve el avión paso a paso. Cada click un paso" + "\n" + "\t" + "-Conflictos --> Comprueba si hay conflictos y, si lo hay, los resuelve" + "\n" + "\t" + "-Restart --> Devuelve los aviones a sus posiciones iniciales" + "\n" + "\t" + "-Guardar --> Guarda las posiciones de los aviones en el instante en que le das" + "\n" + "\t" + "-Reanudar --> Vuelve a poner los aviones en la última posición guardada" + "\n" + "\t" + "-Información vuelos --> Muestra los datos de los aviones y permite modificar las velocidades" + "\n" + "\t" + "-Gestión compañías --> Permite añadir o borrar compañías a la base de datos" + "\n" + "\t" + "Exportar Compañías --> Permite exportar los datos de los vuelos con sus respectivos cambios de velocidad y sus respectivas compañías" + "\n" + "\t" + "Enviar Informe --> Envía dicho informe al correo deseado" + "\n" + "\n" + "* Pulsa Configuración para desplegar otro menú con las siguientes opciones:" + "\n" + "\t" + "-Cambiar fondo --> Permite personalizar el fondo del simulador" + "\n" + "\t" + "-About Us --> Creadores del simulador" + "\n" + "\t" + "-Cerrar sesión --> Cierra tu sesión y permite iniciar sesión con otro usuario" + "\n");
        }

        public void getusuario(string u) //tengo el usuario con el que se ha iniciado sesión
        {
            usuario = u;
        }
        
        private void panel1_MouseMove(object sender, MouseEventArgs e) //Label con la posición y las coordenadas geogáficas del cursor
        {
            //Leemos la posición en la que está el cursor dentro del panel
            int x = e.X;
            int y = e.Y;

            //Creamos un punto con la posición del cursor
            Point p = new Point(x, y);

            //Creamos el area
            Area a = new Area(43, 1, 40, 3, 580, 285);

            // A partir del punto obtenemos las coordenadas UTM
            double pX2 = Conversor.GetUtmXFromPoint(a, p);
            double pY2 = Conversor.GetUtmYFromPoint(a, p);

            // A partir de las coordenadas UTM obtenemos las coordenadas geográficas
            double pLat2 = Conversor.GetLat(pX2, pY2);
            double pLon2 = Conversor.GetLon(pX2, pY2);

            //Escribimos en la label la posición del ratón y las coordenadas geográficas
            positiontext.Text = "X: " + x + " Y: " + y + "\n" + "Latitud: " + pLat2 + "\n" + "Longitud: " + pLon2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Copiamos la lista para guardarla en la pila
            ListFlightPlan listacopia = new ListFlightPlan(listFP);
            pilaFP.Push(listacopia);

            //Movemos todos los vuelos hasta que hayan llegado todos a su destino
            listFP.MoverTodos(interval);
            if (listFP.Hanllegadotodos() == true)
                timer1.Stop();

            //Para dibujar el avión
            DibujarFP(listFP);
        }

        private void panel1_Paint(object sender, PaintEventArgs e) //Para hacer los dibujos (círculo de distancia de seguridad, raya de la trayectoria y pintar círculo en caso de conflicto)
        {
            int i = 0;
            int c = 0;
            while (i < listFP.getcount())
            {
                System.Drawing.Graphics graphics = e.Graphics;
                
                //Cogemos el FP y recogemos sus posiciones
                FlightPlan FP = listFP.getposicion(i);

                int x = Convert.ToInt32(FP.GetAX());
                int y = Convert.ToInt32(FP.GetAY());

                int xi = Convert.ToInt32(FP.GetIX());
                int yi = Convert.ToInt32(FP.GetIY());

                int xf = Convert.ToInt32(FP.GetFX());
                int yf = Convert.ToInt32(FP.GetFY());

                //Mostramos círulo de distancia de seguridad
                int xact = x - dseg / 2;
                int yact = y - dseg / 2;

                //Definimos h como una raya de color azul para dibujar la distancia de seguridad
                Pen h = new Pen(Color.Blue, 1);

                //Definimos brush de color rojo para pintar el círculo en caso de conflicto
                SolidBrush brush = new SolidBrush(Color.Red);

                //Creamos un rectangulo con centro en la posición actual y longitud de los lados=distancia de seguridad
                System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(xact, yact, dseg, dseg);

                //Dibujamos
                if (listFP.getcount() > 1) //Si hay más de un FP, hemos de comprobar los conflictos
                {
                    while (c < listFP.getcount()) //Recorre la lista de FP
                    {
                        try
                        {
                            //si hay conflicto entre dos o más aviones el círculo se pinta de color rojo al tocarse las distancias de seguridad entre ellas
                            if (listFP.getposicion(i).Estaenconflicto(listFP.getposicion(c),dseg)==-1 && (c != i))
                            {
                                e.Graphics.FillEllipse(brush, rectangle);
                                brush.Dispose();
                            }
                        }
                        catch
                        {
                        }
                        //Si no están en conflicto, dibujamos la raya que marca la distancia de seguridad
                        if (dseg < listFP.getposicion(i).Distance(listFP.getposicion(c)) && (c != i))
                            graphics.DrawEllipse(h, rectangle);
                        c = c + 1;
                    }
                }
                else //Si solo hay un FP, dibuja el círculo de radio distancia de seguridad
                    graphics.DrawEllipse(h, rectangle);
                c = 0;

                i++;

                //dibujamos la linea de trayectoria desde la posición inicial hasta la final
                Pen b = new Pen(Color.Black, 1);
                e.Graphics.DrawLine(b, xi, yi, xf, yf);
            }
        }

        private void crearFlightPlanToolStripMenuItem_Click(object sender, EventArgs e) //opción crear flightplan
        {
            try
            {
                //Abrimos el form que lee los datos del FP, lo crea y lo devuelve
                AñadirFP F = new AñadirFP();
                F.cambiarfondo(fondo);
                F.ShowDialog();

                //Recogemos el FP que ha creado el form anterior
                FlightPlan FP = F.getflightdata();

                if (FP != null)
                {
                    //Usamos el método de añadir FP de la lista. Si el FP ya existe en la lista devuelve true, sino false
                    bool a = listFP.añadirfp(FP);

                    if (a == true) //No añade el FP a la lista porque ya existe (informamos con un MessageBox)
                        MessageBox.Show("Ese plan de vuelo ya existe");

                    if (a == false) //Ha añadido el FP a la lista (informamos con un MessageBox), así que dibujamos su avión
                    {
                        DibujarNuevoFP(listFP); //Para dibujar el avión
                        MessageBox.Show("Plan de vuelo añadido");
                        conflictoscomprobados = false;
                    }
                }
            }
            catch
            {
            }
        }

        public void showinfo(object sender, EventArgs e) //Cuando clicas sobre un avión, mostramos la información de ese vuelo
        {
            //Paramos la simulación
            timer1.Stop();

            //Cuando clicas sobre una imagen, coge la posición en la que está en el vector de picturebox (que será la misma en la que este su FP en ListFP) para recoger el FP de ListFP y coger los datos
            PictureBox pp = (PictureBox)sender;
            int i = (int)pp.Tag;

            //Abrimos el form que muestra la información y le damos el vuelo correspondiente
            InformacionVueloClickavion panelinfo = new InformacionVueloClickavion();
            panelinfo.cambiarfondo(fondo);
            panelinfo.setFlight(listFP.getposicion(i));
            panelinfo.ShowDialog();
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e) //opción seguridad
        {
            //Abrimos el form que lee la información de seguridad
            Seguridad f2 = new Seguridad();
            f2.cambiarfondo(fondo);
            f2.ShowDialog();

            //Leemos los datos necesarios (tiempo de ciclo y distancia de seguridad) del form
            dseg = Convert.ToInt32(f2.GetDS());
            interval = Convert.ToInt32(f2.Gettcliclo());
        }

        private void cargarFicheroToolStripMenuItem_Click(object sender, EventArgs e) //opción cargar fichero
        {
            //Abrimos el form que coge el fichero
            CargarFicheroFP f = new CargarFicheroFP();
            f.cambiarfondo(fondo);
            f.ShowDialog();

            //El form nos devuelve el nombre del arvhivo
            string archivo = f.Getarchivo(); //nombre del file

            try
            {
                //Usamos el método CargarFichero de la lista para que rellene la lista
                listFP.CargarFichero(archivo);

                //Como hemos añadido nuevos planes de vuelo, puede haber conflictos
                conflictoscomprobados = false;

                //Si no hemos cargado ningún plan de vuelo antes
                if (imagenes.Count == 0)
                    DibujarNuevoFP(listFP);

                //Si ya había planes de vuelo introducido
                else
                {
                    DibujarFP(listFP);
                    panel1.Refresh();
                }
            }
            catch
            {
                MessageBox.Show("El fichero escogido no es valido");
            }
        }

        private void aboutUsToolStripMenuItem_Click_1(object sender, EventArgs e)//opción about us
        {
            //Muestra los creadores del simulador
            AboutUs f7 = new AboutUs();
            f7.cambiarfondo(fondo);
            f7.ShowDialog();
        } 

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e) //opción cerrar sesión
        {
            //Escondemos este form
            this.Hide();

            //Lo que hace es cerrar el form principal, que se volverá a abrir si se inicia sesión con el mismo o con otro usuario
            IniciarSesion f = new IniciarSesion();
            f.ShowDialog();

            //Cerramos este form
            this.Close();
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e) //opción ayuda
        {
            MessageBox.Show("Instrucciones:" + "\n" + "\n" + "* Pulsa Opciones para desplegar el menú. Las opciones son las siguientes:" + "\n" + "\t" + "-Crear Flight Plan --> Añadir un plan de vuelo" + "\n" + "\t" + "-Seguridad --> Añadir parámetros de seguridad" + "\n" + "\t" + "-Cargar Fichero --> Carga un fichero de texto con planes de vuelo" + "\n" + "\n" + "* Funcionalidades de los botones. Si colocas el ratón encima del botón te dice cuál es:" + "\n" + "\t" + "-Run --> Inicia/Continúa la simulación" + "\n" + "\t" + "-Pausa --> Detiene la simulación" + "\n" + "\t" + "-Deshacer --> Deshace el último paso efectuado y vuelve atrás un ciclo" + "\n" + "\t" + "-Step --> Mueve el avión paso a paso. Cada click un paso" + "\n" + "\t" + "-Conflictos --> Comprueba si hay conflictos y, si lo hay, los resuelve" + "\n" + "\t" + "-Restart --> Devuelve los aviones a sus posiciones iniciales" + "\n" + "\t" + "-Guardar --> Guarda las posiciones de los aviones en el instante en que le das" + "\n" + "\t" + "-Reanudar --> Vuelve a poner los aviones en la última posición guardada" + "\n" + "\t" + "-Información vuelos --> Muestra los datos de los aviones y permite modificar las velocidades" + "\n" + "\t" + "-Gestión compañías --> Permite añadir o borrar compañías a la base de datos" + "\n" + "\t" + "Exportar Compañías --> Permite exportar los datos de los vuelos con sus respectivos cambios de velocidad y sus respectivas compañías" + "\n" + "\t" + "Enviar Informe --> Envía dicho informe al correo deseado" + "\n" + "\n" + "* Pulsa Configuración para desplegar otro menú con las siguientes opciones:" + "\n" + "\t" + "-Cambiar fondo --> Permite personalizar el fondo del simulador" + "\n" + "\t" + "-About Us --> Creadores del simulador" + "\n" + "\t" + "-Cerrar sesión --> Cierra tu sesión y permite iniciar sesión con otro usuario" + "\n");
        }

        private void toolStripButtonGestioncompañias_Click(object sender, EventArgs e) //botón gestión compañías
        {
            InformacionCompañiasDatagridview f12 = new InformacionCompañiasDatagridview();
            f12.Setusuario(usuario);
            f12.cambiarfondo(fondo);
            f12.ShowDialog();
        }

        private void toolStripButtoninformacion_Click(object sender, EventArgs e) //botón información vuelos
        {
            try
            {
                //Abrimos el form, paramos la simulación y le damos (al form) la lista para que pueda coger los datos
                InformacionVuelosDatagridview f5 = new InformacionVuelosDatagridview();
                timer1.Stop();
                f5.setlist(listFP);
                f5.cambiarfondo(fondo);
                f5.Show();

                //Cogemos la lista que nos devuelve el form ya que el usuario puede cambiar la velocidad desde ahí
                listFP = f5.getlist();

                //Dibujar el avión 
                DibujarFP(listFP);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void ToolStripButtonRestart_Click(object sender, EventArgs e) //botón reanudar
        {
            try
            {
                panel1.Refresh();

                //Cargamos en nuestra lista los datos del fichero
                listFP.CargarFichero("Vuelosguardados.txt");

                //Si no hemos cargado ningún plan de vuelo antes
                if (imagenes.Count == 0)
                    DibujarNuevoFP(listFP);

                //Si ya había planes de vuelo introducido
                else
                {
                    panel1.Refresh();
                    DibujarFP(listFP);
                    panel1.Refresh();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: "+exc.Message);
            }
        }

        private void ToolStripButtonGuardar_Click(object sender, EventArgs e) //opción guardar
        {
            //Usamos el método de la lista que guarda todos los vuelos en un fichero
            listFP.GuardarVuelos("Vuelosguardados.txt");
        }

        private void Restart_Click(object sender, EventArgs e) //botón restart
        {
            //Usamos un método ya creado que coloca a todos en su posición inicial
            listFP.restarttodos(); 

            //Para dibujar
            DibujarFP(listFP);
        }

        private void toolStripButtonConflictos_Click(object sender, EventArgs e) //botón conflictos
        {
            //Ya consideramos que hemos solucionado los conflictos
            conflictoscomprobados = true;

            //Colocamos todos los vuelos en su posición inicial
            listFP.restarttodos();

            //Dibujamos el avión en el inicio            
            DibujarFP(listFP);

            //Si no hay ningún plan de vuelo en la lista
            if (listFP.getcount() == 0)
                MessageBox.Show("Introduce algún plan de vuelo");

            //Si solo hay un plan de vuelo, no va a haber conflictos
            if (listFP.getcount() == 1)
                MessageBox.Show("No hay conflictos");

            //Si hay más de un plan de vuelo, cal comprobarlos
            else
            {
                //Comprobar que esté la información de seguridad
                //Si no está, informamos al usuario
                if (interval == 0 || dseg == 0)
                {
                    conflictoscomprobados = false;
                    MessageBox.Show("Falta información de seguridad");
                }

                //Si está:
                else
                {
                    bool conflict = true;
                    while (conflict == true)
                    {
                        //Comprobamos si hay confictos entre los vuelos de la lista con el método
                        if (listFP.BuscarConflictos(dseg) == false)
                            conflict = false;
                        else
                        {
                            //Guardo velocidades en una lista
                            List<double> velocidades = new List<double>();
                            int g = 0;
                            while (g < listFP.getcount())
                            {
                                velocidades.Add(listFP.getposicion(g).GetVelocidad());
                                g++;
                            }

                            //Solucionamos los conflictos
                            listFP.SolucionarConflictos(dseg, interval);

                            //Actualizamos los incrementos de velocidad comparando la velocidad que llevan con la guardada en la lista
                            int y = 0;
                            while (y < listFP.getcount())
                            {
                                listFP.getposicion(y).SetIncrementoV(listFP.getposicion(y).GetVelocidad() - velocidades[y]);
                                y++;
                            }
                        }
                    }
                    MessageBox.Show("No hay conflictos");
                }
            }
        }

        private void toolStripStep_Click(object sender, EventArgs e) //botón step
        {
            //Si no hay ningún plan de vuelo, informamos al usuario
            if (listFP.getcount() == 0) 
                MessageBox.Show("Introduce algún plan de vuelo");

            //Si hay algún plan de vuelo hay que hacer comprobaciones
            else
            {
                //Comprobamos que esté la información de seguridad

                //Si no está:
                if (interval == 0 || dseg == 0)
                    MessageBox.Show("Falta información de seguridad");

                //Si está:
                else
                {
                    //Si no hemos comprobado conflictos el programa nos pregunta si queremos seguir
                    if (conflictoscomprobados == false)
                    {
                        //Se abre el form 
                        DecisionConflictos f = new DecisionConflictos();
                        f.cambiarfondo(fondo);
                        f.ShowDialog();

                        //Recogemos la decisión del usuario. Si no quiere continuar, no hacemos nada (ya le hemos dicho qué ha de hacer)
                        //Si quiere continuar, asignamos a "conflictoscomprobados" true sino saldrá todo el rato el form DecisionConflictos
                        if (f.GetContinuar() == true)
                            conflictoscomprobados = true;
                    }

                    //Si los conflictos está solucionados, lo movemos
                    else 
                        listFP.MoverTodos(interval);
                }
            }

            if (listFP.Hanllegadotodos() == true) //mostrar momento en el que llegan
                MessageBox.Show("Ya han llegado todos los vuelos a su destino");

            //Para dibujar el avión
            DibujarFP(listFP);
        }

        private void toolStripButtonDeshacer_Click(object sender, EventArgs e) //botón deshacer
        {
            //Le asignamos a la lista el último valor guardado en la pila
            listFP = pilaFP.Pop();

            //Para dibujar
            DibujarFP(listFP);
        }

        private void toolStripButtonPausa_Click(object sender, EventArgs e) //botón pausa
        {
            //Paramos la simulación
            timer1.Stop();
        }

        private void toolStripMover_Click(object sender, EventArgs e) //botón mover
        {
            //si no se ha introducido ningun plan de vuelo
            if (listFP.getcount() == 0) 
                MessageBox.Show("Introduce algún plan de vuelo");

            //Si hay algún plan de vuelo, cal hacer alguna comprobación
            else
            {
                //Primero comprobar que esté la información de seguridad

                //si no está, informamos al usuario
                if (interval == 0 || dseg == 0)
                    MessageBox.Show("Falta información de seguridad");

                //Si está, haceos otras comprobaciones
                else
                {
                    //Comprobamos si se han solucionado los conflictos:

                    //Si no hemos comprobado conflictos el programa nos pregunta si queremos seguir
                    if (conflictoscomprobados == false)
                    {
                        //Se abre el form 
                        DecisionConflictos f = new DecisionConflictos();
                        f.cambiarfondo(fondo);
                        f.ShowDialog();

                        //Recogemos la decisión del usuario. Si no quiere continuar, no hacemos nada (ya le hemos dicho qué ha de hacer)
                        //Si quiere continuar, empezamos la simulación
                        if (f.GetContinuar() == true)
                        {
                            timer1.Start();
                            timer1.Interval = interval;
                        }
                    }

                    //Si los conflictos está solucionados, empezamos la simulación
                    else
                    {
                        timer1.Start();
                        timer1.Interval = interval;
                    }
                }
            }
        }

        public void DibujarNuevoFP(ListFlightPlan listfp) //cuando añades algun FP a la lista cal incluir su dibujo en el panel
        {
            int i = 0;
            while (i < listfp.getcount())
            {
                FlightPlan FP = listfp.getposicion(i);

                //Configuramos los parámetros de la picturebox
                PictureBox pp = new PictureBox();
                pp.Width = 20;
                pp.Height = 20;
                pp.ClientSize = new Size(20, 20);

                //Configuramos los parámetros de la leyenda
                Label leyenda = new Label();
                leyenda.Text = FP.GetID();

                // Obtenemos los puntos correspondientes en el panel
                //Para picturebox
                int xif = Convert.ToInt32(FP.GetAX()) - 10;
                int yif = Convert.ToInt32(FP.GetAY()) - 10;
                Point pDraw = new Point(xif, yif);
                //Para leyenda
                int xil = Convert.ToInt32(FP.GetAX()) + 15;
                int yil = Convert.ToInt32(FP.GetAY()) - 15;
                Point pLabel = new Point(xil, yil);

                //Colocamos cada cosa en su punto
                pp.Location = pDraw;
                leyenda.Location = pLabel;

                //Ajustamos y mostramos
                pp.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap image = new Bitmap("avion.jpg");
                pp.Image = (System.Drawing.Image)image;
                panel1.Controls.Add(pp);
                imagenes.Add(pp);
                pp.Click += new System.EventHandler(this.showinfo);
                pp.Tag = num;
                num = num + 1;
                panel1.Invalidate();

                leyendas.Add(leyenda);
                panel1.Controls.Add(leyenda);
                leyenda.BackColor = Color.Transparent;

                i++;
            }
        }

        public void DibujarFP(ListFlightPlan listFP) //cuando mueves los FP cal actualizar su posicion en el panel
        {
            int i = 0;
            while (i < listFP.getcount())
            {
                FlightPlan p = listFP.getposicion(i);

                // Obtenemos los puntos correspondientes en el panel
                int newxf = Convert.ToInt32(p.GetAX()) - 10;
                int newyf = Convert.ToInt32(p.GetAY()) - 10;
                int newxl = Convert.ToInt32(p.GetAX()) + 15;
                int newyl = Convert.ToInt32(p.GetAY()) - 15;
                Point pDraw = new Point(newxf, newyf);
                Point pLabel = new Point(newxl, newyl);

                //Actualizamos
                imagenes[i].Location = pDraw;
                leyendas[i].Location = pLabel;
                panel1.Refresh();

                i = i + 1;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e) //Creamos un documento pdf con los cambios que ha habido en los planes de vuelo y con los datos de las compañías para poder informarles
        {
            try
            {
                //Abrimos un documento pdf con nombre Compañías
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream("Compañías.pdf", FileMode.OpenOrCreate));
                document.Open();

                //Creamos una tabla con 4 columnas dentro del pdf y configuramos sus parámetros
                PdfPTable table = new PdfPTable(3); 
                table.TotalWidth = 400f;
                table.LockedWidth = true;
                float[] widths = new float[] { 2f, 3f, 2f };
                table.SetWidths(widths);
                table.HorizontalAlignment = 1; //0:izq 1:centro 2:derecha
                table.SpacingBefore = 20f;
                table.SpacingAfter = 30f;
                
                //creo el encabezamiento, fusionando las 4 columnas
                PdfPCell cell = new PdfPCell(new Phrase("Compañías"));
                cell.Colspan = 3; 
                cell.Border = 0;
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);
                
                //abrimos la clase que permite tocar la bbdd  de compañias
                baseops c = new baseops();
                c.open();

                //tabla con todo lo que hay en la bbdd de compañias
                DataTable res = c.GetAllComp(); 
                
                //añadimos la primera fila con lo que hay en cada columna
                PdfPCell cellName = new PdfPCell(new Phrase("Name"));
                cellName.HorizontalAlignment = 1;
                table.AddCell(cellName);

                PdfPCell cellemail = new PdfPCell(new Phrase("e-mail"));
                cellemail.HorizontalAlignment = 1;
                table.AddCell(cellemail);

                PdfPCell celltlf = new PdfPCell(new Phrase("Telephone"));
                celltlf.HorizontalAlignment = 1;
                table.AddCell(celltlf);

                //recorre la tabla que tiene los datos de la bbdd
                int i = 0;
                while (i < res.Rows.Count) 
                {
                    //Añadimos los datos de las compañías
                    table.AddCell(Convert.ToString(res.Rows[i][0]));
                    table.AddCell(Convert.ToString(res.Rows[i][1]));
                    table.AddCell(Convert.ToString(res.Rows[i][2]));

                    i++;
                }

                //Añadimos la tabla al documento
                document.Add(table);

                //Escribimos el informe
                document.Add(new Paragraph("\n\n\nINFORME DE CAMBIOS DE VELOCIDAD:"));
                
                //Recorremos la lista para ver qué vuelos han cambiado su velocidad
                int r = 0;
                while (r < listFP.getcount())
                {
                    //Vuelos que no han variado su velocidad
                    if (listFP.getposicion(r).GetIncrementoV() == 0)
                        document.Add(new Paragraph("El vuelo " + listFP.getposicion(r).GetID() + " de " + listFP.getposicion(r).GetCompañia() + " no ha variado su velocidad."));

                    //Vuelos que sí que han variado su velocidad
                    else
                    {
                        //Si el vuelo ha disminuido su velocidad, el incremento será negativo
                        if (listFP.getposicion(r).GetIncrementoV() < 0)
                            document.Add(new Paragraph("El vuelo " + listFP.getposicion(r).GetID() + " de " + listFP.getposicion(r).GetCompañia() + " ha disminuido su velocidad " + Convert.ToString(-listFP.getposicion(r).GetIncrementoV()) + " nudos."));

                        //Si el vuelo ha aumentado su velocidad, el incremento será positivo
                        if (listFP.getposicion(r).GetIncrementoV() > 0)
                            document.Add(new Paragraph("El vuelo " + listFP.getposicion(r).GetID() + " de " + listFP.getposicion(r).GetCompañia() + " ha aumentado su velocidad " + Convert.ToString(listFP.getposicion(r).GetIncrementoV()) + " nudos."));
                    }

                    r++;
                }

                //Cerramos el documento
                document.Close();

                MessageBox.Show("El PDF se ha creado correctamente");
                informegenerado = true;
            }
            catch (Exception ex) //si hay algún error informamos al usuario
            {
                MessageBox.Show("Error:\t" + ex.Message);
            }
        }

        private void toolStripEnviar_Click(object sender, EventArgs e)
        {
            //Solo permite enviar el pdf si este ha sido creado previamente
            if (informegenerado == true)
            {
                EnviarEmail ee = new EnviarEmail();
                ee.cambiarfondo(fondo);
                ee.ShowDialog();
            }

            //Si no, informamos al usuario
            else
                MessageBox.Show("No puedes enviar el informe si no lo has creado. Para crearlo, clica sobre el icono del pdf ('Exportar compañías a PDF')");
        }

        private void cambiarFondoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Abrimos el form para elegir fondo
            Fondos f = new Fondos();
            f.ShowDialog();

            //Recogemos el número del fondo correspondiente
            fondo = f.GetNum();

            //Depende del número, se pondrá un fondo u otro

            if (fondo == 1)
            {
                this.BackgroundImage = Properties.Resources.background_airport;
                BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (fondo == 2)
            {
                this.BackgroundImage = Properties.Resources.nubes;
                BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (fondo == 3)
            {
                this.BackgroundImage = Properties.Resources.paisaje;
                BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (fondo == 4)
            {
                this.BackgroundImage = Properties.Resources.puesta_de_sol;
                BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (fondo == 5)
            {
                this.BackgroundImage = Properties.Resources.noche;
                BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (fondo == 6)
            {
                this.BackgroundImage = Properties.Resources.aurora;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void Demo_Load(object sender, EventArgs e)
        {

        }
    }
}