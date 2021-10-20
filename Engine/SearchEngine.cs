using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NomDuLogiciel
{
    class SearchEngine
    {
        private String item;
        private ListBox resultBox;
        public SearchEngine(String item, ListBox resultBox)
        {
            this.item = item;
            this.resultBox = resultBox;
        }

        public void Search()
        {
            var localFile = new LocalFile();
            String[] datFile = Directory.GetFiles(localFile.CsvDirectoryPath, "*.csv");

            resultBox.Items.Clear();

            foreach (String csvFile in datFile)
            {
                if (Path.GetFileName(csvFile).Contains(item))
                {
                    resultBox.Items.Add(Path.GetFileName(csvFile));
                }
                else
                {
                    if (resultBox.Items.Contains(Path.GetFileName(csvFile)))
                    {
                        resultBox.Items.Remove(Path.GetFileName(csvFile));
                    }
                }
            }
        }


    }
}
