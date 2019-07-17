using System;

namespace AdapterPattern
{
    /// <summary>
    /// アダプティ（このクラスは開発者自身は変更できないものとする）
    /// </summary>
    public class Banner
    {
        private string str;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="str">文字列</param>
        public Banner(string str)
        {
            this.str = str;
        }

        public void ShowWithPattern()
        {
            Console.WriteLine($"({str})");
        }

        public void ShowWithAster()
        {
            Console.WriteLine($"*{str}*");
        }
    }
}