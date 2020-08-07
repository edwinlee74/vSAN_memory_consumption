using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vsan_mem_consumption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int count = 0;
        private void all_flash_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (all_flash_checkBox.CheckState == CheckState.Checked)
            {
                hybrid_checkBox.CheckState = CheckState.Unchecked;
            }
        }

        private void hybrid_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hybrid_checkBox.CheckState == CheckState.Checked)
            {
                all_flash_checkBox.CheckState = CheckState.Unchecked;
            }
        }

        private void deduplication_enable_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (deduplication_enable_checkBox.CheckState == CheckState.Checked)
            {
                deduplication_disable_checkBox.CheckState = CheckState.Unchecked;
            }
        }

        private void deduplication_disable_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (deduplication_disable_checkBox.CheckState == CheckState.Checked)
            {
                deduplication_enable_checkBox.CheckState = CheckState.Unchecked;
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            int i = 0;
            double j = 0;
            bool cache = Double.TryParse(cache_textBox.Text, out j);
            bool capacity = int.TryParse(capacity_textBox.Text, out i);
            if( !cache || !capacity)
            {
                MessageBox.Show("請在快取層及容量層輸入一個數值");
                return;
            }
           
            if (count < 5)
            {
                int index = this.dataGridView1.Rows.Add();
                count += 1;
                this.dataGridView1.Rows[index].Cells[0].Value = cache_textBox.Text;
                this.dataGridView1.Rows[index].Cells[1].Value = capacity_textBox.Text;
            }
            else
            {
                MessageBox.Show("Disk Group最多5個 ");
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected)
                {
                    dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                    count -= 1;
                }
            }
        }

        private void compute_button_Click(object sender, EventArgs e)
        {
            // 固定消耗成本
            int host_footprint = 7100;
            int capacity_disk_footprint = 0;
            int cache_disk_footprint = 0;
            int diskgroup_fixed_footprint = 0;
            double diskgroup_scalable_footprint = 0;
            double deduplication_add = 0;

            if (deduplication_enable_checkBox.CheckState == CheckState.Checked)
            {
                // 當deduplication打開時每個disk group會多120MB的記憶體成本
                deduplication_add = 120;
            }

            if (all_flash_checkBox.CheckState == CheckState.Checked)
            {
                capacity_disk_footprint = 160;
                cache_disk_footprint = 20;
                diskgroup_fixed_footprint = 1360;
            }
            if (hybrid_checkBox.CheckState == CheckState.Checked)
            {
                capacity_disk_footprint = 180;
                cache_disk_footprint = 10;
                diskgroup_fixed_footprint = 1610;
            }

            if (all_flash_checkBox.CheckState == CheckState.Unchecked & hybrid_checkBox.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("請選擇All flash或是hybrid配置.");
            }
            if (deduplication_enable_checkBox.CheckState == CheckState.Unchecked & deduplication_disable_checkBox.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("請選擇是否已開啟資料重覆功能.");
            }
            if(!string.IsNullOrWhiteSpace(host_mem_textBox.Text))
            {
                double i = 0;
                bool result = Double.TryParse(host_mem_textBox.Text, out i);
                if(result)
                {
                    double host_memory = Double.Parse(host_mem_textBox.Text);
                    diskgroup_scalable_footprint = host_memory * 0.005 * 1024;
                }
            }
            else
            {
                MessageBox.Show("主機記憶體容量請輸入一個數值");
                return;
            }

            double vsan_footprint = 0;
            double disk_group_footprint = 0;
            double compute_result = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string cache_text = row.Cells[0].Value.ToString();
                string capacity_text = row.Cells[1].Value.ToString();
                double cache_size = Double.Parse(cache_text);
                double capacity_num = Double.Parse(capacity_text);

                if(cache_size > 600 & all_flash_checkBox.CheckState == CheckState.Checked)
                {
                    // 當all flash的cache大小超600時, 不會再消耗額外記憶體
                    cache_size = 600;
                }

                if (cache_size > 2000 & hybrid_checkBox.CheckState == CheckState.Checked)
                {
                    // 當all flash的cache大小超600時, 不會再消耗額外記憶體
                    cache_size = 2000;
                }
                compute_result = diskgroup_fixed_footprint + diskgroup_scalable_footprint + (cache_size * cache_disk_footprint) + (capacity_num * capacity_disk_footprint) + deduplication_add;
                disk_group_footprint += compute_result;
            }

            // 此公式請參考VMware KB 2113954(https://kb.vmware.com/s/article/2113954?lang=zh_CN)
            vsan_footprint = host_footprint + disk_group_footprint;
            result_textBox.Text = vsan_footprint.ToString();
        }
    }
}
