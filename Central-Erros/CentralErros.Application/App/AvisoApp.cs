using System.Collections.Generic;
using AutoMapper;
using CentralErros.Application.ViewModel;
using CentralErros.Domain.Interfaces;
using CentralErros.Domain.Models;

namespace CentralErros.Application.App
{
    public class AvisoApp : IAvisoApp
    {
        private readonly IAvisoRepositorio _repo;
        private readonly IMapper _mapper;

        public AvisoApp(IAvisoRepositorio repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Alterar(AvisoViewModel entity)
        {
            _repo.Alterar(_mapper.Map<Aviso>(entity));
        }

        public void Deletar(int id)
        {
            _repo.Deletar(id);
        }

        public void Incluir(AvisoViewModel entity)
        {
            _repo.Incluir(_mapper.Map<Aviso>(entity));
        }

        public IEnumerable<AvisoViewModel> ListarTodos()
        {
            return _mapper.Map<IEnumerable<AvisoViewModel>>(_repo.ListarTodos());
        }

        public AvisoViewModel Selecionar(int id)
        {
            return _mapper.Map<AvisoViewModel>(_repo.Selecionar(id));
        }
    }
}
