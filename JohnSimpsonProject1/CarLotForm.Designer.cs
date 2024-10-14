namespace JohnSimpsonProject1
{
    partial class CarLotForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainDisplay = new ListBox();
            label1 = new Label();
            AddVehicleToLot = new Button();
            RefreshCarLot = new Button();
            ShopperName = new ListBox();
            addShopper = new Button();
            ShopperBudget = new ListBox();
            SuspendLayout();
            // 
            // MainDisplay
            // 
            MainDisplay.FormattingEnabled = true;
            MainDisplay.ItemHeight = 15;
            MainDisplay.Location = new Point(35, 27);
            MainDisplay.Name = "MainDisplay";
            MainDisplay.Size = new Size(331, 214);
            MainDisplay.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 1;
            label1.Text = "Vehicles on the lot";
            // 
            // AddVehicleToLot
            // 
            AddVehicleToLot.Location = new Point(35, 257);
            AddVehicleToLot.Name = "AddVehicleToLot";
            AddVehicleToLot.Size = new Size(123, 23);
            AddVehicleToLot.TabIndex = 2;
            AddVehicleToLot.Text = "Add Vehicle To Lot";
            AddVehicleToLot.UseVisualStyleBackColor = true;
            AddVehicleToLot.Click += AddVehicleToLot_Click;
            // 
            // RefreshCarLot
            // 
            RefreshCarLot.Location = new Point(291, 257);
            RefreshCarLot.Name = "RefreshCarLot";
            RefreshCarLot.Size = new Size(75, 23);
            RefreshCarLot.TabIndex = 3;
            RefreshCarLot.Text = "Refresh";
            RefreshCarLot.UseVisualStyleBackColor = true;
            RefreshCarLot.Click += RefreshCarLot_Click;
            // 
            // ShopperName
            // 
            ShopperName.FormattingEnabled = true;
            ShopperName.ItemHeight = 15;
            ShopperName.Location = new Point(601, 27);
            ShopperName.Name = "ShopperName";
            ShopperName.Size = new Size(128, 34);
            ShopperName.TabIndex = 4;
            // 
            // addShopper
            // 
            addShopper.Location = new Point(601, 181);
            addShopper.Name = "addShopper";
            addShopper.Size = new Size(141, 23);
            addShopper.TabIndex = 5;
            addShopper.Text = "Tell us about yourself!";
            addShopper.UseVisualStyleBackColor = true;
            addShopper.Click += addShopper_Click;
            // 
            // ShopperBudget
            // 
            ShopperBudget.FormattingEnabled = true;
            ShopperBudget.ItemHeight = 15;
            ShopperBudget.Location = new Point(792, 27);
            ShopperBudget.Name = "ShopperBudget";
            ShopperBudget.Size = new Size(128, 34);
            ShopperBudget.TabIndex = 6;
            // 
            // CarLotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 595);
            Controls.Add(ShopperBudget);
            Controls.Add(addShopper);
            Controls.Add(ShopperName);
            Controls.Add(RefreshCarLot);
            Controls.Add(AddVehicleToLot);
            Controls.Add(label1);
            Controls.Add(MainDisplay);
            Name = "CarLotForm";
            Text = "The Car Lot ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox MainDisplay;
        private Label label1;
        private Button AddVehicleToLot;
        private Button RefreshCarLot;
        private ListBox ShopperName;
        private Button addShopper;
        private ListBox ShopperBudget;
    }
}