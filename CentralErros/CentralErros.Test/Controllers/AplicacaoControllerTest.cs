using AutoMapper;
using CentralErros.Api.Controllers;
using CentralErros.Application.App;
using CentralErros.Application.Mapper;
using CentralErros.Application.ViewModel.Aplicacao;
using CentralErros.Data.Repositorio;
using CentralErros.Test.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Threading.Tasks;
using Xunit;

namespace CentralErros.Test.Controllers
{
    public class AplicacaoControllerTest
    {
        private readonly IMapper _mapper;
        private readonly FakeContext _ContextoFake;

        public AplicacaoControllerTest()
        {
            _ContextoFake = new FakeContext("AplicacaoController");
            var configuration = new MapperConfiguration(cfg =>
             {
                 cfg.AddProfile(new AutoMapperConfig());
             });
            _mapper = configuration.CreateMapper();
        }

        [Fact]
        public async Task Incluir_Aplicacao_com_Sucesso()
        {
            var context = _ContextoFake.GerarContexto("InlcuirAplicacao_Sucesso");
            context = ContextFakeSeeds.SeedAplicacao(context);

            var repo = new AplicacaoRepositorio(context);
            var services = new AplicacaoAplicacao(repo, _mapper);
            var controller = new AplicacaoController(services);

            controller.ControllerContext.HttpContext = new DefaultHttpContext();
            controller.ControllerContext.HttpContext.User = GerarUsuarioPadraoParaContexto();

            var result = controller.Post(new CadastroAplicacaoViewModel() { Descricao = "Sistma de gestao de redes", Nome = "SGR" });

            Assert.IsType<ActionResult<AplicacaoSimplesViewModel>>(result);
            var res = Assert.IsType<OkObjectResult>(result.Result);
            Assert.IsType<AplicacaoSimplesViewModel>(res.Value);
        }

        [Fact]
        public async Task Selecionar_Aplicacao_Com_Sucesso()
        {
            var context = _ContextoFake.GerarContexto("InlcuirAplicacao_Sucesso");
            context = ContextFakeSeeds.SeedAplicacao(context);

            var repo = new AplicacaoRepositorio(context);
            var services = new AplicacaoAplicacao(repo, _mapper);
            var controller = new AplicacaoController(services);

            controller.ControllerContext.HttpContext = new DefaultHttpContext();
            controller.ControllerContext.HttpContext.User = GerarUsuarioPadraoParaContexto();

            var result = controller.GetAppId(1);

            Assert.IsType<ActionResult<AplicacaoSimplesViewModel>>(result);
            var res = Assert.IsType<OkObjectResult>(result.Result);
            Assert.IsType<AplicacaoSimplesViewModel>(res.Value);
        }
        [Fact]
        public async Task Selecionar_Aplicacao_Com_No_Content()
        {
            var context = _ContextoFake.GerarContexto("InlcuirAplicacao_Sucesso");
            context = ContextFakeSeeds.SeedAplicacao(context);

            var repo = new AplicacaoRepositorio(context);
            var services = new AplicacaoAplicacao(repo, _mapper);
            var controller = new AplicacaoController(services);

            controller.ControllerContext.HttpContext = new DefaultHttpContext();
            controller.ControllerContext.HttpContext.User = GerarUsuarioPadraoParaContexto();

            var result = controller.GetAppId(null);

            Assert.IsType<ActionResult<AplicacaoSimplesViewModel>>(result);
            var res = Assert.IsType<NoContentResult>(result.Result);
            Assert.Equal(res.StatusCode, 204);
        }


        private ClaimsPrincipal GerarUsuarioPadraoParaContexto()
        {
            return new ClaimsPrincipal(
                    new List<ClaimsIdentity>()
                    {
                        new ClaimsIdentity(
                            new List<Claim>()
                            {
                                new Claim("id", Guid.NewGuid().ToString()),
                                new Claim("role", "usuario")
                            }
                        )}
                    );
        }
    }
}
