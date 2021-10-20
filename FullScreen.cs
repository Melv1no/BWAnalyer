using LiveCharts;
using LiveCharts.Wpf;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NomDuLogiciel
{
    public partial class FullScreen : Form
    {
        #region variable etc
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private string filename, pathToSave;
        public bool screenshot;
        public String fullPathFile;
        #endregion
        public FullScreen(String pathToSave, String Filename, bool screenshot)
        {
            InitializeComponent();
            this.filename = Filename;
            this.pathToSave = pathToSave;
            this.screenshot = screenshot;
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void txtQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtMinimiz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private List<String> tupapi = new List<String>();
        public List<String> dateTimeConverter(List<DateTime> time)
        {
            foreach (DateTime dt in time)
            {
                tupapi.Add(dt.ToString("dd / MM / yyyy"));
            }
            return tupapi;
        }
        private void FullScreen_Load(object sender, EventArgs e)
        {
            txtMaxIn.BackColor = this.BackColor;
            txtMaxOut.BackColor = this.BackColor;
            txtMinIn.BackColor = this.BackColor;
            txtMinOut.BackColor = this.BackColor;
            txtMoyIn.BackColor = this.BackColor;
            txtMoyOut.BackColor = this.BackColor;
            var csvEngine = new CsvEngine(filename);
            var mathEngine = new MathEngine(null, null, null);
            label1.Text = filename;
            #region Initialisation des cartesianChart
            cartesianChart1.DisableAnimations = true;
            cartesianChart1.Hoverable = false;
            cartesianChart1.DataTooltip = null;
            LiveCharts.Wpf.Axis ax = new LiveCharts.Wpf.Axis()
            {
                FontSize = 12,
                Separator = new Separator { Step = 192, IsEnabled = true },
                Labels = (dateTimeConverter(csvEngine.CsvGetTimestamp())),
            };
            cartesianChart1.AxisX.Add(ax);
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                 
                LabelFormatter = value => mathEngine.test(value) + " Mb"
            });
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;
            cartesianChart1.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(36, 43, 110));
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;
            cartesianChart1.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(36, 43, 110));
            cartesianChart1.Series.Clear(); 
            cartesianChart1.BackColor = System.Drawing.Color.FromArgb(36, 43, 110);
            #endregion
            #region Ajout Des series sur notre cartesianChart
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
            #endregion
            #region Définition des Valeurs Maximum minimum et Moyenne 
            double maxIn = csvEngine.CsvGetIn().Max<double>();
            txtMaxIn.Text = mathEngine.SomeDoubleValueToLisibleValue(maxIn);

            double minIn = csvEngine.CsvGetIn().Min<double>();
            txtMinIn.Text = mathEngine.SomeDoubleValueToLisibleValue(minIn);

            double minOut = csvEngine.CsvgetOut().Min<double>();
            txtMinOut.Text = mathEngine.SomeDoubleValueToLisibleValue(minOut).Replace("-", "");

            double maxOut = csvEngine.CsvgetOut().Max<double>();
            txtMaxOut.Text = mathEngine.SomeDoubleValueToLisibleValue(maxOut).Replace("-", "");

            double moyOut = csvEngine.CsvgetOut().Average();
            txtMoyOut.Text = mathEngine.SomeDoubleValueToLisibleValue(moyOut).ToString().Replace("-", "");

            double moyIn = csvEngine.CsvGetIn().Average();
            txtMoyIn.Text = mathEngine.SomeDoubleValueToLisibleValue(moyIn);
            #endregion


        }
 
        private void btnExport_Click(object sender, EventArgs e)
        {
            FullScreenShot();
        }
        Bitmap bmp;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                Verb = "print",
                FileName = "" //put the correct path here
            };
            p.Start();
         

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        public void FullScreenShot()
        {
            #region Système de capture d'écran de Fullscreen > false la visilité
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    pathToSave = fbd.SelectedPath;

                }
            }
            btnExport.Visible = false;
            txtMinimiz.Visible = false;
            txtQuit.Visible = false;

            var frm = this;
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(pathToSave + "\\" + filename + ".png", System.Drawing.Imaging.ImageFormat.Png);
            }
            PdfHelper.Instance.SaveImageAsPdf(pathToSave + "\\" + filename + ".png", pathToSave + "\\" + filename + ".pdf", 1000, true);
            Console.WriteLine(pathToSave + "\\" + filename + ".png" + "\n" + pathToSave + "\\" + filename + ".pdf");
            fullPathFile = pathToSave + "\\" + filename + ".pdf";
            btnExport.Visible = true;
            txtMinimiz.Visible = true;
            txtQuit.Visible = true;
#endregion
        }
    }
}
