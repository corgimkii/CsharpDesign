using System;
using System.Text;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 指定文字列出力クラス
    /// </summary>
    public class StringDisplay : AbstractDisplay
    {
        private string Str { get; set; }
        private int Width { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="str">表示対象の文字列</param>
        public StringDisplay(string str)
        {
            this.Str = str;
            Encoding utf8Enc = Encoding.UTF8;
            this.Width = utf8Enc.GetByteCount(str);
        }

        /// <summary>
        /// 開始
        /// </summary>
        public override void Open()
        {
            this.PrintLine();
        }

        /// <summary>
        /// 表示
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"|{this.Str}|");
        }

        /// <summary>
        /// 終了
        /// </summary>
        public override void Close()
        {
            this.PrintLine();
        }

        /// <summary>
        /// 線を引くメソッド
        /// </summary>
        private void PrintLine()
        {
            Console.Write("+");
            for (int i = 0; i < this.Width; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
        }
    }
}