
namespace Notebook
{
    partial class SearchForm
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
            this.label_find = new System.Windows.Forms.Label();
            this.label_replace = new System.Windows.Forms.Label();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.cbReg = new System.Windows.Forms.CheckBox();
            this.btFind = new System.Windows.Forms.Button();
            this.btReplace = new System.Windows.Forms.Button();
            this.btReplaceAll = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_find
            // 
            this.label_find.AutoSize = true;
            this.label_find.Location = new System.Drawing.Point(12, 34);
            this.label_find.Name = "label_find";
            this.label_find.Size = new System.Drawing.Size(41, 13);
            this.label_find.TabIndex = 0;
            this.label_find.Text = "Найти:";
            // 
            // label_replace
            // 
            this.label_replace.AutoSize = true;
            this.label_replace.Location = new System.Drawing.Point(12, 62);
            this.label_replace.Name = "label_replace";
            this.label_replace.Size = new System.Drawing.Size(75, 13);
            this.label_replace.TabIndex = 1;
            this.label_replace.Text = "Заменить на:";
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(93, 31);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(260, 20);
            this.tbFind.TabIndex = 2;
            // 
            // tbReplace
            // 
            this.tbReplace.Location = new System.Drawing.Point(93, 59);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(260, 20);
            this.tbReplace.TabIndex = 3;
            this.tbReplace.TextChanged += new System.EventHandler(this.tbReplace_TextChanged);
            // 
            // cbReg
            // 
            this.cbReg.AutoSize = true;
            this.cbReg.Location = new System.Drawing.Point(15, 87);
            this.cbReg.Name = "cbReg";
            this.cbReg.Size = new System.Drawing.Size(124, 17);
            this.cbReg.TabIndex = 4;
            this.cbReg.Text = "Учитывать регистр";
            this.cbReg.UseVisualStyleBackColor = true;
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(15, 110);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(83, 23);
            this.btFind.TabIndex = 5;
            this.btFind.Text = "Найти далее";
            this.btFind.UseVisualStyleBackColor = true;
            // 
            // btReplace
            // 
            this.btReplace.Location = new System.Drawing.Point(104, 110);
            this.btReplace.Name = "btReplace";
            this.btReplace.Size = new System.Drawing.Size(75, 23);
            this.btReplace.TabIndex = 6;
            this.btReplace.Text = "Заменить";
            this.btReplace.UseVisualStyleBackColor = true;
            // 
            // btReplaceAll
            // 
            this.btReplaceAll.Location = new System.Drawing.Point(185, 110);
            this.btReplaceAll.Name = "btReplaceAll";
            this.btReplaceAll.Size = new System.Drawing.Size(87, 23);
            this.btReplaceAll.TabIndex = 7;
            this.btReplaceAll.Text = "Заменить всё";
            this.btReplaceAll.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(278, 110);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 167);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btReplaceAll);
            this.Controls.Add(this.btReplace);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.cbReg);
            this.Controls.Add(this.tbReplace);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.label_replace);
            this.Controls.Add(this.label_find);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Найти и заменить";
            this.TopMost = true;

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_find;
        private System.Windows.Forms.Label label_replace;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.TextBox tbReplace;
        private System.Windows.Forms.CheckBox cbReg;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Button btReplace;
        private System.Windows.Forms.Button btReplaceAll;
        private System.Windows.Forms.Button btCancel;
    }
}