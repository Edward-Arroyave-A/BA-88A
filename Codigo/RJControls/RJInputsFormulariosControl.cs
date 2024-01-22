﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AnnarComMICROSESV60.RJControls
{
    [DefaultEvent("_TextChanged")]
    public partial class RJInputsFormulariosControl : UserControl
    {
      
        public RJInputsFormulariosControl()
        {
           
            InitializeComponent();
             RjTextBoxControl1_TextChanged();
            
            // Agrega el evento Resize
            // Agrega el evento TextChanged
            // Agrega el evento TextChanged
        }

        private void RjTextBoxControl1_TextChanged()
        {
           
                // Verifica si el texto del rjTextBoxControl1 está en nulo o es una cadena vacía
                if (string.IsNullOrEmpty(rjTextBoxControl1.Texts))
                {
                    label2.Visible = true;
                    label1.ForeColor = Color.Red;
                this.Invalidate();
                // Cambia el color del texto de label1 a rojo
            }
                else
                {
                label2.Visible = false;
                label1.ForeColor = Color.FromArgb(46, 189, 255);
                this.Invalidate();
                // Restablece el color del texto de label1
            }
            
        }

    
        // Propiedades expuestas para rjTextBoxControl1

        [Category("RJ Code Advance")]
        public bool Multiline
        {
            get { return rjTextBoxControl1.Multiline; }
            set { rjTextBoxControl1.Multiline = value; }
        }

        [Category("RJ Code Advance")]
        public int BorderRadius
        {
            get { return rjTextBoxControl1.BorderRadius; }
            set { rjTextBoxControl1.BorderRadius = value; }
        }


        [Category("RJ Code Advance")]
        public Size TextBoxSize
        {
            get { return rjTextBoxControl1.Size; }
            set { rjTextBoxControl1.Size = value; }
        }


        [Category("RJ Code Advance")]
        public string LabelText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        private void rjTextBoxControl1_Leave(object sender, EventArgs e)
        {
            
            rjTextBoxControl1.textBox1_Leave(sender, e);
            RjTextBoxControl1_TextChanged();
        }

        private void rjTextBoxControl1_TextBoxTextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rjTextBoxControl1.Texts))
            {
                label2.Visible = true;
                label1.ForeColor = Color.Red;
                //this.Invalidate();
                // Cambia el color del texto de label1 a rojo
            }
            else
            {
                label2.Visible = false;
                this.Invalidate();
                label1.ForeColor = rjTextBoxControl1.BorderColor;
              
                //this.Invalidate();
                // Restablece el color del texto de label1
            }
        }

       
    }
}
