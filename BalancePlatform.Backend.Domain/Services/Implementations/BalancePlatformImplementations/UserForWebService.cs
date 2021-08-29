using AutoMapper;
using BalancePlatform.Backend.Domain.Entities.Users;
using BalancePlatform.Backend.Domain.Ninject;
using BalancePlatform.Backend.Domain.Services.Implementations.BaseImplementations;
using BalancePlatform.Backend.Domain.Services.Interfaces.BalancePlatformInterfaces;
using BalancePlatform.Backend.Infrastructure.Contexts;
using BalancePlatform.Backend.Infrastructure.Entites;
using BalancePlatform.Backend.Infrastructure.Repositories.Interfaces.BaseInterfaces;
using Ninject;
using Ninject.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancePlatform.Backend.Domain.Services.Implementations.BalancePlatformImplementations
{
    /// <summary>
    /// Сервис работы с пользователями для веб интерфейса
    /// </summary>
    public class UserForWebService : BaseService, IUserForWebService
    {
        private readonly BalancePlatformContext _balancePlatformContext;

        private readonly IEntityWithIdRepository<UserDao, int> _userRepository;

        private readonly IMapper _mapper;

        /// <summary>
        /// Сервис работы с пользователями для веб интерфейса
        /// </summary>
        public UserForWebService()
        {
            IKernel kernel = new StandardKernel(new BalancePlatformModule());

            _balancePlatformContext = kernel.Get<BalancePlatformContext>();

            _userRepository = kernel.Get<IEntityWithIdRepository<UserDao, int>>(new ConstructorArgument("context", _balancePlatformContext));

            _mapper = kernel.Get<IMapper>();
        }

        /// <summary>
        /// Возвращает интерфейс для запроса пользователей для веб интерфейса
        /// </summary>
        /// <returns>Интерфейс для запроса пользователей для веб интерфейса</returns>
        public IQueryable<UserForWeb> GetQueryable()
        {
            var userQueryable = _userRepository.GetQueryable().Where(x => x.IsActive).Where(x => x.RoleId == 3);
            return _mapper.ProjectTo<UserForWeb>(userQueryable);
        }
    }
}
