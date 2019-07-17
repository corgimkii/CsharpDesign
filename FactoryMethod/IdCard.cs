using FactoryMethodPattern.Framework;
using System;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 「使う」という概念だけを持ったクラスである『何か』を継承する。ここではIDカードを表すものとする。
    /// </summary>
    public class IdCard : Product
    {
        /// <summary>
        /// 所有者
        /// </summary>
        /// <value></value>
        public string Owner { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="owner">所有者</param>
        internal IdCard(string owner)
        {
            Console.WriteLine($"{owner}のカードを作ります。");
            this.Owner = owner;
        }

        /// <summary>
        /// 「使う」という概念の実装
        /// </summary>
        public override void Use()
        {
            Console.WriteLine($"{Owner}のカードを使います。");
        }
    }
}
