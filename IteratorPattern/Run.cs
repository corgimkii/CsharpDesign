using System;

namespace IteratorPattern
{
    /// <summary>
    /// イテレータパターン実行クラス
    /// </summary>
    public class RunIteratorPattern
    {
        /// <summary>
        /// イテレータパターン実行
        /// </summary>
        public static void Run()
        {
            BookShelf bookShelf = new BookShelf(); //本棚obj生成

            // 本を追加していく
            bookShelf.appendBook(new Book("エロ本"));
            bookShelf.appendBook(new Book("技術書"));
            bookShelf.appendBook(new Book("マンガ"));

            // この本棚を参照するイテレータを生成する
            IIterator it = bookShelf.Iterator();

            // 要素がなくなるまで繰り返し
            while (it.HasNext())
            {
                Book book = (Book)it.Next();
                Console.WriteLine(book.Name);
            }
        }
    }
}