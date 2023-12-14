using Ado.Data.SqlServer;
using System;
using System.Data.SqlClient;

namespace Bezymyanny.Db.BrandstoftypeRepository
{
    public partial class BrandstoftypeUpdate
    {
        private SqlServerTable table;
        public BrandstoftypeUpdate(SqlServerTable table)
        {
            this.table = table;
        }
        private void SetSqlCommandParameter(SqlCommand sqlCommand, Brandstoftype brandstoftype)
        {
            sqlCommand.Parameters.AddWithValue("@BrandstoftypeID", brandstoftype.BrandstoftypeID);
            sqlCommand.Parameters.AddWithValue("@Beschrijving", brandstoftype.Beschrijving);
            sqlCommand.Parameters.AddWithValue("@IsDeleted", brandstoftype.IsDeleted ?? (object)DBNull.Value);
        }
        public virtual void ByPrimaryKey(Brandstoftype brandstoftype)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Brandstoftype] SET Beschrijving=@Beschrijving, IsDeleted=@IsDeleted WHERE BrandstoftypeID=@BrandstoftypeID;";
                SetSqlCommandParameter(sqlCommand, brandstoftype);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByBrandstoftypeID(Brandstoftype brandstoftype)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Brandstoftype] SET Beschrijving=@Beschrijving, IsDeleted=@IsDeleted WHERE BrandstoftypeID=@BrandstoftypeID;";
                SetSqlCommandParameter(sqlCommand, brandstoftype);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByBeschrijving(Brandstoftype brandstoftype)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Brandstoftype] SET IsDeleted=@IsDeleted WHERE Beschrijving=@Beschrijving;";
                SetSqlCommandParameter(sqlCommand, brandstoftype);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByIsDeleted(Brandstoftype brandstoftype)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Brandstoftype] SET Beschrijving=@Beschrijving WHERE IsDeleted=@IsDeleted;";
                SetSqlCommandParameter(sqlCommand, brandstoftype);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void BeschrijvingByPrimaryKey(string beschrijving, int brandstoftypeid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Brandstoftype] SET Beschrijving=@Beschrijving WHERE BrandstoftypeID=@BrandstoftypeID;";
                sqlCommand.Parameters.AddWithValue("@Beschrijving", beschrijving);
                sqlCommand.Parameters.AddWithValue("@BrandstoftypeID", brandstoftypeid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void IsDeletedByPrimaryKey(Nullable<bool> isdeleted, int brandstoftypeid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Brandstoftype] SET IsDeleted=@IsDeleted WHERE BrandstoftypeID=@BrandstoftypeID;";
                sqlCommand.Parameters.AddWithValue("@IsDeleted", isdeleted ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@BrandstoftypeID", brandstoftypeid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
    }}