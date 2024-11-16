using System;
using System.Drawing;
using System.Windows.Forms;

public class CustomProgressBar : Panel
{
    private int _progress = 0;
    public Color ProgressBarColor { get; set; } = ColorTranslator.FromHtml("#f2b671"); // Cor personalizada
    public int BorderRadius { get; set; } = 10;

    // Tamanho da barra de progresso
    public int ProgressBarWidth { get; set; } = 400;  // Largura fixa para a barra
    public int ProgressBarHeight { get; set; } = 40;  // Altura fixa para a barra

    public int Progress
    {
        get { return _progress; }
        set
        {
            _progress = Math.Min(100, Math.Max(0, value)); // Limita o progresso entre 0 e 100
            Invalidate(); // Redesenha a barra de progresso
        }
    }

    public CustomProgressBar()
    {
        DoubleBuffered = true; // Evita flickering
        this.BackColor = Color.Transparent; // Define o fundo como transparente
        this.Size = new Size(720, 480);  // Define o tamanho da tela
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (var progressBrush = new SolidBrush(ProgressBarColor))
        {
            // Desenha a barra de progresso com bordas arredondadas
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Calcula a posição para centralizar a barra
            int posX = (this.Width - ProgressBarWidth) / 2;
            int posY = (this.Height - ProgressBarHeight) / 2;

            // Desenha o fundo da barra com bordas arredondadas (transparente)
            using (var backBrush = new SolidBrush(Color.Transparent))
            {
                DrawRoundedRectangle(e.Graphics, new Rectangle(posX, posY, ProgressBarWidth, ProgressBarHeight), BorderRadius, backBrush);
            }

            // Desenha a barra de progresso com bordas arredondadas
            int width = (int)(ProgressBarWidth * (_progress / 100.0));
            DrawRoundedRectangle(e.Graphics, new Rectangle(posX, posY, width, ProgressBarHeight), BorderRadius, progressBrush);
        }
    }

    private void DrawRoundedRectangle(Graphics g, Rectangle bounds, int radius, Brush brush)
    {
        using (var path = new System.Drawing.Drawing2D.GraphicsPath())
        {
            float diameter = radius * 2;
            path.AddArc(bounds.Left, bounds.Top, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Top, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            g.FillPath(brush, path);
        }
    }
}
