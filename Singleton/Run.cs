using System;

namespace SingletonPattern
{
    /// <summary>
    /// シングルトンパターン実行クラス
    /// </summary>
    public class RunSingletonPattern
    {
        /// <summary>
        /// シングルトンパターン実行
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Start.");

            var obj1 = Singleton.GetInstance();
            var obj2 = Singleton.GetInstance();

            if (obj1 == obj2)
            {
                Console.WriteLine("インスタンスは同一です。");
            }
            else {
                Console.WriteLine("インスタンスは同一ではありません。");
            }

            var obj3 = NotSingleton.GetInstance();
            var obj4 = NotSingleton.GetInstance();

            if (obj3 == obj4)
            {
                Console.WriteLine("インスタンスは同一です。");
            }
            else {
                Console.WriteLine("インスタンスは同一ではありません。");
            }

            Console.WriteLine("End.");
        }
    }
}