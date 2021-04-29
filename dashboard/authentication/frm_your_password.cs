using System;
using System.Windows.Forms;
using dashboard.Class;


namespace dashboard
{
    public partial class frm_your_password : Form
    {
        #region main
        public frm_your_password()
        {
            InitializeComponent();
        }
        #endregion

        #region controls_events
        private void frm_your_password_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            DoubleBuffering.SetDoubleBuffering(label2, true);
            DoubleBuffering.SetDoubleBuffering(txtPass, true);
            DoubleBuffering.SetDoubleBuffering(btnRestore, true);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frm_login obj = new frm_login();
            obj.Show();
        }
        #endregion

        
    }
}
