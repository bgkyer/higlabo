﻿//Generated at 2022/01/01 08:20:25 by DbSharpApplication.
//https://github.com/higty/higlabo/tree/master/Net6/Tools/DbSharp
using System;
using System.Linq;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Collections.Generic;
using HigLabo.Data;
using HigLabo.DbSharp;

namespace HigLabo.DbSharpSample.SqlServer
{
    public partial class IdentityTable : Table<IdentityTable.Record>
    {
        public const String Name = "IdentityTable";

        public override String TableName
        {
            get
            {
                return IdentityTable.Name;
            }
        }

        public IdentityTable()
        {
            ((IDatabaseContext)this).DatabaseKey = "DbSharpSample_SqlServer";
        }

        public override Record CreateRecord()
        {
            return new Record();
        }
        protected override void SetRecordProperty(StoredProcedureResultSet resultSet, Record record)
        {
            record.SetProperty(resultSet as IRecord);
        }
        protected override void SetOutputParameterValue(Record record, StoredProcedure storedProcedure)
        {
            var spInsert = storedProcedure as IdentityTableInsert;
            if (spInsert != null)
            {
                record.IntColumn = spInsert.IntColumn;
            }
            var spUpdate = storedProcedure as IdentityTableUpdate;
            if (spUpdate != null)
            {
                record.IntColumn = spUpdate.IntColumn;
            }
        }
        public Record SelectByPrimaryKey(Int32 intColumn)
        {
            return this.SelectByPrimaryKey(this.GetDatabase(), intColumn);
        }
        public Record SelectByPrimaryKeyOrNull(Int32 intColumn)
        {
            return this.SelectByPrimaryKeyOrNull(this.GetDatabase(), intColumn);
        }
        public Record SelectByPrimaryKey(Database database, Int32 intColumn)
        {
            var r = this.SelectByPrimaryKeyOrNull(database, intColumn);
            if (r == null) throw new TableRecordNotFoundException(Name, intColumn);
            return r;
        }
        public Record SelectByPrimaryKeyOrNull(Database database, Int32 intColumn)
        {
            var sp = new IdentityTableSelectByPrimaryKey();
            sp.PK_IntColumn = intColumn;
            var rs = sp.GetFirstResultSet(database);
            if (rs == null) return null;
            var r = new Record(rs);
            r.SetOldRecordProperty();
            return r;
        }
        public Int32 Delete(Int32 intColumn)
        {
            return this.Delete(this.GetDatabase(), intColumn);
        }
        public Int32 Delete(Database database, Int32 intColumn)
        {
            var sp = new IdentityTableDelete();
            sp.PK_IntColumn = intColumn;
            return sp.ExecuteNonQuery(database);
        }
        public override StoredProcedureWithResultSet CreateStoredProcedureWithResultSet(TableStoredProcedureTypeWithResultSet type, Record record)
        {
            switch (type)
            {
                case TableStoredProcedureTypeWithResultSet.SelectAll: return CreateSelectAllStoredProcedure();
                case TableStoredProcedureTypeWithResultSet.SelectByPrimaryKey: return this.CreateSelectByPrimaryKeyStoredProcedure(record);
                default: throw new InvalidOperationException();
            }
        }
        public override StoredProcedure CreateStoredProcedure(TableStoredProcedureType type, Record record)
        {
            switch (type)
            {
                case TableStoredProcedureType.Insert: return this.CreateInsertStoredProcedure(record);
                case TableStoredProcedureType.Update: return this.CreateUpdateStoredProcedure(record);
                case TableStoredProcedureType.Delete: return this.CreateDeleteStoredProcedure(record);
                default: throw new InvalidOperationException();
            }
        }
        public IdentityTableSelectAll CreateSelectAllStoredProcedure()
        {
            return new IdentityTableSelectAll();
        }
        public IdentityTableSelectByPrimaryKey CreateSelectByPrimaryKeyStoredProcedure(Record record)
        {
            var sp = new IdentityTableSelectByPrimaryKey();
            if (record == null) return sp;
            if (record.OldRecord == null) throw new OldRecordIsNullException();
            sp.PK_IntColumn = record.OldRecord.IntColumn;
            return sp;
        }
        public IdentityTableInsert CreateInsertStoredProcedure(Record record)
        {
            var sp = new IdentityTableInsert();
            if (record == null) return sp;
            sp.IntColumn = record.IntColumn;
            sp.NVarCharColumn = record.NVarCharColumn;
            return sp;
        }
        public IdentityTableUpdate CreateUpdateStoredProcedure(Record record)
        {
            var sp = new IdentityTableUpdate();
            if (record == null) return sp;
            if (record.OldRecord == null) throw new OldRecordIsNullException();
            sp.IntColumn = record.IntColumn;
            sp.NVarCharColumn = record.NVarCharColumn;
            sp.PK_IntColumn = record.OldRecord.IntColumn;
            return sp;
        }
        public IdentityTableDelete CreateDeleteStoredProcedure(Record record)
        {
            var sp = new IdentityTableDelete();
            if (record == null) return sp;
            if (record.OldRecord == null) throw new OldRecordIsNullException();
            sp.PK_IntColumn = record.OldRecord.IntColumn;
            return sp;
        }
        protected override DataTable CreateDataTable()
        {
            var dt = new DataTable(Name);
            dt.Columns.Add("@PK_IntColumn", typeof(Int32));
            dt.Columns.Add("@IntColumn", typeof(Int32));
            dt.Columns.Add("@NVarCharColumn", typeof(String));
            return dt;
        }
        protected override DataRow SetDataRow(DataRow dataRow, Record record, SaveMode saveMode)
        {
            if (saveMode != SaveMode.Insert)
            {
                if (record.OldRecord == null) throw new OldRecordIsNullException();
                dataRow["@PK_IntColumn"] = GetValueOrDBNull(record.OldRecord.IntColumn);
            }
            dataRow["@IntColumn"] = GetValueOrDBNull(record.IntColumn);
            dataRow["@NVarCharColumn"] = GetValueOrDBNull(record.NVarCharColumn);
            return dataRow;
        }
    }
}
