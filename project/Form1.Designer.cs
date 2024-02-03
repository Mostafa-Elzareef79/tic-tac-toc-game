namespace project
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
            btn_start = new Button();
            player1 = new GroupBox();
            playone = new TextBox();
            O1 = new RadioButton();
            X1 = new RadioButton();
            player2 = new GroupBox();
            playtwo = new TextBox();
            O2 = new RadioButton();
            X2 = new RadioButton();
            player1.SuspendLayout();
            player2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_start
            // 
            btn_start.Location = new Point(307, 353);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(188, 48);
            btn_start.TabIndex = 0;
            btn_start.Text = "start game";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += button1_Click;
            // 
            // player1
            // 
            player1.Controls.Add(playone);
            player1.Controls.Add(O1);
            player1.Controls.Add(X1);
            player1.Location = new Point(63, 55);
            player1.Name = "player1";
            player1.Size = new Size(250, 125);
            player1.TabIndex = 1;
            player1.TabStop = false;
            player1.Text = "player1";
            player1.Enter += player1_Enter;
            // 
            // playone
            // 
            playone.Location = new Point(49, 89);
            playone.Name = "playone";
            playone.Size = new Size(125, 27);
            playone.TabIndex = 2;
            playone.TextChanged += textBox1_TextChanged;
            playone.Leave += playone_Leave;
            // 
            // O1
            // 
            O1.AutoSize = true;
            O1.Location = new Point(154, 59);
            O1.Name = "O1";
            O1.Size = new Size(41, 24);
            O1.TabIndex = 1;
            O1.Text = "O";
            O1.UseVisualStyleBackColor = true;
            O1.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // X1
            // 
            X1.AutoSize = true;
            X1.Location = new Point(49, 59);
            X1.Name = "X1";
            X1.Size = new Size(39, 24);
            X1.TabIndex = 0;
            X1.Text = "X";
            X1.UseVisualStyleBackColor = true;
            X1.CheckedChanged += X_CheckedChanged;
            // 
            // player2
            // 
            player2.Controls.Add(playtwo);
            player2.Controls.Add(O2);
            player2.Controls.Add(X2);
            player2.Location = new Point(522, 55);
            player2.Name = "player2";
            player2.Size = new Size(250, 125);
            player2.TabIndex = 2;
            player2.TabStop = false;
            player2.Text = "player2";
            // 
            // playtwo
            // 
            playtwo.Location = new Point(49, 92);
            playtwo.Name = "playtwo";
            playtwo.Size = new Size(125, 27);
            playtwo.TabIndex = 3;
            playtwo.TextChanged += textBox2_TextChanged;
            // 
            // O2
            // 
            O2.AutoSize = true;
            O2.Location = new Point(133, 59);
            O2.Name = "O2";
            O2.Size = new Size(41, 24);
            O2.TabIndex = 2;
            O2.TabStop = true;
            O2.Text = "O";
            O2.UseVisualStyleBackColor = true;
            O2.CheckedChanged += O2_CheckedChanged;
            // 
            // X2
            // 
            X2.AutoSize = true;
            X2.Location = new Point(22, 59);
            X2.Name = "X2";
            X2.Size = new Size(39, 24);
            X2.TabIndex = 1;
            X2.TabStop = true;
            X2.Text = "X";
            X2.UseVisualStyleBackColor = true;
            X2.CheckedChanged += X2_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(player2);
            Controls.Add(player1);
            Controls.Add(btn_start);
            Name = "Form1";
            Text = "Form1";
            player1.ResumeLayout(false);
            player1.PerformLayout();
            player2.ResumeLayout(false);
            player2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_start;
        private GroupBox player1;
        private GroupBox player2;
        private RadioButton O1;
        private RadioButton X1;
        private RadioButton O2;
        private RadioButton X2;
        public TextBox playone;
        public TextBox playtwo;
    }
}
