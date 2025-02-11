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
    public partial class MultiPkTable : Table<MultiPkTable.Record>
    {
        public const String Name = "MultiPkTable";

        public override String TableName
        {
            get
            {
                return MultiPkTable.Name;
            }
        }

        public MultiPkTable()
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
            var spInsert = storedProcedure as MultiPkTableInsert;
            if (spInsert != null)
            {
                record.TimestampColumn = spInsert.TimestampColumn;
            }
            var spUpdate = storedProcedure as MultiPkTableUpdate;
            if (spUpdate != null)
            {
                record.TimestampColumn = spUpdate.TimestampColumn;
            }
        }
        public Record SelectByPrimaryKey(Int64 bigIntColumn, Int32 intColumn, Double floatColumn)
        {
            return this.SelectByPrimaryKey(this.GetDatabase(), bigIntColumn, intColumn, floatColumn);
        }
        public Record SelectByPrimaryKeyOrNull(Int64 bigIntColumn, Int32 intColumn, Double floatColumn)
        {
            return this.SelectByPrimaryKeyOrNull(this.GetDatabase(), bigIntColumn, intColumn, floatColumn);
        }
        public Record SelectByPrimaryKey(Database database, Int64 bigIntColumn, Int32 intColumn, Double floatColumn)
        {
            var r = this.SelectByPrimaryKeyOrNull(database, bigIntColumn, intColumn, floatColumn);
            if (r == null) throw new TableRecordNotFoundException(Name, bigIntColumn, intColumn, floatColumn);
            return r;
        }
        public Record SelectByPrimaryKeyOrNull(Database database, Int64 bigIntColumn, Int32 intColumn, Double floatColumn)
        {
            var sp = new MultiPkTableSelectByPrimaryKey();
            sp.PK_BigIntColumn = bigIntColumn;
            sp.PK_IntColumn = intColumn;
            sp.PK_FloatColumn = floatColumn;
            var rs = sp.GetFirstResultSet(database);
            if (rs == null) return null;
            var r = new Record(rs);
            r.SetOldRecordProperty();
            return r;
        }
        public Int32 Delete(Int64 bigIntColumn, Int32 intColumn, Double floatColumn, Byte[] timestampColumn)
        {
            return this.Delete(this.GetDatabase(), bigIntColumn, intColumn, floatColumn, timestampColumn);
        }
        public Int32 Delete(Database database, Int64 bigIntColumn, Int32 intColumn, Double floatColumn, Byte[] timestampColumn)
        {
            var sp = new MultiPkTableDelete();
            sp.PK_BigIntColumn = bigIntColumn;
            sp.PK_IntColumn = intColumn;
            sp.PK_FloatColumn = floatColumn;
            sp.PK_TimestampColumn = timestampColumn;
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
        public MultiPkTableSelectAll CreateSelectAllStoredProcedure()
        {
            return new MultiPkTableSelectAll();
        }
        public MultiPkTableSelectByPrimaryKey CreateSelectByPrimaryKeyStoredProcedure(Record record)
        {
            var sp = new MultiPkTableSelectByPrimaryKey();
            if (record == null) return sp;
            if (record.OldRecord == null) throw new OldRecordIsNullException();
            sp.PK_BigIntColumn = record.OldRecord.BigIntColumn;
            sp.PK_IntColumn = record.OldRecord.IntColumn;
            sp.PK_FloatColumn = record.OldRecord.FloatColumn;
            return sp;
        }
        public MultiPkTableInsert CreateInsertStoredProcedure(Record record)
        {
            var sp = new MultiPkTableInsert();
            if (record == null) return sp;
            sp.BigIntColumn = record.BigIntColumn;
            sp.IntColumn = record.IntColumn;
            sp.FloatColumn = record.FloatColumn;
            sp.BinaryColumn = record.BinaryColumn;
            sp.TimestampColumn = record.TimestampColumn;
            sp.VarBinaryColumn = record.VarBinaryColumn;
            sp.BitColumn = record.BitColumn;
            sp.NCharColumn = record.NCharColumn;
            sp.NTextColumn = record.NTextColumn;
            sp.NVarCharColumn = record.NVarCharColumn;
            return sp;
        }
        public MultiPkTableUpdate CreateUpdateStoredProcedure(Record record)
        {
            var sp = new MultiPkTableUpdate();
            if (record == null) return sp;
            if (record.OldRecord == null) throw new OldRecordIsNullException();
            sp.BigIntColumn = record.BigIntColumn;
            sp.IntColumn = record.IntColumn;
            sp.FloatColumn = record.FloatColumn;
            sp.BinaryColumn = record.BinaryColumn;
            sp.TimestampColumn = record.TimestampColumn;
            sp.VarBinaryColumn = record.VarBinaryColumn;
            sp.BitColumn = record.BitColumn;
            sp.NCharColumn = record.NCharColumn;
            sp.NTextColumn = record.NTextColumn;
            sp.NVarCharColumn = record.NVarCharColumn;
            sp.PK_BigIntColumn = record.OldRecord.BigIntColumn;
            sp.PK_IntColumn = record.OldRecord.IntColumn;
            sp.PK_FloatColumn = record.OldRecord.FloatColumn;
            sp.PK_TimestampColumn = record.OldRecord.TimestampColumn;
            return sp;
        }
        public MultiPkTableDelete CreateDeleteStoredProcedure(Record record)
        {
            var sp = new MultiPkTableDelete();
            if (record == null) return sp;
            if (record.OldRecord == null) throw new OldRecordIsNullException();
            sp.PK_BigIntColumn = record.OldRecord.BigIntColumn;
            sp.PK_IntColumn = record.OldRecord.IntColumn;
            sp.PK_FloatColumn = record.OldRecord.FloatColumn;
            sp.PK_TimestampColumn = record.OldRecord.TimestampColumn;
            return sp;
        }
        protected override DataTable CreateDataTable()
        {
            var dt = new DataTable(Name);
            dt.Columns.Add("@PK_BigIntColumn", typeof(Int64));
            dt.Columns.Add("@PK_IntColumn", typeof(Int32));
            dt.Columns.Add("@PK_FloatColumn", typeof(Double));
            dt.Columns.Add("@BigIntColumn", typeof(Int64));
            dt.Columns.Add("@IntColumn", typeof(Int32));
            dt.Columns.Add("@FloatColumn", typeof(Double));
            dt.Columns.Add("@BinaryColumn", typeof(Byte[]));
            dt.Columns.Add("@TimestampColumn", typeof(Byte[]));
            dt.Columns.Add("@VarBinaryColumn", typeof(Byte[]));
            dt.Columns.Add("@BitColumn", typeof(Boolean));
            dt.Columns.Add("@NCharColumn", typeof(String));
            dt.Columns.Add("@NTextColumn", typeof(String));
            dt.Columns.Add("@NVarCharColumn", typeof(String));
            return dt;
        }
        protected override DataRow SetDataRow(DataRow dataRow, Record record, SaveMode saveMode)
        {
            if (saveMode != SaveMode.Insert)
            {
                if (record.OldRecord == null) throw new OldRecordIsNullException();
                dataRow["@PK_BigIntColumn"] = GetValueOrDBNull(record.OldRecord.BigIntColumn);
                dataRow["@PK_IntColumn"] = GetValueOrDBNull(record.OldRecord.IntColumn);
                dataRow["@PK_FloatColumn"] = GetValueOrDBNull(record.OldRecord.FloatColumn);
            }
            dataRow["@BigIntColumn"] = GetValueOrDBNull(record.BigIntColumn);
            dataRow["@IntColumn"] = GetValueOrDBNull(record.IntColumn);
            dataRow["@FloatColumn"] = GetValueOrDBNull(record.FloatColumn);
            dataRow["@BinaryColumn"] = GetValueOrDBNull(record.BinaryColumn);
            dataRow["@TimestampColumn"] = GetValueOrDBNull(record.TimestampColumn);
            dataRow["@VarBinaryColumn"] = GetValueOrDBNull(record.VarBinaryColumn);
            dataRow["@BitColumn"] = GetValueOrDBNull(record.BitColumn);
            dataRow["@NCharColumn"] = GetValueOrDBNull(record.NCharColumn);
            dataRow["@NTextColumn"] = GetValueOrDBNull(record.NTextColumn);
            dataRow["@NVarCharColumn"] = GetValueOrDBNull(record.NVarCharColumn);
            return dataRow;
        }
    }
}
