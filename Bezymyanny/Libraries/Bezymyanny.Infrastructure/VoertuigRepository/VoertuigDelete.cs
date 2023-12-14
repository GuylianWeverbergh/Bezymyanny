using Ado.Data.SqlServer;
using System;
using System.Data.SqlClient;

namespace Bezymyanny.Db.VoertuigRepository
{
    public partial class VoertuigDelete
    {
        private SqlServerTable table;
        public VoertuigDelete(SqlServerTable table)
        {
            this.table = table;
        }
        public virtual void ByPrimaryKey(int voertuigid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Voertuig] WHERE VoertuigID=@VoertuigID;";
                sqlCommand.Parameters.AddWithValue("@VoertuigID", voertuigid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByVoertuigID(int voertuigid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Voertuig] WHERE VoertuigID=@VoertuigID;";
                sqlCommand.Parameters.AddWithValue("@VoertuigID", voertuigid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByMerk(string merk)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Voertuig] WHERE Merk=@Merk;";
                sqlCommand.Parameters.AddWithValue("@Merk", merk);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByModel(string model)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Voertuig] WHERE Model=@Model;";
                sqlCommand.Parameters.AddWithValue("@Model", model);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByChassisnummer(string chassisnummer)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Voertuig] WHERE Chassisnummer=@Chassisnummer;";
                sqlCommand.Parameters.AddWithValue("@Chassisnummer", chassisnummer);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByNummerplaat(string nummerplaat)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Voertuig] WHERE Nummerplaat=@Nummerplaat;";
                sqlCommand.Parameters.AddWithValue("@Nummerplaat", nummerplaat);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByBrandstoftypeId(int brandstoftypeid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Voertuig] WHERE BrandstoftypeId=@BrandstoftypeId;";
                sqlCommand.Parameters.AddWithValue("@BrandstoftypeId", brandstoftypeid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByKleur(string kleur)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Voertuig] WHERE Kleur=@Kleur;";
                sqlCommand.Parameters.AddWithValue("@Kleur", kleur ?? (object)DBNull.Value);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByAantalDeuren(Nullable<byte> aantaldeuren)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Voertuig] WHERE AantalDeuren=@AantalDeuren;";
                sqlCommand.Parameters.AddWithValue("@AantalDeuren", aantaldeuren ?? (object)DBNull.Value);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByBestuurderID(Nullable<int> bestuurderid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Voertuig] WHERE BestuurderID=@BestuurderID;";
                sqlCommand.Parameters.AddWithValue("@BestuurderID", bestuurderid ?? (object)DBNull.Value);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByIsDeleted(Nullable<bool> isdeleted)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Voertuig] WHERE IsDeleted=@IsDeleted;";
                sqlCommand.Parameters.AddWithValue("@IsDeleted", isdeleted ?? (object)DBNull.Value);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
    }}