using Ado.Data.SqlServer;
using System;
using System.Data.SqlClient;

namespace Bezymyanny.Db.RijbewijstypeRepository
{
    public partial class RijbewijstypeUpdate
    {
        private SqlServerTable table;
        public RijbewijstypeUpdate(SqlServerTable table)
        {
            this.table = table;
        }
        private void SetSqlCommandParameter(SqlCommand sqlCommand, Rijbewijstype rijbewijstype)
        {
            sqlCommand.Parameters.AddWithValue("@RijbewijstypeID", rijbewijstype.RijbewijstypeID);
            sqlCommand.Parameters.AddWithValue("@Beschrijving", rijbewijstype.Beschrijving);
            sqlCommand.Parameters.AddWithValue("@IsDeleted", rijbewijstype.IsDeleted ?? (object)DBNull.Value);
        }
        public virtual void ByPrimaryKey(Rijbewijstype rijbewijstype)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Rijbewijstype] SET Beschrijving=@Beschrijving, IsDeleted=@IsDeleted WHERE RijbewijstypeID=@RijbewijstypeID;";
                SetSqlCommandParameter(sqlCommand, rijbewijstype);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByRijbewijstypeID(Rijbewijstype rijbewijstype)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Rijbewijstype] SET Beschrijving=@Beschrijving, IsDeleted=@IsDeleted WHERE RijbewijstypeID=@RijbewijstypeID;";
                SetSqlCommandParameter(sqlCommand, rijbewijstype);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByBeschrijving(Rijbewijstype rijbewijstype)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Rijbewijstype] SET IsDeleted=@IsDeleted WHERE Beschrijving=@Beschrijving;";
                SetSqlCommandParameter(sqlCommand, rijbewijstype);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByIsDeleted(Rijbewijstype rijbewijstype)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Rijbewijstype] SET Beschrijving=@Beschrijving WHERE IsDeleted=@IsDeleted;";
                SetSqlCommandParameter(sqlCommand, rijbewijstype);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void BeschrijvingByPrimaryKey(string beschrijving, int rijbewijstypeid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Rijbewijstype] SET Beschrijving=@Beschrijving WHERE RijbewijstypeID=@RijbewijstypeID;";
                sqlCommand.Parameters.AddWithValue("@Beschrijving", beschrijving);
                sqlCommand.Parameters.AddWithValue("@RijbewijstypeID", rijbewijstypeid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void IsDeletedByPrimaryKey(Nullable<bool> isdeleted, int rijbewijstypeid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Rijbewijstype] SET IsDeleted=@IsDeleted WHERE RijbewijstypeID=@RijbewijstypeID;";
                sqlCommand.Parameters.AddWithValue("@IsDeleted", isdeleted ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@RijbewijstypeID", rijbewijstypeid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
    }}