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

namespace reproductorMultimedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbvistaarchivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            MediaFile file =lbvistaarchivos.SelectedItem as MediaFile;
            if(file != null)
            {
                mpmediaplayer.URL = file.Path;
                mpmediaplayer.Ctlcontrols.play();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            { Multiselect = true, ValidateNames = true, Filter = "WMV|*.mp3|MP4|*.mp4|MKV|+.mkv" })
            { 
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    List<MediaFile> files = new List<MediaFile>();
                    foreach(string FileName in ofd.FileNames)
                    {
                        FileInfo fi = new FileInfo(FileName);
                        files.Add(new MediaFile() { FileName = Path.GetFileNameWithoutExtension(fi.FullName), Path = fi.FullName});
                    }
                    lbvistaarchivos.DataSource = files;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbvistaarchivos.ValueMember = "Path";
            lbvistaarchivos.DisplayMember = "FileName";
        }
    }
}
