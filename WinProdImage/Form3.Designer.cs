namespace WinProdImage
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productControl1 = new WinProdImage.ProductControl();
            this.productControl2 = new WinProdImage.ProductControl();
            this.productControl3 = new WinProdImage.ProductControl();
            this.productControl4 = new WinProdImage.ProductControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.productControl4);
            this.panel1.Controls.Add(this.productControl3);
            this.panel1.Controls.Add(this.productControl2);
            this.panel1.Controls.Add(this.productControl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 364);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(621, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(262, 364);
            this.dataGridView1.TabIndex = 1;
            // 
            // productControl1
            // 
            this.productControl1.BackColor = System.Drawing.Color.AliceBlue;
            this.productControl1.Font = new System.Drawing.Font("나눔스퀘어_ac", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productControl1.Location = new System.Drawing.Point(3, 3);
            this.productControl1.Name = "productControl1";
            this.productControl1.Size = new System.Drawing.Size(294, 175);
            this.productControl1.TabIndex = 0;
            // 
            // productControl2
            // 
            this.productControl2.BackColor = System.Drawing.Color.AliceBlue;
            this.productControl2.Font = new System.Drawing.Font("나눔스퀘어_ac", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productControl2.Location = new System.Drawing.Point(303, 3);
            this.productControl2.Name = "productControl2";
            this.productControl2.Size = new System.Drawing.Size(294, 175);
            this.productControl2.TabIndex = 1;
            // 
            // productControl3
            // 
            this.productControl3.BackColor = System.Drawing.Color.AliceBlue;
            this.productControl3.Font = new System.Drawing.Font("나눔스퀘어_ac", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productControl3.Location = new System.Drawing.Point(3, 184);
            this.productControl3.Name = "productControl3";
            this.productControl3.Size = new System.Drawing.Size(294, 175);
            this.productControl3.TabIndex = 2;
            // 
            // productControl4
            // 
            this.productControl4.BackColor = System.Drawing.Color.AliceBlue;
            this.productControl4.Font = new System.Drawing.Font("나눔스퀘어_ac", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productControl4.Location = new System.Drawing.Point(303, 184);
            this.productControl4.Name = "productControl4";
            this.productControl4.Size = new System.Drawing.Size(294, 175);
            this.productControl4.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 381);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProductControl productControl4;
        private ProductControl productControl3;
        private ProductControl productControl2;
        private ProductControl productControl1;
    }
}