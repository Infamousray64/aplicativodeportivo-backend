using System.ComponentModel.DataAnnotations;

namespace AplicativoDeportivoWeb.Repository.Postgres;

public class Muscle : KeyEntity<int>
{
   [StringLength(100)]
    public string Name { get; set; } 
}
