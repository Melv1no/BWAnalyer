using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LiveCharts.Wpf;
using LiveCharts;
using System.IO;
using LiveCharts.Defaults;
using System.Windows.Documents;
using System.Windows.Forms.DataVisualization.Charting;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;
using SeriesCollection = LiveCharts.SeriesCollection;
using System.Drawing.Imaging;
using Axis = LiveCharts.Wpf.Axis;

namespace NomDuLogiciel
{
    public partial class Form1 : Form
    {
        #region variable call
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void txtQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
             

            var localFile = new LocalFile();
            if (localFile.InstallationFileExists() == false)
            {
                localFile.LocalFileInstallation();

                MessageBox.Show(localFile.CsvDirectoryPath);
            }
            var localCsv = new LocalCsv();
            localCsv.LoadCsvFile(listboxCsv);
            // var csvEngine = new CsvEngine("fdg.csv");
            txtMaxIn.BackColor = this.BackColor; 
            txtMaxOut.BackColor = this.BackColor;
            txtMinIn.BackColor = this.BackColor;
            txtMinOut.BackColor = this.BackColor;
            txtMoyIn.BackColor = this.BackColor;
            txtMoyOut.BackColor = this.BackColor;
            var mathEngine = new MathEngine(null, null, null); 
            TimeSpan span = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));
            double unixTime = span.TotalSeconds;
            #region LiveCHart init
            cartesianChart1.DisableAnimations = true;
            cartesianChart1.Hoverable = false;
            cartesianChart1.DataTooltip = null; 
 
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            { 
                LabelFormatter = value => mathEngine.test(value) + " Mb"
            });
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;
            cartesianChart1.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(36, 43, 110));
            #endregion

        }

        public void ShowError(String body, String title)
        {
            MessageBox.Show(body, title);
        }
        private void btnAddCsv_Click(object sender, EventArgs e)
        {
            var localCsv = new LocalCsv();
            String filePath = String.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\Users\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    if (localCsv.CheckExtension(filePath) == false)
                    {
                        MessageBox.Show("Extension de fichier obligatoire .csv");
                    }
                    else
                    {
                        localCsv.IncludeCsvFile(filePath, listboxCsv);
                    }
                }
            }
            
        }

        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            var searchEngine = new SearchEngine(txtboxSearch.Text, listboxCsv);
            searchEngine.Search();
        }
        private List<String> tupapi = new List<String>();
        public List<String> dateTimeConverter(List<DateTime> time)
        {
            foreach(DateTime dt in time)
            {
                tupapi.Add(dt.ToString("dd / MM / yyyy"));
            }
            return tupapi;
        }
        private void listboxCsv_SelectedIndexChanged(object sender, EventArgs e)
        {

            var csvEngine = new CsvEngine(listboxCsv.SelectedItem.ToString());
            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.Clear(); 

            LiveCharts.Wpf.Axis ax = new LiveCharts.Wpf.Axis()
            { 
                FontSize = 12,
                Separator = new Separator { Step = 192, IsEnabled = true },
                Labels = (dateTimeConverter(csvEngine.CsvGetTimestamp())),
            };
            cartesianChart1.AxisX.Add(ax);
           
            txtTitleWindows.Text = listboxCsv.SelectedItem.ToString(); 
            cartesianChart1.BackColor = System.Drawing.Color.FromArgb(36, 43, 110); 
            cartesianChart1.Series.Add(new LineSeries
            {
                Title = "IN",
                 Values = new ChartValues<double>(csvEngine.CsvGetIn()),
                
                StrokeThickness = 1.5,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 255, 0)),
                Fill = System.Windows.Media.Brushes.Transparent,
                LineSmoothness = 0,
                PointGeometry = null
            });
            cartesianChart1.Series.Add(new LineSeries
            {
                Title = "OUT",
                Values = new ChartValues<double>(csvEngine.CsvgetOut()),
                StrokeThickness = 0.5,
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 0, 0)),
                Fill = System.Windows.Media.Brushes.Transparent,
                LineSmoothness = 1,
                PointGeometrySize = 1,
                PointForeground =
                    new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 0, 0))
            });

            var mathEngine = new MathEngine(null, null, null);
            double maxIn = csvEngine.CsvGetIn().Max<double>();
            txtMaxIn.Text = mathEngine.SomeDoubleValueToLisibleValue(maxIn);

            double minIn = csvEngine.CsvGetIn().Min<double>();
            txtMinIn.Text = mathEngine.SomeDoubleValueToLisibleValue(minIn);

            double minOut = csvEngine.CsvgetOut().Min<double>();
            txtMinOut.Text = mathEngine.SomeDoubleValueToLisibleValue(minOut).Replace("-","");

            double maxOut = csvEngine.CsvgetOut().Max<double>();
            txtMaxOut.Text = mathEngine.SomeDoubleValueToLisibleValue(maxOut).Replace("-","");

            double moyOut = csvEngine.CsvgetOut().Average();
            txtMoyOut.Text = mathEngine.SomeDoubleValueToLisibleValue(moyOut).ToString().Replace("-","");

            double moyIn = csvEngine.CsvGetIn().Average();
            txtMoyIn.Text = mathEngine.SomeDoubleValueToLisibleValue(moyIn);

        }

        private void txtMinimiz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnOpenFullscreen_Click(object sender, EventArgs e)
        {
            if (listboxCsv.SelectedItem == null)
            {
                ShowError("Vous devez selectionnez un fichier CSV avant de continuer !", "Erreur utilisateur");
            }
            else
            {
                var fullscreen = new FullScreen(null, listboxCsv.SelectedItem.ToString(), false);
                fullscreen.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pathToSave;
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    pathToSave = fbd.SelectedPath;
                    FullScreen fullScreen = new FullScreen(pathToSave, listboxCsv.SelectedItem.ToString(), true);
                    fullScreen.Show(); 
                }
            } 
                
 
        }
 
         
        private void btnReport_Click(object sender, EventArgs e)
        {
            var csvEngine = new CsvEngine(listboxCsv.SelectedItem.ToString());

            /*
             * Classement moins consomateur au plus gros
             * Min, max Moy
             * MathEngine back
             */
        }

        private void SortBy_Click(object sender, EventArgs e)
        {

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void txtMoyIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMinIn_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

