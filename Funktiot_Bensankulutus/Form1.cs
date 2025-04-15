namespace Funktiot_Bensankulutus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Lasketaan bensankulutus 100Km:lla
        private double LaskeKustannusPer100Km(double matka, double kulutusPer100Km, double litrahinta)
        {
            // Lasketaan bensankulutus L\100km --  rdL100km: "L/100km (ex. 6.5)"
            double kustannus = (matka * kulutusPer100Km / 100);
            return kustannus * litrahinta;
        }

        // Lasketaan bensankulutus Km:lla
        private double LaskeKustannusPerKm(double matka, double kulutusPerKm, double litrahinta)
        {
            // Lasketaan bensankulutus L/km --  rdLKm: "L/km (ex. 0.065)"
            double kustannus = matka * kulutusPerKm;
            return kustannus * litrahinta;
        }

        // Lasketaan bensankulutus
        private void btnLaske_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtVälimatka.Text, out double matka) ||
                    !double.TryParse(txtP_Kulutus.Text, out double kulutus) ||
                    !double.TryParse(txtBensiiniHinta.Text, out double litrahinta)) 
                {
                    MessageBox.Show("Syötä kelvolliset numeeriset arvot kaikkin kentiin.",
                                    "Virheellinen syöte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (matka <= 0 || kulutus <= 0 || litrahinta <= 0)
                {
                    MessageBox.Show("Arvojen tulee olla positiivisia lukuja.");
                    return;
                }

                // Lasketaan kustannus
                if (rdL100km.Checked)
            {
                    // Lasketaan kustannus L/100km
                    txtTulostus.Text = $"Matkan kokonaiskustannukset ovat {LaskeKustannusPer100Km(matka, kulutus, litrahinta).ToString("0.00")} €";
                }
            else if (rdLKm.Checked)
            {
                // Lasketaan kustannus L/km
                txtTulostus.Text = $"Matkan kokonaiskustannukset ovat {LaskeKustannusPerKm(matka, kulutus, litrahinta).ToString("0.00")} €";
            }
            else
            {
                MessageBox.Show("Valitse joko L/100km tai L/km");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe laskennanssa: {ex.Message}", "Järjestelmävirhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    // Hernandez 15.04.20205
}
