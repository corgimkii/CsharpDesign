
using System;
using System.Collections.Generic;
using FactoryMethodPattern.Framework;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 所有者と紐づくIDカードクラスのクリエイター
    /// </summary>
    public class IdCardFactory : Factory
    {
        /// <summary>
        /// 所有者たち
        /// </summary>
        /// <typeparam name="string">所有者たち</typeparam>
        /// <returns>所有者たち</returns>
        private List<string> Owners { get; set; } = new List<string>();

        /// <summary>
        /// 所有者を明示してIDカードオブジェクトを作成して返却する
        /// </summary>
        /// <param name="owner">持ち主</param>
        /// <returns>IDカードのオブジェクト</returns>
        protected override Product CreateProduct(string owner)
        {
            return new IdCard(owner);
        }

        /// <summary>
        /// 何かの登録処理を継承する。何かをIDカードにダウンキャストし、所有者だけを取り出して、所有者たちのプロパティに追加する
        /// </summary>
        /// <param name="product">何か</param>
        protected override void RegisterProduct(Product product)
        {
            Owners.Add(((IdCard)product).Owner);
        }
    }
}
