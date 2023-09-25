using System.ComponentModel.DataAnnotations;

namespace AplicativoDeportivoWeb.Repository.Postgres;

public class User: KeyEntity<long>
{
    [StringLength(50)]
    public string Name { get; set; }

    [StringLength(50)]
    public string Surname { get; set; }

    [StringLength(150)]
    public string Email { get; set; }

    [StringLength(1000)]
    public string Password { get; set; }

    public DateTime DOB{ get; set; }

    public float Weight { get; set; }

    public float Height { get; set; }
}