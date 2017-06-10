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
            // DayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prev);
            this.Controls.Add(this.day);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "DayList";
            this.Size = new System.Drawing.Size(600, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Button prev;
    }
}
