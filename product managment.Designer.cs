namespace employeemanagment
{
    partial class product_managment
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
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.txt_batchno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.productiondate = new System.Windows.Forms.DateTimePicker();
            this.expirydate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.txt_type = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_productname
            // 
            this.txt_productname.Location = new System.Drawing.Point(112, 12);
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(100, 20);
            this.txt_productname.TabIndex = 0;
            // 
            // txt_batchno
            // 
            this.txt_batchno.Location = new System.Drawing.Point(112, 53);
            this.txt_batchno.Name = "txt_batchno";
            this.txt_batchno.Size = new System.Drawing.Size(100, 20);
            this.txt_batchno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRODUCT NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "BATCH NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PRODUCTION DATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "EXPIRY DATE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "TYPE";
            // 
            // productiondate
            // 
            this.productiondate.Location = new System.Drawing.Point(129, 95);
            this.productiondate.Name = "productiondate";
            this.productiondate.Size = new System.Drawing.Size(200, 20);
            this.productiondate.TabIndex = 7;
            // 
            // expirydate
            // 
            this.expirydate.Location = new System.Drawing.Point(335, 15);
            this.expirydate.Name = "expirydate";
            this.expirydate.Size = new System.Drawing.Size(200, 20);
            this.expirydate.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(481, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(48, 136);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 11;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(234, 136);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 12;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(443, 136);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 13;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(634, 135);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 14;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(371, 60);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(100, 20);
            this.txt_type.TabIndex = 15;
            // 
            // product_managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.search);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.expirydate);
            this.Controls.Add(this.productiondate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_batchno);
            this.Controls.Add(this.txt_productname);
            this.Name = "product_managment";
            this.Text = "product_managment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_productname;
        private System.Windows.Forms.TextBox txt_batchno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker productiondate;
        private System.Windows.Forms.DateTimePicker expirydate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox txt_type;
    }
}