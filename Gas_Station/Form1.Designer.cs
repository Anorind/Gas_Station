namespace Gas_Station
{
    partial class BestOilForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestOilForm));
            groupBoxGasStation = new GroupBox();
            groupBoxTotalPrice = new GroupBox();
            labelTotalPriceMoneyGasStation = new Label();
            labelTotalPrice = new Label();
            labelQuantity = new Label();
            labelSum = new Label();
            textBoxSum = new TextBox();
            textBoxQuantity = new TextBox();
            groupBoxClientChoiseConsider = new GroupBox();
            radioButtonSum = new RadioButton();
            radioButtonQuantity = new RadioButton();
            labelPriceMoneyExchange = new Label();
            textBoxPriceGas = new TextBox();
            labelPriceGas = new Label();
            labelGas = new Label();
            comboBoxGas = new ComboBox();
            groupBoxCaffe = new GroupBox();
            labelQuantityCocaCola = new Label();
            labelCostCocaCola = new Label();
            textBoxQuantityCocaCola = new TextBox();
            textBoxCostCocaCola = new TextBox();
            labelQuantityFrenchFrie = new Label();
            labelCostFrenchFrie = new Label();
            textBoxQuantityFrenchFrie = new TextBox();
            textBoxCostFrenchFrie = new TextBox();
            labelQantityHamburher = new Label();
            labelCostHamburher = new Label();
            textBoxQuantityHamburher = new TextBox();
            textBoxCostHamburher = new TextBox();
            labelQuantityHotDog = new Label();
            labelCostHotDog = new Label();
            textBoxQuantityHotDog = new TextBox();
            textBoxHotDogCost = new TextBox();
            checkBoxCocaCola = new CheckBox();
            checkBoxFrenchFrie = new CheckBox();
            checkBoxHamburher = new CheckBox();
            checkBoxHotDog = new CheckBox();
            groupBoxTotalPriceCafe = new GroupBox();
            labelMoneyTotalPriceCafe = new Label();
            labelTotalPriceCafe = new Label();
            labelQuantityCafeProducts = new Label();
            labelCostCafeProducts = new Label();
            groupBoxTotalPriceBestOil = new GroupBox();
            labelGoodLuck = new Label();
            buttonTotalPriceBestOil = new Button();
            labelMoneyTotalPriceBestOil = new Label();
            labelTotalPriceBestOil = new Label();
            timer = new System.Windows.Forms.Timer(components);
            groupBoxGasStation.SuspendLayout();
            groupBoxTotalPrice.SuspendLayout();
            groupBoxClientChoiseConsider.SuspendLayout();
            groupBoxCaffe.SuspendLayout();
            groupBoxTotalPriceCafe.SuspendLayout();
            groupBoxTotalPriceBestOil.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxGasStation
            // 
            groupBoxGasStation.BackColor = SystemColors.Info;
            groupBoxGasStation.Controls.Add(groupBoxTotalPrice);
            groupBoxGasStation.Controls.Add(labelQuantity);
            groupBoxGasStation.Controls.Add(labelSum);
            groupBoxGasStation.Controls.Add(textBoxSum);
            groupBoxGasStation.Controls.Add(textBoxQuantity);
            groupBoxGasStation.Controls.Add(groupBoxClientChoiseConsider);
            groupBoxGasStation.Controls.Add(labelPriceMoneyExchange);
            groupBoxGasStation.Controls.Add(textBoxPriceGas);
            groupBoxGasStation.Controls.Add(labelPriceGas);
            groupBoxGasStation.Controls.Add(labelGas);
            groupBoxGasStation.Controls.Add(comboBoxGas);
            groupBoxGasStation.FlatStyle = FlatStyle.Popup;
            groupBoxGasStation.ForeColor = SystemColors.Highlight;
            groupBoxGasStation.Location = new Point(48, 28);
            groupBoxGasStation.Name = "groupBoxGasStation";
            groupBoxGasStation.Size = new Size(290, 440);
            groupBoxGasStation.TabIndex = 0;
            groupBoxGasStation.TabStop = false;
            groupBoxGasStation.Text = "Автозаправка";
            // 
            // groupBoxTotalPrice
            // 
            groupBoxTotalPrice.Controls.Add(labelTotalPriceMoneyGasStation);
            groupBoxTotalPrice.Controls.Add(labelTotalPrice);
            groupBoxTotalPrice.ForeColor = SystemColors.Highlight;
            groupBoxTotalPrice.Location = new Point(19, 308);
            groupBoxTotalPrice.Name = "groupBoxTotalPrice";
            groupBoxTotalPrice.Size = new Size(265, 108);
            groupBoxTotalPrice.TabIndex = 10;
            groupBoxTotalPrice.TabStop = false;
            groupBoxTotalPrice.Text = "До сплати";
            // 
            // labelTotalPriceMoneyGasStation
            // 
            labelTotalPriceMoneyGasStation.AutoSize = true;
            labelTotalPriceMoneyGasStation.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalPriceMoneyGasStation.ForeColor = SystemColors.ControlText;
            labelTotalPriceMoneyGasStation.Location = new Point(171, 40);
            labelTotalPriceMoneyGasStation.Name = "labelTotalPriceMoneyGasStation";
            labelTotalPriceMoneyGasStation.Size = new Size(76, 48);
            labelTotalPriceMoneyGasStation.TabIndex = 9;
            labelTotalPriceMoneyGasStation.Text = "грн";
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalPrice.ForeColor = SystemColors.ControlText;
            labelTotalPrice.Location = new Point(49, 27);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(116, 65);
            labelTotalPrice.TabIndex = 0;
            labelTotalPrice.Text = "0,00";
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.ForeColor = SystemColors.ControlText;
            labelQuantity.Location = new Point(225, 188);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(21, 25);
            labelQuantity.TabIndex = 9;
            labelQuantity.Text = "л";
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.ForeColor = SystemColors.ControlText;
            labelSum.Location = new Point(225, 240);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(40, 25);
            labelSum.TabIndex = 8;
            labelSum.Text = "грн";
            // 
            // textBoxSum
            // 
            textBoxSum.Location = new Point(145, 234);
            textBoxSum.Name = "textBoxSum";
            textBoxSum.Size = new Size(74, 31);
            textBoxSum.TabIndex = 7;
            textBoxSum.Text = "0,00";
            textBoxSum.KeyDown += textBoxSum_KeyDown;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(145, 182);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(74, 31);
            textBoxQuantity.TabIndex = 6;
            textBoxQuantity.Text = "0,00";
            textBoxQuantity.KeyDown += textBoxQuantity_KeyDown;
            // 
            // groupBoxClientChoiseConsider
            // 
            groupBoxClientChoiseConsider.Controls.Add(radioButtonSum);
            groupBoxClientChoiseConsider.Controls.Add(radioButtonQuantity);
            groupBoxClientChoiseConsider.ForeColor = SystemColors.ControlText;
            groupBoxClientChoiseConsider.Location = new Point(18, 169);
            groupBoxClientChoiseConsider.Name = "groupBoxClientChoiseConsider";
            groupBoxClientChoiseConsider.Size = new Size(118, 114);
            groupBoxClientChoiseConsider.TabIndex = 5;
            groupBoxClientChoiseConsider.TabStop = false;
            // 
            // radioButtonSum
            // 
            radioButtonSum.AutoSize = true;
            radioButtonSum.Location = new Point(6, 67);
            radioButtonSum.Name = "radioButtonSum";
            radioButtonSum.Size = new Size(79, 29);
            radioButtonSum.TabIndex = 1;
            radioButtonSum.TabStop = true;
            radioButtonSum.Text = "Сума";
            radioButtonSum.UseVisualStyleBackColor = true;
            radioButtonSum.CheckedChanged += radioButtonSum_CheckedChanged;
            // 
            // radioButtonQuantity
            // 
            radioButtonQuantity.AutoSize = true;
            radioButtonQuantity.Location = new Point(6, 15);
            radioButtonQuantity.Name = "radioButtonQuantity";
            radioButtonQuantity.Size = new Size(106, 29);
            radioButtonQuantity.TabIndex = 0;
            radioButtonQuantity.TabStop = true;
            radioButtonQuantity.Text = "Кількість";
            radioButtonQuantity.UseVisualStyleBackColor = true;
            radioButtonQuantity.CheckedChanged += radioButtonQuantity_CheckedChanged;
            // 
            // labelPriceMoneyExchange
            // 
            labelPriceMoneyExchange.AutoSize = true;
            labelPriceMoneyExchange.ForeColor = SystemColors.ControlText;
            labelPriceMoneyExchange.Location = new Point(225, 108);
            labelPriceMoneyExchange.Name = "labelPriceMoneyExchange";
            labelPriceMoneyExchange.Size = new Size(40, 25);
            labelPriceMoneyExchange.TabIndex = 4;
            labelPriceMoneyExchange.Text = "грн";
            // 
            // textBoxPriceGas
            // 
            textBoxPriceGas.Location = new Point(105, 102);
            textBoxPriceGas.Name = "textBoxPriceGas";
            textBoxPriceGas.Size = new Size(111, 31);
            textBoxPriceGas.TabIndex = 3;
            textBoxPriceGas.TextChanged += textBoxPriceGas_TextChanged;
            // 
            // labelPriceGas
            // 
            labelPriceGas.AutoSize = true;
            labelPriceGas.ForeColor = SystemColors.ControlText;
            labelPriceGas.Location = new Point(6, 108);
            labelPriceGas.Name = "labelPriceGas";
            labelPriceGas.Size = new Size(48, 25);
            labelPriceGas.TabIndex = 2;
            labelPriceGas.Text = "Ціна";
            // 
            // labelGas
            // 
            labelGas.AutoSize = true;
            labelGas.ForeColor = SystemColors.ControlText;
            labelGas.Location = new Point(6, 38);
            labelGas.Name = "labelGas";
            labelGas.Size = new Size(69, 25);
            labelGas.TabIndex = 1;
            labelGas.Text = "Бензин";
            // 
            // comboBoxGas
            // 
            comboBoxGas.DropDownHeight = 110;
            comboBoxGas.DropDownWidth = 130;
            comboBoxGas.FlatStyle = FlatStyle.Flat;
            comboBoxGas.FormattingEnabled = true;
            comboBoxGas.IntegralHeight = false;
            comboBoxGas.Items.AddRange(new object[] { "92", "95", "ДТ" });
            comboBoxGas.Location = new Point(105, 35);
            comboBoxGas.Name = "comboBoxGas";
            comboBoxGas.Size = new Size(158, 33);
            comboBoxGas.TabIndex = 0;
            comboBoxGas.SelectedIndexChanged += comboBoxGas_SelectedIndexChanged;
            // 
            // groupBoxCaffe
            // 
            groupBoxCaffe.BackColor = SystemColors.Info;
            groupBoxCaffe.Controls.Add(labelQuantityCocaCola);
            groupBoxCaffe.Controls.Add(labelCostCocaCola);
            groupBoxCaffe.Controls.Add(textBoxQuantityCocaCola);
            groupBoxCaffe.Controls.Add(textBoxCostCocaCola);
            groupBoxCaffe.Controls.Add(labelQuantityFrenchFrie);
            groupBoxCaffe.Controls.Add(labelCostFrenchFrie);
            groupBoxCaffe.Controls.Add(textBoxQuantityFrenchFrie);
            groupBoxCaffe.Controls.Add(textBoxCostFrenchFrie);
            groupBoxCaffe.Controls.Add(labelQantityHamburher);
            groupBoxCaffe.Controls.Add(labelCostHamburher);
            groupBoxCaffe.Controls.Add(textBoxQuantityHamburher);
            groupBoxCaffe.Controls.Add(textBoxCostHamburher);
            groupBoxCaffe.Controls.Add(labelQuantityHotDog);
            groupBoxCaffe.Controls.Add(labelCostHotDog);
            groupBoxCaffe.Controls.Add(textBoxQuantityHotDog);
            groupBoxCaffe.Controls.Add(textBoxHotDogCost);
            groupBoxCaffe.Controls.Add(checkBoxCocaCola);
            groupBoxCaffe.Controls.Add(checkBoxFrenchFrie);
            groupBoxCaffe.Controls.Add(checkBoxHamburher);
            groupBoxCaffe.Controls.Add(checkBoxHotDog);
            groupBoxCaffe.Controls.Add(groupBoxTotalPriceCafe);
            groupBoxCaffe.Controls.Add(labelQuantityCafeProducts);
            groupBoxCaffe.Controls.Add(labelCostCafeProducts);
            groupBoxCaffe.FlatStyle = FlatStyle.Popup;
            groupBoxCaffe.ForeColor = SystemColors.Highlight;
            groupBoxCaffe.Location = new Point(364, 28);
            groupBoxCaffe.Name = "groupBoxCaffe";
            groupBoxCaffe.Size = new Size(398, 440);
            groupBoxCaffe.TabIndex = 1;
            groupBoxCaffe.TabStop = false;
            groupBoxCaffe.Text = "Міні-кафе";
            // 
            // labelQuantityCocaCola
            // 
            labelQuantityCocaCola.AutoSize = true;
            labelQuantityCocaCola.ForeColor = SystemColors.ControlText;
            labelQuantityCocaCola.Location = new Point(352, 236);
            labelQuantityCocaCola.Name = "labelQuantityCocaCola";
            labelQuantityCocaCola.Size = new Size(33, 25);
            labelQuantityCocaCola.TabIndex = 30;
            labelQuantityCocaCola.Text = "шт";
            // 
            // labelCostCocaCola
            // 
            labelCostCocaCola.AutoSize = true;
            labelCostCocaCola.ForeColor = SystemColors.ControlText;
            labelCostCocaCola.Location = new Point(232, 236);
            labelCostCocaCola.Name = "labelCostCocaCola";
            labelCostCocaCola.Size = new Size(40, 25);
            labelCostCocaCola.TabIndex = 29;
            labelCostCocaCola.Text = "грн";
            // 
            // textBoxQuantityCocaCola
            // 
            textBoxQuantityCocaCola.Enabled = false;
            textBoxQuantityCocaCola.Location = new Point(276, 230);
            textBoxQuantityCocaCola.Name = "textBoxQuantityCocaCola";
            textBoxQuantityCocaCola.Size = new Size(70, 31);
            textBoxQuantityCocaCola.TabIndex = 28;
            textBoxQuantityCocaCola.KeyDown += textBoxQuantityCocaCola_KeyDown;
            // 
            // textBoxCostCocaCola
            // 
            textBoxCostCocaCola.Enabled = false;
            textBoxCostCocaCola.Location = new Point(158, 230);
            textBoxCostCocaCola.Name = "textBoxCostCocaCola";
            textBoxCostCocaCola.Size = new Size(68, 31);
            textBoxCostCocaCola.TabIndex = 27;
            textBoxCostCocaCola.Text = "10";
            // 
            // labelQuantityFrenchFrie
            // 
            labelQuantityFrenchFrie.AutoSize = true;
            labelQuantityFrenchFrie.ForeColor = SystemColors.ControlText;
            labelQuantityFrenchFrie.Location = new Point(352, 189);
            labelQuantityFrenchFrie.Name = "labelQuantityFrenchFrie";
            labelQuantityFrenchFrie.Size = new Size(33, 25);
            labelQuantityFrenchFrie.TabIndex = 26;
            labelQuantityFrenchFrie.Text = "шт";
            // 
            // labelCostFrenchFrie
            // 
            labelCostFrenchFrie.AutoSize = true;
            labelCostFrenchFrie.ForeColor = SystemColors.ControlText;
            labelCostFrenchFrie.Location = new Point(232, 189);
            labelCostFrenchFrie.Name = "labelCostFrenchFrie";
            labelCostFrenchFrie.Size = new Size(40, 25);
            labelCostFrenchFrie.TabIndex = 25;
            labelCostFrenchFrie.Text = "грн";
            // 
            // textBoxQuantityFrenchFrie
            // 
            textBoxQuantityFrenchFrie.Enabled = false;
            textBoxQuantityFrenchFrie.Location = new Point(276, 182);
            textBoxQuantityFrenchFrie.Name = "textBoxQuantityFrenchFrie";
            textBoxQuantityFrenchFrie.Size = new Size(70, 31);
            textBoxQuantityFrenchFrie.TabIndex = 24;
            textBoxQuantityFrenchFrie.KeyDown += textBoxQuantityFrenchFrie_KeyDown;
            // 
            // textBoxCostFrenchFrie
            // 
            textBoxCostFrenchFrie.Enabled = false;
            textBoxCostFrenchFrie.Location = new Point(158, 183);
            textBoxCostFrenchFrie.Name = "textBoxCostFrenchFrie";
            textBoxCostFrenchFrie.Size = new Size(68, 31);
            textBoxCostFrenchFrie.TabIndex = 23;
            textBoxCostFrenchFrie.Text = "30";
            // 
            // labelQantityHamburher
            // 
            labelQantityHamburher.AutoSize = true;
            labelQantityHamburher.ForeColor = SystemColors.ControlText;
            labelQantityHamburher.Location = new Point(352, 144);
            labelQantityHamburher.Name = "labelQantityHamburher";
            labelQantityHamburher.Size = new Size(33, 25);
            labelQantityHamburher.TabIndex = 22;
            labelQantityHamburher.Text = "шт";
            // 
            // labelCostHamburher
            // 
            labelCostHamburher.AutoSize = true;
            labelCostHamburher.ForeColor = SystemColors.ControlText;
            labelCostHamburher.Location = new Point(232, 144);
            labelCostHamburher.Name = "labelCostHamburher";
            labelCostHamburher.Size = new Size(40, 25);
            labelCostHamburher.TabIndex = 21;
            labelCostHamburher.Text = "грн";
            // 
            // textBoxQuantityHamburher
            // 
            textBoxQuantityHamburher.Enabled = false;
            textBoxQuantityHamburher.Location = new Point(276, 138);
            textBoxQuantityHamburher.Name = "textBoxQuantityHamburher";
            textBoxQuantityHamburher.Size = new Size(70, 31);
            textBoxQuantityHamburher.TabIndex = 20;
            textBoxQuantityHamburher.KeyDown += textBoxQuantityHamburher_KeyDown;
            // 
            // textBoxCostHamburher
            // 
            textBoxCostHamburher.Enabled = false;
            textBoxCostHamburher.Location = new Point(158, 138);
            textBoxCostHamburher.Name = "textBoxCostHamburher";
            textBoxCostHamburher.Size = new Size(68, 31);
            textBoxCostHamburher.TabIndex = 19;
            textBoxCostHamburher.Text = "50";
            // 
            // labelQuantityHotDog
            // 
            labelQuantityHotDog.AutoSize = true;
            labelQuantityHotDog.ForeColor = SystemColors.ControlText;
            labelQuantityHotDog.Location = new Point(352, 95);
            labelQuantityHotDog.Name = "labelQuantityHotDog";
            labelQuantityHotDog.Size = new Size(33, 25);
            labelQuantityHotDog.TabIndex = 18;
            labelQuantityHotDog.Text = "шт";
            // 
            // labelCostHotDog
            // 
            labelCostHotDog.AutoSize = true;
            labelCostHotDog.ForeColor = SystemColors.ControlText;
            labelCostHotDog.Location = new Point(232, 95);
            labelCostHotDog.Name = "labelCostHotDog";
            labelCostHotDog.Size = new Size(40, 25);
            labelCostHotDog.TabIndex = 17;
            labelCostHotDog.Text = "грн";
            // 
            // textBoxQuantityHotDog
            // 
            textBoxQuantityHotDog.Enabled = false;
            textBoxQuantityHotDog.Location = new Point(276, 89);
            textBoxQuantityHotDog.Name = "textBoxQuantityHotDog";
            textBoxQuantityHotDog.Size = new Size(70, 31);
            textBoxQuantityHotDog.TabIndex = 16;
            textBoxQuantityHotDog.KeyDown += textBoxQuantityHotDog_KeyDown;
            // 
            // textBoxHotDogCost
            // 
            textBoxHotDogCost.Enabled = false;
            textBoxHotDogCost.Location = new Point(158, 89);
            textBoxHotDogCost.Name = "textBoxHotDogCost";
            textBoxHotDogCost.Size = new Size(68, 31);
            textBoxHotDogCost.TabIndex = 15;
            textBoxHotDogCost.Text = "30";
            // 
            // checkBoxCocaCola
            // 
            checkBoxCocaCola.AutoSize = true;
            checkBoxCocaCola.ForeColor = SystemColors.ControlText;
            checkBoxCocaCola.Location = new Point(6, 234);
            checkBoxCocaCola.Name = "checkBoxCocaCola";
            checkBoxCocaCola.Size = new Size(123, 29);
            checkBoxCocaCola.TabIndex = 14;
            checkBoxCocaCola.Text = "Кока-Кола";
            checkBoxCocaCola.UseVisualStyleBackColor = true;
            checkBoxCocaCola.CheckedChanged += checkBoxCocaCola_CheckedChanged;
            // 
            // checkBoxFrenchFrie
            // 
            checkBoxFrenchFrie.AutoSize = true;
            checkBoxFrenchFrie.ForeColor = SystemColors.ControlText;
            checkBoxFrenchFrie.Location = new Point(6, 187);
            checkBoxFrenchFrie.Name = "checkBoxFrenchFrie";
            checkBoxFrenchFrie.Size = new Size(146, 29);
            checkBoxFrenchFrie.TabIndex = 13;
            checkBoxFrenchFrie.Text = "Картопля фрі";
            checkBoxFrenchFrie.UseVisualStyleBackColor = true;
            checkBoxFrenchFrie.CheckedChanged += checkBoxFrenchFrie_CheckedChanged;
            // 
            // checkBoxHamburher
            // 
            checkBoxHamburher.AutoSize = true;
            checkBoxHamburher.ForeColor = SystemColors.ControlText;
            checkBoxHamburher.Location = new Point(6, 140);
            checkBoxHamburher.Name = "checkBoxHamburher";
            checkBoxHamburher.Size = new Size(125, 29);
            checkBoxHamburher.TabIndex = 12;
            checkBoxHamburher.Text = "Гамбургер";
            checkBoxHamburher.UseVisualStyleBackColor = true;
            checkBoxHamburher.CheckedChanged += checkBoxHamburher_CheckedChanged;
            // 
            // checkBoxHotDog
            // 
            checkBoxHotDog.AutoSize = true;
            checkBoxHotDog.ForeColor = SystemColors.ControlText;
            checkBoxHotDog.Location = new Point(6, 91);
            checkBoxHotDog.Name = "checkBoxHotDog";
            checkBoxHotDog.Size = new Size(104, 29);
            checkBoxHotDog.TabIndex = 11;
            checkBoxHotDog.Text = "Хот-Дог";
            checkBoxHotDog.UseVisualStyleBackColor = true;
            checkBoxHotDog.CheckedChanged += checkBoxHotDog_CheckedChanged;
            // 
            // groupBoxTotalPriceCafe
            // 
            groupBoxTotalPriceCafe.Controls.Add(labelMoneyTotalPriceCafe);
            groupBoxTotalPriceCafe.Controls.Add(labelTotalPriceCafe);
            groupBoxTotalPriceCafe.ForeColor = SystemColors.Highlight;
            groupBoxTotalPriceCafe.Location = new Point(19, 308);
            groupBoxTotalPriceCafe.Name = "groupBoxTotalPriceCafe";
            groupBoxTotalPriceCafe.Size = new Size(357, 108);
            groupBoxTotalPriceCafe.TabIndex = 10;
            groupBoxTotalPriceCafe.TabStop = false;
            groupBoxTotalPriceCafe.Text = "До сплати";
            // 
            // labelMoneyTotalPriceCafe
            // 
            labelMoneyTotalPriceCafe.AutoSize = true;
            labelMoneyTotalPriceCafe.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelMoneyTotalPriceCafe.ForeColor = SystemColors.ControlText;
            labelMoneyTotalPriceCafe.Location = new Point(171, 40);
            labelMoneyTotalPriceCafe.Name = "labelMoneyTotalPriceCafe";
            labelMoneyTotalPriceCafe.Size = new Size(76, 48);
            labelMoneyTotalPriceCafe.TabIndex = 9;
            labelMoneyTotalPriceCafe.Text = "грн";
            // 
            // labelTotalPriceCafe
            // 
            labelTotalPriceCafe.AutoSize = true;
            labelTotalPriceCafe.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalPriceCafe.ForeColor = SystemColors.ControlText;
            labelTotalPriceCafe.Location = new Point(49, 27);
            labelTotalPriceCafe.Name = "labelTotalPriceCafe";
            labelTotalPriceCafe.Size = new Size(116, 65);
            labelTotalPriceCafe.TabIndex = 0;
            labelTotalPriceCafe.Text = "0,00";
            // 
            // labelQuantityCafeProducts
            // 
            labelQuantityCafeProducts.AutoSize = true;
            labelQuantityCafeProducts.ForeColor = SystemColors.ControlText;
            labelQuantityCafeProducts.Location = new Point(276, 43);
            labelQuantityCafeProducts.Name = "labelQuantityCafeProducts";
            labelQuantityCafeProducts.Size = new Size(81, 25);
            labelQuantityCafeProducts.TabIndex = 4;
            labelQuantityCafeProducts.Text = "Кількість";
            // 
            // labelCostCafeProducts
            // 
            labelCostCafeProducts.AutoSize = true;
            labelCostCafeProducts.ForeColor = SystemColors.ControlText;
            labelCostCafeProducts.Location = new Point(168, 43);
            labelCostCafeProducts.Name = "labelCostCafeProducts";
            labelCostCafeProducts.Size = new Size(48, 25);
            labelCostCafeProducts.TabIndex = 1;
            labelCostCafeProducts.Text = "Ціна";
            // 
            // groupBoxTotalPriceBestOil
            // 
            groupBoxTotalPriceBestOil.Controls.Add(labelGoodLuck);
            groupBoxTotalPriceBestOil.Controls.Add(buttonTotalPriceBestOil);
            groupBoxTotalPriceBestOil.Controls.Add(labelMoneyTotalPriceBestOil);
            groupBoxTotalPriceBestOil.Controls.Add(labelTotalPriceBestOil);
            groupBoxTotalPriceBestOil.ForeColor = SystemColors.Highlight;
            groupBoxTotalPriceBestOil.Location = new Point(48, 493);
            groupBoxTotalPriceBestOil.Name = "groupBoxTotalPriceBestOil";
            groupBoxTotalPriceBestOil.Size = new Size(714, 194);
            groupBoxTotalPriceBestOil.TabIndex = 11;
            groupBoxTotalPriceBestOil.TabStop = false;
            groupBoxTotalPriceBestOil.Text = "Всього до сплати";
            // 
            // labelGoodLuck
            // 
            labelGoodLuck.Image = (Image)resources.GetObject("labelGoodLuck.Image");
            labelGoodLuck.ImageAlign = ContentAlignment.MiddleRight;
            labelGoodLuck.Location = new Point(36, 63);
            labelGoodLuck.MaximumSize = new Size(85, 85);
            labelGoodLuck.Name = "labelGoodLuck";
            labelGoodLuck.Size = new Size(85, 80);
            labelGoodLuck.TabIndex = 11;
            labelGoodLuck.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonTotalPriceBestOil
            // 
            buttonTotalPriceBestOil.BackColor = SystemColors.GradientActiveCaption;
            buttonTotalPriceBestOil.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTotalPriceBestOil.ForeColor = SystemColors.ControlText;
            buttonTotalPriceBestOil.Location = new Point(134, 63);
            buttonTotalPriceBestOil.Name = "buttonTotalPriceBestOil";
            buttonTotalPriceBestOil.Size = new Size(156, 86);
            buttonTotalPriceBestOil.TabIndex = 10;
            buttonTotalPriceBestOil.Text = "Прорахувати";
            buttonTotalPriceBestOil.UseVisualStyleBackColor = false;
            buttonTotalPriceBestOil.Click += buttonTotalPriceBestOil_Click;
            // 
            // labelMoneyTotalPriceBestOil
            // 
            labelMoneyTotalPriceBestOil.AutoSize = true;
            labelMoneyTotalPriceBestOil.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelMoneyTotalPriceBestOil.ForeColor = SystemColors.ControlText;
            labelMoneyTotalPriceBestOil.Location = new Point(538, 101);
            labelMoneyTotalPriceBestOil.Name = "labelMoneyTotalPriceBestOil";
            labelMoneyTotalPriceBestOil.Size = new Size(76, 48);
            labelMoneyTotalPriceBestOil.TabIndex = 9;
            labelMoneyTotalPriceBestOil.Text = "грн";
            // 
            // labelTotalPriceBestOil
            // 
            labelTotalPriceBestOil.AutoSize = true;
            labelTotalPriceBestOil.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalPriceBestOil.ForeColor = SystemColors.ControlText;
            labelTotalPriceBestOil.Location = new Point(384, 84);
            labelTotalPriceBestOil.Name = "labelTotalPriceBestOil";
            labelTotalPriceBestOil.Size = new Size(116, 65);
            labelTotalPriceBestOil.TabIndex = 0;
            labelTotalPriceBestOil.Text = "0,00";
            // 
            // BestOilForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(774, 699);
            Controls.Add(groupBoxTotalPriceBestOil);
            Controls.Add(groupBoxCaffe);
            Controls.Add(groupBoxGasStation);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BestOilForm";
            Text = "BestOil";
            groupBoxGasStation.ResumeLayout(false);
            groupBoxGasStation.PerformLayout();
            groupBoxTotalPrice.ResumeLayout(false);
            groupBoxTotalPrice.PerformLayout();
            groupBoxClientChoiseConsider.ResumeLayout(false);
            groupBoxClientChoiseConsider.PerformLayout();
            groupBoxCaffe.ResumeLayout(false);
            groupBoxCaffe.PerformLayout();
            groupBoxTotalPriceCafe.ResumeLayout(false);
            groupBoxTotalPriceCafe.PerformLayout();
            groupBoxTotalPriceBestOil.ResumeLayout(false);
            groupBoxTotalPriceBestOil.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxGasStation;
        private Label labelGas;
        private ComboBox comboBoxGas;
        private TextBox textBoxPriceGas;
        private Label labelPriceGas;
        private Label labelPriceMoneyExchange;
        private Label labelQuantity;
        private Label labelSum;
        private TextBox textBoxSum;
        private TextBox textBoxQuantity;
        private GroupBox groupBoxClientChoiseConsider;
        private RadioButton radioButtonSum;
        private RadioButton radioButtonQuantity;
        private GroupBox groupBoxTotalPrice;
        private Label labelTotalPriceMoneyGasStation;
        private Label labelTotalPrice;
        private GroupBox groupBoxCaffe;
        private Label labelCostHotDog;
        private TextBox textBoxQuantityHotDog;
        private TextBox textBoxHotDogCost;
        private CheckBox checkBoxCocaCola;
        private CheckBox checkBoxFrenchFrie;
        private CheckBox checkBoxHamburher;
        private CheckBox checkBoxHotDog;
        private GroupBox groupBoxTotalPriceCafe;
        private Label labelMoneyTotalPriceCafe;
        private Label labelTotalPriceCafe;
        private Label labelQuantityCafeProducts;
        private Label labelCostCafeProducts;
        private Label labelQuantityCocaCola;
        private Label labelCostCocaCola;
        private TextBox textBoxQuantityCocaCola;
        private TextBox textBoxCostCocaCola;
        private Label labelQuantityFrenchFrie;
        private Label labelCostFrenchFrie;
        private TextBox textBoxQuantityFrenchFrie;
        private TextBox textBoxCostFrenchFrie;
        private Label labelQantityHamburher;
        private Label labelCostHamburher;
        private TextBox textBoxQuantityHamburher;
        private TextBox textBoxCostHamburher;
        private Label labelQuantityHotDog;
        private GroupBox groupBoxTotalPriceBestOil;
        private Label labelGoodLuck;
        private Button buttonTotalPriceBestOil;
        private Label labelMoneyTotalPriceBestOil;
        private Label labelTotalPriceBestOil;
        private System.Windows.Forms.Timer timer;
    }
}