using System;
using System.Collections.Generic;

namespace DEMO_Project
{
    class CustomClass
    {
        protected List<object> _list = new List<object>();

        #region Add
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="item">item</param>
        public void Add(object item)
        {
            _list.Add(item);
        }

        #endregion Add

        #region Remove

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="item">item</param>
        public void Remove(object item)
        {
            //Remove item from list
            _list.Remove(item);
        }

        #endregion Remove

        #region Contains

        /// <summary>
        /// Check list contails item or not
        /// </summary>
        /// <param name="item">item</param>
        /// <returns>bool</returns>
        public bool Contains(object item)
        {
            return _list.Contains(item);
        }

        #endregion Contains

        #region Insert

        /// <summary>
        /// Insert item to list
        /// </summary>
        /// <param name="item">item</param>
        public void Insert(object item)
        {
            _list.Insert(_list.Count, item);
        }

        #endregion Insert

        public IEnumerator<object> GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CustomClass l = new CustomClass();
            l.Add("maneesha");
            l.Add(3.134);
            l.Insert("SaiTej");
            Console.WriteLine((l.Contains("maneesha")));

            // iterate
            foreach (Object m in l)
            {
                Console.WriteLine(m);
            }
        }
    }
}
