using MicroMEMSApp.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
using TisaSoft.Entities;
using TisaSoft.SysEntities;

namespace TisaSoft.Services
{

    public class LoaiTB_Service
    {
        private readonly ErrorLog_Service _err = new ErrorLog_Service();
        private readonly AppDbContext _dbc;
        public LoaiTB_Service()
        {
            _dbc = new AppDbContext();
        }

        public List<LoaiTB> GetAll()
        {
            try
            {
                return _dbc.LoaiTBs.OrderBy(x => x.ten).ToList();
            }
            catch (Exception ex) { _err.WriteErrLog(ex, "LoaiTB_Service", "GetAll()"); }

            return null;
        }
        public List<LoaiTB> GetAllActive()
        {
            try
            {
                return _dbc.LoaiTBs
                .Where(x => x.isactive == true)
                .OrderBy(x => x.ten).ToList();
            }
            catch (Exception ex) { _err.WriteErrLog(ex, "LoaiTB_Service", "GetAllActive()"); }

            return null;
        }
        public List<LoaiTB_DuTruMS> GetList_LoaiTB_DuTruMS(int pIDKP)
        {
            try
            {
                if (pIDKP == 0)
                {
                    return _dbc.LoaiTB_DuTruMSs
                            .OrderBy(x => x.tenkp)
                            .ThenBy(x => x.idntb)
                            .ThenBy(x => x.tenltb)
                            .ToList();
                }
                else
                {
                    return _dbc.LoaiTB_DuTruMSs
                            .Where(x => x.idkp == pIDKP)
                            .OrderBy(x => x.tenkp)
                            .ThenBy(x => x.idntb)
                            .ThenBy(x => x.tenltb)
                            .ToList();
                }

            }
            catch (Exception ex) { _err.WriteErrLog(ex, "LoaiTB_Service", "GetList_LoaiTB_DuTruMS(int pIDKP)"); }

            return null;
        }
        public List<LoaiTB> Search(string pTen)
        {
            try
            {
                return _dbc.LoaiTBs.Where(x => x.ten.Contains(pTen)).OrderBy(y => y.ten).ToList();
            }
            catch (Exception ex) { _err.WriteErrLog(ex, "LoaiTB_Service", "Search(string pTen)"); }

            return null;
        }

        public LoaiTB GetOne(int pIDLTB)
        {
            try
            {
                return _dbc.LoaiTBs.FirstOrDefault(x => x.idltb == pIDLTB);
            }
            catch (Exception ex) { _err.WriteErrLog(ex, "LoaiTB_Service", "GetOne(int pIDLTB)"); }

            return null;
        }
        public LoaiTB GetOne(string pLoaiTB)
        {
            try
            {
                List<LoaiTB> arr = _dbc.LoaiTBs.Where(x => x.ten.Trim().ToLower() == pLoaiTB.Trim().ToLower()).ToList();
                if (arr.Count > 0)
                    return arr[0];
            }
            catch (Exception ex) { _err.WriteErrLog(ex, "LoaiTB_Service", "GetOne(string pLoaiTB)"); }

            return null;
        }
        public int GetIDByTen(string pTen)
        {
            int nID = 0;

            List<LoaiTB> lst = _dbc.LoaiTBs
                .Where(x => x.ten.ToLower().Trim() == pTen.ToLower().Trim())
                .OrderBy(y => y.ten).ToList();
            if (lst.Count == 1)
                nID = lst[0].idltb;

            return nID;
        }

