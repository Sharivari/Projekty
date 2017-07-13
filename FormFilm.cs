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
    public partial class FormFilm : Form
    {
        XmlDocument XmlDoc_Films;
        public FormFilm(XmlDocument XmlDoc_Films, TreeView treeViewFilms)
        {
            InitializeComponent();
            this.XmlDoc_Films = XmlDoc_Films;

            var list = treeViewFilms.Nodes
                       .Cast<TreeNode>()
                       .Select(x => x.Text)
                       .ToList();

            cbxFilms.DataSource = list;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {

        }

        private void cbxFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlNodeList Film = XmlDoc_Films.SelectNodes("films/film[@name='" + cbxFilms.SelectedItem + "']");
            foreach (XmlNode myNode in Film)
            {
                tbxName.Text = myNode.Attributes["name"].InnerText;
                tbxDate.Text = myNode.Attributes["date"].InnerText;
                tbxGenres.Text = myNode.Attributes["genres"].InnerText;
            }
        }
    }
}
