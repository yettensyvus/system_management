using System.Drawing;
using System.Windows.Forms;

namespace dashboard.custom_controls
{
    public partial class frm_MessageError : Form
    {
        public frm_MessageError()
        {
            InitializeComponent();
        }

        public Image MessageIcon
        {
            get { return icon.Image; }
            set { icon.Image = value; }
        }

        public string Message
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value; }
        }
    }
}
