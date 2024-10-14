namespace JohnSimpsonProject1
{
    partial class AddCarForm
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
            label1 = new Label();
            MakeTextBox = new TextBox();
            ModelTextBox = new TextBox();
            label2 = new Label();
            MpgTextBox = new TextBox();
            label3 = new Label();
            PriceTextBox = new TextBox();
            label4 = new Label();
            AddVehicleToLot = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 92);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 7;
            label1.Text = "Make";
            // 
            // MakeTextBox
            // 
            MakeTextBox.Location = new Point(137, 110);
            MakeTextBox.Name = "MakeTextBox";
            MakeTextBox.Size = new Size(100, 23);
            MakeTextBox.TabIndex = 0;
            // 
            // ModelTextBox
            // 
            ModelTextBox.Location = new Point(290, 110);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(100, 23);
            ModelTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 92);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 7;
            label2.Text = "Model";
            // 
            // MpgTextBox
            // 
            MpgTextBox.Location = new Point(439, 110);
            MpgTextBox.Name = "MpgTextBox";
            MpgTextBox.Size = new Size(100, 23);
            MpgTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(439, 92);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "MPG";
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(579, 110);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(100, 23);
            PriceTextBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(579, 92);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 6;
            label4.Text = "Price $";
            // 
            // AddVehicleToLot
            // 
            AddVehicleToLot.Location = new Point(325, 233);
            AddVehicleToLot.Name = "AddVehicleToLot";
            AddVehicleToLot.Size = new Size(162, 23);
            AddVehicleToLot.TabIndex = 4;
            AddVehicleToLot.Text = "Add Vehicle to the  Car Lot!";
            AddVehicleToLot.UseVisualStyleBackColor = true;
            AddVehicleToLot.Click += AddVehicleToLot_Click;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddVehicleToLot);
            Controls.Add(PriceTextBox);
            Controls.Add(label4);
            Controls.Add(MpgTextBox);
            Controls.Add(label3);
            Controls.Add(ModelTextBox);
            Controls.Add(label2);
            Controls.Add(MakeTextBox);
            Controls.Add(label1);
            Name = "AddCarForm";
            Text = "AddCarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox MakeTextBox;
        private TextBox ModelTextBox;
        private Label label2;
        private TextBox MpgTextBox;
        private Label label3;
        private TextBox PriceTextBox;
        private Label label4;
        private Button AddVehicleToLot;
    }
}