﻿using CaseStudy.TestData;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Utilities
{
    internal class ExcelUtils
    {
        public static List<ExelData> ReadExcelData(string excelfilepath)
        {
            List<ExelData> excelDatas = new List<ExelData>();
            Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = File.Open(excelfilepath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true,
                        }
                    });
                    var dataTable = result.Tables["SearchProduct"];
                    foreach (DataRow row in dataTable.Rows)
                    {
                        ExelData excelData = new()
                        {
                            SearchText = row["Search"].ToString(),
                        };
                        excelDatas.Add(excelData);
                    }
                }
            }
            return excelDatas;
        }
    }
}
