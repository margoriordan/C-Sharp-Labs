namespace CalculateLetterGrade_WinForm
{
    partial class frmCalculateGrade
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
            txtNumberGrade = new TextBox();
            txtLetterGrade = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtNumberGrade
            // 
            txtNumberGrade.Location = new Point(290, 59);
            txtNumberGrade.Name = "txtNumberGrade";
            txtNumberGrade.Size = new Size(141, 39);
            txtNumberGrade.TabIndex = 1;
            // 
            // txtLetterGrade
            // 
            txtLetterGrade.Location = new Point(290, 128);
            txtLetterGrade.Name = "txtLetterGrade";
            txtLetterGrade.ReadOnly = true;
            txtLetterGrade.Size = new Size(141, 39);
            txtLetterGrade.TabIndex = 1;
            txtLetterGrade.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 59);
            label1.Name = "label1";
            label1.Size = new Size(175, 32);
            label1.TabIndex = 0;
            label1.Text = "&Number grade:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 128);
            label2.Name = "label2";
            label2.Size = new Size(148, 32);
            label2.TabIndex = 3;
            label2.Text = "Letter grade:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(128, 208);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(124, 48);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(307, 208);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(124, 48);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmCalculateGrade
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(547, 314);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLetterGrade);
            Controls.Add(txtNumberGrade);
            Name = "frmCalculateGrade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculate Letter Grade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumberGrade;
        private TextBox txtLetterGrade;
        private Label label1;
        private Label label2;
        private Button btnCalculate;
        private Button btnExit;
    }
}