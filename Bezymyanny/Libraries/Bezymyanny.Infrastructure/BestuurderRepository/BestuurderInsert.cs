using Ado.Data.SqlServer;
using System;
using System.Data.SqlClient;

namespace Bezymyanny.Db.BestuurderRepository
{
    public partial class BestuurderInsert
    {
        private SqlServerTable table;
        public BestuurderInsert(SqlServerTable table)
        {
            this.table = table;
        }
        public virtual void NewRecord(Bestuurder bestuurder)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "INSERT INTO [Bestuurder] (Naam, Voornaam, AdresID, Geboortedatum, Rijksregisternummer, RijbewijstypeID, VoertuigID, TankkaartID, IsDeleted) VALUES (@Naam, @Voornaam, @AdresID, @Geboortedatum, @Rijksregisternummer, @RijbewijstypeID, @VoertuigID, @TankkaartID, @IsDeleted); SELECT SCOPE_IDENTITY() AS INT;";
                sqlCommand.Parameters.AddWithValue("@Naam", bestuurder.Naam);
                sqlCommand.Parameters.AddWithValue("@Voornaam", bestuurder.Voornaam);
                sqlCommand.Parameters.AddWithValue("@AdresID", bestuurder.AdresID ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@Geboortedatum", bestuurder.Geboortedatum ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@Rijksregisternummer", bestuurder.Rijksregisternummer);
                sqlCommand.Parameters.AddWithValue("@RijbewijstypeID", bestuurder.RijbewijstypeID);
                sqlCommand.Parameters.AddWithValue("@VoertuigID", bestuurder.VoertuigID ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@TankkaartID", bestuurder.TankkaartID ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@IsDeleted", bestuurder.IsDeleted ?? (object)DBNull.Value);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
    }}