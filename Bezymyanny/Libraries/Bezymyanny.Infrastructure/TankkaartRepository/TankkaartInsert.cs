using Ado.Data.SqlServer;
using System;
using System.Data.SqlClient;

namespace Bezymyanny.Db.TankkaartRepository
{
    public partial class TankkaartInsert
    {
        private SqlServerTable table;
        public TankkaartInsert(SqlServerTable table)
        {
            this.table = table;
        }
        public virtual void NewRecord(Tankkaart tankkaart)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "INSERT INTO [Tankkaart] (Kaartnummer, Geldigheidsdatum, Pincode, BestuurderID, Geblokkeerd, IsDeleted) VALUES (@Kaartnummer, @Geldigheidsdatum, @Pincode, @BestuurderID, @Geblokkeerd, @IsDeleted); SELECT SCOPE_IDENTITY() AS INT;";
                sqlCommand.Parameters.AddWithValue("@Kaartnummer", tankkaart.Kaartnummer);
                sqlCommand.Parameters.AddWithValue("@Geldigheidsdatum", tankkaart.Geldigheidsdatum ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@Pincode", tankkaart.Pincode ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@BestuurderID", tankkaart.BestuurderID ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@Geblokkeerd", tankkaart.Geblokkeerd ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@IsDeleted", tankkaart.IsDeleted ?? (object)DBNull.Value);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
    }}