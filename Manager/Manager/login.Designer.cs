namespace Manager
{
    partial class loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            boxuser = new TextBox();
            boxpass = new TextBox();
            enter = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(128, 104);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(113, 41);
            label1.TabIndex = 0;
            label1.Text = "نام کاربری: ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Simplified Arabic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(70, 29);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(139, 48);
            label2.TabIndex = 1;
            label2.Text = "خوش آمدید!";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Simplified Arabic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(144, 208);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(96, 41);
            label3.TabIndex = 2;
            label3.Text = "رمزعبور: ";
            // 
            // boxuser
            // 
            boxuser.Anchor = AnchorStyles.Top;
            boxuser.BackColor = SystemColors.ControlLightLight;
            boxuser.Location = new Point(52, 151);
            boxuser.Name = "boxuser";
            boxuser.RightToLeft = RightToLeft.No;
            boxuser.Size = new Size(185, 23);
            boxuser.TabIndex = 3;
            boxuser.TextChanged += boxuser_TextChanged;
            // 
            // boxpass
            // 
            boxpass.Anchor = AnchorStyles.Top;
            boxpass.BackColor = SystemColors.ControlLightLight;
            boxpass.Location = new Point(52, 256);
            boxpass.Name = "boxpass";
            boxpass.RightToLeft = RightToLeft.No;
            boxpass.Size = new Size(185, 23);
            boxpass.TabIndex = 4;
            boxpass.UseSystemPasswordChar = true;
            boxpass.TextChanged += boxpass_TextChanged;
            // 
            // enter
            // 
            enter.Anchor = AnchorStyles.Top;
            enter.BackColor = SystemColors.ButtonHighlight;
            enter.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enter.ForeColor = SystemColors.ActiveCaptionText;
            enter.Location = new Point(104, 313);
            enter.Name = "enter";
            enter.Size = new Size(75, 28);
            enter.TabIndex = 5;
            enter.Text = "ورود";
            enter.TextAlign = ContentAlignment.TopCenter;
            enter.UseVisualStyleBackColor = false;
            enter.Click += enter_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(enter);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(boxpass);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(boxuser);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(279, 373);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "لطفا وارد بشوید";
            // 
            // loginform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(300, 391);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "loginform";
            Text = "Log in";
            Load += loginform_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox boxuser;
        private TextBox boxpass;
        private Button enter;
        private GroupBox groupBox1;
    }
}
