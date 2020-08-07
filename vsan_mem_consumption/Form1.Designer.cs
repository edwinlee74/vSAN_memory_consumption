namespace vsan_mem_consumption
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vsan_config_label = new System.Windows.Forms.Label();
            this.all_flash_checkBox = new System.Windows.Forms.CheckBox();
            this.hybrid_checkBox = new System.Windows.Forms.CheckBox();
            this.deduplication_label = new System.Windows.Forms.Label();
            this.deduplication_enable_checkBox = new System.Windows.Forms.CheckBox();
            this.deduplication_disable_checkBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.host_mem_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cache_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity_disks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cache_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.capacity_label = new System.Windows.Forms.Label();
            this.cache_textBox = new System.Windows.Forms.TextBox();
            this.capacity_textBox = new System.Windows.Forms.TextBox();
            this.consumption_label = new System.Windows.Forms.Label();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.compute_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vsan_config_label
            // 
            this.vsan_config_label.AutoSize = true;
            this.vsan_config_label.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.vsan_config_label.Location = new System.Drawing.Point(12, 36);
            this.vsan_config_label.Name = "vsan_config_label";
            this.vsan_config_label.Size = new System.Drawing.Size(227, 32);
            this.vsan_config_label.TabIndex = 1;
            this.vsan_config_label.Text = "vSAN 配置種類";
            // 
            // all_flash_checkBox
            // 
            this.all_flash_checkBox.AutoSize = true;
            this.all_flash_checkBox.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.all_flash_checkBox.Location = new System.Drawing.Point(245, 36);
            this.all_flash_checkBox.Name = "all_flash_checkBox";
            this.all_flash_checkBox.Size = new System.Drawing.Size(135, 32);
            this.all_flash_checkBox.TabIndex = 2;
            this.all_flash_checkBox.Text = "All Flash";
            this.all_flash_checkBox.UseVisualStyleBackColor = true;
            this.all_flash_checkBox.CheckedChanged += new System.EventHandler(this.all_flash_checkBox_CheckedChanged);
            // 
            // hybrid_checkBox
            // 
            this.hybrid_checkBox.AutoSize = true;
            this.hybrid_checkBox.Checked = true;
            this.hybrid_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hybrid_checkBox.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hybrid_checkBox.Location = new System.Drawing.Point(386, 36);
            this.hybrid_checkBox.Name = "hybrid_checkBox";
            this.hybrid_checkBox.Size = new System.Drawing.Size(112, 32);
            this.hybrid_checkBox.TabIndex = 3;
            this.hybrid_checkBox.Text = "Hybrid";
            this.hybrid_checkBox.UseVisualStyleBackColor = true;
            this.hybrid_checkBox.CheckedChanged += new System.EventHandler(this.hybrid_checkBox_CheckedChanged);
            // 
            // deduplication_label
            // 
            this.deduplication_label.AutoSize = true;
            this.deduplication_label.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deduplication_label.Location = new System.Drawing.Point(18, 104);
            this.deduplication_label.Name = "deduplication_label";
            this.deduplication_label.Size = new System.Drawing.Size(332, 32);
            this.deduplication_label.TabIndex = 4;
            this.deduplication_label.Text = "vSAN deduplication 功能";
            // 
            // deduplication_enable_checkBox
            // 
            this.deduplication_enable_checkBox.AutoSize = true;
            this.deduplication_enable_checkBox.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deduplication_enable_checkBox.Location = new System.Drawing.Point(356, 107);
            this.deduplication_enable_checkBox.Name = "deduplication_enable_checkBox";
            this.deduplication_enable_checkBox.Size = new System.Drawing.Size(111, 32);
            this.deduplication_enable_checkBox.TabIndex = 5;
            this.deduplication_enable_checkBox.Text = "Enable";
            this.deduplication_enable_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.deduplication_enable_checkBox, resources.GetString("deduplication_enable_checkBox.ToolTip"));
            this.deduplication_enable_checkBox.UseVisualStyleBackColor = true;
            this.deduplication_enable_checkBox.CheckedChanged += new System.EventHandler(this.deduplication_enable_checkBox_CheckedChanged);
            // 
            // deduplication_disable_checkBox
            // 
            this.deduplication_disable_checkBox.AutoSize = true;
            this.deduplication_disable_checkBox.Checked = true;
            this.deduplication_disable_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deduplication_disable_checkBox.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deduplication_disable_checkBox.Location = new System.Drawing.Point(473, 107);
            this.deduplication_disable_checkBox.Name = "deduplication_disable_checkBox";
            this.deduplication_disable_checkBox.Size = new System.Drawing.Size(118, 32);
            this.deduplication_disable_checkBox.TabIndex = 6;
            this.deduplication_disable_checkBox.Text = "Disable";
            this.toolTip1.SetToolTip(this.deduplication_disable_checkBox, resources.GetString("deduplication_disable_checkBox.ToolTip"));
            this.deduplication_disable_checkBox.UseVisualStyleBackColor = true;
            this.deduplication_disable_checkBox.CheckedChanged += new System.EventHandler(this.deduplication_disable_checkBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(18, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "ESXI 主機記憶體容量(GB)";
            // 
            // host_mem_textBox
            // 
            this.host_mem_textBox.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.host_mem_textBox.Location = new System.Drawing.Point(419, 157);
            this.host_mem_textBox.Name = "host_mem_textBox";
            this.host_mem_textBox.Size = new System.Drawing.Size(119, 41);
            this.host_mem_textBox.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cache_size,
            this.capacity_disks});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(284, 102);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(659, 322);
            this.dataGridView1.TabIndex = 9;
            // 
            // cache_size
            // 
            this.cache_size.Frozen = true;
            this.cache_size.HeaderText = "Cache Size";
            this.cache_size.MinimumWidth = 8;
            this.cache_size.Name = "cache_size";
            this.cache_size.ReadOnly = true;
            this.cache_size.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cache_size.Width = 150;
            // 
            // capacity_disks
            // 
            this.capacity_disks.Frozen = true;
            this.capacity_disks.HeaderText = "Capacity Disks";
            this.capacity_disks.MinimumWidth = 8;
            this.capacity_disks.Name = "capacity_disks";
            this.capacity_disks.ReadOnly = true;
            this.capacity_disks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.capacity_disks.Width = 150;
            // 
            // cache_label
            // 
            this.cache_label.AutoSize = true;
            this.cache_label.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cache_label.Location = new System.Drawing.Point(239, 33);
            this.cache_label.Name = "cache_label";
            this.cache_label.Size = new System.Drawing.Size(237, 32);
            this.cache_label.TabIndex = 10;
            this.cache_label.Text = "快取層容量(GB)";
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.add_button.Location = new System.Drawing.Point(12, 69);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(144, 46);
            this.add_button.TabIndex = 11;
            this.add_button.Text = "新增";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // capacity_label
            // 
            this.capacity_label.AutoSize = true;
            this.capacity_label.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.capacity_label.Location = new System.Drawing.Point(624, 33);
            this.capacity_label.Name = "capacity_label";
            this.capacity_label.Size = new System.Drawing.Size(239, 32);
            this.capacity_label.TabIndex = 12;
            this.capacity_label.Text = "容量層硬碟數量";
            // 
            // cache_textBox
            // 
            this.cache_textBox.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cache_textBox.Location = new System.Drawing.Point(491, 24);
            this.cache_textBox.Name = "cache_textBox";
            this.cache_textBox.Size = new System.Drawing.Size(127, 41);
            this.cache_textBox.TabIndex = 13;
            // 
            // capacity_textBox
            // 
            this.capacity_textBox.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.capacity_textBox.Location = new System.Drawing.Point(869, 24);
            this.capacity_textBox.Name = "capacity_textBox";
            this.capacity_textBox.Size = new System.Drawing.Size(130, 41);
            this.capacity_textBox.TabIndex = 14;
            // 
            // consumption_label
            // 
            this.consumption_label.AutoSize = true;
            this.consumption_label.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.consumption_label.ForeColor = System.Drawing.Color.Red;
            this.consumption_label.Location = new System.Drawing.Point(875, 50);
            this.consumption_label.Name = "consumption_label";
            this.consumption_label.Size = new System.Drawing.Size(397, 32);
            this.consumption_label.TabIndex = 15;
            this.consumption_label.Text = "每台ESXI記憶體耗用(MB):";
            // 
            // result_textBox
            // 
            this.result_textBox.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.result_textBox.Location = new System.Drawing.Point(881, 104);
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.ReadOnly = true;
            this.result_textBox.Size = new System.Drawing.Size(403, 41);
            this.result_textBox.TabIndex = 16;
            // 
            // compute_button
            // 
            this.compute_button.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.compute_button.Location = new System.Drawing.Point(676, 36);
            this.compute_button.Name = "compute_button";
            this.compute_button.Size = new System.Drawing.Size(171, 46);
            this.compute_button.TabIndex = 17;
            this.compute_button.Text = "開始估算";
            this.compute_button.UseVisualStyleBackColor = true;
            this.compute_button.Click += new System.EventHandler(this.compute_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.delete_button.Location = new System.Drawing.Point(12, 157);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(144, 46);
            this.delete_button.TabIndex = 18;
            this.delete_button.Text = "刪除";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.delete_button);
            this.groupBox1.Controls.Add(this.add_button);
            this.groupBox1.Controls.Add(this.cache_label);
            this.groupBox1.Controls.Add(this.capacity_textBox);
            this.groupBox1.Controls.Add(this.cache_textBox);
            this.groupBox1.Controls.Add(this.capacity_label);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1263, 443);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Disk Group";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 8000;
            this.toolTip1.InitialDelay = 1000;
            this.toolTip1.ReshowDelay = 500;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "vSAN deduplication feature";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1308, 751);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.compute_button);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.consumption_label);
            this.Controls.Add(this.host_mem_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deduplication_disable_checkBox);
            this.Controls.Add(this.deduplication_enable_checkBox);
            this.Controls.Add(this.deduplication_label);
            this.Controls.Add(this.hybrid_checkBox);
            this.Controls.Add(this.all_flash_checkBox);
            this.Controls.Add(this.vsan_config_label);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "vSAN記憶體耗用估算";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label vsan_config_label;
        private System.Windows.Forms.CheckBox all_flash_checkBox;
        private System.Windows.Forms.CheckBox hybrid_checkBox;
        private System.Windows.Forms.Label deduplication_label;
        private System.Windows.Forms.CheckBox deduplication_enable_checkBox;
        private System.Windows.Forms.CheckBox deduplication_disable_checkBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox host_mem_textBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label cache_label;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label capacity_label;
        private System.Windows.Forms.TextBox cache_textBox;
        private System.Windows.Forms.TextBox capacity_textBox;
        private System.Windows.Forms.Label consumption_label;
        private System.Windows.Forms.TextBox result_textBox;
        private System.Windows.Forms.Button compute_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn cache_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity_disks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

