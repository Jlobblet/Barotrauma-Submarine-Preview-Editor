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
using System.Xml.Linq;
using BaroLib;

namespace Barotrauma_Submarine_Preview_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void GoButton_Click(object sender, EventArgs e)
        {
            if (!IsFileValid(SubLocationTextBox.Text, out string subLocation)) return;

            if (!IsFileValid(ImageLocationTextBox.Text, out string imageLocation)) return;

            XDocument submarine = IoUtil.LoadSub(subLocation);
            byte[] imageBytes = File.ReadAllBytes(imageLocation);
            string imageString = Convert.ToBase64String(imageBytes);
            submarine?.Root?.SetAttributeValue("previewimage", imageString);
            submarine?.Root?.Attribute("checkval")?.Remove();
            
            submarine?.SaveSub(subLocation);
        }
        
        private void RemoveMainButton_Click(object sender, EventArgs e)
        {
            if (!IsFileValid(SubLocationTextBox.Text, out string subLocation)) return;

            XDocument submarine = IoUtil.LoadSub(subLocation);
            submarine?.Root?.Attribute("previewimage")?.Remove();

            submarine?.SaveSub(subLocation);
        }

        private void RemoveLinkedButton_Click(object sender, EventArgs e)
        {
            if (!IsFileValid(SubLocationTextBox.Text, out string subLocation)) return;

            XDocument submarine = IoUtil.LoadSub(subLocation);
            if (submarine.Root == null) return;
            foreach (XElement elt in submarine.Root.Elements("LinkedSubmarine"))
            {
                elt.Attribute("previewimage")?.Remove();
            }
            
            submarine.SaveSub(subLocation);
        }


        private void SubLocationButton_Click(object sender, EventArgs e)
        {
            SubLocationTextBox.Text = ShowOpenFileDialog(".sub");
        }
        
        private void ImageBrowseButton_Click(object sender, EventArgs e)
        {
            ImageLocationTextBox.Text = ShowOpenFileDialog(".png");
        }

        private static string ShowOpenFileDialog(string extension)
        {
            var dialog = new OpenFileDialog
                         {
                             CheckFileExists = true,
                             DefaultExt = extension
                         };
            return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : "";
        }

        private static bool IsFileValid(string input, out string output)
        {
            if (input == "" || !File.Exists(input))
            {
                output = null;
                return false;
            }

            output = input;
            return true;
        }
    }
}
