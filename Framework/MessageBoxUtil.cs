using System;
using System.Collections.Generic;

using System.Text;
using System.Windows.Forms;

namespace Framework
{
    public class MessageBoxUtil
    {
        public static DialogResult ShowTips(string message)
        {
            return MessageBox.Show(message, "Быстрое сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        public static DialogResult ShowWarning(string message)
        {
            return MessageBox.Show(message, "Быстрое сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static DialogResult ShowError(string message)
        {
            return MessageBox.Show(message, "Быстрое сообщение", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        public static DialogResult ShowYesNoAndError(string message)
        {
            return MessageBox.Show(message, "Быстрое сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
        }
       
        public static DialogResult ShowOkCancelAndTips(string message)
        {
            return MessageBox.Show(message, "Быстрое сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }
        public static DialogResult ShowYesNoAndWarning(string message)
        {
            return MessageBox.Show(message, "Быстрое сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }
        public static DialogResult ShowOkCancelAndWarning(string message)
        {
            return MessageBox.Show(message, "Быстрое сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }
        public static DialogResult ShowYesNoCancelAndTips(string message)
        {
            return MessageBox.Show(message, "Быстрое сообщение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
        }
    }
}
