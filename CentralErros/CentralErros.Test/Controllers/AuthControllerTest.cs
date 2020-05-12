using CentralErros.Api.Controllers;
using CentralErros.Application.Interface;
using CentralErros.Application.ViewModel;
using CentralErros.Application.ViewModel.Usuario;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CentralErros.Test.Controllers
{
    public class AuthControllerTest
    {
        private readonly Mock<IUsuarioAplicacao> _MockUsuario;
        private readonly Mock<IOptions<Token>> _mockToken;

        public AuthControllerTest()
        {
            _MockUsuario = new Mock<IUsuarioAplicacao>();
        }

        [Fact]
        public  void Registrar_usuario_com_Sucesso()
        {
            var controller = new AuthController(_MockUsuario.Object);
            var usu = new RegistrarUsuarioViewModel() {
                Nome = "Andre",
                Email = "andre@gemail.com",
                Senha = "862411Andre!@#$",
                ConfirmarSenha = "862411Andre!@#$"
            };
            _MockUsuario.Setup(x => x.Registrar(usu))
                .Returns(Task.FromResult(new AvisoLoginViewModel()));

            var result = controller.Registrar(usu);
            Assert.NotNull(result);
            Assert.IsType<ActionResult<AvisoLoginViewModel>>(result);
        }
        [Fact]
        public async Task Registrar_usuario_com_Erros()
        {
            var controller = new AuthController(_MockUsuario.Object);
            var usu = new RegistrarUsuarioViewModel()
            {
                Nome = "Andre",
                Email = "andre@gemail.com",
                Senha = "862411",
                ConfirmarSenha = "862411"
            };
            _MockUsuario.Setup(x => x.Registrar(usu))
                .ReturnsAsync(getUsersViewModel());

            var res = controller.Registrar(usu);
            Assert.Null(res.Value);
            Assert.IsType<ActionResult<AvisoLoginViewModel>>(res);
        }

        private AvisoLoginViewModel getUsersViewModel()
        {
            return new AvisoLoginViewModel()
            {
                Descricao = "ErroAcontceu",
                Token = null
            };
        }
    }
}
