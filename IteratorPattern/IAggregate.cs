using System;

namespace IteratorPattern
{
    /// <summary>
    /// 集合体を表すインターフェース
    /// </summary>
    public interface IAggregate
    {
        IIterator Iterator();
    }
}