﻿using MicroMEMSApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroMEMSApp.Services
{
    internal class TBYT_Service
    {
        private readonly AppDbContext _db;
        public TBYT_Service()
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

        public List<TBYT> GetAll()
        {
            //return _db.TBYTs.ToList();

            try
            {
                return _db.TBYTs.OrderBy(x => x.TenTB).ToList();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public TBYT GetOne(int id)
        { 
            return _db.TBYTs.Find(id);      
        }

        public List<TBYT> Search(string tenTB)
        {
            try
            {
                //return _db.TBYTs.Where(x => x.TenTB.Contains(tenTB)).ToList();
                return _db.TBYTs.Where(x => x.TenTB.Contains(tenTB)).OrderBy(y => y.TenTB).ToList();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool AddNew(TBYT tbyt)
        {
            try
            {
                _db.TBYTs.Add(tbyt);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }        
        }

        public bool Update(TBYT obj)
        {
            bool lreturn = false;
            TBYT tbyt = _db.TBYTs.Find(obj.Id);
            if (tbyt == null)
            {

                lreturn = this.AddNew(obj);
            }
            else
            {
                tbyt.NhomTB = obj.NhomTB;
                tbyt.LoaiTB = obj.LoaiTB;
                tbyt.MaTB = obj.MaTB;
                tbyt.TenTB = obj.TenTB;
                tbyt.Dvt = obj.Dvt;

                tbyt.HangSX = obj.HangSX;
                tbyt.NuocSX = obj.NuocSX;
                tbyt.NamSX = obj.NamSX;
                tbyt.GiaTri = obj.GiaTri;
                tbyt.SoLanBaoTriMotNam = obj.SoLanBaoTriMotNam;             
                
                _db.SaveChanges();
                lreturn = true;
            }
            return lreturn;
        }

        public bool Delete(int Id)
        {
            TBYT tbyt = _db.TBYTs.Find(Id);
            if (tbyt != null)
            {
                _db.TBYTs.Remove(tbyt);
                _db.SaveChanges();
                return true;
            }
            return false;           
        }

        public bool Delete(TBYT obj)
        {
            TBYT tbyt = _db.TBYTs.Find(obj.Id);
            if (tbyt != null)
            {
                _db.TBYTs.Remove(tbyt);
                _db.SaveChanges();
                return true;
            }
            return false;
        }

    }    
}
