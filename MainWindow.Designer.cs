namespace LoginForm
{
    partial class MainWindow
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
            LoginPanel = new Panel();
            LRF_TabCtrl = new TabControl();
            loginTab = new TabPage();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            registerTab = new TabPage();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            resetBtn = new Button();
            button4 = new Button();
            forgotPasswordTab = new TabPage();
            otpTxtbx = new TextBox();
            button6 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            SearchPanel = new Panel();
            button5 = new Button();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            button7 = new Button();
            LoginPanel.SuspendLayout();
            LRF_TabCtrl.SuspendLayout();
            loginTab.SuspendLayout();
            registerTab.SuspendLayout();
            forgotPasswordTab.SuspendLayout();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.Controls.Add(LRF_TabCtrl);
            LoginPanel.Location = new Point(12, 12);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(618, 410);
            LoginPanel.TabIndex = 0;
            // 
            // LRF_TabCtrl
            // 
            LRF_TabCtrl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LRF_TabCtrl.Controls.Add(loginTab);
            LRF_TabCtrl.Controls.Add(registerTab);
            LRF_TabCtrl.Controls.Add(forgotPasswordTab);
            LRF_TabCtrl.ImeMode = ImeMode.NoControl;
            LRF_TabCtrl.ItemSize = new Size(40, 20);
            LRF_TabCtrl.Location = new Point(3, 3);
            LRF_TabCtrl.Multiline = true;
            LRF_TabCtrl.Name = "LRF_TabCtrl";
            LRF_TabCtrl.Padding = new Point(74, 3);
            LRF_TabCtrl.SelectedIndex = 0;
            LRF_TabCtrl.Size = new Size(615, 404);
            LRF_TabCtrl.TabIndex = 0;
            // 
            // loginTab
            // 
            loginTab.Controls.Add(button3);
            loginTab.Controls.Add(button2);
            loginTab.Controls.Add(button1);
            loginTab.Controls.Add(textBox2);
            loginTab.Controls.Add(textBox1);
            loginTab.Location = new Point(4, 24);
            loginTab.Name = "loginTab";
            loginTab.Padding = new Padding(3);
            loginTab.Size = new Size(607, 376);
            loginTab.TabIndex = 0;
            loginTab.Text = "Login";
            loginTab.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(404, 161);
            button3.Name = "button3";
            button3.Size = new Size(21, 23);
            button3.TabIndex = 4;
            button3.Text = "👁";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(323, 209);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(217, 209);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(214, 161);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(184, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(214, 119);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.Size = new Size(184, 23);
            textBox1.TabIndex = 0;
            // 
            // registerTab
            // 
            registerTab.Controls.Add(textBox7);
            registerTab.Controls.Add(textBox6);
            registerTab.Controls.Add(textBox5);
            registerTab.Controls.Add(textBox4);
            registerTab.Controls.Add(textBox3);
            registerTab.Controls.Add(radioButton2);
            registerTab.Controls.Add(radioButton1);
            registerTab.Controls.Add(resetBtn);
            registerTab.Controls.Add(button4);
            registerTab.Location = new Point(4, 24);
            registerTab.Name = "registerTab";
            registerTab.Padding = new Padding(3);
            registerTab.Size = new Size(607, 376);
            registerTab.TabIndex = 1;
            registerTab.Text = "Register";
            registerTab.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(190, 184);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Email";
            textBox7.Size = new Size(188, 23);
            textBox7.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(190, 155);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Mobile No.";
            textBox6.Size = new Size(188, 23);
            textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(190, 126);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Confirm Password";
            textBox5.Size = new Size(188, 23);
            textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(190, 97);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Password";
            textBox4.Size = new Size(188, 23);
            textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(190, 68);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Username";
            textBox3.Size = new Size(188, 23);
            textBox3.TabIndex = 4;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(190, 213);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(51, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Male";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(315, 213);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Female";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(190, 238);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(75, 23);
            resetBtn.TabIndex = 1;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(303, 238);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 0;
            button4.Text = "Submit";
            button4.UseVisualStyleBackColor = true;
            // 
            // forgotPasswordTab
            // 
            forgotPasswordTab.Controls.Add(button7);
            forgotPasswordTab.Controls.Add(textBox11);
            forgotPasswordTab.Controls.Add(textBox12);
            forgotPasswordTab.Controls.Add(button5);
            forgotPasswordTab.Controls.Add(otpTxtbx);
            forgotPasswordTab.Controls.Add(button6);
            forgotPasswordTab.Controls.Add(label3);
            forgotPasswordTab.Controls.Add(label2);
            forgotPasswordTab.Controls.Add(textBox10);
            forgotPasswordTab.Controls.Add(textBox9);
            forgotPasswordTab.Controls.Add(textBox8);
            forgotPasswordTab.Location = new Point(4, 24);
            forgotPasswordTab.Name = "forgotPasswordTab";
            forgotPasswordTab.Padding = new Padding(3);
            forgotPasswordTab.Size = new Size(607, 376);
            forgotPasswordTab.TabIndex = 2;
            forgotPasswordTab.Text = "Forgot Password";
            forgotPasswordTab.UseVisualStyleBackColor = true;
            // 
            // otpTxtbx
            // 
            otpTxtbx.Location = new Point(197, 162);
            otpTxtbx.Name = "otpTxtbx";
            otpTxtbx.PlaceholderText = "OTP";
            otpTxtbx.Size = new Size(188, 23);
            otpTxtbx.TabIndex = 12;
            // 
            // button6
            // 
            button6.Location = new Point(197, 133);
            button6.Name = "button6";
            button6.Size = new Size(188, 23);
            button6.TabIndex = 11;
            button6.Text = "Reset Password";
            button6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(280, 86);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 10;
            label3.Text = "OR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 42);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 9;
            label2.Text = "OR";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(197, 104);
            textBox10.Name = "textBox10";
            textBox10.PlaceholderText = "Email";
            textBox10.Size = new Size(188, 23);
            textBox10.TabIndex = 7;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(197, 60);
            textBox9.Name = "textBox9";
            textBox9.PlaceholderText = "Mobile No.";
            textBox9.Size = new Size(188, 23);
            textBox9.TabIndex = 6;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(197, 16);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "Username";
            textBox8.Size = new Size(188, 23);
            textBox8.TabIndex = 5;
            // 
            // SearchPanel
            // 
            SearchPanel.Location = new Point(12, 12);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(621, 410);
            SearchPanel.TabIndex = 1;
            // 
            // button5
            // 
            button5.Location = new Point(197, 190);
            button5.Name = "button5";
            button5.Size = new Size(188, 23);
            button5.TabIndex = 13;
            button5.Text = "Check OTP";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(197, 248);
            textBox11.Name = "textBox11";
            textBox11.PlaceholderText = "Confirm Password";
            textBox11.Size = new Size(188, 23);
            textBox11.TabIndex = 15;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(197, 219);
            textBox12.Name = "textBox12";
            textBox12.PlaceholderText = "Password";
            textBox12.Size = new Size(188, 23);
            textBox12.TabIndex = 14;
            // 
            // button7
            // 
            button7.Location = new Point(197, 277);
            button7.Name = "button7";
            button7.Size = new Size(188, 23);
            button7.TabIndex = 16;
            button7.Text = "Submit";
            button7.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 434);
            Controls.Add(SearchPanel);
            Controls.Add(LoginPanel);
            Name = "MainWindow";
            Text = "LibMgmtSys :: Department of Mathematics";
            LoginPanel.ResumeLayout(false);
            LRF_TabCtrl.ResumeLayout(false);
            loginTab.ResumeLayout(false);
            loginTab.PerformLayout();
            registerTab.ResumeLayout(false);
            registerTab.PerformLayout();
            forgotPasswordTab.ResumeLayout(false);
            forgotPasswordTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginPanel;
        private TabControl LRF_TabCtrl;
        private TabPage loginTab;
        private TabPage registerTab;
        private Panel SearchPanel;
        private TabPage forgotPasswordTab;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button resetBtn;
        private Button button4;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private Label label3;
        private Label label2;
        private Button button6;
        private TextBox otpTxtbx;
        private Button button5;
        private Button button7;
        private TextBox textBox11;
        private TextBox textBox12;
    }
}