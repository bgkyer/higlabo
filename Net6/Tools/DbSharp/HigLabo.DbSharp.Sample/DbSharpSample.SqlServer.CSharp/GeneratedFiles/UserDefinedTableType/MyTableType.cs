﻿//Generated at 2022/01/01 08:20:25 by DbSharpApplication.
//https://github.com/higty/higlabo/tree/master/Net6/Tools/DbSharp
using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Data.SqlClient.Server;
using HigLabo.DbSharp;

namespace HigLabo.DbSharpSample.SqlServer
{
    public partial class MyTableType : UserDefinedTableType<MyTableType.Record>
    {
        public override SqlDataRecord CreateSqlDataRecord()
        {
            SqlMetaData[] metaData = new SqlMetaData[28];
            metaData[0] = new SqlMetaData("BigIntColumn", SqlDbType.BigInt);
            metaData[1] = new SqlMetaData("BinaryColumn", SqlDbType.Binary, 100);
            metaData[2] = new SqlMetaData("ImageColumn", SqlDbType.Image);
            metaData[3] = new SqlMetaData("VarBinaryColumn", SqlDbType.VarBinary, 100);
            metaData[4] = new SqlMetaData("BitColumn", SqlDbType.Bit);
            metaData[5] = new SqlMetaData("CharColumn", SqlDbType.Char, 100);
            metaData[6] = new SqlMetaData("NCharColumn", SqlDbType.NChar, 100);
            metaData[7] = new SqlMetaData("NTextColumn", SqlDbType.NText);
            metaData[8] = new SqlMetaData("NVarCharColumn", SqlDbType.NVarChar, 100);
            metaData[9] = new SqlMetaData("TextColumn", SqlDbType.Text);
            metaData[10] = new SqlMetaData("VarCharColumn", SqlDbType.VarChar, 100);
            metaData[11] = new SqlMetaData("XmlColumn", SqlDbType.Xml);
            metaData[12] = new SqlMetaData("DateTimeColumn", SqlDbType.DateTime);
            metaData[13] = new SqlMetaData("SmallDateTimeColumn", SqlDbType.SmallDateTime);
            metaData[14] = new SqlMetaData("DateColumn", SqlDbType.Date);
            metaData[15] = new SqlMetaData("TimeColumn", SqlDbType.Time);
            metaData[16] = new SqlMetaData("DateTime2Column", SqlDbType.DateTime2, 0, 7);
            metaData[17] = new SqlMetaData("DecimalColumn", SqlDbType.Decimal, 18, 0);
            metaData[18] = new SqlMetaData("MoneyColumn", SqlDbType.Money);
            metaData[19] = new SqlMetaData("SmallMoneyColumn", SqlDbType.SmallMoney);
            metaData[20] = new SqlMetaData("FloatColumn", SqlDbType.Float);
            metaData[21] = new SqlMetaData("IntColumn", SqlDbType.Int);
            metaData[22] = new SqlMetaData("RealColumn", SqlDbType.Real);
            metaData[23] = new SqlMetaData("UniqueIdentifierColumn", SqlDbType.UniqueIdentifier);
            metaData[24] = new SqlMetaData("SmallIntColumn", SqlDbType.SmallInt);
            metaData[25] = new SqlMetaData("TinyIntColumn", SqlDbType.TinyInt);
            metaData[26] = new SqlMetaData("DateTimeOffsetColumn", SqlDbType.DateTimeOffset, 0, 7);
            metaData[27] = new SqlMetaData("EnumColumn", SqlDbType.NVarChar, 20);
            return new SqlDataRecord(metaData);
        }

        public partial class Record : UserDefinedTableTypeRecord
        {
            private Int64 _BigIntColumn;
            private Byte[] _BinaryColumn;
            private Byte[] _ImageColumn;
            private Byte[] _VarBinaryColumn;
            private Boolean? _BitColumn;
            private String _CharColumn = null;
            private String _NCharColumn = null;
            private String _NTextColumn = null;
            private String _NVarCharColumn = null;
            private String _TextColumn = null;
            private String _VarCharColumn = null;
            private String _XmlColumn = null;
            private DateTime? _DateTimeColumn;
            private DateTime? _SmallDateTimeColumn;
            private DateOnly? _DateColumn;
            private TimeOnly? _TimeColumn;
            private DateTime? _DateTime2Column;
            private Decimal? _DecimalColumn;
            private Decimal? _MoneyColumn;
            private Decimal? _SmallMoneyColumn;
            private Double? _FloatColumn;
            private Int32? _IntColumn;
            private Single? _RealColumn;
            private Guid? _UniqueIdentifierColumn;
            private Int16? _SmallIntColumn;
            private Byte? _TinyIntColumn;
            private DateTimeOffset? _DateTimeOffsetColumn;
            private MyEnum? _EnumColumn;

