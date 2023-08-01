using MicroMEMSApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroMEMSApp.Services
{
    internal class TBYT_LK_Service
    {
        private readonly AppDbContext _db;

        public TBYT_LK_Service()
        {
            _db = new AppDbContext();
        }

        bool disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _db.Dispose();

                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public List<TBYT_LK> GetAll()
        {
            //return _db.TBYT_LKs.ToList();

            try
            {
                var result = _db.TBYT_LKs.OrderBy(x => x.TenLK).ToList();
                if (result == null)
                {
                    MessageBox.Show("Null Result");
                }
                else
                {
                    MessageBox.Show(result.ToString());
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public TBYT_LK GetOne(int id)
        {
            return _db.TBYT_LKs.Find(id);
        }

        public List<TBYT_LK> Search(string tenLK)
        {
            try
            {
                //return _db.TBYTs.Where(x => x.TenTB.Contains(tenTB)).ToList();
                return _db.TBYT_LKs.Where(x => x.TenLK.Contains(tenLK)).OrderBy(y => y.TenLK).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool AddNew(TBYT_LK tbyt_lk)
        {
            try
            {
                _db.TBYT_LKs.Add(tbyt_lk);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Update(TBYT_LK obj)
        {
            bool lreturn = false;
            TBYT_LK tbyt_lk = _db.TBYT_LKs.Find(obj.Id);
            if (tbyt_lk == null)
            {
                lreturn = this.AddNew(obj);
            }
            else
            {
                // MaLK, TenLK, Dvt, SoLuong, IdTBYT
                tbyt_lk.MaLK = obj.MaLK;
                tbyt_lk.TenLK = obj.TenLK;
                tbyt_lk.Dvt = obj.Dvt;
                tbyt_lk.SoLuong = obj.SoLuong;

                _db.SaveChanges();
                lreturn = true;
            }
            return lreturn;
        }

        public bool Delete(int Id)
        {
            TBYT_LK tbyt_lk = _db.TBYT_LKs.Find(Id);
            if (tbyt_lk != null)
            {
                _db.TBYT_LKs.Remove(tbyt_lk);
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(TBYT_LK obj)
        {
            TBYT_LK tbyt_lk = _db.TBYT_LKs.Find(obj.Id);
            if (tbyt_lk != null)
            {
                _db.TBYT_LKs.Remove(tbyt_lk);
                _db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
