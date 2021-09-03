using AutoMapper;
using BalancePlatform.Backend.Domain.Entities.Groups;
using BalancePlatform.Backend.Domain.Ninject;
using BalancePlatform.Backend.Domain.Services.Implementations.BaseImplementations;
using BalancePlatform.Backend.Domain.Services.Interfaces.BalancePlatformInterfaces;
using BalancePlatform.Backend.Infrastructure.Contexts;
using BalancePlatform.Backend.Infrastructure.Repositories.Interfaces.BaseInterfaces;
using Ninject;
using Ninject.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancePlatform.Backend.Domain.Services.Implementations.BalancePlatformImplementations
{
    /// <summary>
    /// Сервис работы с группами
    /// </summary>
    public class GroupService : BaseService, IGroupService
    {
        private readonly BalancePlatformContext _balancePlatformContext;

        //private readonly IEntityWithIdRepository<GroupDao, int> _roleRepository;

        private readonly IMapper _mapper;

        /// <summary>
        /// Сервис работы с группами
        /// </summary>
        public GroupService()
        {
            IKernel kernel = new StandardKernel(new BalancePlatformModule());

            _balancePlatformContext = kernel.Get<BalancePlatformContext>();

            //_groupRepository = kernel.Get<IEntityWithIdRepository<GroupDao, int>>(new ConstructorArgument("context", _balancePlatformContext));

            _mapper = kernel.Get<IMapper>();
        }

        /// <summary>
        /// Возвращает интерфейс для запроса групп
        /// </summary>
        /// <returns>Интерфейс для запроса групп</returns>
        public IQueryable<Group> GetQueryable()
        {
            //var roleQueryable = _roleRepository.GetQueryable();
            return null;//_mapper.ProjectTo<Role>(roleQueryable);
        }
    }
}
