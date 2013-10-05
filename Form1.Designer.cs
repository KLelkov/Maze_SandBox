namespace Maze_SandBox
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.controlPanel = new System.Windows.Forms.Panel();
            this.optionsBox = new System.Windows.Forms.ComboBox();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.propertiesLabel = new System.Windows.Forms.Label();
            this.selectCheckBox = new System.Windows.Forms.CheckBox();
            this.generateBox = new System.Windows.Forms.ComboBox();
            this.solveBox = new System.Windows.Forms.ComboBox();
            this.step_button = new System.Windows.Forms.Button();
            this.generate_button = new System.Windows.Forms.Button();
            this.mazeSizeLabel = new System.Windows.Forms.Label();
            this.mazeSizeBox = new System.Windows.Forms.TextBox();
            this.animationCheckBox = new System.Windows.Forms.CheckBox();
            this.delayBox3 = new System.Windows.Forms.TextBox();
            this.delayLabel3 = new System.Windows.Forms.Label();
            this.cellSizeLabel = new System.Windows.Forms.Label();
            this.solve_button = new System.Windows.Forms.Button();
            this.delayBox2 = new System.Windows.Forms.TextBox();
            this.delayLabel2 = new System.Windows.Forms.Label();
            this.reset_button = new System.Windows.Forms.Button();
            this.delayBox1 = new System.Windows.Forms.TextBox();
            this.delayLabel1 = new System.Windows.Forms.Label();
            this.speedCheckBox = new System.Windows.Forms.CheckBox();
            this.cellSizeBox = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.controlPanel.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.optionsBox);
            this.controlPanel.Controls.Add(this.optionsLabel);
            this.controlPanel.Controls.Add(this.propertiesLabel);
            this.controlPanel.Controls.Add(this.selectCheckBox);
            this.controlPanel.Controls.Add(this.generateBox);
            this.controlPanel.Controls.Add(this.solveBox);
            this.controlPanel.Controls.Add(this.step_button);
            this.controlPanel.Controls.Add(this.generate_button);
            this.controlPanel.Controls.Add(this.mazeSizeLabel);
            this.controlPanel.Controls.Add(this.mazeSizeBox);
            this.controlPanel.Controls.Add(this.animationCheckBox);
            this.controlPanel.Controls.Add(this.delayBox3);
            this.controlPanel.Controls.Add(this.delayLabel3);
            this.controlPanel.Controls.Add(this.cellSizeLabel);
            this.controlPanel.Controls.Add(this.solve_button);
            this.controlPanel.Controls.Add(this.delayBox2);
            this.controlPanel.Controls.Add(this.delayLabel2);
            this.controlPanel.Controls.Add(this.reset_button);
            this.controlPanel.Controls.Add(this.delayBox1);
            this.controlPanel.Controls.Add(this.delayLabel1);
            this.controlPanel.Controls.Add(this.speedCheckBox);
            this.controlPanel.Controls.Add(this.cellSizeBox);
            this.controlPanel.Location = new System.Drawing.Point(1060, 5);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(205, 658);
            this.controlPanel.TabIndex = 22;
            // 
            // optionsBox
            // 
            this.optionsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.optionsBox.FormattingEnabled = true;
            this.optionsBox.Location = new System.Drawing.Point(13, 154);
            this.optionsBox.Name = "optionsBox";
            this.optionsBox.Size = new System.Drawing.Size(185, 21);
            this.optionsBox.TabIndex = 34;
            // 
            // optionsLabel
            // 
            this.optionsLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.optionsLabel.Location = new System.Drawing.Point(13, 351);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(185, 23);
            this.optionsLabel.TabIndex = 33;
            this.optionsLabel.Text = "Options:";
            this.optionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // propertiesLabel
            // 
            this.propertiesLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.propertiesLabel.Location = new System.Drawing.Point(7, 428);
            this.propertiesLabel.Name = "propertiesLabel";
            this.propertiesLabel.Size = new System.Drawing.Size(195, 23);
            this.propertiesLabel.TabIndex = 32;
            this.propertiesLabel.Text = "Properties:";
            this.propertiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectCheckBox
            // 
            this.selectCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.selectCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectCheckBox.Location = new System.Drawing.Point(13, 202);
            this.selectCheckBox.Name = "selectCheckBox";
            this.selectCheckBox.Size = new System.Drawing.Size(185, 35);
            this.selectCheckBox.TabIndex = 28;
            this.selectCheckBox.Text = "Select exit position";
            this.selectCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectCheckBox.UseVisualStyleBackColor = true;
            this.selectCheckBox.Click += new System.EventHandler(this.selectCheckBox_Click);
            // 
            // generateBox
            // 
            this.generateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generateBox.FormattingEnabled = true;
            this.generateBox.Items.AddRange(new object[] {
            "Hunt and Kill algorithm",
            "Walking Man algorithm",
            "Growing Tree algorithm"});
            this.generateBox.Location = new System.Drawing.Point(13, 127);
            this.generateBox.Name = "generateBox";
            this.generateBox.Size = new System.Drawing.Size(185, 21);
            this.generateBox.TabIndex = 29;
            this.generateBox.SelectedIndexChanged += new System.EventHandler(this.generateBox_SelectedIndexChanged);
            // 
            // solveBox
            // 
            this.solveBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.solveBox.FormattingEnabled = true;
            this.solveBox.Items.AddRange(new object[] {
            "Wave solution",
            "Tremo solution"});
            this.solveBox.Location = new System.Drawing.Point(13, 309);
            this.solveBox.Name = "solveBox";
            this.solveBox.Size = new System.Drawing.Size(185, 21);
            this.solveBox.TabIndex = 23;
            // 
            // step_button
            // 
            this.step_button.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step_button.Location = new System.Drawing.Point(13, 377);
            this.step_button.Name = "step_button";
            this.step_button.Size = new System.Drawing.Size(185, 35);
            this.step_button.TabIndex = 2;
            this.step_button.Text = "Generation step";
            this.step_button.UseVisualStyleBackColor = true;
            // 
            // generate_button
            // 
            this.generate_button.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generate_button.Location = new System.Drawing.Point(13, 71);
            this.generate_button.Name = "generate_button";
            this.generate_button.Size = new System.Drawing.Size(185, 50);
            this.generate_button.TabIndex = 0;
            this.generate_button.Text = "Generate";
            this.generate_button.UseVisualStyleBackColor = true;
            this.generate_button.Click += new System.EventHandler(this.generate_button_Click);
            // 
            // mazeSizeLabel
            // 
            this.mazeSizeLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mazeSizeLabel.Location = new System.Drawing.Point(3, 475);
            this.mazeSizeLabel.Name = "mazeSizeLabel";
            this.mazeSizeLabel.Size = new System.Drawing.Size(84, 23);
            this.mazeSizeLabel.TabIndex = 4;
            this.mazeSizeLabel.Text = "Maze size";
            this.mazeSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mazeSizeBox
            // 
            this.mazeSizeBox.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mazeSizeBox.Location = new System.Drawing.Point(93, 477);
            this.mazeSizeBox.Name = "mazeSizeBox";
            this.mazeSizeBox.ReadOnly = true;
            this.mazeSizeBox.Size = new System.Drawing.Size(108, 24);
            this.mazeSizeBox.TabIndex = 5;
            this.mazeSizeBox.Text = "18";
            this.mazeSizeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // animationCheckBox
            // 
            this.animationCheckBox.AutoSize = true;
            this.animationCheckBox.Checked = true;
            this.animationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.animationCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.animationCheckBox.Location = new System.Drawing.Point(83, 629);
            this.animationCheckBox.Name = "animationCheckBox";
            this.animationCheckBox.Size = new System.Drawing.Size(101, 27);
            this.animationCheckBox.TabIndex = 27;
            this.animationCheckBox.Text = "Animation";
            this.animationCheckBox.UseVisualStyleBackColor = true;
            // 
            // delayBox3
            // 
            this.delayBox3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delayBox3.Location = new System.Drawing.Point(143, 566);
            this.delayBox3.Name = "delayBox3";
            this.delayBox3.Size = new System.Drawing.Size(59, 24);
            this.delayBox3.TabIndex = 26;
            this.delayBox3.Text = "10";
            this.delayBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // delayLabel3
            // 
            this.delayLabel3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delayLabel3.Location = new System.Drawing.Point(7, 567);
            this.delayLabel3.Name = "delayLabel3";
            this.delayLabel3.Size = new System.Drawing.Size(130, 23);
            this.delayLabel3.TabIndex = 25;
            this.delayLabel3.Text = "Solving delay";
            this.delayLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cellSizeLabel
            // 
            this.cellSizeLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cellSizeLabel.Location = new System.Drawing.Point(7, 454);
            this.cellSizeLabel.Name = "cellSizeLabel";
            this.cellSizeLabel.Size = new System.Drawing.Size(80, 23);
            this.cellSizeLabel.TabIndex = 23;
            this.cellSizeLabel.Text = "Cell size";
            this.cellSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // solve_button
            // 
            this.solve_button.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solve_button.Location = new System.Drawing.Point(13, 252);
            this.solve_button.Name = "solve_button";
            this.solve_button.Size = new System.Drawing.Size(185, 50);
            this.solve_button.TabIndex = 3;
            this.solve_button.Text = "Solve";
            this.solve_button.UseVisualStyleBackColor = true;
            // 
            // delayBox2
            // 
            this.delayBox2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delayBox2.Location = new System.Drawing.Point(143, 536);
            this.delayBox2.Name = "delayBox2";
            this.delayBox2.Size = new System.Drawing.Size(59, 24);
            this.delayBox2.TabIndex = 20;
            this.delayBox2.Text = "10";
            this.delayBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // delayLabel2
            // 
            this.delayLabel2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delayLabel2.Location = new System.Drawing.Point(7, 537);
            this.delayLabel2.Name = "delayLabel2";
            this.delayLabel2.Size = new System.Drawing.Size(130, 23);
            this.delayLabel2.TabIndex = 19;
            this.delayLabel2.Text = "Gen delay";
            this.delayLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // reset_button
            // 
            this.reset_button.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reset_button.Location = new System.Drawing.Point(13, 7);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(185, 50);
            this.reset_button.TabIndex = 1;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // delayBox1
            // 
            this.delayBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delayBox1.Location = new System.Drawing.Point(143, 506);
            this.delayBox1.Name = "delayBox1";
            this.delayBox1.Size = new System.Drawing.Size(59, 24);
            this.delayBox1.TabIndex = 18;
            this.delayBox1.Text = "100";
            this.delayBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // delayLabel1
            // 
            this.delayLabel1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delayLabel1.Location = new System.Drawing.Point(9, 507);
            this.delayLabel1.Name = "delayLabel1";
            this.delayLabel1.Size = new System.Drawing.Size(130, 23);
            this.delayLabel1.TabIndex = 17;
            this.delayLabel1.Text = "Step delay";
            this.delayLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // speedCheckBox
            // 
            this.speedCheckBox.AutoSize = true;
            this.speedCheckBox.Checked = true;
            this.speedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.speedCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedCheckBox.Location = new System.Drawing.Point(83, 596);
            this.speedCheckBox.Name = "speedCheckBox";
            this.speedCheckBox.Size = new System.Drawing.Size(119, 27);
            this.speedCheckBox.TabIndex = 12;
            this.speedCheckBox.Text = "Speed Mode";
            this.speedCheckBox.UseVisualStyleBackColor = true;
            // 
            // cellSizeBox
            // 
            this.cellSizeBox.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cellSizeBox.Location = new System.Drawing.Point(93, 454);
            this.cellSizeBox.Name = "cellSizeBox";
            this.cellSizeBox.Size = new System.Drawing.Size(62, 24);
            this.cellSizeBox.TabIndex = 14;
            this.cellSizeBox.Text = "35";
            this.cellSizeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cellSizeBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 666);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1270, 22);
            this.statusStrip.TabIndex = 23;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 688);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.controlPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Maze SandBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.ComboBox optionsBox;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Label propertiesLabel;
        private System.Windows.Forms.CheckBox selectCheckBox;
        private System.Windows.Forms.ComboBox generateBox;
        private System.Windows.Forms.ComboBox solveBox;
        private System.Windows.Forms.Button step_button;
        private System.Windows.Forms.Button generate_button;
        private System.Windows.Forms.Label mazeSizeLabel;
        private System.Windows.Forms.TextBox mazeSizeBox;
        private System.Windows.Forms.CheckBox animationCheckBox;
        private System.Windows.Forms.TextBox delayBox3;
        private System.Windows.Forms.Label delayLabel3;
        private System.Windows.Forms.Label cellSizeLabel;
        private System.Windows.Forms.Button solve_button;
        private System.Windows.Forms.TextBox delayBox2;
        private System.Windows.Forms.Label delayLabel2;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.TextBox delayBox1;
        private System.Windows.Forms.Label delayLabel1;
        private System.Windows.Forms.CheckBox speedCheckBox;
        private System.Windows.Forms.TextBox cellSizeBox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}

