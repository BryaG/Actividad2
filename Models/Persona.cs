using System;
using System.Collections.Generic;

namespace PersonasAutos.Models;

public partial class Persona
{
    public string Curp { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public int? Edad { get; set; }

    public string? Genero { get; set; }

    public string? Ciudad { get; set; }

    public string? Telefono { get; set; }

    public string? EstadoCivil { get; set; }

    public decimal? Estatura { get; set; }

    public virtual ICollection<Auto> Autos { get; set; } = new List<Auto>();
}
