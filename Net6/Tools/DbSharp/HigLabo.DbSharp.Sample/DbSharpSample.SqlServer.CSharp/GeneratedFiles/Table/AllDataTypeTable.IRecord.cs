﻿//Generated at 2022/01/01 08:20:25 by DbSharpApplication.
//https://github.com/higty/higlabo/tree/master/Net6/Tools/DbSharp
using System;
using System.Data;
using System.Text;
using HigLabo.DbSharp;

namespace HigLabo.DbSharpSample.SqlServer
{
    public partial class AllDataTypeTable
    {
        public interface IRecord
        {
            Int64 PrimaryKeyColumn { get; set; }
            Byte[] TimestampColumn { get; set; }
            Int64? BigIntColumn { get; set; }
            Byte[] BinaryColumn { get; set; }
            Byte[] ImageColumn { get; set; }
            Byte[] VarBinaryColumn { get; set; }
            Boolean? BitColumn { get; set; }
            String CharColumn { get; set; }
            String NCharColumn { get; set; }
            String NTextColumn { get; set; }
            String NVarCharColumn { get; set; }
            String TextColumn { get; set; }
            String VarCharColumn { get; set; }
            String XmlColumn { get; set; }
            DateTime? DateTimeColumn { get; set; }
            DateTime? SmallDateTimeColumn { get; set; }
            DateOnly? DateColumn { get; set; }
            TimeOnly? TimeColumn { get; set; }
            DateTime? DateTime2Column { get; set; }
            Decimal? DecimalColumn { get; set; }
            Decimal? MoneyColumn { get; set; }
            Decimal? SmallMoneyColumn { get; set; }
            Double? FloatColumn { get; set; }
            Int32? IntColumn { get; set; }
            Single? RealColumn { get; set; }
            Guid? UniqueIdentifierColumn { get; set; }
            Int16? SmallIntColumn { get; set; }
            Byte? TinyIntColumn { get; set; }
            DateTimeOffset? DateTimeOffsetColumn { get; set; }
            Object SqlVariantColumn { get; set; }
            MyEnum? EnumColumn { get; set; }
            Int64 NotNullBigIntColumn { get; set; }
            Byte[] NotNullBinaryColumn { get; set; }
            Byte[] NotNullImageColumn { get; set; }
            Byte[] NotNullVarBinaryColumn { get; set; }
            Boolean NotNullBitColumn { get; set; }
            String NotNullCharColumn { get; set; }
            String NotNullNCharColumn { get; set; }
            String NotNullNTextColumn { get; set; }
            String NotNullNVarCharColumn { get; set; }
            String NotNullTextColumn { get; set; }
            String NotNullVarCharColumn { get; set; }
            String NotNullXmlColumn { get; set; }
            DateTime NotNullDateTimeColumn { get; set; }
            DateTime NotNullSmallDateTimeColumn { get; set; }
            DateOnly NotNullDateColumn { get; set; }
            TimeOnly NotNullTimeColumn { get; set; }
            DateTime NotNullDateTime2Column { get; set; }
            Decimal NotNullDecimalColumn { get; set; }
            Decimal NotNullMoneyColumn { get; set; }
            Decimal NotNullSmallMoneyColumn { get; set; }
            Double NotNullFloatColumn { get; set; }
            Int32 NotNullIntColumn { get; set; }
            Single NotNullRealColumn { get; set; }
            Guid NotNullUniqueIdentifierColumn { get; set; }
            Int16 NotNullSmallIntColumn { get; set; }
            Byte NotNullTinyIntColumn { get; set; }
            DateTimeOffset NotNullDateTimeOffsetColumn { get; set; }
            Object NotNullSqlVariantColumn { get; set; }
            MyEnum NotNullEnumColumn { get; set; }
        }
    }
}
