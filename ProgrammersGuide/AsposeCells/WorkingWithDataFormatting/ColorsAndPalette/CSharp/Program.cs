//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Cells. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Cells;
using System.Drawing;

namespace ColorsAndPalette
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);

            //Instantiating an Workbook object
            Workbook workbook = new Workbook();

            //Adding Orchid color to the palette at 55th index
            workbook.ChangePalette(Color.Orchid, 55);

            //Adding a new worksheet to the Excel object
            int i = workbook.Worksheets.Add();

            //Obtaining the reference of the newly added worksheet by passing its sheet index
            Worksheet worksheet = workbook.Worksheets[i];

            //Accessing the "A1" cell from the worksheet
            Cell cell = worksheet.Cells["A1"];

            //Adding some value to the "A1" cell
            cell.PutValue("Hello Aspose!");

            //Defining new Style object
            Style styleObject = workbook.Styles[workbook.Styles.Add()];
            //Setting the Orchid (custom) color to the font
            styleObject.Font.Color = Color.Orchid;

            //Applying the style to the cell
            cell.SetStyle(styleObject);

            //Saving the Excel file
            workbook.Save(dataDir + "book1.xls", SaveFormat.Auto);

        }
    }
}