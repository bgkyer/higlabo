﻿//Generated at 2022/01/01 11:52:05 by DbSharpApplication.
//https://github.com/higty/higlabo/tree/master/Net6/Tools/DbSharp
using System;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using HigLabo.Core;
using HigLabo.Data;
using HigLabo.DbSharp;
using MySql.Data.Types;
using MySql.Data.MySqlClient;

namespace HigLabo.DbSharpSample.MySql
{
    public partial class alldatatypetableSelectAll : StoredProcedureWithResultSet<alldatatypetableSelectAll.ResultSet>
    {
        public const String Name = "alldatatypetableSelectAll";

        public String DatabaseKey
        {
            get
            {
                return ((IDatabaseContext)this).DatabaseKey;
            }
            set
            {
                ((IDatabaseContext)this).DatabaseKey = value;
            }
        }

        public alldatatypetableSelectAll()
        {
            ((IDatabaseContext)this).DatabaseKey = "DbSharpSample_MySql";
            ConstructorExecuted();
        }

        public override String GetStoredProcedureName()
        {
            return alldatatypetableSelectAll.Name;
        }
        partial void ConstructorExecuted();
        public override DbCommand CreateCommand(Database database)
        {
            var db = database;
            var cm = db.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = this.GetStoredProcedureName();
            return cm;
        }
        protected override void SetOutputParameterValue(DbCommand command)
        {
        }
        public override alldatatypetableSelectAll.ResultSet CreateResultSet()
        {
            return new ResultSet(this);
        }
        protected override void SetResultSet(alldatatypetableSelectAll.ResultSet resultSet, IDataReader reader)
        {
            var r = resultSet;
            Int32 index = -1;
            try
            {
                index += 1; r.PrimaryKeyColumn = reader.GetInt64(index);
                index += 1; r.TimestampColumn = reader.GetDateTime(index);
                index += 1; if (reader[index] != DBNull.Value) r.CharColumn = reader[index] as String;
                index += 1; if (reader[index] != DBNull.Value) r.VarCharColumn = reader[index] as String;
                index += 1; if (reader[index] != DBNull.Value) r.BitColumn = ((UInt64)reader[index] != 0);
                index += 1; if (reader[index] != DBNull.Value) r.TinyIntColumn = (SByte)reader[index];
                index += 1; if (reader[index] != DBNull.Value) r.SmallIntColumn = reader.GetInt16(index);
                index += 1; if (reader[index] != DBNull.Value) r.MediumIntColumn = reader.GetInt32(index);
                index += 1; if (reader[index] != DBNull.Value) r.IntColumn = reader.GetInt32(index);
                index += 1; if (reader[index] != DBNull.Value) r.BigIntColumn = reader.GetInt64(index);
                index += 1; if (reader[index] != DBNull.Value) r.TinyIntUnsignedColumn = reader.GetByte(index);
                index += 1; if (reader[index] != DBNull.Value) r.SmallIntUnsignedColumn = (UInt16)reader[index];
                index += 1; if (reader[index] != DBNull.Value) r.MediumIntUnsignedColumn = (UInt32)reader[index];
                index += 1; if (reader[index] != DBNull.Value) r.IntUnsignedColumn = (UInt32)reader[index];
                index += 1; if (reader[index] != DBNull.Value) r.BigIntUnsignedColumn = (UInt64)reader[index];
                index += 1; if (reader[index] != DBNull.Value) r.FloatColumn = reader.GetFloat(index);
                index += 1; if (reader[index] != DBNull.Value) r.DoubleColumn = reader.GetDouble(index);
                index += 1; if (reader[index] != DBNull.Value) r.DecimalColumn = reader.GetDecimal(index);
                index += 1; if (reader[index] != DBNull.Value) r.NumericColumn = reader.GetDecimal(index);
                index += 1; if (reader[index] != DBNull.Value) r.DateColumn = reader.GetDateTime(index);
                index += 1; if (reader[index] != DBNull.Value) r.DateTimeColumn = reader.GetDateTime(index);
                index += 1; if (reader[index] != DBNull.Value) r.TimeColumn =  (TimeSpan)reader[index];
                index += 1; if (reader[index] != DBNull.Value) r.YearColumn = reader.GetInt32(index);
                index += 1; if (reader[index] != DBNull.Value) r.BinaryColumn = reader[index] as Byte[];
                index += 1; if (reader[index] != DBNull.Value) r.VarBinaryColumn = reader[index] as Byte[];
                index += 1; if (reader[index] != DBNull.Value) r.TinyBlobColumn = reader[index] as Byte[];
                index += 1; if (reader[index] != DBNull.Value) r.MediumBlobColumn = reader[index] as Byte[];
                index += 1; if (reader[index] != DBNull.Value) r.BlobColumn = reader[index] as Byte[];
                index += 1; if (reader[index] != DBNull.Value) r.LongBlobColumn = reader[index] as Byte[];
                index += 1; if (reader[index] != DBNull.Value) r.TinyTextColumn = reader[index] as String;
                index += 1; if (reader[index] != DBNull.Value) r.MediumTextColumn = reader[index] as String;
                index += 1; if (reader[index] != DBNull.Value) r.TextColumn = reader[index] as String;
                index += 1; if (reader[index] != DBNull.Value) r.LongTextColumn = reader[index] as String;
                index += 1; if (reader[index] != DBNull.Value) r.GeometryColumn = ((MySqlDataReader)reader).GetMySqlGeometry(index);
                index += 1; if (reader[index] != DBNull.Value) r.EnumColumn = StoredProcedure.ToEnum<MyEnum>(reader[index] as String) ?? r.EnumColumn;
                index += 1; if (reader[index] != DBNull.Value) r.SetColumn = StoredProcedure.ToEnum<MySet>(reader[index] as String) ?? r.SetColumn;
                index += 1; r.NotNullCharColumn = reader[index] as String;
                index += 1; r.NotNullVarCharColumn = reader[index] as String;
                index += 1; r.NotNullBitColumn = ((UInt64)reader[index] != 0);
                index += 1; r.NotNullTinyIntColumn = (SByte)reader[index];
                index += 1; r.NotNullSmallIntColumn = reader.GetInt16(index);
                index += 1; r.NotNullMediumIntColumn = reader.GetInt32(index);
                index += 1; r.NotNullIntColumn = reader.GetInt32(index);
                index += 1; r.NotNullBigIntColumn = reader.GetInt64(index);
                index += 1; r.NotNullTinyIntUnsignedColumn = reader.GetByte(index);
                index += 1; r.NotNullSmallIntUnsignedColumn = (UInt16)reader[index];
                index += 1; r.NotNullMediumIntUnsignedColumn = (UInt32)reader[index];
                index += 1; r.NotNullIntUnsignedColumn = (UInt32)reader[index];
                index += 1; r.NotNullBigIntUnsignedColumn = (UInt64)reader[index];
                index += 1; r.NotNullFloatColumn = reader.GetFloat(index);
                index += 1; r.NotNullDoubleColumn = reader.GetDouble(index);
                index += 1; r.NotNullDecimalColumn = reader.GetDecimal(index);
                index += 1; r.NotNullNumericColumn = reader.GetDecimal(index);
                index += 1; r.NotNullDateColumn = reader.GetDateTime(index);
                index += 1; r.NotNullDateTimeColumn = reader.GetDateTime(index);
                index += 1; r.NotNullTimeColumn =  (TimeSpan)reader[index];
                index += 1; r.NotNullYearColumn = reader.GetInt32(index);
                index += 1; r.NotNullBinaryColumn = reader[index] as Byte[];
                index += 1; r.NotNullVarBinaryColumn = reader[index] as Byte[];
                index += 1; r.NotNullTinyBlobColumn = reader[index] as Byte[];
                index += 1; r.NotNullTinyTextColumn = reader[index] as String;
                index += 1; r.NotNullBlobColumn = reader[index] as Byte[];
                index += 1; r.NotNullTextColumn = reader[index] as String;
                index += 1; r.NotNullMediumBlobColumn = reader[index] as Byte[];
                index += 1; r.NotNullMediumTextColumn = reader[index] as String;
                index += 1; r.NotNullLongBlobColumn = reader[index] as Byte[];
                index += 1; r.NotNullLongTextColumn = reader[index] as String;
                index += 1; r.NotNullGeometryColumn = ((MySqlDataReader)reader).GetMySqlGeometry(index);
                index += 1; r.NotNullEnumColumn = StoredProcedure.ToEnum<MyEnum>(reader[index] as String) ?? r.NotNullEnumColumn;
                index += 1; r.NotNullSetColumn = StoredProcedure.ToEnum<MySet>(reader[index] as String) ?? r.NotNullSetColumn;
            }
            catch (Exception ex)
            {
                throw new StoredProcedureSchemaMismatchedException(this, index, ex);
            }
        }
        public override String ToString()
        {
            var sb = new StringBuilder(32);
            sb.AppendLine("<alldatatypetableSelectAll>");
            return sb.ToString();
        }

