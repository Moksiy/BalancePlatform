using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancePlatform.Backend.Infrastructure.Entites
{
    /// <summary>
    /// Операции с валютой
    /// </summary>
    public class TransactionDao : EntityWithIdDao<long>
    {
        /// <summary>
        /// Ид пользователя
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Значение 
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Зачисление?
        /// </summary>
        public bool IsIncome { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Тип валюты
        /// </summary>
        public byte CurrencyTypeId { get; set; }
    }
}
