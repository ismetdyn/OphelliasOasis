using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using OphelliasOasis.Common;
using OphelliasOasis.Entity;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace OphelliasOasis.ORM
{
    public class MusteriORM : ORMBase<Musteri, MusteriORM>
    {
        public static Result<DataTable> FaturaGetir(Musteri musteri)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(Tools.Connection.ConnectionString);
                SqlCommand komut = new SqlCommand("fatura", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@musteriID", musteri.MusteriID);
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

        public void FaturaBas(Musteri musteri)
        {
            //Result<DataTable> result = FaturaGetir(musteri);
            //if (!result.IsSuccess) return;
            //GridControl gridControl = new GridControl { DataSource = result.Data};
            //string path = "";
            //XtraFolderBrowserDialog fd = new XtraFolderBrowserDialog();
            //if (fd.ShowDialog() == DialogResult.OK)
            //{
            //    path = string.Format(fd.SelectedPath);
            //    path += string.Format("\\Rapor.pdf");
            //    gridControl.ExportToPdf(path); 
            //    //Process.Start(path);
            //}
        }
    }
}
