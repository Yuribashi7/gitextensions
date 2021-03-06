﻿namespace GitUI.CommandsDialogs
{
    partial class FormMergeBranch
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
            this.strategyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Ok = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Branches = new GitUI.BranchComboBox();
            this.noCommit = new System.Windows.Forms.CheckBox();
            this.advanced = new System.Windows.Forms.CheckBox();
            this.NonDefaultMergeStrategy = new System.Windows.Forms.CheckBox();
            this.squash = new System.Windows.Forms.CheckBox();
            this.strategyHelp = new System.Windows.Forms.LinkLabel();
            this._NO_TRANSLATE_mergeStrategy = new System.Windows.Forms.ComboBox();
            this.currentBranchLabel = new System.Windows.Forms.Label();
            this.noFastForward = new System.Windows.Forms.RadioButton();
            this.fastForward = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Currentbranch = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.helpImageDisplayUserControl1 = new GitUI.Help.HelpImageDisplayUserControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // strategyToolTip
            // 
            this.strategyToolTip.AutomaticDelay = 1;
            this.strategyToolTip.AutoPopDelay = 0;
            this.strategyToolTip.InitialDelay = 1;
            this.strategyToolTip.ReshowDelay = 1;
            this.strategyToolTip.ShowAlways = true;
            this.strategyToolTip.UseAnimation = false;
            this.strategyToolTip.UseFading = false;
            // 
            // Ok
            // 
            this.Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok.Location = new System.Drawing.Point(421, 387);
            this.Ok.Margin = new System.Windows.Forms.Padding(4);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(135, 31);
            this.Ok.TabIndex = 9;
            this.Ok.Text = "&Merge";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.OkClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.helpImageDisplayUserControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(872, 438);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Branches);
            this.groupBox1.Controls.Add(this.noCommit);
            this.groupBox1.Controls.Add(this.advanced);
            this.groupBox1.Controls.Add(this.NonDefaultMergeStrategy);
            this.groupBox1.Controls.Add(this.squash);
            this.groupBox1.Controls.Add(this.strategyHelp);
            this.groupBox1.Controls.Add(this._NO_TRANSLATE_mergeStrategy);
            this.groupBox1.Controls.Add(this.currentBranchLabel);
            this.groupBox1.Controls.Add(this.noFastForward);
            this.groupBox1.Controls.Add(this.fastForward);
            this.groupBox1.Controls.Add(this.Ok);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Currentbranch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(302, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(566, 430);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Merge";
            // 
            // Branches
            // 
            this.Branches.BranchesToSelect = null;
            this.Branches.Location = new System.Drawing.Point(162, 85);
            this.Branches.Margin = new System.Windows.Forms.Padding(0);
            this.Branches.Name = "Branches";
            this.Branches.Size = new System.Drawing.Size(402, 26);
            this.Branches.TabIndex = 0;
            // 
            // noCommit
            // 
            this.noCommit.AutoSize = true;
            this.noCommit.Location = new System.Drawing.Point(16, 204);
            this.noCommit.Margin = new System.Windows.Forms.Padding(4);
            this.noCommit.Name = "noCommit";
            this.noCommit.Size = new System.Drawing.Size(148, 27);
            this.noCommit.TabIndex = 8;
            this.noCommit.Text = "Do not commit";
            this.noCommit.UseVisualStyleBackColor = true;
            // 
            // advanced
            // 
            this.advanced.AutoSize = true;
            this.advanced.Location = new System.Drawing.Point(16, 250);
            this.advanced.Margin = new System.Windows.Forms.Padding(4);
            this.advanced.Name = "advanced";
            this.advanced.Size = new System.Drawing.Size(213, 27);
            this.advanced.TabIndex = 3;
            this.advanced.Text = "Show advanced options";
            this.advanced.UseVisualStyleBackColor = true;
            this.advanced.CheckedChanged += new System.EventHandler(this.advanced_CheckedChanged);
            // 
            // NonDefaultMergeStrategy
            // 
            this.NonDefaultMergeStrategy.AutoSize = true;
            this.NonDefaultMergeStrategy.Location = new System.Drawing.Point(34, 285);
            this.NonDefaultMergeStrategy.Margin = new System.Windows.Forms.Padding(4);
            this.NonDefaultMergeStrategy.Name = "NonDefaultMergeStrategy";
            this.NonDefaultMergeStrategy.Size = new System.Drawing.Size(275, 27);
            this.NonDefaultMergeStrategy.TabIndex = 4;
            this.NonDefaultMergeStrategy.Text = "Use non-default merge strategy";
            this.NonDefaultMergeStrategy.UseVisualStyleBackColor = true;
            this.NonDefaultMergeStrategy.Visible = false;
            this.NonDefaultMergeStrategy.CheckedChanged += new System.EventHandler(this.NonDefaultMergeStrategy_CheckedChanged);
            // 
            // squash
            // 
            this.squash.AutoSize = true;
            this.squash.Location = new System.Drawing.Point(34, 320);
            this.squash.Margin = new System.Windows.Forms.Padding(4);
            this.squash.Name = "squash";
            this.squash.Size = new System.Drawing.Size(157, 27);
            this.squash.TabIndex = 7;
            this.squash.Text = "Squash commits";
            this.squash.UseVisualStyleBackColor = true;
            this.squash.Visible = false;
            // 
            // strategyHelp
            // 
            this.strategyHelp.AutoSize = true;
            this.strategyHelp.Location = new System.Drawing.Point(522, 286);
            this.strategyHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.strategyHelp.Name = "strategyHelp";
            this.strategyHelp.Size = new System.Drawing.Size(45, 23);
            this.strategyHelp.TabIndex = 6;
            this.strategyHelp.TabStop = true;
            this.strategyHelp.Text = "Help";
            this.strategyHelp.Visible = false;
            this.strategyHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.strategyHelp_LinkClicked);
            // 
            // _NO_TRANSLATE_mergeStrategy
            // 
            this._NO_TRANSLATE_mergeStrategy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this._NO_TRANSLATE_mergeStrategy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._NO_TRANSLATE_mergeStrategy.FormattingEnabled = true;
            this._NO_TRANSLATE_mergeStrategy.Items.AddRange(new object[] {
            "resolve",
            "recursive",
            "octopus",
            "ours",
            "subtree"});
            this._NO_TRANSLATE_mergeStrategy.Location = new System.Drawing.Point(318, 283);
            this._NO_TRANSLATE_mergeStrategy.Margin = new System.Windows.Forms.Padding(4);
            this._NO_TRANSLATE_mergeStrategy.Name = "_NO_TRANSLATE_mergeStrategy";
            this._NO_TRANSLATE_mergeStrategy.Size = new System.Drawing.Size(196, 31);
            this._NO_TRANSLATE_mergeStrategy.TabIndex = 5;
            this._NO_TRANSLATE_mergeStrategy.Visible = false;
            // 
            // currentBranchLabel
            // 
            this.currentBranchLabel.AutoSize = true;
            this.currentBranchLabel.Location = new System.Drawing.Point(158, 52);
            this.currentBranchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentBranchLabel.Name = "currentBranchLabel";
            this.currentBranchLabel.Size = new System.Drawing.Size(18, 23);
            this.currentBranchLabel.TabIndex = 0;
            this.currentBranchLabel.Text = "?";
            // 
            // noFastForward
            // 
            this.noFastForward.AutoSize = true;
            this.noFastForward.Location = new System.Drawing.Point(16, 169);
            this.noFastForward.Margin = new System.Windows.Forms.Padding(4);
            this.noFastForward.Name = "noFastForward";
            this.noFastForward.Size = new System.Drawing.Size(301, 27);
            this.noFastForward.TabIndex = 0;
            this.noFastForward.Text = "Always create a new merge commit";
            this.noFastForward.UseVisualStyleBackColor = true;
            this.noFastForward.CheckedChanged += new System.EventHandler(this.noFastForward_CheckedChanged);
            // 
            // fastForward
            // 
            this.fastForward.AutoSize = true;
            this.fastForward.Checked = true;
            this.fastForward.Location = new System.Drawing.Point(16, 138);
            this.fastForward.Margin = new System.Windows.Forms.Padding(4);
            this.fastForward.Name = "fastForward";
            this.fastForward.Size = new System.Drawing.Size(407, 27);
            this.fastForward.TabIndex = 1;
            this.fastForward.TabStop = true;
            this.fastForward.Text = "Keep a single branch line if possible (fast forward)";
            this.fastForward.UseVisualStyleBackColor = true;
            this.fastForward.CheckedChanged += new System.EventHandler(this.fastForward_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Merge branch into current branch";
            // 
            // Currentbranch
            // 
            this.Currentbranch.AutoSize = true;
            this.Currentbranch.Location = new System.Drawing.Point(12, 52);
            this.Currentbranch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Currentbranch.Name = "Currentbranch";
            this.Currentbranch.Size = new System.Drawing.Size(126, 23);
            this.Currentbranch.TabIndex = 0;
            this.Currentbranch.Text = "Current branch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Merge with";
            // 
            // helpImageDisplayUserControl1
            // 
            this.helpImageDisplayUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpImageDisplayUserControl1.AutoSize = true;
            this.helpImageDisplayUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpImageDisplayUserControl1.Image1 = global::GitUI.Properties.Resources.HelpCommandMerge;
            this.helpImageDisplayUserControl1.Image2 = global::GitUI.Properties.Resources.HelpCommandMergeFastForward;
            this.helpImageDisplayUserControl1.IsExpanded = true;
            this.helpImageDisplayUserControl1.IsOnHoverShowImage2 = true;
            this.helpImageDisplayUserControl1.IsOnHoverShowImage2NoticeText = "Hover to see scenario when fast forward is possible.";
            this.helpImageDisplayUserControl1.Location = new System.Drawing.Point(4, 4);
            this.helpImageDisplayUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.helpImageDisplayUserControl1.MinimumSize = new System.Drawing.Size(290, 426);
            this.helpImageDisplayUserControl1.Name = "helpImageDisplayUserControl1";
            this.helpImageDisplayUserControl1.Size = new System.Drawing.Size(290, 430);
            this.helpImageDisplayUserControl1.TabIndex = 18;
            this.helpImageDisplayUserControl1.UniqueIsExpandedSettingsId = "MergeBranches";
            // 
            // FormMergeBranch
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(872, 438);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 485);
            this.Name = "FormMergeBranch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Merge branches";
            this.Load += new System.EventHandler(this.FormMergeBranchLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Currentbranch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton noFastForward;
        private System.Windows.Forms.RadioButton fastForward;
        private System.Windows.Forms.Label currentBranchLabel;
        private System.Windows.Forms.ComboBox _NO_TRANSLATE_mergeStrategy;
        private System.Windows.Forms.LinkLabel strategyHelp;
        private System.Windows.Forms.ToolTip strategyToolTip;
        private System.Windows.Forms.CheckBox squash;
        private System.Windows.Forms.CheckBox advanced;
        private System.Windows.Forms.CheckBox NonDefaultMergeStrategy;
        private System.Windows.Forms.CheckBox noCommit;
        private BranchComboBox Branches;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Help.HelpImageDisplayUserControl helpImageDisplayUserControl1;
    }
}