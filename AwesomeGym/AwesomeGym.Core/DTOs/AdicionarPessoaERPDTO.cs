using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeGym.Core.DTOs
{
    public class AdicionarPessoaERPDTO
    {
        public AdicionarPessoaERPDTO(string nomeCompleto, string numeroDocumento)
        {
            NomeCompleto = nomeCompleto;
            NumeroDocumento = numeroDocumento;
        }

        public string NomeCompleto { get; private set; }
        public string NumeroDocumento { get; private set; }
    }
}
