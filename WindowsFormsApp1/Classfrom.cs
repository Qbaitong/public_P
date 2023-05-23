using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 多线程单例
    /// </summary>
    class Classfrom
    {
        /// <summary>
        /// 存放判断是否登陆的值
        /// </summary>
        private bool bol = false;
        /// <summary>
        /// 保存静态变量的实例
        /// 在这里的静态变量实际上是为了form窗体打开与关闭做准备。
        /// </summary>
        private static load _load = null;
        private static Formadd _add = null;
        private static Formt _d = null;
        private static Formaddinformation _information = null;
        private static formnex _nex = null;
        private static Formmex _mex = null;
        private static Formcx _cx = null;
        /// <summary>
        /// 创建一个线程锁
        /// </summary>
        private static readonly object locker = new object();
        /// <summary>
        /// 构造函数私有
        /// </summary>
        private Classfrom()
        {

        }
        /// <summary>
        /// 需要被外部调用的单例方法
        /// </summary>
        public static Formadd add()
        {
            if (_add == null || _add.IsDisposed)
            {
                lock (locker)
                {
                    if (_add == null)
                    {
                        _add = new Formadd();   
                    }
                }
                _add = new Formadd();
            }
            return _add;
        }
        public static load lo()
        {
            if (_load == null || _load.IsDisposed)
            {
                lock (locker)
                {
                    if (_load == null)
                    {
                        _load = new load();
                    }
                }
                _load = new load();
            }
            return _load;
        }
        public static Formt _return()
        {
            if (_d == null || _d.IsDisposed)
            {
                lock (locker)
                {
                    if (_d == null)
                    {
                        _d = new Formt();
                    }
                }
                _d = new Formt();
            }
            return _d;
        }
        public static Formaddinformation _infor()
        {
            if (_information == null || _information.IsDisposed)
            {
                lock (locker)
                {
                    if (_information == null)
                    {
                        _information = new Formaddinformation();
                    }
                }
                _information = new Formaddinformation();
            }
            return _information;
        }
        public static formnex nex()
        {
            if (_nex == null || _nex.IsDisposed)
            {
                lock (locker)
                {
                    if (_nex == null)
                    {
                        _nex = new formnex();
                    }
                }
                _nex = new formnex();
            }
            return _nex;
        }
        public static Formmex mex()
        {
            if (_mex == null || _mex.IsDisposed)
            {
                lock (locker)
                {
                    if (_mex == null)
                    {
                        _mex = new Formmex();
                    }
                }
                _mex = new Formmex();
            }
            return _mex;
        }
        public static Formcx cx()
        {
            if (_cx == null || _cx.IsDisposed)
            {
                lock (locker)
                {
                    if (_cx == null)
                    {
                        _cx = new Formcx();
                    }
                }
                _cx = new Formcx();
            }
            return _cx;
        }
    }
}
