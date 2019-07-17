using System;

namespace IteratorPattern
{
    public class Book
    {
        /// <summary>
        /// 本の名前
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">本の名前</param>
        public Book(string name)
        {
            this.Name = name;
        }
    }
}