        private int GetNewID()
        {
            int idReturn = 0;
            try
            {
                if (_dbc.LoaiTBs.Count() > 0)
                    idReturn = _dbc.LoaiTBs.Max(x => x.idltb);
            }
            catch { }

            idReturn++;
            return idReturn;
        }
        public bool AddNew(string pTen)
        {
            bool lReturn = false;
            try
            {
                if (_dbc.LoaiTBs.Where(s => s.ten.ToLower().Trim() == pTen.ToLower().Trim()).ToList().Count == 0)
                {
                    LoaiTB obj = new LoaiTB()
                    {
                        idltb = GetNewID(),
                        ten = pTen,
                        dvt = "Cái",
                        isactive = true,
                        usercreate = Global.gUserID,
                        datecreate = DateTime.Now
                    };

                    _dbc.LoaiTBs.Add(obj);
                    _dbc.SaveChanges();
                    lReturn = true;
                }
            }
            catch (Exception ex) { _err.WriteErrLog(ex, "LoaiTB_Service", "AddNew(string pTen)"); }

            return lReturn;
        }
        public bool AddNew(string pTen, string pDvt)
        {
            bool lReturn = false;
            try
            {
                if (_dbc.LoaiTBs.Where(s => s.ten.ToLower().Trim() == pTen.ToLower().Trim()).ToList().Count == 0)
                {
                    LoaiTB obj = new LoaiTB()
                    {
                        idltb = GetNewID(),
                        ten = pTen,
                        dvt = pDvt,
                        isactive = true,
                        usercreate = Global.gUserID,
                        datecreate = DateTime.Now
                    };

                    _dbc.LoaiTBs.Add(obj);
                    _dbc.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex) { _err.WriteErrLog(ex, "LoaiTB_Service", "AddNew(string pTen, string pDvt)"); }

            return lReturn;
        }
        public bool AddNew(LoaiTB obj)
        {
            bool lReturn = false;
            if (obj == null)
                return false;

            try
            {
                obj.idltb = GetNewID();
                obj.datecreate = DateTime.Now;
                obj.usercreate = Global.gUserID;
                obj.isactive = true;

                _dbc.LoaiTBs.Add(obj);
                _dbc.SaveChanges();
            }
            catch (Exception ex) { _err.WriteErrLog(ex, "LoaiTB_Service", "AddNew(LoaiTB obj)"); }

            return lReturn;
        }

        public bool Update(List<LoaiTB> list)
        {
            bool lReturn = false;
            foreach (LoaiTB obj in list)
            {
                try
                {
                    if (obj.idltb <= 0)
                        obj.idltb = GetNewID();

                    LoaiTB item = _dbc.LoaiTBs.FirstOrDefault(x => x.idltb == obj.idltb);
                    if (item == null)
                        lReturn = AddNew(obj);
                    else
                    {
                        item.ten = obj.ten;
                        item.dvt = obj.dvt;
                        item.hangsx = obj.hangsx;
                        item.model = obj.model;
                        item.idkp = obj.idkp;

                        item.isactive = obj.isactive;

                        _dbc.SaveChanges();

                        lReturn = true;
                    }
                }
                catch (Exception ex) { _err.WriteErrLog(ex, "LoaiTB_Service", "Update(LoaiTB obj) - LoaiTB: " + obj.ten); }
            }

            return lReturn;
        }
        public bool Update(LoaiTB obj)
        {
            bool lReturn = false;
            try
            {
                if (obj.idltb <= 0)
                    obj.idltb = GetNewID();

                LoaiTB item = _dbc.LoaiTBs.FirstOrDefault(x => x.idltb == obj.idltb);
                if (item == null)
                    lReturn = AddNew(obj);
                else
                {
                    item.ten = obj.ten;
                    item.dvt = obj.dvt;
                    item.hangsx = obj.hangsx;
                    item.model = obj.model;
                    item.isactive = obj.isactive;

                    _dbc.SaveChanges();

                    lReturn = true;
                }
            }
            catch (Exception ex) { _err.WriteErrLog(ex, "LoaiTB_Service", "Update(LoaiTB obj)"); }

            return lReturn;
        }
        public int Update(DataTable tbl)
        {
            if (tbl == null || tbl.Rows.Count <= 0)
                return 0;

            int nCount = 0;
            foreach (DataRow row in tbl.Rows)
            {
                nCount += Update(new LoaiTB
                {
                    idltb = int.Parse(row["idltb"].ToString().PadLeft(1, '0')),
                    ten = row["ten"].ToString().Trim()
                }) ? 1 : 0;
            }

            return nCount;
        }

        public int Import(DataTable tbl, ref Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBar)
        {
            if (tbl == null || tbl.Rows.Count <= 0)
                return 0;

            int nCount = 0;
            progressBar.Value = 0;
            progressBar.Maximum = tbl.Rows.Count;

            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                DataRow row = tbl.Rows[i];
                progressBar.Value = i + 1;

                LoaiTB obj = _dbc.LoaiTBs.FirstOrDefault(x => x.ten == row["ten"].ToString().Trim());
                if (obj == null)
                {
                    obj = new LoaiTB
                    {
                        idltb = GetNewID(),
                        ten = row["ten"].ToString().Trim()
                    };

                    try { obj.hangsx = row["hangsx"].ToString(); } catch { }
                    try { obj.model = row["model"].ToString(); } catch { }

                    _dbc.LoaiTBs.Add(obj);
                    nCount++;
                }
            }

            _dbc.SaveChanges();

            return nCount;
        }
        public int Import(DataRow row)
        {
            if (row == null)
                return 0;

            int idReturn = 0;
            string sTen = row["ten"].ToString().Trim();
            int nID = int.Parse(row["idltb"].ToString().Trim());

            if (nID == 0)
                nID = GetNewID();

            if (sTen == "" || sTen == "_")
                return 0;

            LoaiTB find = _dbc.LoaiTBs.FirstOrDefault(x => x.idltb == nID);
            if (find == null)
            {
                LoaiTB obj = new LoaiTB
                {
                    idltb = nID,
                    ten = sTen,
                    usercreate = Global.gUserID
                };

                try { obj.hangsx = row["hangsx"].ToString(); } catch { }
                try { obj.model = row["model"].ToString(); } catch { }

                _dbc.LoaiTBs.Add(obj);
                _dbc.SaveChanges();

                idReturn = GetIDByTen(sTen);
            }

            return idReturn;
        }

