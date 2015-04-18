using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypter
{
    public partial class Encrypt : Form
    {
        public Encrypt()
        {
            InitializeComponent();
        }

        private void Message_TextChanged(object sender, EventArgs e)
        {
            Update_Encryption();
        }

        string path;

        private void Update_Encryption()
        {
            BigInteger password_int = BigInteger.Zero;
            string password = "";
            if (checkBox1.CheckState == CheckState.Checked)
                password = Password.Text;
            else
                password = Password.Text.ToLower();
            password_int = new BigInteger(System.Text.ASCIIEncoding.Default.GetBytes(password)) + 1;
            BigInteger text_int = BigInteger.Zero;
            switch (Input_Type.SelectedIndex)
            {
                case 0:
                    {
                        string text = Encrypted_Text.Text;
                        text_int = new BigInteger(System.Text.ASCIIEncoding.Default.GetBytes(text));
                        break;
                    }
                case 1:
                    {
                        try
                        {
                            text_int = BigInteger.Parse(Encrypted_Text.Text);
                        }
                        catch
                        {
                        }
                        break;
                    }
                case 2:
                    {
                        text_int = new BigInteger(System.IO.File.ReadAllBytes(input_type_path));
                        break;
                    }
            }
            switch (Output_Type.SelectedIndex)
            {
                case 0:
                    {
                        Encryption.Text = new String(System.Text.ASCIIEncoding.Default.GetChars((BigInteger.Multiply(password_int, text_int).ToByteArray())));
                        return;
                    }
                case 1:
                    {
                        Encryption.Text = (password_int * text_int).ToString();
                        return;
                    }
                case 2:
                    {
                        System.IO.File.WriteAllBytes(path, (password_int * text_int).ToByteArray());
                        return;
                    }
            }
        }
        private void Encrypt_Load(object sender, EventArgs e)
        {
            Output_Type.SelectedIndex = 0;
            Input_Type.SelectedIndex = 0;
            Update_Encryption();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Encryption.Text);
        }

        private void Encrypted_Text_TextChanged(object sender, EventArgs e)
        {
            Update_Encryption();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            Update_Encryption();
        }

        private void Encryption_Click(object sender, EventArgs e)
        {

        }

        private void Output_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Output_Type.SelectedIndex == 2)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.AddExtension = true;
                dialog.DefaultExt = "enc";
                dialog.Filter = "Encryption Files (*.enc)|*.enc";
                dialog.ShowDialog();
                while (!dialog.CheckPathExists)
                {
                    DialogResult result = MessageBox.Show("Error! File non-existant. Would you like to try again?", "Encrypter", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    switch (result)
                    {
                        case System.Windows.Forms.DialogResult.No:
                            {
                                break;
                            }
                    }
                    dialog.ShowDialog();
                }
                path = dialog.FileName;
            }
            Update_Encryption();
        }

        string input_type_path;

        private void Input_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Input_Type.SelectedIndex == 2)
            {
                OpenFileDialog openfiledialog1 = new OpenFileDialog();
                openfiledialog1.Filter = "All Files (*.*)|*.*|Text Document (*.txt)|*.txt|Html Documents|*.html|PDF File|*.pdf|Rich Text Document (*.rtf)|*.rtf|Word Documents (*.doc, *.docx)|*.doc;*.docx|Image Files(*.jpg, *.png)|*.jpg;*.png";
                openfiledialog1.ShowDialog();
                OpenFileDialog dialog = openfiledialog1;
                while (!dialog.CheckFileExists)
                {
                    DialogResult result = MessageBox.Show("Error! File non-existant. Would you like to try again?", "Encrypter", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    switch (result)
                    {
                        case System.Windows.Forms.DialogResult.No:
                            {
                                Input_Type.SelectedIndex = 0;
                                break;
                            }
                    }
                    dialog.ShowDialog();
                }
                input_type_path = dialog.FileName;
            }
            Update_Encryption();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Update_Encryption();
        }
    }
}
