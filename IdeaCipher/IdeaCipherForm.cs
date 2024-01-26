    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IdeaCipher
    {
        public partial class cipherForm : Form
        {
            private String inputFilename;
            private String tempInputFilename = "tempPlainText.txt";
            private String tempOutputFilename = "tempEncryptedData.dat";
            private readonly string enteredUsername;


        public cipherForm(string username)
        {
            InitializeComponent();
            enteredUsername = username; // Set the username
            usernametext.Text = "Welcome, " + enteredUsername; // Display the username
        }
        public cipherForm()
            {
                InitializeComponent();
            }

            private void btnEncrypt_Click(object sender, EventArgs e)
            {
                if ((inputKey.TextLength < 16) || (inputKey.TextLength > 16))
                {
                    MessageBox.Show("Input Key must be 16 digit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inputKey.Text = "";
                    inputKey.Focus();
                    return;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(inputPlainText.Text))
                    {
                        MessageBox.Show("Input text should not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrWhiteSpace(inputKey.Text))
                    {
                        MessageBox.Show("Key word should be specified!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        File.WriteAllText(tempInputFilename, inputPlainText.Text);
                        IdeaCrypt.cryptFile(tempInputFilename, tempOutputFilename, inputKey.Text, true);
                        inputEncryptedText.Text = (String.Join(" ", File.ReadAllBytes(tempOutputFilename)));
                    }
                }

            }

            private void btnDecrypt_Click(object sender, EventArgs e)
            {
                if ((inputKey.TextLength < 16) || (inputKey.TextLength > 16))
                {
                    MessageBox.Show("Input Key must be 16 digit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inputKey.Text = "";
                    inputKey.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(inputEncryptedText.Text))
                {
                    MessageBox.Show("Input text should not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrWhiteSpace(inputKey.Text))
                {
                    MessageBox.Show("Key word should be specified!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    String[] values = inputEncryptedText.Text.Split(' ');
                    byte[] bytes = new byte[values.Length];
                    for (int i = 0; i < values.Length; i++)
                    {
                        bytes[i] = Byte.Parse(values[i]);
                    }
                    File.WriteAllBytes(tempOutputFilename, bytes);
                    try
                    {
                        IdeaCrypt.cryptFile(tempOutputFilename, tempInputFilename, inputKey.Text, false);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    //byte[] datafile = File.ReadAllBytes(tempInputFilename);
                    //foreach (byte s in datafile)
                    //{
                    //    inputPlainText.Text=inputPlainText.Text + s;
                    //}
                    inputPlainText.Text = File.ReadAllText(tempInputFilename);
                }
            }

            private void btnPlainLoad_Click(object sender, EventArgs e)
            {
                DialogResult result = dlgPlainFile.ShowDialog();
                if (result == DialogResult.OK)
                {
                    inputFilename = dlgPlainFile.FileName;
                    //byte[] datafile = File.ReadAllBytes(inputFilename); //File.ReadAllBytes(tempInputFilename);
                    //foreach (byte s in datafile)
                    //{
                    //    inputPlainText.Text = inputPlainText.Text + s;
                    //}
                    inputPlainText.Text = File.ReadAllText(inputFilename);
                }
            }

            private void btnEncryptedLoad_Click(object sender, EventArgs e)
            {
                DialogResult result = dlgEncryptedFile.ShowDialog();
                if (result == DialogResult.OK)
                {
                    inputFilename = dlgEncryptedFile.FileName;
                    inputEncryptedText.Text = String.Join(" ", File.ReadAllBytes(inputFilename));
                }
            }

            private void btnPlainSave_Click(object sender, EventArgs e)
            {
                if (dlgPlainFileSave.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dlgPlainFileSave.FileName, inputPlainText.Text);
                }
            }

            private void btnEncryptedSave_Click(object sender, EventArgs e)
            {
                if (dlgEncryptedFileSave.ShowDialog() == DialogResult.OK)
                {
                    String[] values = inputEncryptedText.Text.Split(' ');
                    byte[] bytes = new byte[values.Length];
                    for (int i = 0; i < values.Length; i++)
                    {
                        bytes[i] = Byte.Parse(values[i]);
                    }
                    File.WriteAllBytes(dlgEncryptedFileSave.FileName, bytes);
                }
            }

            private void chkViewKey_CheckedChanged(object sender, EventArgs e)
            {
                if (chkViewKey.Checked)
                {
                    inputKey.UseSystemPasswordChar = false;
                }
                else
                {
                    inputKey.UseSystemPasswordChar = true;

                }
            }

            private void btnClearAll_Click(object sender, EventArgs e)
            {
                inputPlainText.Text = "";
                inputEncryptedText.Text = "";
                inputPlainText.Focus();
            }

            private void btnClearPlain_Click(object sender, EventArgs e)
            {
                inputPlainText.Text = "";
                inputPlainText.Focus();
            }

            private void btnClearCiper_Click(object sender, EventArgs e)
            {
                inputEncryptedText.Text = "";
                inputEncryptedText.Focus();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                ExitApp();
            }

            private void ExitApp()
            {
                Environment.Exit(0);
            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void lblInput_Click(object sender, EventArgs e)
            {

            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void inputKey_TextChanged(object sender, EventArgs e)
            {
                // Get the character count from the inputKey TextBox
                int charCount = inputKey.Text.Length;

                // Check if the character count is not equal to 16
                if (charCount > 16)
                {
                    // Display a warning message
                    label2.Text = "Password must be exactly 16 digits";
                    // You may also consider showing a MessageBox for a more prominent warning
                    MessageBox.Show("Password must be exactly 16 digits", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Update the label to display the character count
                    label2.Text = $"Character Count: {charCount}";
                }
            }

            private void Exit_Click(object sender, EventArgs e)
            {
                
                this.Close();
            }

            private void usernametext_Click(object sender, EventArgs e)
            {

            }

        private void cipherForm_Load(object sender, EventArgs e)
        {

        }
    }
    }
        
