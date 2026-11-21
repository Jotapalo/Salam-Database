using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salam_Database.Utils
{
    public class GenericTools
    {
        public static void ClearEntriesByPanel(Panel panel)
        {
            foreach (TextBox obj in GetAll(panel, typeof(TextBox)))
            {
                obj.Text = "";
            }
            foreach (ComboBox obj in GetAll(panel, typeof(ComboBox)))
            {
                obj.SelectedIndex = -1;
                obj.Text = "";
            }
        }
        public static IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                           .Concat(controls)
                           .Where(c => c.GetType() == type);
        }

        public static IEnumerable<object> GetAllByList(List<object> controls, Type type)
        {
            return controls.Where(c => c.GetType() == type);
        }

        public static void GetRowByColumn(DataGridView dataGridView, string value, string columnName, out DataGridViewRow row)
        {
            row = null;
            foreach (DataGridViewRow r in dataGridView.Rows)
            {
                if (r.Cells[columnName].Value != null && r.Cells[columnName].Value.ToString() == value)
                {
                    row = r;
                    break;
                }
            }
        }

        public static void OnlyNumericTextBox_keypress(object sender, KeyPressEventArgs e)
        {
            // Validar que solo se ingresen numeros en la cantidad
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static bool IsNullOrEmpty(params object[] param)
        {
            // For case of textBox and comboBox

            List<object> Controls = param.ToList();

            foreach (TextBox textBox in GetAllByList(Controls, typeof(TextBox)))
            {
                if (string.IsNullOrEmpty(textBox.Text)) return true;
            }

            foreach (ComboBox comboBox in GetAllByList(Controls, typeof(ComboBox)))
            {
                if (string.IsNullOrEmpty(comboBox.Text)) return true;
            }

            return false;
        }
    }
}
