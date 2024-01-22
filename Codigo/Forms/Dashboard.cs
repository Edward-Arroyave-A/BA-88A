using AnnarComMICROSESV60.Utilities;
using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace AnnarComMICROSESV60.Forms
{
    public partial class Dashboard : Form
    {
        Resultados terminal = new Resultados();
        Config config = new Config();
        Color primaryColor = Color.FromArgb(46, 189, 255);
        Color EfectoColorHoverCargar = Color.FromArgb(172, 206, 247);
        Color colorDesconectar = Color.FromArgb(198, 198, 198);
        Color colorConectar = Color.FromArgb(121, 224, 213);
        public Dashboard()
        {
            InitializeComponent();

            #region Proceso para cargar la primera ventana
            //Se crea una instancia del formulario secundario
            terminal = new Resultados()
            {
                //Se asignan propiedades al fomulario
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            //Se establece el panel contenedor como padre del formulario secundario
            panelDashContenedor.Controls.Add(terminal);
            //Se muestra el formulario
            terminal.Show();

            //btnResultados.BackgroundImage = Properties.Resources.Resul_True;
            //btnResultados.BackgroundImageLayout = ImageLayout.Zoom;

            //btnConfig.BackgroundImage = Properties.Resources.Config_False;
            //btnConfig.BackgroundImageLayout = ImageLayout.Zoom;
            #endregion

            this.Text = $"{InterfaceConfig.nombreEquipo} v{Application.ProductVersion}";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            InterfaceConfig.InitializeConfig();


            VariablesGlobal.Conectar = false;
            //Banderas para cambio de icono en los botones
            InterfaceConfig.banderaConfig = true;
            btnResultados.Enabled = false;
        }

        //Eventos al posicionar el mouse en config
        private void btnConfig_MouseEnter(object sender, EventArgs e)
        {
            if (btnConfig.Enabled)
            {
                //btnConfig.BackgroundImage = Properties.Resources.Config_True;
                //btnConfig.BackgroundImageLayout = ImageLayout.Zoom;

                //btnResultados.BackgroundImage = Properties.Resources.Resul_False;
                //btnResultados.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        //Eventos al posicionar el mouse en config
        private void btnConfig_MouseLeave(object sender, EventArgs e)
        {
            //if (btnConfig.Enabled)
            //{
            //    //btnResultados.BackgroundImage = Properties.Resources.Resul_True;
            //    //btnResultados.BackgroundImageLayout = ImageLayout.Zoom;

            //    //btnConfig.BackgroundImage = Properties.Resources.Config_False;
            //    //btnConfig.BackgroundImageLayout = ImageLayout.Zoom;
            //}
        }

        //Eventos al posicionar el mouse en resultados
        private void btnResultados_MouseEnter(object sender, EventArgs e)
        {
            if (btnResultados.Enabled)
            {
                //btnResultados.BackgroundImage = Properties.Resources.Resul_True;
                //btnResultados.BackgroundImageLayout = ImageLayout.Zoom;

                //btnConfig.BackgroundImage = Properties.Resources.Config_False;
                //btnConfig.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        //Eventos al posicionar el mouse en resultados
        private void btnResultados_MouseLeave(object sender, EventArgs e)
        {
            //if (btnResultados.Enabled)
            //{
            //    btnConfig.BackgroundImage = Properties.Resources.Config_True;
            //    btnConfig.BackgroundImageLayout = ImageLayout.Zoom;

            //    btnResultados.BackgroundImage = Properties.Resources.Resul_False;
            //    btnResultados.BackgroundImageLayout = ImageLayout.Zoom;
            //}
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {


            if (!VariablesGlobal.Resultados)
            {


                Config frm = new Config();

                if (VariablesGlobal.Config)
                {
                    VariablesGlobal.Config = false;
                    frm.Close();
                }


                //Se liberan resursos de algun formulario abierto anteriormente
                terminal.Dispose();
                //Se cierra cualquier control existente en el panel contenedor
                panelDashContenedor.Controls.Clear();


                //Cambio de icono boton
                InterfaceConfig.banderaConfig = true;
                btnConfig.Enabled = true;

                if (InterfaceConfig.banderaTerminal)
                {
                    //btnResultados.BackgroundImage = Properties.Resources.Resul_True;
                    //btnResultados.BackgroundImageLayout = ImageLayout.Zoom;

                    //btnConfig.BackgroundImage = Properties.Resources.Config_False;
                    //btnConfig.BackgroundImageLayout = ImageLayout.Zoom;
                }

                ///Cargue del form Terminal
                //Se liberan resursos de algun formulario abierto anteriormente
                config.Dispose();
                //Se cierra cualquier control existente en el panel contenedor
                panelDashContenedor.Controls.Clear();

                //Se crea una instancia del formulario secundario
                terminal = new Resultados()
                {
                    //Se asignan propiedades al fomulario
                    TopLevel = false,
                    TopMost = true,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };

                //Se establece el panel contenedor como padre del formulario secundario
                panelDashContenedor.Controls.Add(terminal);
                //Se muestra el formulario
                terminal.Show();

                btnResultados.Enabled = false;
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Resultados frm = new Resultados();

            if (VariablesGlobal.Resultados)
            {
                VariablesGlobal.Resultados = false;
                frm.Close();
            }

            if (!VariablesGlobal.Config)
            {
                if (!VariablesGlobal.Conectar)
                {


                    //Cambio de icono boton


                    if (InterfaceConfig.banderaConfig)
                    {
                        //btnConfig.BackgroundImage = Properties.Resources.Config_True;
                        //btnConfig.BackgroundImageLayout = ImageLayout.Zoom;

                        //btnResultados.BackgroundImage = Properties.Resources.Resul_False;
                        //btnResultados.BackgroundImageLayout = ImageLayout.Zoom;
                    }
                    btnResultados.Enabled = true;
                    ///Cargue del form Config
                    //Se liberan resursos de algun formulario abierto anteriormente
                    terminal.Dispose();
                    //Se cierra cualquier control existente en el panel contenedor
                    panelDashContenedor.Controls.Clear();

                    //Se crea una instancia del formulario secundario
                    config = new Config()
                    {
                        //Se asignan propiedades al fomulario
                        TopLevel = false,
                        TopMost = true,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill
                    };

                    //Se establece el panel contenedor como padre del formulario secundario
                    panelDashContenedor.Controls.Add(config);
                    //Se muestra el formulario
                    config.Show();
                    VariablesGlobal.Config = true;

                }
                else
                {



                    DialogResult result;
                    using (var msFomr = new FormMessageBox("No se puede abrir la configuracion si esta conectada la interfaz. ", "Configuración denegada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation))
                        result = msFomr.ShowDialog();
                }
            }
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            using (var msFomr = new FormMessageBox("¿Desea cerrar la interfaz?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                result = msFomr.ShowDialog();
            }

            if (result.Equals(DialogResult.Yes))
            {
                Dispose();
                Environment.Exit(1);
            }
            else e.Cancel = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelDashContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {

                pnlSubMenu.Visible = true;
                panel2.Visible = true;

            }
            else
            {
                panel2.Visible = false;
                pnlSubMenu.Visible = false;


            }
            this.Invalidate();
        }

        private void rjButton1_MouseUp(object sender, MouseEventArgs e)
        {
            rjButton1.BackColor = EfectoColorHoverCargar;
            pictureBox1.BackColor = EfectoColorHoverCargar;
            this.Invalidate();
        }

        private void rjButton1_MouseMove(object sender, MouseEventArgs e)
        {
            rjButton1.MouseOverBackColor = EfectoColorHoverCargar;
            pictureBox1.BackColor = EfectoColorHoverCargar;
            this.Invalidate();
        }

        private void rjButton1_MouseEnter(object sender, EventArgs e)
        {
            rjButton1.BackColor = EfectoColorHoverCargar;
            pictureBox1.BackColor = EfectoColorHoverCargar;
            this.Invalidate();
        }

        private void rjButton1_MouseDown(object sender, MouseEventArgs e)
        {
            rjButton1.BackColor = EfectoColorHoverCargar;
            pictureBox1.BackColor = EfectoColorHoverCargar;
            this.Invalidate();
        }



        private void rjButton1_MouseHover_1(object sender, EventArgs e)
        {
            rjButton1.MouseOverBackColor = EfectoColorHoverCargar;
            pictureBox1.BackColor = EfectoColorHoverCargar;
            this.Invalidate();
        }

        private void rjButton1_MouseLeave(object sender, EventArgs e)
        {
            rjButton1.BackColor = primaryColor;
            pictureBox1.BackColor = primaryColor;
            this.Invalidate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            rjButton1_Click(sender, e);

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            rjButton1.BackColor = EfectoColorHoverCargar;
            pictureBox1.BackColor = EfectoColorHoverCargar;
            this.Invalidate();

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            rjButton1.MouseOverBackColor = EfectoColorHoverCargar;
            pictureBox1.BackColor = EfectoColorHoverCargar;
            this.Invalidate();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            rjButton1.BackColor = primaryColor;
            pictureBox1.BackColor = primaryColor;
            this.Invalidate();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            rjButton1.BackColor = EfectoColorHoverCargar;
            pictureBox1.BackColor = EfectoColorHoverCargar;
            this.Invalidate();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            if (rjButton2.Text == "Desconectar")
            {
                rjButton2.Text = "Conectar";
                rjButton2.BackgroundColor = colorConectar;
                pictureBox2.BackColor = colorConectar;
                rjButton2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
                pictureBox2.BackgroundImage = Properties.Resources.Conectar;
            }

            else
            {
                rjButton2.Text = "Desconectar";
                rjButton2.BackgroundColor = colorDesconectar;
                pictureBox2.BackColor = colorDesconectar;
                rjButton2.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
                pictureBox2.BackgroundImage = Properties.Resources.Desconectar;
            }
            this.Invalidate();

        }

        private void rjButton2_MouseHover(object sender, EventArgs e)
        {
            if (rjButton2.Text == "Desconectar")
            {
                rjButton2.MouseOverBackColor = colorConectar;
                pictureBox2.BackColor = colorConectar;
            }
            else
            {
                pictureBox2.BackColor = colorDesconectar;
                rjButton2.MouseOverBackColor = colorDesconectar;

            }
            this.Invalidate();
        }

        private void rjButton2_MouseLeave(object sender, EventArgs e)
        {
            if (rjButton2.Text == "Desconectar")
            {
                rjButton2.BackgroundColor = colorDesconectar;
                pictureBox2.BackColor = rjButton2.BackgroundColor;
            }
            else
            {
                rjButton2.BackgroundColor = colorConectar;
                pictureBox2.BackColor = rjButton2.BackgroundColor;
            }
            this.Invalidate();
        }

        //private void rjButton2_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (rjButton2.Text == "Desconectar")
        //    {
        //        rjButton2.MouseOverBackColor = colorConectar;
        //        pictureBox2.BackColor = colorConectar;
        //    }
        //    else
        //    {
        //        rjButton2.BackgroundColor = colorDesconectar;
        //        pictureBox2.BackColor = colorDesconectar;
        //    }
        //}

        private void rjButton2_MouseEnter(object sender, EventArgs e)
        {
            if (rjButton2.Text == "Desconectar")
            {
                rjButton2.BackgroundColor = colorConectar;
                pictureBox2.BackColor = colorConectar;
            }
            else
            {
                rjButton2.BackgroundColor = colorDesconectar;
                pictureBox2.BackColor = colorDesconectar;

            }
            this.Invalidate();
        }

        private void rjButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            int medio = this.Width / 2;

            int panel4Width = 490;
            int panel3Width = 231;
            int panelDashPaddingLeft = 30;
            int panelDashPaddingRight = 30;
            int panelDashPaddingTop = 7;
            int panelDashPaddingBottom = 7;
            Size panelDashSize = new Size(700, 600);

            if (medio >= 768 && medio <= 1024)
            {
                // Pantalla grande: ajusta el diseño para una pantalla grande
                panelDashPaddingLeft = 80;
                panelDashPaddingRight = 80;
                panelDashSize = new Size(900, 600);
                this.Invalidate();
            }

            if (medio >= 511 && medio <= 655)
            {
                // Ajustes específicos para este rango
                panel4Width = 420;
                panelDashPaddingLeft = 15;
                this.Invalidate();
            }

            if (medio >= 500 && medio <= 510)
            {
                // Ajustes específicos para este rango
                panel4Width = 390;
                panel3Width = 224;
                this.Invalidate();
            }

            if (medio <= 467)
            {
                // Ajustes específicos para este rango
                panel4Width = 350;
                panel3Width = 200;
                this.Invalidate();
            }

            // Aplicar configuraciones comunes
            panel4.Width = panel4Width;
            panel3.Width = panel3Width;
            panelDashContenedor.Padding = new Padding(panelDashPaddingLeft, panelDashPaddingTop, panelDashPaddingRight, panelDashPaddingBottom);
            panelDashContenedor.Size = panelDashSize;
            panel1.Padding = new Padding(30, 30, 30, 7); // Siempre se aplica este valor

            // Incrementa la altura de panel3 y panel4 proporcionalmente al tamaño actual de la ventana
            double proporcionAltura = 0.7; // Ajusta esta proporción según tus necesidades

            panel3.Height = Convert.ToInt32(panel4.Width * proporcionAltura);
            panel4.Height = Convert.ToInt32(panel4.Width * (1 - proporcionAltura));

            // Forzar la actualización del panelDashContenedor
            panelDashContenedor.Invalidate();

            // Ajustar automáticamente el tamaño y la posición de los controles según el modo de escala automática
            ScaleControls();
        }

        private void ScaleControls()
        {
            // Utilizar el modo de escala automática proporcionado por WinForms
            this.AutoScaleMode = AutoScaleMode.Dpi; // O AutoScaleMode.Font según tus preferencias

            // Forzar el rediseño y el repintado de los controles
            this.PerformLayout();
            this.Refresh();
        }


    }
}
