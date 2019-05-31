namespace ClipboardLogger
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.permanNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.processNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьПапкуСЗаписямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьЗаписиЗаСегодняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.остановитьРаботуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // permanNotify
            // 
            this.permanNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.permanNotify.BalloonTipText = "Clipboard Logger has been launched successfully.";
            this.permanNotify.BalloonTipTitle = "Clipboard Logger";
            this.permanNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("permanNotify.Icon")));
            this.permanNotify.Text = "Clipboard Logger";
            this.permanNotify.BalloonTipClicked += new System.EventHandler(this.NotifyIcon_Hide);
            this.permanNotify.BalloonTipClosed += new System.EventHandler(this.NotifyIcon_Hide);
            this.permanNotify.Click += new System.EventHandler(this.NotifyIcon_Hide);
            // 
            // processNotify
            // 
            this.processNotify.ContextMenuStrip = this.contextMenuStrip1;
            this.processNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("processNotify.Icon")));
            this.processNotify.Text = "Clipboard Logger";
            this.processNotify.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьПапкуСЗаписямиToolStripMenuItem,
            this.открытьЗаписиЗаСегодняToolStripMenuItem,
            this.остановитьРаботуToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(223, 70);
            // 
            // открытьПапкуСЗаписямиToolStripMenuItem
            // 
            this.открытьПапкуСЗаписямиToolStripMenuItem.Name = "открытьПапкуСЗаписямиToolStripMenuItem";
            this.открытьПапкуСЗаписямиToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.открытьПапкуСЗаписямиToolStripMenuItem.Text = "Открыть папку с записями";
            this.открытьПапкуСЗаписямиToolStripMenuItem.Click += new System.EventHandler(this.OpenFolder);
            // 
            // открытьЗаписиЗаСегодняToolStripMenuItem
            // 
            this.открытьЗаписиЗаСегодняToolStripMenuItem.Name = "открытьЗаписиЗаСегодняToolStripMenuItem";
            this.открытьЗаписиЗаСегодняToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.открытьЗаписиЗаСегодняToolStripMenuItem.Text = "Открыть записи за сегодня";
            this.открытьЗаписиЗаСегодняToolStripMenuItem.Click += new System.EventHandler(this.OpenToday);
            // 
            // остановитьРаботуToolStripMenuItem
            // 
            this.остановитьРаботуToolStripMenuItem.Name = "остановитьРаботуToolStripMenuItem";
            this.остановитьРаботуToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.остановитьРаботуToolStripMenuItem.Text = "Остановить работу";
            this.остановитьРаботуToolStripMenuItem.Click += new System.EventHandler(this.StopApplication);
            // 
            // closingNotify
            // 
            this.closingNotify.BalloonTipText = "Clipboard Logger has been closed. Click to launch it again.";
            this.closingNotify.BalloonTipTitle = "Clipboard Logger";
            this.closingNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("closingNotify.Icon")));
            this.closingNotify.Text = "Clipboard Logger";
            this.closingNotify.BalloonTipClicked += new System.EventHandler(this.ClosingNotify_BalloonTipClicked);
            this.closingNotify.BalloonTipClosed += new System.EventHandler(this.ClosingNotify_BalloonTipClosed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon permanNotify;
        private System.Windows.Forms.NotifyIcon processNotify;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьПапкуСЗаписямиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьЗаписиЗаСегодняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem остановитьРаботуToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon closingNotify;
    }
}

