
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
            this.Refactoring = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInheritance
            // 
            this.buttonInheritance.Location = new System.Drawing.Point(14, 65);
            this.buttonInheritance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonInheritance.Name = "buttonInheritance";
            this.buttonInheritance.Size = new System.Drawing.Size(117, 41);
            this.buttonInheritance.TabIndex = 1;
            this.buttonInheritance.Text = "Inheritance";
            this.buttonInheritance.UseVisualStyleBackColor = true;
            this.buttonInheritance.Click += new System.EventHandler(this.buttonInheritance_Click);
            // 
            // buttonAssociation
            // 
            this.buttonAssociation.Location = new System.Drawing.Point(14, 115);
            this.buttonAssociation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAssociation.Name = "buttonAssociation";
            this.buttonAssociation.Size = new System.Drawing.Size(117, 41);
            this.buttonAssociation.TabIndex = 2;
            this.buttonAssociation.Text = "Association";
            this.buttonAssociation.UseVisualStyleBackColor = true;
            this.buttonAssociation.Click += new System.EventHandler(this.buttonAssociation_Click);
            // 
            // buttonRealization
            // 
            this.buttonRealization.Location = new System.Drawing.Point(14, 164);
            this.buttonRealization.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRealization.Name = "buttonRealization";
            this.buttonRealization.Size = new System.Drawing.Size(117, 41);
            this.buttonRealization.TabIndex = 3;
            this.buttonRealization.Text = "Realization";
            this.buttonRealization.UseVisualStyleBackColor = true;
            this.buttonRealization.Click += new System.EventHandler(this.buttonRealization_Click);
            // 
            // buttonComposition
            // 
            this.buttonComposition.Location = new System.Drawing.Point(14, 213);
            this.buttonComposition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonComposition.Name = "buttonComposition";
            this.buttonComposition.Size = new System.Drawing.Size(117, 41);
            this.buttonComposition.TabIndex = 4;
            this.buttonComposition.Text = "Composition";
            this.buttonComposition.UseVisualStyleBackColor = true;
            this.buttonComposition.Click += new System.EventHandler(this.buttonComposition_Click);
            // 
            // buttonAggregation
            // 
            this.buttonAggregation.Location = new System.Drawing.Point(14, 263);
            this.buttonAggregation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAggregation.Name = "buttonAggregation";
            this.buttonAggregation.Size = new System.Drawing.Size(117, 41);
            this.buttonAggregation.TabIndex = 5;
            this.buttonAggregation.Text = "Aggregation";
            this.buttonAggregation.UseVisualStyleBackColor = true;
            this.buttonAggregation.Click += new System.EventHandler(this.buttonAggregation_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Location = new System.Drawing.Point(11, 312);
            this.buttonRectangle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(117, 41);
            this.buttonRectangle.TabIndex = 6;
            this.buttonRectangle.Text = "Rectangle";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(137, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1775, 1039);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // CreateNewClassButton
            // 
            this.CreateNewClassButton.Location = new System.Drawing.Point(14, 361);
            this.CreateNewClassButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateNewClassButton.Name = "CreateNewClassButton";
            this.CreateNewClassButton.Size = new System.Drawing.Size(117, 41);
            this.CreateNewClassButton.TabIndex = 8;
            this.CreateNewClassButton.Text = "NewClass";
            this.CreateNewClassButton.UseVisualStyleBackColor = true;
            this.CreateNewClassButton.Click += new System.EventHandler(this.CreateNewClassButton_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(11, 457);
            this.Clearbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(117, 41);
            this.Clearbutton.TabIndex = 9;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 569);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Refactoring
            // 
            this.Refactoring.Location = new System.Drawing.Point(11, 518);
            this.Refactoring.Name = "Refactoring";
            this.Refactoring.Size = new System.Drawing.Size(117, 24);
            this.Refactoring.TabIndex = 0;
            this.Refactoring.Text = "Refactoring";
            this.Refactoring.CheckedChanged += new System.EventHandler(this.Refactoring_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(11, 664);
            this.buttonMove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(117, 41);
            this.buttonMove.TabIndex = 12;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Refactoring);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.CheckBox Refactoring;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMove;
    }
}

