//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Common.DataAccessLayer.AppIdAndAuth
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblAuthorizationApplication
    {
        public long RoleId { get; set; }
        public long ApplicationId { get; set; }
        public bool AllowLogIn { get; set; }
    
        public virtual tblApplicationIdApplication tblApplicationIdApplication { get; set; }
        public virtual tblAuthenticationRole tblAuthenticationRole { get; set; }
    }
}
