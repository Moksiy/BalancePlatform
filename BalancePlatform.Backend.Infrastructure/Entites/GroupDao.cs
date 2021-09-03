using System.ComponentModel.DataAnnotations;

namespace BalancePlatform.Backend.Infrastructure.Entites
{
    public class GroupDao : EntityWithIdDao<int>
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Счет группы
        /// </summary>
        public int GroupScore { get; set; }

        /// <summary>
        /// Ид одмена
        /// </summary>
        public int AdminId { get; set; }
    }
}