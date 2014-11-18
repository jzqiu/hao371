using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hot371.Dal.Sys;
using Hot371.Model;
using QJZ.Framework.Utility;

namespace Hot371.Bll.Sys
{
    public class SysIndustryBiz
    {
        /// <summary>
        /// 缓存key
        /// </summary>
        private const string CacheKey = "Hot371.AllIndustry";

        private readonly SysIndustryRespository _respository;

        public SysIndustryBiz()
        {
            this._respository=new SysIndustryRespository();
        }

        /// <summary>
        /// 获取全部放缓存 1小时
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SysIndustry> GetAll()
        {
            var cache = Caching.Get(CacheKey) as IEnumerable<SysIndustry>;
            if (cache != null)
            {
                return cache;
            }

            var all = _respository.GetAll();
            try
            {
                Caching.Set(CacheKey, all, 60);
            }
            catch (Exception)
            {
            }
            return all;
        }
    }
}
