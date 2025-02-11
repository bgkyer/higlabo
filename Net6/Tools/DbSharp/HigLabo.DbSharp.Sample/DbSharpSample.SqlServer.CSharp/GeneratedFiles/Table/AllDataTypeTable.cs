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
    public partial class AllDataTypeTable : Table<AllDataTypeTable.Record>
    {
        public const String Name = "AllDataTypeTable";

        public override String TableName
        {
            get
            {
                return AllDataTypeTable.Name;
            }
        }

        public AllDataTypeTable()
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
            var spInsert = storedProcedure as AllDataTypeTableInsert;
            if (spInsert != null)
            {
                record.TimestampColumn = spInsert.TimestampColumn;
            }
            var spUpdate = storedProcedure as AllDataTypeTableUpdate;
            if (spUpdate != null)
            {
                record.TimestampColumn = spUpdate.TimestampColumn;
            }
        }
        public Record SelectByPrimaryKey(Int64 primaryKeyColumn)
        {
            return this.SelectByPrimaryKey(this.GetDatabase(), primaryKeyColumn);
        }
        public Record SelectByPrimaryKeyOrNull(Int64 primaryKeyColumn)
        {
            return this.SelectByPrimaryKeyOrNull(this.GetDatabase(), primaryKeyColumn);
        }
        public Record SelectByPrimaryKey(Database database, Int64 primaryKeyColumn)
        {
            var r = this.SelectByPrimaryKeyOrNull(database, primaryKeyColumn);
            if (r == null) throw new TableRecordNotFoundException(Name, primaryKeyColumn);
            return r;
        }
        public Record SelectByPrimaryKeyOrNull(Database database, Int64 primaryKeyColumn)
        {
            var sp = new AllDataTypeTableSelectByPrimaryKey();
            sp.PK_PrimaryKeyColumn = primaryKeyColumn;
            var rs = sp.GetFirstResultSet(database);
            if (rs == null) return null;
            var r = new Record(rs);
            r.SetOldRecordProperty();
            return r;
        }
        public Int32 Delete(Int64 primaryKeyColumn, Byte[] timestampColumn)
        {
            return this.Delete(this.GetDatabase(), primaryKeyColumn, timestampColumn);
        }
        public Int32 Delete(Database database, Int64 primaryKeyColumn, Byte[] timestampColumn)
        {
            var sp = new AllDataTypeTableDelete();
            sp.PK_PrimaryKeyColumn = primaryKeyColumn;
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
        public AllDataTypeTableSelectAll CreateSelectAllStoredProcedure()
        {
            return new AllDataTypeTableSelectAll();
        }
        public AllDataTypeTableSelectByPrimaryKey CreateSelectByPrimaryKeyStoredProcedure(Record record)
        {
            var sp = new AllDataTypeTableSelectByPrimaryKey();
            if (record == null) return sp;
            if (record.OldRecord == null) throw new OldRecordIsNullException();
            sp.PK_PrimaryKeyColumn = record.OldRecord.PrimaryKeyColumn;
            return sp;
        }
        public AllDataTypeTableInsert CreateInsertStoredProcedure(Record record)
        {
            var sp = new AllDataTypeTableInsert();
            if (record == null) return sp;
            sp.PrimaryKeyColumn = record.PrimaryKeyColumn;
            sp.TimestampColumn = record.TimestampColumn;
            sp.BigIntColumn = record.BigIntColumn;
            sp.BinaryColumn = record.BinaryColumn;
            sp.ImageColumn = record.ImageColumn;
            sp.VarBinaryColumn = record.VarBinaryColumn;
            sp.BitColumn = record.BitColumn;
            sp.CharColumn = record.CharColumn;
            sp.NCharColumn = record.NCharColumn;
            sp.NTextColumn = record.NTextColumn;
            sp.NVarCharColumn = record.NVarCharColumn;
            sp.TextColumn = record.TextColumn;
            sp.VarCharColumn = record.VarCharColumn;
            sp.XmlColumn = record.XmlColumn;
            sp.DateTimeColumn = record.DateTimeColumn;
            sp.SmallDateTimeColumn = record.SmallDateTimeColumn;
            sp.DateColumn = record.DateColumn;
            sp.TimeColumn = record.TimeColumn;
            sp.DateTime2Column = record.DateTime2Column;
            sp.DecimalColumn = record.DecimalColumn;
            sp.MoneyColumn = record.MoneyColumn;
            sp.SmallMoneyColumn = record.SmallMoneyColumn;
            sp.FloatColumn = record.FloatColumn;
            sp.IntColumn = record.IntColumn;
            sp.RealColumn = record.RealColumn;
            sp.UniqueIdentifierColumn = record.UniqueIdentifierColumn;
            sp.SmallIntColumn = record.SmallIntColumn;
            sp.TinyIntColumn = record.TinyIntColumn;
            sp.DateTimeOffsetColumn = record.DateTimeOffsetColumn;
            sp.SqlVariantColumn = record.SqlVariantColumn;
            sp.EnumColumn = record.EnumColumn;
            sp.NotNullBigIntColumn = record.NotNullBigIntColumn;
            sp.NotNullBinaryColumn = record.NotNullBinaryColumn;
            sp.NotNullImageColumn = record.NotNullImageColumn;
            sp.NotNullVarBinaryColumn = record.NotNullVarBinaryColumn;
            sp.NotNullBitColumn = record.NotNullBitColumn;
            sp.NotNullCharColumn = record.NotNullCharColumn;
            sp.NotNullNCharColumn = record.NotNullNCharColumn;
            sp.NotNullNTextColumn = record.NotNullNTextColumn;
            sp.NotNullNVarCharColumn = record.NotNullNVarCharColumn;
            sp.NotNullTextColumn = record.NotNullTextColumn;
            sp.NotNullVarCharColumn = record.NotNullVarCharColumn;
            sp.NotNullXmlColumn = record.NotNullXmlColumn;
            sp.NotNullDateTimeColumn = record.NotNullDateTimeColumn;
            sp.NotNullSmallDateTimeColumn = record.NotNullSmallDateTimeColumn;
            sp.NotNullDateColumn = record.NotNullDateColumn;
            sp.NotNullTimeColumn = record.NotNullTimeColumn;
            sp.NotNullDateTime2Column = record.NotNullDateTime2Column;
            sp.NotNullDecimalColumn = record.NotNullDecimalColumn;
            sp.NotNullMoneyColumn = record.NotNullMoneyColumn;
            sp.NotNullSmallMoneyColumn = record.NotNullSmallMoneyColumn;
            sp.NotNullFloatColumn = record.NotNullFloatColumn;
            sp.NotNullIntColumn = record.NotNullIntColumn;
            sp.NotNullRealColumn = record.NotNullRealColumn;
            sp.NotNullUniqueIdentifierColumn = record.NotNullUniqueIdentifierColumn;
            sp.NotNullSmallIntColumn = record.NotNullSmallIntColumn;
            sp.NotNullTinyIntColumn = record.NotNullTinyIntColumn;
            sp.NotNullDateTimeOffsetColumn = record.NotNullDateTimeOffsetColumn;
            sp.NotNullSqlVariantColumn = record.NotNullSqlVariantColumn;
            sp.NotNullEnumColumn = record.NotNullEnumColumn;
            return sp;
        }
        public AllDataTypeTableUpdate CreateUpdateStoredProcedure(Record record)
        {
            var sp = new AllDataTypeTableUpdate();
            if (record == null) return sp;
            if (record.OldRecord == null) throw new OldRecordIsNullException();
            sp.PrimaryKeyColumn = record.PrimaryKeyColumn;
            sp.TimestampColumn = record.TimestampColumn;
            sp.BigIntColumn = record.BigIntColumn;
            sp.BinaryColumn = record.BinaryColumn;
            sp.ImageColumn = record.ImageColumn;
            sp.VarBinaryColumn = record.VarBinaryColumn;
            sp.BitColumn = record.BitColumn;
            sp.CharColumn = record.CharColumn;
            sp.NCharColumn = record.NCharColumn;
            sp.NTextColumn = record.NTextColumn;
            sp.NVarCharColumn = record.NVarCharColumn;
            sp.TextColumn = record.TextColumn;
            sp.VarCharColumn = record.VarCharColumn;
            sp.XmlColumn = record.XmlColumn;
            sp.DateTimeColumn = record.DateTimeColumn;
            sp.SmallDateTimeColumn = record.SmallDateTimeColumn;
            sp.DateColumn = record.DateColumn;
            sp.TimeColumn = record.TimeColumn;
            sp.DateTime2Column = record.DateTime2Column;
            sp.DecimalColumn = record.DecimalColumn;
            sp.MoneyColumn = record.MoneyColumn;
            sp.SmallMoneyColumn = record.SmallMoneyColumn;
            sp.FloatColumn = record.FloatColumn;
            sp.IntColumn = record.IntColumn;
            sp.RealColumn = record.RealColumn;
            sp.UniqueIdentifierColumn = record.UniqueIdentifierColumn;
            sp.SmallIntColumn = record.SmallIntColumn;
            sp.TinyIntColumn = record.TinyIntColumn;
            sp.DateTimeOffsetColumn = record.DateTimeOffsetColumn;
            sp.SqlVariantColumn = record.SqlVariantColumn;
            sp.EnumColumn = record.EnumColumn;
            sp.NotNullBigIntColumn = record.NotNullBigIntColumn;
            sp.NotNullBinaryColumn = record.NotNullBinaryColumn;
            sp.NotNullImageColumn = record.NotNullImageColumn;
            sp.NotNullVarBinaryColumn = record.NotNullVarBinaryColumn;
            sp.NotNullBitColumn = record.NotNullBitColumn;
            sp.NotNullCharColumn = record.NotNullCharColumn;
            sp.NotNullNCharColumn = record.NotNullNCharColumn;
            sp.NotNullNTextColumn = record.NotNullNTextColumn;
            sp.NotNullNVarCharColumn = record.NotNullNVarCharColumn;
            sp.NotNullTextColumn = record.NotNullTextColumn;
            sp.NotNullVarCharColumn = record.NotNullVarCharColumn;
            sp.NotNullXmlColumn = record.NotNullXmlColumn;
            sp.NotNullDateTimeColumn = record.NotNullDateTimeColumn;
            sp.NotNullSmallDateTimeColumn = record.NotNullSmallDateTimeColumn;
            sp.NotNullDateColumn = record.NotNullDateColumn;
            sp.NotNullTimeColumn = record.NotNullTimeColumn;
            sp.NotNullDateTime2Column = record.NotNullDateTime2Column;
            sp.NotNullDecimalColumn = record.NotNullDecimalColumn;
            sp.NotNullMoneyColumn = record.NotNullMoneyColumn;
            sp.NotNullSmallMoneyColumn = record.NotNullSmallMoneyColumn;
            sp.NotNullFloatColumn = record.NotNullFloatColumn;
            sp.NotNullIntColumn = record.NotNullIntColumn;
            sp.NotNullRealColumn = record.NotNullRealColumn;
            sp.NotNullUniqueIdentifierColumn = record.NotNullUniqueIdentifierColumn;
            sp.NotNullSmallIntColumn = record.NotNullSmallIntColumn;
            sp.NotNullTinyIntColumn = record.NotNullTinyIntColumn;
            sp.NotNullDateTimeOffsetColumn = record.NotNullDateTimeOffsetColumn;
            sp.NotNullSqlVariantColumn = record.NotNullSqlVariantColumn;
            sp.NotNullEnumColumn = record.NotNullEnumColumn;
            sp.PK_PrimaryKeyColumn = record.OldRecord.PrimaryKeyColumn;
            sp.PK_TimestampColumn = record.OldRecord.TimestampColumn;
            return sp;
        }
        public AllDataTypeTableDelete CreateDeleteStoredProcedure(Record record)
        {
            var sp = new AllDataTypeTableDelete();
            if (record == null) return sp;
            if (record.OldRecord == null) throw new OldRecordIsNullException();
            sp.PK_PrimaryKeyColumn = record.OldRecord.PrimaryKeyColumn;
            sp.PK_TimestampColumn = record.OldRecord.TimestampColumn;
            return sp;
        }
        protected override DataTable CreateDataTable()
        {
            var dt = new DataTable(Name);
            dt.Columns.Add("@PK_PrimaryKeyColumn", typeof(Int64));
            dt.Columns.Add("@PrimaryKeyColumn", typeof(Int64));
            dt.Columns.Add("@TimestampColumn", typeof(Byte[]));
            dt.Columns.Add("@BigIntColumn", typeof(Int64));
            dt.Columns.Add("@BinaryColumn", typeof(Byte[]));
            dt.Columns.Add("@ImageColumn", typeof(Byte[]));
            dt.Columns.Add("@VarBinaryColumn", typeof(Byte[]));
            dt.Columns.Add("@BitColumn", typeof(Boolean));
            dt.Columns.Add("@CharColumn", typeof(String));
            dt.Columns.Add("@NCharColumn", typeof(String));
            dt.Columns.Add("@NTextColumn", typeof(String));
            dt.Columns.Add("@NVarCharColumn", typeof(String));
            dt.Columns.Add("@TextColumn", typeof(String));
            dt.Columns.Add("@VarCharColumn", typeof(String));
            dt.Columns.Add("@XmlColumn", typeof(String));
            dt.Columns.Add("@DateTimeColumn", typeof(DateTime));
            dt.Columns.Add("@SmallDateTimeColumn", typeof(DateTime));
            dt.Columns.Add("@DateColumn", typeof(DateOnly));
            dt.Columns.Add("@TimeColumn", typeof(TimeOnly));
            dt.Columns.Add("@DateTime2Column", typeof(DateTime));
            dt.Columns.Add("@DecimalColumn", typeof(Decimal));
            dt.Columns.Add("@MoneyColumn", typeof(Decimal));
            dt.Columns.Add("@SmallMoneyColumn", typeof(Decimal));
            dt.Columns.Add("@FloatColumn", typeof(Double));
            dt.Columns.Add("@IntColumn", typeof(Int32));
            dt.Columns.Add("@RealColumn", typeof(Single));
            dt.Columns.Add("@UniqueIdentifierColumn", typeof(Guid));
            dt.Columns.Add("@SmallIntColumn", typeof(Int16));
            dt.Columns.Add("@TinyIntColumn", typeof(Byte));
            dt.Columns.Add("@DateTimeOffsetColumn", typeof(DateTimeOffset));
            dt.Columns.Add("@SqlVariantColumn", typeof(Object));
            dt.Columns.Add("@EnumColumn", typeof(String));
            dt.Columns.Add("@NotNullBigIntColumn", typeof(Int64));
            dt.Columns.Add("@NotNullBinaryColumn", typeof(Byte[]));
            dt.Columns.Add("@NotNullImageColumn", typeof(Byte[]));
            dt.Columns.Add("@NotNullVarBinaryColumn", typeof(Byte[]));
            dt.Columns.Add("@NotNullBitColumn", typeof(Boolean));
            dt.Columns.Add("@NotNullCharColumn", typeof(String));
            dt.Columns.Add("@NotNullNCharColumn", typeof(String));
            dt.Columns.Add("@NotNullNTextColumn", typeof(String));
            dt.Columns.Add("@NotNullNVarCharColumn", typeof(String));
            dt.Columns.Add("@NotNullTextColumn", typeof(String));
            dt.Columns.Add("@NotNullVarCharColumn", typeof(String));
            dt.Columns.Add("@NotNullXmlColumn", typeof(String));
            dt.Columns.Add("@NotNullDateTimeColumn", typeof(DateTime));
            dt.Columns.Add("@NotNullSmallDateTimeColumn", typeof(DateTime));
            dt.Columns.Add("@NotNullDateColumn", typeof(DateOnly));
            dt.Columns.Add("@NotNullTimeColumn", typeof(TimeOnly));
            dt.Columns.Add("@NotNullDateTime2Column", typeof(DateTime));
            dt.Columns.Add("@NotNullDecimalColumn", typeof(Decimal));
            dt.Columns.Add("@NotNullMoneyColumn", typeof(Decimal));
            dt.Columns.Add("@NotNullSmallMoneyColumn", typeof(Decimal));
            dt.Columns.Add("@NotNullFloatColumn", typeof(Double));
            dt.Columns.Add("@NotNullIntColumn", typeof(Int32));
            dt.Columns.Add("@NotNullRealColumn", typeof(Single));
            dt.Columns.Add("@NotNullUniqueIdentifierColumn", typeof(Guid));
            dt.Columns.Add("@NotNullSmallIntColumn", typeof(Int16));
            dt.Columns.Add("@NotNullTinyIntColumn", typeof(Byte));
            dt.Columns.Add("@NotNullDateTimeOffsetColumn", typeof(DateTimeOffset));
            dt.Columns.Add("@NotNullSqlVariantColumn", typeof(Object));
            dt.Columns.Add("@NotNullEnumColumn", typeof(String));
            return dt;
        }
        protected override DataRow SetDataRow(DataRow dataRow, Record record, SaveMode saveMode)
        {
            if (saveMode != SaveMode.Insert)
            {
                if (record.OldRecord == null) throw new OldRecordIsNullException();
                dataRow["@PK_PrimaryKeyColumn"] = GetValueOrDBNull(record.OldRecord.PrimaryKeyColumn);
            }
            dataRow["@PrimaryKeyColumn"] = GetValueOrDBNull(record.PrimaryKeyColumn);
            dataRow["@TimestampColumn"] = GetValueOrDBNull(record.TimestampColumn);
            dataRow["@BigIntColumn"] = GetValueOrDBNull(record.BigIntColumn);
            dataRow["@BinaryColumn"] = GetValueOrDBNull(record.BinaryColumn);
            dataRow["@ImageColumn"] = GetValueOrDBNull(record.ImageColumn);
            dataRow["@VarBinaryColumn"] = GetValueOrDBNull(record.VarBinaryColumn);
            dataRow["@BitColumn"] = GetValueOrDBNull(record.BitColumn);
            dataRow["@CharColumn"] = GetValueOrDBNull(record.CharColumn);
            dataRow["@NCharColumn"] = GetValueOrDBNull(record.NCharColumn);
            dataRow["@NTextColumn"] = GetValueOrDBNull(record.NTextColumn);
            dataRow["@NVarCharColumn"] = GetValueOrDBNull(record.NVarCharColumn);
            dataRow["@TextColumn"] = GetValueOrDBNull(record.TextColumn);
            dataRow["@VarCharColumn"] = GetValueOrDBNull(record.VarCharColumn);
            dataRow["@XmlColumn"] = GetValueOrDBNull(record.XmlColumn);
            dataRow["@DateTimeColumn"] = GetValueOrDBNull(record.DateTimeColumn);
            dataRow["@SmallDateTimeColumn"] = GetValueOrDBNull(record.SmallDateTimeColumn);
            dataRow["@DateColumn"] = GetValueOrDBNull(record.DateColumn);
            dataRow["@TimeColumn"] = GetValueOrDBNull(record.TimeColumn);
            dataRow["@DateTime2Column"] = GetValueOrDBNull(record.DateTime2Column);
            dataRow["@DecimalColumn"] = GetValueOrDBNull(record.DecimalColumn);
            dataRow["@MoneyColumn"] = GetValueOrDBNull(record.MoneyColumn);
            dataRow["@SmallMoneyColumn"] = GetValueOrDBNull(record.SmallMoneyColumn);
            dataRow["@FloatColumn"] = GetValueOrDBNull(record.FloatColumn);
            dataRow["@IntColumn"] = GetValueOrDBNull(record.IntColumn);
            dataRow["@RealColumn"] = GetValueOrDBNull(record.RealColumn);
            dataRow["@UniqueIdentifierColumn"] = GetValueOrDBNull(record.UniqueIdentifierColumn);
            dataRow["@SmallIntColumn"] = GetValueOrDBNull(record.SmallIntColumn);
            dataRow["@TinyIntColumn"] = GetValueOrDBNull(record.TinyIntColumn);
            dataRow["@DateTimeOffsetColumn"] = GetValueOrDBNull(record.DateTimeOffsetColumn);
            dataRow["@SqlVariantColumn"] = GetValueOrDBNull(record.SqlVariantColumn);
            dataRow["@EnumColumn"] = GetValueOrDBNull(record.EnumColumn);
            dataRow["@NotNullBigIntColumn"] = GetValueOrDBNull(record.NotNullBigIntColumn);
            dataRow["@NotNullBinaryColumn"] = GetValueOrDBNull(record.NotNullBinaryColumn);
            dataRow["@NotNullImageColumn"] = GetValueOrDBNull(record.NotNullImageColumn);
            dataRow["@NotNullVarBinaryColumn"] = GetValueOrDBNull(record.NotNullVarBinaryColumn);
            dataRow["@NotNullBitColumn"] = GetValueOrDBNull(record.NotNullBitColumn);
            dataRow["@NotNullCharColumn"] = GetValueOrDBNull(record.NotNullCharColumn);
            dataRow["@NotNullNCharColumn"] = GetValueOrDBNull(record.NotNullNCharColumn);
            dataRow["@NotNullNTextColumn"] = GetValueOrDBNull(record.NotNullNTextColumn);
            dataRow["@NotNullNVarCharColumn"] = GetValueOrDBNull(record.NotNullNVarCharColumn);
            dataRow["@NotNullTextColumn"] = GetValueOrDBNull(record.NotNullTextColumn);
            dataRow["@NotNullVarCharColumn"] = GetValueOrDBNull(record.NotNullVarCharColumn);
            dataRow["@NotNullXmlColumn"] = GetValueOrDBNull(record.NotNullXmlColumn);
            dataRow["@NotNullDateTimeColumn"] = GetValueOrDBNull(record.NotNullDateTimeColumn);
            dataRow["@NotNullSmallDateTimeColumn"] = GetValueOrDBNull(record.NotNullSmallDateTimeColumn);
            dataRow["@NotNullDateColumn"] = GetValueOrDBNull(record.NotNullDateColumn);
            dataRow["@NotNullTimeColumn"] = GetValueOrDBNull(record.NotNullTimeColumn);
            dataRow["@NotNullDateTime2Column"] = GetValueOrDBNull(record.NotNullDateTime2Column);
            dataRow["@NotNullDecimalColumn"] = GetValueOrDBNull(record.NotNullDecimalColumn);
            dataRow["@NotNullMoneyColumn"] = GetValueOrDBNull(record.NotNullMoneyColumn);
            dataRow["@NotNullSmallMoneyColumn"] = GetValueOrDBNull(record.NotNullSmallMoneyColumn);
            dataRow["@NotNullFloatColumn"] = GetValueOrDBNull(record.NotNullFloatColumn);
            dataRow["@NotNullIntColumn"] = GetValueOrDBNull(record.NotNullIntColumn);
            dataRow["@NotNullRealColumn"] = GetValueOrDBNull(record.NotNullRealColumn);
            dataRow["@NotNullUniqueIdentifierColumn"] = GetValueOrDBNull(record.NotNullUniqueIdentifierColumn);
            dataRow["@NotNullSmallIntColumn"] = GetValueOrDBNull(record.NotNullSmallIntColumn);
            dataRow["@NotNullTinyIntColumn"] = GetValueOrDBNull(record.NotNullTinyIntColumn);
            dataRow["@NotNullDateTimeOffsetColumn"] = GetValueOrDBNull(record.NotNullDateTimeOffsetColumn);
            dataRow["@NotNullSqlVariantColumn"] = GetValueOrDBNull(record.NotNullSqlVariantColumn);
            dataRow["@NotNullEnumColumn"] = GetValueOrDBNull(record.NotNullEnumColumn);
            return dataRow;
        }
    }
}
