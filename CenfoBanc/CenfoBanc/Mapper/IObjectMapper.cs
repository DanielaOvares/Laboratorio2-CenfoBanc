﻿using System;
using System.Collections.Generic;
using System.Text;
using Entidades_POJO;

namespace DataAccess.Mapper
{
    interface IObjectMapper
    
         {
        List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows);
        BaseEntity BuildObject(Dictionary<string, object> row);
    }
}
