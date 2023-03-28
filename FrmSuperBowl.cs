namespace WFA230328
{
    public partial class FrmSuperBowl : Form
    {
        private string[] romaiSzamok = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };

        public FrmSuperBowl()
        {
            InitializeComponent();
            btnIrany.Click += OnBtnIranyClick;
            cmdAtvalt.Click += OnCmdAtvaltClick;
        }

        private void OnBtnIranyClick(object? sender, EventArgs e)
        {
            txtArab.Clear();
            txtRomai.Clear();
            btnIrany.Text = btnIrany.Text == "--->" ? "<---" : "--->";
            txtArab.Enabled = !txtArab.Enabled;
            txtRomai.Enabled = !txtRomai.Enabled;
        }

        private void OnCmdAtvaltClick(object? sender, EventArgs e)
        {
            if (txtArab.Enabled)
            {
                if (int.TryParse(txtArab.Text, out _) && int.Parse(txtArab.Text) > 0 && int.Parse(txtArab.Text) <= 10)
                {
                    txtRomai.Text = romaiSzamok[int.Parse(txtArab.Text) - 1];
                }
                else txtRomai.Text = "Hiba!";
            }
            else
            {
                if (romaiSzamok.Contains(txtRomai.Text.ToUpper()))
                {
                    txtArab.Text = $"{Array.IndexOf(romaiSzamok, txtRomai.Text.ToUpper()) + 1}";
                }
                else txtArab.Text = "Hiba!";
            }
        }

    }
}