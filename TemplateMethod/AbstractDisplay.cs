namespace TemplateMethodPattern
{
    /// <summary>
    /// 指定文字列出力の抽象クラス（mixin）
    /// </summary>
    public abstract class AbstractDisplay
    {
        /// <summary>
        /// 開始
        /// </summary>
        public abstract void Open();

        /// <summary>
        /// 表示
        /// </summary>
        public abstract void Print();

        /// <summary>
        /// 終了
        /// </summary>
        public abstract void Close();

        /// <summary>
        /// テンプレートメソッドにあたるメソッド
        /// </summary>
        public void Display()
        {
            this.Open();

            // 何らかの
            for (int i = 0; i < 5; i++)
            {
                this.Print();
            }

            this.Close();
        }
    }
}
