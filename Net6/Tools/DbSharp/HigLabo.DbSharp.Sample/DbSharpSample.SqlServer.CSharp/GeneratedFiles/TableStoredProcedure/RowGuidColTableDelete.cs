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
    public partial class RowGuidColTableDelete : StoredProcedure
    {
        public const String Name = "RowGuidColTableDelete";
        private Guid _PK_RowGuidColumn;

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
        public Guid PK_RowGuidColumn
        {
            get
            {
                return _PK_RowGuidColumn;
            }
            set
            {
                _PK_RowGuidColumn = value;
            }
        }

        public RowGuidColTableDelete()
        {
            ((IDatabaseContext)this).DatabaseKey = "DbSharpSample_SqlServer";
            ConstructorExecuted();
        }

        public override String GetStoredProcedureName()
        {
            return RowGuidColTableDelete.Name;
        }
        partial void ConstructorExecuted();
        public override DbCommand CreateCommand(Database database)
        {
            var db = database;
            var cm = db.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = this.GetStoredProcedureName();
            
            DbParameter p = null;
            
            p = db.CreateParameter("@PK_RowGuidColumn", SqlDbType.UniqueIdentifier, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.PK_RowGuidColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            return cm;
        }
        protected override void SetOutputParameterValue(DbCommand command)
        {
        }
        public override String ToString()
        {
            var sb = new StringBuilder(32);
            sb.AppendLine("<RowGuidColTableDelete>");
            sb.AppendFormat("PK_RowGuidColumn={0}", this.PK_RowGuidColumn); sb.AppendLine();
            return sb.ToString();
        }
    }
}
