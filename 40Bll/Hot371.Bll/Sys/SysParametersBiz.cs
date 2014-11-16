using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hot371.Dal.Sys;
using Hot371.Model;

namespace Hot371.Bll.Sys
{
    public class SysParametersBiz
    {
        public List<SysParameters> Test()
        {
            var respository = new SysParametersRespository();
            return respository.GetAll().ToList();
        }
    }
}
