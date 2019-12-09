namespace Potato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonCOM = new System.Windows.Forms.Button();
            this.comlist = new System.Windows.Forms.ComboBox();
            this.baudlist = new System.Windows.Forms.ComboBox();
            this.textin = new System.Windows.Forms.TextBox();
            this.textout = new System.Windows.Forms.TextBox();
            this.buttonTx = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonCOM
            // 
            this.buttonCOM.Location = new System.Drawing.Point(8, 51);
            this.buttonCOM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCOM.Name = "buttonCOM";
            this.buttonCOM.Size = new System.Drawing.Size(110, 34);
            this.buttonCOM.TabIndex = 0;
            this.buttonCOM.Text = "open";
            this.buttonCOM.UseVisualStyleBackColor = true;
            this.buttonCOM.Click += new System.EventHandler(this.buttonCOM_Click);
            // 
            // comlist
            // 
            this.comlist.FormattingEnabled = true;
            this.comlist.Location = new System.Drawing.Point(8, 8);
            this.comlist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comlist.Name = "comlist";
            this.comlist.Size = new System.Drawing.Size(111, 20);
            this.comlist.TabIndex = 1;
            this.comlist.SelectedIndexChanged += new System.EventHandler(this.comlist_SelectedIndexChanged);
            // 
            // baudlist
            // 
            this.baudlist.FormattingEnabled = true;
            this.baudlist.Location = new System.Drawing.Point(8, 29);
            this.baudlist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.baudlist.Name = "baudlist";
            this.baudlist.Size = new System.Drawing.Size(111, 20);
            this.baudlist.TabIndex = 2;
            this.baudlist.SelectedIndexChanged += new System.EventHandler(this.buadlist_SelectedIndexChanged);
            // 
            // textin
            // 
            this.textin.Location = new System.Drawing.Point(122, 8);
            this.textin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textin.Multiline = true;
            this.textin.Name = "textin";
            this.textin.Size = new System.Drawing.Size(496, 277);
            this.textin.TabIndex = 3;
            // 
            // textout
            // 
            this.textout.Location = new System.Drawing.Point(122, 288);
            this.textout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textout.Multiline = true;
            this.textout.Name = "textout";
            this.textout.Size = new System.Drawing.Size(409, 31);
            this.textout.TabIndex = 4;
            // 
            // buttonTx
            // 
            this.buttonTx.Location = new System.Drawing.Point(534, 288);
            this.buttonTx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTx.Name = "buttonTx";
            this.buttonTx.Size = new System.Drawing.Size(83, 30);
            this.buttonTx.TabIndex = 5;
            this.buttonTx.Text = "发送数据";
            this.buttonTx.UseVisualStyleBackColor = true;
            this.buttonTx.Click += new System.EventHandler(this.buttonTx_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(21, 297);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 12);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "github";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 327);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonTx);
            this.Controls.Add(this.textout);
            this.Controls.Add(this.textin);
            this.Controls.Add(this.baudlist);
            this.Controls.Add(this.comlist);
            this.Controls.Add(this.buttonCOM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "PotatoSerialPort";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCOM;
        private System.Windows.Forms.ComboBox comlist;
        private System.Windows.Forms.ComboBox baudlist;
        private System.Windows.Forms.TextBox textin;
        private System.Windows.Forms.TextBox textout;
        private System.Windows.Forms.Button buttonTx;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

