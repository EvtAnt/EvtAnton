namespace FuelCalculationView
{
    partial class FindVehicleForm
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
            this.dataGridViewFoundVehicles = new System.Windows.Forms.DataGridView();
            this.comboBoxTypeVehicles = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxTypeVehicle = new System.Windows.Forms.CheckBox();
            this.textBoxVehiclesName = new System.Windows.Forms.TextBox();
            this.textBoxVehicleWeight = new System.Windows.Forms.TextBox();
            this.checkBoxNameVehicle = new System.Windows.Forms.CheckBox();
            this.checkBoxWeightVehicle = new System.Windows.Forms.CheckBox();
            this.ButtonCloseFindVehicleForm = new System.Windows.Forms.Button();
            this.ButtonSearchVehicles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoundVehicles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFoundVehicles
            // 
            this.dataGridViewFoundVehicles.AllowUserToAddRows = false;
            this.dataGridViewFoundVehicles.AllowUserToDeleteRows = false;
            this.dataGridViewFoundVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFoundVehicles.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewFoundVehicles.Name = "dataGridViewFoundVehicles";
            this.dataGridViewFoundVehicles.ReadOnly = true;
            this.dataGridViewFoundVehicles.Size = new System.Drawing.Size(275, 150);
            this.dataGridViewFoundVehicles.TabIndex = 0;
            // 
            // comboBoxTypeVehicles
            // 
            this.comboBoxTypeVehicles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeVehicles.FormattingEnabled = true;
            this.comboBoxTypeVehicles.Location = new System.Drawing.Point(71, 21);
            this.comboBoxTypeVehicles.Name = "comboBoxTypeVehicles";
            this.comboBoxTypeVehicles.Size = new System.Drawing.Size(80, 21);
            this.comboBoxTypeVehicles.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ButtonCloseFindVehicleForm);
            this.groupBox1.Controls.Add(this.ButtonSearchVehicles);
            this.groupBox1.Controls.Add(this.dataGridViewFoundVehicles);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 306);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Наеденные транспортные средства";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxTypeVehicles);
            this.groupBox2.Controls.Add(this.checkBoxTypeVehicle);
            this.groupBox2.Controls.Add(this.textBoxVehiclesName);
            this.groupBox2.Controls.Add(this.textBoxVehicleWeight);
            this.groupBox2.Controls.Add(this.checkBoxNameVehicle);
            this.groupBox2.Controls.Add(this.checkBoxWeightVehicle);
            this.groupBox2.Location = new System.Drawing.Point(6, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 119);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры поиска";
            // 
            // checkBoxTypeVehicle
            // 
            this.checkBoxTypeVehicle.AutoSize = true;
            this.checkBoxTypeVehicle.Location = new System.Drawing.Point(6, 25);
            this.checkBoxTypeVehicle.Name = "checkBoxTypeVehicle";
            this.checkBoxTypeVehicle.Size = new System.Drawing.Size(65, 17);
            this.checkBoxTypeVehicle.TabIndex = 9;
            this.checkBoxTypeVehicle.Text = "Тип ТС:";
            this.checkBoxTypeVehicle.UseVisualStyleBackColor = true;
            // 
            // textBoxVehiclesName
            // 
            this.textBoxVehiclesName.Location = new System.Drawing.Point(71, 54);
            this.textBoxVehiclesName.Name = "textBoxVehiclesName";
            this.textBoxVehiclesName.Size = new System.Drawing.Size(80, 20);
            this.textBoxVehiclesName.TabIndex = 4;
            // 
            // textBoxVehicleWeight
            // 
            this.textBoxVehicleWeight.Location = new System.Drawing.Point(101, 86);
            this.textBoxVehicleWeight.Name = "textBoxVehicleWeight";
            this.textBoxVehicleWeight.Size = new System.Drawing.Size(50, 20);
            this.textBoxVehicleWeight.TabIndex = 6;
            this.textBoxVehicleWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxVehicleWeight_KeyPress);
            // 
            // checkBoxNameVehicle
            // 
            this.checkBoxNameVehicle.AutoSize = true;
            this.checkBoxNameVehicle.Location = new System.Drawing.Point(6, 57);
            this.checkBoxNameVehicle.Name = "checkBoxNameVehicle";
            this.checkBoxNameVehicle.Size = new System.Drawing.Size(68, 17);
            this.checkBoxNameVehicle.TabIndex = 11;
            this.checkBoxNameVehicle.Text = "Имя ТС:";
            this.checkBoxNameVehicle.UseVisualStyleBackColor = true;
            // 
            // checkBoxWeightVehicle
            // 
            this.checkBoxWeightVehicle.AutoSize = true;
            this.checkBoxWeightVehicle.Location = new System.Drawing.Point(6, 89);
            this.checkBoxWeightVehicle.Name = "checkBoxWeightVehicle";
            this.checkBoxWeightVehicle.Size = new System.Drawing.Size(96, 17);
            this.checkBoxWeightVehicle.TabIndex = 10;
            this.checkBoxWeightVehicle.Text = "Масса ТС, кг:";
            this.checkBoxWeightVehicle.UseVisualStyleBackColor = true;
            // 
            // ButtonCloseFindVehicleForm
            // 
            this.ButtonCloseFindVehicleForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonCloseFindVehicleForm.Location = new System.Drawing.Point(199, 245);
            this.ButtonCloseFindVehicleForm.Name = "ButtonCloseFindVehicleForm";
            this.ButtonCloseFindVehicleForm.Size = new System.Drawing.Size(62, 23);
            this.ButtonCloseFindVehicleForm.TabIndex = 8;
            this.ButtonCloseFindVehicleForm.Text = "Close";
            this.ButtonCloseFindVehicleForm.UseVisualStyleBackColor = false;
            this.ButtonCloseFindVehicleForm.Click += new System.EventHandler(this.ButtonCloseFindVehicleForm_Click);
            // 
            // ButtonSearchVehicles
            // 
            this.ButtonSearchVehicles.Location = new System.Drawing.Point(178, 200);
            this.ButtonSearchVehicles.Name = "ButtonSearchVehicles";
            this.ButtonSearchVehicles.Size = new System.Drawing.Size(103, 23);
            this.ButtonSearchVehicles.TabIndex = 7;
            this.ButtonSearchVehicles.Text = "Search vehicles";
            this.ButtonSearchVehicles.UseVisualStyleBackColor = true;
            this.ButtonSearchVehicles.Click += new System.EventHandler(this.ButtonSearchVehicles_Click);
            // 
            // FindVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 331);
            this.Controls.Add(this.groupBox1);
            this.Name = "FindVehicleForm";
            this.Text = "FindVehicleForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoundVehicles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFoundVehicles;
        private System.Windows.Forms.ComboBox comboBoxTypeVehicles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxVehicleWeight;
        private System.Windows.Forms.TextBox textBoxVehiclesName;
        private System.Windows.Forms.Button ButtonSearchVehicles;
        private System.Windows.Forms.Button ButtonCloseFindVehicleForm;
        private System.Windows.Forms.CheckBox checkBoxTypeVehicle;
        private System.Windows.Forms.CheckBox checkBoxWeightVehicle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxNameVehicle;
    }
}