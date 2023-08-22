using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Sudoku_GUI
{
    internal class buttonTemplate : Button
    {
        private Color backgroundColorOnEnter = Color.FromArgb(100, 225, 218);
        private Color foregroundColorOnEnter = Color.FromArgb(10, 26, 36);
        private Color backgroundColorOnLeave = Color.FromArgb(10, 26, 36);
        private Color foregroundColorOnLeave = Color.FromArgb(100, 225, 218);

        public Color BackgroundColorOnEnter
        {
            get { return backgroundColorOnEnter; }
            set { backgroundColorOnEnter = value; }
        }

        public Color ForegroundColorOnEnter
        {
            get { return foregroundColorOnEnter; }
            set { foregroundColorOnEnter = value; }
        }

        public Color BackgroundColorOnLeave
        {
            get { return backgroundColorOnLeave; }
            set { backgroundColorOnLeave = value; }
        }

        public Color ForegroundColorOnLeave
        {
            get { return foregroundColorOnLeave; }
            set { foregroundColorOnLeave = value; }
        }

        public buttonTemplate()
        {
            FlatAppearance.BorderSize = 0; // Configuración predeterminada
            FlatStyle = FlatStyle.Flat;    // Configuración predeterminada
            BackColor = Color.FromArgb(10, 26, 36);
            ForeColor = Color.FromArgb(100, 225, 218);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            MouseEnter += CustomButton_MouseEnter;
            MouseLeave += CustomButton_MouseLeave;
        }

        private void CustomButton_MouseEnter(object sender, EventArgs e)
        {
            BackColor = backgroundColorOnEnter;
            ForeColor = foregroundColorOnEnter;
        }

        private void CustomButton_MouseLeave(object sender, EventArgs e)
        {
            BackColor = backgroundColorOnLeave;
            ForeColor = foregroundColorOnLeave;
        }

    }
}
