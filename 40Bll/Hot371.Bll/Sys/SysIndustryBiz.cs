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
        private static readonly string cacheKey = "Hot371.AllIndustry";

        /// <summary>
        /// 获取全部放缓存 1小时
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SysIndustry> GetAll()
        {
            var cache = Caching.Get(cacheKey) as IEnumerable<SysIndustry>;
            if (cache != null)
            {
                return cache;
            }

            var resp = new SysIndustryRespository();
            var all = resp.GetAll();
            try
            {
                Caching.Set(cacheKey, all, 60);
            }
            catch (Exception)
            {
            }
            return all;
        }
    }
}
