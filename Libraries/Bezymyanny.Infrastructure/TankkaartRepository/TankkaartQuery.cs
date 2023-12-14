using Ado.Data.SqlServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Bezymyanny.Db.TankkaartRepository
{
    public partial class TankkaartQuery
    {
        private SqlServerTable table;
        public TankkaartQuery(SqlServerTable table)
        {
            this.table = table;
        }
        private List<Tankkaart> ToList(SqlCommand sqlCommand)
        {
            var dt = table.DbAccess.GetDataTable(sqlCommand);
            List<Tankkaart> list = new List<Tankkaart>();
            foreach (DataRow dataRow in dt.Rows)
            {
                Tankkaart tankkaart = new Tankkaart();
                tankkaart.TankkaartID = (int)dataRow["TankkaartID"];
                tankkaart.Kaartnummer = (int)dataRow["Kaartnummer"];
                tankkaart.Geldigheidsdatum = (Nullable<DateTime>)(dataRow["Geldigheidsdatum"] == DBNull.Value ? null : dataRow["Geldigheidsdatum"]);
                tankkaart.Pincode = (Nullable<int>)(dataRow["Pincode"] == DBNull.Value ? null : dataRow["Pincode"]);
                tankkaart.BestuurderID = (Nullable<int>)(dataRow["BestuurderID"] == DBNull.Value ? null : dataRow["BestuurderID"]);
                tankkaart.Geblokkeerd = (Nullable<bool>)(dataRow["Geblokkeerd"] == DBNull.Value ? null : dataRow["Geblokkeerd"]);
                tankkaart.IsDeleted = (Nullable<bool>)(dataRow["IsDeleted"] == DBNull.Value ? null : dataRow["IsDeleted"]);
                list.Add(tankkaart);
            }
            return list;
        }
        public List<Tankkaart> ToList(string sql)
        {
            return ToList(new SqlCommand(sql));
        }
        public virtual int Count()
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT COUNT(*) FROM [Tankkaart];";
                return Convert.ToInt32(table.DbAccess.ExecuteScalar(sqlCommand));
            }
        }
        public virtual int CountByKeyword(string keyword)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT COUNT(TankkaartID) FROM [Tankkaart] WHERE ();";
                sqlCommand.Parameters.AddWithValue("@Keyword", keyword);
                return Convert.ToInt32(table.DbAccess.ExecuteScalar(sqlCommand));
            }
        }
        public virtual List<Tankkaart> All()
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [TankkaartID], [Kaartnummer], [Geldigheidsdatum], [Pincode], [BestuurderID], [Geblokkeerd], [IsDeleted] FROM [Tankkaart];";
                return ToList(sqlCommand);
            }
        }
        public virtual List<Tankkaart> ByKeyword(string keyword, int start, int end, string orderByColumnName, string orderDirection = "ASC")
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = $"SELECT [TankkaartID], [Kaartnummer], [Geldigheidsdatum], [Pincode], [BestuurderID], [Geblokkeerd], [IsDeleted] FROM (SELECT ROW_NUMBER() OVER (ORDER BY {orderByColumnName} {orderDirection}) AS RowSequence, [TankkaartID], [Kaartnummer], [Geldigheidsdatum], [Pincode], [BestuurderID], [Geblokkeerd], [IsDeleted] FROM [Tankkaart] WHERE ()) AS [Tankkaart] WHERE RowSequence BETWEEN @Start AND @End;"; 
                sqlCommand.Parameters.AddWithValue("@Keyword", keyword);
                sqlCommand.Parameters.AddWithValue("@Start", start);
                sqlCommand.Parameters.AddWithValue("@End", end);
                return ToList(sqlCommand);
            }
        }
        public virtual Tankkaart ByPrimaryKey(int tankkaartid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT TOP 1 [TankkaartID], [Kaartnummer], [Geldigheidsdatum], [Pincode], [BestuurderID], [Geblokkeerd], [IsDeleted] FROM [Tankkaart] WHERE TankkaartID=@TankkaartID;";
                sqlCommand.Parameters.AddWithValue("@TankkaartID", tankkaartid);
                var list = ToList(sqlCommand);
                if (list.Count > 0)
                {
                    return list[0];
                }
                return null;
            }
        }
        public virtual List<Tankkaart> ByTankkaartID(int tankkaartid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [TankkaartID], [Kaartnummer], [Geldigheidsdatum], [Pincode], [BestuurderID], [Geblokkeerd], [IsDeleted] FROM [Tankkaart]; WHERE TankkaartID = @TankkaartID;";
                sqlCommand.Parameters.AddWithValue("@TankkaartID", tankkaartid);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Tankkaart> ByKaartnummer(int kaartnummer)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [TankkaartID], [Kaartnummer], [Geldigheidsdatum], [Pincode], [BestuurderID], [Geblokkeerd], [IsDeleted] FROM [Tankkaart]; WHERE Kaartnummer = @Kaartnummer;";
                sqlCommand.Parameters.AddWithValue("@Kaartnummer", kaartnummer);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Tankkaart> ByGeldigheidsdatum(Nullable<DateTime> geldigheidsdatum)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [TankkaartID], [Kaartnummer], [Geldigheidsdatum], [Pincode], [BestuurderID], [Geblokkeerd], [IsDeleted] FROM [Tankkaart]; WHERE Geldigheidsdatum = @Geldigheidsdatum;";
                sqlCommand.Parameters.AddWithValue("@Geldigheidsdatum", geldigheidsdatum);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Tankkaart> ByPincode(Nullable<int> pincode)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [TankkaartID], [Kaartnummer], [Geldigheidsdatum], [Pincode], [BestuurderID], [Geblokkeerd], [IsDeleted] FROM [Tankkaart]; WHERE Pincode = @Pincode;";
                sqlCommand.Parameters.AddWithValue("@Pincode", pincode);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Tankkaart> ByBestuurderID(Nullable<int> bestuurderid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [TankkaartID], [Kaartnummer], [Geldigheidsdatum], [Pincode], [BestuurderID], [Geblokkeerd], [IsDeleted] FROM [Tankkaart]; WHERE BestuurderID = @BestuurderID;";
                sqlCommand.Parameters.AddWithValue("@BestuurderID", bestuurderid);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Tankkaart> ByGeblokkeerd(Nullable<bool> geblokkeerd)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [TankkaartID], [Kaartnummer], [Geldigheidsdatum], [Pincode], [BestuurderID], [Geblokkeerd], [IsDeleted] FROM [Tankkaart]; WHERE Geblokkeerd = @Geblokkeerd;";
                sqlCommand.Parameters.AddWithValue("@Geblokkeerd", geblokkeerd);
                return ToList(sqlCommand);
            }
        }
        public virtual List<Tankkaart> ByIsDeleted(Nullable<bool> isdeleted)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT [TankkaartID], [Kaartnummer], [Geldigheidsdatum], [Pincode], [BestuurderID], [Geblokkeerd], [IsDeleted] FROM [Tankkaart]; WHERE IsDeleted = @IsDeleted;";
                sqlCommand.Parameters.AddWithValue("@IsDeleted", isdeleted);
                return ToList(sqlCommand);
            }
        }
    }}