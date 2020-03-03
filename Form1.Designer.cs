namespace Cave
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
            this.btnInitialize = new System.Windows.Forms.Button();
            this.btnNeighbors = new System.Windows.Forms.Button();
            this.btnDoors = new System.Windows.Forms.Button();
            this.lblNeighbors = new System.Windows.Forms.Label();
            this.lblDoors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInitialize
            // 
            this.btnInitialize.Location = new System.Drawing.Point(268, 107);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(110, 28);
            this.btnInitialize.TabIndex = 0;
            this.btnInitialize.Text = "Initialize cave";
            this.btnInitialize.UseVisualStyleBackColor = true;
            this.btnInitialize.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNeighbors
            // 
            this.btnNeighbors.Location = new System.Drawing.Point(268, 154);
            this.btnNeighbors.Name = "btnNeighbors";
            this.btnNeighbors.Size = new System.Drawing.Size(110, 23);
            this.btnNeighbors.TabIndex = 1;
            this.btnNeighbors.Text = "Get Neighbors";
            this.btnNeighbors.UseVisualStyleBackColor = true;
            this.btnNeighbors.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDoors
            // 
            this.btnDoors.Location = new System.Drawing.Point(268, 198);
            this.btnDoors.Name = "btnDoors";
            this.btnDoors.Size = new System.Drawing.Size(110, 28);
            this.btnDoors.TabIndex = 2;
            this.btnDoors.Text = "Get Door";
            this.btnDoors.UseVisualStyleBackColor = true;
            this.btnDoors.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblNeighbors
            // 
            this.lblNeighbors.AutoSize = true;
            this.lblNeighbors.Location = new System.Drawing.Point(415, 159);
            this.lblNeighbors.Name = "lblNeighbors";
            this.lblNeighbors.Size = new System.Drawing.Size(35, 13);
            this.lblNeighbors.TabIndex = 3;
            this.lblNeighbors.Text = "label1";
            // 
            // lblDoors
            // 
            this.lblDoors.AutoSize = true;
            this.lblDoors.Location = new System.Drawing.Point(415, 206);
            this.lblDoors.Name = "lblDoors";
            this.lblDoors.Size = new System.Drawing.Size(35, 13);
            this.lblDoors.TabIndex = 4;
            this.lblDoors.Text = "label2";
            this.lblDoors.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDoors);
            this.Controls.Add(this.lblNeighbors);
            this.Controls.Add(this.btnDoors);
            this.Controls.Add(this.btnNeighbors);
            this.Controls.Add(this.btnInitialize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.Button btnNeighbors;
        private System.Windows.Forms.Button btnDoors;
        private System.Windows.Forms.Label lblNeighbors;
        private System.Windows.Forms.Label lblDoors;
    }
}

