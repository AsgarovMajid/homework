using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Dish_Checked(object sender, EventArgs e)
    {
        if (sender is CheckBox cb)
        {
            foreach (var item in CafeGroupBox.Controls)
            {
                if (item is TextBox tb)
                {
                    if (cb.Name.Split("CheckBox")[0].Equals(tb.Name.Split("Count")[0]))
                    {
                        tb.Enabled = cb.Checked ? true : false;
                        return;
                    }
                }
            }
        }
    }

    private void DishPrice_Text(object sender, EventArgs e)
    {
        if (sender is TextBox tb)
        {
            double calc = 0;

            try
            {
                if (HotDogCount.Enabled && !string.IsNullOrWhiteSpace(HotDogCount.Text))
                    calc += Convert.ToInt32(HotDogCount.Text) * Convert.ToDouble(HotDogPrice.Text);

                if (HamburgerCount.Enabled && !string.IsNullOrWhiteSpace(HamburgerCount.Text))
                    calc += Convert.ToInt32(HamburgerCount.Text) * Convert.ToDouble(HamburgerPrice.Text);

                if (FrenchFriesCount.Enabled && !string.IsNullOrWhiteSpace(FrenchFriesCount.Text))
                    calc += Convert.ToInt32(FrenchFriesCount.Text) * Convert.ToDouble(FrenchFriesPrice.Text);

                if (CocaColaCount.Enabled && !string.IsNullOrWhiteSpace(CocaColaCount.Text))
                    calc += Convert.ToInt32(CocaColaCount.Text) * Convert.ToDouble(CocaColaPrice.Text);
            }
            catch
            {
                MessageBox.Show("Only integer values", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DishPrice.Text = calc.ToString();
        }
    }

    private void Payment(object sender, EventArgs e) => TotalGroupBox.Text = (Convert.ToDouble(RefuelPrice.Text) + Convert.ToDouble(DishPrice.Text)).ToString();

    private void BuyBtn_Click(object sender, EventArgs e)
    {
        if (TotalGroupBox.Text.Equals("0"))
        {
            MessageBox.Show("??????", "Invalid Operation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        MessageBox.Show("successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void PaymentType_CheckedChanged(object sender, EventArgs e)
    {
        if (sender is RadioButton rb)
        {
            if (rb.Name == nameof(CountRadioButton))
            {
                CountEntry.Enabled = (rb.Checked) ? true : false;
                FuelCount(CountEntry, null);
            }
            if (rb.Name == nameof(CashRadioButton))
            {
                CashEntry.Enabled = (rb.Checked) ? true : false;
                FuelCount(CashEntry, null);
            }
        }
    }

    private void ComboBox(object sender, EventArgs e)
    {
        if (sender is ComboBox cb)
        {
            if (cb.SelectedItem.ToString().Equals("AI-99")) FuelPrice.Text = "1.50";
            else if (cb.SelectedItem.ToString().Equals("AI-95")) FuelPrice.Text = "1.40";
            else if (cb.SelectedItem.ToString().Equals("AI-98")) FuelPrice.Text = "1.55";

            FuelCount((CountRadioButton.Checked) ? CountEntry : CashEntry, null);
        }
    }

    private void FuelCount(object sender, EventArgs e)
    {
        if (sender is TextBox tb)
        {
            try
            {
                if (CountRadioButton.Checked && !string.IsNullOrWhiteSpace(tb.Text) && !tb.Text.EndsWith("."))
                {
                    CashEntry.TextChanged -= FuelCount;
                    CashEntry.Text = (Convert.ToDouble(tb.Text) * Convert.ToDouble(FuelPrice.Text)).ToString();
                    RefuelPrice.Text = CashEntry.Text;
                    CashEntry.TextChanged += FuelCount;
                }
                else if (CashRadioButton.Checked && !string.IsNullOrWhiteSpace(tb.Text) && !tb.Text.EndsWith("."))
                {
                    CountEntry.TextChanged -= FuelCount;
                    CountEntry.Text = Math.Round((Convert.ToDouble(tb.Text) / Convert.ToDouble(FuelPrice.Text)), 2).ToString();
                    RefuelPrice.Text = tb.Text;
                    CountEntry.TextChanged += FuelCount;
                }
            }
            catch
            {
                MessageBox.Show("integer", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void RefuelGroupBox_Enter(object sender, EventArgs e)
    {

    }
}
