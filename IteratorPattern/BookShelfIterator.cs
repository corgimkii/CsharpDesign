namespace IteratorPattern
{
    /// <summary>
    /// 本棚クラスの反復子
    /// </summary>
    public class BookShelfIterator : IIterator
    {
        /// <summary>
        /// 本棚のオブジェクト
        /// </summary>
        /// <value></value>
        BookShelf BookShelf { get; set; }

        /// <summary>
        /// 本棚クラスのインデックス
        /// </summary>
        /// <value>int</value>
        int Index { get; set; }

        /// <summary>
        /// 本棚クラス反復子コンストラクタ
        /// </summary>
        /// <param name="bookShelf">本棚クラス</param>
        public BookShelfIterator(BookShelf bookShelf)
        {
            this.BookShelf = bookShelf;
            this.Index = 0;
        }

        /// <summary>
        /// 次のオブジェクトが存在するか判定する
        /// </summary>
        /// <returns>存在する：true 存在しない：false</returns>
        public bool HasNext()
        {
            if (Index < BookShelf.GetLength()) {
                return true;
            } else {
                return false;
            }
        }

        /// <summary>
        /// 現在フォーカスされているオブジェクトの、次のオブジェクトを返却する
        /// </summary>
        /// <returns>オブジェクト</returns>
        public object Next()
        {
            Book book = BookShelf.GetBookAt(Index);
            this.Index++;
            return book;
        }
    }
}