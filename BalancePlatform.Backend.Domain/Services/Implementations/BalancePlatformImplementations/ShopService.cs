using AutoMapper;
using BalancePlatform.Backend.Domain.Entities.ShopItems;
using BalancePlatform.Backend.Domain.Ninject;
using BalancePlatform.Backend.Domain.Services.Implementations.BaseImplementations;
using BalancePlatform.Backend.Domain.Services.Interfaces.BalancePlatformInterfaces;
using BalancePlatform.Backend.Infrastructure.Contexts;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancePlatform.Backend.Domain.Services.Implementations.BalancePlatformImplementations
{
    /// <summary>
    /// Сервис работы с магазином
    /// </summary>
    public class ShopService : BaseService, IShopService
    {
        private readonly BalancePlatformContext _balancePlatformContext;

        //private readonly IEntityWithIdRepository<GroupDao, int> _roleRepository;

        private readonly IMapper _mapper;

        /// <summary>
        /// Сервис работы с магазином
        /// </summary>
        public ShopService()
        {
            IKernel kernel = new StandardKernel(new BalancePlatformModule());

            _balancePlatformContext = kernel.Get<BalancePlatformContext>();

            //_groupRepository = kernel.Get<IEntityWithIdRepository<GroupDao, int>>(new ConstructorArgument("context", _balancePlatformContext));

            _mapper = kernel.Get<IMapper>();
        }

        /// <summary>
        /// Возвращает интерфейс для запроса товаров магазина
        /// </summary>
        /// <returns>Интерфейс для запроса товаров магазина</returns>
        public IQueryable<Product> GetQueryable()
        {
            //var roleQueryable = _roleRepository.GetQueryable();
            return null;//_mapper.ProjectTo<Role>(roleQueryable);
        }
    }
}
