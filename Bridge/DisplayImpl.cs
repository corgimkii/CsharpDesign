namespace BridgePattern
{
    // Implementor
    // ・実装のクラス階層の最上位クラス
    // ・Abstranctionのインターフェース（API）を規定する
    public abstract class DisplayImpl
    {
        public abstract void RawOpen();
        
        public abstract void RawPrint();

        public abstract void RawClose();
    }
}