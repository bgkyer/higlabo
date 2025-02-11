﻿//Generated at 2022/01/01 08:20:25 by DbSharpApplication.
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

namespace HigLabo.DbSharpSample.SqlServer
{
    public partial class Usp_OutputParameter : StoredProcedure
    {
        public const String Name = "Usp_OutputParameter";
        private Int64? _BigIntColumn;
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

        public Usp_OutputParameter()
        {
            ((IDatabaseContext)this).DatabaseKey = "DbSharpSample_SqlServer";
            ConstructorExecuted();
        }

        public override String GetStoredProcedureName()
        {
            return Usp_OutputParameter.Name;
        }
        partial void ConstructorExecuted();
        public override DbCommand CreateCommand(Database database)
        {
            var db = database;
            var cm = db.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = this.GetStoredProcedureName();
            
            DbParameter p = null;
            
            p = db.CreateParameter("@BigIntColumn", SqlDbType.BigInt, 19, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.BigIntColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@BinaryColumn", SqlDbType.Binary, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = 100;
            p.Value = this.BinaryColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@ImageColumn", SqlDbType.Image, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 2147483647;
            p.Value = this.ImageColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@VarBinaryColumn", SqlDbType.VarBinary, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = 100;
            p.Value = this.VarBinaryColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@BitColumn", SqlDbType.Bit, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.BitColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@CharColumn", SqlDbType.Char, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = 100;
            p.Value = this.CharColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NCharColumn", SqlDbType.NChar, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = 100;
            p.Value = this.NCharColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NTextColumn", SqlDbType.NText, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 1073741823;
            p.Value = this.NTextColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NVarCharColumn", SqlDbType.NVarChar, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = 100;
            p.Value = this.NVarCharColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@TextColumn", SqlDbType.Text, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 2147483647;
            p.Value = this.TextColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@VarCharColumn", SqlDbType.VarChar, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = 100;
            p.Value = this.VarCharColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@XmlColumn", SqlDbType.Xml, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = -1;
            p.Value = this.XmlColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@DateTimeColumn", SqlDbType.DateTime, null, 3);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.DateTimeColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@SmallDateTimeColumn", SqlDbType.SmallDateTime, null, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.SmallDateTimeColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@DateColumn", SqlDbType.Date, null, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.DateColumn?.ToDateTime(TimeOnly.MinValue);
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@TimeColumn", SqlDbType.Time, null, 7);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.TimeColumn?.ToTimeSpan();
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@DateTime2Column", SqlDbType.DateTime2, null, 7);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.DateTime2Column;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@DecimalColumn", SqlDbType.Decimal, 18, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.DecimalColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@MoneyColumn", SqlDbType.Money, 19, 4);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.MoneyColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@SmallMoneyColumn", SqlDbType.SmallMoney, 10, 4);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.SmallMoneyColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@FloatColumn", SqlDbType.Float, 53, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.FloatColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@IntColumn", SqlDbType.Int, 10, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.IntColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@RealColumn", SqlDbType.Real, 24, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.RealColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@UniqueIdentifierColumn", SqlDbType.UniqueIdentifier, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.UniqueIdentifierColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@SmallIntColumn", SqlDbType.SmallInt, 5, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.SmallIntColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@TinyIntColumn", SqlDbType.TinyInt, 3, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.TinyIntColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@DateTimeOffsetColumn", SqlDbType.DateTimeOffset, null, 7);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.DateTimeOffsetColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@EnumColumn", SqlDbType.NVarChar, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = 20;
            p.Value = this.EnumColumn.ToStringOrNullFromEnum();
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            return cm;
        }
        protected override void SetOutputParameterValue(DbCommand command)
        {
            var cm = command;
            DbParameter p = null;
            p = cm.Parameters[0] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.BigIntColumn = (Int64)p.Value;
            p = cm.Parameters[1] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.BinaryColumn = (Byte[])p.Value;
            p = cm.Parameters[3] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.VarBinaryColumn = (Byte[])p.Value;
            p = cm.Parameters[4] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.BitColumn = (Boolean)p.Value;
            p = cm.Parameters[5] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.CharColumn = (String)p.Value;
            p = cm.Parameters[6] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.NCharColumn = (String)p.Value;
            p = cm.Parameters[8] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.NVarCharColumn = (String)p.Value;
            p = cm.Parameters[10] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.VarCharColumn = (String)p.Value;
            p = cm.Parameters[11] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.XmlColumn = (String)p.Value;
            p = cm.Parameters[12] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.DateTimeColumn = (DateTime)p.Value;
            p = cm.Parameters[13] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.SmallDateTimeColumn = (DateTime)p.Value;
            p = cm.Parameters[14] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.DateColumn = DateOnly.FromDateTime((DateTime)p.Value);
            p = cm.Parameters[15] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.TimeColumn = TimeOnly.FromTimeSpan((TimeSpan)p.Value);
            p = cm.Parameters[16] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.DateTime2Column = (DateTime)p.Value;
            p = cm.Parameters[17] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.DecimalColumn = (Decimal)p.Value;
            p = cm.Parameters[18] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.MoneyColumn = (Decimal)p.Value;
            p = cm.Parameters[19] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.SmallMoneyColumn = (Decimal)p.Value;
            p = cm.Parameters[20] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.FloatColumn = (Double)p.Value;
            p = cm.Parameters[21] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.IntColumn = (Int32)p.Value;
            p = cm.Parameters[22] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.RealColumn = (Single)p.Value;
            p = cm.Parameters[23] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.UniqueIdentifierColumn = (Guid)p.Value;
            p = cm.Parameters[24] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.SmallIntColumn = (Int16)p.Value;
            p = cm.Parameters[25] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.TinyIntColumn = (Byte)p.Value;
            p = cm.Parameters[26] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.DateTimeOffsetColumn = (DateTimeOffset)p.Value;
            p = cm.Parameters[27] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.EnumColumn = StoredProcedure.ToEnum<MyEnum>(p.Value as String) ?? this.EnumColumn;
        }
        public override String ToString()
        {
            var sb = new StringBuilder(32);
            sb.AppendLine("<Usp_OutputParameter>");
            sb.AppendFormat("BigIntColumn={0}", this.BigIntColumn); sb.AppendLine();
            sb.AppendFormat("BinaryColumn={0}", this.BinaryColumn); sb.AppendLine();
            sb.AppendFormat("ImageColumn={0}", this.ImageColumn); sb.AppendLine();
            sb.AppendFormat("VarBinaryColumn={0}", this.VarBinaryColumn); sb.AppendLine();
            sb.AppendFormat("BitColumn={0}", this.BitColumn); sb.AppendLine();
            sb.AppendFormat("CharColumn={0}", this.CharColumn); sb.AppendLine();
            sb.AppendFormat("NCharColumn={0}", this.NCharColumn); sb.AppendLine();
            sb.AppendFormat("NTextColumn={0}", this.NTextColumn); sb.AppendLine();
            sb.AppendFormat("NVarCharColumn={0}", this.NVarCharColumn); sb.AppendLine();
            sb.AppendFormat("TextColumn={0}", this.TextColumn); sb.AppendLine();
            sb.AppendFormat("VarCharColumn={0}", this.VarCharColumn); sb.AppendLine();
            sb.AppendFormat("XmlColumn={0}", this.XmlColumn); sb.AppendLine();
            sb.AppendFormat("DateTimeColumn={0}", this.DateTimeColumn); sb.AppendLine();
            sb.AppendFormat("SmallDateTimeColumn={0}", this.SmallDateTimeColumn); sb.AppendLine();
            sb.AppendFormat("DateColumn={0}", this.DateColumn); sb.AppendLine();
            sb.AppendFormat("TimeColumn={0}", this.TimeColumn); sb.AppendLine();
            sb.AppendFormat("DateTime2Column={0}", this.DateTime2Column); sb.AppendLine();
            sb.AppendFormat("DecimalColumn={0}", this.DecimalColumn); sb.AppendLine();
            sb.AppendFormat("MoneyColumn={0}", this.MoneyColumn); sb.AppendLine();
            sb.AppendFormat("SmallMoneyColumn={0}", this.SmallMoneyColumn); sb.AppendLine();
            sb.AppendFormat("FloatColumn={0}", this.FloatColumn); sb.AppendLine();
            sb.AppendFormat("IntColumn={0}", this.IntColumn); sb.AppendLine();
            sb.AppendFormat("RealColumn={0}", this.RealColumn); sb.AppendLine();
            sb.AppendFormat("UniqueIdentifierColumn={0}", this.UniqueIdentifierColumn); sb.AppendLine();
            sb.AppendFormat("SmallIntColumn={0}", this.SmallIntColumn); sb.AppendLine();
            sb.AppendFormat("TinyIntColumn={0}", this.TinyIntColumn); sb.AppendLine();
            sb.AppendFormat("DateTimeOffsetColumn={0}", this.DateTimeOffsetColumn); sb.AppendLine();
            sb.AppendFormat("EnumColumn={0}", this.EnumColumn); sb.AppendLine();
            return sb.ToString();
        }
    }
}
