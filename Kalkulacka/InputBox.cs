using System.Windows.Forms;

namespace Kalkulacka {
    public partial class InputBox : Form {
        public InputBox() {
            InitializeComponent();
        }

        /// <summary>
        /// Zobrazí InputBox s názvem souboru
        /// </summary>
        /// <param name="nazev">Název souboru</param>
        /// <returns>DialogResult</returns>
        public DialogResult input(ref string nazev) {
            textBox.Text = nazev;
            buttonOK.DialogResult = DialogResult.OK;
            DialogResult dialogResult = this.ShowDialog();
            nazev = textBox.Text;
            return dialogResult;
        }

        /// <summary>
        /// Validuje zapisování povolených znaků v názvu souboru
        /// Při zadání neplatného znaku se zobrazí ToolTip s upozorněním
        /// </summary>
        /// <param name="sender">TextBox</param>
        /// <param name="e">Znak na klávesnici</param>
        private void textBox_KeyPress(object sender, KeyPressEventArgs e) {
            Cursor.Position = PointToScreen(buttonOK.Location);
            toolTip.Active = true;
            if (e.KeyChar == '\\' || e.KeyChar == '/' || e.KeyChar == ':' || e.KeyChar == '*' || e.KeyChar == '?' || e.KeyChar == '"' || e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '|') {
                toolTip.Show("Názvy souborů nesmí obsahovat žádný z následujících znaků: \\ /  : * ? \" < > | ", textBox, 10000);
                e.Handled = true;
            }
            else {
                toolTip.Hide(textBox);
            }
        }

        // Skryje zobrazení ToolTipu po najetí kurzoru myši na TextBox
        private void textBox_MouseMove(object sender, MouseEventArgs e) {
            toolTip.Hide(textBox);
        }
    }
}
