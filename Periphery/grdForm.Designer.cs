using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Periphery
{
    partial class grdForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Color transitionColor = Color.Black;
        private System.ComponentModel.IContainer components = null;
        private string id = "";

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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "grdForm";
        }

        #endregion
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (id == "left")
            {

                using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,  Color.Black, this.transitionColor, 0F))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
            }
            else if (id == "right")
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.transitionColor, Color.Black, 0F))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
            }
        }
        public void setTransitionColor(Color c)
        {
            transitionColor = c;
        }
        public void setId(string s)
        {
            id = s;
        }

    }
}