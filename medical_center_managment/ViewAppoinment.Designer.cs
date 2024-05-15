namespace medical_center_managment
{
    partial class ViewAppoinment
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
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.doctartb = new System.Windows.Forms.TextBox();
            this.appoinmenttb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.appodatetb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(63, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "View Appoinment";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(408, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(928, 375);
            this.dataGridView1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "DoctarID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Appoinment";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 38);
            this.button1.TabIndex = 20;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // doctartb
            // 
            this.doctartb.Location = new System.Drawing.Point(208, 188);
            this.doctartb.Multiline = true;
            this.doctartb.Name = "doctartb";
            this.doctartb.Size = new System.Drawing.Size(132, 33);
            this.doctartb.TabIndex = 21;
            this.doctartb.TextChanged += new System.EventHandler(this.doctartb_TextChanged);
            // 
            // appoinmenttb
            // 
            this.appoinmenttb.Location = new System.Drawing.Point(208, 358);
            this.appoinmenttb.Multiline = true;
            this.appoinmenttb.Name = "appoinmenttb";
            this.appoinmenttb.Size = new System.Drawing.Size(110, 33);
            this.appoinmenttb.TabIndex = 22;
            this.appoinmenttb.TextChanged += new System.EventHandler(this.appoinmenttb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Date";
            // 
            // appodatetb
            // 
            this.appodatetb.Location = new System.Drawing.Point(208, 246);
            this.appodatetb.Multiline = true;
            this.appodatetb.Name = "appodatetb";
            this.appodatetb.Size = new System.Drawing.Size(132, 33);
            this.appodatetb.TabIndex = 24;
            this.appodatetb.TextChanged += new System.EventHandler(this.appodatetb_TextChanged);
            // 
            // ViewAppoinment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 504);
            this.Controls.Add(this.appodatetb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.appoinmenttb);
            this.Controls.Add(this.doctartb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Name = "ViewAppoinment";
            this.Text = "View Appoinment";
            this.Load += new System.EventHandler(this.ViewAppoinment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox doctartb;
        private System.Windows.Forms.TextBox appoinmenttb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox appodatetb;
    }
}