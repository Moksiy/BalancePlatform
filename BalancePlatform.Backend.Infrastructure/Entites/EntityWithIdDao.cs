using BalancePlatform.Backend.Common.Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancePlatform.Backend.Infrastructure.Entites
{
    /// <summary>
    /// Базовый абстрактный класс для всех DAO сущностей с идентификатором
    /// </summary>
    public abstract class EntityWithIdDao<TKey> : EntityDao, IEntityWithId<TKey>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public TKey Id { get; set; }
    }
}
