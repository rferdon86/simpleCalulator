namespace Simple_Calculator
{
    partial class SimpleCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tboOperand1 = new System.Windows.Forms.TextBox();
            this.tboOperator = new System.Windows.Forms.TextBox();
            this.tboOperand2 = new System.Windows.Forms.TextBox();
            this.tboResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operand 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operator:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operand 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Result:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(20, 187);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 28);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(149, 187);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tboOperand1
            // 
            this.tboOperand1.Location = new System.Drawing.Point(116, 27);
            this.tboOperand1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboOperand1.Name = "tboOperand1";
            this.tboOperand1.Size = new System.Drawing.Size(132, 22);
            this.tboOperand1.TabIndex = 6;
            this.tboOperand1.TextChanged += new System.EventHandler(this.ClearResult);
            // 
            // tboOperator
            // 
            this.tboOperator.Location = new System.Drawing.Point(116, 60);
            this.tboOperator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboOperator.Name = "tboOperator";
            this.tboOperator.Size = new System.Drawing.Size(132, 22);
            this.tboOperator.TabIndex = 7;
            this.tboOperator.TextChanged += new System.EventHandler(this.ClearResult);
            // 
            // tboOperand2
            // 
            this.tboOperand2.Location = new System.Drawing.Point(116, 94);
            this.tboOperand2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboOperand2.Name = "tboOperand2";
            this.tboOperand2.Size = new System.Drawing.Size(132, 22);
            this.tboOperand2.TabIndex = 8;
            this.tboOperand2.TextChanged += new System.EventHandler(this.ClearResult);
            // 
            // tboResult
            // 
            this.tboResult.BackColor = System.Drawing.SystemColors.Menu;
            this.tboResult.Location = new System.Drawing.Point(116, 127);
            this.tboResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboResult.Name = "tboResult";
            this.tboResult.ReadOnly = true;
            this.tboResult.Size = new System.Drawing.Size(132, 22);
            this.tboResult.TabIndex = 9;
            // 
            // SimpleCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(296, 250);
            this.Controls.Add(this.tboResult);
            this.Controls.Add(this.tboOperand2);
            this.Controls.Add(this.tboOperator);
            this.Controls.Add(this.tboOperand1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SimpleCalculator";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tboOperand1;
        private System.Windows.Forms.TextBox tboOperator;
        private System.Windows.Forms.TextBox tboOperand2;
        private System.Windows.Forms.TextBox tboResult;
    }
}

