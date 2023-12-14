using Ado.Data.SqlServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Bezymyanny.Db.BrandstoftypeRepository
{
    public partial class BrandstoftypeQuery
    {
        private SqlServerTable table;
        public BrandstoftypeQuery(SqlServerTable table)
        {
            this.table = table;
        }
        private List<Brandstoftype> ToList(SqlCommand sqlCommand)
        {
            var dt = table.DbAccess.GetDataTable(sqlCommand);
            List<Brandstoftype> list = new List<Brandstoftype>();
            foreach (DataRow dataRow in dt.Rows)
            {
                Brandstoftype brandstoftype = new Brandstoftype();
                brandstoftype.BrandstoftypeID = (int)dataRow["BrandstoftypeID"];
                brandstoftype.Beschrijving = (string)dataRow["Beschrijving"];
                brandstoftype.IsDeleted = (Nullable<bool>)(dataRow["IsDeleted"] == DBNull.Value ? null : dataRow["IsDeleted"]);
                list.Add(brandstoftype);
            }
            return list;
        }
        public List<Brandstoftype> ToList(string sql)
        {
            return ToList(new SqlCommand(sql));
        }
        public virtual int Count()
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT COUNT(*) FROM [Brandstoftype];";
                return Convert.ToInt32(table.DbAccess.ExecuteScalar(sqlCommand));
            }
        }
        public virtual int CountByKeyword(string keyword)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT COUNT(BrandstoftypeID) FROM [Brandstoftype] WHERE (Beschrijving LIKE '%' + @Keyword + '%');";
                sqlCommand.Parameters.AddWithValue("@Keyword", keyword);
                return Convert.ToInt32(table.DbAccess.ExecuteScalar(sqlCommand));
            }
        }
        public virtual List<Brandstoftype> All()
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [BrandstoftypeID], [Beschrijving], [IsDeleted] FROM [Brandstoftype];";
                return ToList(sqlCommand);
            }
        }
        public virtual List<Brandstoftype> ByKeyword(string keyword, int start, int end, string orderByColumnName, string orderDirection = "ASC")
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = $"SELECT [BrandstoftypeID], [Beschrijving], [IsDeleted] FROM (SELECT ROW_NUMBER() OVER (ORDER BY {orderByColumnName} {orderDirection}) AS RowSequence, [BrandstoftypeID], [Beschrijving], [IsDeleted] FROM [Brandstoftype] WHERE (Beschrijving LIKE '%' + @Keyword + '%')) AS [Brandstoftype] WHERE RowSequence BETWEEN @Start AND @End;"; 
                sqlCommand.Parameters.AddWithValue("@Keyword", keyword);
                sqlCommand.Parameters.AddWithValue("@Start", start);
                sqlCommand.Parameters.AddWithValue("@End", end);
                return ToList(sqlCommand);
            }
        }
        public virtual Brandstoftype ByPrimaryKey(int brandstoftypeid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT TOP 1 [BrandstoftypeID], [Beschrijving], [IsDeleted] FROM [Brandstoftype] WHERE BrandstoftypeID=@BrandstoftypeID;";
                sqlCommand.Parameters.AddWithValue("@BrandstoftypeID", brandstoftypeid);
                var list = ToList(sqlCommand);
                if (list.Count > 0)
                {
                    return list[0];
                }
                return null;
            }
        }
        public virtual List<Brandstoftype> ByBrandstoftypeID(int brandstoftypeid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [BrandstoftypeID], [Beschrijving], [IsDeleted] FROM [Brandstoftype]; WHERE BrandstoftypeID = @BrandstoftypeID;";
                sqlCommand.Parameters.AddWithValue("@BrandstoftypeID", brandstoftypeid);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Brandstoftype> ByBeschrijving(string beschrijving)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [BrandstoftypeID], [Beschrijving], [IsDeleted] FROM [Brandstoftype]; WHERE Beschrijving = @Beschrijving;";
                sqlCommand.Parameters.AddWithValue("@Beschrijving", beschrijving);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Brandstoftype> ByIsDeleted(Nullable<bool> isdeleted)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [BrandstoftypeID], [Beschrijving], [IsDeleted] FROM [Brandstoftype]; WHERE IsDeleted = @IsDeleted;";
                sqlCommand.Parameters.AddWithValue("@IsDeleted", isdeleted);
                return ToList(sqlCommand);
            }
        }
    }}