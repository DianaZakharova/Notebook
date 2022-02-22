
namespace Notebook
{
    partial class HomeForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mFilePageParam = new System.Windows.Forms.ToolStripMenuItem();
            this.mFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditDel = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditGo = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditGiveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditTime = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mView = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewStatusStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notebox = new System.Windows.Forms.RichTextBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLab1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLinesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLab2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusWordsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLab3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCharSpaceCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLab4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCharCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.Colour = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackgroundImage = global::Notebook.Properties.Resources.e8uIS_UQe54;
            this.menuStrip.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFile,
            this.mEdit,
            this.mFormat,
            this.mView,
            this.mHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1067, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menu";
            // 
            // mFile
            // 
            this.mFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileNew,
            this.mFileOpen,
            this.mFileSave,
            this.mFileSaveAs,
            this.mFilePageParam,
            this.mFilePrint,
            this.mFileExit});
            this.mFile.Name = "mFile";
            this.mFile.Size = new System.Drawing.Size(53, 19);
            this.mFile.Text = "Файл";
            // 
            // mFileNew
            // 
            this.mFileNew.Name = "mFileNew";
            this.mFileNew.ShortcutKeyDisplayString = "Ctrl + N";
            this.mFileNew.Size = new System.Drawing.Size(265, 22);
            this.mFileNew.Text = "Создать";
            this.mFileNew.Click += new System.EventHandler(this.mFileNew_Click);
            // 
            // mFileOpen
            // 
            this.mFileOpen.Name = "mFileOpen";
            this.mFileOpen.ShortcutKeyDisplayString = "Ctrl + O";
            this.mFileOpen.Size = new System.Drawing.Size(265, 22);
            this.mFileOpen.Text = "Открыть";
            this.mFileOpen.Click += new System.EventHandler(this.mFileOpen_Click);
            // 
            // mFileSave
            // 
            this.mFileSave.Name = "mFileSave";
            this.mFileSave.ShortcutKeyDisplayString = "Ctrl + S";
            this.mFileSave.Size = new System.Drawing.Size(265, 22);
            this.mFileSave.Text = "Сохранить";
            this.mFileSave.Click += new System.EventHandler(this.mFileSave_Click);
            // 
            // mFileSaveAs
            // 
            this.mFileSaveAs.Name = "mFileSaveAs";
            this.mFileSaveAs.ShortcutKeyDisplayString = "Ctrl + Alt + S";
            this.mFileSaveAs.Size = new System.Drawing.Size(265, 22);
            this.mFileSaveAs.Text = "Сохранить как";
            this.mFileSaveAs.Click += new System.EventHandler(this.mFileSaveAs_Click);
            // 
            // mFilePageParam
            // 
            this.mFilePageParam.Name = "mFilePageParam";
            this.mFilePageParam.Size = new System.Drawing.Size(265, 22);
            this.mFilePageParam.Text = "Параметры страницы печати";
            this.mFilePageParam.Click += new System.EventHandler(this.mFilePageParam_Click);
            // 
            // mFilePrint
            // 
            this.mFilePrint.Name = "mFilePrint";
            this.mFilePrint.ShortcutKeyDisplayString = "Ctrl + P";
            this.mFilePrint.Size = new System.Drawing.Size(265, 22);
            this.mFilePrint.Text = "Печать";
            this.mFilePrint.Click += new System.EventHandler(this.mFilePrint_Click);
            // 
            // mFileExit
            // 
            this.mFileExit.Name = "mFileExit";
            this.mFileExit.ShortcutKeyDisplayString = "Alt + F4";
            this.mFileExit.Size = new System.Drawing.Size(265, 22);
            this.mFileExit.Text = "Выход";
            this.mFileExit.Click += new System.EventHandler(this.mFileExit_Click);
            // 
            // mEdit
            // 
            this.mEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEditCancel,
            this.mEditCut,
            this.mEditCopy,
            this.mEditPaste,
            this.mEditDel,
            this.mEditFind,
            this.mEditGo,
            this.mEditGiveAll,
            this.mEditTime});
            this.mEdit.Name = "mEdit";
            this.mEdit.Size = new System.Drawing.Size(66, 19);
            this.mEdit.Text = "Правка";
            // 
            // mEditCancel
            // 
            this.mEditCancel.Name = "mEditCancel";
            this.mEditCancel.ShortcutKeyDisplayString = "Ctrl + Z";
            this.mEditCancel.Size = new System.Drawing.Size(243, 22);
            this.mEditCancel.Text = "Отменить ";
            this.mEditCancel.Click += new System.EventHandler(this.mEditCancel_Click);
            // 
            // mEditCut
            // 
            this.mEditCut.Name = "mEditCut";
            this.mEditCut.ShortcutKeyDisplayString = "Ctrl + X";
            this.mEditCut.Size = new System.Drawing.Size(243, 22);
            this.mEditCut.Text = "Вырезать";
            this.mEditCut.Click += new System.EventHandler(this.mEditCut_Click);
            // 
            // mEditCopy
            // 
            this.mEditCopy.Name = "mEditCopy";
            this.mEditCopy.ShortcutKeyDisplayString = "Ctrl + C";
            this.mEditCopy.Size = new System.Drawing.Size(243, 22);
            this.mEditCopy.Text = "Копировать ";
            this.mEditCopy.Click += new System.EventHandler(this.mEditCopy_Click);
            // 
            // mEditPaste
            // 
            this.mEditPaste.Name = "mEditPaste";
            this.mEditPaste.ShortcutKeyDisplayString = "Ctrl + V";
            this.mEditPaste.Size = new System.Drawing.Size(243, 22);
            this.mEditPaste.Text = "Вставить";
            this.mEditPaste.Click += new System.EventHandler(this.mEditPaste_Click);
            // 
            // mEditDel
            // 
            this.mEditDel.Name = "mEditDel";
            this.mEditDel.ShortcutKeyDisplayString = "Del";
            this.mEditDel.Size = new System.Drawing.Size(243, 22);
            this.mEditDel.Text = "Удалить";
            this.mEditDel.Click += new System.EventHandler(this.mEditDel_Click);
            // 
            // mEditFind
            // 
            this.mEditFind.Name = "mEditFind";
            this.mEditFind.ShortcutKeyDisplayString = "Ctrl + F";
            this.mEditFind.Size = new System.Drawing.Size(243, 22);
            this.mEditFind.Text = "Найти и заменить";
            this.mEditFind.Click += new System.EventHandler(this.mEditFind_Click);
            // 
            // mEditGo
            // 
            this.mEditGo.Name = "mEditGo";
            this.mEditGo.ShortcutKeyDisplayString = "Ctrl + G";
            this.mEditGo.Size = new System.Drawing.Size(243, 22);
            this.mEditGo.Text = "Перейти";
            this.mEditGo.Click += new System.EventHandler(this.mEditGo_Click);
            // 
            // mEditGiveAll
            // 
            this.mEditGiveAll.Name = "mEditGiveAll";
            this.mEditGiveAll.ShortcutKeyDisplayString = "Ctrl + A";
            this.mEditGiveAll.Size = new System.Drawing.Size(243, 22);
            this.mEditGiveAll.Text = "Выделить всё";
            this.mEditGiveAll.Click += new System.EventHandler(this.mEditGiveAll_Click);
            // 
            // mEditTime
            // 
            this.mEditTime.Name = "mEditTime";
            this.mEditTime.ShortcutKeyDisplayString = "F5";
            this.mEditTime.Size = new System.Drawing.Size(243, 22);
            this.mEditTime.Text = "Время и дата";
            this.mEditTime.Click += new System.EventHandler(this.mEditTime_Click);
            // 
            // mFormat
            // 
            this.mFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFormatTransfer,
            this.mFormatFont,
            this.Colour});
            this.mFormat.Name = "mFormat";
            this.mFormat.Size = new System.Drawing.Size(69, 19);
            this.mFormat.Text = "Формат";
            this.mFormat.CheckStateChanged += new System.EventHandler(this.mFormat_CheckStateChanged);
            // 
            // mFormatTransfer
            // 
            this.mFormatTransfer.CheckOnClick = true;
            this.mFormatTransfer.Name = "mFormatTransfer";
            this.mFormatTransfer.Size = new System.Drawing.Size(197, 22);
            this.mFormatTransfer.Text = "Перенос по словам";
            // 
            // mFormatFont
            // 
            this.mFormatFont.Name = "mFormatFont";
            this.mFormatFont.Size = new System.Drawing.Size(197, 22);
            this.mFormatFont.Text = "Шрифт";
            this.mFormatFont.Click += new System.EventHandler(this.mFormatFont_Click);
            // 
            // mView
            // 
            this.mView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mViewStatusStrip});
            this.mView.Name = "mView";
            this.mView.Size = new System.Drawing.Size(43, 19);
            this.mView.Text = "Вид";
            // 
            // mViewStatusStrip
            // 
            this.mViewStatusStrip.Checked = true;
            this.mViewStatusStrip.CheckOnClick = true;
            this.mViewStatusStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mViewStatusStrip.Name = "mViewStatusStrip";
            this.mViewStatusStrip.Size = new System.Drawing.Size(190, 22);
            this.mViewStatusStrip.Text = "Строка состояния";
            this.mViewStatusStrip.CheckStateChanged += new System.EventHandler(this.mViewStatusStrip_CheckStateChanged);
            this.mViewStatusStrip.Click += new System.EventHandler(this.mViewStatusStrip_Click);
            // 
            // mHelp
            // 
            this.mHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.mHelp.Name = "mHelp";
            this.mHelp.Size = new System.Drawing.Size(74, 19);
            this.mHelp.Text = "Справка";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ToolStripMenuItem.Text = "О программе";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // notebox
            // 
            this.notebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notebox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notebox.Location = new System.Drawing.Point(0, 25);
            this.notebox.Name = "notebox";
            this.notebox.Size = new System.Drawing.Size(1067, 563);
            this.notebox.TabIndex = 1;
            this.notebox.Text = "";
            this.notebox.TextChanged += new System.EventHandler(this.notebox_TextChanged);
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackgroundImage = global::Notebook.Properties.Resources.e8uIS_UQe54;
            this.StatusStrip.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLab1,
            this.statusLinesCount,
            this.statusLab2,
            this.statusWordsCount,
            this.statusLab3,
            this.statusCharSpaceCount,
            this.statusLab4,
            this.statusCharCount});
            this.StatusStrip.Location = new System.Drawing.Point(0, 566);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1067, 22);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "statusStrip";
            // 
            // statusLab1
            // 
            this.statusLab1.Name = "statusLab1";
            this.statusLab1.Size = new System.Drawing.Size(127, 17);
            this.statusLab1.Text = "Количество строк:";
            // 
            // statusLinesCount
            // 
            this.statusLinesCount.Name = "statusLinesCount";
            this.statusLinesCount.Size = new System.Drawing.Size(15, 17);
            this.statusLinesCount.Text = "0";
            // 
            // statusLab2
            // 
            this.statusLab2.Name = "statusLab2";
            this.statusLab2.Size = new System.Drawing.Size(119, 17);
            this.statusLab2.Text = "Количество слов:";
            // 
            // statusWordsCount
            // 
            this.statusWordsCount.Name = "statusWordsCount";
            this.statusWordsCount.Size = new System.Drawing.Size(15, 17);
            this.statusWordsCount.Text = "0";
            // 
            // statusLab3
            // 
            this.statusLab3.Name = "statusLab3";
            this.statusLab3.Size = new System.Drawing.Size(159, 17);
            this.statusLab3.Text = "Символов с пробелами:";
            // 
            // statusCharSpaceCount
            // 
            this.statusCharSpaceCount.Name = "statusCharSpaceCount";
            this.statusCharSpaceCount.Size = new System.Drawing.Size(15, 17);
            this.statusCharSpaceCount.Text = "0";
            // 
            // statusLab4
            // 
            this.statusLab4.Name = "statusLab4";
            this.statusLab4.Size = new System.Drawing.Size(166, 17);
            this.statusLab4.Text = "Символов без пробелов:";
            // 
            // statusCharCount
            // 
            this.statusCharCount.Name = "statusCharCount";
            this.statusCharCount.Size = new System.Drawing.Size(15, 17);
            this.statusCharCount.Text = "0";
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // fontDialog
            // 
            this.fontDialog.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // Colour
            // 
            this.Colour.Name = "Colour";
            this.Colour.Size = new System.Drawing.Size(197, 22);
            this.Colour.Text = "Изменить цвет";
            this.Colour.Click += new System.EventHandler(this.Colour_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.notebox);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeForm";
            this.Text = "Notebook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mFile;
        private System.Windows.Forms.ToolStripMenuItem mFileNew;
        private System.Windows.Forms.ToolStripMenuItem mFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mFileSave;
        private System.Windows.Forms.ToolStripMenuItem mFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mFilePageParam;
        private System.Windows.Forms.ToolStripMenuItem mFilePrint;
        private System.Windows.Forms.ToolStripMenuItem mEdit;
        private System.Windows.Forms.ToolStripMenuItem mEditCancel;
        private System.Windows.Forms.ToolStripMenuItem mEditCut;
        private System.Windows.Forms.ToolStripMenuItem mEditCopy;
        private System.Windows.Forms.ToolStripMenuItem mEditPaste;
        private System.Windows.Forms.ToolStripMenuItem mEditDel;
        private System.Windows.Forms.ToolStripMenuItem mEditFind;
        private System.Windows.Forms.ToolStripMenuItem mEditGo;
        private System.Windows.Forms.ToolStripMenuItem mFormat;
        private System.Windows.Forms.ToolStripMenuItem mFormatTransfer;
        private System.Windows.Forms.ToolStripMenuItem mFormatFont;
        private System.Windows.Forms.ToolStripMenuItem mView;
        private System.Windows.Forms.ToolStripMenuItem mHelp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mFileExit;
        private System.Windows.Forms.ToolStripMenuItem mEditGiveAll;
        private System.Windows.Forms.ToolStripMenuItem mViewStatusStrip;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLab1;
        private System.Windows.Forms.ToolStripStatusLabel statusLinesCount;
        private System.Windows.Forms.ToolStripStatusLabel statusLab2;
        private System.Windows.Forms.ToolStripStatusLabel statusWordsCount;
        private System.Windows.Forms.ToolStripStatusLabel statusLab3;
        private System.Windows.Forms.ToolStripStatusLabel statusCharSpaceCount;
        private System.Windows.Forms.ToolStripStatusLabel statusLab4;
        private System.Windows.Forms.ToolStripStatusLabel statusCharCount;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.ToolStripMenuItem mEditTime;
        public System.Windows.Forms.RichTextBox notebox;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripMenuItem Colour;
    }
}

