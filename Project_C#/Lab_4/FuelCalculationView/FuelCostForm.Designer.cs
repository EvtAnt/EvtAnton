namespace FuelCalculationView
{
    partial class FuelCostForm
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
            this.ButtonCalculation = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.textBoxFuelCostText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCalculation
            // 
            this.ButtonCalculation.Location = new System.Drawing.Point(159, 6);
            this.ButtonCalculation.Name = "ButtonCalculation";
            this.ButtonCalculation.Size = new System.Drawing.Size(75, 43);
            this.ButtonCalculation.TabIndex = 0;
            this.ButtonCalculation.Text = "Calculation";
            this.ButtonCalculation.UseVisualStyleBackColor = true;
            this.ButtonCalculation.Click += new System.EventHandler(this.ButtonCalculation_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(159, 53);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 1;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(90, 6);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(63, 20);
            this.textBoxDistance.TabIndex = 3;
            this.textBoxDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDistance_KeyPress);
            // 
            // textBoxFuelCostText
            // 
            this.textBoxFuelCostText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFuelCostText.Location = new System.Drawing.Point(15, 32);
            this.textBoxFuelCostText.Multiline = true;
            this.textBoxFuelCostText.Name = "textBoxFuelCostText";
            this.textBoxFuelCostText.ReadOnly = true;
            this.textBoxFuelCostText.Size = new System.Drawing.Size(138, 44);
            this.textBoxFuelCostText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Distance, km:";
            // 
            // FuelCostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 87);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFuelCostText);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonCalculation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FuelCostForm";
            this.Text = "Fuel cost form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCalculation;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.TextBox textBoxFuelCostText;
        private System.Windows.Forms.Label label1;
    }
}