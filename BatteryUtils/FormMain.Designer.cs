namespace BatteryUtils
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelStartThresholdInternal = new System.Windows.Forms.Label();
            this.labelStopThresholdInternal = new System.Windows.Forms.Label();
            this.startThresholdInternal = new System.Windows.Forms.NumericUpDown();
            this.stopThresholdInternal = new System.Windows.Forms.NumericUpDown();
            this.monitorOFF = new System.Windows.Forms.Button();
            this.applyThreshold = new System.Windows.Forms.Button();
            this.labelStartThresholdExternal = new System.Windows.Forms.Label();
            this.labelStopThresholdExternal = new System.Windows.Forms.Label();
            this.startThresholdExternal = new System.Windows.Forms.NumericUpDown();
            this.stopThresholdExternal = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startThresholdInternal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopThresholdInternal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startThresholdExternal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopThresholdExternal)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStartThresholdInternal
            // 
            this.labelStartThresholdInternal.AutoSize = true;
            this.labelStartThresholdInternal.Location = new System.Drawing.Point(22, 51);
            this.labelStartThresholdInternal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartThresholdInternal.Name = "labelStartThresholdInternal";
            this.labelStartThresholdInternal.Size = new System.Drawing.Size(377, 18);
            this.labelStartThresholdInternal.TabIndex = 0;
            this.labelStartThresholdInternal.Text = "Internal battery start charge threshold %";
            // 
            // labelStopThresholdInternal
            // 
            this.labelStopThresholdInternal.AutoSize = true;
            this.labelStopThresholdInternal.Location = new System.Drawing.Point(22, 92);
            this.labelStopThresholdInternal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStopThresholdInternal.Name = "labelStopThresholdInternal";
            this.labelStopThresholdInternal.Size = new System.Drawing.Size(368, 18);
            this.labelStopThresholdInternal.TabIndex = 1;
            this.labelStopThresholdInternal.Text = "Internal battery stop charge threshold %";
            // 
            // startThresholdInternal
            // 
            this.startThresholdInternal.Location = new System.Drawing.Point(420, 49);
            this.startThresholdInternal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startThresholdInternal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startThresholdInternal.Name = "startThresholdInternal";
            this.startThresholdInternal.Size = new System.Drawing.Size(94, 28);
            this.startThresholdInternal.TabIndex = 2;
            this.startThresholdInternal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // stopThresholdInternal
            // 
            this.stopThresholdInternal.Location = new System.Drawing.Point(420, 90);
            this.stopThresholdInternal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopThresholdInternal.Minimum = this.startThresholdInternal.Value;
            this.stopThresholdInternal.Name = "stopThresholdInternal";
            this.stopThresholdInternal.Size = new System.Drawing.Size(94, 28);
            this.stopThresholdInternal.TabIndex = 3;
            this.stopThresholdInternal.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // monitorOFF
            // 
            this.monitorOFF.Location = new System.Drawing.Point(285, 271);
            this.monitorOFF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.monitorOFF.Name = "monitorOFF";
            this.monitorOFF.Size = new System.Drawing.Size(140, 51);
            this.monitorOFF.TabIndex = 4;
            this.monitorOFF.Text = "Monitor OFF";
            this.monitorOFF.UseVisualStyleBackColor = true;
            this.monitorOFF.Click += new System.EventHandler(this.monitorOFF_Click);
            // 
            // applyThreshold
            // 
            this.applyThreshold.Location = new System.Drawing.Point(445, 271);
            this.applyThreshold.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.applyThreshold.Name = "applyThreshold";
            this.applyThreshold.Size = new System.Drawing.Size(153, 51);
            this.applyThreshold.TabIndex = 5;
            this.applyThreshold.Text = "Apply";
            this.applyThreshold.UseVisualStyleBackColor = true;
            this.applyThreshold.Click += new System.EventHandler(this.applyThreshold_Click);
            // 
            // labelStartThresholdExternal
            // 
            this.labelStartThresholdExternal.AutoSize = true;
            this.labelStartThresholdExternal.Location = new System.Drawing.Point(22, 139);
            this.labelStartThresholdExternal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartThresholdExternal.Name = "labelStartThresholdExternal";
            this.labelStartThresholdExternal.Size = new System.Drawing.Size(377, 18);
            this.labelStartThresholdExternal.TabIndex = 6;
            this.labelStartThresholdExternal.Text = "external battery start charge threshold %";
            // 
            // labelStopThresholdExternal
            // 
            this.labelStopThresholdExternal.AutoSize = true;
            this.labelStopThresholdExternal.Location = new System.Drawing.Point(22, 180);
            this.labelStopThresholdExternal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStopThresholdExternal.Name = "labelStopThresholdExternal";
            this.labelStopThresholdExternal.Size = new System.Drawing.Size(368, 18);
            this.labelStopThresholdExternal.TabIndex = 7;
            this.labelStopThresholdExternal.Text = "external battery stop charge threshold %";
            // 
            // startThresholdExternal
            // 
            this.startThresholdExternal.Location = new System.Drawing.Point(420, 137);
            this.startThresholdExternal.Margin = new System.Windows.Forms.Padding(4);
            this.startThresholdExternal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startThresholdExternal.Name = "startThresholdExternal";
            this.startThresholdExternal.Size = new System.Drawing.Size(94, 28);
            this.startThresholdExternal.TabIndex = 8;
            this.startThresholdExternal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // stopThresholdExternal
            // 
            this.stopThresholdExternal.Location = new System.Drawing.Point(420, 178);
            this.stopThresholdExternal.Margin = new System.Windows.Forms.Padding(4);
            this.stopThresholdExternal.Minimum = this.startThresholdInternal.Value;
            this.stopThresholdExternal.Name = "stopThresholdExternal";
            this.stopThresholdExternal.Size = new System.Drawing.Size(94, 28);
            this.stopThresholdExternal.TabIndex = 9;
            this.stopThresholdExternal.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "只支持联想双电池。单电池不要使用本工具！！";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 335);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopThresholdExternal);
            this.Controls.Add(this.startThresholdExternal);
            this.Controls.Add(this.labelStopThresholdExternal);
            this.Controls.Add(this.labelStartThresholdExternal);
            this.Controls.Add(this.applyThreshold);
            this.Controls.Add(this.monitorOFF);
            this.Controls.Add(this.stopThresholdInternal);
            this.Controls.Add(this.startThresholdInternal);
            this.Controls.Add(this.labelStopThresholdInternal);
            this.Controls.Add(this.labelStartThresholdInternal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battery Utils";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startThresholdInternal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopThresholdInternal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startThresholdExternal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopThresholdExternal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStartThresholdInternal;
        private System.Windows.Forms.Label labelStopThresholdInternal;
        private System.Windows.Forms.NumericUpDown startThresholdInternal;
        private System.Windows.Forms.NumericUpDown stopThresholdInternal;
        private System.Windows.Forms.Button monitorOFF;
        private System.Windows.Forms.Button applyThreshold;
        private System.Windows.Forms.Label labelStartThresholdExternal;
        private System.Windows.Forms.Label labelStopThresholdExternal;
        private System.Windows.Forms.NumericUpDown startThresholdExternal;
        private System.Windows.Forms.NumericUpDown stopThresholdExternal;
        private System.Windows.Forms.Label label1;
    }
}

