using System.Windows.Forms;

namespace Kalkulacka {
    public class KeyPress {

        /// <summary>
        /// Validuje zapisování kladných desetinných čísel do textového pole 
        /// </summary>
        /// <param name="sender">TextBox</param>
        /// <param name="e">Znak na klávesnici</param>
        public void validujTextDesetinnaCisla(object sender, KeyPressEventArgs e) {
            if ((sender as TextBox).SelectionStart == 0) {                      //znaky povolené na první pozici
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                    e.Handled = true;
                }
            }
            else {                                                              //znaky povolené na dalších pozicích
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) {
                    e.Handled = true;
                }
            }

            // povolí zapsat pouze jednu desetinnou čárku
            if ((e.KeyChar == ',') && (sender as TextBox).Text.IndexOf(',') > -1) {
                e.Handled = true;
            }

            // v případě, že bude první znak nula, dovolí zapsat pouze desetinnou čárku
            if ((sender as TextBox).Text.IndexOf('0') == 0 && (sender as TextBox).SelectionStart == 1) {
                if (!char.IsControl(e.KeyChar) && e.KeyChar != ',') {
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// Validuje zapisování kladných celých čísel do textového pole 
        /// </summary>
        /// <param name="sender">TextBox</param>
        /// <param name="e">Znak na klávesnici</param>
        public void validujTextCelaCisla(object sender, KeyPressEventArgs e) {
            if ((sender as TextBox).SelectionStart == 0) {          //znaky povolené na první pozici 
                if (!char.IsControl(e.KeyChar) && !(e.KeyChar >= '1' && e.KeyChar <= '9')) {
                    e.Handled = true;
                }
            }
            else {                                                  //znaky povolené na dalších pozicích
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                    e.Handled = true;
                }
            }
        }        
    }
}
