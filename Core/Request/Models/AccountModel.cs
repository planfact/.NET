using System;

namespace Request.Models
{
    /// <summary>
    /// Модель счёта, для ответа
    /// </summary>
    public class AccountModel
    {
        /// <summary>
        /// Id юрлица
        /// </summary>
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
        /// Код валюты см. https://apidoc.planfact.io/
        /// </summary>
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Полное название счёта
        /// </summary>
        public string LongTitle { get; set; }
        /// <summary>
        /// Комментарий
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Номер счёта. Только безнал
        /// </summary>
        public string AccountAcct { get; set; }
        /// <summary>
        /// БИК. Только безнал
        /// </summary>
        public string AccountBik { get; set; }
        /// <summary>
        /// Банк. Только безнал
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
        /// Id банка, с которым интегрируется счет
        /// </summary>
        public int? BankImportIntegrationTokenBankId { get; set; }
       

        /// <summary>
        /// Дата последнего изменения
        /// </summary>
        public DateTime ModifyDate { get; set; }

        /// <summary>
        /// Дата создания счёта
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// Статус последнего действия
        /// </summary>
        public string ActionStatus { get; set; }

        /// <summary>
        /// Признак служебного счёта
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