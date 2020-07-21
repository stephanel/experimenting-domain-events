namespace ExperimentingDomainEvents.WinForms
{
    partial class FormShipTrackingService
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
            this._shipsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._eventsTextBox = new System.Windows.Forms.TextBox();
            this._numberOfEventsCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TrackingOccuredTextBox = new System.Windows.Forms.TextBox();
            this.dgvShips = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._shipsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShips)).BeginInit();
            this.SuspendLayout();
            // 
            // _eventsTextBox
            // 
            this._eventsTextBox.Location = new System.Drawing.Point(12, 210);
            this._eventsTextBox.Multiline = true;
            this._eventsTextBox.Name = "_eventsTextBox";
            this._eventsTextBox.ReadOnly = true;
            this._eventsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._eventsTextBox.Size = new System.Drawing.Size(793, 199);
            this._eventsTextBox.TabIndex = 1;
            // 
            // _numberOfEventsCount
            // 
            this._numberOfEventsCount.Location = new System.Drawing.Point(705, 415);
            this._numberOfEventsCount.Name = "_numberOfEventsCount";
            this._numberOfEventsCount.Size = new System.Drawing.Size(100, 23);
            this._numberOfEventsCount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of Events Occured";
            // 
            // TrackingOccuredTextBox
            // 
            this.TrackingOccuredTextBox.Location = new System.Drawing.Point(12, 444);
            this.TrackingOccuredTextBox.Multiline = true;
            this.TrackingOccuredTextBox.Name = "TrackingOccuredTextBox";
            this.TrackingOccuredTextBox.ReadOnly = true;
            this.TrackingOccuredTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TrackingOccuredTextBox.Size = new System.Drawing.Size(793, 236);
            this.TrackingOccuredTextBox.TabIndex = 1;
            // 
            // dgvShips
            // 
            this.dgvShips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShips.Location = new System.Drawing.Point(12, 21);
            this.dgvShips.Name = "dgvShips";
            this.dgvShips.Size = new System.Drawing.Size(793, 183);
            this.dgvShips.TabIndex = 0;
            this.dgvShips.Text = "dataGridView1";
            this.dgvShips.Click += new System.EventHandler(this.dgvShips_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select a ship to view related events";
            // 
            // FormShipTrackingService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 692);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrackingOccuredTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._numberOfEventsCount);
            this.Controls.Add(this._eventsTextBox);
            this.Controls.Add(this.dgvShips);
            this.Name = "FormShipTrackingService";
            this.Text = "FormShipTrackingService";
            this.Load += new System.EventHandler(this.FormShipTrackingService_Load);
            ((System.ComponentModel.ISupportInitialize)(this._shipsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShips)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource _shipsBindingSource;
        private System.Windows.Forms.DataGridView dgvShips;
        private System.Windows.Forms.TextBox _eventsTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox _numberOfEventsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TrackingOccuredTextBox;
        private System.Windows.Forms.Label label2;
    }
}