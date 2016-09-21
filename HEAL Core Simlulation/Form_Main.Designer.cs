namespace HEAL_Core_Simlulation
{
    partial class frm_Main
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
            this.components = new System.ComponentModel.Container();
            this.gbox_Devices = new System.Windows.Forms.GroupBox();
            this.lbl_DevicesPackets = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbox_Acquisition = new System.Windows.Forms.GroupBox();
            this.lbl_DevicesNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbox_Transformation = new System.Windows.Forms.GroupBox();
            this.lbl_TransformedPacketsNo = new System.Windows.Forms.Label();
            this.lbl_TransformedPacketsLabel = new System.Windows.Forms.Label();
            this.gbox_Analytics = new System.Windows.Forms.GroupBox();
            this.gbox_Insights = new System.Windows.Forms.GroupBox();
            this.gbox_Storage = new System.Windows.Forms.GroupBox();
            this.gbox_HEAL = new System.Windows.Forms.GroupBox();
            this.btn_StopHeal = new System.Windows.Forms.Button();
            this.btn_StartHeal = new System.Windows.Forms.Button();
            this.timer_Insights = new System.Windows.Forms.Timer(this.components);
            this.lbl_PredictionPacketsNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbox_Devices.SuspendLayout();
            this.gbox_Acquisition.SuspendLayout();
            this.gbox_Transformation.SuspendLayout();
            this.gbox_Analytics.SuspendLayout();
            this.gbox_HEAL.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_Devices
            // 
            this.gbox_Devices.Controls.Add(this.lbl_DevicesPackets);
            this.gbox_Devices.Controls.Add(this.label1);
            this.gbox_Devices.Location = new System.Drawing.Point(12, 12);
            this.gbox_Devices.Name = "gbox_Devices";
            this.gbox_Devices.Size = new System.Drawing.Size(200, 176);
            this.gbox_Devices.TabIndex = 0;
            this.gbox_Devices.TabStop = false;
            this.gbox_Devices.Text = "Biometric Devices";
            // 
            // lbl_DevicesPackets
            // 
            this.lbl_DevicesPackets.AutoSize = true;
            this.lbl_DevicesPackets.Location = new System.Drawing.Point(6, 52);
            this.lbl_DevicesPackets.Name = "lbl_DevicesPackets";
            this.lbl_DevicesPackets.Size = new System.Drawing.Size(24, 25);
            this.lbl_DevicesPackets.TabIndex = 1;
            this.lbl_DevicesPackets.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device Packets";
            // 
            // gbox_Acquisition
            // 
            this.gbox_Acquisition.Controls.Add(this.lbl_DevicesNumber);
            this.gbox_Acquisition.Controls.Add(this.label3);
            this.gbox_Acquisition.Location = new System.Drawing.Point(218, 12);
            this.gbox_Acquisition.Name = "gbox_Acquisition";
            this.gbox_Acquisition.Size = new System.Drawing.Size(200, 176);
            this.gbox_Acquisition.TabIndex = 0;
            this.gbox_Acquisition.TabStop = false;
            this.gbox_Acquisition.Text = "Acquisition";
            // 
            // lbl_DevicesNumber
            // 
            this.lbl_DevicesNumber.AutoSize = true;
            this.lbl_DevicesNumber.Location = new System.Drawing.Point(6, 52);
            this.lbl_DevicesNumber.Name = "lbl_DevicesNumber";
            this.lbl_DevicesNumber.Size = new System.Drawing.Size(24, 25);
            this.lbl_DevicesNumber.TabIndex = 1;
            this.lbl_DevicesNumber.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Devices";
            // 
            // gbox_Transformation
            // 
            this.gbox_Transformation.Controls.Add(this.lbl_TransformedPacketsNo);
            this.gbox_Transformation.Controls.Add(this.lbl_TransformedPacketsLabel);
            this.gbox_Transformation.Location = new System.Drawing.Point(424, 12);
            this.gbox_Transformation.Name = "gbox_Transformation";
            this.gbox_Transformation.Size = new System.Drawing.Size(228, 176);
            this.gbox_Transformation.TabIndex = 0;
            this.gbox_Transformation.TabStop = false;
            this.gbox_Transformation.Text = "Transformation";
            // 
            // lbl_TransformedPacketsNo
            // 
            this.lbl_TransformedPacketsNo.AutoSize = true;
            this.lbl_TransformedPacketsNo.Location = new System.Drawing.Point(6, 52);
            this.lbl_TransformedPacketsNo.Name = "lbl_TransformedPacketsNo";
            this.lbl_TransformedPacketsNo.Size = new System.Drawing.Size(24, 25);
            this.lbl_TransformedPacketsNo.TabIndex = 1;
            this.lbl_TransformedPacketsNo.Text = "0";
            // 
            // lbl_TransformedPacketsLabel
            // 
            this.lbl_TransformedPacketsLabel.AutoSize = true;
            this.lbl_TransformedPacketsLabel.Location = new System.Drawing.Point(3, 27);
            this.lbl_TransformedPacketsLabel.Name = "lbl_TransformedPacketsLabel";
            this.lbl_TransformedPacketsLabel.Size = new System.Drawing.Size(216, 25);
            this.lbl_TransformedPacketsLabel.TabIndex = 0;
            this.lbl_TransformedPacketsLabel.Text = "Transformed Packets";
            // 
            // gbox_Analytics
            // 
            this.gbox_Analytics.Controls.Add(this.lbl_PredictionPacketsNo);
            this.gbox_Analytics.Controls.Add(this.label4);
            this.gbox_Analytics.Location = new System.Drawing.Point(658, 12);
            this.gbox_Analytics.Name = "gbox_Analytics";
            this.gbox_Analytics.Size = new System.Drawing.Size(191, 176);
            this.gbox_Analytics.TabIndex = 0;
            this.gbox_Analytics.TabStop = false;
            this.gbox_Analytics.Text = "Analytics";
            // 
            // gbox_Insights
            // 
            this.gbox_Insights.Location = new System.Drawing.Point(855, 12);
            this.gbox_Insights.Name = "gbox_Insights";
            this.gbox_Insights.Size = new System.Drawing.Size(200, 100);
            this.gbox_Insights.TabIndex = 0;
            this.gbox_Insights.TabStop = false;
            this.gbox_Insights.Text = "Insights";
            // 
            // gbox_Storage
            // 
            this.gbox_Storage.Location = new System.Drawing.Point(1061, 12);
            this.gbox_Storage.Name = "gbox_Storage";
            this.gbox_Storage.Size = new System.Drawing.Size(200, 100);
            this.gbox_Storage.TabIndex = 0;
            this.gbox_Storage.TabStop = false;
            this.gbox_Storage.Text = "Storage";
            // 
            // gbox_HEAL
            // 
            this.gbox_HEAL.Controls.Add(this.btn_StopHeal);
            this.gbox_HEAL.Controls.Add(this.btn_StartHeal);
            this.gbox_HEAL.Location = new System.Drawing.Point(12, 194);
            this.gbox_HEAL.Name = "gbox_HEAL";
            this.gbox_HEAL.Size = new System.Drawing.Size(257, 136);
            this.gbox_HEAL.TabIndex = 0;
            this.gbox_HEAL.TabStop = false;
            this.gbox_HEAL.Text = "HEAL";
            // 
            // btn_StopHeal
            // 
            this.btn_StopHeal.Location = new System.Drawing.Point(6, 82);
            this.btn_StopHeal.Name = "btn_StopHeal";
            this.btn_StopHeal.Size = new System.Drawing.Size(94, 41);
            this.btn_StopHeal.TabIndex = 1;
            this.btn_StopHeal.Text = "Stop";
            this.btn_StopHeal.UseVisualStyleBackColor = true;
            this.btn_StopHeal.Click += new System.EventHandler(this.btn_StopHeal_Click);
            // 
            // btn_StartHeal
            // 
            this.btn_StartHeal.Location = new System.Drawing.Point(6, 33);
            this.btn_StartHeal.Name = "btn_StartHeal";
            this.btn_StartHeal.Size = new System.Drawing.Size(94, 43);
            this.btn_StartHeal.TabIndex = 0;
            this.btn_StartHeal.Text = "Start";
            this.btn_StartHeal.UseVisualStyleBackColor = true;
            this.btn_StartHeal.Click += new System.EventHandler(this.btn_StartHeal_Click);
            // 
            // timer_Insights
            // 
            this.timer_Insights.Interval = 50;
            this.timer_Insights.Tick += new System.EventHandler(this.timer_Insights_Tick);
            // 
            // lbl_PredictionPacketsNo
            // 
            this.lbl_PredictionPacketsNo.AutoSize = true;
            this.lbl_PredictionPacketsNo.Location = new System.Drawing.Point(6, 52);
            this.lbl_PredictionPacketsNo.Name = "lbl_PredictionPacketsNo";
            this.lbl_PredictionPacketsNo.Size = new System.Drawing.Size(24, 25);
            this.lbl_PredictionPacketsNo.TabIndex = 3;
            this.lbl_PredictionPacketsNo.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Predicted Packets";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 715);
            this.Controls.Add(this.gbox_Insights);
            this.Controls.Add(this.gbox_Storage);
            this.Controls.Add(this.gbox_HEAL);
            this.Controls.Add(this.gbox_Acquisition);
            this.Controls.Add(this.gbox_Transformation);
            this.Controls.Add(this.gbox_Analytics);
            this.Controls.Add(this.gbox_Devices);
            this.Name = "frm_Main";
            this.Text = "HEAL Core Simulator";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.gbox_Devices.ResumeLayout(false);
            this.gbox_Devices.PerformLayout();
            this.gbox_Acquisition.ResumeLayout(false);
            this.gbox_Acquisition.PerformLayout();
            this.gbox_Transformation.ResumeLayout(false);
            this.gbox_Transformation.PerformLayout();
            this.gbox_Analytics.ResumeLayout(false);
            this.gbox_Analytics.PerformLayout();
            this.gbox_HEAL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_Devices;
        private System.Windows.Forms.GroupBox gbox_Acquisition;
        private System.Windows.Forms.GroupBox gbox_Transformation;
        private System.Windows.Forms.GroupBox gbox_Analytics;
        private System.Windows.Forms.GroupBox gbox_Insights;
        private System.Windows.Forms.GroupBox gbox_Storage;
        private System.Windows.Forms.GroupBox gbox_HEAL;
        private System.Windows.Forms.Button btn_StopHeal;
        private System.Windows.Forms.Button btn_StartHeal;
        private System.Windows.Forms.Label lbl_DevicesPackets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_DevicesNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_TransformedPacketsNo;
        private System.Windows.Forms.Label lbl_TransformedPacketsLabel;
        private System.Windows.Forms.Timer timer_Insights;
        private System.Windows.Forms.Label lbl_PredictionPacketsNo;
        private System.Windows.Forms.Label label4;
    }
}

