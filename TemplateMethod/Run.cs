namespace TemplateMethodPattern
{
    /// <summary>
    /// テンプレートメソッドパターン実行クラス
    /// </summary>
    public class RunTemplateMethodPattern
    {
        /// <summary>
        /// テンプレートメソッドパターン実行
        /// </summary>
        public static void Run()
        {
            AbstractDisplay d1 = new CharDisplay('あ');
            AbstractDisplay d2 = new StringDisplay("Hello!");
            AbstractDisplay d3 = new StringDisplay("ウェーイｗｗｗ");

            d1.Display();
            d2.Display();
            d3.Display();
        }
    }
}