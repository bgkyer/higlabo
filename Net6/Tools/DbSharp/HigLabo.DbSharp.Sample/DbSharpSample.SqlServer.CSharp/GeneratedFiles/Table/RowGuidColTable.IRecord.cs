﻿//Generated at 2022/01/01 08:20:25 by DbSharpApplication.
//https://github.com/higty/higlabo/tree/master/Net6/Tools/DbSharp
using System;
using System.Data;
using System.Text;
using HigLabo.DbSharp;

namespace HigLabo.DbSharpSample.SqlServer
{
    public partial class RowGuidColTable
    {
        public interface IRecord
        {
            Guid RowGuidColumn { get; set; }
            String NVarCharColumn { get; set; }
        }
    }
}
