using StatusMonitor_trial.Models;
using StatusMonitor_trial.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatusMonitor_trial.UI
{
    public partial class CheckField : BaseForm
    {
        private readonly List<PrinterInfo> _printersToCheck;
        private readonly List<string> _availableFields;
        private readonly PrinterInfo _sourcePrinter;
        public CheckField(List<PrinterInfo> selectedPrinters, List<string> availableFields, PrinterInfo sourcePrinter)
        {
            InitializeComponent();
            _printersToCheck = selectedPrinters;
            _availableFields = availableFields;
            _sourcePrinter = sourcePrinter;
        }
        private void CheckField_Load(object sender, EventArgs e)
        {
            // นำรายชื่อ Field ทั้งหมดมาใส่ใน ComboBox ทุกอัน
            var fields = new List<string> { "" }; // เพิ่มค่าว่างเข้าไปเป็นตัวเลือกแรก
            fields.AddRange(_availableFields);

            cmbField1.DataSource = new List<string>(fields);
            cmbField2.DataSource = new List<string>(fields);
            cmbField3.DataSource = new List<string>(fields);
            cmbField5.DataSource = new List<string>(fields);
            cmbField6.DataSource = new List<string>(fields);
        }

        private async void btnCheck_Click(object sender, EventArgs e)
        {
            btnCheck.Enabled = false;
            btnCheck.Text = "Checking...";

            var fieldsToCompare = new List<ComboBox> { cmbField1, cmbField2, cmbField3, cmbField5, cmbField6 }
                .Select(cmb => cmb.SelectedItem?.ToString())
                .Where(field => !string.IsNullOrEmpty(field))
                .Distinct()
                .ToList();

            if (!fieldsToCompare.Any())
            {
                MessageBox.Show("Please select at least one field to check.");
                btnCheck.Enabled = true;
                btnCheck.Text = "Check Fields";
                return;
            }

            var results = await PrinterService.CheckJobFieldsAsync(_printersToCheck);
            PopulateGrid(results, fieldsToCompare);

        }

        private void PopulateGrid(List<FieldCheckResult> results, List<string> fieldsToCompare)
        {
            dgvResults.Rows.Clear();
            dgvResults.Columns.Clear();

            dgvResults.Columns.Add("FieldName", "Field Name");

            foreach (var result in results) dgvResults.Columns.Add(result.PrinterName, result.PrinterName);

            var _sourceFieldValues = new Dictionary<string, string>();
            var sourceResult = results.FirstOrDefault(r => r.PrinterName == _sourcePrinter.Name && r.IsConnected);
            if (sourceResult != null)
            {
                _sourceFieldValues = fieldsToCompare
                    .Where(field => sourceResult.FieldValues.ContainsKey(field))
                    .ToDictionary(field => field, field => sourceResult.FieldValues[field]);
            }

            foreach (var fieldName in fieldsToCompare)
            {
                int rowIndex = dgvResults.Rows.Add();
                var row = dgvResults.Rows[rowIndex];
                row.Cells["FieldName"].Value = fieldName;

                foreach (var result in results)
                {
                    var cell = row.Cells[result.PrinterName];

                    if (!result.IsConnected || !string.IsNullOrEmpty(result.ErrorMessage))
                    {
                        cell.Value = "N/A";
                        cell.Style.BackColor = Color.Gray;
                        continue;
                    }

                    string remoteValue = result.FieldValues.ContainsKey(fieldName)
                        ? result.FieldValues[fieldName]
                        : "N/A";

                    cell.Value = remoteValue;
                    string sourceValue = _sourceFieldValues.ContainsKey(fieldName)
                        ? _sourceFieldValues[fieldName]
                        : "";

                    if (remoteValue == "N/A")
                    {
                        cell.Style.BackColor = Color.Yellow;
                    }
                    else if (remoteValue != sourceValue)
                    {
                        cell.Style.BackColor = Color.Salmon; // ไม่ตรง
                    }
                    else
                    {
                        cell.Style.BackColor = Color.LightGreen; // ตรงกัน
                    }
                }
            }
            btnCheck.Enabled = true;
            btnCheck.Text = "Check Fields";
        }

        private void pbCLRF1_Click(object sender, EventArgs e)
        {
            cmbField1.SelectedItem = null;
        }

        private void pbCLRF2_Click(object sender, EventArgs e)
        {
            cmbField2.SelectedItem = null;
        }

        private void pbCLRF3_Click(object sender, EventArgs e)
        {
            cmbField3.SelectedItem = null;
        }

        private void pbCLRF4_Click(object sender, EventArgs e)
        {
            cmbField5.SelectedItem = null;
        }
        private void pbCLRF5_Click(object sender, EventArgs e)
        {
            cmbField6.SelectedItem = null;
        }

    }
}
