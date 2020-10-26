namespace FuelCalculationView
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearList = new System.Windows.Forms.Button();
            this.FindVehicle = new System.Windows.Forms.Button();
            this.AddRandomVehicle = new System.Windows.Forms.Button();
            this.ButtonFuelCost = new System.Windows.Forms.Button();
            this.DeleteVehicle = new System.Windows.Forms.Button();
            this.AddVehicle = new System.Windows.Forms.Button();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ClearList);
            this.groupBox1.Controls.Add(this.FindVehicle);
            this.groupBox1.Controls.Add(this.AddRandomVehicle);
            this.groupBox1.Controls.Add(this.ButtonFuelCost);
            this.groupBox1.Controls.Add(this.DeleteVehicle);
            this.groupBox1.Controls.Add(this.AddVehicle);
            this.groupBox1.Controls.Add(this.dataGridViewMain);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список транспортных средств";
            // 
            // ClearList
            // 
            this.ClearList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClearList.Location = new System.Drawing.Point(203, 239);
            this.ClearList.Name = "ClearList";
            this.ClearList.Size = new System.Drawing.Size(75, 23);
            this.ClearList.TabIndex = 6;
            this.ClearList.Text = "Clear list";
            this.ClearList.UseVisualStyleBackColor = false;
            this.ClearList.Click += new System.EventHandler(this.ClearList_Click);
            // 
            // FindVehicle
            // 
            this.FindVehicle.Location = new System.Drawing.Point(98, 239);
            this.FindVehicle.Name = "FindVehicle";
            this.FindVehicle.Size = new System.Drawing.Size(88, 23);
            this.FindVehicle.TabIndex = 5;
            this.FindVehicle.Text = "Find a vehicle";
            this.FindVehicle.UseVisualStyleBackColor = true;
            this.FindVehicle.Click += new System.EventHandler(this.FindVehicle_Click);
            // 
            // AddRandomVehicle
            // 
            this.AddRandomVehicle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddRandomVehicle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddRandomVehicle.Location = new System.Drawing.Point(7, 233);
            this.AddRandomVehicle.Name = "AddRandomVehicle";
            this.AddRandomVehicle.Size = new System.Drawing.Size(75, 35);
            this.AddRandomVehicle.TabIndex = 4;
            this.AddRandomVehicle.Text = "Add random vehicle";
            this.AddRandomVehicle.UseVisualStyleBackColor = false;
            this.AddRandomVehicle.Click += new System.EventHandler(this.AddRandomVehicle_Click);
            // 
            // ButtonFuelCost
            // 
            this.ButtonFuelCost.Location = new System.Drawing.Point(203, 203);
            this.ButtonFuelCost.Name = "ButtonFuelCost";
            this.ButtonFuelCost.Size = new System.Drawing.Size(75, 23);
            this.ButtonFuelCost.TabIndex = 3;
            this.ButtonFuelCost.Text = "Fuel Cost";
            this.ButtonFuelCost.UseVisualStyleBackColor = true;
            this.ButtonFuelCost.Click += new System.EventHandler(this.ButtonFuelCost_Click);
            // 
            // DeleteVehicle
            // 
            this.DeleteVehicle.Location = new System.Drawing.Point(98, 203);
            this.DeleteVehicle.Name = "DeleteVehicle";
            this.DeleteVehicle.Size = new System.Drawing.Size(88, 23);
            this.DeleteVehicle.TabIndex = 2;
            this.DeleteVehicle.Text = "Delete Vehicle";
            this.DeleteVehicle.UseVisualStyleBackColor = true;
            this.DeleteVehicle.Click += new System.EventHandler(this.DeleteVehicle_Click);
            // 
            // AddVehicle
            // 
            this.AddVehicle.Location = new System.Drawing.Point(6, 203);
            this.AddVehicle.Name = "AddVehicle";
            this.AddVehicle.Size = new System.Drawing.Size(75, 23);
            this.AddVehicle.TabIndex = 1;
            this.AddVehicle.Text = "Add Vehicle";
            this.AddVehicle.UseVisualStyleBackColor = true;
            this.AddVehicle.Click += new System.EventHandler(this.AddVehicle_Click);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewMain.MaximumSize = new System.Drawing.Size(272, 178);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.Size = new System.Drawing.Size(272, 178);
            this.dataGridViewMain.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 307);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button DeleteVehicle;
        private System.Windows.Forms.Button AddVehicle;
        private System.Windows.Forms.Button ButtonFuelCost;
        private System.Windows.Forms.Button AddRandomVehicle;
        private System.Windows.Forms.Button FindVehicle;
        private System.Windows.Forms.Button ClearList;
    }
}

