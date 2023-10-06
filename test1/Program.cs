namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* var */
            //var a = 20;
            //int b = 10, c = 12;



            /* 二進位 - 0b, 十六進位 - 0x */
            //byte dec = 30, bin = 0b00011110, hex = 0x1e;
            //Console.WriteLine(bin + "\n" + hex);



            /* 條件式null運算子 ?? */
            //int? x=null;
            //int y = x ?? 3;
            //Console.WriteLine(y);

            //x = 30;
            //y = x ?? 3;
            //Console.WriteLine(y);


            /* 格式化字串 */
            //float a = 23.4f;
            //string b= a.ToString();
            //Console.WriteLine(b);
            //Console.WriteLine(b.GetType());

            //int c = 123456789;
            //Console.WriteLine(c.ToString("(\\00)##-####"));
            //Console.WriteLine(c.ToString("(\\00)####-####"));
            //Console.WriteLine(c.ToString("(00)##-####"));
            //Console.WriteLine(c.ToString("(0000)##-####"));
            //Console.WriteLine(c.ToString("(0000)####-####"));
            //Console.WriteLine(c.ToString("(0000)#####-####"));
            //Console.WriteLine(c.ToString("(0000)######-####"));
            //Console.WriteLine(c.ToString("(0000)######-######"));


            int a = 2;


            Console.ReadKey();
        }
    }
}