using dashboard.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace dashboard
{
    public partial class frm_alert : Form
    {
        public frm_alert()
        {
            InitializeComponent();
            TopMost = true;
        }

        public enum alertTypeEnum
        {
            Success,
            Warning,
            Error,
            Info
        }

        private int x, y;
        public void setAlert(string msg, frm_alert.alertTypeEnum type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                frm_alert f = (frm_alert)Application.OpenForms[fname];

                if (f == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }

            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            switch (type)
            {
                case frm_alert.alertTypeEnum.Success:
                    this.GunaPictureBox1.Image = Resources.checkmark_96px;
                    this.BackColor = Color.FromArgb(42, 171, 160);
                    break;
                case frm_alert.alertTypeEnum.Warning:
                    this.GunaPictureBox1.Image = Resources.box_important_96px;
                    this.BackColor = Color.FromArgb(255, 179, 2);
                    break;
                case frm_alert.alertTypeEnum.Error:
                    this.GunaPictureBox1.Image = Resources.error_96px;
                    this.BackColor = Color.FromArgb(255, 121, 70);
                    break;
                case frm_alert.alertTypeEnum.Info:
                    this.GunaPictureBox1.Image = Resources.question_mark_96px;
                    this.BackColor = Color.FromArgb(71, 169, 248);
                    break;
            }
            this.GunaLabel1.Text = msg;

            this.Show();

            this.action = actionEnum.start;
            this.Timer1.Interval = 1;
            this.Timer1.Start();


        }

        public enum actionEnum
        {
            wait,
            start,
            close
        }

        private frm_alert.actionEnum action;


        private void GunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.Timer1.Interval = 1;
            this.action = frm_alert.actionEnum.close;
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case frm_alert.actionEnum.wait:
                    this.Timer1.Interval = 1000;
                    this.action = frm_alert.actionEnum.close;
                    break;
                case frm_alert.actionEnum.start:
                    this.Timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            this.action = frm_alert.actionEnum.wait;
                        }
                    }
                    break;
                case frm_alert.actionEnum.close:
                    this.Timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

    }
}
