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
            SuspendLayout();
            // 
            // inputTextX
            // 
            inputTextX.Location = new Point(60, 64);
            inputTextX.Margin = new Padding(2);
            inputTextX.Name = "inputTextX";
            inputTextX.Size = new Size(84, 23);
            inputTextX.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.Coral;
            labelTitle.Location = new Point(11, 11);
            labelTitle.Margin = new Padding(2, 0, 2, 0);
            labelTitle.MaximumSize = new Size(126, 39);
            labelTitle.MinimumSize = new Size(126, 39);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(126, 39);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Calculator";
            // 
            // labelOutput
            // 
            labelOutput.AllowDrop = true;
            labelOutput.AutoSize = true;
            labelOutput.BackColor = Color.FromArgb(40, 42, 54);
            labelOutput.ForeColor = Color.White;
            labelOutput.Location = new Point(272, 37);
            labelOutput.Margin = new Padding(2, 0, 2, 0);
            labelOutput.MaximumSize = new Size(280, 210);
            labelOutput.MinimumSize = new Size(280, 210);
            labelOutput.Name = "labelOutput";
            labelOutput.Padding = new Padding(7, 6, 7, 6);
            labelOutput.Size = new Size(280, 210);
            labelOutput.TabIndex = 4;
            labelOutput.Text = "...";
            labelOutput.Visible = false;
            // 
            // inputTextY
            // 
            inputTextY.Location = new Point(60, 100);
            inputTextY.Margin = new Padding(2);
            inputTextY.Name = "inputTextY";
            inputTextY.Size = new Size(84, 23);
            inputTextY.TabIndex = 2;
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelX.ForeColor = Color.Coral;
            labelX.Location = new Point(22, 56);
            labelX.Margin = new Padding(2, 0, 2, 0);
            labelX.Name = "labelX";
            labelX.Size = new Size(33, 30);
            labelX.TabIndex = 5;
            labelX.Text = "X:";
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelY.ForeColor = Color.Coral;
            labelY.Location = new Point(22, 92);
            labelY.Margin = new Padding(2, 0, 2, 0);
            labelY.Name = "labelY";
            labelY.Size = new Size(32, 30);
            labelY.TabIndex = 6;
            labelY.Text = "Y:";
            // 
            // labelTitleResult
            // 
            labelTitleResult.AutoSize = true;
            labelTitleResult.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitleResult.ForeColor = Color.Coral;
            labelTitleResult.Location = new Point(375, 5);
            labelTitleResult.Margin = new Padding(2, 0, 2, 0);
            labelTitleResult.Name = "labelTitleResult";
            labelTitleResult.Size = new Size(76, 30);
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
            btnSoma.Location = new Point(22, 143);
            btnSoma.Margin = new Padding(2);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(43, 38);
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
            btnSub.Location = new Point(84, 143);
            btnSub.Margin = new Padding(2);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(43, 38);
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
            btnMult.Location = new Point(145, 143);
            btnMult.Margin = new Padding(2);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(43, 38);
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
            btnDiv.Location = new Point(22, 185);
            btnDiv.Margin = new Padding(2);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(43, 38);
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
            btnQuad.Location = new Point(84, 185);
            btnQuad.Margin = new Padding(2);
            btnQuad.Name = "btnQuad";
            btnQuad.Size = new Size(43, 38);
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
            btnRaiz.Location = new Point(145, 185);
            btnRaiz.Margin = new Padding(2);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(43, 38);
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
            btnMod.Location = new Point(22, 227);
            btnMod.Margin = new Padding(2);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(43, 38);
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
            button1.Location = new Point(84, 227);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(43, 38);
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
            button2.Location = new Point(145, 227);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(43, 38);
            button2.TabIndex = 16;
            button2.Text = "x^y";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnElev_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 83, 102);
            ClientSize = new Size(560, 270);
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
            Margin = new Padding(2);
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
    }
}
