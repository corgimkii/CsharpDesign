namespace BridgePattern
{
    /// <summary>
    /// ブリッジパターン実行クラス
    /// </summary>
    public static class RunBridgePattern
    {
        public static void Run()
        {
            Display d1 = new Display(new StringDisplayImpl("Hello, Japan."));

            Display d2 = new CountDisplay(new StringDisplayImpl("Hello, World."));

            CountDisplay d3 = new CountDisplay(new StringDisplayImpl("Hello, Universe."));

            d1.Show();

            d2.Show();

            d3.Show();

            d3.MultiDisplay(5);
        }
    }
}
