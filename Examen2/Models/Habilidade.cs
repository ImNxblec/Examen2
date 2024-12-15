using System;
using System.Collections.Generic;

namespace Examen2.Models;

public partial class Habilidade
{
    public int IdHabilidad { get; set; }

    public int? IdSuperheroe { get; set; }

    public string? NombreHabilidad { get; set; }

    public string? Descripcion { get; set; }

    public virtual Superhero? IdSuperheroeNavigation { get; set; }
}
