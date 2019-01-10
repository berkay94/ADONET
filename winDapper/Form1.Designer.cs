namespace winDapper
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ınsertProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ınsertDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 381);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(208, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 182);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView2.Location = new System.Drawing.Point(208, 254);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(650, 179);
            this.dataGridView2.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ınsertProductToolStripMenuItem,
            this.deleteProductToolStripMenuItem,
            this.updateProductToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 70);
            // 
            // ınsertProductToolStripMenuItem
            // 
            this.ınsertProductToolStripMenuItem.Name = "ınsertProductToolStripMenuItem";
            this.ınsertProductToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ınsertProductToolStripMenuItem.Text = "Insert Product";
            this.ınsertProductToolStripMenuItem.Click += new System.EventHandler(this.ınsertProductToolStripMenuItem_Click);
            // 
            // deleteProductToolStripMenuItem
            // 
            this.deleteProductToolStripMenuItem.Name = "deleteProductToolStripMenuItem";
            this.deleteProductToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.deleteProductToolStripMenuItem.Text = "Delete Product";
            // 
            // updateProductToolStripMenuItem
            // 
            this.updateProductToolStripMenuItem.Name = "updateProductToolStripMenuItem";
            this.updateProductToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.updateProductToolStripMenuItem.Text = "Update Product";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ınsertDetailToolStripMenuItem,
            this.deleteDetailToolStripMenuItem,
            this.updateDetailToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(146, 70);
            // 
            // ınsertDetailToolStripMenuItem
            // 
            this.ınsertDetailToolStripMenuItem.Name = "ınsertDetailToolStripMenuItem";
            this.ınsertDetailToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.ınsertDetailToolStripMenuItem.Text = "Insert Detail";
            // 
            // deleteDetailToolStripMenuItem
            // 
            this.deleteDetailToolStripMenuItem.Name = "deleteDetailToolStripMenuItem";
            this.deleteDetailToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.deleteDetailToolStripMenuItem.Text = "Delete Detail";
            // 
            // updateDetailToolStripMenuItem
            // 
            this.updateDetailToolStripMenuItem.Name = "updateDetailToolStripMenuItem";
            this.updateDetailToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.updateDetailToolStripMenuItem.Text = "Update Detail";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 547);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ınsertProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProductToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ınsertDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDetailToolStripMenuItem;
    }
}

