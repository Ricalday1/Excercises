namespace Consola_Tabla_de_amortizacion;

public struct Parametros
{
    
    public decimal Interes_pagados { get; set;}
    public decimal Capital_pagado { get; set; }
    public decimal Monto_del_prestamo { get; set; }
    public decimal Tasa_interes_mensual { 
        get => (Tasa_interes_anual / 100) / 12;        
    }
    public decimal Tasa_interes_anual { get; set; }
    public decimal Plazo { get; set; }
    public decimal Calcular_pago (decimal  Tasa_interes_mensual, decimal Plazo, decimal Monto_del_prestamo) 
    {
        decimal resultado = 0;
        resultado = Tasa_interes_mensual + 1;
        resultado = (decimal)Math.Pow((double) resultado, (double)Plazo);
        resultado = resultado - 1;
        resultado = Tasa_interes_mensual / resultado;
        resultado = Tasa_interes_mensual + resultado;
        resultado = Monto_del_prestamo * resultado;
        return resultado;

    }
}