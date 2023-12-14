using Ado.Data.SqlServer;
using System;
using System.Data.SqlClient;

namespace Bezymyanny.Db.RijbewijstypeRepository
{
    public partial class RijbewijstypeDelete
    {
        private SqlServerTable table;
        public RijbewijstypeDelete(SqlServerTable table)
        {
            this.table = table;
        }
        public virtual void ByPrimaryKey(int rijbewijstypeid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Rijbewijstype] WHERE RijbewijstypeID=@RijbewijstypeID;";
                sqlCommand.Parameters.AddWithValue("@RijbewijstypeID", rijbewijstypeid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByRijbewijstypeID(int rijbewijstypeid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Rijbewijstype] WHERE RijbewijstypeID=@RijbewijstypeID;";
                sqlCommand.Parameters.AddWithValue("@RijbewijstypeID", rijbewijstypeid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByBeschrijving(string beschrijving)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Rijbewijstype] WHERE Beschrijving=@Beschrijving;";
                sqlCommand.Parameters.AddWithValue("@Beschrijving", beschrijving);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByIsDeleted(Nullable<bool> isdeleted)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Rijbewijstype] WHERE IsDeleted=@IsDeleted;";
                sqlCommand.Parameters.AddWithValue("@IsDeleted", isdeleted ?? (object)DBNull.Value);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
    }}