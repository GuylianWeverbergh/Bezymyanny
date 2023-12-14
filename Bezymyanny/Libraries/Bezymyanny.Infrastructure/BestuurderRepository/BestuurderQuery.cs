using Ado.Data.SqlServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Bezymyanny.Db.BestuurderRepository
{
    public partial class BestuurderQuery
    {
        private SqlServerTable table;
        public BestuurderQuery(SqlServerTable table)
        {
            this.table = table;
        }
        private List<Bestuurder> ToList(SqlCommand sqlCommand)
        {
            var dt = table.DbAccess.GetDataTable(sqlCommand);
            List<Bestuurder> list = new List<Bestuurder>();
            foreach (DataRow dataRow in dt.Rows)
            {
                Bestuurder bestuurder = new Bestuurder();
                bestuurder.BestuurderID = (int)dataRow["BestuurderID"];
                bestuurder.Naam = (string)dataRow["Naam"];
                bestuurder.Voornaam = (string)dataRow["Voornaam"];
                bestuurder.AdresID = (Nullable<int>)(dataRow["AdresID"] == DBNull.Value ? null : dataRow["AdresID"]);
                bestuurder.Geboortedatum = (Nullable<DateTime>)(dataRow["Geboortedatum"] == DBNull.Value ? null : dataRow["Geboortedatum"]);
                bestuurder.Rijksregisternummer = (string)dataRow["Rijksregisternummer"];
                bestuurder.RijbewijstypeID = (int)dataRow["RijbewijstypeID"];
                bestuurder.VoertuigID = (Nullable<int>)(dataRow["VoertuigID"] == DBNull.Value ? null : dataRow["VoertuigID"]);
                bestuurder.TankkaartID = (Nullable<int>)(dataRow["TankkaartID"] == DBNull.Value ? null : dataRow["TankkaartID"]);
                bestuurder.IsDeleted = (Nullable<bool>)(dataRow["IsDeleted"] == DBNull.Value ? null : dataRow["IsDeleted"]);
                list.Add(bestuurder);
            }
            return list;
        }
        public List<Bestuurder> ToList(string sql)
        {
            return ToList(new SqlCommand(sql));
        }
        public virtual int Count()
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT COUNT(*) FROM [Bestuurder];";
                return Convert.ToInt32(table.DbAccess.ExecuteScalar(sqlCommand));
            }
        }
        public virtual int CountByKeyword(string keyword)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT COUNT(BestuurderID) FROM [Bestuurder] WHERE (Naam LIKE '%' + @Keyword + '%' OR Voornaam LIKE '%' + @Keyword + '%' OR Rijksregisternummer LIKE '%' + @Keyword + '%');";
                sqlCommand.Parameters.AddWithValue("@Keyword", keyword);
                return Convert.ToInt32(table.DbAccess.ExecuteScalar(sqlCommand));
            }
        }
        public virtual List<Bestuurder> All()
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [BestuurderID], [Naam], [Voornaam], [AdresID], [Geboortedatum], [Rijksregisternummer], [RijbewijstypeID], [VoertuigID], [TankkaartID], [IsDeleted] FROM [Bestuurder];";
                return ToList(sqlCommand);
            }
        }
        public virtual List<Bestuurder> ByKeyword(string keyword, int start, int end, string orderByColumnName, string orderDirection = "ASC")
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = $"SELECT [BestuurderID], [Naam], [Voornaam], [AdresID], [Geboortedatum], [Rijksregisternummer], [RijbewijstypeID], [VoertuigID], [TankkaartID], [IsDeleted] FROM (SELECT ROW_NUMBER() OVER (ORDER BY {orderByColumnName} {orderDirection}) AS RowSequence, [BestuurderID], [Naam], [Voornaam], [AdresID], [Geboortedatum], [Rijksregisternummer], [RijbewijstypeID], [VoertuigID], [TankkaartID], [IsDeleted] FROM [Bestuurder] WHERE (Naam LIKE '%' + @Keyword + '%' OR Voornaam LIKE '%' + @Keyword + '%' OR Rijksregisternummer LIKE '%' + @Keyword + '%')) AS [Bestuurder] WHERE RowSequence BETWEEN @Start AND @End;"; 
                sqlCommand.Parameters.AddWithValue("@Keyword", keyword);
                sqlCommand.Parameters.AddWithValue("@Start", start);
                sqlCommand.Parameters.AddWithValue("@End", end);
                return ToList(sqlCommand);
            }
        }
        public virtual Bestuurder ByPrimaryKey(int bestuurderid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT TOP 1 [BestuurderID], [Naam], [Voornaam], [AdresID], [Geboortedatum], [Rijksregisternummer], [RijbewijstypeID], [VoertuigID], [TankkaartID], [IsDeleted] FROM [Bestuurder] WHERE BestuurderID=@BestuurderID;";
                sqlCommand.Parameters.AddWithValue("@BestuurderID", bestuurderid);
                var list = ToList(sqlCommand);
                if (list.Count > 0)
                {
                    return list[0];
                }
                return null;
            }
        }
        public virtual List<Bestuurder> ByBestuurderID(int bestuurderid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [BestuurderID], [Naam], [Voornaam], [AdresID], [Geboortedatum], [Rijksregisternummer], [RijbewijstypeID], [VoertuigID], [TankkaartID], [IsDeleted] FROM [Bestuurder]; WHERE BestuurderID = @BestuurderID;";
                sqlCommand.Parameters.AddWithValue("@BestuurderID", bestuurderid);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Bestuurder> ByNaam(string naam)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [BestuurderID], [Naam], [Voornaam], [AdresID], [Geboortedatum], [Rijksregisternummer], [RijbewijstypeID], [VoertuigID], [TankkaartID], [IsDeleted] FROM [Bestuurder]; WHERE Naam = @Naam;";
                sqlCommand.Parameters.AddWithValue("@Naam", naam);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Bestuurder> ByVoornaam(string voornaam)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [BestuurderID], [Naam], [Voornaam], [AdresID], [Geboortedatum], [Rijksregisternummer], [RijbewijstypeID], [VoertuigID], [TankkaartID], [IsDeleted] FROM [Bestuurder]; WHERE Voornaam = @Voornaam;";
                sqlCommand.Parameters.AddWithValue("@Voornaam", voornaam);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Bestuurder> ByAdresID(Nullable<int> adresid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [BestuurderID], [Naam], [Voornaam], [AdresID], [Geboortedatum], [Rijksregisternummer], [RijbewijstypeID], [VoertuigID], [TankkaartID], [IsDeleted] FROM [Bestuurder]; WHERE AdresID = @AdresID;";
                sqlCommand.Parameters.AddWithValue("@AdresID", adresid);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Bestuurder> ByGeboortedatum(Nullable<DateTime> geboortedatum)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [BestuurderID], [Naam], [Voornaam], [AdresID], [Geboortedatum], [Rijksregisternummer], [RijbewijstypeID], [VoertuigID], [TankkaartID], [IsDeleted] FROM [Bestuurder]; WHERE Geboortedatum = @Geboortedatum;";
                sqlCommand.Parameters.AddWithValue("@Geboortedatum", geboortedatum);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Bestuurder> ByRijksregisternummer(string rijksregisternummer)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [BestuurderID], [Naam], [Voornaam], [AdresID], [Geboortedatum], [Rijksregisternummer], [RijbewijstypeID], [VoertuigID], [TankkaartID], [IsDeleted] FROM [Bestuurder]; WHERE Rijksregisternummer = @Rijksregisternummer;";
                sqlCommand.Parameters.AddWithValue("@Rijksregisternummer", rijksregisternummer);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Bestuurder> ByRijbewijstypeID(int rijbewijstypeid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [BestuurderID], [Naam], [Voornaam], [AdresID], [Geboortedatum], [Rijksregisternummer], [RijbewijstypeID], [VoertuigID], [TankkaartID], [IsDeleted] FROM [Bestuurder]; WHERE RijbewijstypeID = @RijbewijstypeID;";
                sqlCommand.Parameters.AddWithValue("@RijbewijstypeID", rijbewijstypeid);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Bestuurder> ByVoertuigID(Nullable<int> voertuigid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [BestuurderID], [Naam], [Voornaam], [AdresID], [Geboortedatum], [Rijksregisternummer], [RijbewijstypeID], [VoertuigID], [TankkaartID], [IsDeleted] FROM [Bestuurder]; WHERE VoertuigID = @VoertuigID;";
                sqlCommand.Parameters.AddWithValue("@VoertuigID", voertuigid);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Bestuurder> ByTankkaartID(Nullable<int> tankkaartid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [BestuurderID], [Naam], [Voornaam], [AdresID], [Geboortedatum], [Rijksregisternummer], [RijbewijstypeID], [VoertuigID], [TankkaartID], [IsDeleted] FROM [Bestuurder]; WHERE TankkaartID = @TankkaartID;";
                sqlCommand.Parameters.AddWithValue("@TankkaartID", tankkaartid);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Bestuurder> ByIsDeleted(Nullable<bool> isdeleted)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [BestuurderID], [Naam], [Voornaam], [AdresID], [Geboortedatum], [Rijksregisternummer], [RijbewijstypeID], [VoertuigID], [TankkaartID], [IsDeleted] FROM [Bestuurder]; WHERE IsDeleted = @IsDeleted;";
                sqlCommand.Parameters.AddWithValue("@IsDeleted", isdeleted);
                return ToList(sqlCommand);
            }
        }
    }}