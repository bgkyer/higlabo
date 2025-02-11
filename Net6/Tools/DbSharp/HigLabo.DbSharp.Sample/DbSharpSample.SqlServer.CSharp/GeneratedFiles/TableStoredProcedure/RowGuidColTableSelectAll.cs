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
    public partial class RowGuidColTableSelectAll : StoredProcedureWithResultSet<RowGuidColTableSelectAll.ResultSet>
    {
        public const String Name = "RowGuidColTableSelectAll";

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

        public RowGuidColTableSelectAll()
        {
            ((IDatabaseContext)this).DatabaseKey = "DbSharpSample_SqlServer";
            ConstructorExecuted();
        }

        public override String GetStoredProcedureName()
        {
            return RowGuidColTableSelectAll.Name;
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
        public override RowGuidColTableSelectAll.ResultSet CreateResultSet()
        {
            return new ResultSet(this);
        }
        protected override void SetResultSet(RowGuidColTableSelectAll.ResultSet resultSet, IDataReader reader)
        {
            var r = resultSet;
            Int32 index = -1;
            try
            {
                index += 1; r.RowGuidColumn = reader.GetGuid(index);
                index += 1; if (reader[index] != DBNull.Value) r.NVarCharColumn = reader[index] as String;
            }
            catch (Exception ex)
            {
                throw new StoredProcedureSchemaMismatchedException(this, index, ex);
            }
        }
        public override String ToString()
        {
            var sb = new StringBuilder(32);
            sb.AppendLine("<RowGuidColTableSelectAll>");
            return sb.ToString();
        }

        public partial class ResultSet : StoredProcedureResultSet, RowGuidColTable.IRecord
        {
            private Guid _RowGuidColumn;
            private String _NVarCharColumn = null;

            public Guid RowGuidColumn
            {
                get
                {
                    return _RowGuidColumn;
                }
                set
                {
                    _RowGuidColumn = value;
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

            public ResultSet()
            {
            }
            public ResultSet(RowGuidColTable.IRecord resultSet)
            {
                var r = resultSet;
                RowGuidColumn = r.RowGuidColumn;
                NVarCharColumn = r.NVarCharColumn;
            }
            internal ResultSet(RowGuidColTableSelectAll storedProcedure)
            {
                this._StoredProcedureResultSet_StoredProcedure = storedProcedure;
            }

            public override String ToString()
            {
                var sb = new StringBuilder(64);
                sb.AppendLine("<RowGuidColTableSelectAll.ResultSet>");
                sb.AppendFormat("RowGuidColumn={0}", this.RowGuidColumn); sb.AppendLine();
                sb.AppendFormat("NVarCharColumn={0}", this.NVarCharColumn); sb.AppendLine();
                return sb.ToString();
            }
        }
    }
}
