using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClass;

namespace BiblWorm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Books properties
        public string Author
        {
            get { return textBoxAuthor.Text; }
            set { textBoxAuthor.Text = value; }
        }

        public string Title
        {
            get { return textBoxTitle.Text; }
            set { textBoxTitle.Text = value; }
        }

        public string Publisher
        { 
            get { return textBoxPublisher.Text; }
            set { textBoxPublisher.Text = value; }
        }

        public int Pages
        {
            get { return (int)numBoxPages.Value; }
            set { numBoxPages.Value = value; }
        }

        public int Year
        {
            get { return (int)numBoxYear.Value; }
            set { numBoxYear.Value = value; }
        }

        public int InvNumber
        {
            get { return (int)numBoxInvNum.Value; }
            set { numBoxInvNum.Value = value; }
        }

        public bool IsAvailable
        {
            get { return chkBoxAvail.Checked; }
            set { chkBoxAvail.Checked = value; }
        }

        public bool SortedByInvNum
        {
            get { return chkBoxSortBooks.Checked; }
            set { chkBoxSortBooks.Checked = value; }
        }

        public bool ReturnedOnTime
        {
            get { return chkBoxOntime.Checked; }
            set { chkBoxOntime.Checked = value; }
        }

        public int DaysUsed
        {
            get { return (int)numBoxDaysUsed.Value; }
            set { numBoxDaysUsed.Value = value; }
        }
        // End of Books properties

        // Magazines Properties
        public string Volume
        {
            get { return textBoxMagVol.Text; }
            set { textBoxMagVol.Text = value; }
        }

        public int Number
        {
            get { return (int)numBoxMagNum.Value; }
            set { numBoxMagNum.Value = value; }
        }

        public string MagTitle
        {
            get { return textBoxMagTitle.Text; }
            set { textBoxMagTitle.Text = value; }
        }

        public int MagYear
        {
            get { return (int)numBoxMagYear.Value; }
            set { numBoxMagYear.Value = value; }
        }

        public int MagInvNumber
        {
            get { return (int)numBoxMagInvNum.Value; }
            set { numBoxMagInvNum.Value = value; }
        }

        public bool MagIsAvailable
        {
            get { return chkBoxMagAvail.Checked; }
            set { chkBoxMagAvail.Checked = value; }
        }

        public bool MagReturnedOnTime
        {
            get { return chkBoxMagOntime.Checked; }
            set { chkBoxMagOntime.Checked = value; }
        }

        public int MagDaysUsed
        {
            get { return (int)numBoxMagDaysUsed.Value; }
            set { numBoxMagDaysUsed.Value = value; }
        }
        // End of Magazines properties

        List<Item> BookCollection = new List<Item>();

        List<Item> MagCollection = new List<Item>();

        private void buttAddBook_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, Publisher, Pages, Year, InvNumber, IsAvailable);
            
            if (ReturnedOnTime)
                b.ReturnSrok();

            b.PriceBook(DaysUsed);

            BookCollection.Add(b);

            Author = Title = Publisher = "";
            Pages = InvNumber = DaysUsed = 0;
            Year = 0;
            IsAvailable = ReturnedOnTime = false;
        }

        private void buttViewBook_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == Books)
            {
                if (SortedByInvNum)
                    BookCollection.Sort();

                StringBuilder sb = new StringBuilder();
                foreach (Item item in BookCollection)
                    sb.Append("\n" + item.ToString());
                richTextBoxBookInfo.Text = sb.ToString();
            }
            else if (tabControl1.SelectedTab == Magazines)
            {
                if (SortedByInvNum)
                    MagCollection.Sort();

                StringBuilder sb = new StringBuilder();
                foreach (Item item in MagCollection)
                    sb.Append("\n" + item.ToString());
                richTextBoxBookInfo.Text = sb.ToString();
            }
        }

        private void buttAddMag_Click(object sender, EventArgs e)
        {
            Magazine b = new Magazine(Volume, Number, Title, Year, InvNumber, IsAvailable);

            MagCollection.Add(b);

            Volume = MagTitle = "";
            Number = MagInvNumber = MagYear = MagDaysUsed = 0;
            MagIsAvailable = MagReturnedOnTime = false;
        }
    }
}
