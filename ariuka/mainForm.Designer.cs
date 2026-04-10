namespace ariuka
{
    partial class mainForm
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
            menuStrip1 = new MenuStrip();
            movieListToolStripMenuItem = new ToolStripMenuItem();
            commentToolStripMenuItem = new ToolStripMenuItem();
            favouriteToolStripMenuItem = new ToolStripMenuItem();
            watchlistToolStripMenuItem = new ToolStripMenuItem();
            favouriteActorToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { movieListToolStripMenuItem, commentToolStripMenuItem, favouriteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // movieListToolStripMenuItem
            // 
            movieListToolStripMenuItem.Name = "movieListToolStripMenuItem";
            movieListToolStripMenuItem.Size = new Size(73, 20);
            movieListToolStripMenuItem.Text = "Movie List";
            movieListToolStripMenuItem.Click += movieListToolStripMenuItem_Click;
            // 
            // commentToolStripMenuItem
            // 
            commentToolStripMenuItem.Name = "commentToolStripMenuItem";
            commentToolStripMenuItem.Size = new Size(73, 20);
            commentToolStripMenuItem.Text = "Comment";
            // 
            // favouriteToolStripMenuItem
            // 
            favouriteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { watchlistToolStripMenuItem, favouriteActorToolStripMenuItem });
            favouriteToolStripMenuItem.Name = "favouriteToolStripMenuItem";
            favouriteToolStripMenuItem.Size = new Size(104, 20);
            favouriteToolStripMenuItem.Text = "Favourite Movie";
            favouriteToolStripMenuItem.Click += favouriteToolStripMenuItem_Click;
            // 
            // watchlistToolStripMenuItem
            // 
            watchlistToolStripMenuItem.Name = "watchlistToolStripMenuItem";
            watchlistToolStripMenuItem.Size = new Size(155, 22);
            watchlistToolStripMenuItem.Text = "Watchlist";
            watchlistToolStripMenuItem.Click += watchlistToolStripMenuItem_Click;
            // 
            // favouriteActorToolStripMenuItem
            // 
            favouriteActorToolStripMenuItem.Name = "favouriteActorToolStripMenuItem";
            favouriteActorToolStripMenuItem.Size = new Size(155, 22);
            favouriteActorToolStripMenuItem.Text = "Favourite Actor";
            favouriteActorToolStripMenuItem.Click += favouriteActorToolStripMenuItem_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "mainForm";
            Text = "MOVIE APPLICATION";
            Load += mainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem movieListToolStripMenuItem;
        private ToolStripMenuItem commentToolStripMenuItem;
        private ToolStripMenuItem favouriteToolStripMenuItem;
        private ToolStripMenuItem watchlistToolStripMenuItem;
        private ToolStripMenuItem favouriteActorToolStripMenuItem;
    }
}