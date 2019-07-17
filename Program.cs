using IteratorPattern;
using AdapterPattern.Object;
using AdapterPattern.Class;
using FactoryMethodPattern;
using TemplateMethodPattern;
using SingletonPattern;
using ProtetypePattern;
using BridgePattern;

class Program
{
    /// <summary>
    /// コンソールアプリMain
    /// </summary>
    /// <param name="args">コンソール引数</param>
    static void Main(string[] args)
    {
        // RunIteratorPattern.Run();       // イテレータパターン
        // RunSingletonPattern.Run();      // シングルトンパターン
        // RunClassAdapterPattern.Run();   // アダプターパターン・クラス（継承ベース）
        // RunObjectAdapterPattern.Run();  // アダプターパターン・オブジェクト（委譲ベース）
        // RunFactoryMethodPattern.Run();  // ファクトリーメソッドパターン
        RunTemplateMethodPattern.Run(); // テンプレートメソッドパターン
        // RunProtetypePattern.Run();      // プロトタイプパターン
        // RunBridgePattern.Run();         // ブリッジパターン
    }
}