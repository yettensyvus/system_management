namespace dashboard.custom_controls
{
    public static class CustomMessageBox
    {
        public static System.Windows.Forms.DialogResult ShowMessage(string message, string caption, System.Windows.Forms.MessageBoxButtons button, System.Windows.Forms.MessageBoxIcon icon)
        {
            System.Windows.Forms.DialogResult dlgResult = System.Windows.Forms.DialogResult.None;
            switch (button)
            {
                case System.Windows.Forms.MessageBoxButtons.OK:
                    using (frm_MessageOK msgOK = new frm_MessageOK())
                    {
                        msgOK.Text = caption;
                        msgOK.Message = message;
                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information: //success
                                msgOK.MessageIcon = Properties.Resources.checkmark_96px; 
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Question: //info
                                msgOK.MessageIcon = Properties.Resources.box_important_96px;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Error: //errorr
                                msgOK.MessageIcon = Properties.Resources.error_96px;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Warning: //warning
                                msgOK.MessageIcon = Properties.Resources.question_mark_96px;
                                break;
                        }
                        dlgResult = msgOK.ShowDialog();
                    }
                    break;

                case System.Windows.Forms.MessageBoxButtons.YesNo:
                    using (frm_MessageYesNo msgYesNo = new frm_MessageYesNo())
                    {
                        msgYesNo.Text = caption;
                        msgYesNo.Message = message;
                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information:
                                msgYesNo.MessageIcon = Properties.Resources.checkmark_96px;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Question:
                                msgYesNo.MessageIcon = Properties.Resources.box_important_96px;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Error:
                                msgYesNo.MessageIcon = Properties.Resources.error_96px;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Warning:
                                msgYesNo.MessageIcon = Properties.Resources.question_mark_96px;
                                break;
                        }
                        dlgResult = msgYesNo.ShowDialog();
                    }
                    break;
                    

                case System.Windows.Forms.MessageBoxButtons.RetryCancel:
                    using (frm_MessageError msgError = new frm_MessageError())
                    {
                        msgError.Text = caption;
                        msgError.Message = message;
                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information:
                                msgError.MessageIcon = Properties.Resources.checkmark_96px;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Question:
                                msgError.MessageIcon = Properties.Resources.box_important_96px;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Warning:
                                msgError.MessageIcon = Properties.Resources.question_mark_96px;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Error:
                                msgError.MessageIcon = Properties.Resources.error_96px;
                                break;
                        }
                        dlgResult = msgError.ShowDialog();
                    }
                    break;


                case System.Windows.Forms.MessageBoxButtons.OKCancel:
                    using (frm_MessageOKCancel msgOKCancel = new frm_MessageOKCancel())
                    {
                        msgOKCancel.Text = caption;
                        msgOKCancel.Message = message;
                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information:
                                msgOKCancel.MessageIcon = Properties.Resources.checkmark_96px;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Question:
                                msgOKCancel.MessageIcon = Properties.Resources.box_important_96px;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Warning:
                                msgOKCancel.MessageIcon = Properties.Resources.question_mark_96px;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Error:
                                msgOKCancel.MessageIcon = Properties.Resources.error_96px;
                                break;
                        }
                        dlgResult = msgOKCancel.ShowDialog();
                    }
                    break;
            }
            return dlgResult;
        }
    }
}
