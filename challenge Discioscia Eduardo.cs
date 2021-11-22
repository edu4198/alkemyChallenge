using Systema.data.entity:


public class Challenge: DbContext
{
    public ChallengeContext()
    {

    }
    //Entities
    public DbSet<Personaje> Personaje {get;set;}
    public Dbset<PeliculaSerie> PeliculaSerie {get;set;}
    public DbSet<Genero>Genero {get;set;}

}
public class Personaje 
{
    //scalar properties
    public byte Imagen {get;set;}
    public string Nombre {get;set;}
    public int Edad {get;set;}
    public decimal Peso {get;set;}
    public string Historia {get;set;}
    
    //reference navigation properties
    public PeliculaSerie PeliculaSerie {get;set;}
}
public class PeliculaSerie 
{
    //scalar properties
    public byte Imagen {get;set;}
    public string Titulo {get;set;}
    public Datetime? FechaDeCreacion {get;set;}
    public int Calificacion {get;set;}
    
    //reference navigation properties
    public Personaje Personaje {get;set;}
}
public class Genero
{
    public string Nombre {get;set;}
    public byte Imagen {get;set;}

    public ICollection<PeliculaSerie>PeliculaSerie {get;set}
}