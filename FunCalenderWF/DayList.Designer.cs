namespace FunCalenderWF
{
    partial class DayList
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.day = new System.Windows.Forms.Label();
            this.prev = new System.Windows.Forms.Button();
            this.AccountsPage = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.WishListPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.AccountsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.WishListPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MainTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.day.Location = new System.Drawing.Point(221, 68);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(26, 27);
            this.day.TabIndex = 0;
            this.day.Text = "0";
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(18, 18);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(63, 48);
            this.prev.TabIndex = 1;
            this.prev.Text = "prev";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // AccountsPage
            // 
            this.AccountsPage.Controls.Add(this.dataGridView2);
            this.AccountsPage.Location = new System.Drawing.Point(4, 22);
            this.AccountsPage.Name = "AccountsPage";
            this.AccountsPage.Padding = new System.Windows.Forms.Padding(3);
            this.AccountsPage.Size = new System.Drawing.Size(586, 473);
            this.AccountsPage.TabIndex = 1;
            this.AccountsPage.Text = "Accounts";
            this.AccountsPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 21;
            this.dataGridView2.Size = new System.Drawing.Size(586, 473);
            this.dataGridView2.TabIndex = 0;
            // 
            // WishListPage
            // 
            this.WishListPage.Controls.Add(this.dataGridView1);
            this.WishListPage.Location = new System.Drawing.Point(4, 22);
            this.WishListPage.Name = "WishListPage";
            this.WishListPage.Padding = new System.Windows.Forms.Padding(3);
            this.WishListPage.Size = new System.Drawing.Size(586, 473);
            this.WishListPage.TabIndex = 0;
            this.WishListPage.Text = "WishList";
            this.WishListPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(585, 476);
            this.dataGridView1.TabIndex = 0;
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.WishListPage);
            this.MainTab.Controls.Add(this.AccountsPage);
            this.MainTab.Location = new System.Drawing.Point(3, 98);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(594, 499);
            this.MainTab.TabIndex = 2;
            // 
            // DayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainTab);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.day);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "DayList";
            this.Size = new System.Drawing.Size(600, 600);
            this.Load += new System.EventHandler(this.DayList_Load);
            this.AccountsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.WishListPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MainTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.TabPage AccountsPage;
        private System.Windows.Forms.TabPage WishListPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
