using System;
using System.Windows.Forms;
using System.Drawing;

namespace Sudoku_GUI
{
    public class PanelWithBorder : Panel
    {
        private Color borderColor = Color.Black;

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate(); // Redibuja el control para aplicar el cambio de color del borde
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                borderColor,
                ButtonBorderStyle.Solid);
        }
    }
}
