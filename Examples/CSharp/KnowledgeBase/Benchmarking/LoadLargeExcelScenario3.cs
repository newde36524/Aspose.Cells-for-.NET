﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Cells.Examples.CSharp.KnowledgeBase.Benchmarking
{
    public class LoadLargeExcelScenario3
    {
        // ExStart:1
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            try
            {
                CreateAsposeCellsFile(dataDir + "Sample.xls", dataDir + "output_out.xls");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void CreateAsposeCellsFile(string filename_in, string filename_out)
        {
            DateTime start = DateTime.Now;
            Workbook workbook = new Workbook(filename_in);
            for (int i = 0; i < 100; i++)
            {
                Worksheet ws = workbook.Worksheets[i];
                Cells cells = ws.Cells;
                for (int c = 0; c < 10; c++)
                {
                    cells.InsertColumn(c);
                    cells[0, c].PutValue("Column" + c.ToString());
                }
            }
            workbook.Save(filename_out);
            DateTime end = DateTime.Now;
            TimeSpan time = end - start;
            Console.WriteLine("File Updated! \n" + "Time consumed (Seconds): " + time.TotalSeconds.ToString());
        }
        // ExEnd:1
    }
}