        public bool Delete(LoaiTB obj)
        {
            bool lReturn = false;
            try
            {
                LoaiTB item = _dbc.LoaiTBs.FirstOrDefault(x => x.idltb == obj.idltb);
                if (item != null)
                {
                    _dbc.LoaiTBs.Remove(item);
                    _dbc.SaveChanges();
                    lReturn = true;
                }
            }
            catch (Exception ex) { _err.WriteErrLog(ex, "LoaiTB_Service", "Delete(LoaiTB obj)"); }

            return lReturn;
        }
        public bool Delete(int pID)
        {
            bool lReturn = false;
            try
            {
                LoaiTB item = _dbc.LoaiTBs.FirstOrDefault(x => x.idltb == pID);
                if (item != null)
                {
                    _dbc.LoaiTBs.Remove(item);
                    _dbc.SaveChanges();
                    lReturn = true;
                }
            }
            catch (Exception ex) { _err.WriteErrLog(ex, "LoaiTB_Service", "Delete(LoaiTB obj)"); }

            return lReturn;
        }
        public bool Delete(DataRow row)
        {
            if (row == null)
                return false;

            string sTen = row["ten"].ToString().Trim();

            List<LoaiTB> lst = _dbc.LoaiTBs.Where(x => x.ten == sTen).ToList();
            if (lst == null)
            {
                _dbc.LoaiTBs.RemoveRange(lst);
                _dbc.SaveChanges();
            }

            return true;
        }
        public bool Delete(DataTable tbl, ref Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBar)
        {
            if (tbl == null)
                return false;

            progressBar.Value = 0;
            progressBar.Maximum = tbl.Rows.Count;

            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                DataRow row = tbl.Rows[i];
                string sTen = row["ten"].ToString().Trim();

                progressBar.Value = i + 1;

                List<LoaiTB> lst = _dbc.LoaiTBs.Where(x => x.ten == sTen).ToList();
                if (lst != null)
                {
                    _dbc.LoaiTBs.RemoveRange(lst);
                    _dbc.SaveChanges();
                }
            }

            return true;
        }

        bool disposed;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //dispose managed resources
                    _dbc.Dispose();
                    _err.Dispose();
                }
            }

            //dispose unmanaged resources
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
*/