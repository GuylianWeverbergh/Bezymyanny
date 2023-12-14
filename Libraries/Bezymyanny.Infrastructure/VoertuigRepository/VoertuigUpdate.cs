using Ado.Data.SqlServer;
using System;
using System.Data.SqlClient;

namespace Bezymyanny.Db.VoertuigRepository
{
    public partial class VoertuigUpdate
    {
        private SqlServerTable table;
        public VoertuigUpdate(SqlServerTable table)
        {
            this.table = table;
        }
        private void SetSqlCommandParameter(SqlCommand sqlCommand, Voertuig voertuig)
        {
            sqlCommand.Parameters.AddWithValue("@VoertuigID", voertuig.VoertuigID);
            sqlCommand.Parameters.AddWithValue("@Merk", voertuig.Merk);
            sqlCommand.Parameters.AddWithValue("@Model", voertuig.Model);
            sqlCommand.Parameters.AddWithValue("@Chassisnummer", voertuig.Chassisnummer);
            sqlCommand.Parameters.AddWithValue("@Nummerplaat", voertuig.Nummerplaat);
            sqlCommand.Parameters.AddWithValue("@BrandstoftypeId", voertuig.BrandstoftypeId);
            sqlCommand.Parameters.AddWithValue("@Kleur", voertuig.Kleur ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@AantalDeuren", voertuig.AantalDeuren ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@BestuurderID", voertuig.BestuurderID ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@IsDeleted", voertuig.IsDeleted ?? (object)DBNull.Value);
        }
        public virtual void ByPrimaryKey(Voertuig voertuig)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Voertuig] SET Merk=@Merk, Model=@Model, Chassisnummer=@Chassisnummer, Nummerplaat=@Nummerplaat, BrandstoftypeId=@BrandstoftypeId, Kleur=@Kleur, AantalDeuren=@AantalDeuren, BestuurderID=@BestuurderID, IsDeleted=@IsDeleted WHERE VoertuigID=@VoertuigID;";
                SetSqlCommandParameter(sqlCommand, voertuig);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByVoertuigID(Voertuig voertuig)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Voertuig] SET Merk=@Merk, Model=@Model, Chassisnummer=@Chassisnummer, Nummerplaat=@Nummerplaat, BrandstoftypeId=@BrandstoftypeId, Kleur=@Kleur, AantalDeuren=@AantalDeuren, BestuurderID=@BestuurderID, IsDeleted=@IsDeleted WHERE VoertuigID=@VoertuigID;";
                SetSqlCommandParameter(sqlCommand, voertuig);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByMerk(Voertuig voertuig)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Voertuig] SET Model=@Model, Chassisnummer=@Chassisnummer, Nummerplaat=@Nummerplaat, BrandstoftypeId=@BrandstoftypeId, Kleur=@Kleur, AantalDeuren=@AantalDeuren, BestuurderID=@BestuurderID, IsDeleted=@IsDeleted WHERE Merk=@Merk;";
                SetSqlCommandParameter(sqlCommand, voertuig);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByModel(Voertuig voertuig)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Voertuig] SET Merk=@Merk, Chassisnummer=@Chassisnummer, Nummerplaat=@Nummerplaat, BrandstoftypeId=@BrandstoftypeId, Kleur=@Kleur, AantalDeuren=@AantalDeuren, BestuurderID=@BestuurderID, IsDeleted=@IsDeleted WHERE Model=@Model;";
                SetSqlCommandParameter(sqlCommand, voertuig);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByChassisnummer(Voertuig voertuig)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Voertuig] SET Merk=@Merk, Model=@Model, Nummerplaat=@Nummerplaat, BrandstoftypeId=@BrandstoftypeId, Kleur=@Kleur, AantalDeuren=@AantalDeuren, BestuurderID=@BestuurderID, IsDeleted=@IsDeleted WHERE Chassisnummer=@Chassisnummer;";
                SetSqlCommandParameter(sqlCommand, voertuig);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByNummerplaat(Voertuig voertuig)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Voertuig] SET Merk=@Merk, Model=@Model, Chassisnummer=@Chassisnummer, BrandstoftypeId=@BrandstoftypeId, Kleur=@Kleur, AantalDeuren=@AantalDeuren, BestuurderID=@BestuurderID, IsDeleted=@IsDeleted WHERE Nummerplaat=@Nummerplaat;";
                SetSqlCommandParameter(sqlCommand, voertuig);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByBrandstoftypeId(Voertuig voertuig)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Voertuig] SET Merk=@Merk, Model=@Model, Chassisnummer=@Chassisnummer, Nummerplaat=@Nummerplaat, Kleur=@Kleur, AantalDeuren=@AantalDeuren, BestuurderID=@BestuurderID, IsDeleted=@IsDeleted WHERE BrandstoftypeId=@BrandstoftypeId;";
                SetSqlCommandParameter(sqlCommand, voertuig);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByKleur(Voertuig voertuig)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Voertuig] SET Merk=@Merk, Model=@Model, Chassisnummer=@Chassisnummer, Nummerplaat=@Nummerplaat, BrandstoftypeId=@BrandstoftypeId, AantalDeuren=@AantalDeuren, BestuurderID=@BestuurderID, IsDeleted=@IsDeleted WHERE Kleur=@Kleur;";
                SetSqlCommandParameter(sqlCommand, voertuig);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByAantalDeuren(Voertuig voertuig)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Voertuig] SET Merk=@Merk, Model=@Model, Chassisnummer=@Chassisnummer, Nummerplaat=@Nummerplaat, BrandstoftypeId=@BrandstoftypeId, Kleur=@Kleur, BestuurderID=@BestuurderID, IsDeleted=@IsDeleted WHERE AantalDeuren=@AantalDeuren;";
                SetSqlCommandParameter(sqlCommand, voertuig);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByBestuurderID(Voertuig voertuig)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Voertuig] SET Merk=@Merk, Model=@Model, Chassisnummer=@Chassisnummer, Nummerplaat=@Nummerplaat, BrandstoftypeId=@BrandstoftypeId, Kleur=@Kleur, AantalDeuren=@AantalDeuren, IsDeleted=@IsDeleted WHERE BestuurderID=@BestuurderID;";
                SetSqlCommandParameter(sqlCommand, voertuig);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByIsDeleted(Voertuig voertuig)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Voertuig] SET Merk=@Merk, Model=@Model, Chassisnummer=@Chassisnummer, Nummerplaat=@Nummerplaat, BrandstoftypeId=@BrandstoftypeId, Kleur=@Kleur, AantalDeuren=@AantalDeuren, BestuurderID=@BestuurderID WHERE IsDeleted=@IsDeleted;";
                SetSqlCommandParameter(sqlCommand, voertuig);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void MerkByPrimaryKey(string merk, int voertuigid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Voertuig] SET Merk=@Merk WHERE VoertuigID=@VoertuigID;";
                sqlCommand.Parameters.AddWithValue("@Merk", merk);
                sqlCommand.Parameters.AddWithValue("@VoertuigID", voertuigid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ModelByPrimaryKey(string model, int voertuigid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Voertuig] SET Model=@Model WHERE VoertuigID=@VoertuigID;";
                sqlCommand.Parameters.AddWithValue("@Model", model);
                sqlCommand.Parameters.AddWithValue("@VoertuigID", voertuigid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ChassisnummerByPrimaryKey(string chassisnummer, int voertuigid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Voertuig] SET Chassisnummer=@Chassisnummer WHERE VoertuigID=@VoertuigID;";
                sqlCommand.Parameters.AddWithValue("@Chassisnummer", chassisnummer);
                sqlCommand.Parameters.AddWithValue("@VoertuigID", voertuigid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void NummerplaatByPrimaryKey(string nummerplaat, int voertuigid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Voertuig] SET Nummerplaat=@Nummerplaat WHERE VoertuigID=@VoertuigID;";
                sqlCommand.Parameters.AddWithValue("@Nummerplaat", nummerplaat);
                sqlCommand.Parameters.AddWithValue("@VoertuigID", voertuigid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void BrandstoftypeIdByPrimaryKey(int brandstoftypeid, int voertuigid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Voertuig] SET BrandstoftypeId=@BrandstoftypeId WHERE VoertuigID=@VoertuigID;";
                sqlCommand.Parameters.AddWithValue("@BrandstoftypeId", brandstoftypeid);
                sqlCommand.Parameters.AddWithValue("@VoertuigID", voertuigid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void KleurByPrimaryKey(string kleur, int voertuigid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Voertuig] SET Kleur=@Kleur WHERE VoertuigID=@VoertuigID;";
                sqlCommand.Parameters.AddWithValue("@Kleur", kleur ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@VoertuigID", voertuigid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void AantalDeurenByPrimaryKey(Nullable<byte> aantaldeuren, int voertuigid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Voertuig] SET AantalDeuren=@AantalDeuren WHERE VoertuigID=@VoertuigID;";
                sqlCommand.Parameters.AddWithValue("@AantalDeuren", aantaldeuren ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@VoertuigID", voertuigid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void BestuurderIDByPrimaryKey(Nullable<int> bestuurderid, int voertuigid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Voertuig] SET BestuurderID=@BestuurderID WHERE VoertuigID=@VoertuigID;";
                sqlCommand.Parameters.AddWithValue("@BestuurderID", bestuurderid ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@VoertuigID", voertuigid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void IsDeletedByPrimaryKey(Nullable<bool> isdeleted, int voertuigid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Voertuig] SET IsDeleted=@IsDeleted WHERE VoertuigID=@VoertuigID;";
                sqlCommand.Parameters.AddWithValue("@IsDeleted", isdeleted ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@VoertuigID", voertuigid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
    }}