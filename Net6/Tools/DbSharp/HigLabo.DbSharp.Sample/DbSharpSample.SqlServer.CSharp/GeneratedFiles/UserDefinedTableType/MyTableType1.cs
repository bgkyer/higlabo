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
    public partial class MyTableType1 : UserDefinedTableType<MyTableType1.Record>
    {
        public override SqlDataRecord CreateSqlDataRecord()
        {
            SqlMetaData[] metaData = new SqlMetaData[4];
            metaData[0] = new SqlMetaData("BigIntColumn", SqlDbType.BigInt);
            metaData[1] = new SqlMetaData("BinaryColumn", SqlDbType.Binary, 100);
            metaData[2] = new SqlMetaData("ImageColumn", SqlDbType.Image);
            metaData[3] = new SqlMetaData("VarBinaryColumn", SqlDbType.VarBinary, 100);
            return new SqlDataRecord(metaData);
        }

        public partial class Record : UserDefinedTableTypeRecord
        {
            private Int64 _BigIntColumn;
            private Byte[] _BinaryColumn;
            private Byte[] _ImageColumn;
            private Byte[] _VarBinaryColumn;

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

            public Record()
            {
            }

            public override Object[] GetValues()
            {
                Object[] oo = new Object[4];
                oo[0] = this.BigIntColumn;
                oo[1] = this.BinaryColumn;
                oo[2] = this.ImageColumn;
                oo[3] = this.VarBinaryColumn;
                return oo;
            }
        }
    }
}
