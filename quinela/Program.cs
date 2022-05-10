// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




List<String> Equipos = new List<String>()
{
    "Atlas","Chivas", "Tigres", "America", "Cruz Azul", "Pachuca", "Puebla", "San Luis",
};

List<String> Particiapantes = new List<String>()
{
    "Dulce", "Alondra", "Andrea", "Gonzalo", "Eunice", "Eduardo", "?", "?"
};

var resultado = GenerarQuinela (Equipos, Particiapantes);

foreach ( var item in resultado)
{
    Console.WriteLine(item);
}

List<String> GenerarQuinela (List<String>Equipos,List<String>Participantes)
{
    List<String> EquiposParticiapantes = new List<String>();

    var sortedEquipos = Equipos.OrderBy(_=> Guid.NewGuid());
    List<String> sortedParticipantes = Participantes.OrderBy(_=> Guid.NewGuid()).ToList();

    foreach (var item in sortedEquipos)
    {
        EquiposParticiapantes.Add(item + " - " + sortedParticipantes.First());
        sortedParticipantes.RemoveAt(0);
    }

    return EquiposParticiapantes;
}