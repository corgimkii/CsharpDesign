using System;

namespace AdapterPattern.Class
{
    /// <summary>
    /// アダプター
    /// </summary>
    public class PrintBarnner : Banner, IPrint
    {
        public PrintBarnner(string str) : base(str) { }
        // 継承しているので、PrintWeak・ShowWithAster以外のメソッドも使用できてしまう。
        // いつの間にBannerに新メソッドが追加されたらこのクラスも肥大化する！

        public void PrintWeak()
        {
            this.ShowWithPattern();
        }
        
        public void PrintStrong()
        {
            this.ShowWithAster();
        }
    }
}