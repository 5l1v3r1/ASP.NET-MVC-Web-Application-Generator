//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Production
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwOrderCustomer
    {
        public long OrdId { get; set; }
        public string OrdComment { get; set; }
        public Nullable<System.DateTimeOffset> OrdStartDateTime { get; set; }
        public Nullable<System.DateTimeOffset> OrdControlDateTime { get; set; }
        public Nullable<System.DateTimeOffset> OrdCloseDateTime { get; set; }
        public long CustId { get; set; }
        public string CustComment { get; set; }
        public string CustPersonComment { get; set; }
        public string CustPersonFirstName { get; set; }
        public string CustPersonSurname { get; set; }
        public string CustPersonPatronymicName { get; set; }
        public Nullable<long> CustPersonGender { get; set; }
        public Nullable<long> CustPersonMaritalStatus { get; set; }
        public Nullable<System.DateTimeOffset> CustPersonBirthDate { get; set; }
        public Nullable<long> CustPersonAmountOfChildren { get; set; }
        public string CustPersonAddressOfCurrLivingPlace { get; set; }
        public string CustPersonContactsActualAddress { get; set; }
        public string CustPersonContactsFormalAddress { get; set; }
        public string CustPersonContactsPersonalMobilePhone { get; set; }
        public string CustPersonContactsWorkMobilePhone { get; set; }
        public string CustPersonContactsHomePhone { get; set; }
        public string CustPersonContactsWorkPhone { get; set; }
        public string CustPersonContactsPersonalEMail { get; set; }
        public string CustPersonContactsWorkEMail { get; set; }
        public string CustPersonContactsMessenger1 { get; set; }
        public string CustPersonContactsMessenger2 { get; set; }
        public string CustPersonContactsMessenger3 { get; set; }
        public string CustPersonPassportInfoComment { get; set; }
        public string CustPersonPassportInfoSeries { get; set; }
        public string CustPersonPassportInfoNumber { get; set; }
        public Nullable<System.DateTimeOffset> CustPersonPassportInfoIssueDate { get; set; }
        public string CustPersonPassportInfoWhoIsIssuer { get; set; }
        public string CustPersonPassportInfoAddressOfResidence { get; set; }
        public string CustPersonPassportInfoAddressOfRegistration { get; set; }
        public Nullable<System.DateTimeOffset> CustPersonPassportInfoLastChangeDate { get; set; }
    }
}
