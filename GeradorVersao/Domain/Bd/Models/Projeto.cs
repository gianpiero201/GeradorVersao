using System;
using System.Collections.Generic;

namespace GeradorVersao.Domain.Bd.Models;

public partial class Projeto
{
    public long Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Caminho { get; set; } = null!;

    public long DeployAutomatico { get; set; }

    public long? IdArmazem { get; set; }

    public virtual Armazem? IdArmazemNavigation { get; set; }
}
