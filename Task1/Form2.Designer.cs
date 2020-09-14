namespace Task1
{
    partial class Form2
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
            // txtNumEnemies
            // 
            this.txtNumEnemies.Location = new System.Drawing.Point(424, 262);
            this.txtNumEnemies.Name = "txtNumEnemies";
            this.txtNumEnemies.Size = new System.Drawing.Size(100, 22);
            this.txtNumEnemies.TabIndex = 32;
            // 
            // txtMapMaxHeight
            // 
            this.txtMapMaxHeight.Location = new System.Drawing.Point(424, 197);
            this.txtMapMaxHeight.Name = "txtMapMaxHeight";
            this.txtMapMaxHeight.Size = new System.Drawing.Size(100, 22);
            this.txtMapMaxHeight.TabIndex = 31;
            // 
            // lblMapMaxHeight
            // 
            this.lblMapMaxHeight.AutoSize = true;
            this.lblMapMaxHeight.Location = new System.Drawing.Point(276, 200);
            this.lblMapMaxHeight.Name = "lblMapMaxHeight";
            this.lblMapMaxHeight.Size = new System.Drawing.Size(146, 17);
            this.lblMapMaxHeight.TabIndex = 30;
            this.lblMapMaxHeight.Text = "Map Maximum Height:";
            // 
            // lblMapMaxWidth
            // 
            this.lblMapMaxWidth.AutoSize = true;
            this.lblMapMaxWidth.Location = new System.Drawing.Point(280, 115);
            this.lblMapMaxWidth.Name = "lblMapMaxWidth";
            this.lblMapMaxWidth.Size = new System.Drawing.Size(138, 17);
            this.lblMapMaxWidth.TabIndex = 29;
            this.lblMapMaxWidth.Text = "Map Maximun Width:";
            // 
            // txtMapMinHeight
            // 
            this.txtMapMinHeight.Location = new System.Drawing.Point(424, 164);
            this.txtMapMinHeight.Name = "txtMapMinHeight";
            this.txtMapMinHeight.Size = new System.Drawing.Size(100, 22);
            this.txtMapMinHeight.TabIndex = 28;
            // 
            // txtMapMaxWidth
            // 
            this.txtMapMaxWidth.Location = new System.Drawing.Point(424, 112);
            this.txtMapMaxWidth.Name = "txtMapMaxWidth";
            this.txtMapMaxWidth.Size = new System.Drawing.Size(100, 22);
            this.txtMapMaxWidth.TabIndex = 27;
            // 
            // txtMapMinWidth
            // 
            this.txtMapMinWidth.Location = new System.Drawing.Point(424, 80);
            this.txtMapMinWidth.Name = "txtMapMinWidth";
            this.txtMapMinWidth.Size = new System.Drawing.Size(100, 22);
            this.txtMapMinWidth.TabIndex = 26;
            // 
            // lblNumEnemies
            // 
            this.lblNumEnemies.AutoSize = true;
            this.lblNumEnemies.Location = new System.Drawing.Point(282, 265);
            this.lblNumEnemies.Name = "lblNumEnemies";
            this.lblNumEnemies.Size = new System.Drawing.Size(136, 17);
            this.lblNumEnemies.TabIndex = 25;
            this.lblNumEnemies.Text = "Number of Enemies:";
            // 
            // lblMapMinHeight
            // 
            this.lblMapMinHeight.AutoSize = true;
            this.lblMapMinHeight.Location = new System.Drawing.Point(280, 167);
            this.lblMapMinHeight.Name = "lblMapMinHeight";
            this.lblMapMinHeight.Size = new System.Drawing.Size(143, 17);
            this.lblMapMinHeight.TabIndex = 24;
            this.lblMapMinHeight.Text = "Map Minimum Height:";
            // 
            // lblMapMinWidth
            // 
            this.lblMapMinWidth.AutoSize = true;
            this.lblMapMinWidth.Location = new System.Drawing.Point(280, 83);
            this.lblMapMinWidth.Name = "lblMapMinWidth";
            this.lblMapMinWidth.Size = new System.Drawing.Size(138, 17);
            this.lblMapMinWidth.TabIndex = 23;
            this.lblMapMinWidth.Text = "Map Minimum Width:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(369, 348);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 22;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // Form2
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
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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