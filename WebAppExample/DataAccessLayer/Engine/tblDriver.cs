//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppExample.DataAccessLayer.Engine
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblDriver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDriver()
        {
            this.n2mOrderDriver = new HashSet<n2mOrderDriver>();
            this.tblVehicle1 = new HashSet<tblVehicle>();
        }
    
        public long Id { get; set; }
        public string Comment { get; set; }
        public Nullable<long> BalanceAccount { get; set; }
        public Nullable<long> EmployeeId { get; set; }
        public string EmployeeComment { get; set; }
        public Nullable<long> EmployeePosition { get; set; }
        public string EmployeePersonComment { get; set; }
        public string EmployeePersonFirstName { get; set; }
        public string EmployeePersonSurname { get; set; }
        public string EmployeePersonPatronymicName { get; set; }
        public Nullable<long> EmployeePersonGender { get; set; }
        public Nullable<long> EmployeePersonMaritalStatus { get; set; }
        public Nullable<System.DateTimeOffset> EmployeePersonBirthDate { get; set; }
        public Nullable<long> EmployeePersonAmountOfChildren { get; set; }
        public string EmployeePersonAddressOfCurrLivingPlace { get; set; }
        public string EmployeePersonContactsActualAddress { get; set; }
        public string EmployeePersonContactsFormalAddress { get; set; }
        public string EmployeePersonContactsPersonalMobilePhone { get; set; }
        public string EmployeePersonContactsWorkMobilePhone { get; set; }
        public string EmployeePersonContactsHomePhone { get; set; }
        public string EmployeePersonContactsWorkPhone { get; set; }
        public string EmployeePersonContactsPersonalEMail { get; set; }
        public string EmployeePersonContactsWorkEMail { get; set; }
        public string EmployeePersonContactsMessenger1 { get; set; }
        public string EmployeePersonContactsMessenger2 { get; set; }
        public string EmployeePersonContactsMessenger3 { get; set; }
        public string EmployeePersonPassportInfoComment { get; set; }
        public string EmployeePersonPassportInfoSeries { get; set; }
        public string EmployeePersonPassportInfoNumber { get; set; }
        public Nullable<System.DateTimeOffset> EmployeePersonPassportInfoIssueDate { get; set; }
        public string EmployeePersonPassportInfoWhoIsIssuer { get; set; }
        public string EmployeePersonPassportInfoAddressOfResidence { get; set; }
        public string EmployeePersonPassportInfoAddressOfRegistration { get; set; }
        public Nullable<System.DateTimeOffset> EmployeePersonPassportInfoLastChangeDate { get; set; }
        public Nullable<long> CurrentVehicle { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<n2mOrderDriver> n2mOrderDriver { get; set; }
        public virtual tblAccount tblAccount { get; set; }
        public virtual tblVehicle tblVehicle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblVehicle> tblVehicle1 { get; set; }
    }
}
