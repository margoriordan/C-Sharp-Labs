namespace Exercise_1_WinForm
{
    partial class MargoFloorCostEstimator
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
            btnExit = new Button();
            btnCalc = new Button();
            floorLength = new Label();
            floorWidth = new Label();
            costSqFt = new Label();
            separator = new Label();
            label1 = new Label();
            inputFloorLength = new TextBox();
            inputFloorWidth = new TextBox();
            inputCostSqFt = new TextBox();
            floorCostResult = new Label();
            txtFloorArea = new TextBox();
            txtAreaCost = new TextBox();
            descriptor = new Label();
            label2 = new Label();
            txtNumHours = new TextBox();
            descriptor2 = new Label();
            txtInstallCost = new TextBox();
            grandTotal = new Label();
            txtGrandTotal = new TextBox();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(826, 634);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(181, 52);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button1_Click;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(35, 634);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(181, 52);
            btnCalc.TabIndex = 1;
            btnCalc.Text = "Calculate Cost";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // floorLength
            // 
            floorLength.AutoSize = true;
            floorLength.Location = new Point(94, 67);
            floorLength.Name = "floorLength";
            floorLength.Size = new Size(179, 32);
            floorLength.TabIndex = 2;
            floorLength.Text = "Length of floor:";
            // 
            // floorWidth
            // 
            floorWidth.AutoSize = true;
            floorWidth.Location = new Point(94, 154);
            floorWidth.Name = "floorWidth";
            floorWidth.Size = new Size(169, 32);
            floorWidth.TabIndex = 3;
            floorWidth.Text = "Width of floor:";
            floorWidth.Click += label1_Click;
            // 
            // costSqFt
            // 
            costSqFt.AutoSize = true;
            costSqFt.Location = new Point(94, 236);
            costSqFt.Name = "costSqFt";
            costSqFt.Size = new Size(237, 32);
            costSqFt.TabIndex = 4;
            costSqFt.Text = "Cost per square foot:";
            // 
            // separator
            // 
            separator.AutoSize = true;
            separator.Location = new Point(94, 311);
            separator.Name = "separator";
            separator.Size = new Size(244, 32);
            separator.TabIndex = 5;
            separator.Text = "-----------------------";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 391);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 6;
            // 
            // inputFloorLength
            // 
            inputFloorLength.Location = new Point(299, 67);
            inputFloorLength.Name = "inputFloorLength";
            inputFloorLength.Size = new Size(252, 39);
            inputFloorLength.TabIndex = 7;
            inputFloorLength.TextChanged += inputFloorLength_TextChanged;
            // 
            // inputFloorWidth
            // 
            inputFloorWidth.Location = new Point(299, 147);
            inputFloorWidth.Name = "inputFloorWidth";
            inputFloorWidth.Size = new Size(252, 39);
            inputFloorWidth.TabIndex = 8;
            // 
            // inputCostSqFt
            // 
            inputCostSqFt.Location = new Point(390, 236);
            inputCostSqFt.Name = "inputCostSqFt";
            inputCostSqFt.Size = new Size(252, 39);
            inputCostSqFt.TabIndex = 9;
            // 
            // floorCostResult
            // 
            floorCostResult.AutoSize = true;
            floorCostResult.Location = new Point(94, 391);
            floorCostResult.Name = "floorCostResult";
            floorCostResult.Size = new Size(278, 32);
            floorCostResult.TabIndex = 10;
            floorCostResult.Text = "Cost of total floor size of";
            // 
            // txtFloorArea
            // 
            txtFloorArea.Location = new Point(386, 387);
            txtFloorArea.Name = "txtFloorArea";
            txtFloorArea.ReadOnly = true;
            txtFloorArea.Size = new Size(196, 39);
            txtFloorArea.TabIndex = 11;
            // 
            // txtAreaCost
            // 
            txtAreaCost.Location = new Point(742, 387);
            txtAreaCost.Name = "txtAreaCost";
            txtAreaCost.ReadOnly = true;
            txtAreaCost.Size = new Size(252, 39);
            txtAreaCost.TabIndex = 12;
            // 
            // descriptor
            // 
            descriptor.AutoSize = true;
            descriptor.Location = new Point(590, 391);
            descriptor.Name = "descriptor";
            descriptor.Size = new Size(139, 32);
            descriptor.TabIndex = 13;
            descriptor.Text = "square feet:";
            descriptor.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 469);
            label2.Name = "label2";
            label2.Size = new Size(418, 32);
            label2.TabIndex = 14;
            label2.Text = "Number of hours to install the floor is";
            // 
            // txtNumHours
            // 
            txtNumHours.Location = new Point(532, 467);
            txtNumHours.Name = "txtNumHours";
            txtNumHours.ReadOnly = true;
            txtNumHours.Size = new Size(122, 39);
            txtNumHours.TabIndex = 15;
            // 
            // descriptor2
            // 
            descriptor2.AutoSize = true;
            descriptor2.Location = new Point(675, 469);
            descriptor2.Name = "descriptor2";
            descriptor2.Size = new Size(132, 32);
            descriptor2.TabIndex = 16;
            descriptor2.Text = "at a cost of";
            // 
            // txtInstallCost
            // 
            txtInstallCost.Location = new Point(819, 470);
            txtInstallCost.Name = "txtInstallCost";
            txtInstallCost.ReadOnly = true;
            txtInstallCost.Size = new Size(175, 39);
            txtInstallCost.TabIndex = 17;
            // 
            // grandTotal
            // 
            grandTotal.AutoSize = true;
            grandTotal.Location = new Point(247, 547);
            grandTotal.Name = "grandTotal";
            grandTotal.Size = new Size(466, 32);
            grandTotal.TabIndex = 18;
            grandTotal.Text = "The total finished cost for the new floor is:";
            // 
            // txtGrandTotal
            // 
            txtGrandTotal.Location = new Point(742, 547);
            txtGrandTotal.Name = "txtGrandTotal";
            txtGrandTotal.ReadOnly = true;
            txtGrandTotal.Size = new Size(252, 39);
            txtGrandTotal.TabIndex = 19;
            // 
            // MargoFloorCostEstimator
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(1043, 719);
            Controls.Add(txtGrandTotal);
            Controls.Add(grandTotal);
            Controls.Add(txtInstallCost);
            Controls.Add(descriptor2);
            Controls.Add(txtNumHours);
            Controls.Add(label2);
            Controls.Add(descriptor);
            Controls.Add(txtAreaCost);
            Controls.Add(txtFloorArea);
            Controls.Add(floorCostResult);
            Controls.Add(inputCostSqFt);
            Controls.Add(inputFloorWidth);
            Controls.Add(inputFloorLength);
            Controls.Add(label1);
            Controls.Add(separator);
            Controls.Add(costSqFt);
            Controls.Add(floorWidth);
            Controls.Add(floorLength);
            Controls.Add(btnCalc);
            Controls.Add(btnExit);
            Name = "MargoFloorCostEstimator";
            Text = "Margo Flooring Cost Estimator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnCalc;
        private Label floorLength;
        private Label floorWidth;
        private Label costSqFt;
        private Label separator;
        private Label label1;
        private TextBox inputFloorLength;
        private TextBox inputFloorWidth;
        private TextBox inputCostSqFt;
        private Label floorCostResult;
        private TextBox txtFloorArea;
        private TextBox txtAreaCost;
        private Label descriptor;
        private Label label2;
        private TextBox txtNumHours;
        private Label descriptor2;
        private TextBox txtInstallCost;
        private Label grandTotal;
        private TextBox txtGrandTotal;
    }
}