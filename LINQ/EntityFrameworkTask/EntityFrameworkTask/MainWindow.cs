using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace EntityFrameworkTask
{
    public partial class MainWindow : Form
    {
        protected internal HumanityContext dbcontext;

        public MainWindow()
        {
            FormClosing += OnClosing;
            dbcontext = new HumanityContext();

            StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();

            #region Debug: Adding user
            //using (dbcontext = new HumanityContext())
            //{
            //dbcontext.Humans.Add(new Human()
            //{
            //    Fullname = "Koko Starlight",
            //    Gender = "Female",
            //    Birthday = new DateTime(2000, 02, 02).ToString("yyyy-MM-dd")
            //});

            //dbcontext.SaveChanges();
            //}
            #endregion
        }

        private void OnClosing(object sender, EventArgs e)
        {
            if (dbcontext != null) dbcontext.Dispose();
        }

        public void LoadHumans()
        {
            if (dgv_data.DataSource != null)
                dgv_data.DataSource = null;

            dbcontext.Humans.Local.Clear();
            dbcontext.Humans.Load();

            dgv_data.DataSource = dbcontext.Humans.Local.ToBindingList();
        }

        private void btn_loadData_Click(object sender, EventArgs e)
        {
            LoadHumans();

            dgv_data.AllowUserToAddRows = false;
            dgv_data.AllowUserToDeleteRows = false;
            dgv_data.AllowUserToOrderColumns = false;
            dgv_data.AllowUserToResizeColumns = false;
            dgv_data.AllowUserToResizeRows = false;
            foreach (DataGridViewColumn column in dgv_data.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgv_data.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            btn_loadData.Enabled = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Action<Human> action = (h) =>
            { 
                dbcontext.Humans.Add(h);
                dbcontext.SaveChanges();
            };

            HumanForm humanForm = new HumanForm(dbcontext, "Human added!", null, action)
            {
                StartPosition = FormStartPosition.CenterParent
            };

            humanForm.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_data.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please, select human!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = int.Parse(dgv_data.SelectedRows[0].Cells[0].Value.ToString().Trim());

            Action<Human> action = (h) => { dbcontext.SaveChanges(); };

            HumanForm humanForm = new HumanForm(dbcontext, "Human updated!", id, action)
            {
                StartPosition = FormStartPosition.CenterParent
            };

            humanForm.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_data.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please, select human!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = int.Parse(dgv_data.SelectedRows[0].Cells[0].Value.ToString().Trim());

            if (MessageBox.Show("Are you sure you want to delete this row?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var hmn = (from h in dbcontext.Humans.Local
                           where h.Id == id
                           select h).SingleOrDefault();

                dbcontext.Humans.Remove(hmn);
                dbcontext.SaveChanges();
            }
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            SortSelectionForm sortForm = new SortSelectionForm(dbcontext.Humans.Local.ToList())
            {
                StartPosition = FormStartPosition.CenterParent
            };

            sortForm.ShowDialog();

            dgv_data.DataSource = sortForm.sortedHumans;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(dbcontext.Humans.Local.ToList())
            {
                StartPosition = FormStartPosition.CenterParent
            };

            searchForm.ShowDialog();

            dgv_data.DataSource = searchForm.searchResult;
        }
    }
}
