using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Journal.Helpers
{
    public static class ExcelHelper
    {
        public static void SaveExcel(DataGridView save, string nameExcel)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), $"{nameExcel}.xlsx");
            try
            {
                Excel.Application excelapp = new Excel.Application();
                Excel.Workbook workbook = excelapp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.ActiveSheet;

                switch (nameExcel)
                {
                    case "Информация о группе":
                    case "Список групп":
                        worksheet = SaveGroup(worksheet, save);
                        break;
                    case "Журнал группы":
                    case "Успеваемость":
                        worksheet = SaveAllGrid(worksheet, save);
                        break;
                    case "Список учащихся":
                        worksheet = SaveStudents(worksheet, save);
                        break;
                    case "Список предметов":
                        worksheet = SaveSubjects(worksheet, save);
                        break;
                    case "Список преподавателей":
                        worksheet = SaveTeachers(worksheet, save);
                        break;
                    case "Список пользователей":
                        worksheet = SaveUsers(worksheet, save);
                        break;
                    case "Расписание":
                        worksheet = SaveTimetable(worksheet, save);
                        break;
                }

                worksheet.Columns.EntireColumn.AutoFit();
                excelapp.AlertBeforeOverwriting = false;
                workbook.SaveAs(path);
                excelapp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static Excel.Worksheet SaveGroup(Excel.Worksheet sheet, DataGridView grid)
        {
            sheet.Rows[1].Columns[1] = grid.Columns[1].HeaderText;
            sheet.Rows[1].Columns[2] = grid.Columns[2].HeaderText;

            for (int i = 1; i < grid.RowCount; i++)
            {
                sheet.Rows[i + 1].Columns[1] = grid.Rows[i - 1].Cells[1].Value;
                sheet.Rows[i + 1].Columns[2] = grid.Rows[i - 1].Cells[2].Value;
            }

            return sheet;
        }

        private static Excel.Worksheet SaveAllGrid(Excel.Worksheet sheet, DataGridView grid)
        {
            for (int i = 1; i < grid.RowCount; i++)
            {
                for (int j = 1; j <= grid.ColumnCount; j++)
                {
                    sheet.Rows[i + 1].Columns[j] = grid.Rows[i - 1].Cells[j - 1].Value;
                }
            }
            for (int i = 0; i < grid.ColumnCount; i++)
            {
                sheet.Rows[1].Columns[i + 1] = grid.Columns[i].HeaderText;
            }

            return sheet;
        }

        private static Excel.Worksheet SaveStudents(Excel.Worksheet sheet, DataGridView grid)
        {
            sheet.Rows[1].Columns[1] = grid.Columns[1].HeaderText;
            sheet.Rows[1].Columns[2] = grid.Columns[5].HeaderText;
            sheet.Rows[1].Columns[3] = grid.Columns[6].HeaderText;

            for (int i = 1; i < grid.RowCount; i++)
            {
                sheet.Rows[i + 1].Columns[1] = grid.Rows[i - 1].Cells[1].Value;
                sheet.Rows[i + 1].Columns[2] = grid.Rows[i - 1].Cells[5].Value;
                sheet.Rows[i + 1].Columns[3] = grid.Rows[i - 1].Cells[6].Value;
            }

            return sheet;
        }

        private static Excel.Worksheet SaveSubjects(Excel.Worksheet sheet, DataGridView grid)
        {
            sheet.Rows[1].Columns[1] = grid.Columns[1].HeaderText;
            sheet.Rows[1].Columns[2] = grid.Columns[2].HeaderText;
            sheet.Rows[1].Columns[3] = grid.Columns[7].HeaderText;

            for (int i = 1; i < grid.RowCount; i++)
            {
                sheet.Rows[i + 1].Columns[1] = grid.Rows[i - 1].Cells[1].Value;
                sheet.Rows[i + 1].Columns[2] = grid.Rows[i - 1].Cells[2].Value;
                sheet.Rows[i + 1].Columns[3] = grid.Rows[i - 1].Cells[7].Value;
            }

            return sheet;
        }

        private static Excel.Worksheet SaveTeachers(Excel.Worksheet sheet, DataGridView grid)
        {
            sheet.Rows[1].Columns[1] = grid.Columns[1].HeaderText;

            for (int i = 1; i < grid.RowCount; i++)
            {
                sheet.Rows[i + 1].Columns[1] = grid.Rows[i - 1].Cells[1].Value;
            }

            return sheet;
        }

        private static Excel.Worksheet SaveUsers(Excel.Worksheet sheet, DataGridView grid)
        {
            sheet.Rows[1].Columns[1] = grid.Columns[1].HeaderText;
            sheet.Rows[1].Columns[2] = grid.Columns[5].HeaderText;

            for (int i = 1; i < grid.RowCount; i++)
            {
                sheet.Rows[i + 1].Columns[1] = grid.Rows[i - 1].Cells[1].Value;
                sheet.Rows[i + 1].Columns[2] = grid.Rows[i - 1].Cells[5].Value;
            }

            return sheet;
        }

        private static Excel.Worksheet SaveTimetable(Excel.Worksheet sheet, DataGridView grid)
        {
            sheet.Rows[1].Columns[1] = grid.Columns[1].HeaderText;
            sheet.Rows[1].Columns[2] = grid.Columns[2].HeaderText;
            sheet.Rows[1].Columns[3] = grid.Columns[4].HeaderText;
            sheet.Rows[1].Columns[4] = grid.Columns[9].HeaderText;
            sheet.Rows[1].Columns[5] = grid.Columns[12].HeaderText;

            for (int i = 1; i < grid.RowCount; i++)
            {
                sheet.Rows[i + 1].Columns[1] = grid.Rows[i - 1].Cells[1].Value;
                sheet.Rows[i + 1].Columns[2] = grid.Rows[i - 1].Cells[2].Value;
                sheet.Rows[i + 1].Columns[3] = grid.Rows[i - 1].Cells[4].Value;
                sheet.Rows[i + 1].Columns[4] = grid.Rows[i - 1].Cells[9].Value;
                sheet.Rows[i + 1].Columns[5] = grid.Rows[i - 1].Cells[12].Value;
            }

            return sheet;
        }
    }
}
