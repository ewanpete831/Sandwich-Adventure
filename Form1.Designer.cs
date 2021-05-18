
namespace Sandwich_Adventure
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
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.button1Label = new System.Windows.Forms.Label();
            this.button2Label = new System.Windows.Forms.Label();
            this.button3Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.Image = global::Sandwich_Adventure.Properties.Resources.door;
            this.imageBox.Location = new System.Drawing.Point(75, 160);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(551, 236);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(12, 18);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(681, 139);
            this.outputLabel.TabIndex = 1;
            // 
            // option1Button
            // 
            this.option1Button.BackgroundImage = global::Sandwich_Adventure.Properties.Resources.Button_Next_icon;
            this.option1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option1Button.FlatAppearance.BorderSize = 0;
            this.option1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option1Button.Location = new System.Drawing.Point(75, 412);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(74, 51);
            this.option1Button.TabIndex = 2;
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.BackgroundImage = global::Sandwich_Adventure.Properties.Resources.Button_Next_icon;
            this.option2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option2Button.FlatAppearance.BorderSize = 0;
            this.option2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option2Button.Location = new System.Drawing.Point(75, 469);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(74, 51);
            this.option2Button.TabIndex = 3;
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.BackgroundImage = global::Sandwich_Adventure.Properties.Resources.Button_Next_icon;
            this.option3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option3Button.FlatAppearance.BorderSize = 0;
            this.option3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option3Button.Location = new System.Drawing.Point(75, 526);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(74, 51);
            this.option3Button.TabIndex = 4;
            this.option3Button.UseVisualStyleBackColor = true;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // button1Label
            // 
            this.button1Label.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Label.Location = new System.Drawing.Point(155, 412);
            this.button1Label.Name = "button1Label";
            this.button1Label.Size = new System.Drawing.Size(471, 51);
            this.button1Label.TabIndex = 5;
            // 
            // button2Label
            // 
            this.button2Label.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Label.Location = new System.Drawing.Point(151, 479);
            this.button2Label.Name = "button2Label";
            this.button2Label.Size = new System.Drawing.Size(475, 51);
            this.button2Label.TabIndex = 6;
            // 
            // button3Label
            // 
            this.button3Label.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3Label.Location = new System.Drawing.Point(151, 526);
            this.button3Label.Name = "button3Label";
            this.button3Label.Size = new System.Drawing.Size(484, 51);
            this.button3Label.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(705, 587);
            this.Controls.Add(this.button3Label);
            this.Controls.Add(this.button2Label);
            this.Controls.Add(this.button1Label);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.imageBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Journey to the Sandwich Store";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Label button1Label;
        private System.Windows.Forms.Label button2Label;
        private System.Windows.Forms.Label button3Label;
    }
}

