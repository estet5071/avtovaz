using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Model.Entities;
using Model.Enums;
using Model.ServiceAbstractions;

namespace Model.Services
{

    public class ReportService : IReportService
    {

        private ReportType _reportType;
        
        
        public ReportService()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public byte ReportType { set => _reportType = (ReportType)value; }
        public string Path { set; private get; }

    
        public bool CreateReport(DateTime? start, DateTime? end)
        {
            try
            {
                switch (_reportType)
                {
                    case Model.Enums.ReportType.Orders: CreateOrderReport(start, end); break;
                    case Model.Enums.ReportType.Customers: CreateCustomersReport(); break;
                    case Model.Enums.ReportType.Products: CreateProductReport(start, end); break;
                }
                return true;
            }

            catch (Exception)
            {
                return false;
            }
             
            
        }


        private void CreateOrderReport(DateTime? start, DateTime? end)
        {
            var filename = System.IO.Path.Combine(Path, $"Заказы {DateTime.Now:d}.xlsx");
            using ExcelPackage excelPackage = CreateExcelPackage(filename, "Заказы");
            var workSheet = excelPackage.Workbook.Worksheets.Add("Заказы");

            workSheet.Cells["A1:I1"].Merge = true;
            workSheet.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            workSheet.Cells["A1"].Style.Font.Bold = true;
            workSheet.Cells["A1"].Style.Font.Size = 14;
            workSheet.Cells["A1"].Value = $"Заказы ({start} - {end})";

            workSheet.Cells["A2:D2"].Merge = true;
            workSheet.Cells["A2:D2"].Value = "Клиент";
            workSheet.Cells["A2:D2"].Style.Font.Bold = true;

            workSheet.Cells["E2:H2"].Merge = true;
            workSheet.Cells["E2:H2"].Value = "Продавец";
            workSheet.Cells["E2:H2"].Style.Font.Bold = true;

            workSheet.Cells["I2:J2"].Merge = true;
            workSheet.Cells["I2:J2"].Value = "Кол-во продуктов";
            workSheet.Cells["I2:J2"].Style.Font.Bold = true;

            workSheet.Cells["K2:L2"].Merge = true;
            workSheet.Cells["K2:L2"].Value = "Сумма";
            workSheet.Cells["K2:L2"].Style.Font.Bold = true;

            workSheet.Cells["M2:N2"].Merge = true;
            workSheet.Cells["M2:N2"].Value = "Создан";
            workSheet.Cells["M2:N2"].Style.Font.Bold = true;

            workSheet.Cells["O2:P2"].Merge = true;
            workSheet.Cells["O2:P2"].Value = "Закрыт";
            workSheet.Cells["O2:P2"].Style.Font.Bold = true;

            int line = 3;
            var orders = GetOrderRecords(start, end);
            foreach (var item in orders)
            {
                workSheet.Cells[$"A{line}:D{line}"].Merge = true;
                workSheet.Cells[$"A{line}:D{line}"].Value = item.Customer.Name;

                workSheet.Cells[$"E{line}:H{line}"].Merge = true;
                workSheet.Cells[$"E{line}:H{line}"].Value = $"{item.Employee.LastName} {item.Employee.Name} {item.Employee.MiddleName}";

                workSheet.Cells[$"I{line}:J{line}"].Merge = true;
                workSheet.Cells[$"I{line}:J{line}"].Value = item.OrderProducts.Count;

                workSheet.Cells[$"K{line}:L{line}"].Merge = true;
                workSheet.Cells[$"K{line}:L{line}"].Style.Numberformat.Format = @"0,00 ₽";
                workSheet.Cells[$"K{line}:L{line}"].Value = item.Sum;

                workSheet.Cells[$"M{line}:N{line}"].Merge = true;
                workSheet.Cells[$"M{line}:N{line}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                workSheet.Cells[$"M{line}:N{line}"].Value = item.DateCreate.ToString();

                workSheet.Cells[$"O{line}:P{line}"].Merge = true;
                workSheet.Cells[$"O{line}:P{line}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                workSheet.Cells[$"O{line}:P{line}"].Value = item.DateClose.ToString();

                line++;
            }
            var file = new FileInfo(filename);

            excelPackage.SaveAs(file);
        }


        private void CreateCustomersReport()
        {
            var filename = System.IO.Path.Combine(Path, $"Данные о клиентах {DateTime.Now:d}.xlsx");

            using ExcelPackage excelPackage = CreateExcelPackage(filename, "Данные о клиентах");
            var workSheet = excelPackage.Workbook.Worksheets.Add("Данные о клиентах");

            workSheet.Cells["A1:I1"].Merge = true;
            workSheet.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            workSheet.Cells["A1"].Style.Font.Bold = true;
            workSheet.Cells["A1"].Style.Font.Size = 14;
            workSheet.Cells["A1"].Value = "Данные о клиентах";

            workSheet.Cells["A2:E2"].Merge = true;
            workSheet.Cells["A2:E2"].Value = "Название";
            workSheet.Cells["A2:E2"].Style.Font.Bold = true;

            workSheet.Cells["F2:G2"].Merge = true;
            workSheet.Cells["F2:G2"].Value = "Количество заказов";
            workSheet.Cells["F2:G2"].Style.Font.Bold = true;

            workSheet.Cells["H2:I2"].Merge = true;
            workSheet.Cells["H2:I2"].Value = "Общая сумма";
            workSheet.Cells["H2:I2"].Style.Font.Bold = true;
            OrderService orderService = new OrderService();
            int line = 3;
            var customers = new CustomerService().GetAll();
            foreach (var item in customers)
            {
                workSheet.Cells[$"A{line}:E{line}"].Merge = true;
                workSheet.Cells[$"A{line}:E{line}"].Value = item.Name;

                workSheet.Cells[$"F{line}:G{line}"].Merge = true;
                workSheet.Cells[$"F{line}:G{line}"].Value = item.Orders.Count;

                workSheet.Cells[$"H{line}:I{line}"].Merge = true;
                workSheet.Cells[$"H{line}:I{line}"].Style.Numberformat.Format = @"0,00 ₽";
                workSheet.Cells[$"H{line}:I{line}"].Value = item.Orders.Sum(o => o.Sum);

                line++;
            }
            var file = new FileInfo(filename);

            excelPackage.SaveAs(file);
        }


        private void CreateProductReport(DateTime? start, DateTime? end)
        {
            var filename = System.IO.Path.Combine(Path, $"Данные о продуктах {DateTime.Now:d}.xlsx");

            using ExcelPackage excelPackage = CreateExcelPackage(filename, "Данные о продуктах");
            var workSheet = excelPackage.Workbook.Worksheets.Add("Данные о продуктах");

            workSheet.Cells["A1:M1"].Merge = true;
            workSheet.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            workSheet.Cells["A1"].Style.Font.Bold = true;
            workSheet.Cells["A1"].Style.Font.Size = 14;
            workSheet.Cells["A1"].Value = $"Данные о продуктах ({start} - {end})";

            workSheet.Cells["A2:C2"].Merge = true;
            workSheet.Cells["A2:C2"].Value = "Название Продукта";
            workSheet.Cells["A2:C2"].Style.Font.Bold = true;

            workSheet.Cells["D2:E2"].Merge = true;
            workSheet.Cells["D2:E2"].Value = "Тип Кузова";
            workSheet.Cells["D2:E2"].Style.Font.Bold = true;

            workSheet.Cells["F2:H2"].Merge = true;
            workSheet.Cells["F2:H2"].Value = "Цвет";
            workSheet.Cells["F2:H2"].Style.Font.Bold = true;

            workSheet.Cells["I2:J2"].Merge = true;
            workSheet.Cells["I2:J2"].Value = "Дата выпуска";
            workSheet.Cells["I2:J2"].Style.Font.Bold = true;

            workSheet.Cells["K2:L2"].Merge = true;
            workSheet.Cells["K2:L2"].Value = "Стоимость";
            workSheet.Cells["K2:L2"].Style.Font.Bold = true;

            workSheet.Cells["M2:M2"].Merge = true;
            workSheet.Cells["M2:M2"].Value = "Продано";
            workSheet.Cells["M2:M2"].Style.Font.Bold = true;

            workSheet.Cells["N2:O2"].Merge = true;
            workSheet.Cells["N2:O2"].Value = "Сумма";
            workSheet.Cells["N2:O2"].Style.Font.Bold = true;

            int line = 3;
            var products = GetProductRecords(start, end);
            foreach (var item in products)
            {
                workSheet.Cells[$"A{line}:C{line}"].Merge = true;
                workSheet.Cells[$"A{line}:C{line}"].Value = item.Model;

                workSheet.Cells[$"D{line}:E{line}"].Merge = true;
                workSheet.Cells[$"D{line}:E{line}"].Value = item.BodyType;

                workSheet.Cells[$"F{line}:H{line}"].Merge = true;
                workSheet.Cells[$"F{line}:H{line}"].Value = item.Color;

                workSheet.Cells[$"I{line}:J{line}"].Merge = true;
                workSheet.Cells[$"I{line}:J{line}"].Value = item.DateCreate.ToShortDateString();

                workSheet.Cells[$"K{line}:L{line}"].Merge = true;
                workSheet.Cells[$"K{line}:L{line}"].Style.Numberformat.Format = @"0,00 ₽";
                if (item.ProductPrices.Count != 0)
                    workSheet.Cells[$"K{line}:L{line}"].Value = item.ProductPrices.Last().Value;
                else
                    workSheet.Cells[$"K{line}:L{line}"].Value = "Нет цены";

                workSheet.Cells[$"M{line}:M{line}"].Merge = true;
                workSheet.Cells[$"M{line}:M{line}"].Value = item.OrderProducts.Count;

                workSheet.Cells[$"N{line}:O{line}"].Merge = true;
                workSheet.Cells[$"N{line}:O{line}"].Style.Numberformat.Format = @"0,00 ₽";
                if (item.ProductPrices.Count != 0)
                    workSheet.Cells[$"N{line}:O{line}"].Value = item.OrderProducts.Sum(o => o.Product.ProductPrices.Last().Value);
                else
                    workSheet.Cells[$"N{line}:O{line}"].Value = "Нет цены";

                line++;
            }

            excelPackage.Save();
        }



        private List<Product> GetProductRecords(DateTime? start, DateTime? end)
        {
            List<Product> products = new ProductService().GetAll();
            if (start.HasValue)
                products = products.Where(x => x.DateCreate >= start).ToList();
            if (end.HasValue)
                products = products.Where(x => x.DateCreate <= end).ToList();
            return products;

        }


        private List<Order> GetOrderRecords(DateTime? start, DateTime? end)
        {
            List<Order> orders = new OrderService().GetAll();

            if (start != null)
                orders = orders.Where(o => o.DateCreate >= start).ToList();

            if (end != null)
                orders = orders.Where(o => o.DateCreate <= end).ToList();

            return orders;
        }


        private ExcelPackage CreateExcelPackage(string filename, string title)
        {
            File.Delete(filename);

            var ep = new ExcelPackage(new FileInfo(filename));
            ep.Workbook.Properties.Title = title;
            ep.Workbook.Properties.Created = DateTime.Now;

            return ep;
        }


    }

}

