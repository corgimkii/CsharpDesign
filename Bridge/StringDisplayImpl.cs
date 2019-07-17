using System;
using System.Text;

namespace BridgePattern
{
    // ConcreteImplementator
    // ・Implementatorを具体的に実装する
    public class StringDisplayImpl : DisplayImpl
    {
        private string str;
        private int width;
        public StringDisplayImpl(string str)
        {
            this.str = str;
            Encoding sjisEnc = Encoding.GetEncoding("UTF-8");
            this.width = sjisEnc.GetByteCount(str);
        }

        public override void RawOpen()
        {
            PrintLine();
        }

        public override void RawPrint()
        {
            Console.WriteLine($"|{str}|");
        }

        public override void RawClose()
        {
            PrintLine();
        }

        public void PrintLine()
        {
            Console.Write("+");
            for (int i = 0; i <width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}