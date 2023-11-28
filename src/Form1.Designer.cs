using Autoclicker.Properties;

namespace Autoclicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            clickSetBar = new TrackBar();
            cpsLabel = new Label();
            btnStop = new Button();
            Autoclicker = new System.Windows.Forms.Timer(components);
            btnStart = new Button();
            menuStrip1 = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            stopKeyComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)clickSetBar).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // clickSetBar
            // 
            clickSetBar.Location = new Point(12, 54);
            clickSetBar.Maximum = 1000;
            clickSetBar.Minimum = 1;
            clickSetBar.Name = "clickSetBar";
            clickSetBar.Size = new Size(355, 45);
            clickSetBar.TabIndex = 0;
            clickSetBar.TickStyle = TickStyle.None;
            clickSetBar.Value = 1;
            clickSetBar.Scroll += SetClicks;
            // 
            // cpsLabel
            // 
            cpsLabel.AutoSize = true;
            cpsLabel.Location = new Point(12, 36);
            cpsLabel.Name = "cpsLabel";
            cpsLabel.Size = new Size(73, 15);
            cpsLabel.TabIndex = 1;
            cpsLabel.Text = "1 Clicks/Sec.";
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.FlatStyle = FlatStyle.Popup;
            btnStop.Location = new Point(292, 105);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += StopAutoclick;
            // 
            // Autoclicker
            // 
            Autoclicker.Interval = 1000;
            Autoclicker.Tick += Autoclicker_Tick;
            // 
            // btnStart
            // 
            btnStart.FlatStyle = FlatStyle.Popup;
            btnStart.Location = new Point(211, 105);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += StartAutoclick;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(379, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += HelpDialog;
            // 
            // stopKeyComboBox
            // 
            stopKeyComboBox.FormattingEnabled = true;
            stopKeyComboBox.Items.AddRange(new object[] { "CTRL", "ALT", "SHIFT" });
            stopKeyComboBox.Location = new Point(12, 105);
            stopKeyComboBox.Name = "stopKeyComboBox";
            stopKeyComboBox.Size = new Size(193, 23);
            stopKeyComboBox.TabIndex = 5;
            stopKeyComboBox.Text = "Stop Key";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 138);
            Controls.Add(stopKeyComboBox);
            Controls.Add(btnStart);
            Controls.Add(btnStop);
            Controls.Add(cpsLabel);
            Controls.Add(clickSetBar);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = Resources.app;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            ShowIcon = false;
            Text = "LKs Autoclicker";
            ((System.ComponentModel.ISupportInitialize)clickSetBar).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar clickSetBar;
        private Label cpsLabel;
        private Button btnStop;
        private System.Windows.Forms.Timer Autoclicker;
        private Button btnStart;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ComboBox stopKeyComboBox;
    }
}