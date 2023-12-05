namespace Exercise_7c
{
    partial class StudentRec
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.studentIDtxt = new System.Windows.Forms.TextBox();
            this.majorTxt = new System.Windows.Forms.TextBox();
            this.dobTxt = new System.Windows.Forms.TextBox();
            this.lastTxt = new System.Windows.Forms.TextBox();
            this.firstTxt = new System.Windows.Forms.TextBox();
            this.findStudBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.displayBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Major:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "DOB:";
            // 
            // studentIDtxt
            // 
            this.studentIDtxt.Location = new System.Drawing.Point(21, 44);
            this.studentIDtxt.Name = "studentIDtxt";
            this.studentIDtxt.Size = new System.Drawing.Size(139, 23);
            this.studentIDtxt.TabIndex = 5;
            // 
            // majorTxt
            // 
            this.majorTxt.Location = new System.Drawing.Point(437, 98);
            this.majorTxt.Name = "majorTxt";
            this.majorTxt.Size = new System.Drawing.Size(243, 23);
            this.majorTxt.TabIndex = 6;
            // 
            // dobTxt
            // 
            this.dobTxt.Location = new System.Drawing.Point(192, 98);
            this.dobTxt.Name = "dobTxt";
            this.dobTxt.Size = new System.Drawing.Size(217, 23);
            this.dobTxt.TabIndex = 7;
            // 
            // lastTxt
            // 
            this.lastTxt.Location = new System.Drawing.Point(437, 44);
            this.lastTxt.Name = "lastTxt";
            this.lastTxt.Size = new System.Drawing.Size(243, 23);
            this.lastTxt.TabIndex = 8;
            // 
            // firstTxt
            // 
            this.firstTxt.Location = new System.Drawing.Point(192, 44);
            this.firstTxt.Name = "firstTxt";
            this.firstTxt.Size = new System.Drawing.Size(217, 23);
            this.firstTxt.TabIndex = 9;
            // 
            // findStudBtn
            // 
            this.findStudBtn.Location = new System.Drawing.Point(21, 98);
            this.findStudBtn.Name = "findStudBtn";
            this.findStudBtn.Size = new System.Drawing.Size(139, 23);
            this.findStudBtn.TabIndex = 10;
            this.findStudBtn.Text = "Find Student";
            this.findStudBtn.UseVisualStyleBackColor = true;
            this.findStudBtn.Click += new System.EventHandler(this.findStudBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(62, 149);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(89, 23);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(222, 149);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(89, 23);
            this.modifyBtn.TabIndex = 12;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(382, 149);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(89, 23);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(542, 149);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(89, 23);
            this.displayBtn.TabIndex = 14;
            this.displayBtn.Text = "Display All";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(591, 409);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(89, 23);
            this.clearBtn.TabIndex = 15;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(21, 409);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(89, 23);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(21, 200);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(659, 185);
            this.dataGridView.TabIndex = 17;
            // 
            // StudentRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.findStudBtn);
            this.Controls.Add(this.firstTxt);
            this.Controls.Add(this.lastTxt);
            this.Controls.Add(this.dobTxt);
            this.Controls.Add(this.majorTxt);
            this.Controls.Add(this.studentIDtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentRec";
            this.Text = "Student Records";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox studentIDtxt;
        private TextBox majorTxt;
        private TextBox dobTxt;
        private TextBox lastTxt;
        private TextBox firstTxt;
        private Button findStudBtn;
        private Button addBtn;
        private Button modifyBtn;
        private Button deleteBtn;
        private Button displayBtn;
        private Button clearBtn;
        private Button exitBtn;
        private DataGridView dataGridView;
    }
}