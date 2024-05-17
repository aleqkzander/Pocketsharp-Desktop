namespace Pocketsharp_Desktop.Utility
{
    internal class DialogUtility
    {
        public static bool ShowYesNoDialog(string message, string caption)
        {
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result.Equals(DialogResult.Yes);
        }
    }
}
