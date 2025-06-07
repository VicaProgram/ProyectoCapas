using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public static class ModernStyles
{
    // ===== ESTILO PARA BOTONES (VERDE CLARO) =====
    public static void ApplyModernStyle(this Button button)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.BackColor = Color.FromArgb(100, 200, 100);  // Verde claro
        button.ForeColor = Color.White;                    // Texto blanco
        button.Font = new Font("Segoe UI", 10, FontStyle.Bold); // Texto en negrita
        button.Cursor = Cursors.Hand;

        // Bordes redondeados
        button.Paint += (sender, e) => {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (var path = new GraphicsPath())
            {
                int radius = 12;  // Radio más pronunciado
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, button.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();
                button.Region = new Region(path);
            }
        };

        // Efecto hover (verde más oscuro al pasar el mouse)
        button.MouseEnter += (sender, e) => button.BackColor = Color.FromArgb(70, 180, 70);
        button.MouseLeave += (sender, e) => button.BackColor = Color.FromArgb(100, 200, 100);
    }

    // ===== ESTILOS PARA OTROS CONTROLES (se mantienen igual) =====
    public static void ApplyModernStyle(this TextBox textBox)
    {
        textBox.BorderStyle = BorderStyle.None;
        textBox.BackColor = Color.FromArgb(240, 240, 240);
        textBox.Font = new Font("Segoe UI", 10);

        var underline = new Panel
        {
            Height = 2,
            Dock = DockStyle.Bottom,
            BackColor = Color.FromArgb(100, 100, 100)
        };
        textBox.Controls.Add(underline);
    }

    public static void ApplyModernStyle(this DataGridView dgv)
    {
        dgv.BorderStyle = BorderStyle.None;
        dgv.BackgroundColor = Color.FromArgb(240, 240, 240);
        dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 200, 100); // Verde claro en cabeceras
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        dgv.EnableHeadersVisualStyles = false;
        dgv.RowHeadersVisible = false;
        dgv.GridColor = Color.FromArgb(200, 200, 200);
    }

    public static void ApplyModernStyle(this MenuStrip menu)
    {
        menu.Renderer = new ToolStripProfessionalRenderer(new ModernMenuColors());
        menu.Font = new Font("Segoe UI", 10);
        menu.BackColor = Color.FromArgb(50, 50, 50);
        menu.ForeColor = Color.White;
    }
}

// Colores personalizados para el menú (opcional, si quieres que coincida con el verde)
public class ModernMenuColors : ProfessionalColorTable
{
    public override Color MenuItemSelected => Color.FromArgb(70, 180, 70); // Verde claro seleccionado
    public override Color MenuItemBorder => Color.FromArgb(100, 200, 100);
    public override Color MenuItemPressedGradientBegin => Color.FromArgb(80, 190, 80);
    public override Color MenuItemPressedGradientEnd => Color.FromArgb(80, 190, 80);
}