using System;
using System.Windows.Forms;
using System.Linq;

namespace EntityFrameworkTask
{
    public partial class HumanForm : Form
    {
        HumanityContext context;
        Action<Human> action;
        string msgText;
        int? id;

        public HumanForm(HumanityContext ctx, string successMessage, int? id, Action<Human> act)
        {
            InitializeComponent();

            // date time picker style
            dtp_birthday.Format = DateTimePickerFormat.Custom;
            dtp_birthday.CustomFormat = "yyyy-MM-dd";
            dtp_birthday.Value = DateTime.Now.Date;

            context = ctx;
            msgText = successMessage;
            action = act;
            this.id = null;

            if (id != null)
            {
                this.id = id;

                var hmn = (from h in context.Humans.Local
                           where h.Id == id.Value
                           select h).SingleOrDefault();

                tb_firstname.Text = hmn.Fullname.Split(' ')[0];
                tb_lastname.Text = hmn.Fullname.Split(' ')[1];
                tb_gender.Text = hmn.Gender;
                dtp_birthday.Value = DateTime.ParseExact(hmn.Birthday, "yyyy-MM-dd", null);
                btn_add.Text = "Update human";
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = !(string.IsNullOrEmpty(tb_firstname.Text) || string.IsNullOrWhiteSpace(tb_firstname.Text)) 
                                    ? tb_firstname.Text.Trim()
                                    : throw new Exception("Please, enter your firstname");
                string lname = !(string.IsNullOrEmpty(tb_lastname.Text) || string.IsNullOrWhiteSpace(tb_lastname.Text))
                                    ? tb_lastname.Text.Trim()
                                    : throw new Exception("Please, enter your lastname");
                string gender = !(string.IsNullOrEmpty(tb_gender.Text) || string.IsNullOrWhiteSpace(tb_gender.Text))
                                    ? tb_gender.Text.Trim()
                                    : throw new Exception("Please, enter your gender");
                DateTime birthday = dtp_birthday.Value;

                Human hmn = null;

                if (id != null)
                {
                    hmn = (from h in context.Humans.Local
                           where h.Id == id.Value
                           select h).SingleOrDefault();

                    hmn.Fullname = fname + " " + lname;
                    hmn.Gender = gender;
                    hmn.Birthday = birthday.ToString("yyyy-MM-dd");

                    context.Entry(hmn).Property(h => h.Fullname).IsModified = true;
                    context.Entry(hmn).Property(h => h.Gender).IsModified = true;
                    context.Entry(hmn).Property(h => h.Birthday).IsModified = true;
                }
                else
                {
                    hmn = new Human()
                    {
                        Fullname = fname + " " + lname,
                        Gender = gender,
                        Birthday = birthday.ToString("yyyy-MM-dd")
                    };
                }

                action(hmn);

                MessageBox.Show(msgText, "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
