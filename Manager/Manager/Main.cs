using Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Manager
{
    public partial class Main : Form
    {
        private BindingList<Expense> expenses = new BindingList<Expense>();
        private BindingSource bs = new BindingSource();
        public Main()
        {
            InitializeComponent();
            cmbCategory.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;

            bs.DataSource = expenses;
            dgvExpenses.DataSource = bs;
        }


        private void RefreshDataGrid()
        {
            dgvExpenses.DataSource = null;
            dgvExpenses.DataSource = expenses;


        }

        private void filterbox()
        {
            if (comboBox1.Text == "همه")
            {
                dgvExpenses.DataSource = null;
                dgvExpenses.DataSource = expenses;
                return;

            }
            List<Expense> filtered = new List<Expense>();

            foreach (var item in expenses)
            {
                if (item.Category == comboBox1.Text)
                    filtered.Add(item);
            }

            dgvExpenses.DataSource = null;
            dgvExpenses.DataSource = filtered;
        }


        private void UpdateStatus()
        {
            decimal total = 0;
            decimal max = 0;

            foreach (var e in expenses)
            {
                total += e.Amount;
                if (e.Amount > max)
                    max = e.Amount;
            }

            labelTotal.Text = $" مجموع هزینه ها: {total}";
            labelMax.Text = $"بیشترین هزینه: {max} ";

            decimal budget;
            if (decimal.TryParse(txtBudget.Text, out budget) && budget > 0)
            {
                decimal percent = (total / budget) * 100;
                percent = Math.Round(percent, 2);
                labelPercent.Text = "مصرف شده: " + percent + "%";
                if (percent > 90)
                {
                    labelPercent.ForeColor = Color.Red;
                }
                else
                {
                    labelPercent.ForeColor = Color.Green;
                }
            }
        }



        private void errorfild()
        {
            if (txtAmount.Text == "" || txtAmount.Text == " " || txtTitle.Text == "" || txtTitle.Text == " ")
            {
                MessageBox.Show(".لطفا تمام موارد را پر کنید", "!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtAmount.Focus();
                return;
            }
            decimal amount;
            try
            {
                amount = decimal.Parse(txtAmount.Text);

            }
            catch (FormatException)
            {
                MessageBox.Show(".لطفا مقدار هزینه را به صورت عددی وارد کنید", "!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Focus();
                return;
            }

            Expense expense = new Expense();
            {
                expense.Title = txtTitle.Text;
                expense.Amount = amount;
                expense.Category = cmbCategory.SelectedItem.ToString();

                PersianCalendar pc = new PersianCalendar();

                expense.Date = $"{pc.GetYear(dtpDate.Value)}/" + $"{pc.GetMonth(dtpDate.Value).ToString("00")}/" + $"{pc.GetDayOfMonth(dtpDate.Value).ToString("00")}";

                expenses.Add(expense);

            }
        }





        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void labelcategory_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "همه")
            {
                bs.DataSource = expenses;
            }
            else
            {
                bs.DataSource = new BindingList<Expense>(
                    expenses.Where(x => x.Category == comboBox1.Text).ToList()
                );
            }

            dgvExpenses.DataSource = bs;
            
            UpdateStatus();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            errorfild();
            bs.ResetBindings(false);
            RefreshDataGrid();
            btnClear.PerformClick();
            UpdateStatus();
            filterbox();
        }

        private void dgvExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
            txtTitle.Clear();
            cmbCategory.SelectedIndex = 0;
            dtpDate.Value = DateTime.Now;
            txtTitle.Focus();
        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtBudget_TextChanged(object sender, EventArgs e)
        {
            UpdateStatus();
            filterbox();
            RefreshDataGrid();
        }

        private void labelMax_Click(object sender, EventArgs e)
        {

        }

        private void labelPercent_Click(object sender, EventArgs e)
        {

        }

        private void btndeletrow_Click(object sender, EventArgs e)
        {


            if (dgvExpenses.CurrentRow == null)
            {
                MessageBox.Show("!حداقل یک ردیف را انتخاب کنید", "!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            
            Expense item = dgvExpenses.CurrentRow.DataBoundItem as Expense;

            if (item == null)
                return;

            DialogResult r = MessageBox.Show("آیا مطمئن هستید که می خواهید این ردیف را حذف کنید؟", "تایید حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.No)
                return;

            expenses.Remove(item);

            bs.ResetBindings(false);
            UpdateStatus();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
            UpdateStatus();
            filterbox();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter w = new StreamWriter(sfd.FileName))
                {
                    foreach (var e2 in expenses)
                        w.WriteLine($"{e2.Title},{e2.Amount},{e2.Category},{e2.Date}");
                }
            
            MessageBox.Show(".با موفقیت ذخیره شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                expenses.Clear();

                foreach (var line in File.ReadAllLines(ofd.FileName))
                {
                    var p = line.Split(',');

                    if (p.Length < 4) continue;

                    expenses.Add(new Expense
                    {
                        Title = p[0],
                        Amount = decimal.TryParse(p[1], out decimal a) ? a : 0,
                        Category = p[2],
                        Date = p[3]
                    });
                }
                RefreshDataGrid();
                UpdateStatus();
                filterbox();

            }
        }


        private void toolStripUser_Click(object sender, EventArgs e)
        {



            toolStripUser.Text = "      کاربر: admin ";

        }

        private void toolStripTime_Click(object sender, EventArgs e)
        {
            toolStripTime.Text = $"            {DateTime.Now.ToString("HH:mm:ss")} ";
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}


