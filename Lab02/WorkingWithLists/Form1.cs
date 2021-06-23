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
using System.IO;


namespace WorkingWithLists
{
    public partial class FormLists : Form
    {
        public FormLists()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (PeopleList.Text.Length != 0)
            {
                MemberList.Items.Add(PeopleList.Text);
            }
            else MessageBox.Show("Выберите элемент из списка или введите новый");
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            while (MemberList.CheckedIndices.Count > 0)
                MemberList.Items.RemoveAt(MemberList.CheckedIndices[0]);
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            MemberList.Sorted = true;
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            FileStream fStream = new FileStream("..\\..\\MembersFromXML.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(fStream);

            for (int i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
            {
                PeopleList.Items.Add(xmlDoc.DocumentElement.ChildNodes[i].InnerText);
            }
            fStream.Close();
        }
    }
}
