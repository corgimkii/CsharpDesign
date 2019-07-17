using System;

namespace SingletonPattern
{
    /// <summary>
    /// シングルトンで実装されたクラス
    /// </summary>
    public class Singleton
    {
        private static Singleton singleton = new Singleton();
        
        /// <summary>
        /// コンストラクタ
        /// </summary>
        private Singleton()
        {
            Console.WriteLine("シングルトンインスタンスを生成しました。");
        }

        /// <summary>
        /// インスタンスの生成
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            return singleton;
        }
    }
    
    /// <summary>
    /// 非シングルトンで実装されたクラス
    /// </summary>
    public class NotSingleton
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public NotSingleton()
        {
            Console.WriteLine("非シングルトンインスタンスを生成しました。");
        }

        /// <summary>
        /// インスタンスの生成
        /// </summary>
        /// <returns></returns>
        public static NotSingleton GetInstance()
        {
            return new NotSingleton();
        }
    }
}
