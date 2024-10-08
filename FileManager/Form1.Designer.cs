﻿namespace FileManager
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            filePathTxt = new TextBox();
            backBtn = new Button();
            nextBtn = new Button();
            fileNameLbl = new Label();
            label2 = new Label();
            fileTypeLbl = new Label();
            label4 = new Label();
            iconList = new ImageList(components);
            listView1 = new ListView();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // filePathTxt
            // 
            filePathTxt.Location = new Point(94, 12);
            filePathTxt.Name = "filePathTxt";
            filePathTxt.Size = new Size(613, 23);
            filePathTxt.TabIndex = 0;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(12, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(75, 23);
            backBtn.TabIndex = 1;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // nextBtn
            // 
            nextBtn.Location = new Point(713, 12);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(75, 23);
            nextBtn.TabIndex = 2;
            nextBtn.Text = "Open";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // fileNameLbl
            // 
            fileNameLbl.AutoSize = true;
            fileNameLbl.Location = new Point(79, 370);
            fileNameLbl.Name = "fileNameLbl";
            fileNameLbl.Size = new Size(74, 15);
            fileNameLbl.TabIndex = 4;
            fileNameLbl.Text = "Not Selected";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 370);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 5;
            label2.Text = "File Name:";
            // 
            // fileTypeLbl
            // 
            fileTypeLbl.AutoSize = true;
            fileTypeLbl.Location = new Point(79, 406);
            fileTypeLbl.Name = "fileTypeLbl";
            fileTypeLbl.Size = new Size(74, 15);
            fileTypeLbl.TabIndex = 6;
            fileTypeLbl.Text = "Not Selected";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 406);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 7;
            label4.Text = "File Type:";
            // 
            // iconList
            // 
            iconList.ColorDepth = ColorDepth.Depth32Bit;
            iconList.ImageStream = (ImageListStreamer)resources.GetObject("iconList.ImageStream");
            iconList.TransparentColor = Color.Transparent;
            iconList.Images.SetKeyName(0, "audio.ico");
            iconList.Images.SetKeyName(1, "excel.ico");
            iconList.Images.SetKeyName(2, "folder.ico");
            iconList.Images.SetKeyName(3, "pdf.ico");
            iconList.Images.SetKeyName(4, "unknown.ico");
            iconList.Images.SetKeyName(5, "video.ico");
            iconList.Images.SetKeyName(6, "word.ico");
            iconList.Images.SetKeyName(7, "Yellowicon-Flat-Unknown.256.png");
            iconList.Images.SetKeyName(8, "Hopstarter-Sleek-Xp-Basic-Folder.256.png");
            // 
            // listView1
            // 
            listView1.Font = new Font("Segoe UI", 12F);
            listView1.LargeImageList = iconList;
            listView1.Location = new Point(10, 41);
            listView1.Name = "listView1";
            listView1.Size = new Size(778, 308);
            listView1.SmallImageList = iconList;
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.ItemSelectionChanged += listView1_ItemSelectionChanged;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(387, 370);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 9;
            lblMessage.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMessage);
            Controls.Add(listView1);
            Controls.Add(label4);
            Controls.Add(fileTypeLbl);
            Controls.Add(label2);
            Controls.Add(fileNameLbl);
            Controls.Add(nextBtn);
            Controls.Add(backBtn);
            Controls.Add(filePathTxt);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox filePathTxt;
        private Button backBtn;
        private Button nextBtn;
        private Label fileNameLbl;
        private Label label2;
        private Label fileTypeLbl;
        private Label label4;
        private ImageList iconList;
        private ListView listView1;
        private Label lblMessage;
    }
}
