using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace QLCuaHangDienThoai
{
    public class XuatExcel
    {
        public void ExportToExcel(DataGridView dataGridView, string sheetName, string[] listTitle, string fileName)
        {
            if (dataGridView.Rows.Count == 0 || dataGridView.Rows[0].IsNewRow)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog save = new SaveFileDialog
            {
                Filter = "Excel Workbook|*.xlsx",
                Title = "Xuất danh sách",
                FileName = fileName + ".xlsx"
            };

            if (save.ShowDialog() != DialogResult.OK)
                return;

            // SỬA: Thiết lập license cho EPPlus 8+ (non-commercial)
            ExcelPackage.License.SetNonCommercialOrganization("Truong DH CNTT");  // Thay bằng tên tổ chức của bạn

            using (var package = new ExcelPackage())
            {
                var ws = package.Workbook.Worksheets.Add(sheetName);

                // Tiêu đề cột
                for (int i = 0; i < listTitle.Length; i++)
                {
                    ws.Cells[1, i + 1].Value = listTitle[i];
                    ws.Cells[1, i + 1].Style.Font.Bold = true;
                    ws.Cells[1, i + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    ws.Cells[1, i + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                }

                // Dữ liệu
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    if (dataGridView.Rows[i].IsNewRow) continue;

                    for (int j = 0; j < listTitle.Length; j++)
                    {
                        var value = dataGridView.Rows[i].Cells[j].Value;
                        ws.Cells[i + 2, j + 1].Value = value?.ToString() ?? "";
                    }
                }

                // Tự động co giãn cột
                ws.Cells.AutoFitColumns();

                // Lưu file
                package.SaveAs(new System.IO.FileInfo(save.FileName));
            }

            MessageBox.Show("Xuất Excel thành công!\nĐã lưu tại: " + save.FileName, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
