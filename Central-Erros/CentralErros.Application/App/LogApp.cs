using System.Collections.Generic;
using AutoMapper;
using CentralErros.Application.Interface;
using CentralErros.Application.ViewModel;
using CentralErros.Domain.Interfaces;
using CentralErros.Domain.Models;

namespace CentralErros.Application.App
{
    public class LogApp : ILogApp
    {
        private readonly ILogRepositorio _repo;
        private readonly IMapper _mapper;

        public LogApp(ILogRepositorio repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Alterar(LogViewModel entity)
        {
            _repo.Alterar(_mapper.Map<Log>(entity));
        }

        public void Deletar(int id)
        {
            _repo.Deletar(id);
        }

        public void Incluir(LogViewModel entity)
        {
            _repo.Incluir(_mapper.Map<Log>(entity));
        }

        public IEnumerable<LogViewModel> ListarTodos()
        {
            return _mapper.Map<IEnumerable<LogViewModel>>(_repo.ListarTodos());
        }

        public LogViewModel Selecionar(int id)
        {
            return _mapper.Map<LogViewModel>(_repo.Selecionar(id));
        }
    }
}
