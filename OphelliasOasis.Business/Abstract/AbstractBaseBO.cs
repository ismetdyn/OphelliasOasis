using OphelliasOasis.Common;
using System;
using System.Data;

namespace OphelliasOasis.Business.Abstract
{
    public abstract class AbstractBaseBO<ET ,OT, BO>
        where BO : class, new()
        where ET : class, new()
        where OT : ORMBase<ET, OT>, new()
    {
        private static BO _current;

        public static BO Current
        {
            get 
            {
                if (_current == null) _current = new BO();
                return _current; 
            }
        }

        public Result<ET> EkleveGetir(ET entity)
        {
            try
            {
                Result<bool> result1 = ORMBase<ET, OT>.Current.Insert(entity);
                if (!result1.IsSuccess) throw new Exception(result1.Message);
                Result<DataTable> result2 = ORMBase<ET, OT>.Current.SelectDataTable();
                if (!result2.IsSuccess) throw new Exception(result2.Message);
                Result<ET> result3 = result2.Data.Rows[result2.Data.Rows.Count - 1].ToEntity<ET>();
                if (!result3.IsSuccess) throw new Exception(result3.Message);
                return new Result<ET>
                {
                    IsSuccess = true,
                    Message = "Başarılı(MusteriEkleveGetir)",
                    Data = result3.Data
                };
            }
            catch (Exception ex)
            {
                return new Result<ET>
                {
                    IsSuccess = false,
                    Message = "Hata(MusteriEkleveGetir)" + ex.Message
                };
            }
        }
    }
}
