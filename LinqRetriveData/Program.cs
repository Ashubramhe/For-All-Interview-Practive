using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;


public class TableItem
{
    public int Id { get; set; } // Assuming the first column is of type int, change it accordingly
    public string Name { get; set; } // Assuming there is a second column of type string
    // Add more properties for other columns if needed
}

class Progarm
{
    static void Main()
    {
        List<TableItem> list = new List<TableItem>()
        {
            new TableItem { Id = 1,Name="Ashutosh"},
            new TableItem { Id = 2,Name="Darshan"},
            new TableItem { Id = 3,Name="Aniket"}
        };
       
        IEnumerable<object> firstCol= list.Select(A=>A.Name);


        foreach (var col in firstCol)
        {
            Console.WriteLine(col);
        }

        Console.ReadLine();
    }
}