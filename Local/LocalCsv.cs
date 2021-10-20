using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace NomDuLogiciel
{
    class LocalCsv
    {
        public LocalCsv()
        {

        }

        public Boolean CheckExtension(String filePath)
        {
            if(Path.GetExtension(filePath) == ".csv")
            {
                return true;
            }
            return false;
        }

        public void LoadCsvFile(ListBox listBox)
        {
            var localFile = new LocalFile();
            String[] datFile = Directory.GetFiles(localFile.CsvDirectoryPath, "*.csv");
            foreach(String csvFile in datFile)
            {
                listBox.Items.Add(Path.GetFileName(csvFile));
            }
        }

        public void IncludeCsvFile(String filePath, ListBox listBox)
        {
            var localFile = new LocalFile();
            try
            {
                File.Copy(filePath, localFile.CsvDirectoryPath + Path.GetFileName(filePath));
                String newLocalCsvPath = Path.Combine(localFile.CsvDirectoryPath + localFile.NewLocalCsvPath(filePath) + ".dat");
                File.WriteAllText(newLocalCsvPath, localFile.NewLocalCsvPath(filePath));
                listBox.Items.Add(Path.GetFileName(filePath));
            }
            catch (IOException e)
            {
                Console.WriteLine("LocalCsv.IncludeCsvFile.IOException" + e);
                
            }
        }
    }
}
