namespace Pocketsharp_Desktop.Utility
{
    internal class TextBoxUtility
    {
        public static void AddTODOEntry(RichTextBox richTextBox, string todo)
        {
            richTextBox.Text += "TODO: " + todo + "\n";
        }

        public static void AddINFOEntry(RichTextBox richTextBox, string info)
        {
            richTextBox.Text += "INFO: " + info + "\n";
        }

        public static void ClearStatusBox(RichTextBox richTextBox)
        {
            richTextBox.Clear();
        }

        public static void SetupTextBox(TextBox textBox, string? placeholder = null, string? text = null)
        {
            textBox.PlaceholderText = placeholder;
            textBox.Text = text;
        }
    }
}
