using System;

namespace ProtetypePattern
{
    /// <summary>
    /// プロダクト
    /// </summary>
    public interface IProduct : ICloneable
    {
        /// <summary>
        /// 任意の文字列を伴ってプロダクトを使用する
        /// </summary>
        /// <param name="s"></param>
        void Use(string s);

        /// <summary>
        /// オブジェクトのクローン
        /// </summary>
        /// <returns>クローンされたプロダクトのオブジェクト</returns>
        IProduct CreateClone();
    }
}