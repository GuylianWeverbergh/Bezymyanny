using Ado.Data.SqlServer;
using System;
using System.Data.SqlClient;

namespace Bezymyanny.Db.RijbewijstypeRepository
{
    public partial class RijbewijstypeInsert
    {
        private SqlServerTable table;
        public RijbewijstypeInsert(SqlServerTable table)
        {
            this.table = table;
        }
        public virtual void NewRecord(Rijbewijstype rijbewijstype)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "INSERT INTO [Rijbewijstype] (Beschrijving, IsDeleted) VALUES (@Beschrijving, @IsDeleted); SELECT SCOPE_IDENTITY() AS INT;";
                sqlCommand.Parameters.AddWithValue("@Beschrijving", rijbewijstype.Beschrijving);
                sqlCommand.Parameters.AddWithValue("@IsDeleted", rijbewijstype.IsDeleted ?? (object)DBNull.Value);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
    }}