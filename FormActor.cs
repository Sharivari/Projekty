using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XML
{
    public partial class FormActor : Form
    {
        XmlDocument XmlDoc;
        public FormActor(XmlDocument XmlDoc, TreeView treeView1)
        {
            InitializeComponent();
            this.XmlDoc = XmlDoc;

            var list = treeView1.Nodes
                       .Cast<TreeNode>()
                       .Select(x => x.Text)
                       .ToList();

            cbxActor.DataSource = list;

        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            XmlNode root = XmlDoc.DocumentElement;
            XmlNodeList Actor = XmlDoc.SelectNodes("actors/actor[@name='" + cbxActor.SelectedItem + "']");
            foreach (XmlNode myNode in Actor)
            {
                XmlElement formData = (XmlElement)XmlDoc.SelectSingleNode("actors/actor[@name='" + cbxActor.SelectedItem + "']");
                if (formData != null)
                {
                    formData.SetAttribute("name", tbxName.Text); // Set to new value.
                }
                myNode["name"].InnerText = tbxName.Text;
                myNode["birthdate"].InnerText = tbxBirth.Text;
                myNode["placeofbirth"].InnerText = tbxPlaceBirth.Text;
            }
            XmlDoc.Save("C:\\Users\\Galaxis\\Desktop\\Studia\\VI semestr\\Metajęzyki Berezowski\\aktorzy.xml");

            this.DialogResult = DialogResult.OK;
        }

        private void cbxActor_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlNodeList Actor = XmlDoc.SelectNodes("actors/actor[@name='" + cbxActor.SelectedItem + "']");
            foreach (XmlNode myNode in Actor)
            {
                    tbxName.Text = myNode["name"].InnerText;
                    tbxBirth.Text = myNode["birthdate"].InnerText;
                    tbxPlaceBirth.Text = myNode["placeofbirth"].InnerText;
            }
        }
    }
}
