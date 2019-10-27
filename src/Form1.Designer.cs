namespace simple_calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.formulaDisplayArea = new System.Windows.Forms.Label();
            this.resultDisplayArea = new System.Windows.Forms.TextBox();
            this.CEButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.backSpaceButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.multiButton = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.sumButton = new System.Windows.Forms.Button();
            this.signToggleButton = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.decimalPointButton = new System.Windows.Forms.Button();
            this.resultDisplayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // formulaDisplayArea
            // 
            this.formulaDisplayArea.AutoSize = true;
            this.formulaDisplayArea.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.formulaDisplayArea.ForeColor = System.Drawing.SystemColors.Control;
            this.formulaDisplayArea.Location = new System.Drawing.Point(314, 22);
            this.formulaDisplayArea.Name = "formulaDisplayArea";
            this.formulaDisplayArea.Size = new System.Drawing.Size(60, 15);
            this.formulaDisplayArea.TabIndex = 0;
            this.formulaDisplayArea.Text = "0+1-3*4/5";
            this.formulaDisplayArea.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // resultDisplayArea
            // 
            this.resultDisplayArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.resultDisplayArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultDisplayArea.Cursor = System.Windows.Forms.Cursors.Default;
            this.resultDisplayArea.Enabled = false;
            this.resultDisplayArea.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.resultDisplayArea.ForeColor = System.Drawing.SystemColors.Window;
            this.resultDisplayArea.Location = new System.Drawing.Point(12, 40);
            this.resultDisplayArea.Name = "resultDisplayArea";
            this.resultDisplayArea.ReadOnly = true;
            this.resultDisplayArea.Size = new System.Drawing.Size(282, 54);
            this.resultDisplayArea.TabIndex = 2;
            this.resultDisplayArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CEButton
            // 
            this.CEButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CEButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CEButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CEButton.Location = new System.Drawing.Point(12, 106);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(66, 43);
            this.CEButton.TabIndex = 3;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // CButton
            // 
            this.CButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CButton.Location = new System.Drawing.Point(84, 106);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(66, 43);
            this.CButton.TabIndex = 4;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // backSpaceButton
            // 
            this.backSpaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backSpaceButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.backSpaceButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.backSpaceButton.Location = new System.Drawing.Point(156, 106);
            this.backSpaceButton.Name = "backSpaceButton";
            this.backSpaceButton.Size = new System.Drawing.Size(66, 43);
            this.backSpaceButton.TabIndex = 5;
            this.backSpaceButton.Text = "→";
            this.backSpaceButton.UseVisualStyleBackColor = true;
            this.backSpaceButton.Click += new System.EventHandler(this.backSpaceButton_Click);
            // 
            // divButton
            // 
            this.divButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.divButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.divButton.Location = new System.Drawing.Point(228, 106);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(66, 43);
            this.divButton.TabIndex = 6;
            this.divButton.Text = "÷";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.divButton_Click);
            // 
            // multiButton
            // 
            this.multiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.multiButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.multiButton.Location = new System.Drawing.Point(228, 155);
            this.multiButton.Name = "multiButton";
            this.multiButton.Size = new System.Drawing.Size(66, 43);
            this.multiButton.TabIndex = 7;
            this.multiButton.Text = "×";
            this.multiButton.UseVisualStyleBackColor = true;
            this.multiButton.Click += new System.EventHandler(this.multiButton_Click);
            // 
            // minButton
            // 
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.minButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minButton.Location = new System.Drawing.Point(228, 204);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(66, 43);
            this.minButton.TabIndex = 8;
            this.minButton.Text = "ー";
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(12, 155);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(66, 43);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(84, 155);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(66, 43);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Location = new System.Drawing.Point(156, 155);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(66, 43);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(12, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 43);
            this.button4.TabIndex = 12;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(84, 204);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 43);
            this.button5.TabIndex = 13;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(156, 204);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 43);
            this.button6.TabIndex = 14;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(12, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 43);
            this.button1.TabIndex = 15;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(84, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 43);
            this.button2.TabIndex = 16;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(156, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 43);
            this.button3.TabIndex = 17;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sumButton
            // 
            this.sumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sumButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sumButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sumButton.Location = new System.Drawing.Point(228, 253);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(66, 43);
            this.sumButton.TabIndex = 18;
            this.sumButton.Text = "＋";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // signToggleButton
            // 
            this.signToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signToggleButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.signToggleButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signToggleButton.Location = new System.Drawing.Point(12, 302);
            this.signToggleButton.Name = "signToggleButton";
            this.signToggleButton.Size = new System.Drawing.Size(66, 43);
            this.signToggleButton.TabIndex = 19;
            this.signToggleButton.Text = "+/-";
            this.signToggleButton.UseVisualStyleBackColor = true;
            this.signToggleButton.Click += new System.EventHandler(this.signToggleButton_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button17.Location = new System.Drawing.Point(84, 302);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(66, 43);
            this.button17.TabIndex = 20;
            this.button17.Text = "CE";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // decimalPointButton
            // 
            this.decimalPointButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decimalPointButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.decimalPointButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.decimalPointButton.Location = new System.Drawing.Point(156, 302);
            this.decimalPointButton.Name = "decimalPointButton";
            this.decimalPointButton.Size = new System.Drawing.Size(66, 43);
            this.decimalPointButton.TabIndex = 21;
            this.decimalPointButton.Text = "．";
            this.decimalPointButton.UseVisualStyleBackColor = true;
            this.decimalPointButton.Click += new System.EventHandler(this.decimalPointButton_Click);
            // 
            // resultDisplayButton
            // 
            this.resultDisplayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultDisplayButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.resultDisplayButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.resultDisplayButton.Location = new System.Drawing.Point(228, 302);
            this.resultDisplayButton.Name = "resultDisplayButton";
            this.resultDisplayButton.Size = new System.Drawing.Size(66, 43);
            this.resultDisplayButton.TabIndex = 22;
            this.resultDisplayButton.Text = "＝";
            this.resultDisplayButton.UseVisualStyleBackColor = true;
            this.resultDisplayButton.Click += new System.EventHandler(this.resultDisplayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(305, 354);
            this.Controls.Add(this.resultDisplayButton);
            this.Controls.Add(this.decimalPointButton);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.signToggleButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.multiButton);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.backSpaceButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.CEButton);
            this.Controls.Add(this.resultDisplayArea);
            this.Name = "Form1";
            this.Text = "simple calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formulaDisplayArea;
        private System.Windows.Forms.TextBox resultDisplayArea;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button backSpaceButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button multiButton;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button signToggleButton;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button decimalPointButton;
        private System.Windows.Forms.Button resultDisplayButton;
    }
}

