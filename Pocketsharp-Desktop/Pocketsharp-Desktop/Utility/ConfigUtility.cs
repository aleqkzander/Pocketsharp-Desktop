using Pocketsharp_Desktop.Objects;

namespace Pocketsharp_Desktop.Utility
{
    internal class ConfigUtility
    {
        readonly static string executableDirectory = AppDomain.CurrentDomain.BaseDirectory;
        readonly static string configFolder = Path.Combine(executableDirectory, "Config");
        readonly static string filePath = Path.Combine(configFolder, "config.txt");

        public static void Save(string text)
        {
            try
            {
                if (!Directory.Exists(configFolder))
                    Directory.CreateDirectory(configFolder);

                using (StreamWriter writer = new(filePath)) writer.Write(text);
                MessageBox.Show("Saved file successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occurred: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string Load()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string fileContent = File.ReadAllText(filePath);
                    return fileContent;
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        public static void Delete()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    MessageBox.Show("File deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}