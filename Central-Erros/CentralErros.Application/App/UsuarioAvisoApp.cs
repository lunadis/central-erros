using System.Collections.Generic;
using AutoMapper;
using CentralErros.Application.Interface;
using CentralErros.Application.ViewModel;
using CentralErros.Domain.Interfaces;

namespace CentralErros.Domain.Models
{
    public class UsuarioAvisoApp : IUsuarioAvisoApp
    {

        private readonly IUsuarioAvisoRepositorio _repo;
        private readonly IMapper _mapper;

        public UsuarioAvisoApp(IUsuarioAvisoRepositorio repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Alterar(UsuarioAvisoViewModel entity)
        {
            _repo.Alterar(_mapper.Map<UsuarioAviso>(entity));
        }

        public void Deletar(int id)
        {
            _repo.Deletar(id);
        }

        public void Incluir(UsuarioAvisoViewModel entity)
        {
            _repo.Incluir(_mapper.Map<UsuarioAviso>(entity));
        }

        public IEnumerable<UsuarioAvisoViewModel> ListarTodos()
        {
            return _mapper.Map<IEnumerable<UsuarioAvisoViewModel>>(_repo.ListarTodos());
        }

        public UsuarioAvisoViewModel Selecionar(int id)
        {
            return _mapper.Map<UsuarioAvisoViewModel>(_repo.Selecionar(id));
        }
    }
}