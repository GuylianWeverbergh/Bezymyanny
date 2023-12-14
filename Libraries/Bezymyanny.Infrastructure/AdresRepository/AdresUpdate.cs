using Ado.Data.SqlServer;
using System;
using System.Data.SqlClient;

namespace Bezymyanny.Db.AdresRepository
{
    public partial class AdresUpdate
    {
        private SqlServerTable table;
        public AdresUpdate(SqlServerTable table)
        {
            this.table = table;
        }
        private void SetSqlCommandParameter(SqlCommand sqlCommand, Adres adres)
        {
            sqlCommand.Parameters.AddWithValue("@AdresID", adres.AdresID);
            sqlCommand.Parameters.AddWithValue("@Straat", adres.Straat);
            sqlCommand.Parameters.AddWithValue("@Huisnummer", adres.Huisnummer);
            sqlCommand.Parameters.AddWithValue("@Postcode", adres.Postcode);
            sqlCommand.Parameters.AddWithValue("@Stad", adres.Stad);
            sqlCommand.Parameters.AddWithValue("@Land", adres.Land);
            sqlCommand.Parameters.AddWithValue("@IsDeleted", adres.IsDeleted ?? (object)DBNull.Value);
        }
        public virtual void ByPrimaryKey(Adres adres)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Adres] SET Straat=@Straat, Huisnummer=@Huisnummer, Postcode=@Postcode, Stad=@Stad, Land=@Land, IsDeleted=@IsDeleted WHERE AdresID=@AdresID;";
                SetSqlCommandParameter(sqlCommand, adres);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByAdresID(Adres adres)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Adres] SET Straat=@Straat, Huisnummer=@Huisnummer, Postcode=@Postcode, Stad=@Stad, Land=@Land, IsDeleted=@IsDeleted WHERE AdresID=@AdresID;";
                SetSqlCommandParameter(sqlCommand, adres);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByStraat(Adres adres)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Adres] SET Huisnummer=@Huisnummer, Postcode=@Postcode, Stad=@Stad, Land=@Land, IsDeleted=@IsDeleted WHERE Straat=@Straat;";
                SetSqlCommandParameter(sqlCommand, adres);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByHuisnummer(Adres adres)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Adres] SET Straat=@Straat, Postcode=@Postcode, Stad=@Stad, Land=@Land, IsDeleted=@IsDeleted WHERE Huisnummer=@Huisnummer;";
                SetSqlCommandParameter(sqlCommand, adres);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByPostcode(Adres adres)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Adres] SET Straat=@Straat, Huisnummer=@Huisnummer, Stad=@Stad, Land=@Land, IsDeleted=@IsDeleted WHERE Postcode=@Postcode;";
                SetSqlCommandParameter(sqlCommand, adres);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByStad(Adres adres)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Adres] SET Straat=@Straat, Huisnummer=@Huisnummer, Postcode=@Postcode, Land=@Land, IsDeleted=@IsDeleted WHERE Stad=@Stad;";
                SetSqlCommandParameter(sqlCommand, adres);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByLand(Adres adres)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Adres] SET Straat=@Straat, Huisnummer=@Huisnummer, Postcode=@Postcode, Stad=@Stad, IsDeleted=@IsDeleted WHERE Land=@Land;";
                SetSqlCommandParameter(sqlCommand, adres);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByIsDeleted(Adres adres)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Adres] SET Straat=@Straat, Huisnummer=@Huisnummer, Postcode=@Postcode, Stad=@Stad, Land=@Land WHERE IsDeleted=@IsDeleted;";
                SetSqlCommandParameter(sqlCommand, adres);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void StraatByPrimaryKey(string straat, int adresid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Adres] SET Straat=@Straat WHERE AdresID=@AdresID;";
                sqlCommand.Parameters.AddWithValue("@Straat", straat);
                sqlCommand.Parameters.AddWithValue("@AdresID", adresid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void HuisnummerByPrimaryKey(string huisnummer, int adresid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Adres] SET Huisnummer=@Huisnummer WHERE AdresID=@AdresID;";
                sqlCommand.Parameters.AddWithValue("@Huisnummer", huisnummer);
                sqlCommand.Parameters.AddWithValue("@AdresID", adresid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void PostcodeByPrimaryKey(string postcode, int adresid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Adres] SET Postcode=@Postcode WHERE AdresID=@AdresID;";
                sqlCommand.Parameters.AddWithValue("@Postcode", postcode);
                sqlCommand.Parameters.AddWithValue("@AdresID", adresid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void StadByPrimaryKey(string stad, int adresid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Adres] SET Stad=@Stad WHERE AdresID=@AdresID;";
                sqlCommand.Parameters.AddWithValue("@Stad", stad);
                sqlCommand.Parameters.AddWithValue("@AdresID", adresid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void LandByPrimaryKey(string land, int adresid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Adres] SET Land=@Land WHERE AdresID=@AdresID;";
                sqlCommand.Parameters.AddWithValue("@Land", land);
                sqlCommand.Parameters.AddWithValue("@AdresID", adresid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void IsDeletedByPrimaryKey(Nullable<bool> isdeleted, int adresid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Adres] SET IsDeleted=@IsDeleted WHERE AdresID=@AdresID;";
                sqlCommand.Parameters.AddWithValue("@IsDeleted", isdeleted ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@AdresID", adresid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
    }}