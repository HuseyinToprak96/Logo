using AutoMapper;
using Layer.Core.Interfaces.Repository;
using Layer.Core.Interfaces.Service;
using Layer.Core.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Service.Services
{
    public class Service<T> : IService<T> where T : class
    {
        protected readonly IMapper _mapper;
        private readonly IGenericRepository<T> _genericRepository;
        protected readonly IUnitOfWork _unitOfWork;
        public Service(IMapper mapper, IGenericRepository<T> genericRepository, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _genericRepository = genericRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<T> AddAsync(T tEntity)
        {
            await _genericRepository.AddAsync(tEntity);
            await _unitOfWork.CommitAsync();
            return tEntity;
        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> Entities)
        {
            await _genericRepository.AddRangeAsync(Entities);
            await _unitOfWork.CommitAsync();
            return Entities;
        }

        public async Task<bool> AnyAsync(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return await _genericRepository.AnyAsync(expression);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _genericRepository.GetAllAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _genericRepository.GetByIdAsync(id);
        }

        public async Task Remove(T tEntity)
        {
            _genericRepository.Remove(tEntity);
            await _unitOfWork.CommitAsync();
        }

        public async Task RemoveRange(IEnumerable<T> Entities)
        {
            _genericRepository.RemoveRange(Entities);
            await _unitOfWork.CommitAsync();

        }

        public async Task Update(T tEntity)
        {
            _genericRepository.Update(tEntity);
            await _unitOfWork.CommitAsync();
        }

        public IQueryable<T> Where(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return _genericRepository.Where(expression);
        }
    }
}
