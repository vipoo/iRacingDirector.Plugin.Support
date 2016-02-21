﻿namespace iRacingDirector.Plugin.Tester
{
    partial class Main
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
            this.browseBackgroundImageButton = new System.Windows.Forms.Button();
            this.fullSizeButton = new System.Windows.Forms.Button();
            this.halfSizeButton = new System.Windows.Forms.Button();
            this.thirdSizeButton = new System.Windows.Forms.Button();
            this.introFlashCardButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundTestImageFileName = new System.Windows.Forms.TextBox();
            this.pluginAssemblyFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.browsePluginButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errorDetailsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sampleSessionDataFileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.browserSampleSessionDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browseBackgroundImageButton
            // 
            this.browseBackgroundImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseBackgroundImageButton.Location = new System.Drawing.Point(749, 47);
            this.browseBackgroundImageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browseBackgroundImageButton.Name = "browseBackgroundImageButton";
            this.browseBackgroundImageButton.Size = new System.Drawing.Size(80, 24);
            this.browseBackgroundImageButton.TabIndex = 0;
            this.browseBackgroundImageButton.Text = "browse";
            this.browseBackgroundImageButton.UseVisualStyleBackColor = true;
            this.browseBackgroundImageButton.Click += new System.EventHandler(this.browseBackgroundImageButton_Click);
            // 
            // fullSizeButton
            // 
            this.fullSizeButton.Location = new System.Drawing.Point(23, 185);
            this.fullSizeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fullSizeButton.Name = "fullSizeButton";
            this.fullSizeButton.Size = new System.Drawing.Size(155, 28);
            this.fullSizeButton.TabIndex = 1;
            this.fullSizeButton.Text = "Full Size";
            this.fullSizeButton.UseVisualStyleBackColor = true;
            this.fullSizeButton.Click += new System.EventHandler(this.fullSizeButton_Click);
            // 
            // halfSizeButton
            // 
            this.halfSizeButton.Location = new System.Drawing.Point(23, 221);
            this.halfSizeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.halfSizeButton.Name = "halfSizeButton";
            this.halfSizeButton.Size = new System.Drawing.Size(155, 28);
            this.halfSizeButton.TabIndex = 2;
            this.halfSizeButton.Text = "Half Size";
            this.halfSizeButton.UseVisualStyleBackColor = true;
            this.halfSizeButton.Click += new System.EventHandler(this.halfSizeButton_Click);
            // 
            // thirdSizeButton
            // 
            this.thirdSizeButton.Location = new System.Drawing.Point(23, 258);
            this.thirdSizeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thirdSizeButton.Name = "thirdSizeButton";
            this.thirdSizeButton.Size = new System.Drawing.Size(155, 28);
            this.thirdSizeButton.TabIndex = 3;
            this.thirdSizeButton.Text = "Third Size";
            this.thirdSizeButton.UseVisualStyleBackColor = true;
            this.thirdSizeButton.Click += new System.EventHandler(this.thirdSizeButton_Click);
            // 
            // introFlashCardButton
            // 
            this.introFlashCardButton.Location = new System.Drawing.Point(218, 185);
            this.introFlashCardButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.introFlashCardButton.Name = "introFlashCardButton";
            this.introFlashCardButton.Size = new System.Drawing.Size(186, 43);
            this.introFlashCardButton.TabIndex = 4;
            this.introFlashCardButton.Text = "Intro Flash Card";
            this.introFlashCardButton.UseVisualStyleBackColor = true;
            this.introFlashCardButton.Click += new System.EventHandler(this.introFlashCardButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Test Background Image:";
            // 
            // backgroundTestImageFileName
            // 
            this.backgroundTestImageFileName.Location = new System.Drawing.Point(189, 49);
            this.backgroundTestImageFileName.Name = "backgroundTestImageFileName";
            this.backgroundTestImageFileName.Size = new System.Drawing.Size(553, 24);
            this.backgroundTestImageFileName.TabIndex = 6;
            this.backgroundTestImageFileName.Leave += new System.EventHandler(this.backgroundTestImageFileName_Leave);
            // 
            // pluginAssemblyFileName
            // 
            this.pluginAssemblyFileName.Location = new System.Drawing.Point(189, 19);
            this.pluginAssemblyFileName.Name = "pluginAssemblyFileName";
            this.pluginAssemblyFileName.Size = new System.Drawing.Size(553, 24);
            this.pluginAssemblyFileName.TabIndex = 9;
            this.pluginAssemblyFileName.Leave += new System.EventHandler(this.pluginAssemblyFileName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Plugin Binary (dll):";
            // 
            // browsePluginButton
            // 
            this.browsePluginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browsePluginButton.Location = new System.Drawing.Point(749, 18);
            this.browsePluginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browsePluginButton.Name = "browsePluginButton";
            this.browsePluginButton.Size = new System.Drawing.Size(80, 24);
            this.browsePluginButton.TabIndex = 7;
            this.browsePluginButton.Text = "browse";
            this.browsePluginButton.UseVisualStyleBackColor = true;
            this.browsePluginButton.Click += new System.EventHandler(this.browsePluginButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Show Test Image:";
            // 
            // errorDetailsTextBox
            // 
            this.errorDetailsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorDetailsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorDetailsTextBox.Location = new System.Drawing.Point(485, 152);
            this.errorDetailsTextBox.Multiline = true;
            this.errorDetailsTextBox.Name = "errorDetailsTextBox";
            this.errorDetailsTextBox.ReadOnly = true;
            this.errorDetailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.errorDetailsTextBox.Size = new System.Drawing.Size(349, 157);
            this.errorDetailsTextBox.TabIndex = 11;
            this.errorDetailsTextBox.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Error Details:";
            // 
            // sampleSessionDataFileName
            // 
            this.sampleSessionDataFileName.Location = new System.Drawing.Point(189, 79);
            this.sampleSessionDataFileName.Name = "sampleSessionDataFileName";
            this.sampleSessionDataFileName.Size = new System.Drawing.Size(553, 24);
            this.sampleSessionDataFileName.TabIndex = 15;
            this.sampleSessionDataFileName.Leave += new System.EventHandler(this.sampleSessionDataFileName_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sample Session Data:";
            // 
            // browserSampleSessionDataButton
            // 
            this.browserSampleSessionDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browserSampleSessionDataButton.Location = new System.Drawing.Point(749, 77);
            this.browserSampleSessionDataButton.Margin = new System.Windows.Forms.Padding(4);
            this.browserSampleSessionDataButton.Name = "browserSampleSessionDataButton";
            this.browserSampleSessionDataButton.Size = new System.Drawing.Size(80, 24);
            this.browserSampleSessionDataButton.TabIndex = 13;
            this.browserSampleSessionDataButton.Text = "browse";
            this.browserSampleSessionDataButton.UseVisualStyleBackColor = true;
            this.browserSampleSessionDataButton.Click += new System.EventHandler(this.browserSampleSessionDataButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 337);
            this.Controls.Add(this.sampleSessionDataFileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.browserSampleSessionDataButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.errorDetailsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pluginAssemblyFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.browsePluginButton);
            this.Controls.Add(this.backgroundTestImageFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.introFlashCardButton);
            this.Controls.Add(this.thirdSizeButton);
            this.Controls.Add(this.halfSizeButton);
            this.Controls.Add(this.fullSizeButton);
            this.Controls.Add(this.browseBackgroundImageButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseBackgroundImageButton;
        private System.Windows.Forms.Button fullSizeButton;
        private System.Windows.Forms.Button halfSizeButton;
        private System.Windows.Forms.Button thirdSizeButton;
        private System.Windows.Forms.Button introFlashCardButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox backgroundTestImageFileName;
        private System.Windows.Forms.TextBox pluginAssemblyFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browsePluginButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox errorDetailsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sampleSessionDataFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button browserSampleSessionDataButton;
    }
}

