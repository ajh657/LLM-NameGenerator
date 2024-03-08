using System;
using System.Linq;
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

        public static string FirstCharToUpper(this string input) =>
        input switch
        {
            null => throw new ArgumentNullException(nameof(input)),
            "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
            _ => string.Concat(input[0].ToString().ToUpper(), input.AsSpan(1))
        };

        public static string[] GetFriendlyModelNames(this string[] modelList)
        {
            return modelList.Select(x => Constants.UnderscoreBetweenNumbers().Replace(x, "."))
                            .Select(x => x.Replace('-', ' '))
                            .Select(x => x.FirstCharToUpper())
                            .ToArray();
        }

    }
}
