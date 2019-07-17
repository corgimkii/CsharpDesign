namespace FactoryMethodPattern.Framework
{
    /// <summary>
    /// 「使う」という抽象的な概念だけが定義された『何か』を表すクラス（これだけなら別にインターフェースでもよい）
    /// </summary>
    public abstract class Product
    {
        /// <summary>
        /// 「使う」ということ
        /// </summary>
        public abstract void Use();
    }
}
