
namespace Openssl
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.input = new System.Windows.Forms.RichTextBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.vector = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input.Location = new System.Drawing.Point(12, 12);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(240, 426);
            this.input.TabIndex = 0;
            this.input.Text = "";
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // output
            // 
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.output.Location = new System.Drawing.Point(548, 12);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(240, 426);
            this.output.TabIndex = 1;
            this.output.Text = "";
            // 
            // encrypt
            // 
            this.encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encrypt.Location = new System.Drawing.Point(351, 250);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(97, 36);
            this.encrypt.TabIndex = 2;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decrypt.Location = new System.Drawing.Point(351, 292);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(97, 36);
            this.decrypt.TabIndex = 3;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // vector
            // 
            this.vector.Location = new System.Drawing.Point(297, 188);
            this.vector.Name = "vector";
            this.vector.Size = new System.Drawing.Size(214, 20);
            this.vector.TabIndex = 4;
            this.vector.TextChanged += new System.EventHandler(this.vector_TextChanged);
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(297, 142);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(214, 20);
            this.key.TabIndex = 5;
            this.key.TextChanged += new System.EventHandler(this.key_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(294, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(294, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Init vector";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.key);
            this.Controls.Add(this.vector);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "OpenSSL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.TextBox vector;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

