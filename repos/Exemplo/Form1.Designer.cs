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
            inputTextX = new TextBox();
            labelTitle = new Label();
            labelOutput = new Label();
            inputTextY = new TextBox();
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
            SuspendLayout();
            // 
            // inputTextX
            // 
            inputTextX.Location = new Point(86, 107);
            inputTextX.Name = "inputTextX";
            inputTextX.Size = new Size(182, 31);
            inputTextX.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.Coral;
            labelTitle.Location = new Point(16, 18);
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
            labelOutput.BackColor = Color.FromArgb(40, 42, 54);
            labelOutput.ForeColor = Color.White;
            labelOutput.Location = new Point(378, 65);
            labelOutput.MaximumSize = new Size(400, 300);
            labelOutput.MinimumSize = new Size(400, 300);
            labelOutput.Name = "labelOutput";
            labelOutput.Padding = new Padding(10);
            labelOutput.Size = new Size(400, 300);
            labelOutput.TabIndex = 8;
            labelOutput.Text = "0";
            labelOutput.TextAlign = ContentAlignment.TopRight;
            labelOutput.Visible = false;
            // 
            // inputTextY
            // 
            inputTextY.Location = new Point(86, 167);
            inputTextY.Name = "inputTextY";
            inputTextY.Size = new Size(182, 31);
            inputTextY.TabIndex = 2;
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelX.ForeColor = Color.Coral;
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
            labelY.ForeColor = Color.Coral;
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
            labelTitleResult.ForeColor = Color.Coral;
            labelTitleResult.Location = new Point(527, 9);
            labelTitleResult.Name = "labelTitleResult";
            labelTitleResult.Size = new Size(111, 45);
            labelTitleResult.TabIndex = 7;
            labelTitleResult.Text = "Result";
            // 
            // btnSoma
            // 
            btnSoma.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSoma.BackColor = Color.Coral;
            btnSoma.BackgroundImageLayout = ImageLayout.Center;
            btnSoma.FlatStyle = FlatStyle.Flat;
            btnSoma.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSoma.ForeColor = SystemColors.Control;
            btnSoma.Location = new Point(31, 238);
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
            btnSub.BackColor = Color.Coral;
            btnSub.FlatStyle = FlatStyle.Flat;
            btnSub.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSub.ForeColor = SystemColors.Control;
            btnSub.Location = new Point(120, 238);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(61, 63);
            btnSub.TabIndex = 9;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnSub_Click;
            // 
            // btnMult
            // 
            btnMult.BackColor = Color.Coral;
            btnMult.FlatStyle = FlatStyle.Flat;
            btnMult.Font = new Font("Segoe UI", 14F);
            btnMult.ForeColor = SystemColors.Control;
            btnMult.Location = new Point(207, 238);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(61, 63);
            btnMult.TabIndex = 10;
            btnMult.Text = "x";
            btnMult.UseVisualStyleBackColor = false;
            btnMult.Click += btnMult_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.Coral;
            btnDiv.FlatStyle = FlatStyle.Flat;
            btnDiv.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDiv.ForeColor = SystemColors.Control;
            btnDiv.Location = new Point(31, 308);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(61, 63);
            btnDiv.TabIndex = 11;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnQuad
            // 
            btnQuad.BackColor = Color.Coral;
            btnQuad.FlatStyle = FlatStyle.Flat;
            btnQuad.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnQuad.ForeColor = SystemColors.Control;
            btnQuad.Location = new Point(120, 308);
            btnQuad.Name = "btnQuad";
            btnQuad.Size = new Size(61, 63);
            btnQuad.TabIndex = 12;
            btnQuad.Text = "x²";
            btnQuad.UseVisualStyleBackColor = false;
            btnQuad.Click += btnQuad_Click;
            // 
            // btnRaiz
            // 
            btnRaiz.BackColor = Color.Coral;
            btnRaiz.FlatStyle = FlatStyle.Flat;
            btnRaiz.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRaiz.ForeColor = SystemColors.Control;
            btnRaiz.Location = new Point(207, 308);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(61, 63);
            btnRaiz.TabIndex = 13;
            btnRaiz.Text = "√";
            btnRaiz.UseVisualStyleBackColor = false;
            btnRaiz.Click += btnRaiz_Click;
            // 
            // btnMod
            // 
            btnMod.BackColor = Color.Coral;
            btnMod.FlatStyle = FlatStyle.Flat;
            btnMod.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMod.ForeColor = SystemColors.Control;
            btnMod.Location = new Point(31, 378);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(61, 63);
            btnMod.TabIndex = 14;
            btnMod.Text = "%";
            btnMod.UseVisualStyleBackColor = false;
            btnMod.Click += btnPorc_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(120, 378);
            button1.Name = "button1";
            button1.Size = new Size(61, 63);
            button1.TabIndex = 15;
            button1.Text = "010";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnBin_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Coral;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(207, 378);
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
            labelResult.BackColor = Color.FromArgb(40, 42, 54);
            labelResult.Font = new Font("Segoe UI", 20F);
            labelResult.ForeColor = Color.Coral;
            labelResult.Location = new Point(473, 190);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(221, 54);
            labelResult.TabIndex = 7;
            labelResult.Text = "000000000";
            labelResult.Visible = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Coral;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReset.ForeColor = SystemColors.Control;
            btnReset.Location = new Point(504, 386);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(159, 46);
            btnReset.TabIndex = 17;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 83, 102);
            ClientSize = new Size(800, 450);
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
            Controls.Add(inputTextX);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextX;
        private Label labelTitle;
        private Label labelOutput;
        private TextBox inputTextY;
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
    }
}
