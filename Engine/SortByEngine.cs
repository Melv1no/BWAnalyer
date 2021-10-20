using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NomDuLogiciel
{ 
    class SortByEngine
    {

        private ListBox listBox;
        public SortByEngine(ListBox listBox)
        {
            this.listBox = listBox;
        }

        public void SortBy()
        {
            listBox.Items.Clear();
            var localFile = new LocalFile(); 
            String[] datFile = Directory.GetFiles(localFile.CsvDirectoryPath, "*.csv");
            List<double> Moyenne = new List<double>();
            double moyenne;
            foreach (String csvFile in datFile)
            {

                var csvEngine = new CsvEngine(csvFile);
                moyenne = csvEngine.CsvGetIn().Average(); 

            }

            }


    }
}
