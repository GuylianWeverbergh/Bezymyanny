using Ado.Data.SqlServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Bezymyanny.Db.VoertuigRepository
{
    public partial class VoertuigQuery
    {
        private SqlServerTable table;
        public VoertuigQuery(SqlServerTable table)
        {
            this.table = table;
        }
        private List<Voertuig> ToList(SqlCommand sqlCommand)
        {
            var dt = table.DbAccess.GetDataTable(sqlCommand);
            List<Voertuig> list = new List<Voertuig>();
            foreach (DataRow dataRow in dt.Rows)
            {
                Voertuig voertuig = new Voertuig();
                voertuig.VoertuigID = (int)dataRow["VoertuigID"];
                voertuig.Merk = (string)dataRow["Merk"];
                voertuig.Model = (string)dataRow["Model"];
                voertuig.Chassisnummer = (string)dataRow["Chassisnummer"];
                voertuig.Nummerplaat = (string)dataRow["Nummerplaat"];
                voertuig.BrandstoftypeId = (int)dataRow["BrandstoftypeId"];
                voertuig.Kleur = (string)(dataRow["Kleur"] == DBNull.Value ? null : dataRow["Kleur"]);
                voertuig.AantalDeuren = (Nullable<byte>)(dataRow["AantalDeuren"] == DBNull.Value ? null : dataRow["AantalDeuren"]);
                voertuig.BestuurderID = (Nullable<int>)(dataRow["BestuurderID"] == DBNull.Value ? null : dataRow["BestuurderID"]);
                voertuig.IsDeleted = (Nullable<bool>)(dataRow["IsDeleted"] == DBNull.Value ? null : dataRow["IsDeleted"]);
                list.Add(voertuig);
            }
            return list;
        }
        public List<Voertuig> ToList(string sql)
        {
            return ToList(new SqlCommand(sql));
        }
        public virtual int Count()
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT COUNT(*) FROM [Voertuig];";
                return Convert.ToInt32(table.DbAccess.ExecuteScalar(sqlCommand));
            }
        }
        public virtual int CountByKeyword(string keyword)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT COUNT(VoertuigID) FROM [Voertuig] WHERE (Merk LIKE '%' + @Keyword + '%' OR Model LIKE '%' + @Keyword + '%' OR Chassisnummer LIKE '%' + @Keyword + '%' OR Nummerplaat LIKE '%' + @Keyword + '%' OR Kleur LIKE '%' + @Keyword + '%');";
                sqlCommand.Parameters.AddWithValue("@Keyword", keyword);
                return Convert.ToInt32(table.DbAccess.ExecuteScalar(sqlCommand));
            }
        }
        public virtual List<Voertuig> All()
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [VoertuigID], [Merk], [Model], [Chassisnummer], [Nummerplaat], [BrandstoftypeId], [Kleur], [AantalDeuren], [BestuurderID], [IsDeleted] FROM [Voertuig];";
                return ToList(sqlCommand);
            }
        }
        public virtual List<Voertuig> ByKeyword(string keyword, int start, int end, string orderByColumnName, string orderDirection = "ASC")
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = $"SELECT [VoertuigID], [Merk], [Model], [Chassisnummer], [Nummerplaat], [BrandstoftypeId], [Kleur], [AantalDeuren], [BestuurderID], [IsDeleted] FROM (SELECT ROW_NUMBER() OVER (ORDER BY {orderByColumnName} {orderDirection}) AS RowSequence, [VoertuigID], [Merk], [Model], [Chassisnummer], [Nummerplaat], [BrandstoftypeId], [Kleur], [AantalDeuren], [BestuurderID], [IsDeleted] FROM [Voertuig] WHERE (Merk LIKE '%' + @Keyword + '%' OR Model LIKE '%' + @Keyword + '%' OR Chassisnummer LIKE '%' + @Keyword + '%' OR Nummerplaat LIKE '%' + @Keyword + '%' OR Kleur LIKE '%' + @Keyword + '%')) AS [Voertuig] WHERE RowSequence BETWEEN @Start AND @End;"; 
                sqlCommand.Parameters.AddWithValue("@Keyword", keyword);
                sqlCommand.Parameters.AddWithValue("@Start", start);
                sqlCommand.Parameters.AddWithValue("@End", end);
                return ToList(sqlCommand);
            }
        }
        public virtual Voertuig ByPrimaryKey(int voertuigid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT TOP 1 [VoertuigID], [Merk], [Model], [Chassisnummer], [Nummerplaat], [BrandstoftypeId], [Kleur], [AantalDeuren], [BestuurderID], [IsDeleted] FROM [Voertuig] WHERE VoertuigID=@VoertuigID;";
                sqlCommand.Parameters.AddWithValue("@VoertuigID", voertuigid);
                var list = ToList(sqlCommand);
                if (list.Count > 0)
                {
                    return list[0];
                }
                return null;
            }
        }
        public virtual List<Voertuig> ByVoertuigID(int voertuigid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [VoertuigID], [Merk], [Model], [Chassisnummer], [Nummerplaat], [BrandstoftypeId], [Kleur], [AantalDeuren], [BestuurderID], [IsDeleted] FROM [Voertuig]; WHERE VoertuigID = @VoertuigID;";
                sqlCommand.Parameters.AddWithValue("@VoertuigID", voertuigid);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Voertuig> ByMerk(string merk)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [VoertuigID], [Merk], [Model], [Chassisnummer], [Nummerplaat], [BrandstoftypeId], [Kleur], [AantalDeuren], [BestuurderID], [IsDeleted] FROM [Voertuig]; WHERE Merk = @Merk;";
                sqlCommand.Parameters.AddWithValue("@Merk", merk);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Voertuig> ByModel(string model)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [VoertuigID], [Merk], [Model], [Chassisnummer], [Nummerplaat], [BrandstoftypeId], [Kleur], [AantalDeuren], [BestuurderID], [IsDeleted] FROM [Voertuig]; WHERE Model = @Model;";
                sqlCommand.Parameters.AddWithValue("@Model", model);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Voertuig> ByChassisnummer(string chassisnummer)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [VoertuigID], [Merk], [Model], [Chassisnummer], [Nummerplaat], [BrandstoftypeId], [Kleur], [AantalDeuren], [BestuurderID], [IsDeleted] FROM [Voertuig]; WHERE Chassisnummer = @Chassisnummer;";
                sqlCommand.Parameters.AddWithValue("@Chassisnummer", chassisnummer);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Voertuig> ByNummerplaat(string nummerplaat)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [VoertuigID], [Merk], [Model], [Chassisnummer], [Nummerplaat], [BrandstoftypeId], [Kleur], [AantalDeuren], [BestuurderID], [IsDeleted] FROM [Voertuig]; WHERE Nummerplaat = @Nummerplaat;";
                sqlCommand.Parameters.AddWithValue("@Nummerplaat", nummerplaat);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Voertuig> ByBrandstoftypeId(int brandstoftypeid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [VoertuigID], [Merk], [Model], [Chassisnummer], [Nummerplaat], [BrandstoftypeId], [Kleur], [AantalDeuren], [BestuurderID], [IsDeleted] FROM [Voertuig]; WHERE BrandstoftypeId = @BrandstoftypeId;";
                sqlCommand.Parameters.AddWithValue("@BrandstoftypeId", brandstoftypeid);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Voertuig> ByKleur(string kleur)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [VoertuigID], [Merk], [Model], [Chassisnummer], [Nummerplaat], [BrandstoftypeId], [Kleur], [AantalDeuren], [BestuurderID], [IsDeleted] FROM [Voertuig]; WHERE Kleur = @Kleur;";
                sqlCommand.Parameters.AddWithValue("@Kleur", kleur);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Voertuig> ByAantalDeuren(Nullable<byte> aantaldeuren)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [VoertuigID], [Merk], [Model], [Chassisnummer], [Nummerplaat], [BrandstoftypeId], [Kleur], [AantalDeuren], [BestuurderID], [IsDeleted] FROM [Voertuig]; WHERE AantalDeuren = @AantalDeuren;";
                sqlCommand.Parameters.AddWithValue("@AantalDeuren", aantaldeuren);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Voertuig> ByBestuurderID(Nullable<int> bestuurderid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [VoertuigID], [Merk], [Model], [Chassisnummer], [Nummerplaat], [BrandstoftypeId], [Kleur], [AantalDeuren], [BestuurderID], [IsDeleted] FROM [Voertuig]; WHERE BestuurderID = @BestuurderID;";
                sqlCommand.Parameters.AddWithValue("@BestuurderID", bestuurderid);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Voertuig> ByIsDeleted(Nullable<bool> isdeleted)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [VoertuigID], [Merk], [Model], [Chassisnummer], [Nummerplaat], [BrandstoftypeId], [Kleur], [AantalDeuren], [BestuurderID], [IsDeleted] FROM [Voertuig]; WHERE IsDeleted = @IsDeleted;";
                sqlCommand.Parameters.AddWithValue("@IsDeleted", isdeleted);
                return ToList(sqlCommand);
            }
        }
    }}