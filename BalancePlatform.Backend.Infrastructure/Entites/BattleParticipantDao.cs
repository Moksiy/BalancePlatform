
namespace BalancePlatform.Backend.Infrastructure.Entites
{
    /// <summary>
    /// Участники вызова
    /// </summary>
    public class BattleParticipantDao : EntityWithIdDao<int>
    {
        /// <summary>
        /// Вызов
        /// </summary>
        public BadgeDao Badge { get; set; }
        
        /// <summary>
        /// Группа 1 (атакует)
        /// </summary>
        public int AttackGroupId { get; set; }

        /// <summary>
        /// Группа 2 (защищается)
        /// </summary>
        public GroupDao AttackGroup { get; set; }

        /// <summary>
        /// Группа 2 (защищается)
        /// </summary>
        public int DefenseGroupId { get; set; }

        /// <summary>
        /// Группа 2 (защищается)
        /// </summary>
        public GroupDao DefenseGroup { get; set; }
        
    }
}
