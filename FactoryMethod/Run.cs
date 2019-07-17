using FactoryMethodPattern;
using FactoryMethodPattern.Framework;

namespace FactoryMethodPattern
{
    /// <summary>
    /// ファクトリーメソッドパターン実行クラス
    /// </summary>
    public class RunFactoryMethodPattern
    {
        /// <summary>
        /// ファクトリーメソッドパターン実行
        /// </summary>
        public static void Run()
        {
            Factory factory = new IdCardFactory();

            // => 林健一のカードを作ります。
            Product card1 = factory.Create("林健一");

            // => 林健二のカードを作ります。
            Product card2 = factory.Create("林健二");

            // => 林健一のカードを使います。
            card1.Use();

            // => 林健二のカードを使います。
            card2.Use();
        }
    }
}
