using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    /// <summary>
    /// 本棚を表すクラス
    /// </summary>
    public class BookShelf : IAggregate
    {
        /// <summary>
        /// 本たち
        /// </summary>
        /// <typeparam name="Book"></typeparam>
        /// <returns></returns>
        List<Book> Books = new List<Book>();

        /// <summary>
        /// 最後のインデックス番号
        /// </summary>
        /// <value></value>
        int Last { get; set; } = 0;

        /// <summary>
        /// ランダムアクセス
        /// </summary>
        /// <param name="index">指定するインデックス</param>
        /// <returns>返却する本OBJ</returns>
        public Book GetBookAt(int index)
        {
            return Books[index];
        }

        /// <summary>
        /// 要素アペンド
        /// </summary>
        /// <param name="book">追加する本OBJ</param>
        public void appendBook(Book book)
        {
            this.Books.Add(book);
            Last++;
        }

        /// <summary>
        /// 集合体の長さを取得
        /// </summary>
        /// <returns>最終インデックス</returns>
        public int GetLength()
        {
            return this.Last;
        }

        /// <summary>
        /// イテレータ生成
        /// </summary>
        /// <returns>イテレータ</returns>
        public IIterator Iterator()
        {
            return new BookShelfIterator(this);
        }
    }
}
