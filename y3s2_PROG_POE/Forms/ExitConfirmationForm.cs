using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace y3s2_PROG_POE.Forms
{
    public partial class ExitConfirmationForm : Form
    {
        public bool IsConfirmed { get; private set; }

        public ExitConfirmationForm()
        {
            InitializeComponent();
            IsConfirmed = false;
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitConfirmationForm_Load(object sender, EventArgs e)
        {

        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Sets value of confirmation - results in closing the report form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfrim_Click(object sender, EventArgs e)
        {
            IsConfirmed = true;
            this.Close();
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Cancels exit procedure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

    }
}
		/*-----------------------------------------------------------------End of File--------------------------------------------------------------------------*/
