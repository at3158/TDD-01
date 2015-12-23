using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TDD_01.WEBDATA
{
    public class Cal
    {
        /// <summary>
        /// CalAdd
        /// </summary>
        /// <param name="iNum1"></param>
        /// <param name="iNum2"></param>
        /// <returns></returns>
        public int CalAdd(int iNum1, int iNum2)
        {
            int iCalAdd = 0;
            iCalAdd = iNum1 + iNum2;

            return iCalAdd;

        }

        /// <summary>
        /// CalMin
        /// </summary>
        /// <param name="iNum1"></param>
        /// <param name="iNum2"></param>
        /// <returns></returns>
        public int CalMin(int iNum1, int iNum2)
        {
            int iCalMin = 0;
            iCalMin = iNum1 - iNum2;

            return iCalMin;

        }
    }
}