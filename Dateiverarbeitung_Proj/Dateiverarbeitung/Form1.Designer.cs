namespace Dateiverarbeitung
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
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DirE = new System.DirectoryServices.DirectoryEntry();
            this.FSW = new System.IO.FileSystemWatcher();
            this.MS = new System.Windows.Forms.MenuStrip();
            this.StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruppierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nachBuchstabenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nachWortenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nachBuchstabenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aufsteigendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absteigendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nachWörternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aufsteigendToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.absteigendToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.FSW)).BeginInit();
            this.MS.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBox
            // 
            this.TxtBox.Location = new System.Drawing.Point(12, 68);
            this.TxtBox.Multiline = true;
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.Size = new System.Drawing.Size(411, 236);
            this.TxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Textausgabe";
            // 
            // FSW
            // 
            this.FSW.EnableRaisingEvents = true;
            this.FSW.SynchronizingObject = this;
            // 
            // MS
            // 
            this.MS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenu,
            this.textToolStripMenuItem});
            this.MS.Location = new System.Drawing.Point(0, 0);
            this.MS.Name = "MS";
            this.MS.Size = new System.Drawing.Size(435, 24);
            this.MS.TabIndex = 6;
            this.MS.Text = "menuStrip1";
            // 
            // StripMenu
            // 
            this.StripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speichernToolStripMenuItem,
            this.ladenToolStripMenuItem,
            this.toolStripSeparator1,
            this.beendenToolStripMenuItem});
            this.StripMenu.Name = "StripMenu";
            this.StripMenu.Size = new System.Drawing.Size(46, 20);
            this.StripMenu.Text = "Datei";
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.SpeichernToolStripMenuItem_Click);
            // 
            // ladenToolStripMenuItem
            // 
            this.ladenToolStripMenuItem.Name = "ladenToolStripMenuItem";
            this.ladenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ladenToolStripMenuItem.Text = "Laden";
            this.ladenToolStripMenuItem.Click += new System.EventHandler(this.LadenToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.BeendenToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gruppierenToolStripMenuItem,
            this.sortierenToolStripMenuItem});
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.textToolStripMenuItem.Text = "Text";
            // 
            // gruppierenToolStripMenuItem
            // 
            this.gruppierenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nachBuchstabenToolStripMenuItem,
            this.nachWortenToolStripMenuItem});
            this.gruppierenToolStripMenuItem.Name = "gruppierenToolStripMenuItem";
            this.gruppierenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gruppierenToolStripMenuItem.Text = "Gruppieren";
            // 
            // nachBuchstabenToolStripMenuItem
            // 
            this.nachBuchstabenToolStripMenuItem.Name = "nachBuchstabenToolStripMenuItem";
            this.nachBuchstabenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nachBuchstabenToolStripMenuItem.Text = "Nach Buchstaben";
            this.nachBuchstabenToolStripMenuItem.Click += new System.EventHandler(this.NachBuchstabenToolStripMenuItem_Click);
            // 
            // nachWortenToolStripMenuItem
            // 
            this.nachWortenToolStripMenuItem.Name = "nachWortenToolStripMenuItem";
            this.nachWortenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nachWortenToolStripMenuItem.Text = "Nach Worten";
            // 
            // sortierenToolStripMenuItem
            // 
            this.sortierenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nachBuchstabenToolStripMenuItem1,
            this.nachWörternToolStripMenuItem});
            this.sortierenToolStripMenuItem.Name = "sortierenToolStripMenuItem";
            this.sortierenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sortierenToolStripMenuItem.Text = "Sortieren";
            // 
            // nachBuchstabenToolStripMenuItem1
            // 
            this.nachBuchstabenToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aufsteigendToolStripMenuItem,
            this.absteigendToolStripMenuItem});
            this.nachBuchstabenToolStripMenuItem1.Name = "nachBuchstabenToolStripMenuItem1";
            this.nachBuchstabenToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.nachBuchstabenToolStripMenuItem1.Text = "Nach Buchstaben";
            // 
            // aufsteigendToolStripMenuItem
            // 
            this.aufsteigendToolStripMenuItem.Name = "aufsteigendToolStripMenuItem";
            this.aufsteigendToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.aufsteigendToolStripMenuItem.Text = "Aufsteigend";
            // 
            // absteigendToolStripMenuItem
            // 
            this.absteigendToolStripMenuItem.Name = "absteigendToolStripMenuItem";
            this.absteigendToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.absteigendToolStripMenuItem.Text = "Absteigend";
            // 
            // nachWörternToolStripMenuItem
            // 
            this.nachWörternToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aufsteigendToolStripMenuItem1,
            this.absteigendToolStripMenuItem1});
            this.nachWörternToolStripMenuItem.Name = "nachWörternToolStripMenuItem";
            this.nachWörternToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.nachWörternToolStripMenuItem.Text = "Nach Wörtern";
            // 
            // aufsteigendToolStripMenuItem1
            // 
            this.aufsteigendToolStripMenuItem1.Name = "aufsteigendToolStripMenuItem1";
            this.aufsteigendToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.aufsteigendToolStripMenuItem1.Text = "Aufsteigend";
            // 
            // absteigendToolStripMenuItem1
            // 
            this.absteigendToolStripMenuItem1.Name = "absteigendToolStripMenuItem1";
            this.absteigendToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.absteigendToolStripMenuItem1.Text = "Absteigend";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBox);
            this.Controls.Add(this.MS);
            this.MainMenuStrip = this.MS;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FSW)).EndInit();
            this.MS.ResumeLayout(false);
            this.MS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox;
        private System.Windows.Forms.Label label1;
        private System.DirectoryServices.DirectoryEntry DirE;
        private System.IO.FileSystemWatcher FSW;
        private System.Windows.Forms.MenuStrip MS;
        private System.Windows.Forms.ToolStripMenuItem StripMenu;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruppierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nachBuchstabenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nachWortenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nachBuchstabenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aufsteigendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem absteigendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nachWörternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aufsteigendToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem absteigendToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

