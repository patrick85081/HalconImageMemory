using HalconDotNet;

namespace HalconImageTest
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMemoryLeak = new System.Windows.Forms.Button();
            this.btUsing = new System.Windows.Forms.Button();
            this.hWindowControl = new HalconDotNet.HWindowControl();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMemoryLeak
            // 
            this.btnMemoryLeak.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMemoryLeak.Location = new System.Drawing.Point(11, 394);
            this.btnMemoryLeak.Name = "btnMemoryLeak";
            this.btnMemoryLeak.Size = new System.Drawing.Size(116, 71);
            this.btnMemoryLeak.TabIndex = 0;
            this.btnMemoryLeak.Text = "Function 1";
            this.btnMemoryLeak.UseVisualStyleBackColor = true;
            this.btnMemoryLeak.Click += new System.EventHandler(this.btnMemoryLeak_Click);
            // 
            // btUsing
            // 
            this.btUsing.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btUsing.Location = new System.Drawing.Point(133, 394);
            this.btUsing.Name = "btUsing";
            this.btUsing.Size = new System.Drawing.Size(116, 71);
            this.btUsing.TabIndex = 0;
            this.btUsing.Text = "Function 2";
            this.btUsing.UseVisualStyleBackColor = true;
            this.btUsing.Click += new System.EventHandler(this.btUsing_Click);
            // 
            // hWindowControl
            // 
            this.hWindowControl.BackColor = System.Drawing.Color.Black;
            this.hWindowControl.BorderColor = System.Drawing.Color.Black;
            this.hWindowControl.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowControl.Location = new System.Drawing.Point(12, 12);
            this.hWindowControl.Name = "hWindowControl";
            this.hWindowControl.Size = new System.Drawing.Size(413, 323);
            this.hWindowControl.TabIndex = 0;
            this.hWindowControl.WindowSize = new System.Drawing.Size(413, 323);
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStatus.Location = new System.Drawing.Point(22, 355);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(387, 23);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStop.Location = new System.Drawing.Point(255, 394);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(116, 71);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 480);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.hWindowControl);
            this.Controls.Add(this.btUsing);
            this.Controls.Add(this.btnMemoryLeak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMemoryLeak;
        private System.Windows.Forms.Button btUsing;
        private HalconDotNet.HWindowControl hWindowControl;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnStop;
    }
}

