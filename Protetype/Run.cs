namespace ProtetypePattern
{
    /// <summary>
    /// プロトタイプパターン実行クラス
    /// </summary>
    public class RunProtetypePattern
    {
        /// <summary>
        /// プロトタイプパターン実行
        /// </summary>
        public static void Run()
        {
            // マネージャーを生成
            Manager manager = new Manager();

            // プロダクトのオブジェクト群を生成
            UnderLinePen upen = new UnderLinePen('~');
            MessageBox mbox = new MessageBox('*');
            MessageBox sbox = new MessageBox('/');
            
            // マネージャーにプロダクトのオブジェクト群を登録
            manager.Register("strong message", upen);
            manager.Register("warning box", mbox);
            manager.Register("slash box", sbox);

            // オブジェクトをクローンして、それぞれ使用する
            IProduct p1 = manager.Create("strong message");
            p1.Use("Hello, world");
            IProduct p2 = manager.Create("warning box");
            p2.Use("Hello, world");
            IProduct p3 = manager.Create("slash box");
            p3.Use("Hello, world");
        }
    }
}
