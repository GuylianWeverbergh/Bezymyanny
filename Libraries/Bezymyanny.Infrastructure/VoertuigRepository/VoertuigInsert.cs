using Ado.Data.SqlServer;
using System;
using System.Data.SqlClient;

namespace Bezymyanny.Db.VoertuigRepository
{
    public partial class VoertuigInsert
    {
        private SqlServerTable table;
        public VoertuigInsert(SqlServerTable table)
        {
            this.table = table;
        }
        public virtual void NewRecord(Voertuig voertuig)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "INSERT INTO [Voertuig] (Merk, Model, Chassisnummer, Nummerplaat, BrandstoftypeId, Kleur, AantalDeuren, BestuurderID, IsDeleted) VALUES (@Merk, @Model, @Chassisnummer, @Nummerplaat, @BrandstoftypeId, @Kleur, @AantalDeuren, @BestuurderID, @IsDeleted); SELECT SCOPE_IDENTITY() AS INT;";
                sqlCommand.Parameters.AddWithValue("@Merk", voertuig.Merk);
                sqlCommand.Parameters.AddWithValue("@Model", voertuig.Model);
                sqlCommand.Parameters.AddWithValue("@Chassisnummer", voertuig.Chassisnummer);
                sqlCommand.Parameters.AddWithValue("@Nummerplaat", voertuig.Nummerplaat);
                sqlCommand.Parameters.AddWithValue("@BrandstoftypeId", voertuig.BrandstoftypeId);
                sqlCommand.Parameters.AddWithValue("@Kleur", voertuig.Kleur ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@AantalDeuren", voertuig.AantalDeuren ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@BestuurderID", voertuig.BestuurderID ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@IsDeleted", voertuig.IsDeleted ?? (object)DBNull.Value);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
    }}