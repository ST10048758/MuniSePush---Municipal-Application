using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace y3s2_PROG_POE.Classes
{
    public class CustomProgressBar : ProgressBar
    {
        public CustomProgressBar()
        {
            // Enable double buffering to avoid flicker
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        /// <summary>
        /// Method to draw the progress bar for the overall report completion display.
        ///     -> Code sourced from ChatGPT
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            // Calculate the percentage of progress
            Rectangle rect = this.ClientRectangle;
            Graphics g = e.Graphics;

            // Draw the progress bar background
            ProgressBarRenderer.DrawHorizontalBar(g, rect);

            // Get the width of the progress
            rect.Inflate(-3, -3); // Optional: padding inside the bar
            rect.Width = (int)(rect.Width * ((double)this.Value / this.Maximum));

            // Fill the progress bar with custom color
            using (Brush brush = new SolidBrush(Color.DarkOrange)) 
            {
                g.FillRectangle(brush, rect);
            }
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

    }
}
		/*-----------------------------------------------------------------End of File--------------------------------------------------------------------------*/

