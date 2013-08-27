using OpenCBS.Controls;

namespace OpenCBS.GUI.Contracts
{
    partial class ReschedulingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReschedulingForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.interestRateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.installmentsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.newInstallmentsLabel = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.trancheConfigurationPanel = new System.Windows.Forms.Panel();
            this.firstRepaymentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.firstRepaymentOnLabel = new System.Windows.Forms.Label();
            this.gracePeriodLabel = new System.Windows.Forms.Label();
            this.gracePeriodNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.scheduleUserControl = new OpenCBS.Controls.ScheduleControl();
            this.contractCodeLabel = new System.Windows.Forms.Label();
            this.titleRescheduleContractLabel = new System.Windows.Forms.Label();
            this.chargeInterestDuringGracePeriodCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.interestRateNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installmentsNumericUpDown)).BeginInit();
            this.buttonsPanel.SuspendLayout();
            this.trancheConfigurationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gracePeriodNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = false;
            // 
            // interestRateLabel
            // 
            resources.ApplyResources(this.interestRateLabel, "interestRateLabel");
            this.interestRateLabel.Name = "interestRateLabel";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.startDateTimePicker, "startDateTimePicker");
            this.startDateTimePicker.Name = "startDateTimePicker";
            // 
            // startDateLabel
            // 
            resources.ApplyResources(this.startDateLabel, "startDateLabel");
            this.startDateLabel.Name = "startDateLabel";
            // 
            // interestRateNumericUpDown
            // 
            this.interestRateNumericUpDown.DecimalPlaces = 2;
            this.interestRateNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            resources.ApplyResources(this.interestRateNumericUpDown, "interestRateNumericUpDown");
            this.interestRateNumericUpDown.Name = "interestRateNumericUpDown";
            // 
            // installmentsNumericUpDown
            // 
            resources.ApplyResources(this.installmentsNumericUpDown, "installmentsNumericUpDown");
            this.installmentsNumericUpDown.Name = "installmentsNumericUpDown";
            // 
            // newInstallmentsLabel
            // 
            resources.ApplyResources(this.newInstallmentsLabel, "newInstallmentsLabel");
            this.newInstallmentsLabel.Name = "newInstallmentsLabel";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.okButton);
            this.buttonsPanel.Controls.Add(this.cancelButton);
            resources.ApplyResources(this.buttonsPanel, "buttonsPanel");
            this.buttonsPanel.Name = "buttonsPanel";
            // 
            // trancheConfigurationPanel
            // 
            this.trancheConfigurationPanel.Controls.Add(this.chargeInterestDuringGracePeriodCheckBox);
            this.trancheConfigurationPanel.Controls.Add(this.contractCodeLabel);
            this.trancheConfigurationPanel.Controls.Add(this.titleRescheduleContractLabel);
            this.trancheConfigurationPanel.Controls.Add(this.firstRepaymentDateTimePicker);
            this.trancheConfigurationPanel.Controls.Add(this.firstRepaymentOnLabel);
            this.trancheConfigurationPanel.Controls.Add(this.gracePeriodLabel);
            this.trancheConfigurationPanel.Controls.Add(this.gracePeriodNumericUpDown);
            this.trancheConfigurationPanel.Controls.Add(this.newInstallmentsLabel);
            this.trancheConfigurationPanel.Controls.Add(this.interestRateLabel);
            this.trancheConfigurationPanel.Controls.Add(this.startDateTimePicker);
            this.trancheConfigurationPanel.Controls.Add(this.installmentsNumericUpDown);
            this.trancheConfigurationPanel.Controls.Add(this.startDateLabel);
            this.trancheConfigurationPanel.Controls.Add(this.interestRateNumericUpDown);
            resources.ApplyResources(this.trancheConfigurationPanel, "trancheConfigurationPanel");
            this.trancheConfigurationPanel.Name = "trancheConfigurationPanel";
            // 
            // firstRepaymentDateTimePicker
            // 
            this.firstRepaymentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.firstRepaymentDateTimePicker, "firstRepaymentDateTimePicker");
            this.firstRepaymentDateTimePicker.Name = "firstRepaymentDateTimePicker";
            // 
            // firstRepaymentOnLabel
            // 
            resources.ApplyResources(this.firstRepaymentOnLabel, "firstRepaymentOnLabel");
            this.firstRepaymentOnLabel.Name = "firstRepaymentOnLabel";
            // 
            // gracePeriodLabel
            // 
            resources.ApplyResources(this.gracePeriodLabel, "gracePeriodLabel");
            this.gracePeriodLabel.Name = "gracePeriodLabel";
            // 
            // gracePeriodNumericUpDown
            // 
            resources.ApplyResources(this.gracePeriodNumericUpDown, "gracePeriodNumericUpDown");
            this.gracePeriodNumericUpDown.Name = "gracePeriodNumericUpDown";
            // 
            // scheduleUserControl
            // 
            resources.ApplyResources(this.scheduleUserControl, "scheduleUserControl");
            this.scheduleUserControl.Name = "scheduleUserControl";
            // 
            // contractCodeLabel
            // 
            resources.ApplyResources(this.contractCodeLabel, "contractCodeLabel");
            this.contractCodeLabel.Name = "contractCodeLabel";
            // 
            // titleRescheduleContractLabel
            // 
            resources.ApplyResources(this.titleRescheduleContractLabel, "titleRescheduleContractLabel");
            this.titleRescheduleContractLabel.Name = "titleRescheduleContractLabel";
            // 
            // chargeInterestDuringGracePeriodCheckBox
            // 
            resources.ApplyResources(this.chargeInterestDuringGracePeriodCheckBox, "chargeInterestDuringGracePeriodCheckBox");
            this.chargeInterestDuringGracePeriodCheckBox.Checked = true;
            this.chargeInterestDuringGracePeriodCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chargeInterestDuringGracePeriodCheckBox.Name = "chargeInterestDuringGracePeriodCheckBox";
            // 
            // ReschedulingForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.scheduleUserControl);
            this.Controls.Add(this.trancheConfigurationPanel);
            this.Controls.Add(this.buttonsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReschedulingForm";
            ((System.ComponentModel.ISupportInitialize)(this.interestRateNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installmentsNumericUpDown)).EndInit();
            this.buttonsPanel.ResumeLayout(false);
            this.trancheConfigurationPanel.ResumeLayout(false);
            this.trancheConfigurationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gracePeriodNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.NumericUpDown interestRateNumericUpDown;
        private System.Windows.Forms.NumericUpDown installmentsNumericUpDown;
        private System.Windows.Forms.Label newInstallmentsLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Panel trancheConfigurationPanel;
        private System.Windows.Forms.Label gracePeriodLabel;
        private System.Windows.Forms.NumericUpDown gracePeriodNumericUpDown;
        private System.Windows.Forms.DateTimePicker firstRepaymentDateTimePicker;
        private System.Windows.Forms.Label firstRepaymentOnLabel;
        private ScheduleControl scheduleUserControl;
        private System.Windows.Forms.Label contractCodeLabel;
        private System.Windows.Forms.Label titleRescheduleContractLabel;
        private System.Windows.Forms.CheckBox chargeInterestDuringGracePeriodCheckBox;
    }
}