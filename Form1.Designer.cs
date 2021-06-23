
namespace Riceshower
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_translation_submit = new System.Windows.Forms.Button();
            this.btn_proofreading_submit = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.lbl_directory = new System.Windows.Forms.Label();
            this.lbl_text_num = new System.Windows.Forms.Label();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(533, 19);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(49, 250);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(533, 19);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(49, 406);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(533, 19);
            this.textBox3.TabIndex = 2;
            // 
            // btn_translation_submit
            // 
            this.btn_translation_submit.Location = new System.Drawing.Point(741, 236);
            this.btn_translation_submit.Name = "btn_translation_submit";
            this.btn_translation_submit.Size = new System.Drawing.Size(160, 47);
            this.btn_translation_submit.TabIndex = 3;
            this.btn_translation_submit.Text = "Translation Submit";
            this.btn_translation_submit.UseVisualStyleBackColor = true;
            this.btn_translation_submit.Click += new System.EventHandler(this.btn_translation_submit_Click);
            // 
            // btn_proofreading_submit
            // 
            this.btn_proofreading_submit.Location = new System.Drawing.Point(741, 386);
            this.btn_proofreading_submit.Name = "btn_proofreading_submit";
            this.btn_proofreading_submit.Size = new System.Drawing.Size(159, 45);
            this.btn_proofreading_submit.TabIndex = 4;
            this.btn_proofreading_submit.Text = "Proofreading Submit";
            this.btn_proofreading_submit.UseVisualStyleBackColor = true;
            this.btn_proofreading_submit.Click += new System.EventHandler(this.btn_proofreading_submit_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(679, 54);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(101, 74);
            this.btn_load.TabIndex = 5;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // lbl_directory
            // 
            this.lbl_directory.AutoSize = true;
            this.lbl_directory.Location = new System.Drawing.Point(677, 161);
            this.lbl_directory.Name = "lbl_directory";
            this.lbl_directory.Size = new System.Drawing.Size(35, 12);
            this.lbl_directory.TabIndex = 6;
            this.lbl_directory.Text = "label1";
            // 
            // lbl_text_num
            // 
            this.lbl_text_num.AutoSize = true;
            this.lbl_text_num.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.lbl_text_num.Location = new System.Drawing.Point(49, 54);
            this.lbl_text_num.Name = "lbl_text_num";
            this.lbl_text_num.Size = new System.Drawing.Size(78, 27);
            this.lbl_text_num.TabIndex = 7;
            this.lbl_text_num.Text = "label1";
            // 
            // btn_previous
            // 
            this.btn_previous.Location = new System.Drawing.Point(108, 159);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(100, 50);
            this.btn_previous.TabIndex = 8;
            this.btn_previous.Text = "Previous";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(372, 159);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(96, 49);
            this.btn_next.TabIndex = 9;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(861, 54);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(101, 74);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 519);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.lbl_text_num);
            this.Controls.Add(this.lbl_directory);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_proofreading_submit);
            this.Controls.Add(this.btn_translation_submit);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_translation_submit;
        private System.Windows.Forms.Button btn_proofreading_submit;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label lbl_directory;
        private System.Windows.Forms.Label lbl_text_num;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_save;
    }
}

