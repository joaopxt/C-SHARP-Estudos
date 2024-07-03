namespace TicTacToe;

partial class Form1 {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        components = new System.ComponentModel.Container();
        label1 = new Label();
        label2 = new Label();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        button5 = new Button();
        button6 = new Button();
        button7 = new Button();
        button8 = new Button();
        button9 = new Button();
        button10 = new Button();
        GameTimer = new System.Windows.Forms.Timer(components);
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(22, 30);
        label1.Name = "label1";
        label1.Size = new Size(65, 20);
        label1.TabIndex = 0;
        label1.Text = "Player 1";
        label1.Click += label1_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(503, 30);
        label2.Name = "label2";
        label2.Size = new Size(38, 20);
        label2.TabIndex = 2;
        label2.Text = "CPU";
        // 
        // button1
        // 
        button1.BackColor = SystemColors.Control;
        button1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button1.Location = new Point(103, 111);
        button1.Name = "button1";
        button1.Size = new Size(117, 103);
        button1.TabIndex = 3;
        button1.Text = "?";
        button1.UseVisualStyleBackColor = false;
        button1.Click += PlayerClickButton;
        // 
        // button2
        // 
        button2.BackColor = SystemColors.Control;
        button2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button2.Location = new Point(103, 220);
        button2.Name = "button2";
        button2.Size = new Size(117, 103);
        button2.TabIndex = 4;
        button2.Text = "?";
        button2.UseVisualStyleBackColor = false;
        button2.Click += PlayerClickButton;
        // 
        // button3
        // 
        button3.BackColor = SystemColors.Control;
        button3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button3.Location = new Point(349, 111);
        button3.Name = "button3";
        button3.Size = new Size(117, 103);
        button3.TabIndex = 5;
        button3.Text = "?";
        button3.UseVisualStyleBackColor = false;
        button3.Click += PlayerClickButton;
        // 
        // button4
        // 
        button4.BackColor = SystemColors.Control;
        button4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button4.Location = new Point(226, 111);
        button4.Name = "button4";
        button4.Size = new Size(117, 103);
        button4.TabIndex = 6;
        button4.Text = "?";
        button4.UseVisualStyleBackColor = false;
        button4.Click += PlayerClickButton;
        // 
        // button5
        // 
        button5.BackColor = SystemColors.Control;
        button5.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button5.Location = new Point(349, 220);
        button5.Name = "button5";
        button5.Size = new Size(117, 103);
        button5.TabIndex = 7;
        button5.Text = "?";
        button5.UseVisualStyleBackColor = false;
        button5.Click += PlayerClickButton;
        // 
        // button6
        // 
        button6.BackColor = SystemColors.Control;
        button6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button6.Location = new Point(226, 220);
        button6.Name = "button6";
        button6.Size = new Size(117, 103);
        button6.TabIndex = 8;
        button6.Text = "?";
        button6.UseVisualStyleBackColor = false;
        button6.Click += PlayerClickButton;
        // 
        // button7
        // 
        button7.BackColor = SystemColors.Control;
        button7.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button7.Location = new Point(349, 329);
        button7.Name = "button7";
        button7.Size = new Size(117, 103);
        button7.TabIndex = 9;
        button7.Text = "?";
        button7.UseVisualStyleBackColor = false;
        button7.Click += PlayerClickButton;
        // 
        // button8
        // 
        button8.BackColor = SystemColors.Control;
        button8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button8.Location = new Point(226, 329);
        button8.Name = "button8";
        button8.Size = new Size(117, 103);
        button8.TabIndex = 10;
        button8.Text = "?";
        button8.UseVisualStyleBackColor = false;
        button8.Click += PlayerClickButton;
        // 
        // button9
        // 
        button9.BackColor = SystemColors.Control;
        button9.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button9.Location = new Point(103, 329);
        button9.Name = "button9";
        button9.Size = new Size(117, 103);
        button9.TabIndex = 11;
        button9.Text = "?";
        button9.UseVisualStyleBackColor = false;
        button9.Click += PlayerClickButton;
        // 
        // button10
        // 
        button10.BackColor = SystemColors.GradientInactiveCaption;
        button10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button10.Location = new Point(221, 456);
        button10.Name = "button10";
        button10.Size = new Size(122, 39);
        button10.TabIndex = 12;
        button10.Text = "RESTART";
        button10.UseVisualStyleBackColor = false;
        button10.Click += RestartGame;
        // 
        // GameTimer
        // 
        GameTimer.Interval = 1000;
        GameTimer.Tick += CPUMpove;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(591, 535);
        Controls.Add(button10);
        Controls.Add(button9);
        Controls.Add(button8);
        Controls.Add(button7);
        Controls.Add(button6);
        Controls.Add(button5);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Form1";
        Text = "TicTacToe";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;
    private Button button8;
    private Button button9;
    private Button button10;
    private System.Windows.Forms.Timer GameTimer;
}
