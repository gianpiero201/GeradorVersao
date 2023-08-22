using System;
using System.Collections.Generic;

namespace GeradorVersao.Domain.Bd.Models;

public partial class Armazem
{
    public long Id { get; set; }

    public string? Nome { get; set; }

    public string? Caminho { get; set; }

    public long? IdTipoArmazem { get; set; }

    public virtual TipoArmazem? IdTipoArmazemNavigation { get; set; }

    public virtual ICollection<Projeto> Projetos { get; set; } = new List<Projeto>();
}
