using System;
using System.Collections.Generic;

namespace PersonasAutos.Models;

public partial class Auto
{
    public string Matricula { get; set; } = null!;

    public string? Modelo { get; set; }

    public string? Marca { get; set; }

    public string? Color { get; set; }

    public int? Anio { get; set; }

    public decimal? Precio { get; set; }

    public decimal? Peso { get; set; }

    public string? Tipo { get; set; }

    public string? CurpPersona { get; set; }

    public virtual Persona? CurpPersonaNavigation { get; set; }
}
