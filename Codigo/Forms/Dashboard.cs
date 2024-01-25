using AnnarComMICROSESV60.Forms;
using AnnarComMICROSESV60.Properties;
using AnnarComMICROSESV60.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;
using static AnnarComMICROSESV60.Forms.Resultados;

namespace AnnarComMICROSESV60
{
    public partial class Dashboard : Form
    {
        public string token = string.Empty;
        Resultados terminal = new Resultados();
        Config config = new Config();
        private Form activeForm = null;
        private string espacioTexto = "    ";
        private bool estadoBtnConectar = true;

        public Dashboard()
        {
            InitializeComponent();
            Text = InterfaceConfig.nombreEquipo + " - v" + Application.ProductVersion;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            rjbResultados.PerformClick();
        }

        private void Dashboard_SizeChanged(object sender, EventArgs e)
        {
            var widthClient = this.ClientSize.Width;
            if (widthClient <= 1000) rjbConectar.Text = "";
            else
            {
                if (estadoBtnConectar) rjbConectar.Text = "Conectar";
                else rjbConectar.Text = "Desconectar";
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.MdiParent = this;
            childForm.TopLevel = false;
            childForm.TopMost = true;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //pnlForm.Controls.Add(childForm);
            //pnlForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            using (var msFomr = new FormMessageBox("¿Desea cerrar la interfaz?", "Advertencia", MessageBoxButtons.YesNo))
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

        private void rjbConectar_Click(object sender, EventArgs e)
        {
            //Activación del puerto
            terminal.AbrirPuerto();

            if (estadoBtnConectar)
            {
                rjbConectar.BackgroundColor = Color.FromArgb(163, 162, 162);
                rjbConectar.Text = "Desconectar";
                rjbConectar.Image = Resources.Desconectar;
                estadoBtnConectar = false;
            }
            else
            {
                rjbConectar.BackgroundColor = Color.FromArgb(21, 224, 213);
                rjbConectar.Text = "Conectar";
                rjbConectar.Image = Resources.Conectar;
                estadoBtnConectar = true;
            }
            Dashboard_SizeChanged(sender, e);
            rjbConectar_MouseHover(sender, e);
        }

        private void rjbResultados_Click(object sender, EventArgs e)
        {
            //InterfaceConfig.InitializeConfig();

            rjbConfiguracion.BackColor = Color.White;
            rjbConfiguracion.Image = Resources.btn_configuracion;
            rjbConfiguracion.ForeColor = Color.FromArgb(62, 62, 62);

            rjbTitulo.Text = espacioTexto + "Carga de Resultados";

            rjbResultados.BackColor = Color.FromArgb(99, 121, 217);
            rjbResultados.Image = Resources.btn_carga2;
            rjbResultados.ForeColor = Color.White;

            //OpenChildForm(new Resultados());

            if (activeForm != null) activeForm.Close();
            terminal.MdiParent = this;
            terminal.TopLevel = false;
            terminal.FormBorderStyle = FormBorderStyle.None;
            terminal.Dock = DockStyle.Fill;
            terminal.Show();

            VariablesGlobal.Config = false;
        }

        private void rjbConfiguracion_Click(object sender, EventArgs e)
        {
            rjbResultados.BackColor = Color.White;
            rjbResultados.Image = Resources.btn_carga1;
            rjbResultados.ForeColor = Color.FromArgb(62, 62, 62);

            rjbTitulo.Text = espacioTexto + "Configuración";

            rjbConfiguracion.BackColor = Color.FromArgb(21, 224, 213);
            rjbConfiguracion.Image = Resources.btn_configuracion_white;
            rjbConfiguracion.ForeColor = Color.White;

            terminal.flpCOMVisible = false;
            //terminal.LimpiarTerminal();

            OpenChildForm(new Config());

            VariablesGlobal.Config = true;
        }

        private void rjbTitulo_Click(object sender, EventArgs e)
        {
            // Cambia la visibilidad de los FlowLayoutPanel en el formulario hijo
            if (terminal != null)
            {
                //terminal.flpCOMVisible = !terminal.flpCOMVisible;
                if (!terminal.flpCOMVisible)
                {
                    terminal.flpCOMVisible = true;
                }
                else
                {
                    terminal.flpCOMVisible = false;
                }
            }
        }

        public int timerInterval
        {
            get { return timer1.Interval; }
            set
            {
                timer1.Interval = value;
            }
        }
    }
}
