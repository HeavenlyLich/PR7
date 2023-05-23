namespace PR_7
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.termNumberLabel = new System.Windows.Forms.Label();
            this.termNumberTextBox = new System.Windows.Forms.TextBox();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.calculateButton = new System.Windows.Forms.Button();
            this.sumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // termNumberLabel
            // 
            this.termNumberLabel.AutoSize = true;
            this.termNumberLabel.Location = new System.Drawing.Point(12, 15);
            this.termNumberLabel.Name = "termNumberLabel";
            this.termNumberLabel.Size = new System.Drawing.Size(94, 13);
            this.termNumberLabel.TabIndex = 0;
            this.termNumberLabel.Text = "n- член прогресії:";
            // 
            // termNumberTextBox
            // 
            this.termNumberTextBox.Location = new System.Drawing.Point(113, 12);
            this.termNumberTextBox.Name = "termNumberTextBox";
            this.termNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.termNumberTextBox.TabIndex = 1;
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Location = new System.Drawing.Point(241, 12);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.Size = new System.Drawing.Size(260, 200);
            this.resultDataGridView.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(15, 148);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(172, 64);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Починаємо!";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(12, 52);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(36, 13);
            this.sumLabel.TabIndex = 4;
            this.sumLabel.Text = "Сума:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 212);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultDataGridView);
            this.Controls.Add(this.termNumberTextBox);
            this.Controls.Add(this.termNumberLabel);
            this.Name = "Form2";
            this.Text = "Завдання 10";
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label termNumberLabel;
        private System.Windows.Forms.TextBox termNumberTextBox;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label sumLabel;
    }
}
