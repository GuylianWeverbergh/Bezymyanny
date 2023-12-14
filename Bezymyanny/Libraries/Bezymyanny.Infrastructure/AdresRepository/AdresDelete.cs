using Ado.Data.SqlServer;
using System;
using System.Data.SqlClient;

namespace Bezymyanny.Db.AdresRepository
{
    public partial class AdresDelete
    {
        private SqlServerTable table;
        public AdresDelete(SqlServerTable table)
        {
            this.table = table;
        }
        public virtual void ByPrimaryKey(int adresid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Adres] WHERE AdresID=@AdresID;";
                sqlCommand.Parameters.AddWithValue("@AdresID", adresid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByAdresID(int adresid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Adres] WHERE AdresID=@AdresID;";
                sqlCommand.Parameters.AddWithValue("@AdresID", adresid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByStraat(string straat)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Adres] WHERE Straat=@Straat;";
                sqlCommand.Parameters.AddWithValue("@Straat", straat);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByHuisnummer(string huisnummer)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Adres] WHERE Huisnummer=@Huisnummer;";
                sqlCommand.Parameters.AddWithValue("@Huisnummer", huisnummer);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByPostcode(string postcode)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Adres] WHERE Postcode=@Postcode;";
                sqlCommand.Parameters.AddWithValue("@Postcode", postcode);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByStad(string stad)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Adres] WHERE Stad=@Stad;";
                sqlCommand.Parameters.AddWithValue("@Stad", stad);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByLand(string land)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Adres] WHERE Land=@Land;";
                sqlCommand.Parameters.AddWithValue("@Land", land);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByIsDeleted(Nullable<bool> isdeleted)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Adres] WHERE IsDeleted=@IsDeleted;";
                sqlCommand.Parameters.AddWithValue("@IsDeleted", isdeleted ?? (object)DBNull.Value);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
    }}