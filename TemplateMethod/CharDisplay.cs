using System;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 指定文字出力クラス
    /// </summary>
    public class CharDisplay : AbstractDisplay
    {
        /// <summary>
        /// 表示対象の文字
        /// </summary>
        /// <value>表示対象の文字</value>
        private char Ch { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="ch">表示対象の文字</param>
        public CharDisplay(char ch)
        {
            this.Ch = ch;
        }

        /// <summary>
        /// 開始
        /// </summary>
        public override void Open()
        {
            Console.Write("<<");
        }

        /// <summary>
        /// 表示
        /// </summary>
        public override void Print()
        {
            Console.Write(Ch);
        }

        /// <summary>
        /// 終了
        /// </summary>
        public override void Close()
        {
            Console.WriteLine(">>");
        }   
    }
}