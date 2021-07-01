using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Crud_application
{
    public class Business_Logic_Layer
    {
        public int Insert(ApplicationLayer ALObject)
        {
            try
            {
                Crud_application.Data_Access_Layer ObjDAL = new Crud_application.Data_Access_Layer();
                return ObjDAL.InsertData(ALObject);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Update(Crud_application.ApplicationLayer ALObject, int Id)
        {
            try
            {
                Crud_application.Data_Access_Layer ObjDAL = new Crud_application.Data_Access_Layer();
                return ObjDAL.UpdateData(ALObject, Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(int Id)
        {
            try
            {
                Crud_application.Data_Access_Layer ObjDAL = new Crud_application.Data_Access_Layer();
                return ObjDAL.DeleteData(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable BindGrid()
        {
            try
            {
                Crud_application.Data_Access_Layer ObjDAL = new Crud_application.Data_Access_Layer();
                return ObjDAL.BindGrid();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetById(int Id)
        {
            try
            {
                Crud_application.Data_Access_Layer ObjDAL = new Crud_application.Data_Access_Layer();
                return ObjDAL.GetById(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}