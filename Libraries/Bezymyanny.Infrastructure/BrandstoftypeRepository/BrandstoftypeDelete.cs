using Ado.Data.SqlServer;
using System;
using System.Data.SqlClient;

namespace Bezymyanny.Db.BrandstoftypeRepository
{
    public partial class BrandstoftypeDelete
    {
        private SqlServerTable table;
        public BrandstoftypeDelete(SqlServerTable table)
        {
            this.table = table;
        }
        public virtual void ByPrimaryKey(int brandstoftypeid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Brandstoftype] WHERE BrandstoftypeID=@BrandstoftypeID;";
                sqlCommand.Parameters.AddWithValue("@BrandstoftypeID", brandstoftypeid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByBrandstoftypeID(int brandstoftypeid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Brandstoftype] WHERE BrandstoftypeID=@BrandstoftypeID;";
                sqlCommand.Parameters.AddWithValue("@BrandstoftypeID", brandstoftypeid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByBeschrijving(string beschrijving)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Brandstoftype] WHERE Beschrijving=@Beschrijving;";
                sqlCommand.Parameters.AddWithValue("@Beschrijving", beschrijving);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByIsDeleted(Nullable<bool> isdeleted)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Brandstoftype] WHERE IsDeleted=@IsDeleted;";
                sqlCommand.Parameters.AddWithValue("@IsDeleted", isdeleted ?? (object)DBNull.Value);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
    }}