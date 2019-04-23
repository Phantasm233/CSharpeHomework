namespace CS8
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource9 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource10 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource11 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource12 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource13 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource13)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderId,
            this.guestName,
            this.goodsName,
            this.goodsCount,
            this.goodsPrice});
            this.dataGridView1.Location = new System.Drawing.Point(37, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(544, 310);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderId
            // 
            this.orderId.DataPropertyName = "orderId";
            this.orderId.HeaderText = "订单号";
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            // 
            // guestName
            // 
            this.guestName.DataPropertyName = "customer";
            this.guestName.HeaderText = "客户名";
            this.guestName.Name = "guestName";
            this.guestName.ReadOnly = true;
            // 
            // goodsName
            // 
            this.goodsName.DataPropertyName = "details";
            this.goodsName.HeaderText = "商品名";
            this.goodsName.Name = "goodsName";
            this.goodsName.ReadOnly = true;
            // 
            // goodsCount
            // 
            this.goodsCount.HeaderText = "商品数量";
            this.goodsCount.Name = "goodsCount";
            this.goodsCount.ReadOnly = true;
            // 
            // goodsPrice
            // 
            this.goodsPrice.HeaderText = "商品价格";
            this.goodsPrice.Name = "goodsPrice";
            this.goodsPrice.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(106, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 25);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "订单号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(321, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(421, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(632, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 5;
            this.button3.Text = "添加";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(632, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 43);
            this.button4.TabIndex = 6;
            this.button4.Text = "修改";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 480);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.BindingSource bindingSource4;
        private System.Windows.Forms.BindingSource bindingSource5;
        private System.Windows.Forms.BindingSource bindingSource6;
        private System.Windows.Forms.BindingSource bindingSource7;
        private System.Windows.Forms.BindingSource bindingSource8;
        private System.Windows.Forms.BindingSource bindingSource9;
        private System.Windows.Forms.BindingSource bindingSource10;
        private System.Windows.Forms.BindingSource bindingSource11;
        private System.Windows.Forms.BindingSource bindingSource12;
        private System.Windows.Forms.BindingSource bindingSource13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsPrice;
    }
}