        public partial class ResultSet : StoredProcedureResultSet, alldatatypetable.IRecord
        {
            private Int64 _PrimaryKeyColumn;
            private DateTime _TimestampColumn;
            private String _CharColumn = null;
            private String _VarCharColumn = null;
            private Boolean? _BitColumn;
            private SByte? _TinyIntColumn;
            private Int16? _SmallIntColumn;
            private Int32? _MediumIntColumn;
            private Int32? _IntColumn;
            private Int64? _BigIntColumn;
            private Byte? _TinyIntUnsignedColumn;
            private UInt16? _SmallIntUnsignedColumn;
            private UInt32? _MediumIntUnsignedColumn;
            private UInt32? _IntUnsignedColumn;
            private UInt64? _BigIntUnsignedColumn;
            private Single? _FloatColumn;
            private Double? _DoubleColumn;
            private Decimal? _DecimalColumn;
            private Decimal? _NumericColumn;
            private DateTime? _DateColumn;
            private DateTime? _DateTimeColumn;
            private TimeSpan? _TimeColumn;
            private Int32? _YearColumn;
            private Byte[] _BinaryColumn;
            private Byte[] _VarBinaryColumn;
            private Byte[] _TinyBlobColumn;
            private Byte[] _MediumBlobColumn;
            private Byte[] _BlobColumn;
            private Byte[] _LongBlobColumn;
            private String _TinyTextColumn = null;
            private String _MediumTextColumn = null;
            private String _TextColumn = null;
            private String _LongTextColumn = null;
            private global::MySql.Data.Types.MySqlGeometry? _GeometryColumn;
            private MyEnum? _EnumColumn;
            private MySet? _SetColumn;
            private String _NotNullCharColumn = "";
            private String _NotNullVarCharColumn = "";
            private Boolean _NotNullBitColumn;
            private SByte _NotNullTinyIntColumn;
            private Int16 _NotNullSmallIntColumn;
            private Int32 _NotNullMediumIntColumn;
            private Int32 _NotNullIntColumn;
            private Int64 _NotNullBigIntColumn;
            private Byte _NotNullTinyIntUnsignedColumn;
            private UInt16 _NotNullSmallIntUnsignedColumn;
            private UInt32 _NotNullMediumIntUnsignedColumn;
            private UInt32 _NotNullIntUnsignedColumn;
            private UInt64 _NotNullBigIntUnsignedColumn;
            private Single _NotNullFloatColumn;
            private Double _NotNullDoubleColumn;
            private Decimal _NotNullDecimalColumn;
            private Decimal _NotNullNumericColumn;
            private DateTime _NotNullDateColumn;
            private DateTime _NotNullDateTimeColumn;
            private TimeSpan _NotNullTimeColumn;
            private Int32 _NotNullYearColumn;
            private Byte[] _NotNullBinaryColumn;
            private Byte[] _NotNullVarBinaryColumn;
            private Byte[] _NotNullTinyBlobColumn;
            private String _NotNullTinyTextColumn = "";
            private Byte[] _NotNullBlobColumn;
            private String _NotNullTextColumn = "";
            private Byte[] _NotNullMediumBlobColumn;
            private String _NotNullMediumTextColumn = "";
            private Byte[] _NotNullLongBlobColumn;
            private String _NotNullLongTextColumn = "";
            private global::MySql.Data.Types.MySqlGeometry _NotNullGeometryColumn;
            private MyEnum _NotNullEnumColumn;
            private MySet _NotNullSetColumn;

