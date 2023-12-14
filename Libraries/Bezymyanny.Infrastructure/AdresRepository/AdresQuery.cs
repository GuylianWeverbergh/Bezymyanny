using Ado.Data.SqlServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Bezymyanny.Db.AdresRepository
{
    public partial class AdresQuery
    {
        private SqlServerTable table;
        public AdresQuery(SqlServerTable table)
        {
            this.table = table;
        }
        private List<Adres> ToList(SqlCommand sqlCommand)
        {
            var dt = table.DbAccess.GetDataTable(sqlCommand);
            List<Adres> list = new List<Adres>();
            foreach (DataRow dataRow in dt.Rows)
            {
                Adres adres = new Adres();
                adres.AdresID = (int)dataRow["AdresID"];
                adres.Straat = (string)dataRow["Straat"];
                adres.Huisnummer = (string)dataRow["Huisnummer"];
                adres.Postcode = (string)dataRow["Postcode"];
                adres.Stad = (string)dataRow["Stad"];
                adres.Land = (string)dataRow["Land"];
                adres.IsDeleted = (Nullable<bool>)(dataRow["IsDeleted"] == DBNull.Value ? null : dataRow["IsDeleted"]);
                list.Add(adres);
            }
            return list;
        }
        public List<Adres> ToList(string sql)
        {
            return ToList(new SqlCommand(sql));
        }
        public virtual int Count()
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT COUNT(*) FROM [Adres];";
                return Convert.ToInt32(table.DbAccess.ExecuteScalar(sqlCommand));
            }
        }
        public virtual int CountByKeyword(string keyword)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT COUNT(AdresID) FROM [Adres] WHERE (Straat LIKE '%' + @Keyword + '%' OR Huisnummer LIKE '%' + @Keyword + '%' OR Postcode LIKE '%' + @Keyword + '%' OR Stad LIKE '%' + @Keyword + '%' OR Land LIKE '%' + @Keyword + '%');";
                sqlCommand.Parameters.AddWithValue("@Keyword", keyword);
                return Convert.ToInt32(table.DbAccess.ExecuteScalar(sqlCommand));
            }
        }
        public virtual List<Adres> All()
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [AdresID], [Straat], [Huisnummer], [Postcode], [Stad], [Land], [IsDeleted] FROM [Adres];";
                return ToList(sqlCommand);
            }
        }
        public virtual List<Adres> ByKeyword(string keyword, int start, int end, string orderByColumnName, string orderDirection = "ASC")
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = $"SELECT [AdresID], [Straat], [Huisnummer], [Postcode], [Stad], [Land], [IsDeleted] FROM (SELECT ROW_NUMBER() OVER (ORDER BY {orderByColumnName} {orderDirection}) AS RowSequence, [AdresID], [Straat], [Huisnummer], [Postcode], [Stad], [Land], [IsDeleted] FROM [Adres] WHERE (Straat LIKE '%' + @Keyword + '%' OR Huisnummer LIKE '%' + @Keyword + '%' OR Postcode LIKE '%' + @Keyword + '%' OR Stad LIKE '%' + @Keyword + '%' OR Land LIKE '%' + @Keyword + '%')) AS [Adres] WHERE RowSequence BETWEEN @Start AND @End;"; 
                sqlCommand.Parameters.AddWithValue("@Keyword", keyword);
                sqlCommand.Parameters.AddWithValue("@Start", start);
                sqlCommand.Parameters.AddWithValue("@End", end);
                return ToList(sqlCommand);
            }
        }
        public virtual Adres ByPrimaryKey(int adresid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT TOP 1 [AdresID], [Straat], [Huisnummer], [Postcode], [Stad], [Land], [IsDeleted] FROM [Adres] WHERE AdresID=@AdresID;";
                sqlCommand.Parameters.AddWithValue("@AdresID", adresid);
                var list = ToList(sqlCommand);
                if (list.Count > 0)
                {
                    return list[0];
                }
                return null;
            }
        }
        public virtual List<Adres> ByAdresID(int adresid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [AdresID], [Straat], [Huisnummer], [Postcode], [Stad], [Land], [IsDeleted] FROM [Adres]; WHERE AdresID = @AdresID;";
                sqlCommand.Parameters.AddWithValue("@AdresID", adresid);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Adres> ByStraat(string straat)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [AdresID], [Straat], [Huisnummer], [Postcode], [Stad], [Land], [IsDeleted] FROM [Adres]; WHERE Straat = @Straat;";
                sqlCommand.Parameters.AddWithValue("@Straat", straat);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Adres> ByHuisnummer(string huisnummer)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [AdresID], [Straat], [Huisnummer], [Postcode], [Stad], [Land], [IsDeleted] FROM [Adres]; WHERE Huisnummer = @Huisnummer;";
                sqlCommand.Parameters.AddWithValue("@Huisnummer", huisnummer);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Adres> ByPostcode(string postcode)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [AdresID], [Straat], [Huisnummer], [Postcode], [Stad], [Land], [IsDeleted] FROM [Adres]; WHERE Postcode = @Postcode;";
                sqlCommand.Parameters.AddWithValue("@Postcode", postcode);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Adres> ByStad(string stad)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [AdresID], [Straat], [Huisnummer], [Postcode], [Stad], [Land], [IsDeleted] FROM [Adres]; WHERE Stad = @Stad;";
                sqlCommand.Parameters.AddWithValue("@Stad", stad);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Adres> ByLand(string land)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [AdresID], [Straat], [Huisnummer], [Postcode], [Stad], [Land], [IsDeleted] FROM [Adres]; WHERE Land = @Land;";
                sqlCommand.Parameters.AddWithValue("@Land", land);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Adres> ByIsDeleted(Nullable<bool> isdeleted)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [AdresID], [Straat], [Huisnummer], [Postcode], [Stad], [Land], [IsDeleted] FROM [Adres]; WHERE IsDeleted = @IsDeleted;";
                sqlCommand.Parameters.AddWithValue("@IsDeleted", isdeleted);
                return ToList(sqlCommand);
            }
        }
    }}