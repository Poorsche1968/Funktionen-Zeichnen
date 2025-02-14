using System.Windows.Forms;

namespace FunktionZeichnen
{
    public partial class LinearFunktionForm : Form
    {
        private Koordinatensystem _graphPanel;
        public LinearFunktionForm()
        {
            InitializeComponent();
            Text = "Lineare Funktion";

            // GraphPanel hinzufügen
            _graphPanel = new Koordinatensystem() { Top = 150, Left = 20, Width = 800, Height = 600 };
            Controls.Add(_graphPanel);

            // Button-Klick-Event
            buttonZeichnen.Click += (sender, e) =>
            {
                if (double.TryParse(textBoxNeigung.Text, out double neigung) && double.TryParse(textBoxAbfangen.Text, out double abfangen))
                {
                    var linearFunction = new LineareFunktion(neigung, abfangen);
                    _graphPanel.SetFunktion(linearFunction);
                    MessageBox.Show($"Funktion zeichnen: y = {neigung}x + {abfangen}");
                }
                else
                {
                    MessageBox.Show("Ungültige Eingabe. Bitte geben Sie numerische Werte ein.");
                }
            };


            // Werde ich Löschen 
            // UI-Elemente hinzufügen
            //Controls.Add(labelNeigung);
            Controls.Add(textBoxNeigung);
           // Controls.Add(labelAbfangen);
            Controls.Add(textBoxAbfangen);
            Controls.Add(buttonZeichnen);
        }

        private void LinearFunktionForm_Load(object sender, System.EventArgs e)
        {

        }

        private void Neigung_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (double.TryParse(textBoxNeigung.Text, out double neigung) && double.TryParse(textBoxAbfangen.Text, out double abfangen))
            {
                var linearFunction = new LineareFunktion(neigung, abfangen);
                _graphPanel.SetFunktion(linearFunction);
                MessageBox.Show($"Funktion zeichnen: y = {neigung}x + {abfangen}");
            }
            else
            {
                MessageBox.Show("Ungültige Eingabe. Bitte geben Sie numerische Werte ein.");
            }
        }
    }
}