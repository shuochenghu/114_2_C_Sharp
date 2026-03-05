namespace Review_Q2
{
    partial class Form1
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
            grpEngineService = new GroupBox();
            chkOilChange = new CheckBox();
            chkLubrication = new CheckBox();
            grpOtherService = new GroupBox();
            chkTransmission = new CheckBox();
            chkMufflerReplacement = new CheckBox();
            chkTireRotation = new CheckBox();
            grpCleaningService = new GroupBox();
            chkCarWash = new CheckBox();
            chkChassisCleaningRustProofing = new CheckBox();
            grpPartsAndLabor = new GroupBox();
            txtLaborHours = new TextBox();
            txtPartsCost = new TextBox();
            lblLaborHours = new Label();
            lblPartsCost = new Label();
            grpFeeSummary = new GroupBox();
            lblTotalFeesValue = new Label();
            lblTaxValue = new Label();
            lblPartsFeeValue = new Label();
            lblServiceLaborFeeValue = new Label();
            lblTotalFees = new Label();
            lblTax = new Label();
            lblPartsFee = new Label();
            lblServiceLaborFee = new Label();
            btnCalculateTotal = new Button();
            btnClear = new Button();
            btnExit = new Button();
            grpEngineService.SuspendLayout();
            grpOtherService.SuspendLayout();
            grpCleaningService.SuspendLayout();
            grpPartsAndLabor.SuspendLayout();
            grpFeeSummary.SuspendLayout();
            SuspendLayout();
            // 
            // grpEngineService
            // 
            grpEngineService.Controls.Add(chkOilChange);
            grpEngineService.Controls.Add(chkLubrication);
            grpEngineService.Location = new Point(24, 24);
            grpEngineService.Margin = new Padding(4);
            grpEngineService.Name = "grpEngineService";
            grpEngineService.Padding = new Padding(4);
            grpEngineService.Size = new Size(220, 121);
            grpEngineService.TabIndex = 0;
            grpEngineService.TabStop = false;
            grpEngineService.Text = "機油的潤滑";
            // 
            // chkOilChange
            // 
            chkOilChange.AutoSize = true;
            chkOilChange.Location = new Point(18, 36);
            chkOilChange.Margin = new Padding(4);
            chkOilChange.Name = "chkOilChange";
            chkOilChange.Size = new Size(190, 27);
            chkOilChange.TabIndex = 0;
            chkOilChange.Text = "更換機油 (NT$780)";
            chkOilChange.UseVisualStyleBackColor = true;
            // 
            // chkLubrication
            // 
            chkLubrication.AutoSize = true;
            chkLubrication.Location = new Point(18, 73);
            chkLubrication.Margin = new Padding(4);
            chkLubrication.Name = "chkLubrication";
            chkLubrication.Size = new Size(190, 27);
            chkLubrication.TabIndex = 1;
            chkLubrication.Text = "潤滑保養 (NT$540)";
            chkLubrication.UseVisualStyleBackColor = true;
            // 
            // grpOtherService
            // 
            grpOtherService.Controls.Add(chkTransmission);
            grpOtherService.Controls.Add(chkMufflerReplacement);
            grpOtherService.Controls.Add(chkTireRotation);
            grpOtherService.Location = new Point(24, 157);
            grpOtherService.Margin = new Padding(4);
            grpOtherService.Name = "grpOtherService";
            grpOtherService.Padding = new Padding(4);
            grpOtherService.Size = new Size(220, 157);
            grpOtherService.TabIndex = 1;
            grpOtherService.TabStop = false;
            grpOtherService.Text = "其他服務";
            // 
            // chkTransmission
            // 
            chkTransmission.AutoSize = true;
            chkTransmission.Location = new Point(18, 36);
            chkTransmission.Margin = new Padding(4);
            chkTransmission.Name = "chkTransmission";
            chkTransmission.Size = new Size(154, 27);
            chkTransmission.TabIndex = 0;
            chkTransmission.Text = "檢驗 (NT$450)";
            chkTransmission.UseVisualStyleBackColor = true;
            // 
            // chkMufflerReplacement
            // 
            chkMufflerReplacement.AutoSize = true;
            chkMufflerReplacement.Location = new Point(18, 73);
            chkMufflerReplacement.Margin = new Padding(4);
            chkMufflerReplacement.Name = "chkMufflerReplacement";
            chkMufflerReplacement.Size = new Size(222, 27);
            chkMufflerReplacement.TabIndex = 1;
            chkMufflerReplacement.Text = "更換消音器 (NT$3,000)";
            chkMufflerReplacement.UseVisualStyleBackColor = true;
            // 
            // chkTireRotation
            // 
            chkTireRotation.AutoSize = true;
            chkTireRotation.Location = new Point(18, 109);
            chkTireRotation.Margin = new Padding(4);
            chkTireRotation.Name = "chkTireRotation";
            chkTireRotation.Size = new Size(190, 27);
            chkTireRotation.TabIndex = 2;
            chkTireRotation.Text = "輪胎換位 (NT$600)";
            chkTireRotation.UseVisualStyleBackColor = true;
            // 
            // grpCleaningService
            // 
            grpCleaningService.Controls.Add(chkCarWash);
            grpCleaningService.Controls.Add(chkChassisCleaningRustProofing);
            grpCleaningService.Location = new Point(269, 24);
            grpCleaningService.Margin = new Padding(4);
            grpCleaningService.Name = "grpCleaningService";
            grpCleaningService.Padding = new Padding(4);
            grpCleaningService.Size = new Size(244, 121);
            grpCleaningService.TabIndex = 2;
            grpCleaningService.TabStop = false;
            grpCleaningService.Text = "清洗服務";
            // 
            // chkCarWash
            // 
            chkCarWash.AutoSize = true;
            chkCarWash.Location = new Point(18, 36);
            chkCarWash.Margin = new Padding(4);
            chkCarWash.Name = "chkCarWash";
            chkCarWash.Size = new Size(190, 27);
            chkCarWash.TabIndex = 0;
            chkCarWash.Text = "水箱清洗 (NT$900)";
            chkCarWash.UseVisualStyleBackColor = true;
            // 
            // chkChassisCleaningRustProofing
            // 
            chkChassisCleaningRustProofing.AutoSize = true;
            chkChassisCleaningRustProofing.Location = new Point(18, 73);
            chkChassisCleaningRustProofing.Margin = new Padding(4);
            chkChassisCleaningRustProofing.Name = "chkChassisCleaningRustProofing";
            chkChassisCleaningRustProofing.Size = new Size(222, 27);
            chkChassisCleaningRustProofing.TabIndex = 1;
            chkChassisCleaningRustProofing.Text = "變速箱清洗 (NT$2,400)";
            chkChassisCleaningRustProofing.UseVisualStyleBackColor = true;
            // 
            // grpPartsAndLabor
            // 
            grpPartsAndLabor.Controls.Add(txtLaborHours);
            grpPartsAndLabor.Controls.Add(txtPartsCost);
            grpPartsAndLabor.Controls.Add(lblLaborHours);
            grpPartsAndLabor.Controls.Add(lblPartsCost);
            grpPartsAndLabor.Location = new Point(269, 157);
            grpPartsAndLabor.Margin = new Padding(4);
            grpPartsAndLabor.Name = "grpPartsAndLabor";
            grpPartsAndLabor.Padding = new Padding(4);
            grpPartsAndLabor.Size = new Size(244, 157);
            grpPartsAndLabor.TabIndex = 3;
            grpPartsAndLabor.TabStop = false;
            grpPartsAndLabor.Text = "零件和工時";
            // 
            // txtLaborHours
            // 
            txtLaborHours.Location = new Point(134, 85);
            txtLaborHours.Margin = new Padding(4);
            txtLaborHours.Name = "txtLaborHours";
            txtLaborHours.Size = new Size(91, 30);
            txtLaborHours.TabIndex = 3;
            // 
            // txtPartsCost
            // 
            txtPartsCost.Location = new Point(134, 36);
            txtPartsCost.Margin = new Padding(4);
            txtPartsCost.Name = "txtPartsCost";
            txtPartsCost.Size = new Size(91, 30);
            txtPartsCost.TabIndex = 2;
            // 
            // lblLaborHours
            // 
            lblLaborHours.AutoSize = true;
            lblLaborHours.Location = new Point(18, 88);
            lblLaborHours.Margin = new Padding(4, 0, 4, 0);
            lblLaborHours.Name = "lblLaborHours";
            lblLaborHours.Size = new Size(117, 23);
            lblLaborHours.TabIndex = 1;
            lblLaborHours.Text = "工時數 (小時)";
            // 
            // lblPartsCost
            // 
            lblPartsCost.AutoSize = true;
            lblPartsCost.Location = new Point(18, 40);
            lblPartsCost.Margin = new Padding(4, 0, 4, 0);
            lblPartsCost.Name = "lblPartsCost";
            lblPartsCost.Size = new Size(98, 23);
            lblPartsCost.TabIndex = 0;
            lblPartsCost.Text = "零件 (NT$)";
            // 
            // grpFeeSummary
            // 
            grpFeeSummary.Controls.Add(lblTotalFeesValue);
            grpFeeSummary.Controls.Add(lblTaxValue);
            grpFeeSummary.Controls.Add(lblPartsFeeValue);
            grpFeeSummary.Controls.Add(lblServiceLaborFeeValue);
            grpFeeSummary.Controls.Add(lblTotalFees);
            grpFeeSummary.Controls.Add(lblTax);
            grpFeeSummary.Controls.Add(lblPartsFee);
            grpFeeSummary.Controls.Add(lblServiceLaborFee);
            grpFeeSummary.Location = new Point(24, 327);
            grpFeeSummary.Margin = new Padding(4);
            grpFeeSummary.Name = "grpFeeSummary";
            grpFeeSummary.Padding = new Padding(4);
            grpFeeSummary.Size = new Size(489, 194);
            grpFeeSummary.TabIndex = 4;
            grpFeeSummary.TabStop = false;
            grpFeeSummary.Text = "費用摘要";
            // 
            // lblTotalFeesValue
            // 
            lblTotalFeesValue.BorderStyle = BorderStyle.Fixed3D;
            lblTotalFeesValue.Location = new Point(159, 139);
            lblTotalFeesValue.Margin = new Padding(4, 0, 4, 0);
            lblTotalFeesValue.Name = "lblTotalFeesValue";
            lblTotalFeesValue.Size = new Size(147, 33);
            lblTotalFeesValue.TabIndex = 7;
            lblTotalFeesValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTaxValue
            // 
            lblTaxValue.BorderStyle = BorderStyle.Fixed3D;
            lblTaxValue.Location = new Point(159, 103);
            lblTaxValue.Margin = new Padding(4, 0, 4, 0);
            lblTaxValue.Name = "lblTaxValue";
            lblTaxValue.Size = new Size(147, 33);
            lblTaxValue.TabIndex = 6;
            lblTaxValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPartsFeeValue
            // 
            lblPartsFeeValue.BorderStyle = BorderStyle.Fixed3D;
            lblPartsFeeValue.Location = new Point(159, 67);
            lblPartsFeeValue.Margin = new Padding(4, 0, 4, 0);
            lblPartsFeeValue.Name = "lblPartsFeeValue";
            lblPartsFeeValue.Size = new Size(147, 33);
            lblPartsFeeValue.TabIndex = 5;
            lblPartsFeeValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblServiceLaborFeeValue
            // 
            lblServiceLaborFeeValue.BorderStyle = BorderStyle.Fixed3D;
            lblServiceLaborFeeValue.Location = new Point(159, 30);
            lblServiceLaborFeeValue.Margin = new Padding(4, 0, 4, 0);
            lblServiceLaborFeeValue.Name = "lblServiceLaborFeeValue";
            lblServiceLaborFeeValue.Size = new Size(147, 33);
            lblServiceLaborFeeValue.TabIndex = 4;
            lblServiceLaborFeeValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalFees
            // 
            lblTotalFees.AutoSize = true;
            lblTotalFees.Location = new Point(43, 143);
            lblTotalFees.Margin = new Padding(4, 0, 4, 0);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(64, 23);
            lblTotalFees.TabIndex = 3;
            lblTotalFees.Text = "總費用";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(43, 107);
            lblTax.Margin = new Padding(4, 0, 4, 0);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(99, 23);
            lblTax.TabIndex = 2;
            lblTax.Text = "稅金 (零件)";
            // 
            // lblPartsFee
            // 
            lblPartsFee.AutoSize = true;
            lblPartsFee.Location = new Point(43, 70);
            lblPartsFee.Margin = new Padding(4, 0, 4, 0);
            lblPartsFee.Name = "lblPartsFee";
            lblPartsFee.Size = new Size(46, 23);
            lblPartsFee.TabIndex = 1;
            lblPartsFee.Text = "零件";
            // 
            // lblServiceLaborFee
            // 
            lblServiceLaborFee.AutoSize = true;
            lblServiceLaborFee.Location = new Point(43, 34);
            lblServiceLaborFee.Margin = new Padding(4, 0, 4, 0);
            lblServiceLaborFee.Name = "lblServiceLaborFee";
            lblServiceLaborFee.Size = new Size(100, 23);
            lblServiceLaborFee.TabIndex = 0;
            lblServiceLaborFee.Text = "服務與工資";
            // 
            // btnCalculateTotal
            // 
            btnCalculateTotal.Location = new Point(86, 539);
            btnCalculateTotal.Margin = new Padding(4);
            btnCalculateTotal.Name = "btnCalculateTotal";
            btnCalculateTotal.Size = new Size(110, 42);
            btnCalculateTotal.TabIndex = 5;
            btnCalculateTotal.Text = "計算總額";
            btnCalculateTotal.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(214, 539);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 42);
            btnClear.TabIndex = 6;
            btnClear.Text = "清除";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(342, 539);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 42);
            btnExit.TabIndex = 7;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 605);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculateTotal);
            Controls.Add(grpFeeSummary);
            Controls.Add(grpPartsAndLabor);
            Controls.Add(grpCleaningService);
            Controls.Add(grpOtherService);
            Controls.Add(grpEngineService);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "汽車維修服務";
            grpEngineService.ResumeLayout(false);
            grpEngineService.PerformLayout();
            grpOtherService.ResumeLayout(false);
            grpOtherService.PerformLayout();
            grpCleaningService.ResumeLayout(false);
            grpCleaningService.PerformLayout();
            grpPartsAndLabor.ResumeLayout(false);
            grpPartsAndLabor.PerformLayout();
            grpFeeSummary.ResumeLayout(false);
            grpFeeSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpEngineService;
        private CheckBox chkOilChange;
        private CheckBox chkLubrication;
        private GroupBox grpOtherService;
        private CheckBox chkTransmission;
        private CheckBox chkMufflerReplacement;
        private CheckBox chkTireRotation;
        private GroupBox grpCleaningService;
        private CheckBox chkCarWash;
        private CheckBox chkChassisCleaningRustProofing;
        private GroupBox grpPartsAndLabor;
        private TextBox txtLaborHours;
        private TextBox txtPartsCost;
        private Label lblLaborHours;
        private Label lblPartsCost;
        private GroupBox grpFeeSummary;
        private Label lblTotalFeesValue;
        private Label lblTaxValue;
        private Label lblPartsFeeValue;
        private Label lblServiceLaborFeeValue;
        private Label lblTotalFees;
        private Label lblTax;
        private Label lblPartsFee;
        private Label lblServiceLaborFee;
        private Button btnCalculateTotal;
        private Button btnClear;
        private Button btnExit;
    }
}
