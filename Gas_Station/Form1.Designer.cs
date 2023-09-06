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
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            toolStripDropDownButton = new ToolStripDropDownButton();
            englishMenuItem = new ToolStripMenuItem();
            ukrainianMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            toolStripTextBox1 = new ToolStripTextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            contextMenu = new ContextMenuStrip(components);
            restoreMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            notifyIcon = new NotifyIcon(components);
            groupBoxGasStation.SuspendLayout();
            groupBoxTotalPrice.SuspendLayout();
            groupBoxClientChoiseConsider.SuspendLayout();
            groupBoxCaffe.SuspendLayout();
            groupBoxTotalPriceCafe.SuspendLayout();
            groupBoxTotalPriceBestOil.SuspendLayout();
            statusStrip.SuspendLayout();
            contextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxGasStation
            // 
            resources.ApplyResources(groupBoxGasStation, "groupBoxGasStation");
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
            groupBoxGasStation.Name = "groupBoxGasStation";
            groupBoxGasStation.TabStop = false;
            // 
            // groupBoxTotalPrice
            // 
            resources.ApplyResources(groupBoxTotalPrice, "groupBoxTotalPrice");
            groupBoxTotalPrice.Controls.Add(labelTotalPriceMoneyGasStation);
            groupBoxTotalPrice.Controls.Add(labelTotalPrice);
            groupBoxTotalPrice.ForeColor = SystemColors.Highlight;
            groupBoxTotalPrice.Name = "groupBoxTotalPrice";
            groupBoxTotalPrice.TabStop = false;
            // 
            // labelTotalPriceMoneyGasStation
            // 
            resources.ApplyResources(labelTotalPriceMoneyGasStation, "labelTotalPriceMoneyGasStation");
            labelTotalPriceMoneyGasStation.ForeColor = SystemColors.ControlText;
            labelTotalPriceMoneyGasStation.Name = "labelTotalPriceMoneyGasStation";
            // 
            // labelTotalPrice
            // 
            resources.ApplyResources(labelTotalPrice, "labelTotalPrice");
            labelTotalPrice.ForeColor = SystemColors.ControlText;
            labelTotalPrice.Name = "labelTotalPrice";
            // 
            // labelQuantity
            // 
            resources.ApplyResources(labelQuantity, "labelQuantity");
            labelQuantity.ForeColor = SystemColors.ControlText;
            labelQuantity.Name = "labelQuantity";
            // 
            // labelSum
            // 
            resources.ApplyResources(labelSum, "labelSum");
            labelSum.ForeColor = SystemColors.ControlText;
            labelSum.Name = "labelSum";
            // 
            // textBoxSum
            // 
            resources.ApplyResources(textBoxSum, "textBoxSum");
            textBoxSum.Name = "textBoxSum";
            textBoxSum.KeyDown += textBoxSum_KeyDown;
            // 
            // textBoxQuantity
            // 
            resources.ApplyResources(textBoxQuantity, "textBoxQuantity");
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.KeyDown += textBoxQuantity_KeyDown;
            // 
            // groupBoxClientChoiseConsider
            // 
            resources.ApplyResources(groupBoxClientChoiseConsider, "groupBoxClientChoiseConsider");
            groupBoxClientChoiseConsider.Controls.Add(radioButtonSum);
            groupBoxClientChoiseConsider.Controls.Add(radioButtonQuantity);
            groupBoxClientChoiseConsider.ForeColor = SystemColors.ControlText;
            groupBoxClientChoiseConsider.Name = "groupBoxClientChoiseConsider";
            groupBoxClientChoiseConsider.TabStop = false;
            // 
            // radioButtonSum
            // 
            resources.ApplyResources(radioButtonSum, "radioButtonSum");
            radioButtonSum.Name = "radioButtonSum";
            radioButtonSum.TabStop = true;
            radioButtonSum.UseVisualStyleBackColor = true;
            radioButtonSum.CheckedChanged += radioButtonSum_CheckedChanged;
            // 
            // radioButtonQuantity
            // 
            resources.ApplyResources(radioButtonQuantity, "radioButtonQuantity");
            radioButtonQuantity.Name = "radioButtonQuantity";
            radioButtonQuantity.TabStop = true;
            radioButtonQuantity.UseVisualStyleBackColor = true;
            radioButtonQuantity.CheckedChanged += radioButtonQuantity_CheckedChanged;
            // 
            // labelPriceMoneyExchange
            // 
            resources.ApplyResources(labelPriceMoneyExchange, "labelPriceMoneyExchange");
            labelPriceMoneyExchange.ForeColor = SystemColors.ControlText;
            labelPriceMoneyExchange.Name = "labelPriceMoneyExchange";
            // 
            // textBoxPriceGas
            // 
            resources.ApplyResources(textBoxPriceGas, "textBoxPriceGas");
            textBoxPriceGas.Name = "textBoxPriceGas";
            textBoxPriceGas.TextChanged += textBoxPriceGas_TextChanged;
            // 
            // labelPriceGas
            // 
            resources.ApplyResources(labelPriceGas, "labelPriceGas");
            labelPriceGas.ForeColor = SystemColors.ControlText;
            labelPriceGas.Name = "labelPriceGas";
            // 
            // labelGas
            // 
            resources.ApplyResources(labelGas, "labelGas");
            labelGas.ForeColor = SystemColors.ControlText;
            labelGas.Name = "labelGas";
            // 
            // comboBoxGas
            // 
            resources.ApplyResources(comboBoxGas, "comboBoxGas");
            comboBoxGas.DropDownHeight = 110;
            comboBoxGas.DropDownWidth = 130;
            comboBoxGas.FormattingEnabled = true;
            comboBoxGas.Items.AddRange(new object[] { resources.GetString("comboBoxGas.Items"), resources.GetString("comboBoxGas.Items1"), resources.GetString("comboBoxGas.Items2") });
            comboBoxGas.Name = "comboBoxGas";
            comboBoxGas.SelectedIndexChanged += comboBoxGas_SelectedIndexChanged;
            // 
            // groupBoxCaffe
            // 
            resources.ApplyResources(groupBoxCaffe, "groupBoxCaffe");
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
            groupBoxCaffe.Name = "groupBoxCaffe";
            groupBoxCaffe.TabStop = false;
            // 
            // labelQuantityCocaCola
            // 
            resources.ApplyResources(labelQuantityCocaCola, "labelQuantityCocaCola");
            labelQuantityCocaCola.ForeColor = SystemColors.ControlText;
            labelQuantityCocaCola.Name = "labelQuantityCocaCola";
            // 
            // labelCostCocaCola
            // 
            resources.ApplyResources(labelCostCocaCola, "labelCostCocaCola");
            labelCostCocaCola.ForeColor = SystemColors.ControlText;
            labelCostCocaCola.Name = "labelCostCocaCola";
            // 
            // textBoxQuantityCocaCola
            // 
            resources.ApplyResources(textBoxQuantityCocaCola, "textBoxQuantityCocaCola");
            textBoxQuantityCocaCola.Name = "textBoxQuantityCocaCola";
            textBoxQuantityCocaCola.KeyDown += textBoxQuantityCocaCola_KeyDown;
            // 
            // textBoxCostCocaCola
            // 
            resources.ApplyResources(textBoxCostCocaCola, "textBoxCostCocaCola");
            textBoxCostCocaCola.Name = "textBoxCostCocaCola";
            // 
            // labelQuantityFrenchFrie
            // 
            resources.ApplyResources(labelQuantityFrenchFrie, "labelQuantityFrenchFrie");
            labelQuantityFrenchFrie.ForeColor = SystemColors.ControlText;
            labelQuantityFrenchFrie.Name = "labelQuantityFrenchFrie";
            // 
            // labelCostFrenchFrie
            // 
            resources.ApplyResources(labelCostFrenchFrie, "labelCostFrenchFrie");
            labelCostFrenchFrie.ForeColor = SystemColors.ControlText;
            labelCostFrenchFrie.Name = "labelCostFrenchFrie";
            // 
            // textBoxQuantityFrenchFrie
            // 
            resources.ApplyResources(textBoxQuantityFrenchFrie, "textBoxQuantityFrenchFrie");
            textBoxQuantityFrenchFrie.Name = "textBoxQuantityFrenchFrie";
            textBoxQuantityFrenchFrie.KeyDown += textBoxQuantityFrenchFrie_KeyDown;
            // 
            // textBoxCostFrenchFrie
            // 
            resources.ApplyResources(textBoxCostFrenchFrie, "textBoxCostFrenchFrie");
            textBoxCostFrenchFrie.Name = "textBoxCostFrenchFrie";
            // 
            // labelQantityHamburher
            // 
            resources.ApplyResources(labelQantityHamburher, "labelQantityHamburher");
            labelQantityHamburher.ForeColor = SystemColors.ControlText;
            labelQantityHamburher.Name = "labelQantityHamburher";
            // 
            // labelCostHamburher
            // 
            resources.ApplyResources(labelCostHamburher, "labelCostHamburher");
            labelCostHamburher.ForeColor = SystemColors.ControlText;
            labelCostHamburher.Name = "labelCostHamburher";
            // 
            // textBoxQuantityHamburher
            // 
            resources.ApplyResources(textBoxQuantityHamburher, "textBoxQuantityHamburher");
            textBoxQuantityHamburher.Name = "textBoxQuantityHamburher";
            textBoxQuantityHamburher.KeyDown += textBoxQuantityHamburher_KeyDown;
            // 
            // textBoxCostHamburher
            // 
            resources.ApplyResources(textBoxCostHamburher, "textBoxCostHamburher");
            textBoxCostHamburher.Name = "textBoxCostHamburher";
            // 
            // labelQuantityHotDog
            // 
            resources.ApplyResources(labelQuantityHotDog, "labelQuantityHotDog");
            labelQuantityHotDog.ForeColor = SystemColors.ControlText;
            labelQuantityHotDog.Name = "labelQuantityHotDog";
            // 
            // labelCostHotDog
            // 
            resources.ApplyResources(labelCostHotDog, "labelCostHotDog");
            labelCostHotDog.ForeColor = SystemColors.ControlText;
            labelCostHotDog.Name = "labelCostHotDog";
            // 
            // textBoxQuantityHotDog
            // 
            resources.ApplyResources(textBoxQuantityHotDog, "textBoxQuantityHotDog");
            textBoxQuantityHotDog.Name = "textBoxQuantityHotDog";
            textBoxQuantityHotDog.KeyDown += textBoxQuantityHotDog_KeyDown;
            // 
            // textBoxHotDogCost
            // 
            resources.ApplyResources(textBoxHotDogCost, "textBoxHotDogCost");
            textBoxHotDogCost.Name = "textBoxHotDogCost";
            // 
            // checkBoxCocaCola
            // 
            resources.ApplyResources(checkBoxCocaCola, "checkBoxCocaCola");
            checkBoxCocaCola.ForeColor = SystemColors.ControlText;
            checkBoxCocaCola.Name = "checkBoxCocaCola";
            checkBoxCocaCola.UseVisualStyleBackColor = true;
            checkBoxCocaCola.CheckedChanged += checkBoxCocaCola_CheckedChanged;
            // 
            // checkBoxFrenchFrie
            // 
            resources.ApplyResources(checkBoxFrenchFrie, "checkBoxFrenchFrie");
            checkBoxFrenchFrie.ForeColor = SystemColors.ControlText;
            checkBoxFrenchFrie.Name = "checkBoxFrenchFrie";
            checkBoxFrenchFrie.UseVisualStyleBackColor = true;
            checkBoxFrenchFrie.CheckedChanged += checkBoxFrenchFrie_CheckedChanged;
            // 
            // checkBoxHamburher
            // 
            resources.ApplyResources(checkBoxHamburher, "checkBoxHamburher");
            checkBoxHamburher.ForeColor = SystemColors.ControlText;
            checkBoxHamburher.Name = "checkBoxHamburher";
            checkBoxHamburher.UseVisualStyleBackColor = true;
            checkBoxHamburher.CheckedChanged += checkBoxHamburher_CheckedChanged;
            // 
            // checkBoxHotDog
            // 
            resources.ApplyResources(checkBoxHotDog, "checkBoxHotDog");
            checkBoxHotDog.ForeColor = SystemColors.ControlText;
            checkBoxHotDog.Name = "checkBoxHotDog";
            checkBoxHotDog.UseVisualStyleBackColor = true;
            checkBoxHotDog.CheckedChanged += checkBoxHotDog_CheckedChanged;
            // 
            // groupBoxTotalPriceCafe
            // 
            resources.ApplyResources(groupBoxTotalPriceCafe, "groupBoxTotalPriceCafe");
            groupBoxTotalPriceCafe.Controls.Add(labelMoneyTotalPriceCafe);
            groupBoxTotalPriceCafe.Controls.Add(labelTotalPriceCafe);
            groupBoxTotalPriceCafe.ForeColor = SystemColors.Highlight;
            groupBoxTotalPriceCafe.Name = "groupBoxTotalPriceCafe";
            groupBoxTotalPriceCafe.TabStop = false;
            // 
            // labelMoneyTotalPriceCafe
            // 
            resources.ApplyResources(labelMoneyTotalPriceCafe, "labelMoneyTotalPriceCafe");
            labelMoneyTotalPriceCafe.ForeColor = SystemColors.ControlText;
            labelMoneyTotalPriceCafe.Name = "labelMoneyTotalPriceCafe";
            // 
            // labelTotalPriceCafe
            // 
            resources.ApplyResources(labelTotalPriceCafe, "labelTotalPriceCafe");
            labelTotalPriceCafe.ForeColor = SystemColors.ControlText;
            labelTotalPriceCafe.Name = "labelTotalPriceCafe";
            // 
            // labelQuantityCafeProducts
            // 
            resources.ApplyResources(labelQuantityCafeProducts, "labelQuantityCafeProducts");
            labelQuantityCafeProducts.ForeColor = SystemColors.ControlText;
            labelQuantityCafeProducts.Name = "labelQuantityCafeProducts";
            // 
            // labelCostCafeProducts
            // 
            resources.ApplyResources(labelCostCafeProducts, "labelCostCafeProducts");
            labelCostCafeProducts.ForeColor = SystemColors.ControlText;
            labelCostCafeProducts.Name = "labelCostCafeProducts";
            // 
            // groupBoxTotalPriceBestOil
            // 
            resources.ApplyResources(groupBoxTotalPriceBestOil, "groupBoxTotalPriceBestOil");
            groupBoxTotalPriceBestOil.Controls.Add(labelGoodLuck);
            groupBoxTotalPriceBestOil.Controls.Add(buttonTotalPriceBestOil);
            groupBoxTotalPriceBestOil.Controls.Add(labelMoneyTotalPriceBestOil);
            groupBoxTotalPriceBestOil.Controls.Add(labelTotalPriceBestOil);
            groupBoxTotalPriceBestOil.ForeColor = SystemColors.Highlight;
            groupBoxTotalPriceBestOil.Name = "groupBoxTotalPriceBestOil";
            groupBoxTotalPriceBestOil.TabStop = false;
            // 
            // labelGoodLuck
            // 
            resources.ApplyResources(labelGoodLuck, "labelGoodLuck");
            labelGoodLuck.Name = "labelGoodLuck";
            // 
            // buttonTotalPriceBestOil
            // 
            resources.ApplyResources(buttonTotalPriceBestOil, "buttonTotalPriceBestOil");
            buttonTotalPriceBestOil.BackColor = SystemColors.GradientActiveCaption;
            buttonTotalPriceBestOil.ForeColor = SystemColors.ControlText;
            buttonTotalPriceBestOil.Name = "buttonTotalPriceBestOil";
            buttonTotalPriceBestOil.UseVisualStyleBackColor = false;
            buttonTotalPriceBestOil.Click += buttonTotalPriceBestOil_Click;
            // 
            // labelMoneyTotalPriceBestOil
            // 
            resources.ApplyResources(labelMoneyTotalPriceBestOil, "labelMoneyTotalPriceBestOil");
            labelMoneyTotalPriceBestOil.ForeColor = SystemColors.ControlText;
            labelMoneyTotalPriceBestOil.Name = "labelMoneyTotalPriceBestOil";
            // 
            // labelTotalPriceBestOil
            // 
            resources.ApplyResources(labelTotalPriceBestOil, "labelTotalPriceBestOil");
            labelTotalPriceBestOil.ForeColor = SystemColors.ControlText;
            labelTotalPriceBestOil.Name = "labelTotalPriceBestOil";
            // 
            // statusStrip
            // 
            resources.ApplyResources(statusStrip, "statusStrip");
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel, toolStripDropDownButton, toolStripDropDownButton1 });
            statusStrip.Name = "statusStrip";
            // 
            // statusLabel
            // 
            resources.ApplyResources(statusLabel, "statusLabel");
            statusLabel.Name = "statusLabel";
            // 
            // toolStripDropDownButton
            // 
            resources.ApplyResources(toolStripDropDownButton, "toolStripDropDownButton");
            toolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { englishMenuItem, ukrainianMenuItem });
            toolStripDropDownButton.Name = "toolStripDropDownButton";
            // 
            // englishMenuItem
            // 
            resources.ApplyResources(englishMenuItem, "englishMenuItem");
            englishMenuItem.CheckOnClick = true;
            englishMenuItem.Name = "englishMenuItem";
            englishMenuItem.Click += englishMenuItem_Click;
            // 
            // ukrainianMenuItem
            // 
            resources.ApplyResources(ukrainianMenuItem, "ukrainianMenuItem");
            ukrainianMenuItem.CheckOnClick = true;
            ukrainianMenuItem.Name = "ukrainianMenuItem";
            ukrainianMenuItem.Click += ukrainianMenuItem_Click;
            // 
            // toolStripDropDownButton1
            // 
            resources.ApplyResources(toolStripDropDownButton1, "toolStripDropDownButton1");
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            // 
            // toolStripTextBox1
            // 
            resources.ApplyResources(toolStripTextBox1, "toolStripTextBox1");
            toolStripTextBox1.Name = "toolStripTextBox1";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // contextMenu
            // 
            resources.ApplyResources(contextMenu, "contextMenu");
            contextMenu.ImageScalingSize = new Size(24, 24);
            contextMenu.Items.AddRange(new ToolStripItem[] { restoreMenuItem, exitMenuItem });
            contextMenu.Name = "contextMenu";
            contextMenu.ShowCheckMargin = true;
            // 
            // restoreMenuItem
            // 
            resources.ApplyResources(restoreMenuItem, "restoreMenuItem");
            restoreMenuItem.Name = "restoreMenuItem";
            restoreMenuItem.Click += restoreMenuItem_Click;
            // 
            // exitMenuItem
            // 
            resources.ApplyResources(exitMenuItem, "exitMenuItem");
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Click += exitMenuItem_Click;
            // 
            // notifyIcon
            // 
            resources.ApplyResources(notifyIcon, "notifyIcon");
            notifyIcon.ContextMenuStrip = contextMenu;
            // 
            // BestOilForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            Controls.Add(statusStrip);
            Controls.Add(groupBoxTotalPriceBestOil);
            Controls.Add(groupBoxCaffe);
            Controls.Add(groupBoxGasStation);
            Name = "BestOilForm";
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
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            contextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;
        private ToolStripDropDownButton toolStripDropDownButton;
        private ToolStripMenuItem englishMenuItem;
        private ToolStripMenuItem ukrainianMenuItem;
        private System.Windows.Forms.Timer timer1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripTextBox toolStripTextBox1;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem restoreMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private NotifyIcon notifyIcon;
    }
}