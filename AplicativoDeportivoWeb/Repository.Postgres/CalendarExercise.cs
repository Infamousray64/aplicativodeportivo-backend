using System.ComponentModel.DataAnnotations;

namespace AplicativoDeportivoWeb.Repository.Postgres;
public class CalendarExercise: KeyEntity<long>
{
    [StringLength(50)]
    public string Lunes { get; set; }

    [StringLength(50)]
    public string Martes { get; set; }

    [StringLength(150)]
    public string Miercoles { get; set; }

    [StringLength(1000)]
    public string Jueves { get; set; }

    [StringLength(1000)]
    public string Viernes { get; set; }

    [StringLength(1000)]
    public string Sabado { get; set; }

    [StringLength(1000)]
    public string Domingo { get; set; }
}