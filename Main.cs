namespace PdfPasswordRemover;

using iText.Kernel.Exceptions;
using iText.Kernel.Pdf;
using System.Text;

public partial class Main : Form
{

    public Main()
    {
        this.InitializeComponent();
    }

    private void buttonShowPassword_Click(object sender, EventArgs e)
    {
        switch (this.textBoxPassword.PasswordChar)
        {
            case '*':
                this.textBoxPassword.PasswordChar = '\0';
                this.buttonShowPassword.Text = "Hide password";
                break;
            case '\0':
                this.textBoxPassword.PasswordChar = '*';
                this.buttonShowPassword.Text = "Show password";
                break;
        }
    }

    private void textBoxPassword_TextChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(this.textBoxPassword.Text.Trim()))
        {
            this.buttonRemovePassword.Enabled = true;
            return;
        }
        this.buttonRemovePassword.Enabled = false;
    }

    private void buttonRemovePassword_Click(object sender, EventArgs e)
    {
        try
        {
            var openFileDialog = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "*.pdf",
                Filter = "Pdf files|*.pdf",
                Multiselect = false,
                Title = "Please select a PDF file"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string fileName = openFileDialog.FileName;
            string userPassword = this.textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(userPassword))
            {
                MessageBox.Show("Enter a password");
                return;
            }

            var outputFolder = Path.GetDirectoryName(fileName);
            var outputFileName = Path.GetFileNameWithoutExtension(fileName) + "_unlocked" + Path.GetExtension(fileName);
            var finalFileName = Path.Combine(outputFolder, outputFileName);
            if (!this.saveInSameFolderCheckbox.Checked)
            {
                var saveFileDialog = new SaveFileDialog
                {
                    CheckPathExists = true,
                    DefaultExt = "*.pdf",
                    Filter = "Pdf files|*.pdf",
                    Title = "Please select a PDF file"
                };

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                finalFileName = saveFileDialog.FileName;
            }
            PdfDocument pdfDocument = null;
            try
            {
                byte[] OWNERPASS = Encoding.Default.GetBytes(userPassword);

                ReaderProperties readerProperties = new ReaderProperties().SetPassword(OWNERPASS);
                PdfReader pdfReader = new PdfReader(fileName, readerProperties);
                using var newpdf = new PdfWriter(finalFileName);
                pdfDocument = new PdfDocument(pdfReader, newpdf);
                pdfDocument.Close();

                MessageBox.Show("Password removed successfully.");
            }
            catch (BadPasswordException)
            {
                MessageBox.Show("Incorrect password. Password-protected PDF cannot be unlocked.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred: {ex.Message}");
            }
            finally
            {
                if (pdfDocument != null)
                {
                    pdfDocument.Close();
                }

            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }
    }
}
