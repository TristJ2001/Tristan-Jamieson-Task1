namespace Task1
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.txtNumEnemies = new System.Windows.Forms.TextBox();
            this.txtMapMaxHeight = new System.Windows.Forms.TextBox();
            this.lblMapMaxHeight = new System.Windows.Forms.Label();
            this.lblMapMaxWidth = new System.Windows.Forms.Label();
            this.txtMapMinHeight = new System.Windows.Forms.TextBox();
            this.txtMapMaxWidth = new System.Windows.Forms.TextBox();
            this.txtMapMinWidth = new System.Windows.Forms.TextBox();
            this.lblNumEnemies = new System.Windows.Forms.Label();
            this.lblMapMinHeight = new System.Windows.Forms.Label();
            this.lblMapMinWidth = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.Location = new System.Drawing.Point(290, 41);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(231, 291);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "label1";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(646, 198);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "▲";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(646, 256);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "▼";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(700, 227);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = "►";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(592, 227);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.Text = "◄";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // txtNumEnemies
            // 
            this.txtNumEnemies.Location = new System.Drawing.Point(156, 188);
            this.txtNumEnemies.Name = "txtNumEnemies";
            this.txtNumEnemies.Size = new System.Drawing.Size(100, 22);
            this.txtNumEnemies.TabIndex = 21;
            // 
            // txtMapMaxHeight
            // 
            this.txtMapMaxHeight.Location = new System.Drawing.Point(156, 123);
            this.txtMapMaxHeight.Name = "txtMapMaxHeight";
            this.txtMapMaxHeight.Size = new System.Drawing.Size(100, 22);
            this.txtMapMaxHeight.TabIndex = 20;
            // 
            // lblMapMaxHeight
            // 
            this.lblMapMaxHeight.AutoSize = true;
            this.lblMapMaxHeight.Location = new System.Drawing.Point(8, 126);
            this.lblMapMaxHeight.Name = "lblMapMaxHeight";
            this.lblMapMaxHeight.Size = new System.Drawing.Size(146, 17);
            this.lblMapMaxHeight.TabIndex = 19;
            this.lblMapMaxHeight.Text = "Map Maximum Height:";
            // 
            // lblMapMaxWidth
            // 
            this.lblMapMaxWidth.AutoSize = true;
            this.lblMapMaxWidth.Location = new System.Drawing.Point(12, 41);
            this.lblMapMaxWidth.Name = "lblMapMaxWidth";
            this.lblMapMaxWidth.Size = new System.Drawing.Size(138, 17);
            this.lblMapMaxWidth.TabIndex = 18;
            this.lblMapMaxWidth.Text = "Map Maximun Width:";
            // 
            // txtMapMinHeight
            // 
            this.txtMapMinHeight.Location = new System.Drawing.Point(156, 90);
            this.txtMapMinHeight.Name = "txtMapMinHeight";
            this.txtMapMinHeight.Size = new System.Drawing.Size(100, 22);
            this.txtMapMinHeight.TabIndex = 17;
            // 
            // txtMapMaxWidth
            // 
            this.txtMapMaxWidth.Location = new System.Drawing.Point(156, 38);
            this.txtMapMaxWidth.Name = "txtMapMaxWidth";
            this.txtMapMaxWidth.Size = new System.Drawing.Size(100, 22);
            this.txtMapMaxWidth.TabIndex = 16;
            // 
            // txtMapMinWidth
            // 
            this.txtMapMinWidth.Location = new System.Drawing.Point(156, 6);
            this.txtMapMinWidth.Name = "txtMapMinWidth";
            this.txtMapMinWidth.Size = new System.Drawing.Size(100, 22);
            this.txtMapMinWidth.TabIndex = 15;
            // 
            // lblNumEnemies
            // 
            this.lblNumEnemies.AutoSize = true;
            this.lblNumEnemies.Location = new System.Drawing.Point(14, 191);
            this.lblNumEnemies.Name = "lblNumEnemies";
            this.lblNumEnemies.Size = new System.Drawing.Size(136, 17);
            this.lblNumEnemies.TabIndex = 14;
            this.lblNumEnemies.Text = "Number of Enemies:";
            // 
            // lblMapMinHeight
            // 
            this.lblMapMinHeight.AutoSize = true;
            this.lblMapMinHeight.Location = new System.Drawing.Point(12, 93);
            this.lblMapMinHeight.Name = "lblMapMinHeight";
            this.lblMapMinHeight.Size = new System.Drawing.Size(143, 17);
            this.lblMapMinHeight.TabIndex = 13;
            this.lblMapMinHeight.Text = "Map Minimum Height:";
            // 
            // lblMapMinWidth
            // 
            this.lblMapMinWidth.AutoSize = true;
            this.lblMapMinWidth.Location = new System.Drawing.Point(12, 9);
            this.lblMapMinWidth.Name = "lblMapMinWidth";
            this.lblMapMinWidth.Size = new System.Drawing.Size(138, 17);
            this.lblMapMinWidth.TabIndex = 12;
            this.lblMapMinWidth.Text = "Map Minimum Width:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(101, 274);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumEnemies);
            this.Controls.Add(this.txtMapMaxHeight);
            this.Controls.Add(this.lblMapMaxHeight);
            this.Controls.Add(this.lblMapMaxWidth);
            this.Controls.Add(this.txtMapMinHeight);
            this.Controls.Add(this.txtMapMaxWidth);
            this.Controls.Add(this.txtMapMinWidth);
            this.Controls.Add(this.lblNumEnemies);
            this.Controls.Add(this.lblMapMinHeight);
            this.Controls.Add(this.lblMapMinWidth);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lblDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.TextBox txtNumEnemies;
        private System.Windows.Forms.TextBox txtMapMaxHeight;
        private System.Windows.Forms.Label lblMapMaxHeight;
        private System.Windows.Forms.Label lblMapMaxWidth;
        private System.Windows.Forms.TextBox txtMapMinHeight;
        private System.Windows.Forms.TextBox txtMapMaxWidth;
        private System.Windows.Forms.TextBox txtMapMinWidth;
        private System.Windows.Forms.Label lblNumEnemies;
        private System.Windows.Forms.Label lblMapMinHeight;
        private System.Windows.Forms.Label lblMapMinWidth;
        private System.Windows.Forms.Button btnStart;
    }
}

