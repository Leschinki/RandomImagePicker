namespace RandomImagePicker
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_target = new System.Windows.Forms.Button();
            this.lbl_source = new System.Windows.Forms.Label();
            this.lbl_target = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.txb_chance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quelle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ziel";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(12, 29);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 2;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_target
            // 
            this.btn_target.Location = new System.Drawing.Point(145, 29);
            this.btn_target.Name = "btn_target";
            this.btn_target.Size = new System.Drawing.Size(75, 23);
            this.btn_target.TabIndex = 3;
            this.btn_target.Text = "Select";
            this.btn_target.UseVisualStyleBackColor = true;
            this.btn_target.Click += new System.EventHandler(this.btn_target_Click);
            // 
            // lbl_source
            // 
            this.lbl_source.AutoSize = true;
            this.lbl_source.Location = new System.Drawing.Point(251, 13);
            this.lbl_source.Name = "lbl_source";
            this.lbl_source.Size = new System.Drawing.Size(37, 13);
            this.lbl_source.TabIndex = 4;
            this.lbl_source.Text = "Quelle";
            // 
            // lbl_target
            // 
            this.lbl_target.AutoSize = true;
            this.lbl_target.Location = new System.Drawing.Point(251, 34);
            this.lbl_target.Name = "lbl_target";
            this.lbl_target.Size = new System.Drawing.Size(24, 13);
            this.lbl_target.TabIndex = 5;
            this.lbl_target.Text = "Ziel";
            // 
            // btn_start
            // 
            this.btn_start.Enabled = false;
            this.btn_start.Location = new System.Drawing.Point(12, 105);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(607, 42);
            this.btn_start.TabIndex = 6;
            this.btn_start.Text = "GO";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_chance
            // 
            this.txb_chance.Location = new System.Drawing.Point(75, 79);
            this.txb_chance.Name = "lbl_chance";
            this.txb_chance.Size = new System.Drawing.Size(100, 20);
            this.txb_chance.TabIndex = 7;
            this.txb_chance.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Chance 1:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 155);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_chance);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_target);
            this.Controls.Add(this.lbl_source);
            this.Controls.Add(this.btn_target);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_target;
        private System.Windows.Forms.Label lbl_source;
        private System.Windows.Forms.Label lbl_target;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox txb_chance;
        private System.Windows.Forms.Label label3;
    }
}

