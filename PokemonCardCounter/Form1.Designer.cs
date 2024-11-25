namespace PokemonCardCounter
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
            openFileButton = new Button();
            gen1Card = new PictureBox();
            gen2Card = new PictureBox();
            gen3Card = new PictureBox();
            gen4Card = new PictureBox();
            gen5Card = new PictureBox();
            gen6Card = new PictureBox();
            gen7Card = new PictureBox();
            gen8Card = new PictureBox();
            gen9Card = new PictureBox();
            textGen1 = new TextBox();
            textGen2 = new TextBox();
            textGen9 = new TextBox();
            textGen8 = new TextBox();
            textGen7 = new TextBox();
            textGen6 = new TextBox();
            textGen5 = new TextBox();
            textGen4 = new TextBox();
            textGen3 = new TextBox();
            welcomeText = new TextBox();
            totalText = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)gen1Card).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gen2Card).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gen3Card).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gen4Card).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gen5Card).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gen6Card).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gen7Card).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gen8Card).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gen9Card).BeginInit();
            SuspendLayout();
            // 
            // openFileButton
            // 
            openFileButton.Location = new Point(670, 438);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(75, 23);
            openFileButton.TabIndex = 0;
            openFileButton.Text = "Open File";
            openFileButton.UseVisualStyleBackColor = true;
            openFileButton.Click += openFileButton_Click;
            // 
            // gen1Card
            // 
            gen1Card.Image = Properties.Resources.Lapras;
            gen1Card.Location = new Point(-2, 61);
            gen1Card.Name = "gen1Card";
            gen1Card.Size = new Size(249, 347);
            gen1Card.TabIndex = 1;
            gen1Card.TabStop = false;
            // 
            // gen2Card
            // 
            gen2Card.Image = Properties.Resources.Kingdra;
            gen2Card.Location = new Point(266, 61);
            gen2Card.Name = "gen2Card";
            gen2Card.Size = new Size(245, 341);
            gen2Card.TabIndex = 2;
            gen2Card.TabStop = false;
            // 
            // gen3Card
            // 
            gen3Card.Image = Properties.Resources.Mudkip;
            gen3Card.Location = new Point(533, 61);
            gen3Card.Name = "gen3Card";
            gen3Card.Size = new Size(243, 341);
            gen3Card.TabIndex = 3;
            gen3Card.TabStop = false;
            // 
            // gen4Card
            // 
            gen4Card.Image = Properties.Resources.Darkrai;
            gen4Card.Location = new Point(797, 61);
            gen4Card.Name = "gen4Card";
            gen4Card.Size = new Size(250, 347);
            gen4Card.TabIndex = 4;
            gen4Card.TabStop = false;
            // 
            // gen5Card
            // 
            gen5Card.Image = Properties.Resources.Golurk;
            gen5Card.Location = new Point(1069, 61);
            gen5Card.Name = "gen5Card";
            gen5Card.Size = new Size(251, 341);
            gen5Card.TabIndex = 5;
            gen5Card.TabStop = false;
            // 
            // gen6Card
            // 
            gen6Card.Image = Properties.Resources.Yveltal;
            gen6Card.Location = new Point(3, 465);
            gen6Card.Name = "gen6Card";
            gen6Card.Size = new Size(244, 349);
            gen6Card.TabIndex = 6;
            gen6Card.TabStop = false;
            // 
            // gen7Card
            // 
            gen7Card.Image = Properties.Resources.Melmetal;
            gen7Card.Location = new Point(266, 465);
            gen7Card.Name = "gen7Card";
            gen7Card.Size = new Size(252, 349);
            gen7Card.TabIndex = 7;
            gen7Card.TabStop = false;
            // 
            // gen8Card
            // 
            gen8Card.Image = Properties.Resources.Dragapult;
            gen8Card.Location = new Point(534, 465);
            gen8Card.Name = "gen8Card";
            gen8Card.Size = new Size(242, 349);
            gen8Card.TabIndex = 8;
            gen8Card.TabStop = false;
            // 
            // gen9Card
            // 
            gen9Card.Image = Properties.Resources.Ceruledge;
            gen9Card.Location = new Point(797, 465);
            gen9Card.Name = "gen9Card";
            gen9Card.Size = new Size(250, 349);
            gen9Card.TabIndex = 9;
            gen9Card.TabStop = false;
            // 
            // textGen1
            // 
            textGen1.BackColor = Color.White;
            textGen1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textGen1.Location = new Point(32, 28);
            textGen1.Name = "textGen1";
            textGen1.ReadOnly = true;
            textGen1.Size = new Size(186, 23);
            textGen1.TabIndex = 10;
            textGen1.TextAlign = HorizontalAlignment.Center;
            // 
            // textGen2
            // 
            textGen2.BackColor = Color.White;
            textGen2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textGen2.Location = new Point(299, 28);
            textGen2.Name = "textGen2";
            textGen2.ReadOnly = true;
            textGen2.Size = new Size(186, 23);
            textGen2.TabIndex = 11;
            textGen2.TextAlign = HorizontalAlignment.Center;
            // 
            // textGen9
            // 
            textGen9.BackColor = Color.White;
            textGen9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textGen9.Location = new Point(825, 431);
            textGen9.Name = "textGen9";
            textGen9.ReadOnly = true;
            textGen9.Size = new Size(186, 23);
            textGen9.TabIndex = 12;
            textGen9.TextAlign = HorizontalAlignment.Center;
            // 
            // textGen8
            // 
            textGen8.BackColor = Color.White;
            textGen8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textGen8.Location = new Point(562, 431);
            textGen8.Name = "textGen8";
            textGen8.ReadOnly = true;
            textGen8.Size = new Size(186, 23);
            textGen8.TabIndex = 13;
            textGen8.TextAlign = HorizontalAlignment.Center;
            // 
            // textGen7
            // 
            textGen7.BackColor = Color.White;
            textGen7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textGen7.Location = new Point(299, 432);
            textGen7.Name = "textGen7";
            textGen7.ReadOnly = true;
            textGen7.Size = new Size(186, 23);
            textGen7.TabIndex = 14;
            textGen7.TextAlign = HorizontalAlignment.Center;
            // 
            // textGen6
            // 
            textGen6.BackColor = Color.White;
            textGen6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textGen6.Location = new Point(32, 432);
            textGen6.Name = "textGen6";
            textGen6.ReadOnly = true;
            textGen6.Size = new Size(186, 23);
            textGen6.TabIndex = 15;
            textGen6.TextAlign = HorizontalAlignment.Center;
            // 
            // textGen5
            // 
            textGen5.BackColor = Color.White;
            textGen5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textGen5.Location = new Point(1099, 28);
            textGen5.Name = "textGen5";
            textGen5.ReadOnly = true;
            textGen5.Size = new Size(186, 23);
            textGen5.TabIndex = 16;
            textGen5.TextAlign = HorizontalAlignment.Center;
            // 
            // textGen4
            // 
            textGen4.BackColor = Color.White;
            textGen4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textGen4.Location = new Point(825, 28);
            textGen4.Name = "textGen4";
            textGen4.ReadOnly = true;
            textGen4.Size = new Size(186, 23);
            textGen4.TabIndex = 17;
            textGen4.TextAlign = HorizontalAlignment.Center;
            // 
            // textGen3
            // 
            textGen3.BackColor = Color.White;
            textGen3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textGen3.Location = new Point(562, 28);
            textGen3.Name = "textGen3";
            textGen3.ReadOnly = true;
            textGen3.Size = new Size(186, 23);
            textGen3.TabIndex = 18;
            textGen3.TextAlign = HorizontalAlignment.Center;
            // 
            // welcomeText
            // 
            welcomeText.BackColor = Color.White;
            welcomeText.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            welcomeText.ForeColor = Color.Red;
            welcomeText.Location = new Point(1068, 465);
            welcomeText.Name = "welcomeText";
            welcomeText.ReadOnly = true;
            welcomeText.Size = new Size(322, 27);
            welcomeText.TabIndex = 19;
            welcomeText.Text = "Welcome to Logan's Pokemon Card Counter!";
            // 
            // totalText
            // 
            totalText.BackColor = Color.White;
            totalText.Font = new Font("Times New Roman", 13F);
            totalText.ForeColor = Color.SteelBlue;
            totalText.Location = new Point(1069, 509);
            totalText.Name = "totalText";
            totalText.ReadOnly = true;
            totalText.Size = new Size(321, 305);
            totalText.TabIndex = 21;
            totalText.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1402, 926);
            Controls.Add(totalText);
            Controls.Add(welcomeText);
            Controls.Add(openFileButton);
            Controls.Add(textGen3);
            Controls.Add(textGen4);
            Controls.Add(textGen5);
            Controls.Add(textGen6);
            Controls.Add(textGen7);
            Controls.Add(textGen8);
            Controls.Add(textGen9);
            Controls.Add(textGen2);
            Controls.Add(textGen1);
            Controls.Add(gen9Card);
            Controls.Add(gen8Card);
            Controls.Add(gen7Card);
            Controls.Add(gen6Card);
            Controls.Add(gen5Card);
            Controls.Add(gen4Card);
            Controls.Add(gen3Card);
            Controls.Add(gen2Card);
            Controls.Add(gen1Card);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gen1Card).EndInit();
            ((System.ComponentModel.ISupportInitialize)gen2Card).EndInit();
            ((System.ComponentModel.ISupportInitialize)gen3Card).EndInit();
            ((System.ComponentModel.ISupportInitialize)gen4Card).EndInit();
            ((System.ComponentModel.ISupportInitialize)gen5Card).EndInit();
            ((System.ComponentModel.ISupportInitialize)gen6Card).EndInit();
            ((System.ComponentModel.ISupportInitialize)gen7Card).EndInit();
            ((System.ComponentModel.ISupportInitialize)gen8Card).EndInit();
            ((System.ComponentModel.ISupportInitialize)gen9Card).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button openFileButton;
        private PictureBox gen1Card;
        private PictureBox gen2Card;
        private PictureBox gen3Card;
        private PictureBox gen4Card;
        private PictureBox gen5Card;
        private PictureBox gen6Card;
        private PictureBox gen7Card;
        private PictureBox gen8Card;
        private PictureBox gen9Card;
        private TextBox textGen1;
        private TextBox textGen2;
        private TextBox textGen9;
        private TextBox textGen8;
        private TextBox textGen7;
        private TextBox textGen6;
        private TextBox textGen5;
        private TextBox textGen4;
        private TextBox textGen3;
        private TextBox welcomeText;
        private RichTextBox totalText;
    }
}
