namespace Heroesvillanos;

public class Parser 
{
    public Heroevillano Parse(string line)
    {
        var heroevillano = new Heroevillano();
        var values = line.Split(',');
        heroevillano.Id = long.Parse(values[0]);
        heroevillano.Name = values[1];
       // heroevillano.Gender = (Gender)Enum.Parse(typeof(Genre), values[2]);
      //  heroevillno.Alignment = (Alignment)Enum.Parse(typeof(Alige), values[3]);
        heroevillano.Overview = values[4];
       // movie.Popularity = long.Parse(values[5]);
        //movie.ProductionCompanies = values[6].Split('-').ToList();
        return heroevillano;
    }
}