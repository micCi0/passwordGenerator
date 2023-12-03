namespace PasswordGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.Label();
            this.lowerCaseCheck = new System.Windows.Forms.CheckBox();
            this.upperCaseCheck = new System.Windows.Forms.CheckBox();
            this.numberCheck = new System.Windows.Forms.CheckBox();
            this.symbolsCheck = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelResult = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(61, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Generator";
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(91, 196);
            this.trackBar.Maximum = 20;
            this.trackBar.Minimum = 4;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(327, 69);
            this.trackBar.TabIndex = 1;
            this.trackBar.Value = 8;
            this.trackBar.Enter += new System.EventHandler(this.ChangeLength);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Options";
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.Location = new System.Drawing.Point(415, 205);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(18, 20);
            this.length.TabIndex = 3;
            this.length.Text = "0";
            // 
            // lowerCaseCheck
            // 
            this.lowerCaseCheck.AutoSize = true;
            this.lowerCaseCheck.Location = new System.Drawing.Point(29, 249);
            this.lowerCaseCheck.Name = "lowerCaseCheck";
            this.lowerCaseCheck.Size = new System.Drawing.Size(112, 24);
            this.lowerCaseCheck.TabIndex = 4;
            this.lowerCaseCheck.Text = "Lowercase";
            this.lowerCaseCheck.UseVisualStyleBackColor = true;
            // 
            // upperCaseCheck
            // 
            this.upperCaseCheck.AutoSize = true;
            this.upperCaseCheck.Location = new System.Drawing.Point(166, 249);
            this.upperCaseCheck.Name = "upperCaseCheck";
            this.upperCaseCheck.Size = new System.Drawing.Size(113, 24);
            this.upperCaseCheck.TabIndex = 5;
            this.upperCaseCheck.Text = "Uppercase";
            this.upperCaseCheck.UseVisualStyleBackColor = true;
            // 
            // numberCheck
            // 
            this.numberCheck.AutoSize = true;
            this.numberCheck.Location = new System.Drawing.Point(302, 249);
            this.numberCheck.Name = "numberCheck";
            this.numberCheck.Size = new System.Drawing.Size(99, 24);
            this.numberCheck.TabIndex = 6;
            this.numberCheck.Text = "Numbers";
            this.numberCheck.UseVisualStyleBackColor = true;
            // 
            // symbolsCheck
            // 
            this.symbolsCheck.AutoSize = true;
            this.symbolsCheck.Location = new System.Drawing.Point(419, 249);
            this.symbolsCheck.Name = "symbolsCheck";
            this.symbolsCheck.Size = new System.Drawing.Size(95, 24);
            this.symbolsCheck.TabIndex = 7;
            this.symbolsCheck.Text = "Symbols";
            this.symbolsCheck.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(193, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.labelResult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 84);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 84);
            this.panel2.TabIndex = 10;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResult.ForeColor = System.Drawing.Color.White;
            this.labelResult.Location = new System.Drawing.Point(3, 43);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 32);
            this.labelResult.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(468, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Copy";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.CopyResult);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.symbolsCheck);
            this.Controls.Add(this.numberCheck);
            this.Controls.Add(this.upperCaseCheck);
            this.Controls.Add(this.lowerCaseCheck);
            this.Controls.Add(this.length);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.CheckBox lowerCaseCheck;
        private System.Windows.Forms.CheckBox upperCaseCheck;
        private System.Windows.Forms.CheckBox numberCheck;
        private System.Windows.Forms.CheckBox symbolsCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button button2;
    }
}

