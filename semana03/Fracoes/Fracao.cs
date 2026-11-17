public class Fracao
{
    private int _numerador;
    private int _denominador;

    // Construtor padrão (1/1)
    public Fracao()
    {
        _numerador = 1;
        _denominador = 1;
    }

    // Construtor com numerador
    public Fracao(int numeroInteiro)
    {
        _numerador = numeroInteiro;
        _denominador = 1;
    }

    // Construtor com numerador e denominador
    public Fracao(int numerador, int denominador)
    {
        _numerador = numerador;
        _denominador = denominador;
    }

    // Getter Numerador
    public int ObterNumerador()
    {
        return _numerador;
    }

    // Setter Numerador
    public void DefinirNumerador(int numerador)
    {
        _numerador = numerador;
    }

    // Getter Denominador
    public int ObterDenominador()
    {
        return _denominador;
    }

    // Setter Denominador
    public void DefinirDenominador(int denominador)
    {
        _denominador = denominador;
    }

    // Retorna 3/4
    public string ObterFracaoEmTexto()
    {
        return $"{_numerador}/{_denominador}";
    }

    // Retorna 0.75
    public double ObterFracaoEmDecimal()
    {
        return (double)_numerador / _denominador;
    }
}