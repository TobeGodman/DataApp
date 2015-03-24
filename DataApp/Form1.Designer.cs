namespace DataApp
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.connectBt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.getDataBt = new System.Windows.Forms.Button();
            this.TickDataGridView = new System.Windows.Forms.DataGridView();
            this.StopBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TickDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // connectBt
            // 
            this.connectBt.Location = new System.Drawing.Point(31, 12);
            this.connectBt.Name = "connectBt";
            this.connectBt.Size = new System.Drawing.Size(95, 23);
            this.connectBt.TabIndex = 0;
            this.connectBt.Text = "连接服务器";
            this.connectBt.UseVisualStyleBackColor = true;
            this.connectBt.Click += new System.EventHandler(this.connectBt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(595, 107);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(223, 305);
            this.textBox1.TabIndex = 2;
            // 
            // getDataBt
            // 
            this.getDataBt.Location = new System.Drawing.Point(31, 41);
            this.getDataBt.Name = "getDataBt";
            this.getDataBt.Size = new System.Drawing.Size(95, 23);
            this.getDataBt.TabIndex = 3;
            this.getDataBt.Text = "获取行情";
            this.getDataBt.UseVisualStyleBackColor = true;
            this.getDataBt.Click += new System.EventHandler(this.getDataBt_Click);
            // 
            // TickDataGridView
            // 
            this.TickDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TickDataGridView.Location = new System.Drawing.Point(31, 107);
            this.TickDataGridView.Name = "TickDataGridView";
            this.TickDataGridView.RowHeadersVisible = false;
            this.TickDataGridView.RowTemplate.Height = 23;
            this.TickDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TickDataGridView.Size = new System.Drawing.Size(558, 376);
            this.TickDataGridView.TabIndex = 4;
            // 
            // StopBt
            // 
            this.StopBt.Location = new System.Drawing.Point(31, 70);
            this.StopBt.Name = "StopBt";
            this.StopBt.Size = new System.Drawing.Size(95, 23);
            this.StopBt.TabIndex = 5;
            this.StopBt.Text = "Stop";
            this.StopBt.UseVisualStyleBackColor = true;
            this.StopBt.Click += new System.EventHandler(this.StopBt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 506);
            this.Controls.Add(this.StopBt);
            this.Controls.Add(this.TickDataGridView);
            this.Controls.Add(this.getDataBt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.connectBt);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "行情";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TickDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectBt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button getDataBt;
        private System.Windows.Forms.DataGridView TickDataGridView;
        private System.Windows.Forms.Button StopBt;
    }
}

