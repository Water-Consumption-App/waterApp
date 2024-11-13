using System.Drawing;
using System.Windows.Forms;

public class LifeBar : Panel
{
    private int _value;
    private int _maximum;
    private Color _barColor;

    // Propriedade para o valor atual da vida
    public int Value
    {
        get { return _value; }
        set
        {
            if (value < 0) _value = 0;
            else if (value > _maximum) _value = _maximum;
            else _value = value;
            Invalidate(); // Redesenha a barra quando o valor mudar
        }
    }

    // Propriedade para o valor máximo da vida
    public int Maximum
    {
        get { return _maximum; }
        set
        {
            if (value > 0) _maximum = value;
            else _maximum = 1;
            Invalidate(); // Redesenha a barra quando o valor máximo mudar
        }
    }

    // Cor da barra de vida
    public Color BarColor
    {
        get { return _barColor; }
        set
        {
            _barColor = value;
            Invalidate(); // Redesenha a barra quando a cor mudar
        }
    }

    // Construtor do controle LifeBar
    public LifeBar()
    {
        this.DoubleBuffered = true;
        this.SetStyle(ControlStyles.UserPaint, true);
        this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        this.BackColor = Color.Transparent;
    }

    // Método para desenhar a barra de vida com cantos arredondados
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Desenhando o fundo da barra (com cantos arredondados)
        using (Brush backgroundBrush = new SolidBrush(Color.Gray))
        {
            e.Graphics.FillRectangle(backgroundBrush, 0, 0, this.Width, this.Height);
        }

        // Calculando a largura da barra proporcional ao valor da vida
        float percentage = (float)_value / _maximum;
        int barWidth = (int)(this.Width * percentage); // Largura da barra proporcional

        // Desenhando a barra de vida com a cor definida e cantos arredondados
        using (Brush barBrush = new SolidBrush(_barColor))
        {
            e.Graphics.FillRectangle(barBrush, 0, 0, barWidth, this.Height);
        }

        // Desenhando a borda com cantos arredondados
        using (Pen borderPen = new Pen(Color.Black, 2))
        {
            e.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
        }
    }
}
