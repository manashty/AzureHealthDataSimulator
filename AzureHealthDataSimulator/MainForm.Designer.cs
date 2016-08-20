namespace AzureHealthDataSimulator
{
    partial class MainForm
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
            this.btn_StartSimulation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_StartSimulation
            // 
            this.btn_StartSimulation.Location = new System.Drawing.Point(75, 51);
            this.btn_StartSimulation.Name = "btn_StartSimulation";
            this.btn_StartSimulation.Size = new System.Drawing.Size(133, 80);
            this.btn_StartSimulation.TabIndex = 0;
            this.btn_StartSimulation.Text = "Start Simulation";
            this.btn_StartSimulation.UseVisualStyleBackColor = true;
            this.btn_StartSimulation.Click += new System.EventHandler(this.btn_StartSimulation_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_StartSimulation);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_StartSimulation;
    }
}

