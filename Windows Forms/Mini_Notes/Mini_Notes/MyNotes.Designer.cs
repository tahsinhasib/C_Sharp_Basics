namespace Mini_Notes
{
    partial class MyNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyNotes));
            this.label1 = new System.Windows.Forms.Label();
            this.notesdatagridview = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.date_tb = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_tb = new System.Windows.Forms.RichTextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.num_tb = new System.Windows.Forms.RichTextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notesdatagridview)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available notes";
            // 
            // notesdatagridview
            // 
            this.notesdatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.notesdatagridview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.notesdatagridview.ColumnHeadersHeight = 29;
            this.notesdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.notesdatagridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.notesdatagridview.Location = new System.Drawing.Point(43, 129);
            this.notesdatagridview.Name = "notesdatagridview";
            this.notesdatagridview.RowHeadersWidth = 51;
            this.notesdatagridview.RowTemplate.Height = 29;
            this.notesdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.notesdatagridview.Size = new System.Drawing.Size(815, 377);
            this.notesdatagridview.TabIndex = 1;
            this.notesdatagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.notesdatagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(897, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date :";
            // 
            // date_tb
            // 
            this.date_tb.Location = new System.Drawing.Point(1064, 185);
            this.date_tb.Name = "date_tb";
            this.date_tb.Size = new System.Drawing.Size(165, 45);
            this.date_tb.TabIndex = 7;
            this.date_tb.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(896, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Text :";
            // 
            // text_tb
            // 
            this.text_tb.Location = new System.Drawing.Point(1064, 252);
            this.text_tb.Name = "text_tb";
            this.text_tb.Size = new System.Drawing.Size(165, 139);
            this.text_tb.TabIndex = 9;
            this.text_tb.Text = "";
            // 
            // button_update
            // 
            this.button_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_update.Image = ((System.Drawing.Image)(resources.GetObject("button_update.Image")));
            this.button_update.Location = new System.Drawing.Point(0, 0);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(119, 125);
            this.button_update.TabIndex = 10;
            this.button_update.Text = "UPDATE";
            this.button_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(897, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "NO :";
            // 
            // num_tb
            // 
            this.num_tb.Location = new System.Drawing.Point(1064, 126);
            this.num_tb.Name = "num_tb";
            this.num_tb.Size = new System.Drawing.Size(165, 40);
            this.num_tb.TabIndex = 3;
            this.num_tb.Text = "";
            // 
            // button_delete
            // 
            this.button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_delete.Image = ((System.Drawing.Image)(resources.GetObject("button_delete.Image")));
            this.button_delete.Location = new System.Drawing.Point(223, 0);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(109, 125);
            this.button_delete.TabIndex = 11;
            this.button_delete.Text = "Delete";
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_reset
            // 
            this.button_reset.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_reset.Image = ((System.Drawing.Image)(resources.GetObject("button_reset.Image")));
            this.button_reset.Location = new System.Drawing.Point(118, 0);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(105, 125);
            this.button_reset.TabIndex = 12;
            this.button_reset.Text = "Reset";
            this.button_reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_reset);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Location = new System.Drawing.Point(897, 433);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 125);
            this.panel1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1124, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 87);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MyNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1277, 669);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.text_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.notesdatagridview);
            this.Controls.Add(this.label1);
            this.Name = "MyNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyNotes";
            this.Load += new System.EventHandler(this.MyNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notesdatagridview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView notesdatagridview;
        private Label label3;
        private RichTextBox date_tb;
        private Label label4;
        private RichTextBox text_tb;
        private Button button_update;
        private Label label2;
        private RichTextBox num_tb;
        private Button button_delete;
        private Button button_reset;
        private Panel panel1;
        private Button button2;
    }
}