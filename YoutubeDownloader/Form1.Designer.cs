namespace YoutubeDownloader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtVideoUrl = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.cmbVideoType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVideoName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Download video";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtVideoUrl
            // 
            this.txtVideoUrl.Location = new System.Drawing.Point(82, 32);
            this.txtVideoUrl.Name = "txtVideoUrl";
            this.txtVideoUrl.Size = new System.Drawing.Size(374, 23);
            this.txtVideoUrl.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 77);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 15);
            this.lblMessage.TabIndex = 2;
            // 
            // cmbVideoType
            // 
            this.cmbVideoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoType.FormattingEnabled = true;
            this.cmbVideoType.Items.AddRange(new object[] {
            "Audio",
            "Video",
            "MP3"});
            this.cmbVideoType.Location = new System.Drawing.Point(462, 69);
            this.cmbVideoType.Name = "cmbVideoType";
            this.cmbVideoType.Size = new System.Drawing.Size(144, 23);
            this.cmbVideoType.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Video URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Video Name:";
            // 
            // txtVideoName
            // 
            this.txtVideoName.Location = new System.Drawing.Point(93, 69);
            this.txtVideoName.Name = "txtVideoName";
            this.txtVideoName.Size = new System.Drawing.Size(363, 23);
            this.txtVideoName.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 101);
            this.Controls.Add(this.txtVideoName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVideoType);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtVideoUrl);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Lucy\'s Youtube Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox txtVideoUrl;
        private Label lblMessage;
        private ComboBox cmbVideoType;
        private Label label1;
        private Label label2;
        private TextBox txtVideoName;
    }
}