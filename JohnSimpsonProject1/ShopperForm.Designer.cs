namespace JohnSimpsonProject1
{
    partial class ShopperForm
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
            Submit = new Button();
            ShopperNameBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ShopperBudgetBox = new TextBox();
            SuspendLayout();
            // 
            // Submit
            // 
            Submit.Location = new Point(327, 299);
            Submit.Name = "Submit";
            Submit.Size = new Size(104, 23);
            Submit.TabIndex = 3;
            Submit.Text = "Submit Info";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // ShopperNameBox
            // 
            ShopperNameBox.Location = new Point(211, 162);
            ShopperNameBox.Name = "ShopperNameBox";
            ShopperNameBox.Size = new Size(136, 23);
            ShopperNameBox.TabIndex = 1;
            ShopperNameBox.TextChanged += ShopperNameBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 144);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 2;
            label1.Text = "What is your name?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 144);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 4;
            label2.Text = "What is your budget?";
            // 
            // ShopperBudgetBox
            // 
            ShopperBudgetBox.Location = new Point(439, 162);
            ShopperBudgetBox.Name = "ShopperBudgetBox";
            ShopperBudgetBox.Size = new Size(136, 23);
            ShopperBudgetBox.TabIndex = 2;
            // 
            // ShopperForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(ShopperBudgetBox);
            Controls.Add(label1);
            Controls.Add(ShopperNameBox);
            Controls.Add(Submit);
            Name = "ShopperForm";
            Text = "ShopperForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Submit;
        private TextBox ShopperNameBox;
        private Label label1;
        private Label label2;
        private TextBox ShopperBudgetBox;
    }
}