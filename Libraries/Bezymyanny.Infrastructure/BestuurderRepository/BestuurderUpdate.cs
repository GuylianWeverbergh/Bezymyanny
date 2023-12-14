using Ado.Data.SqlServer;
using System;
using System.Data.SqlClient;

namespace Bezymyanny.Db.BestuurderRepository
{
    public partial class BestuurderUpdate
    {
        private SqlServerTable table;
        public BestuurderUpdate(SqlServerTable table)
        {
            this.table = table;
        }
        private void SetSqlCommandParameter(SqlCommand sqlCommand, Bestuurder bestuurder)
        {
            sqlCommand.Parameters.AddWithValue("@BestuurderID", bestuurder.BestuurderID);
            sqlCommand.Parameters.AddWithValue("@Naam", bestuurder.Naam);
            sqlCommand.Parameters.AddWithValue("@Voornaam", bestuurder.Voornaam);
            sqlCommand.Parameters.AddWithValue("@AdresID", bestuurder.AdresID ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@Geboortedatum", bestuurder.Geboortedatum ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@Rijksregisternummer", bestuurder.Rijksregisternummer);
            sqlCommand.Parameters.AddWithValue("@RijbewijstypeID", bestuurder.RijbewijstypeID);
            sqlCommand.Parameters.AddWithValue("@VoertuigID", bestuurder.VoertuigID ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@TankkaartID", bestuurder.TankkaartID ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@IsDeleted", bestuurder.IsDeleted ?? (object)DBNull.Value);
        }
        public virtual void ByPrimaryKey(Bestuurder bestuurder)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Bestuurder] SET Naam=@Naam, Voornaam=@Voornaam, AdresID=@AdresID, Geboortedatum=@Geboortedatum, Rijksregisternummer=@Rijksregisternummer, RijbewijstypeID=@RijbewijstypeID, VoertuigID=@VoertuigID, TankkaartID=@TankkaartID, IsDeleted=@IsDeleted WHERE BestuurderID=@BestuurderID;";
                SetSqlCommandParameter(sqlCommand, bestuurder);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByBestuurderID(Bestuurder bestuurder)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Bestuurder] SET Naam=@Naam, Voornaam=@Voornaam, AdresID=@AdresID, Geboortedatum=@Geboortedatum, Rijksregisternummer=@Rijksregisternummer, RijbewijstypeID=@RijbewijstypeID, VoertuigID=@VoertuigID, TankkaartID=@TankkaartID, IsDeleted=@IsDeleted WHERE BestuurderID=@BestuurderID;";
                SetSqlCommandParameter(sqlCommand, bestuurder);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByNaam(Bestuurder bestuurder)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Bestuurder] SET Voornaam=@Voornaam, AdresID=@AdresID, Geboortedatum=@Geboortedatum, Rijksregisternummer=@Rijksregisternummer, RijbewijstypeID=@RijbewijstypeID, VoertuigID=@VoertuigID, TankkaartID=@TankkaartID, IsDeleted=@IsDeleted WHERE Naam=@Naam;";
                SetSqlCommandParameter(sqlCommand, bestuurder);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByVoornaam(Bestuurder bestuurder)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Bestuurder] SET Naam=@Naam, AdresID=@AdresID, Geboortedatum=@Geboortedatum, Rijksregisternummer=@Rijksregisternummer, RijbewijstypeID=@RijbewijstypeID, VoertuigID=@VoertuigID, TankkaartID=@TankkaartID, IsDeleted=@IsDeleted WHERE Voornaam=@Voornaam;";
                SetSqlCommandParameter(sqlCommand, bestuurder);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByAdresID(Bestuurder bestuurder)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Bestuurder] SET Naam=@Naam, Voornaam=@Voornaam, Geboortedatum=@Geboortedatum, Rijksregisternummer=@Rijksregisternummer, RijbewijstypeID=@RijbewijstypeID, VoertuigID=@VoertuigID, TankkaartID=@TankkaartID, IsDeleted=@IsDeleted WHERE AdresID=@AdresID;";
                SetSqlCommandParameter(sqlCommand, bestuurder);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByGeboortedatum(Bestuurder bestuurder)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Bestuurder] SET Naam=@Naam, Voornaam=@Voornaam, AdresID=@AdresID, Rijksregisternummer=@Rijksregisternummer, RijbewijstypeID=@RijbewijstypeID, VoertuigID=@VoertuigID, TankkaartID=@TankkaartID, IsDeleted=@IsDeleted WHERE Geboortedatum=@Geboortedatum;";
                SetSqlCommandParameter(sqlCommand, bestuurder);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByRijksregisternummer(Bestuurder bestuurder)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Bestuurder] SET Naam=@Naam, Voornaam=@Voornaam, AdresID=@AdresID, Geboortedatum=@Geboortedatum, RijbewijstypeID=@RijbewijstypeID, VoertuigID=@VoertuigID, TankkaartID=@TankkaartID, IsDeleted=@IsDeleted WHERE Rijksregisternummer=@Rijksregisternummer;";
                SetSqlCommandParameter(sqlCommand, bestuurder);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByRijbewijstypeID(Bestuurder bestuurder)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Bestuurder] SET Naam=@Naam, Voornaam=@Voornaam, AdresID=@AdresID, Geboortedatum=@Geboortedatum, Rijksregisternummer=@Rijksregisternummer, VoertuigID=@VoertuigID, TankkaartID=@TankkaartID, IsDeleted=@IsDeleted WHERE RijbewijstypeID=@RijbewijstypeID;";
                SetSqlCommandParameter(sqlCommand, bestuurder);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByVoertuigID(Bestuurder bestuurder)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Bestuurder] SET Naam=@Naam, Voornaam=@Voornaam, AdresID=@AdresID, Geboortedatum=@Geboortedatum, Rijksregisternummer=@Rijksregisternummer, RijbewijstypeID=@RijbewijstypeID, TankkaartID=@TankkaartID, IsDeleted=@IsDeleted WHERE VoertuigID=@VoertuigID;";
                SetSqlCommandParameter(sqlCommand, bestuurder);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByTankkaartID(Bestuurder bestuurder)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Bestuurder] SET Naam=@Naam, Voornaam=@Voornaam, AdresID=@AdresID, Geboortedatum=@Geboortedatum, Rijksregisternummer=@Rijksregisternummer, RijbewijstypeID=@RijbewijstypeID, VoertuigID=@VoertuigID, IsDeleted=@IsDeleted WHERE TankkaartID=@TankkaartID;";
                SetSqlCommandParameter(sqlCommand, bestuurder);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByIsDeleted(Bestuurder bestuurder)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Bestuurder] SET Naam=@Naam, Voornaam=@Voornaam, AdresID=@AdresID, Geboortedatum=@Geboortedatum, Rijksregisternummer=@Rijksregisternummer, RijbewijstypeID=@RijbewijstypeID, VoertuigID=@VoertuigID, TankkaartID=@TankkaartID WHERE IsDeleted=@IsDeleted;";
                SetSqlCommandParameter(sqlCommand, bestuurder);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void NaamByPrimaryKey(string naam, int bestuurderid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Bestuurder] SET Naam=@Naam WHERE BestuurderID=@BestuurderID;";
                sqlCommand.Parameters.AddWithValue("@Naam", naam);
                sqlCommand.Parameters.AddWithValue("@BestuurderID", bestuurderid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void VoornaamByPrimaryKey(string voornaam, int bestuurderid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Bestuurder] SET Voornaam=@Voornaam WHERE BestuurderID=@BestuurderID;";
                sqlCommand.Parameters.AddWithValue("@Voornaam", voornaam);
                sqlCommand.Parameters.AddWithValue("@BestuurderID", bestuurderid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void AdresIDByPrimaryKey(Nullable<int> adresid, int bestuurderid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Bestuurder] SET AdresID=@AdresID WHERE BestuurderID=@BestuurderID;";
                sqlCommand.Parameters.AddWithValue("@AdresID", adresid ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@BestuurderID", bestuurderid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void GeboortedatumByPrimaryKey(Nullable<DateTime> geboortedatum, int bestuurderid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Bestuurder] SET Geboortedatum=@Geboortedatum WHERE BestuurderID=@BestuurderID;";
                sqlCommand.Parameters.AddWithValue("@Geboortedatum", geboortedatum ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@BestuurderID", bestuurderid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void RijksregisternummerByPrimaryKey(string rijksregisternummer, int bestuurderid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Bestuurder] SET Rijksregisternummer=@Rijksregisternummer WHERE BestuurderID=@BestuurderID;";
                sqlCommand.Parameters.AddWithValue("@Rijksregisternummer", rijksregisternummer);
                sqlCommand.Parameters.AddWithValue("@BestuurderID", bestuurderid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void RijbewijstypeIDByPrimaryKey(int rijbewijstypeid, int bestuurderid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Bestuurder] SET RijbewijstypeID=@RijbewijstypeID WHERE BestuurderID=@BestuurderID;";
                sqlCommand.Parameters.AddWithValue("@RijbewijstypeID", rijbewijstypeid);
                sqlCommand.Parameters.AddWithValue("@BestuurderID", bestuurderid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void VoertuigIDByPrimaryKey(Nullable<int> voertuigid, int bestuurderid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Bestuurder] SET VoertuigID=@VoertuigID WHERE BestuurderID=@BestuurderID;";
                sqlCommand.Parameters.AddWithValue("@VoertuigID", voertuigid ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@BestuurderID", bestuurderid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void TankkaartIDByPrimaryKey(Nullable<int> tankkaartid, int bestuurderid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Bestuurder] SET TankkaartID=@TankkaartID WHERE BestuurderID=@BestuurderID;";
                sqlCommand.Parameters.AddWithValue("@TankkaartID", tankkaartid ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@BestuurderID", bestuurderid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void IsDeletedByPrimaryKey(Nullable<bool> isdeleted, int bestuurderid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Bestuurder] SET IsDeleted=@IsDeleted WHERE BestuurderID=@BestuurderID;";
                sqlCommand.Parameters.AddWithValue("@IsDeleted", isdeleted ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@BestuurderID", bestuurderid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
    }}