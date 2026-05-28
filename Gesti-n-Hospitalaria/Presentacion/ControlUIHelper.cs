using System.Windows.Forms;
using System.Collections.Generic;
using Sara_UI_Design.SaraControls;
namespace Presentacion {
    public static class ControlUIHelper {
        public static void LlenarComboFk<T>(SaraUI_ComboBox combo, List<T> datos, string campoMostrar, string campoId) {
            combo.DataSource = datos;
            combo.DisplayMember = campoMostrar;
            combo.ValueMember = campoId;
            combo.SelectedIndex = -1;
        }
    }
}