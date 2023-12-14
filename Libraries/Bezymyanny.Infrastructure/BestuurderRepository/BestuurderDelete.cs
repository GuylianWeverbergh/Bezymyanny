using Ado.Data.SqlServer;
using System;
using System.Data.SqlClient;

namespace Bezymyanny.Db.BestuurderRepository
{
    public partial class BestuurderDelete
    {
        private SqlServerTable table;
        public BestuurderDelete(SqlServerTable table)
        {
            this.table = table;
        }
        public virtual void ByPrimaryKey(int bestuurderid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Bestuurder] WHERE BestuurderID=@BestuurderID;";
                sqlCommand.Parameters.AddWithValue("@BestuurderID", bestuurderid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByBestuurderID(int bestuurderid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Bestuurder] WHERE BestuurderID=@BestuurderID;";
                sqlCommand.Parameters.AddWithValue("@BestuurderID", bestuurderid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByNaam(string naam)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Bestuurder] WHERE Naam=@Naam;";
                sqlCommand.Parameters.AddWithValue("@Naam", naam);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByVoornaam(string voornaam)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Bestuurder] WHERE Voornaam=@Voornaam;";
                sqlCommand.Parameters.AddWithValue("@Voornaam", voornaam);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByAdresID(Nullable<int> adresid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Bestuurder] WHERE AdresID=@AdresID;";
                sqlCommand.Parameters.AddWithValue("@AdresID", adresid ?? (object)DBNull.Value);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByGeboortedatum(Nullable<DateTime> geboortedatum)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Bestuurder] WHERE Geboortedatum=@Geboortedatum;";
                sqlCommand.Parameters.AddWithValue("@Geboortedatum", geboortedatum ?? (object)DBNull.Value);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByRijksregisternummer(string rijksregisternummer)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Bestuurder] WHERE Rijksregisternummer=@Rijksregisternummer;";
                sqlCommand.Parameters.AddWithValue("@Rijksregisternummer", rijksregisternummer);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByRijbewijstypeID(int rijbewijstypeid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Bestuurder] WHERE RijbewijstypeID=@RijbewijstypeID;";
                sqlCommand.Parameters.AddWithValue("@RijbewijstypeID", rijbewijstypeid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByVoertuigID(Nullable<int> voertuigid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Bestuurder] WHERE VoertuigID=@VoertuigID;";
                sqlCommand.Parameters.AddWithValue("@VoertuigID", voertuigid ?? (object)DBNull.Value);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByTankkaartID(Nullable<int> tankkaartid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Bestuurder] WHERE TankkaartID=@TankkaartID;";
                sqlCommand.Parameters.AddWithValue("@TankkaartID", tankkaartid ?? (object)DBNull.Value);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByIsDeleted(Nullable<bool> isdeleted)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Bestuurder] WHERE IsDeleted=@IsDeleted;";
                sqlCommand.Parameters.AddWithValue("@IsDeleted", isdeleted ?? (object)DBNull.Value);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
    }}