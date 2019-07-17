using System;

namespace IteratorPattern
{
    /// <summary>
    /// 数え上げ、スキャンを表すインターフェース
    /// </summary>
    public interface IIterator
    {
        /// <summary>
        /// 次のオブジェクトが存在するか判定する
        /// </summary>
        /// <returns>存在する：true 存在しない：false</returns>
        bool HasNext();

        /// <summary>
        /// 現在フォーカスされているオブジェクトの、次のオブジェクトを返却する
        /// </summary>
        /// <returns>オブジェクト</returns>
        object Next();
    }
}