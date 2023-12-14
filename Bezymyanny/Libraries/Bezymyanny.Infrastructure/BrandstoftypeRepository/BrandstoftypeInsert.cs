using Ado.Data.SqlServer;
using System;
using System.Data.SqlClient;

namespace Bezymyanny.Db.BrandstoftypeRepository
{
    public partial class BrandstoftypeInsert
    {
        private SqlServerTable table;
        public BrandstoftypeInsert(SqlServerTable table)
        {
            this.table = table;
        }
        public virtual void NewRecord(Brandstoftype brandstoftype)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "INSERT INTO [Brandstoftype] (Beschrijving, IsDeleted) VALUES (@Beschrijving, @IsDeleted); SELECT SCOPE_IDENTITY() AS INT;";
                sqlCommand.Parameters.AddWithValue("@Beschrijving", brandstoftype.Beschrijving);
                sqlCommand.Parameters.AddWithValue("@IsDeleted", brandstoftype.IsDeleted ?? (object)DBNull.Value);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
    }}