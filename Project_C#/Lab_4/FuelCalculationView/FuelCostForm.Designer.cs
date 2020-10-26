﻿namespace FuelCalculationView
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
            this.TextBoxDistance = new System.Windows.Forms.TextBox();
            this.TextBoxFuelCostText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCalculation
            // 
            this.ButtonCalculation.Location = new System.Drawing.Point(12, 82);
            this.ButtonCalculation.Name = "ButtonCalculation";
            this.ButtonCalculation.Size = new System.Drawing.Size(75, 23);
            this.ButtonCalculation.TabIndex = 0;
            this.ButtonCalculation.Text = "Calculation";
            this.ButtonCalculation.UseVisualStyleBackColor = true;
            this.ButtonCalculation.Click += new System.EventHandler(this.ButtonCalculation_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(113, 82);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 1;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // TextBoxDistance
            // 
            this.TextBoxDistance.Location = new System.Drawing.Point(125, 59);
            this.TextBoxDistance.Name = "TextBoxDistance";
            this.TextBoxDistance.Size = new System.Drawing.Size(63, 20);
            this.TextBoxDistance.TabIndex = 3;
            this.TextBoxDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDistance_KeyPress);
            // 
            // TextBoxFuelCostText
            // 
            this.TextBoxFuelCostText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxFuelCostText.Location = new System.Drawing.Point(12, 12);
            this.TextBoxFuelCostText.Multiline = true;
            this.TextBoxFuelCostText.Name = "TextBoxFuelCostText";
            this.TextBoxFuelCostText.ReadOnly = true;
            this.TextBoxFuelCostText.Size = new System.Drawing.Size(176, 44);
            this.TextBoxFuelCostText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Расстояние, км:";
            // 
            // FuelCostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 111);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxFuelCostText);
            this.Controls.Add(this.TextBoxDistance);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonCalculation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "FuelCostForm";
            this.Text = "FuelCostForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCalculation;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.TextBox TextBoxDistance;
        private System.Windows.Forms.TextBox TextBoxFuelCostText;
        private System.Windows.Forms.Label label1;
    }
}