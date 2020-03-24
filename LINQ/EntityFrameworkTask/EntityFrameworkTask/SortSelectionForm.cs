using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkTask
{
    public partial class SortSelectionForm : Form
    {
        protected internal List<Human> sortedHumans;

        public SortSelectionForm(List<Human> initialList)
        {
            InitializeComponent();

            sortedHumans = initialList;
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            if (rbtn_fullname.Checked)
                sortedHumans = sortedHumans
                    .OrderBy(h => h.Fullname)
                    .ToList();
            else if (rbtn_gender.Checked)
                sortedHumans = sortedHumans
                    .OrderBy(h => h.Gender)
                    .ToList();
            else if (rbtn_birthday.Checked)
                sortedHumans = sortedHumans
                    .OrderBy(h => h.Birthday)
                    .ToList();

            MessageBox.Show("Data has been sorted!", "Success", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
