using InfoJobsHackUPC.Entities;
using OmplirDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.IO;

var context = new AppDbContext();

 void prova()
{
    DataTable tblcsv = new();  
    tblcsv.Columns.Add("ID");  
    tblcsv.Columns.Add("Orient");  
      
    string ReadCSV = File.ReadAllText("skills.csv"); 


    foreach (string csvRow in ReadCSV.Split('\n'))  
    {  
    if (!string.IsNullOrEmpty(csvRow))  
           {  
            tblcsv.Rows.Add();  
            int count = 0;  
            foreach (string FileRec in csvRow.Split(','))  
            {  
                tblcsv.Rows[tblcsv.Rows.Count - 1][count] = FileRec;  
                count++;  
            } 
            if (tblcsv.Rows.Count -1 > 0){
                //Console.WriteLine(tblcsv.Rows[tblcsv.Rows.Count -1][0] );
                try{
                    context.Add(new Skill(){
                        Id =  Convert.ToInt64(tblcsv.Rows[tblcsv.Rows.Count - 1][0].ToString()),
                        Name = (string) tblcsv.Rows[tblcsv.Rows.Count - 1][1]
                    });
                    context.SaveChanges();
                } catch (Exception){
                     //Console.WriteLine("Potato");
                }
           }
        }    
    }
}
    
prova();