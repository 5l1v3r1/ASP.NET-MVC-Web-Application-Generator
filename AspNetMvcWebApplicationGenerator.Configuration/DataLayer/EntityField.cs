﻿namespace AspNetMvcWebApplicationGenerator.Configuration.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EntityField
    {
        public EntityFieldType FieldType { get; }
        public String Name { get; }
        public int? StringLengthMin { get; }
        public int StringLengthMax { get; }
        public String ValidationRegExp { get; }
        public Boolean ValidationCheckExistance { get; }

        #region link to other tables or virtual parts properties   
            public LinkType LinkType { get; }
            public String LinkedEntityName { get; }
        #endregion

        #region grid column configuration 
            public int     GridColumnWidth { get; }
            public Boolean GridColumnIsSortingAllowed { get; }
        #endregion

        #region field filter configuration 
            public Boolean FieldFilterIsRequired { get; }
            public Boolean FieldFilterIsMinRequired { get; }
        #endregion

        public EntityField
        (
            EntityFieldType fieldType, 
            String name,
            int?     stringLengthMin = null, 
            int      stringLengthMax = 32,
            String   validationRegExp = null,
            Boolean  validationCheckExistance = false,
            LinkType linkType = LinkType.NoLink,
            String   linkedEntityName = "",
            int      gridColumnWidth = 100, 
            Boolean  gridColumnIsSortingAllowed = false,
            Boolean  fieldFilterIsRequired = false,
            Boolean  fieldFilterIsMinRequired = false
        )
        {
            FieldType = fieldType;
            Name = Name;
            StringLengthMin = stringLengthMin;
            StringLengthMax = stringLengthMax;
            ValidationRegExp = validationRegExp;
            ValidationCheckExistance = validationCheckExistance;
            LinkType = linkType;
            LinkedEntityName = linkedEntityName;
            GridColumnWidth = gridColumnWidth;
            GridColumnIsSortingAllowed = gridColumnIsSortingAllowed;
            FieldFilterIsRequired = fieldFilterIsRequired;
            FieldFilterIsMinRequired = fieldFilterIsMinRequired;
        }
    }
}
