namespace FuelCalculationView
{
    partial class AddVehicleForm
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
            this.comboBoxTypesOfVehicle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNamesOfVehicle = new System.Windows.Forms.TextBox();
            this.textBoxWeightOfVehicle = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTypesOfVehicle
            // 
            this.comboBoxTypesOfVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypesOfVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTypesOfVehicle.FormattingEnabled = true;
            this.comboBoxTypesOfVehicle.Location = new System.Drawing.Point(57, 13);
            this.comboBoxTypesOfVehicle.Name = "comboBoxTypesOfVehicle";
            this.comboBoxTypesOfVehicle.Size = new System.Drawing.Size(92, 21);
            this.comboBoxTypesOfVehicle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Weight, kg:";
            // 
            // textBoxNamesOfVehicle
            // 
            this.textBoxNamesOfVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNamesOfVehicle.Location = new System.Drawing.Point(57, 49);
            this.textBoxNamesOfVehicle.Name = "textBoxNamesOfVehicle";
            this.textBoxNamesOfVehicle.Size = new System.Drawing.Size(92, 20);
            this.textBoxNamesOfVehicle.TabIndex = 4;
            // 
            // textBoxWeightOfVehicle
            // 
            this.textBoxWeightOfVehicle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxWeightOfVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWeightOfVehicle.Location = new System.Drawing.Point(81, 86);
            this.textBoxWeightOfVehicle.MaxLength = 8;
            this.textBoxWeightOfVehicle.Name = "textBoxWeightOfVehicle";
            this.textBoxWeightOfVehicle.Size = new System.Drawing.Size(68, 20);
            this.textBoxWeightOfVehicle.TabIndex = 5;
            this.textBoxWeightOfVehicle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VehicleWeight_KeyPress);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(12, 122);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(63, 23);
            this.OK.TabIndex = 6;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(81, 122);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(68, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 155);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.textBoxWeightOfVehicle);
            this.Controls.Add(this.textBoxNamesOfVehicle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTypesOfVehicle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddVehicleForm";
            this.Text = "AVF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTypesOfVehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNamesOfVehicle;
        private System.Windows.Forms.TextBox textBoxWeightOfVehicle;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
    }
}