using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Examen2.Models;

public partial class Superhero
{
    public int IdSuperheroe { get; set; }

    public string? Nombre { get; set; }

    public string? Alias { get; set; }

    public string? Origen { get; set; }

    public int? NivelPoder { get; set; }

    public string Estado { get; set; } = null!;

    public virtual ICollection<Habilidade> Habilidades { get; set; } = new List<Habilidade>();

    public virtual ICollection<Misione> Misiones { get; set; } = new List<Misione>();
}
