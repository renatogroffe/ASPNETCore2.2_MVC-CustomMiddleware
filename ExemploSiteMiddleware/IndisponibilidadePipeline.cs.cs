using Microsoft.AspNetCore.Builder;

namespace ExemploSiteMiddleware
{
    public class IndisponibilidadePipeline
    {
        public void Configure(IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.UseChecagemIndisponibilidade();
        }
    }
}