using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppoutbook
{
    class Classform
    {
        /// <summary>
        /// 窗体的静态字段
        /// </summary>
        private static Formadd formadd = null;
        private static FormbookBorrow borrow = null;
        private static Formbookreturn ret = null;
        private static FormBorrowingquery query = null;
        private static Formfather fa = null;
        private static Formload loading = null;
        private static Formaddson son = null;
        //私有构造函数
        private Classform()
        {

        }
        //创建一个线程锁
        private static readonly object locker = new object();
        /// <summary>
        /// 图书管理窗体的实例方法
        /// </summary>
        /// <returns></returns>
        public static Formadd _formadd()
        {
            if (formadd == null || formadd.IsDisposed)
            {
                lock (locker)
                {
                    if (formadd == null)
                    {
                        formadd = new Formadd();
                    }
                }
                formadd = new Formadd();
            }
            return formadd;
        }
        /// <summary>
        /// 图书借阅的实例方法
        /// </summary>
        /// <returns></returns>
        public static FormbookBorrow _borrow()
        {
            if (borrow == null || borrow.IsDisposed)
            {
                lock (locker)
                {
                    if (borrow == null)
                    {
                        borrow = new FormbookBorrow();
                    }
                }
                borrow = new FormbookBorrow();
            }
            return borrow;
        }
        /// <summary>
        /// 图书归还的方法
        /// </summary>
        /// <returns></returns>
        public static Formbookreturn _ret()
        {
            if (ret == null || ret.IsDisposed)
            {
                lock (locker)
                {
                    if (ret == null)
                    {
                        ret = new Formbookreturn();
                    }
                }
                ret = new Formbookreturn();
            }
            return ret;
        }
        /// <summary>
        /// 图书查询的方法
        /// </summary>
        /// <returns></returns>
        public static FormBorrowingquery _query()
        {
            if (query == null || query.IsDisposed)
            {
                lock (locker)
                {
                    if (query == null)
                    {
                        query = new FormBorrowingquery();
                    }
                }
                query = new FormBorrowingquery();
            }
            return query;
        }
        /// <summary>
        /// 主窗体的单例实例方法
        /// </summary>
        /// <returns></returns>
        public static Formfather _fat()
        {
            if (fa == null ||fa .IsDisposed)
            {
                lock (locker)
                {
                    if (fa == null)
                    {
                        fa = new Formfather();
                    }
                }
                fa = new Formfather();
            }
            return fa;
        }
        /// <summary>
        /// 登录加载的实例方法
        /// </summary>
        /// <returns></returns>
        public static Formload _loading()
        {
            if (loading == null || loading.IsDisposed)
            {
                lock (locker)
                {
                    if (loading == null)
                    {
                        loading = new Formload();
                    }
                }
                loading = new Formload();
            }
            return loading;
        }
        public static Formaddson _son()
        {
            if (son == null || son.IsDisposed)
            {
                lock (locker)
                {
                    if (son == null)
                    {
                        son = new Formaddson();
                    }
                }
                son = new Formaddson();
            }
            return son;
        }
       
    }
}
