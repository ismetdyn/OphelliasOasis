using OphelliasOasis.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OphelliasOasis.ORM
{
    public class RaporORM
    {
        public static Result<DataTable> RaporGetir(string raporAdi)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(Tools.Connection.ConnectionString);
                SqlCommand komut = new SqlCommand(raporAdi, baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return new Result<DataTable>
                {
                    IsSuccess = true,
                    Message = "İslem basarili!",
                    Data = dt
                };
            }
            catch (Exception ex)
            {
                return new Result<DataTable>
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }
    }
}
