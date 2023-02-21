namespace Mini_Notes
{
    partial class Create_Notes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_Notes));
            this.label1 = new System.Windows.Forms.Label();
            this.num_tb = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_tb = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.date_tb = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "NO :";
            // 
            // num_tb
            // 
            this.num_tb.Location = new System.Drawing.Point(236, 56);
            this.num_tb.Name = "num_tb";
            this.num_tb.Size = new System.Drawing.Size(309, 40);
            this.num_tb.TabIndex = 1;
            this.num_tb.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Text :";
            // 
            // text_tb
            // 
            this.text_tb.Location = new System.Drawing.Point(236, 209);
            this.text_tb.Name = "text_tb";
            this.text_tb.Size = new System.Drawing.Size(309, 139);
            this.text_tb.TabIndex = 3;
            this.text_tb.Text = "";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(236, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 150);
            this.button1.TabIndex = 4;
            this.button1.Text = "SAVE";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(63, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date :";
            // 
            // date_tb
            // 
            this.date_tb.Location = new System.Drawing.Point(236, 130);
            this.date_tb.Name = "date_tb";
            this.date_tb.Size = new System.Drawing.Size(309, 45);
            this.date_tb.TabIndex = 6;
            this.date_tb.Text = "";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1125, 541);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 87);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_reset
            // 
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_reset.Image = ((System.Drawing.Image)(resources.GetObject("button_reset.Image")));
            this.button_reset.Location = new System.Drawing.Point(403, 400);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(142, 150);
            this.button_reset.TabIndex = 8;
            this.button_reset.Text = "Reset";
            this.button_reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // Create_Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1277, 669);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.date_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_tb);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Create_Notes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyNotes";
            this.Load += new System.EventHandler(this.Create_Notes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RichTextBox num_tb;
        private Label label2;
        private RichTextBox text_tb;
        private Button button1;
        private Label label3;
        private RichTextBox date_tb;
        private Button button2;
        private Button button_reset;
    }
}