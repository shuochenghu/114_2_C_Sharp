namespace Review_Q2
{
    public partial class Form1 : Form
    {
        private const decimal OIL_CHANGE_PRICE = 780m;
        private const decimal LUBRICATION_PRICE = 540m;
        private const decimal CAR_WASH_PRICE = 900m;
        private const decimal CHASSIS_CLEANING_PRICE = 2400m;
        private const decimal TRANSMISSION_PRICE = 450m;
        private const decimal MUFFLER_REPLACEMENT_PRICE = 3000m;
        private const decimal TIRE_ROTATION_PRICE = 600m;
        private const decimal LABOR_RATE = 600m;
        private const decimal TAX_RATE = 0.06m;

        public Form1()
        {
            InitializeComponent();
            btnCalculateTotal.Click += calculateButton_Click;
            btnClear.Click += clearButton_Click;
            btnExit.Click += exitButton_Click;
        }

        private decimal GetPartsCost()
        {
            return decimal.TryParse(txtPartsCost.Text, out decimal parts) && parts >= 0 ? parts : 0m;
        }

        private decimal GetLaborHours()
        {
            return decimal.TryParse(txtLaborHours.Text, out decimal hours) && hours >= 0 ? hours : 0m;
        }

        private decimal GetLaborFee()
        {
            return GetLaborHours() * LABOR_RATE;
        }

        private decimal OilLubeCharges()
        {
            decimal charges = 0m;

            if (chkOilChange.Checked)
                charges += OIL_CHANGE_PRICE;

            if (chkLubrication.Checked)
                charges += LUBRICATION_PRICE;

            return charges;
        }

        private decimal FlushCharges()
        {
            decimal charges = 0m;

            if (chkCarWash.Checked)
                charges += CAR_WASH_PRICE;

            if (chkChassisCleaningRustProofing.Checked)
                charges += CHASSIS_CLEANING_PRICE;

            return charges;
        }

        private decimal MiscCharges()
        {
            decimal charges = 0m;

            if (chkTransmission.Checked)
                charges += TRANSMISSION_PRICE;

            if (chkMufflerReplacement.Checked)
                charges += MUFFLER_REPLACEMENT_PRICE;

            if (chkTireRotation.Checked)
                charges += TIRE_ROTATION_PRICE;

            return charges;
        }

        private decimal ServiceCharges()
        {
            return OilLubeCharges() + FlushCharges() + MiscCharges();
        }

        private decimal ServiceLaborFee()
        {
            return ServiceCharges() + GetLaborFee();
        }

        private decimal TaxCharges()
        {
            return GetPartsCost() * TAX_RATE;
        }

        private decimal TotalCharges()
        {
            return ServiceLaborFee() + GetPartsCost() + TaxCharges();
        }

        private void calculateButton_Click(object? sender, EventArgs e)
        {
            lblServiceLaborFeeValue.Text = ServiceLaborFee().ToString("N0");
            lblPartsFeeValue.Text = GetPartsCost().ToString("N0");
            lblTaxValue.Text = TaxCharges().ToString("N0");
            lblTotalFeesValue.Text = TotalCharges().ToString("N0");
        }

        private void clearButton_Click(object? sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        private void exitButton_Click(object? sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "是否要儲存維修明細到檔案？",
                "儲存確認",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SaveServiceDetailsToFile();
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void ClearOilLube()
        {
            chkOilChange.Checked = false;
            chkLubrication.Checked = false;
        }

        private void ClearFlushes()
        {
            chkCarWash.Checked = false;
            chkChassisCleaningRustProofing.Checked = false;
        }

        private void ClearMisc()
        {
            chkTransmission.Checked = false;
            chkMufflerReplacement.Checked = false;
            chkTireRotation.Checked = false;
        }

        private void ClearOther()
        {
            txtPartsCost.Clear();
            txtLaborHours.Clear();
        }

        private void ClearFees()
        {
            lblServiceLaborFeeValue.Text = string.Empty;
            lblPartsFeeValue.Text = string.Empty;
            lblTaxValue.Text = string.Empty;
            lblTotalFeesValue.Text = string.Empty;
        }

        private void WriteServiceSection(StreamWriter writer, string title, List<(bool isChecked, string name, decimal price)> services, decimal subtotal)
        {
            writer.WriteLine($"【{title}】");
            
            bool hasSelectedItems = services.Any(s => s.isChecked);
            
            if (hasSelectedItems)
            {
                foreach (var service in services.Where(s => s.isChecked))
                {
                    writer.WriteLine($"  ? {service.name}：NT$ {service.price:N0}");
                }
            }
            else
            {
                writer.WriteLine("  (無選擇項目)");
            }
            
            writer.WriteLine($"  小計：NT$ {subtotal:N0}");
            writer.WriteLine();
        }

        private void SaveServiceDetailsToFile()
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "文字檔案 (*.txt)|*.txt|所有檔案 (*.*)|*.*",
                    FilterIndex = 1,
                    DefaultExt = "txt",
                    FileName = $"維修明細_{DateTime.Now:yyyyMMdd_HHmmss}.txt"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.UTF8))
                    {
                        writer.WriteLine("========================================");
                        writer.WriteLine("       汽車維修服務明細報表");
                        writer.WriteLine("========================================");
                        writer.WriteLine($"日期時間：{DateTime.Now:yyyy/MM/dd HH:mm:ss}");
                        writer.WriteLine();

                        var oilLubeServices = new List<(bool, string, decimal)>
                        {
                            (chkOilChange.Checked, "更換機油", OIL_CHANGE_PRICE),
                            (chkLubrication.Checked, "潤滑保養", LUBRICATION_PRICE)
                        };
                        WriteServiceSection(writer, "機油的潤滑", oilLubeServices, OilLubeCharges());

                        var flushServices = new List<(bool, string, decimal)>
                        {
                            (chkCarWash.Checked, "水箱清洗", CAR_WASH_PRICE),
                            (chkChassisCleaningRustProofing.Checked, "鋁鏈清洗+防鏽", CHASSIS_CLEANING_PRICE)
                        };
                        WriteServiceSection(writer, "清洗服務", flushServices, FlushCharges());

                        var miscServices = new List<(bool, string, decimal)>
                        {
                            (chkTransmission.Checked, "檢驗", TRANSMISSION_PRICE),
                            (chkMufflerReplacement.Checked, "更換消音器", MUFFLER_REPLACEMENT_PRICE),
                            (chkTireRotation.Checked, "輪胎換位", TIRE_ROTATION_PRICE)
                        };
                        WriteServiceSection(writer, "其他服務", miscServices, MiscCharges());

                        writer.WriteLine("【零件和工時】");
                        decimal partsCost = GetPartsCost();
                        decimal laborHours = GetLaborHours();
                        writer.WriteLine($"  零件費用：NT$ {partsCost:N0}");
                        writer.WriteLine($"  工時數：{laborHours:N2} 小時");
                        writer.WriteLine($"  工時費用：NT$ {GetLaborFee():N0} (@ NT$ {LABOR_RATE:N0}/小時)");
                        writer.WriteLine();

                        writer.WriteLine("========================================");
                        writer.WriteLine("【費用摘要】");
                        writer.WriteLine("========================================");
                        writer.WriteLine($"服務與工資：NT$ {ServiceLaborFee():N0}");
                        writer.WriteLine($"零件：NT$ {partsCost:N0}");
                        writer.WriteLine($"稅金 (零件)：NT$ {TaxCharges():N0} (6%)");
                        writer.WriteLine("----------------------------------------");
                        writer.WriteLine($"總費用：NT$ {TotalCharges():N0}");
                        writer.WriteLine("========================================");
                    }

                    MessageBox.Show(
                        $"維修明細已成功儲存至：\n{saveFileDialog.FileName}",
                        "儲存成功",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"儲存檔案時發生錯誤：\n{ex.Message}",
                    "錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
