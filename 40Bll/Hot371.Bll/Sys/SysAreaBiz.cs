using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hot371.Dal.Sys;
using Hot371.Model;
using QJZ.Framework.Utility;

namespace Hot371.Bll.Sys
{
    /// <summary>
    /// 区划业务逻辑
    /// </summary>
    public class SysAreaBiz
    {
        /// <summary>
        /// 缓存key
        /// </summary>
        private static readonly string cacheKey = "Hot371.AllArea";

        /// <summary>
        /// 获取全部放缓存 1小时
        /// </summary>
        /// <returns></returns>
        private IEnumerable<SysArea> GetAll()
        {
            var cache = Caching.Get(cacheKey) as IEnumerable<SysArea>;
            if (cache != null)
            {
                return cache;
            }

            var resp = new SysAreaRespository();
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

        /// <summary>
        /// 根据等级获取
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public List<SysArea> GetAreaByLevel(int level)
        {
            var all = GetAll();
            var areas = all.Where(a => a.AreaLevel == level).ToList();
            return areas;
        }

        /// <summary>
        /// 根据父区划获取
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public List<SysArea> GetAreaByParent(int pId)
        {
            var all = GetAll();
            var areas = all.Where(a => a.ParentId == pId).ToList();
            return areas;
        }
    }
}
