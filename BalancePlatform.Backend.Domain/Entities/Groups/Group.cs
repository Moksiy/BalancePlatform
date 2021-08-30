﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using BalancePlatform.Backend.Common.Base.Entities;

namespace BalancePlatform.Backend.Domain.Entities.Groups
{
    /// <summary>
    /// Роль пользователь
    /// </summary>
    [DataContract]
    [Serializable]
    public class Group : IEntityWithId<int>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Display(Name = "Id")]
        [DataMember]
        public int Id { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        [Display(Name = "Наименование")]
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        [Display(Name = "Описание")]
        [DataMember]
        public string Descr { get; set; }
        /// <summary>
        /// Общий счет
        /// </summary>
        [Display(Name = "Общий счет")]
        [DataMember]
        public int TotalScore { get; set; }


    }
}