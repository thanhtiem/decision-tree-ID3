namespace ID3
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.dgvmain = new System.Windows.Forms.DataGridView();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnloaddata = new System.Windows.Forms.Button();
            this.pnpaint = new System.Windows.Forms.Panel();
            this.pbxpaint = new System.Windows.Forms.PictureBox();
            this.rtxresult = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmain)).BeginInit();
            this.pnpaint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpaint)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Font = new System.Drawing.Font("VNI-Bodon-Poster", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(196, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(831, 69);
            this.label1.TabIndex = 6;
            this.label1.Text = "DECISION TREE LEARNING - ID3 Algorithm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRun.ForeColor = System.Drawing.Color.Red;
            this.btnRun.Location = new System.Drawing.Point(151, 41);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(122, 54);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnlearn_Click);
            // 
            // dgvmain
            // 
            this.dgvmain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvmain.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmain.Location = new System.Drawing.Point(23, 111);
            this.dgvmain.Margin = new System.Windows.Forms.Padding(4);
            this.dgvmain.Name = "dgvmain";
            this.dgvmain.Size = new System.Drawing.Size(562, 218);
            this.dgvmain.TabIndex = 6;
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnnew.Location = new System.Drawing.Point(281, 41);
            this.btnnew.Margin = new System.Windows.Forms.Padding(4);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(122, 54);
            this.btnnew.TabIndex = 5;
            this.btnnew.Text = "Reset";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnloaddata
            // 
            this.btnloaddata.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnloaddata.Location = new System.Drawing.Point(21, 41);
            this.btnloaddata.Margin = new System.Windows.Forms.Padding(4);
            this.btnloaddata.Name = "btnloaddata";
            this.btnloaddata.Size = new System.Drawing.Size(122, 54);
            this.btnloaddata.TabIndex = 8;
            this.btnloaddata.Text = "Load Data";
            this.btnloaddata.UseVisualStyleBackColor = true;
            this.btnloaddata.Click += new System.EventHandler(this.btnloaddata_Click);
            // 
            // pnpaint
            // 
            this.pnpaint.AutoScroll = true;
            this.pnpaint.BackColor = System.Drawing.Color.Gainsboro;
            this.pnpaint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnpaint.Controls.Add(this.pbxpaint);
            this.pnpaint.Location = new System.Drawing.Point(629, 111);
            this.pnpaint.Margin = new System.Windows.Forms.Padding(4);
            this.pnpaint.Name = "pnpaint";
            this.pnpaint.Size = new System.Drawing.Size(682, 457);
            this.pnpaint.TabIndex = 7;
            // 
            // pbxpaint
            // 
            this.pbxpaint.BackColor = System.Drawing.Color.Gainsboro;
            this.pbxpaint.Location = new System.Drawing.Point(-2, -2);
            this.pbxpaint.Margin = new System.Windows.Forms.Padding(4);
            this.pbxpaint.Name = "pbxpaint";
            this.pbxpaint.Size = new System.Drawing.Size(756, 621);
            this.pbxpaint.TabIndex = 0;
            this.pbxpaint.TabStop = false;
            this.pbxpaint.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxpaint_Paint);
            // 
            // rtxresult
            // 
            this.rtxresult.BackColor = System.Drawing.Color.Gainsboro;
            this.rtxresult.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtxresult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rtxresult.Location = new System.Drawing.Point(23, 369);
            this.rtxresult.Margin = new System.Windows.Forms.Padding(4);
            this.rtxresult.Name = "rtxresult";
            this.rtxresult.ReadOnly = true;
            this.rtxresult.Size = new System.Drawing.Size(562, 180);
            this.rtxresult.TabIndex = 0;
            this.rtxresult.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(422, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 54);
            this.button1.TabIndex = 10;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnloaddata);
            this.groupBox1.Controls.Add(this.btnRun);
            this.groupBox1.Controls.Add(this.btnnew);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 557);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(552, 99);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Data training";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Solutions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1038, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tree";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1071, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "GVHD: Nguyễn Thị Ngọc Diễm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(46, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 92);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1335, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnpaint);
            this.Controls.Add(this.rtxresult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvmain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "ID3";
            this.Load += new System.EventHandler(this.ID3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmain)).EndInit();
            this.pnpaint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxpaint)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.DataGridView dgvmain;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnloaddata;
        private System.Windows.Forms.Panel pnpaint;
        private System.Windows.Forms.PictureBox pbxpaint;
        private System.Windows.Forms.RichTextBox rtxresult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

