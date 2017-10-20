namespace New
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbListRow = new System.Windows.Forms.ListBox();
            this.lbListRel = new System.Windows.Forms.ListBox();
            this.listView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(544, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(544, 425);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtname
            // 
            this.txtname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtname.Location = new System.Drawing.Point(13, 13);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(525, 20);
            this.txtname.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbListRow
            // 
            this.lbListRow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbListRow.FormattingEnabled = true;
            this.lbListRow.Location = new System.Drawing.Point(13, 41);
            this.lbListRow.Name = "lbListRow";
            this.lbListRow.Size = new System.Drawing.Size(295, 186);
            this.lbListRow.TabIndex = 4;
            // 
            // lbListRel
            // 
            this.lbListRel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbListRel.FormattingEnabled = true;
            this.lbListRel.Location = new System.Drawing.Point(314, 41);
            this.lbListRel.Name = "lbListRel";
            this.lbListRel.Size = new System.Drawing.Size(305, 186);
            this.lbListRel.TabIndex = 5;
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Location = new System.Drawing.Point(13, 233);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(606, 186);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.lbListRel);
            this.Controls.Add(this.lbListRow);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpen);
            this.Name = "Main";
            this.Text = "Read File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lbListRow;
        private System.Windows.Forms.ListBox lbListRel;
        private System.Windows.Forms.ListView listView;
    }
}

