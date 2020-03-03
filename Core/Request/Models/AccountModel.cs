using System;

namespace Request.Models
{
    public class AccountModel
    {
        public int CompanyId { get; set; }
        /// <summary>
        /// Тип счёта
        /// </summary>
        public string AccountType { get; set; }
        /// <summary>
        /// Название типа счета
        /// </summary>
        public string AccountTypeTitle { get; set; }
        /// <summary>
        /// Код валюты
        /// </summary>
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Полное название
        /// </summary>
        public string LongTitle { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Номер
        /// </summary>
        public string AccountAcct { get; set; }
        /// <summary>
        /// БИК
        /// </summary>
        public string AccountBik { get; set; }
        /// <summary>
        /// Банк
        /// </summary>
        public string AccountBank { get; set; }
        /// <summary>
        /// Название валюты
        /// </summary>
        public string CurrencyTitle { get; set; }
        /// <summary>
        /// Активность счета
        /// </summary>
        public bool? Active { get; set; }
        /// <summary>
        /// Текущий остаток на счету
        /// </summary>
        public double Remainder { get; set; }
        /// <summary>
        /// Индентификатор операции остатка по счету
        /// </summary>
        public int? RemainderOperationId { get; set; }
        /// <summary>
        /// Id токена интеграции с банком
        /// </summary>
        public int? BankImportIntegrationTokenId { get; set; }
        /// <summary>
        /// Id банка с которым интегрируется счет
        /// </summary>
        public int? BankImportIntegrationTokenBankId { get; set; }
       

        /// <summary>
        /// Дата последней модификации
        /// </summary>
        public DateTime ModifyDate { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// Статус последнего действия
        /// </summary>
        public string ActionStatus { get; set; }

        /// <summary>
        /// Признак служебного
        /// </summary>
        public bool IsUndistributed { get; set; }

        /// <summary>
        /// Дата начального остатка
        /// </summary>
        public DateTime? StartingRemainderDate { get; set; }
        /// <summary>
        /// Значение начального остатка
        /// </summary>
        public decimal? StartingRemainderValue { get; set; }
        /// <summary>
        /// Значение начального остатка в валюте пользователя
        /// </summary>
        public decimal? StartingRemainderValueInUserCurrency { get; set; }
        /// <summary>
        /// Корреспондентский номер счета
        /// </summary>
        public string CorrespondentAcct { get; set; }
    }
}