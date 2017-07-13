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
using System.Xml;
using System.Xml.Linq;

namespace XML
{
    public partial class Form1 : Form
    {
        TreeNode AktorNode, FilmyNode;
        XmlDocument XmlDoc = new XmlDocument();
        XmlDocument XmlDoc_Films = new XmlDocument();
        string selectedNodeText;
        public Form1()
        {
            InitializeComponent();
            ZaladujAktorow();
            ZaladujFilmy();

            var list = treeView1.Nodes.Cast<TreeNode>().Select(x => x.Text).ToList();
            cbxActor.DataSource = list;

            var list2 = treeViewFilms.Nodes.Cast<TreeNode>().Select(x => x.Text).ToList();
            cbxFilm.DataSource = list2;
        }

        private void ZaladujFilmy()
        {
            {
                treeViewFilms.Nodes.Clear();
                try
                {
                    XmlDoc_Films.Load("C:\\Users\\Galaxis\\Desktop\\Studia\\VI semestr\\Metajęzyki Berezowski\\aktorzy_filmy.xml");

                    XmlNode XMLAktorNode = XmlDoc_Films.GetElementsByTagName("films").Item(0);

                    if (XMLAktorNode.HasChildNodes)
                    {
                        for (int j = 0; j < XMLAktorNode.ChildNodes.Count; j++)
                        {

                            String nazwa = XMLAktorNode.ChildNodes[j].Attributes["name"].Value;
                            TreeNode TylkoFilmyNode = new TreeNode(nazwa);
                            treeViewFilms.Nodes.Add(TylkoFilmyNode);


                            XmlNodeList Shops = XmlDoc_Films.SelectNodes("films/film[@name = '" + nazwa + "']");
                            foreach (XmlNode xn in Shops)
                            {

                                TylkoFilmyNode.Nodes.Add("Data wydania filmu: " + "  " + xn.Attributes["date"].InnerText);
                                TylkoFilmyNode.Nodes.Add("Rodzaje: " + "  " + xn.Attributes["genres"].InnerText);

                            }
                        }
                    }
                }


                catch (XmlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void ZaladujAktorow()
        {

            treeView1.Nodes.Clear();

            try
            {
                XmlDoc.Load("C:\\Users\\Galaxis\\Desktop\\Studia\\VI semestr\\Metajęzyki Berezowski\\aktorzy.xml");
                int Count = XmlDoc.GetElementsByTagName("actor").Count;

                for (int i = 0; i < Count; i++)
                {
                    AktorNode = treeView1.Nodes.Add(XmlDoc.GetElementsByTagName("name").Item(i).InnerText);
                    

                    AktorNode.Nodes.Add("Data urodzenia: " + "  " + XmlDoc.GetElementsByTagName("birthdate").Item(i).InnerText);
                    AktorNode.Nodes.Add("Miejsce urodzenia: " + "  " + XmlDoc.GetElementsByTagName("placeofbirth").Item(i).InnerText);


                    FilmyNode = AktorNode.Nodes.Add("Filmy");
                    

                    XmlDoc_Films.Load("C:\\Users\\Galaxis\\Desktop\\Studia\\VI semestr\\Metajęzyki Berezowski\\aktorzy_filmy.xml");

                    
                    XmlNode XMLAktorNode = XmlDoc.GetElementsByTagName("films").Item(i);
                    if (XMLAktorNode.HasChildNodes)
                    {
                        for (int j = 0; j < XMLAktorNode.ChildNodes.Count; j++)
                        {
                            String nazwa = XMLAktorNode.ChildNodes[j].Attributes["name"].Value;
                            String postac = XMLAktorNode.ChildNodes[j].Attributes["character"].Value;
                            XmlNodeList Shops = XmlDoc_Films.SelectNodes("films/film[@name = '" + nazwa + "']");
                            foreach (XmlNode xn in Shops)
                            {
                                TreeNode filmname = new TreeNode("Nazwa: " + "  " + xn.Attributes["name"].InnerText);
                                Font f = new Font("Microsoft Sans Serif", 8 , FontStyle.Underline);
                                filmname.NodeFont = f;
                                FilmyNode.Nodes.Add(filmname);
                                FilmyNode.Nodes.Add("Postać: " + "  " + postac);
                                FilmyNode.Nodes.Add("Data wydania filmu: " + "  " + xn.Attributes["date"].InnerText);
                                FilmyNode.Nodes.Add("Rodzaj: " + "  " + xn.Attributes["genres"].InnerText);

                            }
                        }
                    }
                }
            }
            catch (XmlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedNodeText = e.Node.Text;
        }

        private void btnEdytujAktora_Click(object sender, EventArgs e)
        {
            FormActor formactor = new FormActor(XmlDoc, treeView1);
            if (formactor.ShowDialog() == DialogResult.OK)
            {
                ZaladujAktorow();
            }
        }

        private void btnDodajFilm_Click(object sender, EventArgs e)
        {
            //create node and add value
            XmlNode node = XmlDoc_Films.CreateNode(XmlNodeType.Element, "film", null);
            XmlDoc_Films.DocumentElement.AppendChild(node);
            XmlDoc_Films.Save("C:\\Users\\Galaxis\\Desktop\\Studia\\VI semestr\\Metajęzyki Berezowski\\aktorzy_filmy.xml");

            XDocument doc = XDocument.Load("C:\\Users\\Galaxis\\Desktop\\Studia\\VI semestr\\Metajęzyki Berezowski\\aktorzy_filmy.xml");
            foreach (XElement film in doc.Root.Elements("film").Where(u => u.Attribute("name") == null & u.Attribute("date") == null & u.Attribute("genres") == null).ToList())
            {
                film.Add(new XAttribute("name", tbxFilmName.Text));
                film.Add(new XAttribute("date", tbxFilmDate.Text));
                film.Add(new XAttribute("genres", tbxFilmGenres.Text));
            }
            doc.Save("C:\\Users\\Galaxis\\Desktop\\Studia\\VI semestr\\Metajęzyki Berezowski\\aktorzy_filmy.xml");
            tbxFilmName.Text = null;
            tbxFilmDate.Text = null;
            tbxFilmGenres.Text = null;
        }

        private void btnEdytujFilm_Click(object sender, EventArgs e)
        {
            FormFilm formfilm = new FormFilm(XmlDoc_Films, treeViewFilms);
            if (formfilm.ShowDialog() == DialogResult.OK)
            {
                ZaladujFilmy();
            }
        }


        private void btnDodajFilmDoAktora_Click(object sender, EventArgs e)
        {
            
            XmlNode Validations = XmlDoc.SelectSingleNode("/actors/actor[@name='" + cbxActor.SelectedItem.ToString() + "']/films");

            XmlNode node = XmlDoc.CreateNode(XmlNodeType.Element, "film", null);
            Validations.AppendChild(node);
            XmlDoc.Save("C:\\Users\\Galaxis\\Desktop\\Studia\\VI semestr\\Metajęzyki Berezowski\\aktorzy.xml");



            XDocument doc2 = XDocument.Load("C:\\Users\\Galaxis\\Desktop\\Studia\\VI semestr\\Metajęzyki Berezowski\\aktorzy.xml");
            foreach (XElement film in doc2.Root.Elements("actor").Elements("films").Elements("film").Where(u => u.Attribute("name") == null & u.Attribute("character") == null).ToList())
            {
                film.Add(new XAttribute("name", cbxFilm.SelectedItem.ToString()));
                film.Add(new XAttribute("character", tbxCharacter.Text));
            }


            doc2.Save("C:\\Users\\Galaxis\\Desktop\\Studia\\VI semestr\\Metajęzyki Berezowski\\aktorzy.xml");
            tbxCharacter.Text = null;;
            ZaladujAktorow();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedNodeText != null)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("C:\\Users\\Galaxis\\Desktop\\Studia\\VI semestr\\Metajęzyki Berezowski\\aktorzy.xml");
                XmlNodeList nodes = doc.SelectNodes("/actors/actor[@name='" + selectedNodeText + "']");
                for (int i = nodes.Count - 1; i >= 0; i--)
                {
                    nodes[i].ParentNode.RemoveChild(nodes[i]);
                }
                doc.Save("C:\\Users\\Galaxis\\Desktop\\Studia\\VI semestr\\Metajęzyki Berezowski\\aktorzy.xml");
                ZaladujAktorow();
            }
        }

        private void btnDodajAktora_Click(object sender, EventArgs e)
        {
            //create node and add value
            XmlNode node = XmlDoc.CreateNode(XmlNodeType.Element, "actor", null);
            //node.InnerText = "this is new node";

            XmlNode nodeName = XmlDoc.CreateElement("name");
            nodeName.InnerText = tbxActorName.Text;

            XmlNode nodeBirth = XmlDoc.CreateElement("birthdate");
            nodeBirth.InnerText = tbxBirthDate.Text;

            XmlNode nodePlaceBirth = XmlDoc.CreateElement("placeofbirth");
            nodePlaceBirth.InnerText = tbxPlaceOFBirth.Text;

            XmlNode nodeFilms = XmlDoc.CreateElement("films");

            XmlAttribute attributeName = XmlDoc.CreateAttribute("name");
            attributeName.InnerText = tbxActorName.Text;
                //add to parent node
            node.AppendChild(nodeName);
            node.AppendChild(nodeBirth);
            node.AppendChild(nodePlaceBirth);
            node.AppendChild(nodeFilms);
            node.Attributes.Append(attributeName);

            //add to elements collection
            XmlDoc.DocumentElement.AppendChild(node);
            //save back
            XmlDoc.Save("C:\\Users\\Galaxis\\Desktop\\Studia\\VI semestr\\Metajęzyki Berezowski\\aktorzy.xml");

            /*
            XDocument doc = XDocument.Load("C:\\Users\\Galaxis\\Desktop\\Studia\\VI semestr\\Metajęzyki Berezowski\\aktorzy.xml");
            foreach (XElement actor in doc.Root.Elements("actor").Where(u => u.Attribute("name") == null).ToList())
            {
                actor.Add(new XAttribute("name", tbxActorName.Text));
            }
            foreach (XElement actor in doc.Root.Elements("actor").Where(u => u.Attribute("name") equals "0").ToList())
            {
                MessageBox.Show()
                actor.Add(new XAttribute("name", tbxActorName.Text));
            }
            

            doc.Save("C:\\Users\\Galaxis\\Desktop\\Studia\\VI semestr\\Metajęzyki Berezowski\\aktorzy.xml");
            */
            tbxActorName.Text = null;
            tbxBirthDate.Text = null;
            tbxPlaceOFBirth.Text = null;
            ZaladujAktorow();
        }

       
    }
}
