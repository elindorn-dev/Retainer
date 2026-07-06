using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retainer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
public class RoundedButton : Button
{
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (var path = new GraphicsPath())
        {
            int radius = 20; // Задайте нужный радиус

            // Добавляем дуги и линии для формирования скруглённых углов
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddLine(radius, 0, Width - radius, 0);
            path.AddArc(Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(Width, radius, Width, Height - radius);
            path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
            path.AddLine(Width - radius, Height, radius, Height);
            path.AddArc(0, Height - radius, radius, radius, 90, 90);
            path.AddLine(0, Height - radius, 0, radius);
            path.CloseFigure();

            // Устанавливаем регион кнопки
            this.Region = new Region(path);

            // Для сглаживания краёв
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }
    }
}