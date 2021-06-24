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
            get { return (int)numBoxInventNum.Value; }
            set { numBoxInventNum.Value = value; }
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
            get { return (int)numDaysUsed.Value; }
            set { numDaysUsed.Value = value; }
        }

        List<Item> BookCollection = new List<Item>();

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
            if (SortedByInvNum)
                BookCollection.Sort();

            StringBuilder sb = new StringBuilder();
            foreach (Item item in BookCollection)
                sb.Append("\n" + item.ToString());
            richTextBoxBookInfo.Text = sb.ToString();
        }
    }
}
