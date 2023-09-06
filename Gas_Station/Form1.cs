using System.ComponentModel;
using System.Globalization;

namespace Gas_Station
{
    public partial class BestOilForm : Form
    {
        public BestOilForm()
        {

            InitializeComponent();
            timer1.Start();
        }
        bool clearForm = false;
        decimal price = 0;
        decimal quantity = 0;

        private void comboBoxGas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxGas.SelectedItem.ToString())
            {
                case "92":
                    price = 30;
                    textBoxPriceGas.Text = price.ToString();
                    break;
                case "95":
                    price = 35;
                    textBoxPriceGas.Text = price.ToString();
                    break;
                case "ДТ":
                    price = 32;
                    textBoxPriceGas.Text = price.ToString();
                    break;
            }
        }


        private void textBoxPriceGas_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxPriceGas.Text, out quantity))
            {
                price = quantity;//Ми можемо змінити ціну на пальне
            }
            else if (clearForm == true)
            {
                MessageBox.Show("Невірний формат ціни", "Помилка", MessageBoxButtons.OK);
            }
        }

        private void radioButtonQuantity_CheckedChanged(object sender, EventArgs e)
        {
            textBoxQuantity.Enabled = radioButtonQuantity.Checked;
            textBoxSum.Enabled = !radioButtonQuantity.Checked;
            textBoxSum.Text = $"{decimal.Parse(textBoxQuantity.Text) * price}";
            if (textBoxPriceGas.Text != "" && textBoxQuantity.Text != "" && radioButtonQuantity.Checked)
            {
                decimal totalPrice = price * decimal.Parse(textBoxQuantity.Text);
                labelTotalPrice.Text = totalPrice.ToString();
            }
            else if (clearForm == true)
                MessageBox.Show("Ви щось не відмітили в цьому вікні", "Помилка", MessageBoxButtons.OK);
        }

        private void radioButtonSum_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSum.Enabled = radioButtonSum.Checked;
            textBoxQuantity.Enabled = !radioButtonSum.Checked;
            textBoxQuantity.Text = $"{decimal.Parse(textBoxSum.Text) / price}";
            if (textBoxPriceGas.Text != "" && textBoxSum.Text != "" && radioButtonSum.Checked)
            {
                decimal sum = decimal.Parse(textBoxSum.Text);
                labelTotalPrice.Text = sum.ToString();
            }
            else if (clearForm == true)
                MessageBox.Show("Ви щось не відмітили в цьому вікні", "Помилка", MessageBoxButtons.OK);
        }

        private void textBoxQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxPriceGas.Text != "" && textBoxQuantity.Text != "" && radioButtonQuantity.Checked)
                {
                    decimal price = decimal.Parse(textBoxPriceGas.Text);
                    decimal quantity = decimal.Parse(textBoxQuantity.Text);
                    decimal totalPrice = price * quantity;
                    labelTotalPrice.Text = totalPrice.ToString();
                }
                else if (clearForm == true)
                    MessageBox.Show("Ви щось не відмітили в цьому вікні", "Помилка", MessageBoxButtons.OK);
            }
        }

        private void textBoxSum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxPriceGas.Text != "" && textBoxSum.Text != "" && radioButtonSum.Checked)
                {
                    decimal sum = decimal.Parse(textBoxSum.Text);
                    textBoxQuantity.Text = $"{decimal.Parse(textBoxSum.Text) / price}";
                    labelTotalPrice.Text = sum.ToString();
                }
                else if (clearForm == true)
                    MessageBox.Show("Ви щось не відмітили в цьому вікні", "Помилка", MessageBoxButtons.OK);
            }
        }

        decimal total_cost_cafe = 0;
        private void checkBoxHotDog_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHotDog.Checked)
            {
                textBoxQuantityHotDog.Enabled = true;
                textBoxQuantityHotDog.Text = "1";
                total_cost_cafe += (decimal.Parse(textBoxQuantityHotDog.Text) * decimal.Parse(textBoxHotDogCost.Text));
                labelTotalPriceCafe.Text = $"{total_cost_cafe}";
            }
            else
            {
                textBoxQuantityHotDog.Enabled = false;
                total_cost_cafe -= (decimal.Parse(textBoxQuantityHotDog.Text) * decimal.Parse(textBoxHotDogCost.Text));
                textBoxQuantityHotDog.Text = "";
                labelTotalPriceCafe.Text = $"{total_cost_cafe}";
            }
        }

        private void checkBoxHamburher_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHamburher.Checked)
            {
                textBoxQuantityHamburher.Enabled = true;
                textBoxQuantityHamburher.Text = "1";
                total_cost_cafe += (decimal.Parse(textBoxQuantityHamburher.Text) * decimal.Parse(textBoxCostHamburher.Text));
                labelTotalPriceCafe.Text = $"{total_cost_cafe}";
            }
            else
            {
                textBoxQuantityHamburher.Enabled = false;
                total_cost_cafe -= (decimal.Parse(textBoxQuantityHamburher.Text) * decimal.Parse(textBoxCostHamburher.Text));
                textBoxQuantityHamburher.Text = "";
                labelTotalPriceCafe.Text = $"{total_cost_cafe}";
            }
        }

        private void checkBoxFrenchFrie_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFrenchFrie.Checked)
            {
                textBoxQuantityFrenchFrie.Enabled = true;
                textBoxQuantityFrenchFrie.Text = "1";
                total_cost_cafe += (decimal.Parse(textBoxQuantityFrenchFrie.Text) * decimal.Parse(textBoxCostFrenchFrie.Text));
                labelTotalPriceCafe.Text = $"{total_cost_cafe}";
            }
            else
            {
                textBoxQuantityFrenchFrie.Enabled = false;
                total_cost_cafe -= (decimal.Parse(textBoxQuantityFrenchFrie.Text) * decimal.Parse(textBoxCostFrenchFrie.Text));
                textBoxQuantityFrenchFrie.Text = "";
                labelTotalPriceCafe.Text = $"{total_cost_cafe}";
            }
        }

        private void checkBoxCocaCola_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCocaCola.Checked)
            {
                textBoxQuantityCocaCola.Enabled = true;
                textBoxQuantityCocaCola.Text = "1";
                total_cost_cafe += (decimal.Parse(textBoxQuantityCocaCola.Text) * decimal.Parse(textBoxCostCocaCola.Text));
                labelTotalPriceCafe.Text = $"{total_cost_cafe}";
            }
            else
            {
                textBoxQuantityCocaCola.Enabled = false;
                total_cost_cafe -= (decimal.Parse(textBoxQuantityCocaCola.Text) * decimal.Parse(textBoxCostCocaCola.Text));
                textBoxQuantityCocaCola.Text = "";
                labelTotalPriceCafe.Text = $"{total_cost_cafe}";
            }
        }

        private void textBoxQuantityHotDog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                total_cost_cafe += (decimal.Parse(textBoxQuantityHotDog.Text) * decimal.Parse(textBoxHotDogCost.Text) - decimal.Parse(textBoxHotDogCost.Text));
                labelTotalPriceCafe.Text = $"{total_cost_cafe}";
            }
        }

        private void textBoxQuantityHamburher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                total_cost_cafe += (decimal.Parse(textBoxQuantityHamburher.Text) * decimal.Parse(textBoxCostHamburher.Text) - decimal.Parse(textBoxCostHamburher.Text));
                labelTotalPriceCafe.Text = $"{total_cost_cafe}";
            }
        }

        private void textBoxQuantityFrenchFrie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                total_cost_cafe += (decimal.Parse(textBoxQuantityFrenchFrie.Text) * decimal.Parse(textBoxCostFrenchFrie.Text) - decimal.Parse(textBoxCostFrenchFrie.Text));
                labelTotalPriceCafe.Text = $"{total_cost_cafe}";
            }
        }

        private void textBoxQuantityCocaCola_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                total_cost_cafe += (decimal.Parse(textBoxQuantityCocaCola.Text) * decimal.Parse(textBoxCostCocaCola.Text) - decimal.Parse(textBoxCostCocaCola.Text));
                labelTotalPriceCafe.Text = $"{total_cost_cafe}";
            }
        }

        private void buttonTotalPriceBestOil_Click(object sender, EventArgs e)
        {
            labelTotalPriceBestOil.Text = $"{decimal.Parse(labelTotalPrice.Text) + decimal.Parse(labelTotalPriceCafe.Text)}";

            timer.Interval = 3000;
            timer.Start();
            timer.Tick += (sender, e) =>
            {
                timer.Stop();
                DialogResult result = MessageBox.Show("Очистити форму?", "Питання", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ClearForm();
                }
                else
                {
                    timer.Interval = 3000;
                    timer.Start();
                }
            };
        }
        bool ClearForm()
        {
            comboBoxGas.Text = string.Empty;
            textBoxPriceGas.Text = string.Empty;
            textBoxQuantity.Text = "0";
            textBoxSum.Text = "0";
            radioButtonQuantity.Checked = false;
            radioButtonSum.Checked = false;
            labelTotalPrice.Text = "0,00";
            checkBoxHotDog.Checked = false;
            checkBoxHamburher.Checked = false;
            checkBoxFrenchFrie.Checked = false;
            checkBoxCocaCola.Checked = false;
            labelTotalPriceCafe.Text = "0,00";
            labelTotalPriceBestOil.Text = "0,00";
            return clearForm = false;
        }
        private void englishMenuItem_Click(object sender, EventArgs e)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(BestOilForm));
            CultureInfo culture = new CultureInfo("en-US");
            ApplyResourcesToControl(this, resources, culture);
        }
        private void ukrainianMenuItem_Click(object sender, EventArgs e)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(BestOilForm));
            CultureInfo culture = new CultureInfo("uk-UA");
            ApplyResourcesToControl(this, resources, culture);
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (statusLabel.Text == DateTime.Now.ToString("HH: mm:ss"))
            {
                statusLabel.Text = DateTime.Now.ToString("dd.MM.yyyy");
            }
            else
            {
                statusLabel.Text = DateTime.Now.ToString("HH: mm:ss");
            }
            toolStripTextBox1.Text = DateTime.Now.ToString("dddd");
        }

        private void restoreMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }
        private void ApplyResourcesToControl(Control control, ComponentResourceManager resources, CultureInfo culture)
        {
            resources.ApplyResources(control, control.Name, culture);
            foreach (Control childControl in control.Controls)
            {
                ApplyResourcesToControl(childControl, resources, culture);
            }
        }
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
            }
        }
    }
}