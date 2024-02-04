using System;
using System.Collections.Generic;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml;

namespace Master_Csharp.DataColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new DataTable
            DataTable table = new DataTable("Employee");

            // Create a new DataColumn
            DataColumn column = new DataColumn();
            column.DataType = typeof(int);
            column.ColumnName = "EmployeeID";
            column.AutoIncrement = true;
            column.Unique = true;

            // Add the column to the DataTable
            table.Columns.Add(column);

            // Print the column properties
            Console.WriteLine("Column Name: " + column.ColumnName);
            Console.WriteLine("Data Type: " + column.DataType);
            Console.WriteLine("AutoIncrement: " + column.AutoIncrement);
            Console.WriteLine("Unique: " + column.Unique);







    /*        In C#, DataColumn is a class defined in the .NET Framework's System.Data namespace. I
     *        
     *        t is used in conjunction with the DataTable class to define the structure of columns within a data table.

A DataColumn object represents a single column of data within a DataTable. It defines properties such as the column's name, 
   data type, constraints, and default values. Here are some key aspects of the DataColumn class:

ColumnName: It represents the name of the column.

DataType: It specifies the data type of the values that can be stored in the column.

DefaultValue: It represents the default value for the column.

AllowDBNull: It indicates whether the column allows null values.

Unique: It specifies whether values in the column must be unique across rows.

AutoIncrement: It indicates whether the column automatically increments its value when new rows are added.

MaxLength: It specifies the maximum length of the data in the colum*/
        }
    }
}
