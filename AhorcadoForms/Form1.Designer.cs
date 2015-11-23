namespace AhorcadoForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelInputWord = new System.Windows.Forms.Label();
            this.buttonInputWord = new System.Windows.Forms.Button();
            this.textBoxInputWord = new System.Windows.Forms.TextBox();
            this.labelHiddenWord = new System.Windows.Forms.Label();
            this.labelInputChar = new System.Windows.Forms.Label();
            this.textBoxInputChar = new System.Windows.Forms.TextBox();
            this.buttonInputChar = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInputWord
            // 
            this.labelInputWord.AutoSize = true;
            this.labelInputWord.Location = new System.Drawing.Point(12, 14);
            this.labelInputWord.Name = "labelInputWord";
            this.labelInputWord.Size = new System.Drawing.Size(91, 13);
            this.labelInputWord.TabIndex = 0;
            this.labelInputWord.Text = "Introduce Palabra";
            // 
            // buttonInputWord
            // 
            this.buttonInputWord.Location = new System.Drawing.Point(216, 12);
            this.buttonInputWord.Name = "buttonInputWord";
            this.buttonInputWord.Size = new System.Drawing.Size(123, 23);
            this.buttonInputWord.TabIndex = 1;
            this.buttonInputWord.Text = "Introducir palabra";
            this.buttonInputWord.UseVisualStyleBackColor = true;
            this.buttonInputWord.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxInputWord
            // 
            this.textBoxInputWord.Location = new System.Drawing.Point(110, 12);
            this.textBoxInputWord.Name = "textBoxInputWord";
            this.textBoxInputWord.Size = new System.Drawing.Size(100, 20);
            this.textBoxInputWord.TabIndex = 2;
            // 
            // labelHiddenWord
            // 
            this.labelHiddenWord.AutoSize = true;
            this.labelHiddenWord.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHiddenWord.Location = new System.Drawing.Point(506, 14);
            this.labelHiddenWord.Name = "labelHiddenWord";
            this.labelHiddenWord.Size = new System.Drawing.Size(579, 90);
            this.labelHiddenWord.TabIndex = 3;
            this.labelHiddenWord.Text = "Introduce Palabra";
            // 
            // labelInputChar
            // 
            this.labelInputChar.AutoSize = true;
            this.labelInputChar.Location = new System.Drawing.Point(12, 51);
            this.labelInputChar.Name = "labelInputChar";
            this.labelInputChar.Size = new System.Drawing.Size(75, 13);
            this.labelInputChar.TabIndex = 4;
            this.labelInputChar.Text = "Introduce letra";
            // 
            // textBoxInputChar
            // 
            this.textBoxInputChar.Location = new System.Drawing.Point(110, 51);
            this.textBoxInputChar.MaxLength = 1;
            this.textBoxInputChar.Name = "textBoxInputChar";
            this.textBoxInputChar.Size = new System.Drawing.Size(100, 20);
            this.textBoxInputChar.TabIndex = 5;
            // 
            // buttonInputChar
            // 
            this.buttonInputChar.Location = new System.Drawing.Point(217, 47);
            this.buttonInputChar.Name = "buttonInputChar";
            this.buttonInputChar.Size = new System.Drawing.Size(122, 23);
            this.buttonInputChar.TabIndex = 6;
            this.buttonInputChar.Text = "Introducir letra";
            this.buttonInputChar.UseVisualStyleBackColor = true;
            this.buttonInputChar.Click += new System.EventHandler(this.buttonInputChar_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::AhorcadoForms.Properties.Resources.ahorcado_1;
            this.pictureBox.InitialImage = global::AhorcadoForms.Properties.Resources.ahorcado_1;
            this.pictureBox.Location = new System.Drawing.Point(673, 107);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(320, 328);
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 452);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonInputChar);
            this.Controls.Add(this.textBoxInputChar);
            this.Controls.Add(this.labelInputChar);
            this.Controls.Add(this.labelHiddenWord);
            this.Controls.Add(this.textBoxInputWord);
            this.Controls.Add(this.buttonInputWord);
            this.Controls.Add(this.labelInputWord);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInputWord;
        private System.Windows.Forms.Button buttonInputWord;
        private System.Windows.Forms.TextBox textBoxInputWord;
        private System.Windows.Forms.Label labelHiddenWord;
        private System.Windows.Forms.Label labelInputChar;
        private System.Windows.Forms.TextBox textBoxInputChar;
        private System.Windows.Forms.Button buttonInputChar;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

