using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenAINameGenerator.Util
{
    public static class Extensions
    {
        public static void ShowError(string title, string body)
        {
            MessageBox.Show(body, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowError(string body)
        {
            MessageBox.Show(body, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ConformationDialogueBox(string title, string body)
        {
            return MessageBox.Show(body, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        public static DialogResult ConformationDialogueBox(string body)
        {
            return MessageBox.Show(body, "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

    }
}
