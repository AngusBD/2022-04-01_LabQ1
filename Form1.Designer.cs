namespace Ch5PracticeQ4 {
    partial class Form1 {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
						this.components = new System.ComponentModel.Container();
						this.label1 = new System.Windows.Forms.Label();
						this.label2 = new System.Windows.Forms.Label();
						this.label3 = new System.Windows.Forms.Label();
						this.textBox1 = new System.Windows.Forms.TextBox();
						this.button1 = new System.Windows.Forms.Button();
						this.button2 = new System.Windows.Forms.Button();
						this.button3 = new System.Windows.Forms.Button();
						this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
						this.label4 = new System.Windows.Forms.Label();
						this.label5 = new System.Windows.Forms.Label();
						this.label6 = new System.Windows.Forms.Label();
						this.SuspendLayout();
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Location = new System.Drawing.Point(313, 50);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(108, 15);
						this.label1.TabIndex = 0;
						this.label1.Text = "Guess the number";
						// 
						// label2
						// 
						this.label2.AutoSize = true;
						this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
						this.label2.Location = new System.Drawing.Point(258, 152);
						this.label2.Name = "label2";
						this.label2.Size = new System.Drawing.Size(27, 20);
						this.label2.TabIndex = 1;
						this.label2.Text = "10";
						// 
						// label3
						// 
						this.label3.AutoSize = true;
						this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
						this.label3.Location = new System.Drawing.Point(441, 152);
						this.label3.Name = "label3";
						this.label3.Size = new System.Drawing.Size(36, 20);
						this.label3.TabIndex = 2;
						this.label3.Text = "100";
						// 
						// textBox1
						// 
						this.textBox1.Location = new System.Drawing.Point(316, 147);
						this.textBox1.Name = "textBox1";
						this.textBox1.Size = new System.Drawing.Size(100, 25);
						this.textBox1.TabIndex = 3;
						this.toolTip1.SetToolTip(this.textBox1, "Please enter a two-digit number");
						// 
						// button1
						// 
						this.button1.Location = new System.Drawing.Point(224, 237);
						this.button1.Name = "button1";
						this.button1.Size = new System.Drawing.Size(75, 23);
						this.button1.TabIndex = 4;
						this.button1.Text = "GO";
						this.button1.UseVisualStyleBackColor = true;
						this.button1.Click += new System.EventHandler(this.button1_Click);
						// 
						// button2
						// 
						this.button2.Location = new System.Drawing.Point(353, 237);
						this.button2.Name = "button2";
						this.button2.Size = new System.Drawing.Size(75, 23);
						this.button2.TabIndex = 5;
						this.button2.Text = "GoAgain";
						this.button2.UseVisualStyleBackColor = true;
						this.button2.Click += new System.EventHandler(this.button2_Click);
						// 
						// button3
						// 
						this.button3.Location = new System.Drawing.Point(469, 236);
						this.button3.Name = "button3";
						this.button3.Size = new System.Drawing.Size(75, 23);
						this.button3.TabIndex = 6;
						this.button3.Text = "Exit";
						this.button3.UseVisualStyleBackColor = true;
						this.button3.Click += new System.EventHandler(this.button3_Click);
						// 
						// toolTip1
						// 
						this.toolTip1.AutoPopDelay = 5000;
						this.toolTip1.InitialDelay = 50;
						this.toolTip1.ReshowDelay = 100;
						// 
						// label4
						// 
						this.label4.AutoSize = true;
						this.label4.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
						this.label4.Location = new System.Drawing.Point(288, 149);
						this.label4.Name = "label4";
						this.label4.Size = new System.Drawing.Size(22, 23);
						this.label4.TabIndex = 7;
						this.label4.Text = "<";
						// 
						// label5
						// 
						this.label5.AutoSize = true;
						this.label5.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
						this.label5.Location = new System.Drawing.Point(422, 150);
						this.label5.Name = "label5";
						this.label5.Size = new System.Drawing.Size(22, 23);
						this.label5.TabIndex = 8;
						this.label5.Text = "<";
						// 
						// label6
						// 
						this.label6.AutoSize = true;
						this.label6.Location = new System.Drawing.Point(313, 329);
						this.label6.Name = "label6";
						this.label6.Size = new System.Drawing.Size(96, 15);
						this.label6.TabIndex = 9;
						this.label6.Text = "CorrectAnswer:";
						// 
						// Form1
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(800, 450);
						this.Controls.Add(this.label6);
						this.Controls.Add(this.label5);
						this.Controls.Add(this.label4);
						this.Controls.Add(this.button3);
						this.Controls.Add(this.button2);
						this.Controls.Add(this.button1);
						this.Controls.Add(this.textBox1);
						this.Controls.Add(this.label3);
						this.Controls.Add(this.label2);
						this.Controls.Add(this.label1);
						this.Name = "Form1";
						this.Text = "Form1";
						this.Load += new System.EventHandler(this.Form1_Load);
						this.ResumeLayout(false);
						this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
				private System.Windows.Forms.Label label6;
		}
}

