
namespace WeaklySmartUMLMaker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonInheritance = new System.Windows.Forms.Button();
            this.buttonAssociation = new System.Windows.Forms.Button();
            this.buttonRealization = new System.Windows.Forms.Button();
            this.buttonComposition = new System.Windows.Forms.Button();
            this.buttonAggregation = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CreateNewClassButton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInheritance
            // 
            this.buttonInheritance.Image = ((System.Drawing.Image)(resources.GetObject("buttonInheritance.Image")));
            this.buttonInheritance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonInheritance.Location = new System.Drawing.Point(10, 12);
            this.buttonInheritance.Name = "buttonInheritance";
            this.buttonInheritance.Size = new System.Drawing.Size(102, 59);
            this.buttonInheritance.TabIndex = 1;
            this.buttonInheritance.Text = "Inheritance";
            this.buttonInheritance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonInheritance.UseVisualStyleBackColor = true;
            this.buttonInheritance.Click += new System.EventHandler(this.buttonInheritance_Click);
            // 
            // buttonAssociation
            // 
            this.buttonAssociation.Image = ((System.Drawing.Image)(resources.GetObject("buttonAssociation.Image")));
            this.buttonAssociation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAssociation.Location = new System.Drawing.Point(10, 77);
            this.buttonAssociation.Name = "buttonAssociation";
            this.buttonAssociation.Size = new System.Drawing.Size(102, 48);
            this.buttonAssociation.TabIndex = 2;
            this.buttonAssociation.Text = "Association";
            this.buttonAssociation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAssociation.UseVisualStyleBackColor = true;
            this.buttonAssociation.Click += new System.EventHandler(this.buttonAssociation_Click);
            // 
            // buttonRealization
            // 
            this.buttonRealization.Image = ((System.Drawing.Image)(resources.GetObject("buttonRealization.Image")));
            this.buttonRealization.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRealization.Location = new System.Drawing.Point(10, 131);
            this.buttonRealization.Name = "buttonRealization";
            this.buttonRealization.Size = new System.Drawing.Size(102, 51);
            this.buttonRealization.TabIndex = 3;
            this.buttonRealization.Text = "Realization";
            this.buttonRealization.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRealization.UseVisualStyleBackColor = true;
            this.buttonRealization.Click += new System.EventHandler(this.buttonRealization_Click);
            // 
            // buttonComposition
            // 
            this.buttonComposition.Image = ((System.Drawing.Image)(resources.GetObject("buttonComposition.Image")));
            this.buttonComposition.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonComposition.Location = new System.Drawing.Point(10, 188);
            this.buttonComposition.Name = "buttonComposition";
            this.buttonComposition.Size = new System.Drawing.Size(102, 51);
            this.buttonComposition.TabIndex = 4;
            this.buttonComposition.Text = "Composition";
            this.buttonComposition.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonComposition.UseVisualStyleBackColor = true;
            this.buttonComposition.Click += new System.EventHandler(this.buttonComposition_Click);
            // 
            // buttonAggregation
            // 
            this.buttonAggregation.Image = ((System.Drawing.Image)(resources.GetObject("buttonAggregation.Image")));
            this.buttonAggregation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAggregation.Location = new System.Drawing.Point(10, 245);
            this.buttonAggregation.Name = "buttonAggregation";
            this.buttonAggregation.Size = new System.Drawing.Size(102, 52);
            this.buttonAggregation.TabIndex = 5;
            this.buttonAggregation.Text = "Aggregation";
            this.buttonAggregation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAggregation.UseVisualStyleBackColor = true;
            this.buttonAggregation.Click += new System.EventHandler(this.buttonAggregation_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Location = new System.Drawing.Point(10, 342);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(102, 31);
            this.buttonRectangle.TabIndex = 6;
            this.buttonRectangle.Text = "Rectangle";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(118, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 426);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // CreateNewClassButton
            // 
            this.CreateNewClassButton.Location = new System.Drawing.Point(10, 379);
            this.CreateNewClassButton.Name = "CreateNewClassButton";
            this.CreateNewClassButton.Size = new System.Drawing.Size(102, 31);
            this.CreateNewClassButton.TabIndex = 8;
            this.CreateNewClassButton.Text = "NewClass";
            this.CreateNewClassButton.UseVisualStyleBackColor = true;
            this.CreateNewClassButton.Click += new System.EventHandler(this.CreateNewClassButton_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(693, 24);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(102, 31);
            this.Clearbutton.TabIndex = 9;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(708, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(693, 154);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Value = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.SystemColors.Control;
            this.colorDialog1.FullOpen = true;
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(693, 121);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(104, 27);
            this.buttonColor.TabIndex = 12;
            this.buttonColor.Text = "Choose a color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 449);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.CreateNewClassButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonRectangle);
            this.Controls.Add(this.buttonAggregation);
            this.Controls.Add(this.buttonComposition);
            this.Controls.Add(this.buttonRealization);
            this.Controls.Add(this.buttonAssociation);
            this.Controls.Add(this.buttonInheritance);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonInheritance;
        private System.Windows.Forms.Button buttonAssociation;
        private System.Windows.Forms.Button buttonRealization;
        private System.Windows.Forms.Button buttonComposition;
        private System.Windows.Forms.Button buttonAggregation;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CreateNewClassButton;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonColor;
    }
}

