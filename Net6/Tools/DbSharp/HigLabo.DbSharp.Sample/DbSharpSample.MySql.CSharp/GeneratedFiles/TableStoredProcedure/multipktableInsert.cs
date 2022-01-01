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
    public partial class multipktableInsert : StoredProcedure
    {
        public const String Name = "multipktableInsert";
        private Int64 _BigIntColumn;
        private Int32 _IntColumn;
        private Single _FloatColumn;
        private Byte[] _BinaryColumn;
        private DateTime _TimestampColumn;
        private Byte[] _VarBinaryColumn;
        private Boolean? _BitColumn;
        private String _NCharColumn = null;
        private String _NVarCharColumn = null;

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
        public Int32 IntColumn
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
        public Single FloatColumn
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

        public multipktableInsert()
        {
            ((IDatabaseContext)this).DatabaseKey = "DbSharpSample_MySql";
            ConstructorExecuted();
        }

        public override String GetStoredProcedureName()
        {
            return multipktableInsert.Name;
        }
        partial void ConstructorExecuted();
        public override DbCommand CreateCommand(Database database)
        {
            var db = database;
            var cm = db.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = this.GetStoredProcedureName();
            
            DbParameter p = null;
            
            p = db.CreateParameter("@BigIntColumn", MySqlDbType.Int64, 19, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.BigIntColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@IntColumn", MySqlDbType.Int32, 10, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.IntColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@FloatColumn", MySqlDbType.Float, 12, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.FloatColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@BinaryColumn", MySqlDbType.Binary, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.BinaryColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@TimestampColumn", MySqlDbType.Timestamp, null, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.TimestampColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@VarBinaryColumn", MySqlDbType.VarBinary, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.VarBinaryColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@BitColumn", MySqlDbType.Bit, 1, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.BitColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NCharColumn", MySqlDbType.String, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.NCharColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NVarCharColumn", MySqlDbType.VarChar, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.NVarCharColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            return cm;
        }
        protected override void SetOutputParameterValue(DbCommand command)
        {
            var cm = command;
            DbParameter p = null;
            p = cm.Parameters[4] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.TimestampColumn = (DateTime)p.Value;
        }
        public override String ToString()
        {
            var sb = new StringBuilder(32);
            sb.AppendLine("<multipktableInsert>");
            sb.AppendFormat("BigIntColumn={0}", this.BigIntColumn); sb.AppendLine();
            sb.AppendFormat("IntColumn={0}", this.IntColumn); sb.AppendLine();
            sb.AppendFormat("FloatColumn={0}", this.FloatColumn); sb.AppendLine();
            sb.AppendFormat("BinaryColumn={0}", this.BinaryColumn); sb.AppendLine();
            sb.AppendFormat("TimestampColumn={0}", this.TimestampColumn); sb.AppendLine();
            sb.AppendFormat("VarBinaryColumn={0}", this.VarBinaryColumn); sb.AppendLine();
            sb.AppendFormat("BitColumn={0}", this.BitColumn); sb.AppendLine();
            sb.AppendFormat("NCharColumn={0}", this.NCharColumn); sb.AppendLine();
            sb.AppendFormat("NVarCharColumn={0}", this.NVarCharColumn); sb.AppendLine();
            return sb.ToString();
        }
    }
}
