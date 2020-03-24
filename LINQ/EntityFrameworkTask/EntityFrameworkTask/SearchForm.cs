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
    public partial class SearchForm : Form
    {
        protected internal List<Human> searchResult;

        public SearchForm(List<Human> initial)
        {
            InitializeComponent();

            searchResult = initial;

            // date time picker style
            dtp_birthday.Format = DateTimePickerFormat.Custom;
            dtp_birthday.CustomFormat = "yyyy-MM-dd";
            dtp_birthday.Value = DateTime.Now.Date;

            tb_fullname.Enabled = false;
            tb_gender.Enabled = false;
            dtp_birthday.Enabled = false;

            cb_fullname.CheckedChanged += cb_fullname_CheckedChanged;
            cb_gender.CheckedChanged += cb_gender_CheckedChanged;
            cb_birthday.CheckedChanged += cb_birthday_CheckedChanged;
        }

        private void cb_fullname_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_fullname.Checked)
                tb_fullname.Enabled = true;
            else
                tb_fullname.Enabled = false;
        }

        private void cb_gender_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_gender.Checked)
                tb_gender.Enabled = true;
            else
                tb_gender.Enabled = false;
        }

        private void cb_birthday_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_birthday.Checked)
                dtp_birthday.Enabled = true;
            else
                dtp_birthday.Enabled = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string fullname = tb_fullname.Text.Trim();
            string gender = tb_gender.Text.Trim();
            string birthday = dtp_birthday.Value.ToString("yyyy-MM-dd");

            if (cb_fullname.Checked)
                if (cb_match.Checked)
                    searchResult = searchResult
                        .Where(h => h.Fullname == fullname)
                        .ToList();
                else
                    searchResult = searchResult
                        .Where(h => h.Fullname.Contains(fullname))
                        .ToList();

            if (cb_gender.Checked)
                if (cb_match.Checked)
                    searchResult = searchResult
                        .Where(h => h.Gender == gender)
                        .ToList();
                else
                    searchResult = searchResult
                        .Where(h => h.Gender.Contains(gender))
                        .ToList();

            if (cb_birthday.Checked)
                if (cb_match.Checked)
                    searchResult = searchResult
                        .Where(h => h.Birthday == birthday)
                        .ToList();
                else
                    searchResult = searchResult
                        .Where(h => h.Birthday.Contains(birthday))
                        .ToList();

            MessageBox.Show("Search comleted!", "Success", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
