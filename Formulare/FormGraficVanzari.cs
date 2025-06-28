using ProiectVanzari.Clase;
using ProiectVanzari.Servicii;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; 

namespace ProiectVanzari.Formulare
{
    public partial class FormGraficVanzari : Form
    {
        private ManagerDate _managerDate;
        private List<Tranzactie> _listaTranzactii;

        private const string GRAFIC_VANZARI_CLIENT = "Total Vânzări pe Client";
        private const string GRAFIC_TOP_PRODUSE = "Top Produse Vândute (după valoare)";
        private const string GRAFIC_VANZARI_LUNARE = "Total Vânzări Lunare (anul curent)";


        public FormGraficVanzari()
        {
            InitializeComponent();
            _managerDate = new ManagerDate();
            _listaTranzactii = new List<Tranzactie>();
        }

        private void FormGraficVanzari_Load(object sender, EventArgs e)
        {
            cmbTipGrafic.Items.Add(GRAFIC_VANZARI_CLIENT);
            cmbTipGrafic.Items.Add(GRAFIC_TOP_PRODUSE);
            cmbTipGrafic.Items.Add(GRAFIC_VANZARI_LUNARE);
            cmbTipGrafic.SelectedIndex = 0; 

            try
            {
                
                _listaTranzactii = _managerDate.IncarcaTranzactiiDinDb();
                if (_listaTranzactii.Any())
                {
                    GenereazaGraficSelectat(); 
                }
                else
                {
                    MessageBox.Show("Nu există date de tranzacții pentru a genera grafice.", "Date lipsă", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    chartVanzari.Series.Clear(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la încărcarea datelor pentru grafic: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenereazaGrafic_Click(object sender, EventArgs e)
        {
            if (!_listaTranzactii.Any())
            {
                MessageBox.Show("Nu există date de tranzacții pentru a genera grafice.", "Date lipsă", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chartVanzari.Series.Clear();
                return;
            }
            GenereazaGraficSelectat();
        }

        private void GenereazaGraficSelectat()
        {
            string tipGraficSelectat = cmbTipGrafic.SelectedItem.ToString();
            chartVanzari.Series.Clear(); 
            chartVanzari.Titles.Clear(); 

            switch (tipGraficSelectat)
            {
                case GRAFIC_VANZARI_CLIENT:
                    GenereazaGraficVanzariPeClient();
                    break;
                case GRAFIC_TOP_PRODUSE:
                    GenereazaGraficTopProduse();
                    break;
                case GRAFIC_VANZARI_LUNARE:
                    GenereazaGraficVanzariLunare();
                    break;
            }
        }

        private void GenereazaGraficVanzariPeClient()
        {
            chartVanzari.Titles.Add("Total Vânzări pe Client");
            Series serieVanzariClient = new Series("VanzariClient")
            {
                ChartType = SeriesChartType.Pie 
            };

            var vanzariPeClient = _listaTranzactii
                .Where(t => t.ClientAsociat != null) 
                .GroupBy(t => t.ClientAsociat.ToString()) 
                .Select(g => new { Client = g.Key, TotalVanzari = g.Sum(t => t.TotalGeneral) })
                .OrderByDescending(x => x.TotalVanzari)
                .ToList();

            if (!vanzariPeClient.Any())
            {
                serieVanzariClient.Points.AddXY("Fără date", 1); 
            }
            else
            {
                foreach (var item in vanzariPeClient)
                {
                    DataPoint dataPoint = new DataPoint();
                    dataPoint.SetValueXY(item.Client, (double)item.TotalVanzari); 
                    dataPoint.Label = $"{item.Client}\n({item.TotalVanzari:C})"; 
                    dataPoint.LegendText = item.Client; 
                    serieVanzariClient.Points.Add(dataPoint);
                }
            }
            chartVanzari.Series.Add(serieVanzariClient);
        }

        private void GenereazaGraficTopProduse()
        {
            chartVanzari.Titles.Add("Top 5 Produse Vândute (după Valoare)");
            Series serieTopProduse = new Series("TopProduse")
            {
                ChartType = SeriesChartType.Column 
            };

            var topProduse = _listaTranzactii
                .SelectMany(t => t.ProduseVandute) 
                .GroupBy(pv => pv.ProdusAsociat.Denumire) 
                .Select(g => new
                {
                    DenumireProdus = g.Key,
                    ValoareTotalaVanduta = g.Sum(pv => pv.ValoareTotala)
                })
                .OrderByDescending(x => x.ValoareTotalaVanduta)
                .Take(5) 
                .ToList();

            if (!topProduse.Any())
            {
                serieTopProduse.Points.AddXY("Fără date", 0);
            }
            else
            {
                foreach (var item in topProduse)
                {
                    serieTopProduse.Points.AddXY(item.DenumireProdus, (double)item.ValoareTotalaVanduta);
                    
                    serieTopProduse.Points.Last().Label = item.ValoareTotalaVanduta.ToString("C");
                }
            }

            
            chartVanzari.ChartAreas[0].AxisX.Interval = 1; 
            chartVanzari.ChartAreas[0].AxisX.LabelStyle.Angle = -45; 
            chartVanzari.ChartAreas[0].AxisX.Title = "Produs";
            chartVanzari.ChartAreas[0].AxisY.Title = "Valoare Totală Vândută";
            chartVanzari.ChartAreas[0].AxisY.LabelStyle.Format = "C"; 

            chartVanzari.Series.Add(serieTopProduse);
        }

        private void GenereazaGraficVanzariLunare()
        {
            chartVanzari.Titles.Add($"Total Vânzări Lunare ({DateTime.Now.Year})");
            Series serieVanzariLunare = new Series("VanzariLunare")
            {
                ChartType = SeriesChartType.Line, 
                BorderWidth = 2
            };

            var vanzariLunare = _listaTranzactii
                .Where(t => t.DataTranzactie.Year == DateTime.Now.Year) 
                .GroupBy(t => new { An = t.DataTranzactie.Year, Luna = t.DataTranzactie.Month })
                .Select(g => new
                {
                    AnLuna = new DateTime(g.Key.An, g.Key.Luna, 1), 
                    TotalVanzari = g.Sum(t => t.TotalGeneral)
                })
                .OrderBy(x => x.AnLuna)
                .ToList();

            if (!vanzariLunare.Any())
            {
                serieVanzariLunare.Points.AddXY("Fără date", 0);
            }
            else
            {
                
                for (int luna = 1; luna <= 12; luna++)
                {
                    var vanzareLunaCurenta = vanzariLunare.FirstOrDefault(v => v.AnLuna.Month == luna);
                    decimal totalLuna = vanzareLunaCurenta?.TotalVanzari ?? 0;

                    DataPoint dp = new DataPoint();
                    dp.SetValueXY(new DateTime(DateTime.Now.Year, luna, 1), (double)totalLuna);
                    dp.AxisLabel = new DateTime(DateTime.Now.Year, luna, 1).ToString("MMM"); 
                    dp.Label = totalLuna.ToString("C"); 
                    serieVanzariLunare.Points.Add(dp);
                }
            }

            chartVanzari.ChartAreas[0].AxisX.LabelStyle.Format = "MMM"; 
            chartVanzari.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
            chartVanzari.ChartAreas[0].AxisX.Interval = 1;
            chartVanzari.ChartAreas[0].AxisX.Title = "Lună";
            chartVanzari.ChartAreas[0].AxisY.Title = "Total Vânzări";
            chartVanzari.ChartAreas[0].AxisY.LabelStyle.Format = "C";

            chartVanzari.Series.Add(serieVanzariLunare);
        }
    }
}