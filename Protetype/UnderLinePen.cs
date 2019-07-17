using System;
using System.Text;

namespace ProtetypePattern
{
    public class UnderLinePen : IProduct
    {
        private char ulchar;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="ulchar">文字列</param>
        public UnderLinePen(char ulchar)
        {
            this.ulchar = ulchar;
        }

        /// <summary>
        /// 任意の文字列を伴ってプロダクトを使用する
        /// </summary>
        /// <param name="s"></param>
        public void Use(string s)
        {
            Encoding sjisEnc = Encoding.GetEncoding("UTF-8");
            int length = sjisEnc.GetByteCount(s);
            Console.WriteLine($"\"{s}\"");
            Console.Write(" ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(ulchar);
            }
            Console.WriteLine("");
        }

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