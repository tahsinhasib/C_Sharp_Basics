namespace Mini_Notes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.button_notes = new System.Windows.Forms.Button();
            this.iconbutton_create = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 35.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(510, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOTES ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1136, 630);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Version 1.0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Controls.Add(this.button_about);
            this.panel1.Controls.Add(this.button_notes);
            this.panel1.Controls.Add(this.iconbutton_create);
            this.panel1.Location = new System.Drawing.Point(378, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 178);
            this.panel1.TabIndex = 2;
            // 
            // button_exit
            // 
            this.button_exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_exit.Image = ((System.Drawing.Image)(resources.GetObject("button_exit.Image")));
            this.button_exit.Location = new System.Drawing.Point(365, 0);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(117, 178);
            this.button_exit.TabIndex = 3;
            this.button_exit.Text = "Exit";
            this.button_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_about
            // 
            this.button_about.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_about.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_about.Image = ((System.Drawing.Image)(resources.GetObject("button_about.Image")));
            this.button_about.Location = new System.Drawing.Point(251, 0);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(114, 178);
            this.button_about.TabIndex = 2;
            this.button_about.Text = "About";
            this.button_about.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_about.UseVisualStyleBackColor = true;
            // 
            // button_notes
            // 
            this.button_notes.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_notes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_notes.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_notes.Image = ((System.Drawing.Image)(resources.GetObject("button_notes.Image")));
            this.button_notes.Location = new System.Drawing.Point(123, 0);
            this.button_notes.Name = "button_notes";
            this.button_notes.Size = new System.Drawing.Size(128, 178);
            this.button_notes.TabIndex = 1;
            this.button_notes.Text = "My Notes";
            this.button_notes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_notes.UseVisualStyleBackColor = true;
            this.button_notes.Click += new System.EventHandler(this.button_notes_Click);
            // 
            // iconbutton_create
            // 
            this.iconbutton_create.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconbutton_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbutton_create.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconbutton_create.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconbutton_create.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.iconbutton_create.IconColor = System.Drawing.Color.Black;
            this.iconbutton_create.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbutton_create.IconSize = 81;
            this.iconbutton_create.Location = new System.Drawing.Point(0, 0);
            this.iconbutton_create.Name = "iconbutton_create";
            this.iconbutton_create.Size = new System.Drawing.Size(123, 178);
            this.iconbutton_create.TabIndex = 0;
            this.iconbutton_create.Text = "Create New";
            this.iconbutton_create.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconbutton_create.UseVisualStyleBackColor = true;
            this.iconbutton_create.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1273, 665);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconbutton_create;
        private Button button_about;
        private Button button_notes;
        private Button button_exit;
    }
}