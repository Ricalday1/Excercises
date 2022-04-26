namespace Consola_Tabla_de_amortizacion;

public struct Parametros
{
    public decimal Pago { get; set; }
    public decimal Interes_pagados { get; set;}
    public decimal Capital_pagado { get; set; }
    public decimal Monto_del_prestamo { get; set; }
    public decimal Tasa_interes_mensual { 
        get => (Tasa_interes_anual / 100) / 12;        
    }
    public decimal Tasa_interes_anual { get; set; }
    public decimal Plazo { get; set; }
}