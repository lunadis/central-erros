using AutoMapper;
using CentralErros.Application.Interface;
using CentralErros.Application.ViewModel;
using CentralErros.Domain.Interfaces;
using CentralErros.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CentralErros.Application.App
{
    public class UsuarioAplicacaoApp : IUsuarioAplicacaoApp
    {
        private readonly IUsuarioAplicacaoRepositorio _repo;
        private readonly IMapper _mapper;

        public UsuarioAplicacaoApp(IUsuarioAplicacaoRepositorio repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Alterar(UsuarioAplicacaoViewModel entity)
        {
            _repo.Alterar(_mapper.Map<UsuarioAplicacao>(entity));
        }

        public void Deletar(int id)
        {
            _repo.Deletar(id);
        }

        public void Incluir(UsuarioAplicacaoViewModel entity)
        {
            _repo.Incluir(_mapper.Map<UsuarioAplicacao>(entity));
        }

        public IEnumerable<UsuarioAplicacaoViewModel> ListarTodos()
        {
            return _mapper.Map<IEnumerable<UsuarioAplicacaoViewModel>>(_repo.ListarTodos());
        }

        public UsuarioAplicacaoViewModel Selecionar(int id)
        {
            return _mapper.Map<UsuarioAplicacaoViewModel>(_repo.Selecionar(id));
        }
    }
}
