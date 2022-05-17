using Marvel;

var repository = new Repository();

foreach (var heroevillano in repository.GetAll())
{
    Console.WriteLine(heroevillano.Title);