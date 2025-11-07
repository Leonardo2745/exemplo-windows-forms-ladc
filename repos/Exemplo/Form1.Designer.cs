namespace Exemplo
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
            labelTitle = new Label();
            labelOutput = new Label();
            labelX = new Label();
            labelY = new Label();
            labelTitleResult = new Label();
            btnSoma = new Button();
            btnSub = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            btnQuad = new Button();
            btnRaiz = new Button();
            btnMod = new Button();
            button1 = new Button();
            button2 = new Button();
            labelResult = new Label();
            btnReset = new Button();
            inputTextY = new TextBox();
            inputTextX = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.Lime;
            labelTitle.Location = new Point(86, 25);
            labelTitle.MaximumSize = new Size(180, 65);
            labelTitle.MinimumSize = new Size(180, 65);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(180, 65);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Calculator";
            // 
            // labelOutput
            // 
            labelOutput.AllowDrop = true;
            labelOutput.AutoSize = true;
            labelOutput.BackColor = Color.FromArgb(64, 64, 64);
            labelOutput.Font = new Font("Segoe UI", 30F);
            labelOutput.ForeColor = Color.LawnGreen;
            labelOutput.Location = new Point(378, 65);
            labelOutput.MaximumSize = new Size(400, 300);
            labelOutput.MinimumSize = new Size(400, 300);
            labelOutput.Name = "labelOutput";
            labelOutput.Padding = new Padding(10);
            labelOutput.Size = new Size(400, 300);
            labelOutput.TabIndex = 8;
            labelOutput.Text = "0";
            labelOutput.TextAlign = ContentAlignment.MiddleCenter;
            labelOutput.Click += labelOutput_Click;
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelX.ForeColor = Color.Lime;
            labelX.Location = new Point(31, 93);
            labelX.Name = "labelX";
            labelX.Size = new Size(50, 45);
            labelX.TabIndex = 5;
            labelX.Text = "X:";
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelY.ForeColor = Color.Lime;
            labelY.Location = new Point(31, 153);
            labelY.Name = "labelY";
            labelY.Size = new Size(48, 45);
            labelY.TabIndex = 6;
            labelY.Text = "Y:";
            // 
            // labelTitleResult
            // 
            labelTitleResult.AutoSize = true;
            labelTitleResult.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitleResult.ForeColor = Color.Lime;
            labelTitleResult.Location = new Point(527, 9);
            labelTitleResult.Name = "labelTitleResult";
            labelTitleResult.Size = new Size(111, 45);
            labelTitleResult.TabIndex = 7;
            labelTitleResult.Text = "Result";
            // 
            // btnSoma
            // 
            btnSoma.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSoma.BackColor = Color.FromArgb(64, 64, 64);
            btnSoma.BackgroundImageLayout = ImageLayout.Center;
            btnSoma.FlatStyle = FlatStyle.Flat;
            btnSoma.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSoma.ForeColor = Color.Lime;
            btnSoma.Location = new Point(50, 221);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(61, 63);
            btnSoma.TabIndex = 8;
            btnSoma.TabStop = false;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.FromArgb(64, 64, 64);
            btnSub.FlatStyle = FlatStyle.Flat;
            btnSub.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSub.ForeColor = Color.Lime;
            btnSub.Location = new Point(146, 221);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(61, 63);
            btnSub.TabIndex = 9;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnSub_Click;
            // 
            // btnMult
            // 
            btnMult.BackColor = Color.FromArgb(64, 64, 64);
            btnMult.FlatStyle = FlatStyle.Flat;
            btnMult.Font = new Font("Segoe UI", 14F);
            btnMult.ForeColor = Color.Lime;
            btnMult.Location = new Point(239, 221);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(61, 63);
            btnMult.TabIndex = 10;
            btnMult.Text = "x";
            btnMult.UseVisualStyleBackColor = false;
            btnMult.Click += btnMult_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.FromArgb(64, 64, 64);
            btnDiv.FlatStyle = FlatStyle.Flat;
            btnDiv.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDiv.ForeColor = Color.Lime;
            btnDiv.Location = new Point(50, 290);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(61, 63);
            btnDiv.TabIndex = 11;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnQuad
            // 
            btnQuad.BackColor = Color.FromArgb(64, 64, 64);
            btnQuad.FlatStyle = FlatStyle.Flat;
            btnQuad.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnQuad.ForeColor = Color.Lime;
            btnQuad.Location = new Point(146, 290);
            btnQuad.Name = "btnQuad";
            btnQuad.Size = new Size(61, 63);
            btnQuad.TabIndex = 12;
            btnQuad.Text = "x²";
            btnQuad.UseVisualStyleBackColor = false;
            btnQuad.Click += btnQuad_Click;
            // 
            // btnRaiz
            // 
            btnRaiz.BackColor = Color.FromArgb(64, 64, 64);
            btnRaiz.FlatStyle = FlatStyle.Flat;
            btnRaiz.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRaiz.ForeColor = Color.Lime;
            btnRaiz.Location = new Point(239, 292);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(61, 63);
            btnRaiz.TabIndex = 13;
            btnRaiz.Text = "√";
            btnRaiz.UseVisualStyleBackColor = false;
            btnRaiz.Click += btnRaiz_Click;
            // 
            // btnMod
            // 
            btnMod.BackColor = Color.FromArgb(64, 64, 64);
            btnMod.FlatStyle = FlatStyle.Flat;
            btnMod.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMod.ForeColor = Color.Lime;
            btnMod.Location = new Point(50, 359);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(61, 63);
            btnMod.TabIndex = 14;
            btnMod.Text = "%";
            btnMod.UseVisualStyleBackColor = false;
            btnMod.Click += btnPorc_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(146, 361);
            button1.Name = "button1";
            button1.Size = new Size(61, 63);
            button1.TabIndex = 15;
            button1.Text = "010";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnBin_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.Lime;
            button2.Location = new Point(239, 361);
            button2.Name = "button2";
            button2.Size = new Size(61, 63);
            button2.TabIndex = 16;
            button2.Text = "x^y";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnElev_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.BackColor = Color.FromArgb(64, 64, 64);
            labelResult.Font = new Font("Segoe UI", 12F);
            labelResult.ForeColor = Color.Lime;
            labelResult.Location = new Point(657, 75);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(27, 32);
            labelResult.TabIndex = 7;
            labelResult.Text = "0";
            labelResult.TextAlign = ContentAlignment.MiddleLeft;
            labelResult.Visible = false;
            labelResult.Click += labelResult_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(64, 64, 64);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReset.ForeColor = Color.Lime;
            btnReset.Location = new Point(500, 378);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(159, 46);
            btnReset.TabIndex = 17;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // inputTextY
            // 
            inputTextY.BackColor = Color.FromArgb(64, 64, 64);
            inputTextY.BorderStyle = BorderStyle.FixedSingle;
            inputTextY.Font = new Font("Segoe UI", 12F);
            inputTextY.ForeColor = Color.Lime;
            inputTextY.Location = new Point(85, 158);
            inputTextY.MaximumSize = new Size(180, 30);
            inputTextY.MinimumSize = new Size(180, 40);
            inputTextY.Name = "inputTextY";
            inputTextY.Size = new Size(180, 40);
            inputTextY.TabIndex = 2;
            inputTextY.TextAlign = HorizontalAlignment.Center;
            inputTextY.TextChanged += inputTextY_TextChanged;
            // 
            // inputTextX
            // 
            inputTextX.BackColor = Color.FromArgb(64, 64, 64);
            inputTextX.BorderStyle = BorderStyle.FixedSingle;
            inputTextX.Font = new Font("Segoe UI", 12F);
            inputTextX.ForeColor = Color.Lime;
            inputTextX.Location = new Point(85, 98);
            inputTextX.MaximumSize = new Size(180, 30);
            inputTextX.MinimumSize = new Size(180, 40);
            inputTextX.Name = "inputTextX";
            inputTextX.Size = new Size(180, 40);
            inputTextX.TabIndex = 18;
            inputTextX.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 6F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(693, 426);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 19;
            label1.Text = "© Leonardo A.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(inputTextX);
            Controls.Add(btnReset);
            Controls.Add(labelResult);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnMod);
            Controls.Add(btnRaiz);
            Controls.Add(btnQuad);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnSub);
            Controls.Add(btnSoma);
            Controls.Add(labelTitleResult);
            Controls.Add(labelY);
            Controls.Add(labelX);
            Controls.Add(inputTextY);
            Controls.Add(labelOutput);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTitle;
        private Label labelOutput;
        private Label labelX;
        private Label labelY;
        private Label labelTitleResult;
        private Button btnSoma;
        private Button btnSub;
        private Button btnMult;
        private Button btnDiv;
        private Button btnQuad;
        private Button btnRaiz;
        private Button btnMod;
        private Button button1;
        private Button button2;
        private Label labelResult;
        private Button btnReset;
        private TextBox inputTextY;
        private TextBox inputTextX;
        private Label label1;
    }
}
