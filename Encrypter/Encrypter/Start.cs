using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypter
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Encrypt().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Decrypt().ShowDialog();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
            if (Environment.GetCommandLineArgs().Length != 1)
            {
                new Decrypt(Environment.GetCommandLineArgs()[1]).ShowDialog();
            }
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            new Decrypt(sender, e).ShowDialog();
        }
    }
}
