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

namespace RandomImagePicker
{
    public partial class Form1 : Form
    {
        string source = null;
        string target = null;
        Random rand = new Random(999);
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog sourceDialog = new FolderBrowserDialog())
            {
                if (sourceDialog.ShowDialog() == DialogResult.OK)
                {
                    source = sourceDialog.SelectedPath;
                    lbl_source.Text = source;
                }
            }
            if (target != null && source != null)
                btn_start.Enabled = true;
        }

        private void btn_target_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog targetDialog = new FolderBrowserDialog())
            {
                if (targetDialog.ShowDialog() == DialogResult.OK)
                {
                    target = targetDialog.SelectedPath;
                    lbl_target.Text = target;
                }
            }
            if (target != null && source != null)
                btn_start.Enabled = true;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            int chance = 10;
            try
            {
                chance = Convert.ToInt32(txb_chance.Text);
            }
            catch
            {
                return;
            }
            var files = Directory.GetFiles(source, "*.*");
            foreach (string s in files)
            {
                if (rand.Next(0, chance).Equals(1))
                {
                    var fileName = System.IO.Path.GetFileName(s);
                    var destFile = System.IO.Path.Combine(target, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
            MessageBox.Show("Finished");

        }
    }
}
