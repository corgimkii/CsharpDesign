using System;
using System.Text;

namespace ProtetypePattern
{
    /// <summary>
    /// メッセージボックスクラス
    /// </summary>
    public class MessageBox : IProduct
    {
        /// <summary>
        /// メッセージボックスの飾り文字
        /// </summary>
        private char decochar;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="str">使用する飾り文字</param>
        public MessageBox(char str)
        {
            this.decochar = str;
        }

        /// <summary>
        /// メッセージボックスの利用
        /// </summary>
        /// <param name="s">メッセージボックスに使用する文字列</param>
        public void Use(string s)
        {
            Encoding utf8Enc = Encoding.GetEncoding("UTF-8");
            int length = utf8Enc.GetByteCount(s);

            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(decochar);
            }
            Console.WriteLine("");
            Console.WriteLine($"{decochar} {s} {decochar}");
            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(decochar);
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// オブジェクトのクローン
        /// </summary>
        /// <returns>クローンされたオブジェクト</returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        /// <summary>
        /// オブジェクトのクローン
        /// </summary>
        /// <returns>クローンされたプロダクトのオブジェクト</returns>
        public IProduct CreateClone()
        {
            return (IProduct)this.Clone();
        }
    }
}
