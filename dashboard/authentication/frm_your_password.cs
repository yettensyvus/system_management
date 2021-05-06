using System;
using System.Windows.Forms;


namespace dashboard
{
    public partial class frm_your_password : Form
    {
        #region main
        public frm_your_password()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        #endregion

        #region controls_events
        private void btnRestore_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frm_login obj = new frm_login();
            obj.Show();
        }
        #endregion

        
    }
}
