using System.ComponentModel.DataAnnotations;

namespace AplicativoDeportivoWeb.Repository.Postgres;

public class KeyEntity<T>
{
    [Key]
    public virtual T? Id { get; set; }
}