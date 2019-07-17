using System;

namespace AdapterPattern.Object
{
    /// <summary>
    /// アダプター
    /// </summary>
    public class PrintBarnner : IPrint
    {
        private Banner obj;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="str">文字列</param>
        public PrintBarnner(string str)
        {
            this.obj = new Banner(str);
            // 処理をBarnnerに委譲しているだけなので、PrintWeak・ShowWithAster以外のメソッドは使用できない。
            // いつの間にBannerに新メソッドが追加されても影響なし
        }

        public void PrintWeak()
        {
            obj.ShowWithPattern();
        }
        
        public void PrintStrong()
        {
            obj.ShowWithAster();
        }
    }
}