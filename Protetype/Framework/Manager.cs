using System.Collections.Generic;

namespace ProtetypePattern
{
    public class Manager
    {
        /// <summary>
        /// ショーケース
        /// </summary>
        /// <typeparam name="string">キー</typeparam>
        /// <typeparam name="IProduct">プロダクト</typeparam>
        /// <returns></returns>
        private Dictionary<string, IProduct> showcase = new Dictionary<string, IProduct>();

        /// <summary>
        /// ショーケースにプロダクトを登録
        /// </summary>
        /// <param name="name">プロダクト名</param>
        /// <param name="proto">プロト</param>
        public void Register(string name, IProduct proto)
        {
            showcase.Add(name, proto);
        }

        /// <summary>
        /// ショーケースの指定したキーのプロダクトをクローンする
        /// </summary>
        /// <param name="protoname"></param>
        /// <returns></returns>
        public IProduct Create(string protoname)
        {
            IProduct p = showcase[protoname];
            return p.CreateClone();
        }
    }
}