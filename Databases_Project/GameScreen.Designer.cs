namespace Databases_Project
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogPanel = new System.Windows.Forms.Panel();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.NextDayButton = new System.Windows.Forms.Button();
            this.SpecialButton = new System.Windows.Forms.Button();
            this.WaitDayButton = new System.Windows.Forms.Button();
            this.travelersDataView = new System.Windows.Forms.DataGridView();
            this.crewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journeyGame_DBClassDataSet = new Databases_Project.JourneyGame_DBClassDataSet();
            this.CrewLabel = new System.Windows.Forms.Label();
            this.InventoryListBox = new System.Windows.Forms.ListBox();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.TossItemButton = new System.Windows.Forms.Button();
            this.UseItemButton = new System.Windows.Forms.Button();
            this.LogLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crewTableAdapter = new Databases_Project.JourneyGame_DBClassDataSetTableAdapters.CrewTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.travelersDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journeyGame_DBClassDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.devControlsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.newGameToolStripMenuItem,
            this.saveGameToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(45, 20);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            // 
            // devControlsToolStripMenuItem
            // 
            this.devControlsToolStripMenuItem.Name = "devControlsToolStripMenuItem";
            this.devControlsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.devControlsToolStripMenuItem.Text = "Dev Controls";
            // 
            // LogPanel
            // 
            this.LogPanel.Location = new System.Drawing.Point(234, 42);
            this.LogPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(225, 203);
            this.LogPanel.TabIndex = 1;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(234, 264);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(225, 28);
            this.ProgressBar.TabIndex = 2;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(232, 248);
            this.ProgressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(88, 13);
            this.ProgressLabel.TabIndex = 3;
            this.ProgressLabel.Text = "Journey Progress";
            // 
            // NextDayButton
            // 
            this.NextDayButton.Location = new System.Drawing.Point(234, 306);
            this.NextDayButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NextDayButton.Name = "NextDayButton";
            this.NextDayButton.Size = new System.Drawing.Size(225, 24);
            this.NextDayButton.TabIndex = 4;
            this.NextDayButton.Text = "Next Day";
            this.NextDayButton.UseVisualStyleBackColor = true;
            this.NextDayButton.Click += new System.EventHandler(this.NextDayButton_Click);
            // 
            // SpecialButton
            // 
            this.SpecialButton.Location = new System.Drawing.Point(362, 337);
            this.SpecialButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SpecialButton.Name = "SpecialButton";
            this.SpecialButton.Size = new System.Drawing.Size(98, 24);
            this.SpecialButton.TabIndex = 5;
            this.SpecialButton.Text = "Accept Offer";
            this.SpecialButton.UseVisualStyleBackColor = true;
            // 
            // WaitDayButton
            // 
            this.WaitDayButton.Location = new System.Drawing.Point(234, 337);
            this.WaitDayButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WaitDayButton.Name = "WaitDayButton";
            this.WaitDayButton.Size = new System.Drawing.Size(98, 24);
            this.WaitDayButton.TabIndex = 6;
            this.WaitDayButton.Text = "Wait Day";
            this.WaitDayButton.UseVisualStyleBackColor = true;
            // 
            // travelersDataView
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.travelersDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.travelersDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.travelersDataView.DefaultCellStyle = dataGridViewCellStyle5;
            this.travelersDataView.Location = new System.Drawing.Point(7, 58);
            this.travelersDataView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.travelersDataView.Name = "travelersDataView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.travelersDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.travelersDataView.RowHeadersWidth = 4;
            this.travelersDataView.RowTemplate.Height = 24;
            this.travelersDataView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.travelersDataView.Size = new System.Drawing.Size(220, 303);
            this.travelersDataView.TabIndex = 7;
            // 
            // crewBindingSource
            // 
            this.crewBindingSource.DataMember = "Crew";
            this.crewBindingSource.DataSource = this.journeyGame_DBClassDataSet;
            // 
            // journeyGame_DBClassDataSet
            // 
            this.journeyGame_DBClassDataSet.DataSetName = "JourneyGame_DBClassDataSet";
            this.journeyGame_DBClassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CrewLabel
            // 
            this.CrewLabel.AutoSize = true;
            this.CrewLabel.Location = new System.Drawing.Point(4, 42);
            this.CrewLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CrewLabel.Name = "CrewLabel";
            this.CrewLabel.Size = new System.Drawing.Size(51, 13);
            this.CrewLabel.TabIndex = 8;
            this.CrewLabel.Text = "Travelers";
            this.CrewLabel.UseMnemonic = false;
            // 
            // InventoryListBox
            // 
            this.InventoryListBox.FormattingEnabled = true;
            this.InventoryListBox.Location = new System.Drawing.Point(464, 58);
            this.InventoryListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InventoryListBox.Name = "InventoryListBox";
            this.InventoryListBox.Size = new System.Drawing.Size(162, 186);
            this.InventoryListBox.TabIndex = 9;
            this.InventoryListBox.SelectedIndexChanged += new System.EventHandler(this.InventoryListBox_SelectedIndexChanged);
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Location = new System.Drawing.Point(464, 42);
            this.InventoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.InventoryLabel.TabIndex = 10;
            this.InventoryLabel.Text = "Inventory";
            this.InventoryLabel.UseMnemonic = false;
            // 
            // TossItemButton
            // 
            this.TossItemButton.Location = new System.Drawing.Point(464, 249);
            this.TossItemButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TossItemButton.Name = "TossItemButton";
            this.TossItemButton.Size = new System.Drawing.Size(160, 24);
            this.TossItemButton.TabIndex = 11;
            this.TossItemButton.Text = "Toss Item";
            this.TossItemButton.UseVisualStyleBackColor = true;
            // 
            // UseItemButton
            // 
            this.UseItemButton.Enabled = false;
            this.UseItemButton.Location = new System.Drawing.Point(464, 278);
            this.UseItemButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UseItemButton.Name = "UseItemButton";
            this.UseItemButton.Size = new System.Drawing.Size(160, 24);
            this.UseItemButton.TabIndex = 12;
            this.UseItemButton.Text = "Use Item";
            this.UseItemButton.UseVisualStyleBackColor = true;
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Location = new System.Drawing.Point(232, 26);
            this.LogLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(58, 13);
            this.LogLabel.TabIndex = 13;
            this.LogLabel.Text = "Travel Log";
            this.LogLabel.UseMnemonic = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(468, 307);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(155, 54);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // crewTableAdapter
            // 
            this.crewTableAdapter.ClearBeforeFill = true;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(632, 369);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LogLabel);
            this.Controls.Add(this.UseItemButton);
            this.Controls.Add(this.TossItemButton);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.InventoryListBox);
            this.Controls.Add(this.CrewLabel);
            this.Controls.Add(this.travelersDataView);
            this.Controls.Add(this.WaitDayButton);
            this.Controls.Add(this.SpecialButton);
            this.Controls.Add(this.NextDayButton);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.LogPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GameScreen";
            this.Text = "GameScreen";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.travelersDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journeyGame_DBClassDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devControlsToolStripMenuItem;
        private System.Windows.Forms.Panel LogPanel;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.Button NextDayButton;
        private System.Windows.Forms.Button SpecialButton;
        private System.Windows.Forms.Button WaitDayButton;
        private System.Windows.Forms.DataGridView travelersDataView;
        private System.Windows.Forms.Label CrewLabel;
        private System.Windows.Forms.ListBox InventoryListBox;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.Button TossItemButton;
        private System.Windows.Forms.Button UseItemButton;
        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private JourneyGame_DBClassDataSet journeyGame_DBClassDataSet;
        private System.Windows.Forms.BindingSource crewBindingSource;
        private JourneyGame_DBClassDataSetTableAdapters.CrewTableAdapter crewTableAdapter;
    }
}