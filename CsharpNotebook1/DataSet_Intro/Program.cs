using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataSet_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create two DataTable instances
            DataTable table1 = new DataTable("patients");
            table1.Columns.Add("name");
            table1.Columns.Add("id");
            table1.Rows.Add("sam", 1);
            table1.Rows.Add("mark", 2);

            DataTable table2 = new DataTable("medications");
            table2.Columns.Add("id");
            table2.Columns.Add("medication");
            table2.Rows.Add(1, "atenolol");
            table2.Rows.Add(2, "amoxicillin");

            //Create a DataSet and put both tables in it.
            DataSet set = new DataSet("office");
            set.Tables.Add(table1);
            set.Tables.Add(table2);
            
            //----------------------------

            //Visualize DataSet.
            Console.WriteLine(set.GetXml());

            //----------------------------

            //Show original DataSet name
            Console.WriteLine(set.DataSetName);

            //Change the DataSet name
            set.DataSetName = "unknown";
            Console.WriteLine(set.DataSetName);

            //----------------------------

            //Loop over DataTables in DataSet.
            DataTableCollection collection = set.Tables;
            for(int i = 0; i < collection.Count; i++)
            {
                DataTable table = collection[i];
                Console.WriteLine("{0}: {1}", i, table.TableName);
            }

            //Write name of first table.
            Console.WriteLine("x: {0}", set.Tables[0].TableName);

            //Write row count of medications table.
            Console.WriteLine("y: {0}", set.Tables["medications"].Rows.Count);
        }
    }
}
