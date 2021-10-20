using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace NomDuLogiciel
{
    class CsvEngine
    {
        private String csvFile;
        public List<String> inColumn;
        public List<String> outColumn;
        public List<Double> timestampColumn;
        public CsvEngine(String csvFile)
        {
            this.csvFile = csvFile;
        }

        public List<Double> CsvGetIn()
        {
            var localFIle = new LocalFile();
            String filePath = Path.Combine(localFIle.CsvDirectoryPath + csvFile);
            string[] csvLine = System.IO.File.ReadAllLines(filePath);

            inColumn = new List<String>();
            outColumn = new List<String>();

            for (int i = 1; i < csvLine.Length; i++)
            {
                String[] csvRow = csvLine[i].Split(';');
                inColumn.Add(csvRow[2]);
                //Console.WriteLine(csvRow[2] + "\\ IN");
            }
            var mathEngine = new MathEngine(inColumn, outColumn, filePath);
            return mathEngine.getIn();
        }

        public List<Double> CsvgetOut()
        {
            var localFIle = new LocalFile();
            String filePath = Path.Combine(localFIle.CsvDirectoryPath + csvFile);
            string[] csvLine = System.IO.File.ReadAllLines(filePath);
            inColumn = new List<String>();
            outColumn = new List<String>();

            for (int i = 1; i < csvLine.Length; i++)
            {
                String[] csvRow = csvLine[i].Split(';');
                outColumn.Add(csvRow[7]);
            }
            var mathEngine = new MathEngine(inColumn, outColumn, filePath);
            return mathEngine.getOut();
        }

        public List<DateTime> CsvGetTimestamp()
        {
            var localFIle = new LocalFile();
            String filePath = Path.Combine(localFIle.CsvDirectoryPath + csvFile);
            string[] csvLine = System.IO.File.ReadAllLines(filePath);
            timestampColumn = new List<double>();
            String[] fileLines = File.ReadAllLines(filePath);
            foreach(String timestamp in fileLines)
            {
                string[] splited = timestamp.Split(';');
                if (splited[0].Contains("time")){

                }
                else {
                    Console.WriteLine(splited[0]);
                    timestampColumn.Add(Convert.ToDouble(splited[0])); 
                }
            }
            var dateEngine = new DateEngine(timestampColumn);
            return dateEngine.getDateTime();
        }
    }
}

