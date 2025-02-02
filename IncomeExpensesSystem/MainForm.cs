﻿using IncomeExpensesSystem.Models;

namespace IncomeExpensesSystem
{
    public partial class MainForm : Form
    {
        public MainForm(User user)
        {
            InitializeComponent();
            userNameLabel.Text = user.Name;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = true;
            categoryForm1.Visible = false;
            incomeForm1.Visible = false;
            expensesForm1.Visible = false;
        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = true;
            incomeForm1.Visible = false;
            expensesForm1.Visible = false;
        }

        private void incomeBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm1.Visible = true;
            expensesForm1.Visible = false;
        }

        private void expenseBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm1.Visible = false;
            expensesForm1.Visible = true;
        }
    }
}
