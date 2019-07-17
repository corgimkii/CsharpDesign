using System;

namespace AdapterPattern.Object
{
    /// <summary>
    /// オブジェクトアダプターパターン実行クラス
    /// </summary>
    public class RunObjectAdapterPattern
    {
        /// <summary>
        /// オブジェクトアダプターパターン実行
        /// </summary>
        public static void Run()
        {
            IPrint p = new PrintBarnner("Hello");

            p.PrintWeak();

            p.PrintStrong();
        }
    }
}