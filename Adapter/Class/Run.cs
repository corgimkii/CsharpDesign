using System;

namespace AdapterPattern.Class
{
    /// <summary>
    /// クラスアダプターパターン実行クラス
    /// </summary>
    public class RunClassAdapterPattern
    {
        /// <summary>
        /// クラスアダプターパターン実行
        /// </summary>
        public static void Run()
        {
            IPrint p = new PrintBarnner("Hello");

            p.PrintWeak();

            p.PrintStrong();
        }
    }
}