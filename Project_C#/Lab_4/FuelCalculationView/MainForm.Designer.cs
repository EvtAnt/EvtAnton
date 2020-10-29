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
            this.groupBoxVehiclesList = new System.Windows.Forms.GroupBox();
            this.ButtonDownloadList = new System.Windows.Forms.Button();
            this.ButtonSaveList = new System.Windows.Forms.Button();
            this.ButtonClearList = new System.Windows.Forms.Button();
            this.ButtonFindVehicle = new System.Windows.Forms.Button();
            this.ButtonAddRandomVehicle = new System.Windows.Forms.Button();
            this.ButtonFuelCost = new System.Windows.Forms.Button();
            this.ButtonDeleteVehicle = new System.Windows.Forms.Button();
            this.ButtonAddVehicle = new System.Windows.Forms.Button();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.groupBoxVehiclesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxVehiclesList
            // 
            this.groupBoxVehiclesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxVehiclesList.Controls.Add(this.dataGridViewMain);
            this.groupBoxVehiclesList.Controls.Add(this.ButtonDownloadList);
            this.groupBoxVehiclesList.Controls.Add(this.ButtonSaveList);
            this.groupBoxVehiclesList.Controls.Add(this.ButtonClearList);
            this.groupBoxVehiclesList.Controls.Add(this.ButtonFindVehicle);
            this.groupBoxVehiclesList.Controls.Add(this.ButtonAddRandomVehicle);
            this.groupBoxVehiclesList.Controls.Add(this.ButtonFuelCost);
            this.groupBoxVehiclesList.Controls.Add(this.ButtonDeleteVehicle);
            this.groupBoxVehiclesList.Controls.Add(this.ButtonAddVehicle);
            this.groupBoxVehiclesList.Location = new System.Drawing.Point(12, 12);
            this.groupBoxVehiclesList.Name = "groupBoxVehiclesList";
            this.groupBoxVehiclesList.Size = new System.Drawing.Size(284, 324);
            this.groupBoxVehiclesList.TabIndex = 0;
            this.groupBoxVehiclesList.TabStop = false;
            this.groupBoxVehiclesList.Text = "Список транспортных средств";
            // 
            // ButtonDownloadList
            // 
            this.ButtonDownloadList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonDownloadList.Location = new System.Drawing.Point(6, 274);
            this.ButtonDownloadList.Name = "ButtonDownloadList";
            this.ButtonDownloadList.Size = new System.Drawing.Size(75, 39);
            this.ButtonDownloadList.TabIndex = 8;
            this.ButtonDownloadList.Text = "Load list vehicles";
            this.ButtonDownloadList.UseVisualStyleBackColor = true;
            this.ButtonDownloadList.Click += new System.EventHandler(this.ButtonDownloadList_Click);
            // 
            // ButtonSaveList
            // 
            this.ButtonSaveList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonSaveList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonSaveList.Location = new System.Drawing.Point(203, 203);
            this.ButtonSaveList.Name = "ButtonSaveList";
            this.ButtonSaveList.Size = new System.Drawing.Size(75, 23);
            this.ButtonSaveList.TabIndex = 7;
            this.ButtonSaveList.Text = "Save list";
            this.ButtonSaveList.UseVisualStyleBackColor = false;
            this.ButtonSaveList.Click += new System.EventHandler(this.ButtonSaveList_Click);
            // 
            // ButtonClearList
            // 
            this.ButtonClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonClearList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ButtonClearList.Location = new System.Drawing.Point(203, 239);
            this.ButtonClearList.Name = "ButtonClearList";
            this.ButtonClearList.Size = new System.Drawing.Size(75, 23);
            this.ButtonClearList.TabIndex = 6;
            this.ButtonClearList.Text = "Clear list";
            this.ButtonClearList.UseVisualStyleBackColor = false;
            this.ButtonClearList.Click += new System.EventHandler(this.ButtonClearList_Click);
            // 
            // ButtonFindVehicle
            // 
            this.ButtonFindVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonFindVehicle.Location = new System.Drawing.Point(98, 239);
            this.ButtonFindVehicle.Name = "ButtonFindVehicle";
            this.ButtonFindVehicle.Size = new System.Drawing.Size(88, 23);
            this.ButtonFindVehicle.TabIndex = 5;
            this.ButtonFindVehicle.Text = "Find a vehicle";
            this.ButtonFindVehicle.UseVisualStyleBackColor = true;
            this.ButtonFindVehicle.Click += new System.EventHandler(this.FindVehicle_Click);
            // 
            // ButtonAddRandomVehicle
            // 
            this.ButtonAddRandomVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAddRandomVehicle.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButtonAddRandomVehicle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonAddRandomVehicle.Location = new System.Drawing.Point(98, 274);
            this.ButtonAddRandomVehicle.Name = "ButtonAddRandomVehicle";
            this.ButtonAddRandomVehicle.Size = new System.Drawing.Size(180, 39);
            this.ButtonAddRandomVehicle.TabIndex = 4;
            this.ButtonAddRandomVehicle.Text = "Add random vehicle";
            this.ButtonAddRandomVehicle.UseVisualStyleBackColor = false;
            this.ButtonAddRandomVehicle.Click += new System.EventHandler(this.AddRandomVehicle_Click);
            // 
            // ButtonFuelCost
            // 
            this.ButtonFuelCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonFuelCost.Location = new System.Drawing.Point(6, 239);
            this.ButtonFuelCost.Name = "ButtonFuelCost";
            this.ButtonFuelCost.Size = new System.Drawing.Size(75, 23);
            this.ButtonFuelCost.TabIndex = 3;
            this.ButtonFuelCost.Text = "Fuel cost";
            this.ButtonFuelCost.UseVisualStyleBackColor = true;
            this.ButtonFuelCost.Click += new System.EventHandler(this.ButtonFuelCost_Click);
            // 
            // ButtonDeleteVehicle
            // 
            this.ButtonDeleteVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonDeleteVehicle.Location = new System.Drawing.Point(98, 203);
            this.ButtonDeleteVehicle.Name = "ButtonDeleteVehicle";
            this.ButtonDeleteVehicle.Size = new System.Drawing.Size(88, 23);
            this.ButtonDeleteVehicle.TabIndex = 2;
            this.ButtonDeleteVehicle.Text = "Delete vehicle";
            this.ButtonDeleteVehicle.UseVisualStyleBackColor = true;
            this.ButtonDeleteVehicle.Click += new System.EventHandler(this.DeleteVehicle_Click);
            // 
            // ButtonAddVehicle
            // 
            this.ButtonAddVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAddVehicle.Location = new System.Drawing.Point(6, 203);
            this.ButtonAddVehicle.Name = "ButtonAddVehicle";
            this.ButtonAddVehicle.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddVehicle.TabIndex = 1;
            this.ButtonAddVehicle.Text = "Add vehicle";
            this.ButtonAddVehicle.UseVisualStyleBackColor = true;
            this.ButtonAddVehicle.Click += new System.EventHandler(this.AddVehicle_Click);
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
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMain.Size = new System.Drawing.Size(272, 178);
            this.dataGridViewMain.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 348);
            this.Controls.Add(this.groupBoxVehiclesList);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBoxVehiclesList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVehiclesList;
        private System.Windows.Forms.Button ButtonDeleteVehicle;
        private System.Windows.Forms.Button ButtonAddVehicle;
        private System.Windows.Forms.Button ButtonFuelCost;
        private System.Windows.Forms.Button ButtonAddRandomVehicle;
        private System.Windows.Forms.Button ButtonFindVehicle;
        private System.Windows.Forms.Button ButtonClearList;
        private System.Windows.Forms.Button ButtonSaveList;
        private System.Windows.Forms.Button ButtonDownloadList;
        private System.Windows.Forms.DataGridView dataGridViewMain;
    }
}

