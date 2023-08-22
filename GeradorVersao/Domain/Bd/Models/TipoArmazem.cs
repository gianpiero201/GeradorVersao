using System;
using System.Collections.Generic;

namespace GeradorVersao.Domain.Bd.Models;

public partial class TipoArmazem
{
    public long Id { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Armazem> Armazems { get; set; } = new List<Armazem>();
}
