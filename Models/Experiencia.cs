using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuCurriculo.models
{
    public class Experiencia
    {
            public string Empresa {get; set;} = string.Empty;
            public string Cargo {get; set;} = string.Empty;
            public string Inicio {get; set;} = string.Empty;
            public string Fim {get; set;} = "Atual";
            public string Descricao {get; set;} = string.Empty;
    }
}