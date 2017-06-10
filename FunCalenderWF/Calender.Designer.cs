namespace FunCalenderWF
{
    partial class Calender
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
            this.SetWishList = new System.Windows.Forms.Button();
            this.SetCalender = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Prev = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.YearMonth = new System.Windows.Forms.Label();
            this.monthlen = new System.Windows.Forms.TableLayoutPanel();
            this.day1 = new System.Windows.Forms.Label();
            this.day2 = new System.Windows.Forms.Label();
            this.day3 = new System.Windows.Forms.Label();
            this.day4 = new System.Windows.Forms.Label();
            this.day5 = new System.Windows.Forms.Label();
            this.day6 = new System.Windows.Forms.Label();
            this.day7 = new System.Windows.Forms.Label();
            this.day8 = new System.Windows.Forms.Label();
            this.day9 = new System.Windows.Forms.Label();
            this.day10 = new System.Windows.Forms.Label();
            this.day11 = new System.Windows.Forms.Label();
            this.day12 = new System.Windows.Forms.Label();
            this.day13 = new System.Windows.Forms.Label();
            this.day14 = new System.Windows.Forms.Label();
            this.day15 = new System.Windows.Forms.Label();
            this.day16 = new System.Windows.Forms.Label();
            this.day17 = new System.Windows.Forms.Label();
            this.day18 = new System.Windows.Forms.Label();
            this.day19 = new System.Windows.Forms.Label();
            this.day20 = new System.Windows.Forms.Label();
            this.day21 = new System.Windows.Forms.Label();
            this.day22 = new System.Windows.Forms.Label();
            this.day23 = new System.Windows.Forms.Label();
            this.day24 = new System.Windows.Forms.Label();
            this.day25 = new System.Windows.Forms.Label();
            this.day26 = new System.Windows.Forms.Label();
            this.day27 = new System.Windows.Forms.Label();
            this.day28 = new System.Windows.Forms.Label();
            this.day29 = new System.Windows.Forms.Label();
            this.day30 = new System.Windows.Forms.Label();
            this.day31 = new System.Windows.Forms.Label();
            this.day32 = new System.Windows.Forms.Label();
            this.day33 = new System.Windows.Forms.Label();
            this.day34 = new System.Windows.Forms.Label();
            this.day35 = new System.Windows.Forms.Label();
            this.day36 = new System.Windows.Forms.Label();
            this.day37 = new System.Windows.Forms.Label();
            this.day38 = new System.Windows.Forms.Label();
            this.day39 = new System.Windows.Forms.Label();
            this.day40 = new System.Windows.Forms.Label();
            this.day41 = new System.Windows.Forms.Label();
            this.day42 = new System.Windows.Forms.Label();
            this.Selectday = new System.Windows.Forms.DateTimePicker();
            this.monthlen.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetWishList
            // 
            this.SetWishList.Location = new System.Drawing.Point(19, 133);
            this.SetWishList.Name = "SetWishList";
            this.SetWishList.Size = new System.Drawing.Size(104, 64);
            this.SetWishList.TabIndex = 1;
            this.SetWishList.Text = "WishList";
            this.SetWishList.UseVisualStyleBackColor = true;
            // 
            // SetCalender
            // 
            this.SetCalender.Enabled = false;
            this.SetCalender.Location = new System.Drawing.Point(19, 43);
            this.SetCalender.Name = "SetCalender";
            this.SetCalender.Size = new System.Drawing.Size(104, 64);
            this.SetCalender.TabIndex = 2;
            this.SetCalender.Text = "Calender";
            this.SetCalender.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 64);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Prev
            // 
            this.Prev.Location = new System.Drawing.Point(279, 534);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(75, 23);
            this.Prev.TabIndex = 4;
            this.Prev.Text = "<";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(409, 534);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 5;
            this.Next.Text = ">";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // YearMonth
            // 
            this.YearMonth.AutoSize = true;
            this.YearMonth.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.YearMonth.Location = new System.Drawing.Point(320, 100);
            this.YearMonth.Name = "YearMonth";
            this.YearMonth.Size = new System.Drawing.Size(143, 27);
            this.YearMonth.TabIndex = 6;
            this.YearMonth.Text = "0000年0月";
            // 
            // monthlen
            // 
            this.monthlen.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.monthlen.ColumnCount = 7;
            this.monthlen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.92593F));
            this.monthlen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.07407F));
            this.monthlen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.monthlen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.monthlen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.monthlen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.monthlen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.monthlen.Controls.Add(this.day1, 0, 0);
            this.monthlen.Controls.Add(this.day2, 1, 0);
            this.monthlen.Controls.Add(this.day3, 2, 0);
            this.monthlen.Controls.Add(this.day4, 3, 0);
            this.monthlen.Controls.Add(this.day5, 4, 0);
            this.monthlen.Controls.Add(this.day6, 5, 0);
            this.monthlen.Controls.Add(this.day7, 6, 0);
            this.monthlen.Controls.Add(this.day8, 0, 1);
            this.monthlen.Controls.Add(this.day9, 1, 1);
            this.monthlen.Controls.Add(this.day10, 2, 1);
            this.monthlen.Controls.Add(this.day11, 3, 1);
            this.monthlen.Controls.Add(this.day12, 4, 1);
            this.monthlen.Controls.Add(this.day13, 5, 1);
            this.monthlen.Controls.Add(this.day14, 6, 1);
            this.monthlen.Controls.Add(this.day15, 0, 2);
            this.monthlen.Controls.Add(this.day16, 1, 2);
            this.monthlen.Controls.Add(this.day17, 2, 2);
            this.monthlen.Controls.Add(this.day18, 3, 2);
            this.monthlen.Controls.Add(this.day19, 4, 2);
            this.monthlen.Controls.Add(this.day20, 5, 2);
            this.monthlen.Controls.Add(this.day21, 6, 2);
            this.monthlen.Controls.Add(this.day22, 0, 3);
            this.monthlen.Controls.Add(this.day23, 1, 3);
            this.monthlen.Controls.Add(this.day24, 2, 3);
            this.monthlen.Controls.Add(this.day25, 3, 3);
            this.monthlen.Controls.Add(this.day26, 4, 3);
            this.monthlen.Controls.Add(this.day27, 5, 3);
            this.monthlen.Controls.Add(this.day28, 6, 3);
            this.monthlen.Controls.Add(this.day29, 0, 4);
            this.monthlen.Controls.Add(this.day30, 1, 4);
            this.monthlen.Controls.Add(this.day31, 2, 4);
            this.monthlen.Controls.Add(this.day32, 3, 4);
            this.monthlen.Controls.Add(this.day33, 4, 4);
            this.monthlen.Controls.Add(this.day34, 5, 4);
            this.monthlen.Controls.Add(this.day35, 6, 4);
            this.monthlen.Controls.Add(this.day36, 0, 5);
            this.monthlen.Controls.Add(this.day37, 1, 5);
            this.monthlen.Controls.Add(this.day38, 2, 5);
            this.monthlen.Controls.Add(this.day39, 3, 5);
            this.monthlen.Controls.Add(this.day40, 4, 5);
            this.monthlen.Controls.Add(this.day41, 5, 5);
            this.monthlen.Controls.Add(this.day42, 6, 5);
            this.monthlen.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.monthlen.Location = new System.Drawing.Point(196, 130);
            this.monthlen.Name = "monthlen";
            this.monthlen.RowCount = 6;
            this.monthlen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.61832F));
            this.monthlen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.38168F));
            this.monthlen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.monthlen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.monthlen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.monthlen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.monthlen.Size = new System.Drawing.Size(375, 398);
            this.monthlen.TabIndex = 0;
            // 
            // day1
            // 
            this.day1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day1.AutoSize = true;
            this.day1.Cursor = System.Windows.Forms.Cursors.Default;
            this.day1.Location = new System.Drawing.Point(6, 3);
            this.day1.Name = "day1";
            this.day1.Size = new System.Drawing.Size(41, 62);
            this.day1.TabIndex = 0;
            this.day1.Text = "1";
            // 
            // day2
            // 
            this.day2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day2.AutoSize = true;
            this.day2.Location = new System.Drawing.Point(56, 3);
            this.day2.Name = "day2";
            this.day2.Size = new System.Drawing.Size(39, 62);
            this.day2.TabIndex = 1;
            this.day2.Text = "2";
            // 
            // day3
            // 
            this.day3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day3.AutoSize = true;
            this.day3.Location = new System.Drawing.Point(104, 3);
            this.day3.Name = "day3";
            this.day3.Size = new System.Drawing.Size(43, 62);
            this.day3.TabIndex = 2;
            this.day3.Text = "3";
            // 
            // day4
            // 
            this.day4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day4.AutoSize = true;
            this.day4.Location = new System.Drawing.Point(156, 3);
            this.day4.Name = "day4";
            this.day4.Size = new System.Drawing.Size(43, 62);
            this.day4.TabIndex = 3;
            this.day4.Text = "4";
            // 
            // day5
            // 
            this.day5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day5.AutoSize = true;
            this.day5.Location = new System.Drawing.Point(208, 3);
            this.day5.Name = "day5";
            this.day5.Size = new System.Drawing.Size(39, 62);
            this.day5.TabIndex = 4;
            this.day5.Text = "5";
            // 
            // day6
            // 
            this.day6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day6.AutoSize = true;
            this.day6.Location = new System.Drawing.Point(256, 3);
            this.day6.Name = "day6";
            this.day6.Size = new System.Drawing.Size(43, 62);
            this.day6.TabIndex = 5;
            this.day6.Text = "6";
            // 
            // day7
            // 
            this.day7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day7.AutoSize = true;
            this.day7.Location = new System.Drawing.Point(308, 3);
            this.day7.Name = "day7";
            this.day7.Size = new System.Drawing.Size(61, 62);
            this.day7.TabIndex = 6;
            this.day7.Text = "7";
            // 
            // day8
            // 
            this.day8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day8.AutoSize = true;
            this.day8.Location = new System.Drawing.Point(6, 68);
            this.day8.Name = "day8";
            this.day8.Size = new System.Drawing.Size(41, 63);
            this.day8.TabIndex = 7;
            this.day8.Text = "8";
            // 
            // day9
            // 
            this.day9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day9.AutoSize = true;
            this.day9.Location = new System.Drawing.Point(56, 68);
            this.day9.Name = "day9";
            this.day9.Size = new System.Drawing.Size(39, 63);
            this.day9.TabIndex = 8;
            this.day9.Text = "9";
            // 
            // day10
            // 
            this.day10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day10.AutoSize = true;
            this.day10.Location = new System.Drawing.Point(104, 68);
            this.day10.Name = "day10";
            this.day10.Size = new System.Drawing.Size(43, 63);
            this.day10.TabIndex = 9;
            this.day10.Text = "10";
            // 
            // day11
            // 
            this.day11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day11.AutoSize = true;
            this.day11.Location = new System.Drawing.Point(156, 68);
            this.day11.Name = "day11";
            this.day11.Size = new System.Drawing.Size(43, 63);
            this.day11.TabIndex = 10;
            this.day11.Text = "11";
            // 
            // day12
            // 
            this.day12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day12.AutoSize = true;
            this.day12.Location = new System.Drawing.Point(208, 68);
            this.day12.Name = "day12";
            this.day12.Size = new System.Drawing.Size(39, 63);
            this.day12.TabIndex = 11;
            this.day12.Text = "12";
            // 
            // day13
            // 
            this.day13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day13.AutoSize = true;
            this.day13.Location = new System.Drawing.Point(256, 68);
            this.day13.Name = "day13";
            this.day13.Size = new System.Drawing.Size(43, 63);
            this.day13.TabIndex = 12;
            this.day13.Text = "13";
            // 
            // day14
            // 
            this.day14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day14.AutoSize = true;
            this.day14.Location = new System.Drawing.Point(308, 68);
            this.day14.Name = "day14";
            this.day14.Size = new System.Drawing.Size(61, 63);
            this.day14.TabIndex = 13;
            this.day14.Text = "14";
            // 
            // day15
            // 
            this.day15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day15.AutoSize = true;
            this.day15.Location = new System.Drawing.Point(6, 134);
            this.day15.Name = "day15";
            this.day15.Size = new System.Drawing.Size(41, 64);
            this.day15.TabIndex = 14;
            this.day15.Text = "15";
            // 
            // day16
            // 
            this.day16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day16.AutoSize = true;
            this.day16.Location = new System.Drawing.Point(56, 134);
            this.day16.Name = "day16";
            this.day16.Size = new System.Drawing.Size(39, 64);
            this.day16.TabIndex = 15;
            this.day16.Text = "16";
            // 
            // day17
            // 
            this.day17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day17.AutoSize = true;
            this.day17.Location = new System.Drawing.Point(104, 134);
            this.day17.Name = "day17";
            this.day17.Size = new System.Drawing.Size(43, 64);
            this.day17.TabIndex = 16;
            this.day17.Text = "17";
            // 
            // day18
            // 
            this.day18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day18.AutoSize = true;
            this.day18.Location = new System.Drawing.Point(156, 134);
            this.day18.Name = "day18";
            this.day18.Size = new System.Drawing.Size(43, 64);
            this.day18.TabIndex = 17;
            this.day18.Text = "18";
            // 
            // day19
            // 
            this.day19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day19.AutoSize = true;
            this.day19.Location = new System.Drawing.Point(208, 134);
            this.day19.Name = "day19";
            this.day19.Size = new System.Drawing.Size(39, 64);
            this.day19.TabIndex = 18;
            this.day19.Text = "19";
            // 
            // day20
            // 
            this.day20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day20.AutoSize = true;
            this.day20.Location = new System.Drawing.Point(256, 134);
            this.day20.Name = "day20";
            this.day20.Size = new System.Drawing.Size(43, 64);
            this.day20.TabIndex = 19;
            this.day20.Text = "20";
            // 
            // day21
            // 
            this.day21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day21.AutoSize = true;
            this.day21.Location = new System.Drawing.Point(308, 134);
            this.day21.Name = "day21";
            this.day21.Size = new System.Drawing.Size(61, 64);
            this.day21.TabIndex = 20;
            this.day21.Text = "21";
            // 
            // day22
            // 
            this.day22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day22.AutoSize = true;
            this.day22.Location = new System.Drawing.Point(6, 201);
            this.day22.Name = "day22";
            this.day22.Size = new System.Drawing.Size(41, 65);
            this.day22.TabIndex = 21;
            this.day22.Text = "22";
            // 
            // day23
            // 
            this.day23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day23.AutoSize = true;
            this.day23.Location = new System.Drawing.Point(56, 201);
            this.day23.Name = "day23";
            this.day23.Size = new System.Drawing.Size(39, 65);
            this.day23.TabIndex = 22;
            this.day23.Text = "23";
            // 
            // day24
            // 
            this.day24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day24.AutoSize = true;
            this.day24.Location = new System.Drawing.Point(104, 201);
            this.day24.Name = "day24";
            this.day24.Size = new System.Drawing.Size(43, 65);
            this.day24.TabIndex = 23;
            this.day24.Text = "24";
            // 
            // day25
            // 
            this.day25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day25.AutoSize = true;
            this.day25.Location = new System.Drawing.Point(156, 201);
            this.day25.Name = "day25";
            this.day25.Size = new System.Drawing.Size(43, 65);
            this.day25.TabIndex = 24;
            this.day25.Text = "25";
            // 
            // day26
            // 
            this.day26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day26.AutoSize = true;
            this.day26.Location = new System.Drawing.Point(208, 201);
            this.day26.Name = "day26";
            this.day26.Size = new System.Drawing.Size(39, 65);
            this.day26.TabIndex = 25;
            this.day26.Text = "26";
            // 
            // day27
            // 
            this.day27.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day27.AutoSize = true;
            this.day27.Location = new System.Drawing.Point(256, 201);
            this.day27.Name = "day27";
            this.day27.Size = new System.Drawing.Size(43, 65);
            this.day27.TabIndex = 26;
            this.day27.Text = "27";
            // 
            // day28
            // 
            this.day28.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day28.AutoSize = true;
            this.day28.Location = new System.Drawing.Point(308, 201);
            this.day28.Name = "day28";
            this.day28.Size = new System.Drawing.Size(61, 65);
            this.day28.TabIndex = 27;
            this.day28.Text = "28";
            // 
            // day29
            // 
            this.day29.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day29.AutoSize = true;
            this.day29.Location = new System.Drawing.Point(6, 269);
            this.day29.Name = "day29";
            this.day29.Size = new System.Drawing.Size(41, 68);
            this.day29.TabIndex = 28;
            this.day29.Text = "29";
            // 
            // day30
            // 
            this.day30.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day30.AutoSize = true;
            this.day30.Location = new System.Drawing.Point(56, 269);
            this.day30.Name = "day30";
            this.day30.Size = new System.Drawing.Size(39, 68);
            this.day30.TabIndex = 29;
            this.day30.Text = "30";
            // 
            // day31
            // 
            this.day31.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day31.AutoSize = true;
            this.day31.Location = new System.Drawing.Point(104, 269);
            this.day31.Name = "day31";
            this.day31.Size = new System.Drawing.Size(43, 68);
            this.day31.TabIndex = 30;
            this.day31.Text = "31";
            // 
            // day32
            // 
            this.day32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day32.AutoSize = true;
            this.day32.Location = new System.Drawing.Point(156, 269);
            this.day32.Name = "day32";
            this.day32.Size = new System.Drawing.Size(43, 68);
            this.day32.TabIndex = 31;
            this.day32.Text = "32";
            // 
            // day33
            // 
            this.day33.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day33.AutoSize = true;
            this.day33.Location = new System.Drawing.Point(208, 269);
            this.day33.Name = "day33";
            this.day33.Size = new System.Drawing.Size(39, 68);
            this.day33.TabIndex = 32;
            this.day33.Text = "33";
            // 
            // day34
            // 
            this.day34.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day34.AutoSize = true;
            this.day34.Location = new System.Drawing.Point(256, 269);
            this.day34.Name = "day34";
            this.day34.Size = new System.Drawing.Size(43, 68);
            this.day34.TabIndex = 33;
            this.day34.Text = "34";
            // 
            // day35
            // 
            this.day35.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day35.AutoSize = true;
            this.day35.Location = new System.Drawing.Point(308, 269);
            this.day35.Name = "day35";
            this.day35.Size = new System.Drawing.Size(61, 68);
            this.day35.TabIndex = 34;
            this.day35.Text = "35";
            // 
            // day36
            // 
            this.day36.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day36.Location = new System.Drawing.Point(6, 340);
            this.day36.Name = "day36";
            this.day36.Size = new System.Drawing.Size(41, 55);
            this.day36.TabIndex = 0;
            this.day36.Text = "36";
            // 
            // day37
            // 
            this.day37.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day37.AutoSize = true;
            this.day37.Location = new System.Drawing.Point(56, 340);
            this.day37.Name = "day37";
            this.day37.Size = new System.Drawing.Size(39, 55);
            this.day37.TabIndex = 35;
            this.day37.Text = "37";
            // 
            // day38
            // 
            this.day38.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day38.AutoSize = true;
            this.day38.Location = new System.Drawing.Point(104, 340);
            this.day38.Name = "day38";
            this.day38.Size = new System.Drawing.Size(43, 55);
            this.day38.TabIndex = 36;
            this.day38.Text = "38";
            // 
            // day39
            // 
            this.day39.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day39.AutoSize = true;
            this.day39.Location = new System.Drawing.Point(156, 340);
            this.day39.Name = "day39";
            this.day39.Size = new System.Drawing.Size(43, 55);
            this.day39.TabIndex = 37;
            this.day39.Text = "39";
            // 
            // day40
            // 
            this.day40.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day40.AutoSize = true;
            this.day40.Location = new System.Drawing.Point(208, 340);
            this.day40.Name = "day40";
            this.day40.Size = new System.Drawing.Size(39, 55);
            this.day40.TabIndex = 38;
            this.day40.Text = "40";
            // 
            // day41
            // 
            this.day41.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day41.AutoSize = true;
            this.day41.Location = new System.Drawing.Point(256, 340);
            this.day41.Name = "day41";
            this.day41.Size = new System.Drawing.Size(43, 55);
            this.day41.TabIndex = 39;
            this.day41.Text = "41";
            // 
            // day42
            // 
            this.day42.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day42.AutoSize = true;
            this.day42.Location = new System.Drawing.Point(308, 340);
            this.day42.Name = "day42";
            this.day42.Size = new System.Drawing.Size(61, 55);
            this.day42.TabIndex = 40;
            this.day42.Text = "42";
            // 
            // Selectday
            // 
            this.Selectday.Location = new System.Drawing.Point(454, 78);
            this.Selectday.Name = "Selectday";
            this.Selectday.Size = new System.Drawing.Size(117, 19);
            this.Selectday.TabIndex = 7;
            // 
            // Calender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Selectday);
            this.Controls.Add(this.YearMonth);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SetCalender);
            this.Controls.Add(this.SetWishList);
            this.Controls.Add(this.monthlen);
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Calender";
            this.Size = new System.Drawing.Size(600, 600);
            this.Load += new System.EventHandler(this.Calender_Load);
            this.monthlen.ResumeLayout(false);
            this.monthlen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SetWishList;
        private System.Windows.Forms.Button SetCalender;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label YearMonth;
        private System.Windows.Forms.TableLayoutPanel monthlen;
        private System.Windows.Forms.Label day1;
        private System.Windows.Forms.Label day2;
        private System.Windows.Forms.Label day3;
        private System.Windows.Forms.Label day4;
        private System.Windows.Forms.Label day5;
        private System.Windows.Forms.Label day6;
        private System.Windows.Forms.Label day7;
        private System.Windows.Forms.Label day8;
        private System.Windows.Forms.Label day9;
        private System.Windows.Forms.Label day10;
        private System.Windows.Forms.Label day11;
        private System.Windows.Forms.Label day12;
        private System.Windows.Forms.Label day13;
        private System.Windows.Forms.Label day14;
        private System.Windows.Forms.Label day15;
        private System.Windows.Forms.Label day16;
        private System.Windows.Forms.Label day17;
        private System.Windows.Forms.Label day18;
        private System.Windows.Forms.Label day19;
        private System.Windows.Forms.Label day20;
        private System.Windows.Forms.Label day21;
        private System.Windows.Forms.Label day22;
        private System.Windows.Forms.Label day23;
        private System.Windows.Forms.Label day24;
        private System.Windows.Forms.Label day25;
        private System.Windows.Forms.Label day26;
        private System.Windows.Forms.Label day27;
        private System.Windows.Forms.Label day28;
        private System.Windows.Forms.Label day29;
        private System.Windows.Forms.Label day30;
        private System.Windows.Forms.Label day31;
        private System.Windows.Forms.Label day32;
        private System.Windows.Forms.Label day33;
        private System.Windows.Forms.Label day34;
        private System.Windows.Forms.Label day35;
        private System.Windows.Forms.Label day36;
        private System.Windows.Forms.Label day37;
        private System.Windows.Forms.Label day38;
        private System.Windows.Forms.Label day39;
        private System.Windows.Forms.Label day40;
        private System.Windows.Forms.Label day41;
        private System.Windows.Forms.Label day42;
        private System.Windows.Forms.DateTimePicker Selectday;
    }
}
