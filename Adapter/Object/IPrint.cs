using System;

namespace AdapterPattern.Object
{
    /// <summary>
    /// ターゲット
    /// </summary>
    public interface IPrint
    {    
        void PrintWeak();
        void PrintStrong();
    }
}