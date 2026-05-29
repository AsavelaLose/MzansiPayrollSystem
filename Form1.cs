using MzansiPayrollSystem;
using System;
using System.Windows.Forms;

namespace MzansiPayrollSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                double hours = double.Parse(txtHours.Text);
                int dependents = int.Parse(txtDependents.Text);

                if (string.IsNullOrWhiteSpace(name))
                    throw new Exception("Contractor name cannot be empty.");
                if (hours < 0) throw new Exception("Hours cannot be negative.");
                if (dependents < 0 || dependents > 10) throw new Exception("Dependents must be between 0 and 10.");

                PayrollCalculator calc = new PayrollCalculator();

                double gross = calc.CalculateGrossPay(hours);
                double uif = calc.CalculateUIF(gross);
                double membership = calc.CalculateMembership(gross);
                double paye = calc.CalculatePAYE(gross, dependents);
                double net = calc.CalculateNetPay(gross, uif, paye, membership);

                txtGross.Text = $"R{gross:F2}";
                txtUIF.Text = $"R{uif:F2}";
                txtMembership.Text = $"R{membership:F2}";
                txtPAYE.Text = $"R{paye:F2}";
                txtTotal.Text = $"R{(uif + paye + membership):F2}";
                txtNet.Text = $"R{net:F2}";

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtHours.Clear();
            txtDependents.Clear();
            txtGross.Clear();
            txtUIF.Clear();
            txtMembership.Clear();
            txtPAYE.Clear();
            txtTotal.Clear();
            txtNet.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtGross_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPAYE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMembership_TextChanged(object sender, EventArgs e)
        {

        }
    }
}