namespace BridgePattern
{
    // RefinedAbstraction
    // ・Abstractionに対して機能を追加
    public class CountDisplay : Display
    {
        public CountDisplay(DisplayImpl impl) : base(impl) { }

        /// <summary>
        ///  指定された回数だけ表示を行う
        /// </summary>
        /// <param name="times">表示回数</param>
        public void MultiDisplay(int times)
        {
            // 開く!
            Open();

            // 指定された回数だけ表示を行う
            for (int i = 0; i < times; i++)
            {
                Print();
            }

            // 閉じる!
            Close();
        }
    }
}