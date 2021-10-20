using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace NomDuLogiciel
{
    class LocalFile
    {
        public String InstallationDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
        public String TempFileDirectoryPath = AppDomain.CurrentDomain.BaseDirectory + "Fichier Temporaire\\";
        public String LogFileDirectoryPath = AppDomain.CurrentDomain.BaseDirectory + "Fichier Log\\";
        public String CsvDirectoryPath = AppDomain.CurrentDomain.BaseDirectory + "Fichier CSV\\";
        public LocalFile()
        {

        }
        public Boolean InstallationFileExists()
        {
            if(!Directory.Exists(CsvDirectoryPath))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void LocalFileInstallation()
        {
            try
            {
                Directory.CreateDirectory(TempFileDirectoryPath);
                Directory.CreateDirectory(LogFileDirectoryPath);
                Directory.CreateDirectory(CsvDirectoryPath);
                
            }catch(IOException e)
            {
                Console.WriteLine("LocalFile.LocalFileInstallation.IOExcepetion\n" + e);
            }
        }

        public String NewLocalCsvPath(string filePath)
        {
            return Path.GetFileName(filePath);
        }

    }
}
