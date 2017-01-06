namespace Periphery
{
    partial class mnWnd_periphery
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
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnCalculateAverage = new System.Windows.Forms.Button();
            this.btn_Create_Periphery = new System.Windows.Forms.Button();
            this.btn_Start_Simulation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(12, 12);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(137, 23);
            this.btnCapture.TabIndex = 1;
            this.btnCapture.Text = "Capture Screen";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnCalculateAverage
            // 
            this.btnCalculateAverage.Location = new System.Drawing.Point(13, 42);
            this.btnCalculateAverage.Name = "btnCalculateAverage";
            this.btnCalculateAverage.Size = new System.Drawing.Size(136, 23);
            this.btnCalculateAverage.TabIndex = 2;
            this.btnCalculateAverage.Text = "Calculate Average";
            this.btnCalculateAverage.UseVisualStyleBackColor = true;
            this.btnCalculateAverage.Click += new System.EventHandler(this.btnCalculateAverage_Click);
            // 
            // btn_Create_Periphery
            // 
            this.btn_Create_Periphery.Location = new System.Drawing.Point(13, 72);
            this.btn_Create_Periphery.Name = "btn_Create_Periphery";
            this.btn_Create_Periphery.Size = new System.Drawing.Size(136, 23);
            this.btn_Create_Periphery.TabIndex = 3;
            this.btn_Create_Periphery.Text = "Create Periphery";
            this.btn_Create_Periphery.UseVisualStyleBackColor = true;
            this.btn_Create_Periphery.Click += new System.EventHandler(this.btn_Create_Periphery_Click);
            // 
            // btn_Start_Simulation
            // 
            this.btn_Start_Simulation.Location = new System.Drawing.Point(13, 102);
            this.btn_Start_Simulation.Name = "btn_Start_Simulation";
            this.btn_Start_Simulation.Size = new System.Drawing.Size(136, 23);
            this.btn_Start_Simulation.TabIndex = 4;
            this.btn_Start_Simulation.Text = "Start Simulation";
            this.btn_Start_Simulation.UseVisualStyleBackColor = true;
            this.btn_Start_Simulation.Click += new System.EventHandler(this.btn_Start_Simulation_Click);
            // 
            // mnWnd_periphery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Start_Simulation);
            this.Controls.Add(this.btn_Create_Periphery);
            this.Controls.Add(this.btnCalculateAverage);
            this.Controls.Add(this.btnCapture);
            this.Name = "mnWnd_periphery";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mnWnd_periphery_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnCalculateAverage;
        private System.Windows.Forms.Button btn_Create_Periphery;
        private System.Windows.Forms.Button btn_Start_Simulation;
    }
}

