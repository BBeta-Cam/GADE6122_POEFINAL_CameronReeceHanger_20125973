
namespace GADE6122_POE_CameronReeceHanger_20125973
{
    partial class FormGame
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
            this.txbMap = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txbGameText = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.grpbxAttack = new System.Windows.Forms.GroupBox();
            this.txbAttackText = new System.Windows.Forms.TextBox();
            this.cmbbxAttack = new System.Windows.Forms.ComboBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.txbAttackLog = new System.Windows.Forms.TextBox();
            this.grpbxAttack.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbMap
            // 
            this.txbMap.Location = new System.Drawing.Point(12, 12);
            this.txbMap.Multiline = true;
            this.txbMap.Name = "txbMap";
            this.txbMap.Size = new System.Drawing.Size(356, 268);
            this.txbMap.TabIndex = 0;
            this.txbMap.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(403, 389);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(170, 43);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(589, 389);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 43);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbGameText
            // 
            this.txbGameText.Location = new System.Drawing.Point(403, 12);
            this.txbGameText.Multiline = true;
            this.txbGameText.Name = "txbGameText";
            this.txbGameText.Size = new System.Drawing.Size(356, 86);
            this.txbGameText.TabIndex = 3;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(126, 298);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(93, 34);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(27, 349);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(93, 34);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(126, 398);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(93, 34);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(225, 349);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(93, 34);
            this.btnRight.TabIndex = 7;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // grpbxAttack
            // 
            this.grpbxAttack.BackColor = System.Drawing.Color.Gray;
            this.grpbxAttack.Controls.Add(this.txbAttackText);
            this.grpbxAttack.Controls.Add(this.cmbbxAttack);
            this.grpbxAttack.Location = new System.Drawing.Point(403, 105);
            this.grpbxAttack.Name = "grpbxAttack";
            this.grpbxAttack.Size = new System.Drawing.Size(356, 148);
            this.grpbxAttack.TabIndex = 8;
            this.grpbxAttack.TabStop = false;
            this.grpbxAttack.Text = "Attack";
            // 
            // txbAttackText
            // 
            this.txbAttackText.Location = new System.Drawing.Point(7, 48);
            this.txbAttackText.Multiline = true;
            this.txbAttackText.Name = "txbAttackText";
            this.txbAttackText.Size = new System.Drawing.Size(343, 94);
            this.txbAttackText.TabIndex = 1;
            // 
            // cmbbxAttack
            // 
            this.cmbbxAttack.FormattingEnabled = true;
            this.cmbbxAttack.Location = new System.Drawing.Point(7, 20);
            this.cmbbxAttack.Name = "cmbbxAttack";
            this.cmbbxAttack.Size = new System.Drawing.Size(343, 21);
            this.cmbbxAttack.TabIndex = 0;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(403, 256);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(356, 35);
            this.btnAttack.TabIndex = 9;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // txbAttackLog
            // 
            this.txbAttackLog.Location = new System.Drawing.Point(403, 298);
            this.txbAttackLog.Multiline = true;
            this.txbAttackLog.Name = "txbAttackLog";
            this.txbAttackLog.Size = new System.Drawing.Size(356, 85);
            this.txbAttackLog.TabIndex = 10;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 452);
            this.Controls.Add(this.txbAttackLog);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.grpbxAttack);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txbGameText);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txbMap);
            this.Name = "FormGame";
            this.Text = "Game";
            this.grpbxAttack.ResumeLayout(false);
            this.grpbxAttack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbMap;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbGameText;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.GroupBox grpbxAttack;
        private System.Windows.Forms.TextBox txbAttackText;
        private System.Windows.Forms.ComboBox cmbbxAttack;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.TextBox txbAttackLog;
    }
}

