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
    public partial class Decrypt : Form
    {
        string path;
        public Decrypt ()
        {
            InitializeComponent();
        }

        public Decrypt(string path)
        {
            InitializeComponent();
            sel_event_thrown = false;
            Input_Type.SelectedIndex = 2;
            sel_event_thrown = true;
            
            this.path = path;
            Update_Decryption();
        }

        public Decrypt (object sender, DragEventArgs e)
        {
            InitializeComponent();
            Form1_DragDrop(sender, e);
        }

        private void Encryption_TextChanged(object sender, EventArgs e)
        {
            Update_Decryption();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            Update_Decryption();
        }

        private void Decrypt_Load(object sender, EventArgs e)
        {
            if (Input_Type.SelectedIndex == -1)
                Input_Type.SelectedIndex = 0;
            sel_event_thrown = false;
            Output_Type.SelectedIndex = 0;
            sel_event_thrown = true;
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length != 0)
            {
                sel_event_thrown = false;
                Input_Type.SelectedIndex = 2;
                sel_event_thrown = true;
                path = (string)(files[0]);
                Update_Decryption();
            }
        }
        bool sel_event_thrown = true;

        private void Update_Decryption ()
        {
            string password = "";
            if (checkBox1.CheckState == CheckState.Checked)
                password = Password.Text;
            else
                password = Password.Text.ToLower();
            string encryption = Encryption.Text;
            BigInteger password_int = new BigInteger(System.Text.ASCIIEncoding.Default.GetBytes(password)) + 1;
            BigInteger encryption_int = BigInteger.Zero;
            switch (Input_Type.SelectedIndex)
            {
                case 0:
                    {
                        encryption_int = new BigInteger(System.Text.ASCIIEncoding.Default.GetBytes(encryption));
                        break;
                    }
                case 1:
                    {
                        try
                        {
                            encryption_int = BigInteger.Parse(Encryption.Text);
                        }
                        catch
                        {
                        }
                        break;
                    }
                case 2:
                    {
                        encryption_int = new BigInteger(System.IO.File.ReadAllBytes(path));
                        break;
                    }
            }
            switch (Output_Type.SelectedIndex)
            {
                case 0:
                    {
                        BeginText.Text = new String(System.Text.ASCIIEncoding.Default.GetChars((encryption_int / password_int).ToByteArray()));
                        break;
                    }
                case 1:
                    {
                        BeginText.Text = new BigInteger(((encryption_int / password_int).ToByteArray())).ToString();
                        break;
                    }
                case 2:
                    {
                        System.IO.File.WriteAllBytes(output_type_path, (encryption_int / password_int).ToByteArray());
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(BeginText.Text, TextDataFormat.UnicodeText);
        }

        private void Input_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sel_event_thrown)
            {
                if (Input_Type.SelectedIndex == 2)
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.AddExtension = true;
                    dialog.DefaultExt = "enc";
                    dialog.Filter = "Encryption Files (*.enc)|*.enc";
                    dialog.ShowDialog();
                    while (!dialog.CheckFileExists)
                    {
                        DialogResult result = MessageBox.Show("Error! File non-existant. Would you like to try again?", "Decrypter", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
            }
            if (Input_Type.SelectedIndex == 2)
            {
                Encryption.Enabled = false;
                if (sel_event_thrown)
                    Update_Decryption();
            }
            else
            {
                Encryption.Enabled = true;
                Update_Decryption();
            }
        }

        string output_type_path = "";

        private void Output_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Input_Type.SelectedIndex == 2)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "All Files (*.*)|*.*|Text Document (*.txt)|*.txt|Html Documents|*.html|PDF File|*.pdf|Rich Text Document (*.rtf)|*.rtf|Word Documents (*.doc, *.docx)|*.doc;*.docx|Image Files(*.jpg, *.png)|*.jpg;*.png";;
                dialog.ShowDialog();
                while (!dialog.CheckPathExists)
                {
                    DialogResult result = MessageBox.Show("Error! File non-existant. Would you like to try again?", "Decrypter", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    switch (result)
                    {
                        case System.Windows.Forms.DialogResult.No:
                            {
                                break;
                            }
                    }
                    dialog.ShowDialog();
                }
                output_type_path = dialog.FileName;
            }
            Update_Decryption();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Update_Decryption();
        }
    }
}
