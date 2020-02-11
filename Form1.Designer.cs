namespace JK_Control_Helper
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_scroll = new System.Windows.Forms.TextBox();
            this.textBox_mouse_y = new System.Windows.Forms.TextBox();
            this.textBox_mouse_x = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox_profile = new System.Windows.Forms.TextBox();
            this.button_browse = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_scroll);
            this.groupBox1.Controls.Add(this.textBox_mouse_y);
            this.groupBox1.Controls.Add(this.textBox_mouse_x);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensitivity Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 65);
            this.label5.TabIndex = 6;
            this.label5.Text = "The game can undo your changes,\r\nso when you save, make sure the game\r\nis off or " +
    "you\'re in the profile select menu.\r\n\r\n(Normal min. value is 0.250000)";
            // 
            // textBox_scroll
            // 
            this.textBox_scroll.Location = new System.Drawing.Point(70, 80);
            this.textBox_scroll.Name = "textBox_scroll";
            this.textBox_scroll.Size = new System.Drawing.Size(100, 20);
            this.textBox_scroll.TabIndex = 5;
            this.textBox_scroll.Text = "0.000000";
            // 
            // textBox_mouse_y
            // 
            this.textBox_mouse_y.Location = new System.Drawing.Point(70, 54);
            this.textBox_mouse_y.Name = "textBox_mouse_y";
            this.textBox_mouse_y.Size = new System.Drawing.Size(100, 20);
            this.textBox_mouse_y.TabIndex = 4;
            this.textBox_mouse_y.Text = "0.000000";
            // 
            // textBox_mouse_x
            // 
            this.textBox_mouse_x.Location = new System.Drawing.Point(70, 28);
            this.textBox_mouse_x.Name = "textBox_mouse_x";
            this.textBox_mouse_x.Size = new System.Drawing.Size(100, 20);
            this.textBox_mouse_x.TabIndex = 3;
            this.textBox_mouse_x.Text = "0.000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Scroll";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mouse Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mouse X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox_profile
            // 
            this.textBox_profile.Location = new System.Drawing.Point(97, 93);
            this.textBox_profile.Name = "textBox_profile";
            this.textBox_profile.ReadOnly = true;
            this.textBox_profile.Size = new System.Drawing.Size(241, 20);
            this.textBox_profile.TabIndex = 2;
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(16, 91);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(75, 23);
            this.button_browse.TabIndex = 3;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.Button_Browse_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(16, 256);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "If an input is grayed out, it\'s because it\'s not bound in-game";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 289);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.textBox_profile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "JK Sensitivity Helper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox_profile;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.TextBox textBox_mouse_x;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_scroll;
        private System.Windows.Forms.TextBox textBox_mouse_y;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
    }
}