            public Int64 BigIntColumn
            {
                get
                {
                    return _BigIntColumn;
                }
                set
                {
                    _BigIntColumn = value;
                }
            }
            public Byte[] BinaryColumn
            {
                get
                {
                    return _BinaryColumn;
                }
                set
                {
                    _BinaryColumn = value;
                }
            }
            public Byte[] ImageColumn
            {
                get
                {
                    return _ImageColumn;
                }
                set
                {
                    _ImageColumn = value;
                }
            }
            public Byte[] VarBinaryColumn
            {
                get
                {
                    return _VarBinaryColumn;
                }
                set
                {
                    _VarBinaryColumn = value;
                }
            }
            public Boolean? BitColumn
            {
                get
                {
                    return _BitColumn;
                }
                set
                {
                    _BitColumn = value;
                }
            }
            public String CharColumn
            {
                get
                {
                    return _CharColumn;
                }
                set
                {
                    _CharColumn = value;
                }
            }
            public String NCharColumn
            {
                get
                {
                    return _NCharColumn;
                }
                set
                {
                    _NCharColumn = value;
                }
            }
            public String NTextColumn
            {
                get
                {
                    return _NTextColumn;
                }
                set
                {
                    _NTextColumn = value;
                }
            }
            public String NVarCharColumn
            {
                get
                {
                    return _NVarCharColumn;
                }
                set
                {
                    _NVarCharColumn = value;
                }
            }
            public String TextColumn
            {
                get
                {
                    return _TextColumn;
                }
                set
                {
                    _TextColumn = value;
                }
            }
            public String VarCharColumn
            {
                get
                {
                    return _VarCharColumn;
                }
                set
                {
                    _VarCharColumn = value;
                }
            }
            public String XmlColumn
            {
                get
                {
                    return _XmlColumn;
                }
                set
                {
                    _XmlColumn = value;
                }
            }
            public DateTime? DateTimeColumn
            {
                get
                {
                    return _DateTimeColumn;
                }
                set
                {
                    _DateTimeColumn = value;
                }
            }
            public DateTime? SmallDateTimeColumn
            {
                get
                {
                    return _SmallDateTimeColumn;
                }
                set
                {
                    _SmallDateTimeColumn = value;
                }
            }
            public DateOnly? DateColumn
            {
                get
                {
                    return _DateColumn;
                }
                set
                {
                    _DateColumn = value;
                }
            }
            public TimeOnly? TimeColumn
            {
                get
                {
                    return _TimeColumn;
                }
                set
                {
                    _TimeColumn = value;
                }
            }
            public DateTime? DateTime2Column
            {
                get
                {
                    return _DateTime2Column;
                }
                set
                {
                    _DateTime2Column = value;
                }
            }
            public Decimal? DecimalColumn
            {
                get
                {
                    return _DecimalColumn;
                }
                set
                {
                    _DecimalColumn = value;
                }
            }
            public Decimal? MoneyColumn
            {
                get
                {
                    return _MoneyColumn;
                }
                set
                {
                    _MoneyColumn = value;
                }
            }
            public Decimal? SmallMoneyColumn
            {
                get
                {
                    return _SmallMoneyColumn;
                }
                set
                {
                    _SmallMoneyColumn = value;
                }
            }
            public Double? FloatColumn
            {
                get
                {
                    return _FloatColumn;
                }
                set
                {
                    _FloatColumn = value;
                }
            }
            public Int32? IntColumn
            {
                get
                {
                    return _IntColumn;
                }
                set
                {
                    _IntColumn = value;
                }
            }
            public Single? RealColumn
            {
                get
                {
                    return _RealColumn;
                }
                set
                {
                    _RealColumn = value;
                }
            }
            public Guid? UniqueIdentifierColumn
            {
                get
                {
                    return _UniqueIdentifierColumn;
                }
                set
                {
                    _UniqueIdentifierColumn = value;
                }
            }
            public Int16? SmallIntColumn
            {
                get
                {
                    return _SmallIntColumn;
                }
                set
                {
                    _SmallIntColumn = value;
                }
            }
            public Byte? TinyIntColumn
            {
                get
                {
                    return _TinyIntColumn;
                }
                set
                {
                    _TinyIntColumn = value;
                }
            }
            public DateTimeOffset? DateTimeOffsetColumn
            {
                get
                {
                    return _DateTimeOffsetColumn;
                }
                set
                {
                    _DateTimeOffsetColumn = value;
                }
            }
            public MyEnum? EnumColumn
            {
                get
                {
                    return _EnumColumn;
                }
                set
                {
                    _EnumColumn = value;
                }
            }

            public Record()
            {
            }

            public override Object[] GetValues()
            {
                Object[] oo = new Object[28];
                oo[0] = this.BigIntColumn;
                oo[1] = this.BinaryColumn;
                oo[2] = this.ImageColumn;
                oo[3] = this.VarBinaryColumn;
                oo[4] = this.BitColumn;
                oo[5] = this.CharColumn;
                oo[6] = this.NCharColumn;
                oo[7] = this.NTextColumn;
                oo[8] = this.NVarCharColumn;
                oo[9] = this.TextColumn;
                oo[10] = this.VarCharColumn;
                oo[11] = this.XmlColumn;
                oo[12] = this.DateTimeColumn;
                oo[13] = this.SmallDateTimeColumn;
                oo[14] = this.DateColumn?.ToDateTime(TimeOnly.MinValue);
                oo[15] = this.TimeColumn?.ToTimeSpan();
                oo[16] = this.DateTime2Column;
                oo[17] = this.DecimalColumn;
                oo[18] = this.MoneyColumn;
                oo[19] = this.SmallMoneyColumn;
                oo[20] = this.FloatColumn;
                oo[21] = this.IntColumn;
                oo[22] = this.RealColumn;
                oo[23] = this.UniqueIdentifierColumn;
                oo[24] = this.SmallIntColumn;
                oo[25] = this.TinyIntColumn;
                oo[26] = this.DateTimeOffsetColumn;
                if (this.EnumColumn != null) oo[27] = this.EnumColumn.ToString();
                return oo;
            }
        }
    }
}
