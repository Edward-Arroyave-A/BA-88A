﻿using AnnarComMICROSESV60.Properties;
using System;
using System.Drawing;

namespace AnnarComMICROSESV60
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pnlForm = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();

            this.rjbConectar = new AnnarComMICROSESV60.RJControls.RJButton();
            this.rjbTitulo = new AnnarComMICROSESV60.RJControls.RJButton();


            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelNav.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;

            this.pnlForm.Location = new System.Drawing.Point(349, 108);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1002, 723);

            this.pnlForm.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));

            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.41532F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.58468F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.Controls.Add(this.rjbConectar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rjbTitulo, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(349, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.27711F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.72289F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1002, 108);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // rjbConectar
            // 
            this.rjbConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.rjbConectar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.rjbConectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rjbConectar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbConectar.BorderRadius = 11;
            this.rjbConectar.BorderSize = 0;
            this.rjbConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbConectar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjbConectar.FlatAppearance.BorderSize = 0;
            this.rjbConectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.rjbConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbConectar.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Bold);
            this.rjbConectar.FontSize = 14F;
            this.rjbConectar.ForeColor = System.Drawing.Color.White;
            this.rjbConectar.Image = global::AnnarComMICROSESV60.Properties.Resources.Conectar;
            this.rjbConectar.Location = new System.Drawing.Point(641, 25);
            this.rjbConectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjbConectar.MouseOverBackColor = System.Drawing.Color.White;
            this.rjbConectar.Name = "rjbConectar";
            this.rjbConectar.Size = new System.Drawing.Size(343, 76);
            this.rjbConectar.TabIndex = 11;
            this.rjbConectar.Text = "Conectar";
            this.rjbConectar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjbConectar.TextColor = System.Drawing.Color.White;
            this.rjbConectar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjbConectar.UseVisualStyleBackColor = false;
            this.rjbConectar.Click += new System.EventHandler(this.rjbConectar_Click);
            this.rjbConectar.MouseLeave += new System.EventHandler(this.rjbConectar_MouseLeave);
            this.rjbConectar.MouseHover += new System.EventHandler(this.rjbConectar_MouseHover);
            // 
            // rjbTitulo
            // 
            this.rjbTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.rjbTitulo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.rjbTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rjbTitulo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbTitulo.BorderRadius = 10;
            this.rjbTitulo.BorderSize = 0;
            this.rjbTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjbTitulo.FlatAppearance.BorderSize = 0;
            this.rjbTitulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.rjbTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbTitulo.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Bold);
            this.rjbTitulo.FontSize = 14F;
            this.rjbTitulo.ForeColor = System.Drawing.Color.White;
            this.rjbTitulo.Image = global::AnnarComMICROSESV60.Properties.Resources.btn_carga2;
            this.rjbTitulo.Location = new System.Drawing.Point(8, 25);
            this.rjbTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjbTitulo.MouseOverBackColor = System.Drawing.Color.White;
            this.rjbTitulo.Name = "rjbTitulo";
            this.rjbTitulo.Size = new System.Drawing.Size(627, 76);
            this.rjbTitulo.TabIndex = 12;
            this.rjbTitulo.Text = "    Carga Resultados";
            this.rjbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjbTitulo.TextColor = System.Drawing.Color.White;
            this.rjbTitulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjbTitulo.UseVisualStyleBackColor = false;
            this.rjbTitulo.MouseLeave += new System.EventHandler(this.rjbTitulo_MouseLeave);
            this.rjbTitulo.MouseHover += new System.EventHandler(this.rjbTitulo_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rjbCerrarSesion);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 560);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 271);
            this.panel1.TabIndex = 8;
            // 
            // rjbCerrarSesion
            // 
            this.rjbCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.rjbCerrarSesion.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjbCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rjbCerrarSesion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbCerrarSesion.BorderRadius = 8;
            this.rjbCerrarSesion.BorderSize = 0;
            this.rjbCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbCerrarSesion.FlatAppearance.BorderSize = 0;
            this.rjbCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.rjbCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rjbCerrarSesion.FontSize = 18F;
            this.rjbCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.rjbCerrarSesion.Image = global::AnnarComMICROSESV60.Properties.Resources.btn_cerrar_sesion;
            this.rjbCerrarSesion.Location = new System.Drawing.Point(120, 16);
            this.rjbCerrarSesion.MouseOverBackColor = System.Drawing.Color.White;
            this.rjbCerrarSesion.Name = "rjbCerrarSesion";
            this.rjbCerrarSesion.Padding = new System.Windows.Forms.Padding(2);
            this.rjbCerrarSesion.Size = new System.Drawing.Size(104, 97);
            this.rjbCerrarSesion.TabIndex = 8;
            this.rjbCerrarSesion.TextColor = System.Drawing.Color.White;
            this.rjbCerrarSesion.UseVisualStyleBackColor = false;
            this.rjbCerrarSesion.Click += new System.EventHandler(this.rjbCerrarSesion_Click);
            this.rjbCerrarSesion.MouseLeave += new System.EventHandler(this.rjbCerrarSesion_MouseLeave);
            this.rjbCerrarSesion.MouseHover += new System.EventHandler(this.rjbCerrarSesion_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AnnarComMICROSESV60.Properties.Resources.by_it_health_blanco;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(80, 174);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 30);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panelNav
            // 
            this.panelNav.AutoScroll = true;
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.panelNav.BackgroundImage = global::AnnarComMICROSESV60.Properties.Resources.FondoDashboard_2x;
            this.panelNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelNav.Controls.Add(this.panel1);
            this.panelNav.Controls.Add(this.rjbConfiguracion);
            this.panelNav.Controls.Add(this.rjbResultados);
            this.panelNav.Controls.Add(this.panel3);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(349, 831);
            this.panelNav.TabIndex = 0;
            // 
            // rjbConfiguracion
            // 
            this.rjbConfiguracion.BackColor = System.Drawing.Color.White;
            this.rjbConfiguracion.BackgroundColor = System.Drawing.Color.White;
            this.rjbConfiguracion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbConfiguracion.BorderRadius = 10;
            this.rjbConfiguracion.BorderSize = 0;
            this.rjbConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbConfiguracion.FlatAppearance.BorderSize = 0;
            this.rjbConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbConfiguracion.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.rjbConfiguracion.FontSize = 12F;
            this.rjbConfiguracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.rjbConfiguracion.Image = global::AnnarComMICROSESV60.Properties.Resources.btn_configuracion;
            this.rjbConfiguracion.Location = new System.Drawing.Point(44, 420);
            this.rjbConfiguracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjbConfiguracion.MouseOverBackColor = System.Drawing.Color.Empty;
            this.rjbConfiguracion.Name = "rjbConfiguracion";
            this.rjbConfiguracion.Size = new System.Drawing.Size(268, 71);
            this.rjbConfiguracion.TabIndex = 10;
            this.rjbConfiguracion.Text = "    Configuración";
            this.rjbConfiguracion.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.rjbConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjbConfiguracion.UseVisualStyleBackColor = false;
            this.rjbConfiguracion.Click += new System.EventHandler(this.rjbConfiguracion_Click);
            // 
            // rjbResultados
            // 
            this.rjbResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(121)))), ((int)(((byte)(217)))));
            this.rjbResultados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(121)))), ((int)(((byte)(217)))));
            this.rjbResultados.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbResultados.BorderRadius = 10;
            this.rjbResultados.BorderSize = 0;
            this.rjbResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbResultados.FlatAppearance.BorderSize = 0;
            this.rjbResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbResultados.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.rjbResultados.FontSize = 12F;
            this.rjbResultados.ForeColor = System.Drawing.Color.White;
            this.rjbResultados.Image = global::AnnarComMICROSESV60.Properties.Resources.btn_carga2;
            this.rjbResultados.Location = new System.Drawing.Point(44, 309);
            this.rjbResultados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjbResultados.MouseOverBackColor = System.Drawing.Color.Empty;
            this.rjbResultados.Name = "rjbResultados";
            this.rjbResultados.Size = new System.Drawing.Size(268, 74);
            this.rjbResultados.TabIndex = 9;
            this.rjbResultados.Text = "    Carga \r\n    Resultados";
            this.rjbResultados.TextColor = System.Drawing.Color.White;
            this.rjbResultados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjbResultados.UseVisualStyleBackColor = false;
            this.rjbResultados.Click += new System.EventHandler(this.rjbResultados_Click);
            // 

            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);

            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 268);

            this.panel3.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::AnnarComMICROSESV60.Properties.Resources.Logo_Live_LIS;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            this.pictureBox2.Location = new System.Drawing.Point(79, 76);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 121);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 

            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 675);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelNav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.SizeChanged += new System.EventHandler(this.Dashboard_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelNav.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        private void rjbCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rjbCerrarSesion_MouseLeave(object sender, EventArgs e)
        {
            rjbCerrarSesion.Image = Resources.btn_cerrar_sesion;
        }

        public void rjbCerrarSesion_MouseHover(object sender, EventArgs e)
        {
            rjbCerrarSesion.Image = Resources.btn_cerrar_sesion_blue;
        }

        private void rjbTitulo_MouseHover(object sender, EventArgs e)
        {
            rjbTitulo.Image = Resources.btn_carga3;
            rjbTitulo.ForeColor = Color.FromArgb(46, 189, 255);
        }

        private void rjbTitulo_MouseLeave(object sender, EventArgs e)
        {
            rjbTitulo.Image = Resources.btn_carga2;
            rjbTitulo.ForeColor = Color.White;
        }

        private void rjbConectar_MouseHover(object sender, EventArgs e)
        {
            if (estadoBtnConectar)
            {
                rjbConectar.Image = Resources.Conectar_cian;
                rjbConectar.TextColor = Color.FromArgb(21, 224, 213);
            }
            else
            {
                rjbConectar.Image = Resources.Desconectar_gray;
                rjbConectar.TextColor = Color.FromArgb(163, 162, 162);
            }
        }

        private void rjbConectar_MouseLeave(object sender, EventArgs e)
        {
            if (estadoBtnConectar)
            {
                rjbConectar.Image = Resources.Conectar;
                rjbConectar.TextColor = Color.White;
            }
            else
            {
                rjbConectar.Image = Resources.Desconectar;
                rjbConectar.TextColor = Color.White;
            }
        }

        #endregion
        private System.Windows.Forms.Panel pnlForm;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RJControls.RJButton rjbConectar;
        private RJControls.RJButton rjbTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJControls.RJButton rjbResultados;
        private RJControls.RJButton rjbConfiguracion;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RJControls.RJButton rjbCerrarSesion;
    }
}