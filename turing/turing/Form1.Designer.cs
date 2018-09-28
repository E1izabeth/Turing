namespace turing
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Program = new System.Windows.Forms.DataGridView();
            this.tape = new System.Windows.Forms.DataGridView();
            this.tapeLeft = new System.Windows.Forms.Button();
            this.tapeRight = new System.Windows.Forms.Button();
            this.oneStep = new System.Windows.Forms.Button();
            this.allCmd = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.ListBox();
            this.lblCommand = new System.Windows.Forms.Label();
            this.lblSlash = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CleanLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgrammsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddQ = new System.Windows.Forms.Button();
            this.SubQ = new System.Windows.Forms.Button();
            this.maxCmd = new System.Windows.Forms.NumericUpDown();
            this.numCmd = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.subCol = new System.Windows.Forms.Button();
            this.addRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Program)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tape)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxCmd)).BeginInit();
            this.SuspendLayout();
            // 
            // Program
            // 
            this.Program.AllowUserToAddRows = false;
            this.Program.AllowUserToDeleteRows = false;
            this.Program.AllowUserToResizeColumns = false;
            this.Program.AllowUserToResizeRows = false;
            this.Program.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Program.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Program.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Program.ColumnHeadersHeight = 40;
            this.Program.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Program.DefaultCellStyle = dataGridViewCellStyle2;
            this.Program.Location = new System.Drawing.Point(263, 162);
            this.Program.Margin = new System.Windows.Forms.Padding(2);
            this.Program.MultiSelect = false;
            this.Program.Name = "Program";
            this.Program.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Program.RowHeadersWidth = 50;
            this.Program.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            this.Program.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Program.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Program.ShowEditingIcon = false;
            this.Program.Size = new System.Drawing.Size(335, 234);
            this.Program.TabIndex = 2;
            this.Program.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProgramCell_ValueChanged);
            this.Program.Resize += new System.EventHandler(this.ProgramResize);
            // 
            // tape
            // 
            this.tape.AllowUserToAddRows = false;
            this.tape.AllowUserToDeleteRows = false;
            this.tape.AllowUserToResizeColumns = false;
            this.tape.AllowUserToResizeRows = false;
            this.tape.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tape.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.tape.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tape.DefaultCellStyle = dataGridViewCellStyle4;
            this.tape.Location = new System.Drawing.Point(290, 70);
            this.tape.Margin = new System.Windows.Forms.Padding(2);
            this.tape.MultiSelect = false;
            this.tape.Name = "tape";
            this.tape.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tape.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tape.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tape.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tape.Size = new System.Drawing.Size(330, 78);
            this.tape.TabIndex = 3;
            this.tape.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TapeCell_ValueChanged);
            this.tape.Resize += new System.EventHandler(this.TapeResize);
            // 
            // tapeLeft
            // 
            this.tapeLeft.Location = new System.Drawing.Point(263, 70);
            this.tapeLeft.Margin = new System.Windows.Forms.Padding(2);
            this.tapeLeft.Name = "tapeLeft";
            this.tapeLeft.Size = new System.Drawing.Size(23, 78);
            this.tapeLeft.TabIndex = 4;
            this.tapeLeft.Text = "<";
            this.tapeLeft.UseVisualStyleBackColor = true;
            this.tapeLeft.Click += new System.EventHandler(this.ButtonLeft_Click);
            // 
            // tapeRight
            // 
            //this.tapeRight.Anchor = ((System.Windows.Forms.AnchorStyles)System.Windows.Forms.AnchorStyles.Bottom);
            this.tapeRight.Location = new System.Drawing.Point(622, 70);
            this.tapeRight.Margin = new System.Windows.Forms.Padding(2);
            this.tapeRight.Name = "tapeRight";
            this.tapeRight.Size = new System.Drawing.Size(23, 78);
            this.tapeRight.TabIndex = 5;
            this.tapeRight.Text = ">";
            this.tapeRight.UseVisualStyleBackColor = true;
            this.tapeRight.Click += new System.EventHandler(this.ButtonRight_Click);
            // 
            // oneStep
            // 
            this.oneStep.Anchor = ((System.Windows.Forms.AnchorStyles)System.Windows.Forms.AnchorStyles.Bottom);
            this.oneStep.Location = new System.Drawing.Point(266, 426);
            this.oneStep.Margin = new System.Windows.Forms.Padding(2);
            this.oneStep.Name = "oneStep";
            this.oneStep.Size = new System.Drawing.Size(75, 24);
            this.oneStep.TabIndex = 6;
            this.oneStep.Text = "One step";
            this.oneStep.UseVisualStyleBackColor = true;
            this.oneStep.Click += new System.EventHandler(this.ByStep_Click);
            // 
            // allCmd
            // 
            this.allCmd.Anchor = ((System.Windows.Forms.AnchorStyles)System.Windows.Forms.AnchorStyles.Bottom);
            this.allCmd.Location = new System.Drawing.Point(345, 426);
            this.allCmd.Margin = new System.Windows.Forms.Padding(2);
            this.allCmd.Name = "allCmd";
            this.allCmd.Size = new System.Drawing.Size(75, 24);
            this.allCmd.TabIndex = 7;
            this.allCmd.Text = "To End";
            this.allCmd.UseVisualStyleBackColor = true;
            this.allCmd.Click += new System.EventHandler(this.ToEnd_Click);
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.log.FormattingEnabled = true;
            this.log.ItemHeight = 15;
            this.log.Location = new System.Drawing.Point(9, 28);
            this.log.Margin = new System.Windows.Forms.Padding(2);
            this.log.Name = "log";
            this.log.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.log.Size = new System.Drawing.Size(237, 424);
            this.log.TabIndex = 9;
            // 
            // lblCommand
            // 
            this.lblCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCommand.AutoSize = true;
            this.lblCommand.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCommand.Location = new System.Drawing.Point(262, 28);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(90, 22);
            this.lblCommand.TabIndex = 12;
            this.lblCommand.Text = "Command:";
            // 
            // lblSlash
            // 
            this.lblSlash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSlash.AutoSize = true;
            this.lblSlash.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSlash.Location = new System.Drawing.Point(539, 28);
            this.lblSlash.Name = "lblSlash";
            this.lblSlash.Size = new System.Drawing.Size(20, 22);
            this.lblSlash.TabIndex = 13;
            this.lblSlash.Text = "/";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ProgrammsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CleanLogToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // CleanLogToolStripMenuItem
            // 
            this.CleanLogToolStripMenuItem.Name = "CleanLogToolStripMenuItem";
            this.CleanLogToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CleanLogToolStripMenuItem.Text = "Clean Log";
            this.CleanLogToolStripMenuItem.Click += new System.EventHandler(this.CleanLogToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ProgrammsToolStripMenuItem
            // 
            this.ProgrammsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem,
            this.test2ToolStripMenuItem,
            this.test3ToolStripMenuItem,
            this.test4ToolStripMenuItem});
            this.ProgrammsToolStripMenuItem.Name = "ProgrammsToolStripMenuItem";
            this.ProgrammsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.ProgrammsToolStripMenuItem.Text = "Tests";
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.test1ToolStripMenuItem.Text = "Test 1";
            this.test1ToolStripMenuItem.Click += new System.EventHandler(this.Test1ToolStripMenuItem_Click);
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.test2ToolStripMenuItem.Text = "Test 2";
            this.test2ToolStripMenuItem.Click += new System.EventHandler(this.Test2ToolStripMenuItem_Click);
            // 
            // test3ToolStripMenuItem
            // 
            this.test3ToolStripMenuItem.Name = "test3ToolStripMenuItem";
            this.test3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.test3ToolStripMenuItem.Text = "Test 3";
            this.test3ToolStripMenuItem.Click += new System.EventHandler(this.Test3ToolStripMenuItem_Click);
            // 
            // test4ToolStripMenuItem
            // 
            this.test4ToolStripMenuItem.Name = "test4ToolStripMenuItem";
            this.test4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.test4ToolStripMenuItem.Text = "Test 4";
            this.test4ToolStripMenuItem.Click += new System.EventHandler(this.Test4ToolStripMenuItem_Click);
            // 
            // AddQ
            // 
            this.AddQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddQ.Location = new System.Drawing.Point(603, 193);
            this.AddQ.Name = "AddQ";
            this.AddQ.Size = new System.Drawing.Size(49, 25);
            this.AddQ.TabIndex = 16;
            this.AddQ.Text = "+q";
            this.AddQ.UseVisualStyleBackColor = true;
            this.AddQ.Click += new System.EventHandler(this.AddQ_Click);
            // 
            // SubQ
            // 
            this.SubQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubQ.Location = new System.Drawing.Point(603, 162);
            this.SubQ.Name = "SubQ";
            this.SubQ.Size = new System.Drawing.Size(49, 25);
            this.SubQ.TabIndex = 17;
            this.SubQ.Text = "-q";
            this.SubQ.UseVisualStyleBackColor = true;
            this.SubQ.Click += new System.EventHandler(this.SubQ_Click);
            // 
            // maxCmd
            // 
            this.maxCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxCmd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxCmd.Location = new System.Drawing.Point(565, 27);
            this.maxCmd.Maximum = new decimal(new int[] {10000, 0, 0, 0});
            this.maxCmd.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.maxCmd.Name = "maxCmd";
            this.maxCmd.Size = new System.Drawing.Size(79, 26);
            this.maxCmd.TabIndex = 20;
            this.maxCmd.Value = new decimal(new int[] {1000, 0, 0, 0});
            this.maxCmd.ValueChanged += new System.EventHandler(this.MaxCmd_ValueChanged);
            // 
            // numCmd
            // 
            this.numCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCmd.AutoSize = true;
            this.numCmd.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numCmd.Location = new System.Drawing.Point(358, 28);
            this.numCmd.Name = "numCmd";
            this.numCmd.Size = new System.Drawing.Size(20, 22);
            this.numCmd.TabIndex = 21;
            this.numCmd.Text = "0";
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnLoad.Location = new System.Drawing.Point(577, 426);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 24);
            this.btnLoad.TabIndex = 22;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // subCol
            // 
            this.subCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subCol.Location = new System.Drawing.Point(603, 224);
            this.subCol.Name = "subCol";
            this.subCol.Size = new System.Drawing.Size(49, 23);
            this.subCol.TabIndex = 24;
            this.subCol.Text = "-col";
            this.subCol.UseVisualStyleBackColor = true;
            this.subCol.Click += new System.EventHandler(this.SubCol_Click);
            // 
            // addRow
            // 
            this.addRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addRow.Location = new System.Drawing.Point(604, 254);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(48, 23);
            this.addRow.TabIndex = 25;
            this.addRow.Text = "+col";
            this.addRow.UseVisualStyleBackColor = true;
            this.addRow.Click += new System.EventHandler(this.AddRow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(656, 461);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.subCol);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.numCmd);
            this.Controls.Add(this.maxCmd);
            this.Controls.Add(this.SubQ);
            this.Controls.Add(this.AddQ);
            this.Controls.Add(this.lblSlash);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.log);
            this.Controls.Add(this.allCmd);
            this.Controls.Add(this.oneStep);
            this.Controls.Add(this.tapeRight);
            this.Controls.Add(this.tapeLeft);
            this.Controls.Add(this.tape);
            this.Controls.Add(this.Program);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turing machine";
            this.Load += new System.EventHandler(this.MainFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.Program)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tape)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxCmd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.DataGridView Program;
        private System.Windows.Forms.DataGridView tape;
        private System.Windows.Forms.Button tapeLeft;
        private System.Windows.Forms.Button tapeRight;
        private System.Windows.Forms.Button oneStep;
        private System.Windows.Forms.Button allCmd;
        private System.Windows.Forms.ListBox log;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.Label lblSlash;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProgrammsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CleanLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Button AddQ;
        private System.Windows.Forms.Button SubQ;
        private System.Windows.Forms.NumericUpDown maxCmd;
        private System.Windows.Forms.Label numCmd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button subCol;
        private System.Windows.Forms.Button addRow;
    }
}

