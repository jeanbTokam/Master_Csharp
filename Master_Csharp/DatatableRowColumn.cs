using System;
using System.ComponentModel;
using System.Data;

namespace interviews_practice
{
    public class DatatableRowColumn
    {
        public static void Main(string[] args)
        {
            //create a datatable
            DataTable dt = new DataTable();

            //add column
            dt.Columns.Add("NAME", typeof(string));
            dt.Columns.Add("JOBS", typeof(string));

            //create a new row
            DataRow row1 = dt.NewRow();

            //add value into rows 
            row1["NAME"] = "jb";
            row1["JOBS"] = "Software Engineer";

            // add row1 to Rows
            dt.Rows.Add(row1);


            //iterate and diplay Columns and Rows
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    Console.WriteLine($"{column.ColumnName}: {row[column]}");
                }
            }

            Console.WriteLine($"Total rows: {dt.Rows.Count}");


            dt.AsDataView().Dispose();
        }
    }
}
