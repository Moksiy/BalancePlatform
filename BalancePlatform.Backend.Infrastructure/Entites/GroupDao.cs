using System.ComponentModel.DataAnnotations;

namespace BalancePlatform.Backend.Infrastructure.Entites
{
    public class GroupDao : EntityWithIdDao<int>
    {
        /// <summary>
        /// Название
        /// </summary>
        [MaxLength(256)]
        public string Name { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        [MaxLength(256)]
        public string Descr { get; set; }
    }
}