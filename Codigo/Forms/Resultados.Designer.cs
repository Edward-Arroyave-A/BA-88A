namespace AnnarComMICROSESV60.Forms
{
    partial class Resultados
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
            this.timerIntervalos = new System.Windows.Forms.Timer(this.components);
            this.lblIntervalos = new System.Windows.Forms.Label();
            this.flpContenedorResul = new System.Windows.Forms.FlowLayoutPanel();
            this.chkDSR = new System.Windows.Forms.CheckBox();
            this.chkCD = new System.Windows.Forms.CheckBox();
            this.chkCTS = new System.Windows.Forms.CheckBox();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.rbHex = new System.Windows.Forms.RadioButton();
            this.chkClearWithDTR = new System.Windows.Forms.CheckBox();
            this.chkClearOnOpen = new System.Windows.Forms.CheckBox();
            this.chkRTS = new System.Windows.Forms.CheckBox();
            this.chkDTR = new System.Windows.Forms.CheckBox();
            this.tmrCheckComPorts = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerIntervalos
            // 
            this.timerIntervalos.Tick += new System.EventHandler(this.timerIntervalos_Tick);
            // 
            // lblIntervalos
            // 
            this.lblIntervalos.BackColor = System.Drawing.Color.Transparent;
            this.lblIntervalos.Location = new System.Drawing.Point(699, 583);
            this.lblIntervalos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntervalos.Name = "lblIntervalos";
            this.lblIntervalos.Size = new System.Drawing.Size(35, 15);
            this.lblIntervalos.TabIndex = 0;
            this.lblIntervalos.Text = "Timer";
            this.lblIntervalos.Visible = false;
            // 
            // flpContenedorResul
            // 
            this.flpContenedorResul.AutoScroll = true;
            this.flpContenedorResul.AutoSize = true;
            this.flpContenedorResul.BackColor = System.Drawing.Color.White;
            this.flpContenedorResul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpContenedorResul.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpContenedorResul.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.flpContenedorResul.Location = new System.Drawing.Point(0, 0);
            this.flpContenedorResul.Name = "flpContenedorResul";
            this.flpContenedorResul.Size = new System.Drawing.Size(797, 606);
            this.flpContenedorResul.TabIndex = 16;
            this.flpContenedorResul.WrapContents = false;
            this.flpContenedorResul.Paint += new System.Windows.Forms.PaintEventHandler(this.flpContenedorResul_Paint);
            // 
            // chkDSR
            // 
            this.chkDSR.AutoSize = true;
            this.chkDSR.Enabled = false;
            this.chkDSR.Location = new System.Drawing.Point(464, 295);
            this.chkDSR.Name = "chkDSR";
            this.chkDSR.Size = new System.Drawing.Size(47, 19);
            this.chkDSR.TabIndex = 29;
            this.chkDSR.Text = "DSR";
            this.chkDSR.UseVisualStyleBackColor = true;
            this.chkDSR.Visible = false;
            // 
            // chkCD
            // 
            this.chkCD.AutoSize = true;
            this.chkCD.Enabled = false;
            this.chkCD.Location = new System.Drawing.Point(410, 295);
            this.chkCD.Name = "chkCD";
            this.chkCD.Size = new System.Drawing.Size(42, 19);
            this.chkCD.TabIndex = 30;
            this.chkCD.Text = "CD";
            this.chkCD.UseVisualStyleBackColor = true;
            this.chkCD.Visible = false;
            // 
            // chkCTS
            // 
            this.chkCTS.AutoSize = true;
            this.chkCTS.Enabled = false;
            this.chkCTS.Location = new System.Drawing.Point(514, 245);
            this.chkCTS.Name = "chkCTS";
            this.chkCTS.Size = new System.Drawing.Size(45, 19);
            this.chkCTS.TabIndex = 28;
            this.chkCTS.Text = "CTS";
            this.chkCTS.UseVisualStyleBackColor = true;
            this.chkCTS.Visible = false;
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Location = new System.Drawing.Point(464, 270);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(46, 19);
            this.rbText.TabIndex = 31;
            this.rbText.Text = "Text";
            this.rbText.Visible = false;
            // 
            // rbHex
            // 
            this.rbHex.AutoSize = true;
            this.rbHex.Location = new System.Drawing.Point(410, 270);
            this.rbHex.Name = "rbHex";
            this.rbHex.Size = new System.Drawing.Size(46, 19);
            this.rbHex.TabIndex = 32;
            this.rbHex.Text = "Hex";
            this.rbHex.Visible = false;
            // 
            // chkClearWithDTR
            // 
            this.chkClearWithDTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkClearWithDTR.AutoSize = true;
            this.chkClearWithDTR.Location = new System.Drawing.Point(170, 267);
            this.chkClearWithDTR.Name = "chkClearWithDTR";
            this.chkClearWithDTR.Size = new System.Drawing.Size(103, 19);
            this.chkClearWithDTR.TabIndex = 34;
            this.chkClearWithDTR.Text = "Clear with DTR";
            this.chkClearWithDTR.UseVisualStyleBackColor = true;
            this.chkClearWithDTR.Visible = false;
            // 
            // chkClearOnOpen
            // 
            this.chkClearOnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkClearOnOpen.AutoSize = true;
            this.chkClearOnOpen.Location = new System.Drawing.Point(55, 267);
            this.chkClearOnOpen.Name = "chkClearOnOpen";
            this.chkClearOnOpen.Size = new System.Drawing.Size(105, 19);
            this.chkClearOnOpen.TabIndex = 33;
            this.chkClearOnOpen.Text = "Clear on Open";
            this.chkClearOnOpen.UseVisualStyleBackColor = true;
            this.chkClearOnOpen.Visible = false;
            // 
            // chkRTS
            // 
            this.chkRTS.AutoSize = true;
            this.chkRTS.Location = new System.Drawing.Point(464, 245);
            this.chkRTS.Name = "chkRTS";
            this.chkRTS.Size = new System.Drawing.Size(44, 19);
            this.chkRTS.TabIndex = 36;
            this.chkRTS.Text = "RTS";
            this.chkRTS.UseVisualStyleBackColor = true;
            this.chkRTS.Visible = false;
            // 
            // chkDTR
            // 
            this.chkDTR.AutoSize = true;
            this.chkDTR.Location = new System.Drawing.Point(410, 245);
            this.chkDTR.Name = "chkDTR";
            this.chkDTR.Size = new System.Drawing.Size(46, 19);
            this.chkDTR.TabIndex = 35;
            this.chkDTR.Text = "DTR";
            this.chkDTR.UseVisualStyleBackColor = true;
            this.chkDTR.Visible = false;
            // 
            // tmrCheckComPorts
            // 
            this.tmrCheckComPorts.Interval = 580;
            this.tmrCheckComPorts.Tick += new System.EventHandler(this.tmrCheckComPorts_Tick);
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(797, 606);
            this.Controls.Add(this.chkRTS);
            this.Controls.Add(this.chkDTR);
            this.Controls.Add(this.chkClearWithDTR);
            this.Controls.Add(this.chkClearOnOpen);
            this.Controls.Add(this.rbText);
            this.Controls.Add(this.rbHex);
            this.Controls.Add(this.chkDSR);
            this.Controls.Add(this.chkCD);
            this.Controls.Add(this.chkCTS);
            this.Controls.Add(this.lblIntervalos);
            this.Controls.Add(this.flpContenedorResul);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Resultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terminal";
            this.Load += new System.EventHandler(this.Terminal_Load);
            this.Shown += new System.EventHandler(this.Resultados_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerIntervalos;
        private System.Windows.Forms.Label lblIntervalos;
        private System.Windows.Forms.FlowLayoutPanel flpContenedorResul;
        private System.Windows.Forms.CheckBox chkDSR;
        private System.Windows.Forms.CheckBox chkCD;
        private System.Windows.Forms.CheckBox chkCTS;
        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.RadioButton rbHex;
        private System.Windows.Forms.CheckBox chkClearWithDTR;
        private System.Windows.Forms.CheckBox chkClearOnOpen;
        private System.Windows.Forms.CheckBox chkRTS;
        private System.Windows.Forms.CheckBox chkDTR;
        private System.Windows.Forms.Timer tmrCheckComPorts;
    }
}