using System;

enum meses
{
	Enero,
	Febrero,
	Marzo,
	Abril,
	Mayo,
	Junio,
	Julio,
	Agosto,
	Septiembre,
	Octubre,
	Noviembre,
	Diciembre
}

public class Program
{
	public static int Main()
	{
		Console.WriteLine(meses.Enero);
		Console.WriteLine((meses)1);
		return 0;
	}
}