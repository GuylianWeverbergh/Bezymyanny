using Ado.Data.SqlServer;
using System;
using System.Data.SqlClient;

namespace Bezymyanny.Db.AdresRepository
{
    public partial class AdresInsert
    {
        private SqlServerTable table;
        public AdresInsert(SqlServerTable table)
        {
            this.table = table;
        }
        public virtual void NewRecord(Adres adres)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "INSERT INTO [Adres] (Straat, Huisnummer, Postcode, Stad, Land, IsDeleted) VALUES (@Straat, @Huisnummer, @Postcode, @Stad, @Land, @IsDeleted); SELECT SCOPE_IDENTITY() AS INT;";
                sqlCommand.Parameters.AddWithValue("@Straat", adres.Straat);
                sqlCommand.Parameters.AddWithValue("@Huisnummer", adres.Huisnummer);
                sqlCommand.Parameters.AddWithValue("@Postcode", adres.Postcode);
                sqlCommand.Parameters.AddWithValue("@Stad", adres.Stad);
                sqlCommand.Parameters.AddWithValue("@Land", adres.Land);
                sqlCommand.Parameters.AddWithValue("@IsDeleted", adres.IsDeleted ?? (object)DBNull.Value);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
    }}