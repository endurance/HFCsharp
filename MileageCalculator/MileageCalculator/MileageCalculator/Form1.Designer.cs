namespace MileageCalculator
{
    partial class Form1
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
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Owed = new System.Windows.Forms.Label();
            this.startNumber = new System.Windows.Forms.NumericUpDown();
            this.endNumber = new System.Windows.Forms.NumericUpDown();
            this.calculateButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.startNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(26, 24);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(131, 21);
            this.startLabel.TabIndex = 3;
            this.startLabel.Text = "Starting Mileage";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(26, 61);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(123, 21);
            this.endLabel.TabIndex = 4;
            this.endLabel.Text = "Ending Mileage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Amount Owed";
            // 
            // Owed
            // 
            this.Owed.AutoSize = true;
            this.Owed.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Owed.Location = new System.Drawing.Point(149, 101);
            this.Owed.Name = "Owed";
            this.Owed.Size = new System.Drawing.Size(0, 21);
            this.Owed.TabIndex = 6;
            // 
            // startNumber
            // 
            this.startNumber.CausesValidation = false;
            this.startNumber.Location = new System.Drawing.Point(164, 24);
            this.startNumber.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.startNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startNumber.Name = "startNumber";
            this.startNumber.Size = new System.Drawing.Size(120, 20);
            this.startNumber.TabIndex = 7;
            this.startNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endNumber
            // 
            this.endNumber.Location = new System.Drawing.Point(164, 61);
            this.endNumber.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.endNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endNumber.Name = "endNumber";
            this.endNumber.Size = new System.Drawing.Size(120, 20);
            this.endNumber.TabIndex = 8;
            this.endNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(30, 132);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(208, 131);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 23);
            this.displayButton.TabIndex = 10;
            this.displayButton.Text = "Display Miles";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 167);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.endNumber);
            this.Controls.Add(this.startNumber);
            this.Controls.Add(this.Owed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Owed;
        private System.Windows.Forms.NumericUpDown startNumber;
        private System.Windows.Forms.NumericUpDown endNumber;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button displayButton;
    }
}

