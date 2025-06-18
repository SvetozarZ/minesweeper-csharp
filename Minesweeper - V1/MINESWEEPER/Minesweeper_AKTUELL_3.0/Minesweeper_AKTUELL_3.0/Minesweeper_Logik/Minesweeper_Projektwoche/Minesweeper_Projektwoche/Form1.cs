using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Minesweeper_Projektwoche
{
    public partial class Form1 : Form
    {
        private Button[,] spielfeld = new Button[8, 8];
        private bool[,] bomben = new bool[8, 8];
        private int geöffneteFelder = 0;
        private int anzahlBomben = 8;   // Standardwert: leicht
        private int startLeben = 5;     // Standardwert: leicht
        private Random rand = new Random();

        private Timer timer = new Timer();
        private int sekunden = 0;

        private int leben = 5; // Startleben

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000; // 1 Sekunde
            timer.Tick += Timer_Tick;
            ErstelleSpielfeld();
            AktualisiereFeldAnzahl();
            AktualisiereLeben();
            AktualisiereBombenAnzahl();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            sekunden++;
            LblTimer.Text = sekunden.ToString();
        }

        private void ErstelleSpielfeld()
        {
            PanelPlayfield.Controls.Clear();
            geöffneteFelder = 0;
            sekunden = 0;
            LblTimer.Text = "0";
            leben = startLeben;
            AktualisiereLeben();

            bomben = new bool[8, 8];
            spielfeld = new Button[8, 8];

            List<(int, int)> alleFelder = new List<(int, int)>();
            for (int x = 0; x < 8; x++)
                for (int y = 0; y < 8; y++)
                    alleFelder.Add((x, y));

            for (int i = 0; i < anzahlBomben; i++) // 8 Bomben
            {
                int index = rand.Next(alleFelder.Count);
                var (bx, by) = alleFelder[index];
                bomben[bx, by] = true;
                alleFelder.RemoveAt(index);
            }

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Button button = new Button();
                    button.Size = new Size(40, 40);
                    button.Location = new Point(x * 40, y * 40);
                    button.MouseUp += ButtonMouseUp;
                    button.Tag = new Point(x, y);
                    button.TabStop = false;
                    PanelPlayfield.Controls.Add(button);
                    spielfeld[x, y] = button;
                    button.Enabled = true;
                    button.Text = "";
                    button.BackColor = default(Color);
                }
            }

            AktualisiereBombenAnzahl();

            timer.Start();
        }

        private void DeckeFreieFelderAuf(int x, int y)
        {
            // Wenn das Feld außerhalb des Bereichs ist → abbrechen

            if (x < 0 || x >= 8 || y < 0 || y >= 8)
                return;

            Button btn = spielfeld[x, y];

            // Wenn das Feld schon deaktiviert ist oder eine Flagge hat → abbrechen

            if (!btn.Enabled || btn.Text == "🚩")
                return;

            int nachbarBomben = ZaehleNachbarBomben(x, y);
            btn.BackColor = Color.LightGray;
            btn.Text = nachbarBomben > 0 ? nachbarBomben.ToString() : "";
            btn.Enabled = false;
            geöffneteFelder++;
            AktualisiereFeldAnzahl();

            // Wenn keine Nachbarbomben → alle Nachbarn auch aufdecken

            if (nachbarBomben == 0)
            {
                for (int dx = -1; dx <= 1; dx++)
                {
                    for (int dy = -1; dy <= 1; dy++)
                    {
                        if (dx != 0 || dy != 0) // nicht sich selbst

                            DeckeFreieFelderAuf(x + dx, y + dy);
                    }
                }
            }
        }

        private void SetzeSchwierigkeitsgrad(string schwierigkeitsgrad)
        {
            switch (schwierigkeitsgrad)
            {
                case "Leicht":
                    anzahlBomben = 8;
                    startLeben = 5;
                    break;
                case "Mittel":
                    anzahlBomben = 16;
                    startLeben = 3;
                    break;
                case "Schwer":
                    anzahlBomben = 24;
                    startLeben = 1;
                    break;
            }

            leben = startLeben;                 // Leben setzen
            ErstelleSpielfeld();               // neues Spielfeld starten
            AktualisiereFeldAnzahl();          // Anzeige aktualisieren
        }


        private void AktualisiereBombenAnzahl()
        {
            int bombenAnzahl = 0;
            for (int x = 0; x < 8; x++)
                for (int y = 0; y < 8; y++)
                    if (bomben[x, y]) bombenAnzahl++;

            LblAnzahlBomben.Text = bombenAnzahl.ToString();
        }

        private void ButtonMouseUp(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            Point pos = (Point)btn.Tag;
            int x = pos.X;
            int y = pos.Y;

            if (e.Button == MouseButtons.Right && btn.Enabled)
            {
                btn.Text = btn.Text == "🚩" ? "" : "🚩";
            }
            else if (e.Button == MouseButtons.Left)
            {
                ButtonKlick(btn);
            }
        }

        private void ButtonKlick(Button btn)


        {



            if (!btn.Enabled || btn.Text == "🚩") return;

            Point pos = (Point)btn.Tag;
            int x = pos.X;
            int y = pos.Y;

            if (bomben[x, y])
            {
                leben--;
                AktualisiereLeben();
                btn.BackColor = Color.Red;
                btn.Text = "💣";
                btn.Enabled = false;

                if (leben <= 0)
                {
                    MessageBox.Show("💥 Bumm! Du hast verloren.");
                    SpielBeenden();
                    timer.Stop();
                    return;
                }
                else
                {
                    MessageBox.Show($"💥 Mine getroffen! Leben übrig: {leben}");
                }
            }


            else
            {
                DeckeFreieFelderAuf(x, y); // 🆕 Rekursives Aufdecken

                if (geöffneteFelder == (8 * 8 - anzahlBomben)) // Alle Nicht-Bombenfelder offen
                {
                    SpielGewonnen();
                    timer.Stop();
                }
            }
        }
            
              
        

        private int ZaehleNachbarBomben(int x, int y)
        {
            int count = 0;
            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    int nx = x + dx;
                    int ny = y + dy;
                    if (nx >= 0 && nx < 8 && ny >= 0 && ny < 8 && bomben[nx, ny])
                        count++;
                }
            }
            return count;
        }

        private void SpielBeenden()
        {
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    if (bomben[x, y])
                    {
                        spielfeld[x, y].BackColor = Color.Red;
                        spielfeld[x, y].Text = "💣";
                    }
                    spielfeld[x, y].Enabled = false;
                }
            }
        }

        private void SpielGewonnen()
        {
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    if (bomben[x, y])
                    {
                        spielfeld[x, y].Text = "🚩";
                        spielfeld[x, y].BackColor = Color.LightGreen;
                    }
                    spielfeld[x, y].Enabled = false;
                }
            }
            MessageBox.Show("🎉 Glückwunsch, du hast gewonnen!");
        }

        private void AktualisiereFeldAnzahl()
        {
            int geschlosseneFelder = 0;
            int offeneFelder = 0;

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    if (spielfeld[x, y].Enabled)
                        geschlosseneFelder++;  // Button ist noch aktiv = geschlossen
                    else
                        offeneFelder++;        // Button ist deaktiviert = offen
                }
            }

            LblGeschlossenFelder1.Text = geschlosseneFelder.ToString();
            LblOffeneFelder1.Text = offeneFelder.ToString();
        }

        private void AktualisiereLeben()
        {
            LblShowScore.Text = leben.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: neues Spiel automatisch starten beim Laden
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ErstelleSpielfeld();
            AktualisiereFeldAnzahl();
        }

        // Dummy Events aus Designer, können leer bleiben
        private void SCORE_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void LblTOP_Click(object sender, EventArgs e) { }

        private void BtnEASY_Click(object sender, EventArgs e)
        {
            SetzeSchwierigkeitsgrad("Leicht");
        }

        private void BtnMEDIUM_Click(object sender, EventArgs e)
        {
            SetzeSchwierigkeitsgrad("Mittel");
        }

        private void BtnHARD_Click(object sender, EventArgs e)
        {
            SetzeSchwierigkeitsgrad("Schwer");
        }

        private void LblTimerShow_Click(object sender, EventArgs e)
        {

        }
    }
}
