using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataTable_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable data = GetTable();
            foreach (DataRow row in data.Rows)
            {
                //print the column with index 1 in the form of string.
                Console.WriteLine(row.Field<string>(1));
            }
        }

        
        //DataTable is part of the System.Data.namespace
        static DataTable GetTable()
        {
            //Here we create a DataTable with four columns
            DataTable table = new DataTable();
            table.Columns.Add("Dosage", typeof(int));
            table.Columns.Add("Drug", typeof(string));
            table.Columns.Add("Patient", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));

            //Here we add five DataRows
            table.Rows.Add(25, "Indocin", "David", DateTime.Now);
            table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
            table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
            table.Rows.Add(21, "Combivent", "Janet", DateTime.Now);
            table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);

            return table;
        }
    }
}
