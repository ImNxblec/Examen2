using System;
using System.Collections.Generic;

namespace Examen2.Models;

public partial class Misione
{
    public int IdMision { get; set; }

    public int? IdSuperheroe { get; set; }

    public string? NombreMision { get; set; }

    public string? Descripcion { get; set; }

    public string? Estado { get; set; }

    public virtual Superhero? IdSuperheroeNavigation { get; set; }
}
