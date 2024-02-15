using System.ComponentModel.DataAnnotations;

namespace AplicativoDeportivoWeb.Repository.Postgres;

public class Exercises : KeyEntity<int>
{
    [StringLength(100)]
    public string Name { get; set; }

    public string Muscle { get; set; } 
}
