using System;

namespace AdapterPattern.Class
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