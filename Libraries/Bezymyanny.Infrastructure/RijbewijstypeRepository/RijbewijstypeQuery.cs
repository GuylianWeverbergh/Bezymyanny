using Ado.Data.SqlServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Bezymyanny.Db.RijbewijstypeRepository
{
    public partial class RijbewijstypeQuery
    {
        private SqlServerTable table;
        public RijbewijstypeQuery(SqlServerTable table)
        {
            this.table = table;
        }
        private List<Rijbewijstype> ToList(SqlCommand sqlCommand)
        {
            var dt = table.DbAccess.GetDataTable(sqlCommand);
            List<Rijbewijstype> list = new List<Rijbewijstype>();
            foreach (DataRow dataRow in dt.Rows)
            {
                Rijbewijstype rijbewijstype = new Rijbewijstype();
                rijbewijstype.RijbewijstypeID = (int)dataRow["RijbewijstypeID"];
                rijbewijstype.Beschrijving = (string)dataRow["Beschrijving"];
                rijbewijstype.IsDeleted = (Nullable<bool>)(dataRow["IsDeleted"] == DBNull.Value ? null : dataRow["IsDeleted"]);
                list.Add(rijbewijstype);
            }
            return list;
        }
        public List<Rijbewijstype> ToList(string sql)
        {
            return ToList(new SqlCommand(sql));
        }
        public virtual int Count()
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT COUNT(*) FROM [Rijbewijstype];";
                return Convert.ToInt32(table.DbAccess.ExecuteScalar(sqlCommand));
            }
        }
        public virtual int CountByKeyword(string keyword)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT COUNT(RijbewijstypeID) FROM [Rijbewijstype] WHERE (Beschrijving LIKE '%' + @Keyword + '%');";
                sqlCommand.Parameters.AddWithValue("@Keyword", keyword);
                return Convert.ToInt32(table.DbAccess.ExecuteScalar(sqlCommand));
            }
        }
        public virtual List<Rijbewijstype> All()
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [RijbewijstypeID], [Beschrijving], [IsDeleted] FROM [Rijbewijstype];";
                return ToList(sqlCommand);
            }
        }
        public virtual List<Rijbewijstype> ByKeyword(string keyword, int start, int end, string orderByColumnName, string orderDirection = "ASC")
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = $"SELECT [RijbewijstypeID], [Beschrijving], [IsDeleted] FROM (SELECT ROW_NUMBER() OVER (ORDER BY {orderByColumnName} {orderDirection}) AS RowSequence, [RijbewijstypeID], [Beschrijving], [IsDeleted] FROM [Rijbewijstype] WHERE (Beschrijving LIKE '%' + @Keyword + '%')) AS [Rijbewijstype] WHERE RowSequence BETWEEN @Start AND @End;"; 
                sqlCommand.Parameters.AddWithValue("@Keyword", keyword);
                sqlCommand.Parameters.AddWithValue("@Start", start);
                sqlCommand.Parameters.AddWithValue("@End", end);
                return ToList(sqlCommand);
            }
        }
        public virtual Rijbewijstype ByPrimaryKey(int rijbewijstypeid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT TOP 1 [RijbewijstypeID], [Beschrijving], [IsDeleted] FROM [Rijbewijstype] WHERE RijbewijstypeID=@RijbewijstypeID;";
                sqlCommand.Parameters.AddWithValue("@RijbewijstypeID", rijbewijstypeid);
                var list = ToList(sqlCommand);
                if (list.Count > 0)
                {
                    return list[0];
                }
                return null;
            }
        }
        public virtual List<Rijbewijstype> ByRijbewijstypeID(int rijbewijstypeid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [RijbewijstypeID], [Beschrijving], [IsDeleted] FROM [Rijbewijstype]; WHERE RijbewijstypeID = @RijbewijstypeID;";
                sqlCommand.Parameters.AddWithValue("@RijbewijstypeID", rijbewijstypeid);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Rijbewijstype> ByBeschrijving(string beschrijving)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [RijbewijstypeID], [Beschrijving], [IsDeleted] FROM [Rijbewijstype]; WHERE Beschrijving = @Beschrijving;";
                sqlCommand.Parameters.AddWithValue("@Beschrijving", beschrijving);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Rijbewijstype> ByIsDeleted(Nullable<bool> isdeleted)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [RijbewijstypeID], [Beschrijving], [IsDeleted] FROM [Rijbewijstype]; WHERE IsDeleted = @IsDeleted;";
                sqlCommand.Parameters.AddWithValue("@IsDeleted", isdeleted);
                return ToList(sqlCommand);
            }
        }
    }}