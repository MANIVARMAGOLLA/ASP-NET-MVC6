using DataAccessLayer;
using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BL
    {
        public int InsertIntoDept(DTO dto)
        {
            try
            {
                DAL dal = new DAL();
                int value = dal.InsrertIntoDept(dto);
                return value;
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
    }
}
