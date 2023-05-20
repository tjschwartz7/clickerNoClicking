namespace BikiniBottomCashgrab
{
    partial class Form1
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
            this.moneyLabel = new System.Windows.Forms.Label();
            this.PPButton = new System.Windows.Forms.Button();
            this.BuyCount = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TAButton = new System.Windows.Forms.Button();
            this.PPOwnedLabel = new System.Windows.Forms.Label();
            this.TAOwnedLabel = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.TACost = new System.Windows.Forms.Label();
            this.PPCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(423, 39);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(43, 20);
            this.moneyLabel.TabIndex = 0;
            this.moneyLabel.Tag = "moneyLabel";
            this.moneyLabel.Text = "Cash:";
            // 
            // PPButton
            // 
            this.PPButton.Location = new System.Drawing.Point(197, 101);
            this.PPButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PPButton.Name = "PPButton";
            this.PPButton.Size = new System.Drawing.Size(104, 31);
            this.PPButton.TabIndex = 1;
            this.PPButton.Tag = "PPButton";
            this.PPButton.Text = "Buy";
            this.PPButton.UseVisualStyleBackColor = true;
            this.PPButton.Click += new System.EventHandler(this.PPButton_Click);
            // 
            // BuyCount
            // 
            this.BuyCount.FormattingEnabled = true;
            this.BuyCount.Items.AddRange(new object[] {
            "1",
            "10",
            "100"});
            this.BuyCount.Location = new System.Drawing.Point(764, 13);
            this.BuyCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BuyCount.Name = "BuyCount";
            this.BuyCount.Size = new System.Drawing.Size(138, 28);
            this.BuyCount.TabIndex = 2;
            this.BuyCount.Tag = "BuyCount";
            this.BuyCount.SelectedIndexChanged += new System.EventHandler(this.BuyCount_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BikiniBottomCashgrab.Properties.Resources.PrettyPatties;
            this.pictureBox1.Location = new System.Drawing.Point(34, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BikiniBottomCashgrab.Properties.Resources.TentacleAcres;
            this.pictureBox2.Location = new System.Drawing.Point(34, 163);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // TAButton
            // 
            this.TAButton.Location = new System.Drawing.Point(197, 224);
            this.TAButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TAButton.Name = "TAButton";
            this.TAButton.Size = new System.Drawing.Size(104, 31);
            this.TAButton.TabIndex = 5;
            this.TAButton.Tag = "TAButton";
            this.TAButton.Text = "Buy";
            this.TAButton.UseVisualStyleBackColor = true;
            this.TAButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // PPOwnedLabel
            // 
            this.PPOwnedLabel.AutoSize = true;
            this.PPOwnedLabel.Location = new System.Drawing.Point(323, 112);
            this.PPOwnedLabel.Name = "PPOwnedLabel";
            this.PPOwnedLabel.Size = new System.Drawing.Size(109, 20);
            this.PPOwnedLabel.TabIndex = 7;
            this.PPOwnedLabel.Tag = "PPOwnedLabel";
            this.PPOwnedLabel.Text = "Pretty Patties: 0";
            // 
            // TAOwnedLabel
            // 
            this.TAOwnedLabel.AutoSize = true;
            this.TAOwnedLabel.Location = new System.Drawing.Point(323, 235);
            this.TAOwnedLabel.Name = "TAOwnedLabel";
            this.TAOwnedLabel.Size = new System.Drawing.Size(119, 20);
            this.TAOwnedLabel.TabIndex = 8;
            this.TAOwnedLabel.Tag = "TAOwnedLabel";
            this.TAOwnedLabel.Text = "Tentacle Acres: 0";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(10, 12);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(19, 576);
            this.vScrollBar1.TabIndex = 9;
            // 
            // TACost
            // 
            this.TACost.AutoSize = true;
            this.TACost.Location = new System.Drawing.Point(570, 235);
            this.TACost.Name = "TACost";
            this.TACost.Size = new System.Drawing.Size(45, 20);
            this.TACost.TabIndex = 11;
            this.TACost.Tag = "TACost";
            this.TACost.Text = "Cost: ";
            // 
            // PPCost
            // 
            this.PPCost.AutoSize = true;
            this.PPCost.Location = new System.Drawing.Point(570, 112);
            this.PPCost.Name = "PPCost";
            this.PPCost.Size = new System.Drawing.Size(45, 20);
            this.PPCost.TabIndex = 12;
            this.PPCost.Tag = "PPCost";
            this.PPCost.Text = "Cost: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.PPCost);
            this.Controls.Add(this.TACost);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.TAOwnedLabel);
            this.Controls.Add(this.PPOwnedLabel);
            this.Controls.Add(this.TAButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BuyCount);
            this.Controls.Add(this.PPButton);
            this.Controls.Add(this.moneyLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label moneyLabel;
        private Button PPButton;
        private ComboBox BuyCount;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button TAButton;
        private Label PPOwnedLabel;
        private Label TAOwnedLabel;
        private VScrollBar vScrollBar1;
        private Label TACost;
        private Label PPCost;
    }
}