            public Int64 PrimaryKeyColumn
            {
                get
                {
                    return _PrimaryKeyColumn;
                }
                set
                {
                    _PrimaryKeyColumn = value;
                }
            }
            public DateTime TimestampColumn
            {
                get
                {
                    return _TimestampColumn;
                }
                set
                {
                    _TimestampColumn = value;
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
            public SByte? TinyIntColumn
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
            public Int32? MediumIntColumn
            {
                get
                {
                    return _MediumIntColumn;
                }
                set
                {
                    _MediumIntColumn = value;
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
            public Int64? BigIntColumn
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
            public Byte? TinyIntUnsignedColumn
            {
                get
                {
                    return _TinyIntUnsignedColumn;
                }
                set
                {
                    _TinyIntUnsignedColumn = value;
                }
            }
            public UInt16? SmallIntUnsignedColumn
            {
                get
                {
                    return _SmallIntUnsignedColumn;
                }
                set
                {
                    _SmallIntUnsignedColumn = value;
                }
            }
            public UInt32? MediumIntUnsignedColumn
            {
                get
                {
                    return _MediumIntUnsignedColumn;
                }
                set
                {
                    _MediumIntUnsignedColumn = value;
                }
            }
            public UInt32? IntUnsignedColumn
            {
                get
                {
                    return _IntUnsignedColumn;
                }
                set
                {
                    _IntUnsignedColumn = value;
                }
            }
            public UInt64? BigIntUnsignedColumn
            {
                get
                {
                    return _BigIntUnsignedColumn;
                }
                set
                {
                    _BigIntUnsignedColumn = value;
                }
            }
            public Single? FloatColumn
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
            public Double? DoubleColumn
            {
                get
                {
                    return _DoubleColumn;
                }
                set
                {
                    _DoubleColumn = value;
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
            public Decimal? NumericColumn
            {
                get
                {
                    return _NumericColumn;
                }
                set
                {
                    _NumericColumn = value;
                }
            }
            public DateTime? DateColumn
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
            public TimeSpan? TimeColumn
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
            public Int32? YearColumn
            {
                get
                {
                    return _YearColumn;
                }
                set
                {
                    _YearColumn = value;
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
            public Byte[] TinyBlobColumn
            {
                get
                {
                    return _TinyBlobColumn;
                }
                set
                {
                    _TinyBlobColumn = value;
                }
            }
            public Byte[] MediumBlobColumn
            {
                get
                {
                    return _MediumBlobColumn;
                }
                set
                {
                    _MediumBlobColumn = value;
                }
            }
            public Byte[] BlobColumn
            {
                get
                {
                    return _BlobColumn;
                }
                set
                {
                    _BlobColumn = value;
                }
            }
            public Byte[] LongBlobColumn
            {
                get
                {
                    return _LongBlobColumn;
                }
                set
                {
                    _LongBlobColumn = value;
                }
            }
            public String TinyTextColumn
            {
                get
                {
                    return _TinyTextColumn;
                }
                set
                {
                    _TinyTextColumn = value;
                }
            }
            public String MediumTextColumn
            {
                get
                {
                    return _MediumTextColumn;
                }
                set
                {
                    _MediumTextColumn = value;
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
            public String LongTextColumn
            {
                get
                {
                    return _LongTextColumn;
                }
                set
                {
                    _LongTextColumn = value;
                }
            }
            public global::MySql.Data.Types.MySqlGeometry? GeometryColumn
            {
                get
                {
                    return _GeometryColumn;
                }
                set
                {
                    _GeometryColumn = value;
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
            public MySet? SetColumn
            {
                get
                {
                    return _SetColumn;
                }
                set
                {
                    _SetColumn = value;
                }
            }
            public String NotNullCharColumn
            {
                get
                {
                    return _NotNullCharColumn;
                }
                set
                {
                    _NotNullCharColumn = value ?? "";
                }
            }
            public String NotNullVarCharColumn
            {
                get
                {
                    return _NotNullVarCharColumn;
                }
                set
                {
                    _NotNullVarCharColumn = value ?? "";
                }
            }
            public Boolean NotNullBitColumn
            {
                get
                {
                    return _NotNullBitColumn;
                }
                set
                {
                    _NotNullBitColumn = value;
                }
            }
            public SByte NotNullTinyIntColumn
            {
                get
                {
                    return _NotNullTinyIntColumn;
                }
                set
                {
                    _NotNullTinyIntColumn = value;
                }
            }
            public Int16 NotNullSmallIntColumn
            {
                get
                {
                    return _NotNullSmallIntColumn;
                }
                set
                {
                    _NotNullSmallIntColumn = value;
                }
            }
            public Int32 NotNullMediumIntColumn
            {
                get
                {
                    return _NotNullMediumIntColumn;
                }
                set
                {
                    _NotNullMediumIntColumn = value;
                }
            }
            public Int32 NotNullIntColumn
            {
                get
                {
                    return _NotNullIntColumn;
                }
                set
                {
                    _NotNullIntColumn = value;
                }
            }
            public Int64 NotNullBigIntColumn
            {
                get
                {
                    return _NotNullBigIntColumn;
                }
                set
                {
                    _NotNullBigIntColumn = value;
                }
            }
            public Byte NotNullTinyIntUnsignedColumn
            {
                get
                {
                    return _NotNullTinyIntUnsignedColumn;
                }
                set
                {
                    _NotNullTinyIntUnsignedColumn = value;
                }
            }
            public UInt16 NotNullSmallIntUnsignedColumn
            {
                get
                {
                    return _NotNullSmallIntUnsignedColumn;
                }
                set
                {
                    _NotNullSmallIntUnsignedColumn = value;
                }
            }
            public UInt32 NotNullMediumIntUnsignedColumn
            {
                get
                {
                    return _NotNullMediumIntUnsignedColumn;
                }
                set
                {
                    _NotNullMediumIntUnsignedColumn = value;
                }
            }
            public UInt32 NotNullIntUnsignedColumn
            {
                get
                {
                    return _NotNullIntUnsignedColumn;
                }
                set
                {
                    _NotNullIntUnsignedColumn = value;
                }
            }
            public UInt64 NotNullBigIntUnsignedColumn
            {
                get
                {
                    return _NotNullBigIntUnsignedColumn;
                }
                set
                {
                    _NotNullBigIntUnsignedColumn = value;
                }
            }
            public Single NotNullFloatColumn
            {
                get
                {
                    return _NotNullFloatColumn;
                }
                set
                {
                    _NotNullFloatColumn = value;
                }
            }
            public Double NotNullDoubleColumn
            {
                get
                {
                    return _NotNullDoubleColumn;
                }
                set
                {
                    _NotNullDoubleColumn = value;
                }
            }
            public Decimal NotNullDecimalColumn
            {
                get
                {
                    return _NotNullDecimalColumn;
                }
                set
                {
                    _NotNullDecimalColumn = value;
                }
            }
            public Decimal NotNullNumericColumn
            {
                get
                {
                    return _NotNullNumericColumn;
                }
                set
                {
                    _NotNullNumericColumn = value;
                }
            }
            public DateTime NotNullDateColumn
            {
                get
                {
                    return _NotNullDateColumn;
                }
                set
                {
                    _NotNullDateColumn = value;
                }
            }
            public DateTime NotNullDateTimeColumn
            {
                get
                {
                    return _NotNullDateTimeColumn;
                }
                set
                {
                    _NotNullDateTimeColumn = value;
                }
            }
            public TimeSpan NotNullTimeColumn
            {
                get
                {
                    return _NotNullTimeColumn;
                }
                set
                {
                    _NotNullTimeColumn = value;
                }
            }
            public Int32 NotNullYearColumn
            {
                get
                {
                    return _NotNullYearColumn;
                }
                set
                {
                    _NotNullYearColumn = value;
                }
            }
            public Byte[] NotNullBinaryColumn
            {
                get
                {
                    return _NotNullBinaryColumn;
                }
                set
                {
                    _NotNullBinaryColumn = value;
                }
            }
            public Byte[] NotNullVarBinaryColumn
            {
                get
                {
                    return _NotNullVarBinaryColumn;
                }
                set
                {
                    _NotNullVarBinaryColumn = value;
                }
            }
            public Byte[] NotNullTinyBlobColumn
            {
                get
                {
                    return _NotNullTinyBlobColumn;
                }
                set
                {
                    _NotNullTinyBlobColumn = value;
                }
            }
            public String NotNullTinyTextColumn
            {
                get
                {
                    return _NotNullTinyTextColumn;
                }
                set
                {
                    _NotNullTinyTextColumn = value ?? "";
                }
            }
            public Byte[] NotNullBlobColumn
            {
                get
                {
                    return _NotNullBlobColumn;
                }
                set
                {
                    _NotNullBlobColumn = value;
                }
            }
            public String NotNullTextColumn
            {
                get
                {
                    return _NotNullTextColumn;
                }
                set
                {
                    _NotNullTextColumn = value ?? "";
                }
            }
            public Byte[] NotNullMediumBlobColumn
            {
                get
                {
                    return _NotNullMediumBlobColumn;
                }
                set
                {
                    _NotNullMediumBlobColumn = value;
                }
            }
            public String NotNullMediumTextColumn
            {
                get
                {
                    return _NotNullMediumTextColumn;
                }
                set
                {
                    _NotNullMediumTextColumn = value ?? "";
                }
            }
            public Byte[] NotNullLongBlobColumn
            {
                get
                {
                    return _NotNullLongBlobColumn;
                }
                set
                {
                    _NotNullLongBlobColumn = value;
                }
            }
            public String NotNullLongTextColumn
            {
                get
                {
                    return _NotNullLongTextColumn;
                }
                set
                {
                    _NotNullLongTextColumn = value ?? "";
                }
            }
            public global::MySql.Data.Types.MySqlGeometry NotNullGeometryColumn
            {
                get
                {
                    return _NotNullGeometryColumn;
                }
                set
                {
                    _NotNullGeometryColumn = value;
                }
            }
            public MyEnum NotNullEnumColumn
            {
                get
                {
                    return _NotNullEnumColumn;
                }
                set
                {
                    _NotNullEnumColumn = value;
                }
            }
            public MySet NotNullSetColumn
            {
                get
                {
                    return _NotNullSetColumn;
                }
                set
                {
                    _NotNullSetColumn = value;
                }
            }

            public ResultSet()
            {
            }
            public ResultSet(alldatatypetable.IRecord resultSet)
            {
                var r = resultSet;
                PrimaryKeyColumn = r.PrimaryKeyColumn;
                TimestampColumn = r.TimestampColumn;
                CharColumn = r.CharColumn;
                VarCharColumn = r.VarCharColumn;
                BitColumn = r.BitColumn;
                TinyIntColumn = r.TinyIntColumn;
                SmallIntColumn = r.SmallIntColumn;
                MediumIntColumn = r.MediumIntColumn;
                IntColumn = r.IntColumn;
                BigIntColumn = r.BigIntColumn;
                TinyIntUnsignedColumn = r.TinyIntUnsignedColumn;
                SmallIntUnsignedColumn = r.SmallIntUnsignedColumn;
                MediumIntUnsignedColumn = r.MediumIntUnsignedColumn;
                IntUnsignedColumn = r.IntUnsignedColumn;
                BigIntUnsignedColumn = r.BigIntUnsignedColumn;
                FloatColumn = r.FloatColumn;
                DoubleColumn = r.DoubleColumn;
                DecimalColumn = r.DecimalColumn;
                NumericColumn = r.NumericColumn;
                DateColumn = r.DateColumn;
                DateTimeColumn = r.DateTimeColumn;
                TimeColumn = r.TimeColumn;
                YearColumn = r.YearColumn;
                BinaryColumn = r.BinaryColumn;
                VarBinaryColumn = r.VarBinaryColumn;
                TinyBlobColumn = r.TinyBlobColumn;
                MediumBlobColumn = r.MediumBlobColumn;
                BlobColumn = r.BlobColumn;
                LongBlobColumn = r.LongBlobColumn;
                TinyTextColumn = r.TinyTextColumn;
                MediumTextColumn = r.MediumTextColumn;
                TextColumn = r.TextColumn;
                LongTextColumn = r.LongTextColumn;
                GeometryColumn = r.GeometryColumn;
                EnumColumn = r.EnumColumn;
                SetColumn = r.SetColumn;
                NotNullCharColumn = r.NotNullCharColumn;
                NotNullVarCharColumn = r.NotNullVarCharColumn;
                NotNullBitColumn = r.NotNullBitColumn;
                NotNullTinyIntColumn = r.NotNullTinyIntColumn;
                NotNullSmallIntColumn = r.NotNullSmallIntColumn;
                NotNullMediumIntColumn = r.NotNullMediumIntColumn;
                NotNullIntColumn = r.NotNullIntColumn;
                NotNullBigIntColumn = r.NotNullBigIntColumn;
                NotNullTinyIntUnsignedColumn = r.NotNullTinyIntUnsignedColumn;
                NotNullSmallIntUnsignedColumn = r.NotNullSmallIntUnsignedColumn;
                NotNullMediumIntUnsignedColumn = r.NotNullMediumIntUnsignedColumn;
                NotNullIntUnsignedColumn = r.NotNullIntUnsignedColumn;
                NotNullBigIntUnsignedColumn = r.NotNullBigIntUnsignedColumn;
                NotNullFloatColumn = r.NotNullFloatColumn;
                NotNullDoubleColumn = r.NotNullDoubleColumn;
                NotNullDecimalColumn = r.NotNullDecimalColumn;
                NotNullNumericColumn = r.NotNullNumericColumn;
                NotNullDateColumn = r.NotNullDateColumn;
                NotNullDateTimeColumn = r.NotNullDateTimeColumn;
                NotNullTimeColumn = r.NotNullTimeColumn;
                NotNullYearColumn = r.NotNullYearColumn;
                NotNullBinaryColumn = r.NotNullBinaryColumn;
                NotNullVarBinaryColumn = r.NotNullVarBinaryColumn;
                NotNullTinyBlobColumn = r.NotNullTinyBlobColumn;
                NotNullTinyTextColumn = r.NotNullTinyTextColumn;
                NotNullBlobColumn = r.NotNullBlobColumn;
                NotNullTextColumn = r.NotNullTextColumn;
                NotNullMediumBlobColumn = r.NotNullMediumBlobColumn;
                NotNullMediumTextColumn = r.NotNullMediumTextColumn;
                NotNullLongBlobColumn = r.NotNullLongBlobColumn;
                NotNullLongTextColumn = r.NotNullLongTextColumn;
                NotNullGeometryColumn = r.NotNullGeometryColumn;
                NotNullEnumColumn = r.NotNullEnumColumn;
                NotNullSetColumn = r.NotNullSetColumn;
            }
            internal ResultSet(alldatatypetableSelectAll storedProcedure)
            {
                this._StoredProcedureResultSet_StoredProcedure = storedProcedure;
            }

            public override String ToString()
            {
                var sb = new StringBuilder(64);
                sb.AppendLine("<alldatatypetableSelectAll.ResultSet>");
                sb.AppendFormat("PrimaryKeyColumn={0}", this.PrimaryKeyColumn); sb.AppendLine();
                sb.AppendFormat("TimestampColumn={0}", this.TimestampColumn); sb.AppendLine();
                sb.AppendFormat("CharColumn={0}", this.CharColumn); sb.AppendLine();
                sb.AppendFormat("VarCharColumn={0}", this.VarCharColumn); sb.AppendLine();
                sb.AppendFormat("BitColumn={0}", this.BitColumn); sb.AppendLine();
                sb.AppendFormat("TinyIntColumn={0}", this.TinyIntColumn); sb.AppendLine();
                sb.AppendFormat("SmallIntColumn={0}", this.SmallIntColumn); sb.AppendLine();
                sb.AppendFormat("MediumIntColumn={0}", this.MediumIntColumn); sb.AppendLine();
                sb.AppendFormat("IntColumn={0}", this.IntColumn); sb.AppendLine();
                sb.AppendFormat("BigIntColumn={0}", this.BigIntColumn); sb.AppendLine();
                sb.AppendFormat("TinyIntUnsignedColumn={0}", this.TinyIntUnsignedColumn); sb.AppendLine();
                sb.AppendFormat("SmallIntUnsignedColumn={0}", this.SmallIntUnsignedColumn); sb.AppendLine();
                sb.AppendFormat("MediumIntUnsignedColumn={0}", this.MediumIntUnsignedColumn); sb.AppendLine();
                sb.AppendFormat("IntUnsignedColumn={0}", this.IntUnsignedColumn); sb.AppendLine();
                sb.AppendFormat("BigIntUnsignedColumn={0}", this.BigIntUnsignedColumn); sb.AppendLine();
                sb.AppendFormat("FloatColumn={0}", this.FloatColumn); sb.AppendLine();
                sb.AppendFormat("DoubleColumn={0}", this.DoubleColumn); sb.AppendLine();
                sb.AppendFormat("DecimalColumn={0}", this.DecimalColumn); sb.AppendLine();
                sb.AppendFormat("NumericColumn={0}", this.NumericColumn); sb.AppendLine();
                sb.AppendFormat("DateColumn={0}", this.DateColumn); sb.AppendLine();
                sb.AppendFormat("DateTimeColumn={0}", this.DateTimeColumn); sb.AppendLine();
                sb.AppendFormat("TimeColumn={0}", this.TimeColumn); sb.AppendLine();
                sb.AppendFormat("YearColumn={0}", this.YearColumn); sb.AppendLine();
                sb.AppendFormat("BinaryColumn={0}", this.BinaryColumn); sb.AppendLine();
                sb.AppendFormat("VarBinaryColumn={0}", this.VarBinaryColumn); sb.AppendLine();
                sb.AppendFormat("TinyBlobColumn={0}", this.TinyBlobColumn); sb.AppendLine();
                sb.AppendFormat("MediumBlobColumn={0}", this.MediumBlobColumn); sb.AppendLine();
                sb.AppendFormat("BlobColumn={0}", this.BlobColumn); sb.AppendLine();
                sb.AppendFormat("LongBlobColumn={0}", this.LongBlobColumn); sb.AppendLine();
                sb.AppendFormat("TinyTextColumn={0}", this.TinyTextColumn); sb.AppendLine();
                sb.AppendFormat("MediumTextColumn={0}", this.MediumTextColumn); sb.AppendLine();
                sb.AppendFormat("TextColumn={0}", this.TextColumn); sb.AppendLine();
                sb.AppendFormat("LongTextColumn={0}", this.LongTextColumn); sb.AppendLine();
                sb.AppendFormat("GeometryColumn={0}", this.GeometryColumn); sb.AppendLine();
                sb.AppendFormat("EnumColumn={0}", this.EnumColumn); sb.AppendLine();
                sb.AppendFormat("SetColumn={0}", this.SetColumn); sb.AppendLine();
                sb.AppendFormat("NotNullCharColumn={0}", this.NotNullCharColumn); sb.AppendLine();
                sb.AppendFormat("NotNullVarCharColumn={0}", this.NotNullVarCharColumn); sb.AppendLine();
                sb.AppendFormat("NotNullBitColumn={0}", this.NotNullBitColumn); sb.AppendLine();
                sb.AppendFormat("NotNullTinyIntColumn={0}", this.NotNullTinyIntColumn); sb.AppendLine();
                sb.AppendFormat("NotNullSmallIntColumn={0}", this.NotNullSmallIntColumn); sb.AppendLine();
                sb.AppendFormat("NotNullMediumIntColumn={0}", this.NotNullMediumIntColumn); sb.AppendLine();
                sb.AppendFormat("NotNullIntColumn={0}", this.NotNullIntColumn); sb.AppendLine();
                sb.AppendFormat("NotNullBigIntColumn={0}", this.NotNullBigIntColumn); sb.AppendLine();
                sb.AppendFormat("NotNullTinyIntUnsignedColumn={0}", this.NotNullTinyIntUnsignedColumn); sb.AppendLine();
                sb.AppendFormat("NotNullSmallIntUnsignedColumn={0}", this.NotNullSmallIntUnsignedColumn); sb.AppendLine();
                sb.AppendFormat("NotNullMediumIntUnsignedColumn={0}", this.NotNullMediumIntUnsignedColumn); sb.AppendLine();
                sb.AppendFormat("NotNullIntUnsignedColumn={0}", this.NotNullIntUnsignedColumn); sb.AppendLine();
                sb.AppendFormat("NotNullBigIntUnsignedColumn={0}", this.NotNullBigIntUnsignedColumn); sb.AppendLine();
                sb.AppendFormat("NotNullFloatColumn={0}", this.NotNullFloatColumn); sb.AppendLine();
                sb.AppendFormat("NotNullDoubleColumn={0}", this.NotNullDoubleColumn); sb.AppendLine();
                sb.AppendFormat("NotNullDecimalColumn={0}", this.NotNullDecimalColumn); sb.AppendLine();
                sb.AppendFormat("NotNullNumericColumn={0}", this.NotNullNumericColumn); sb.AppendLine();
                sb.AppendFormat("NotNullDateColumn={0}", this.NotNullDateColumn); sb.AppendLine();
                sb.AppendFormat("NotNullDateTimeColumn={0}", this.NotNullDateTimeColumn); sb.AppendLine();
                sb.AppendFormat("NotNullTimeColumn={0}", this.NotNullTimeColumn); sb.AppendLine();
                sb.AppendFormat("NotNullYearColumn={0}", this.NotNullYearColumn); sb.AppendLine();
                sb.AppendFormat("NotNullBinaryColumn={0}", this.NotNullBinaryColumn); sb.AppendLine();
                sb.AppendFormat("NotNullVarBinaryColumn={0}", this.NotNullVarBinaryColumn); sb.AppendLine();
                sb.AppendFormat("NotNullTinyBlobColumn={0}", this.NotNullTinyBlobColumn); sb.AppendLine();
                sb.AppendFormat("NotNullTinyTextColumn={0}", this.NotNullTinyTextColumn); sb.AppendLine();
                sb.AppendFormat("NotNullBlobColumn={0}", this.NotNullBlobColumn); sb.AppendLine();
                sb.AppendFormat("NotNullTextColumn={0}", this.NotNullTextColumn); sb.AppendLine();
                sb.AppendFormat("NotNullMediumBlobColumn={0}", this.NotNullMediumBlobColumn); sb.AppendLine();
                sb.AppendFormat("NotNullMediumTextColumn={0}", this.NotNullMediumTextColumn); sb.AppendLine();
                sb.AppendFormat("NotNullLongBlobColumn={0}", this.NotNullLongBlobColumn); sb.AppendLine();
                sb.AppendFormat("NotNullLongTextColumn={0}", this.NotNullLongTextColumn); sb.AppendLine();
                sb.AppendFormat("NotNullGeometryColumn={0}", this.NotNullGeometryColumn); sb.AppendLine();
                sb.AppendFormat("NotNullEnumColumn={0}", this.NotNullEnumColumn); sb.AppendLine();
                sb.AppendFormat("NotNullSetColumn={0}", this.NotNullSetColumn); sb.AppendLine();
                return sb.ToString();
            }
        }
    }
}
