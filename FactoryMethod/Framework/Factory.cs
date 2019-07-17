namespace FactoryMethodPattern.Framework
{
    /// <summary>
    /// 「所有者が明らかになっている『何か』を作成する」という動きだけが実装されているクラス
    /// 「『何か』を登録する」
    /// </summary>
    public abstract class Factory
    {
        /// <summary>
        /// 所有者が明らかになっている『何か』を作成し、「何か」にまつわる一部を登録し、返却する
        /// </summary>
        /// <param name="owner">所有者</param>
        /// <returns>何か</returns>
        public Product Create(string owner)
        {
            Product p = CreateProduct(owner);
            RegisterProduct(p);

            return p;
        }

        /// <summary>
        /// 何かを作成して返却するという概念
        /// </summary>
        /// <param name="owner"></param>
        /// <returns>所有者</returns>
        protected abstract Product CreateProduct(string owner);

        /// <summary>
        /// 何かを登録するという概念
        /// </summary>
        /// <param name="product">何か</param>
        protected abstract void RegisterProduct(Product product);
    }
}
