namespace AssetPackCreatorUtilities
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void cmdRenameProject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || txtName.Text.Contains(" ") || !txtName.Text.ToLower().EndsWith("assetpack"))
            {
                MessageBox.Show("Please enter a name that ends with 'AssetPack' and does not contain any spaces or other characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string oldSolutionName = "CustomAssetPack";
            string newSolutionName = txtName.Text;

            // Look for sln file in current folder
            foreach (string file in Directory.GetFiles(Directory.GetCurrentDirectory()))
            {
                if (file.EndsWith(".sln"))
                {
                    oldSolutionName = Path.GetFileNameWithoutExtension(file);
                    break;
                }
            }
            if (MessageBox.Show("Detected Solution file: " + oldSolutionName + ".sln. Would you like to continue renaming it to " + newSolutionName + ".sln?" , "Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                // Lösche alte Solution-Datei
                File.Move($"{oldSolutionName}.sln", $"{newSolutionName}.sln");

                // Umbenenne Projektdatei (.csproj)
                File.Move($"{oldSolutionName}.csproj", $"{newSolutionName}.csproj");

                // Öffne Projektdatei und ersetze den alten Namen durch den neuen
                string csprojContent = File.ReadAllText($"{newSolutionName}.sln");
                csprojContent = csprojContent.Replace(oldSolutionName, newSolutionName);
                File.WriteAllText($"{newSolutionName}.sln", csprojContent);

                // Erfolgsmeldung anzeigen
                MessageBox.Show("Solution successfully renamed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Fehlermeldung anzeigen
                MessageBox.Show($"Error renaming solution: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
