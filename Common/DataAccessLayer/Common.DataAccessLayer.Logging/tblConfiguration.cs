//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Common.DataAccessLayer.Logging
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblConfiguration
    {
        public long Id { get; set; }
        public bool DisableSavingToFile { get; set; }
        public bool DisableSavingToWebService { get; set; }
        public bool DisableSystemMessage { get; set; }
        public bool DisableMessageForUser { get; set; }
        public bool DisableInformation { get; set; }
        public bool DisableWarning { get; set; }
        public bool DisableError { get; set; }
        public bool DisableFatalError { get; set; }
        public bool DisableDebugMessage { get; set; }
    }
}
