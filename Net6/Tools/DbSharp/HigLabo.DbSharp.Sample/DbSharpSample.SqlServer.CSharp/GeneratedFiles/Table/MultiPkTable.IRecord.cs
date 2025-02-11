﻿//Generated at 2022/01/01 08:20:25 by DbSharpApplication.
//https://github.com/higty/higlabo/tree/master/Net6/Tools/DbSharp
using System;
using System.Data;
using System.Text;
using HigLabo.DbSharp;

namespace HigLabo.DbSharpSample.SqlServer
{
    public partial class MultiPkTable
    {
        public interface IRecord
        {
            Int64 BigIntColumn { get; set; }
            Int32 IntColumn { get; set; }
            Double FloatColumn { get; set; }
            Byte[] BinaryColumn { get; set; }
            Byte[] TimestampColumn { get; set; }
            Byte[] VarBinaryColumn { get; set; }
            Boolean? BitColumn { get; set; }
            String NCharColumn { get; set; }
            String NTextColumn { get; set; }
            String NVarCharColumn { get; set; }
        }
    }
}
