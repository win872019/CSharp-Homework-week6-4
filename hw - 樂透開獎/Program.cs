namespace hw___樂透開獎
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int count=0;   // 跑次數用
            int[] inputNumber = new int[6]; // 輸入的號碼
            int[] prizeNumber = new int[6]; // 開獎號碼
            string[] prize = new string[4] { "6億", "200萬", "1688", "87" }; // 獎金金額
            int checkingQty = 0;    // 對中號碼 數量
            string checking = "您選的號碼裡，中的號碼有 ";

            string gameRules = $"遊戲規則：1~30選出6個號碼，依指示輸入6個號碼\n中6個號碼→頭獎，" +
                $"獎金： {prize[0]}元\n中5個號碼→二獎，獎金： {prize[1]}元\n中4個號碼→三獎，獎金：{prize[2]}元 \n" +
                $"中3個號碼→四獎，獎金：{prize[3]}元\n";

            Console.WriteLine(gameRules);


            // 原 code - bug*
            //for (count = 0; count < prizeNumber.Length; count++)
            //{
            //    Console.Write($"輸入第{count + 1}個號碼： ");
            //    inputNumber[count] = Convert.ToInt32(Console.ReadLine());

            //    // 檢查是否在有效範圍
            //    while (inputNumber[count] < 1 || inputNumber[count] > 30)            //bug
            //    {
            //        Console.Write("輸入無效，請輸入1~30之間的號碼： ");
            //        inputNumber[count] = Convert.ToInt32(Console.ReadLine());
            //    }

            //    // 檢查是否重複輸入
            //    while (count > 0 && Array.IndexOf(inputNumber, inputNumber[count], 0, count) != -1)
            //    {
            //        Console.Write("號碼重複，請輸入未輸入過，1~30之間的號碼： ");
            //        inputNumber[count] = Convert.ToInt32(Console.ReadLine());
            //    }

            //}
            //////////////


            // Observation - 條件式
            //int[] b = new int[] { -5, 4, 5, 6 };
            //int a;
            //Console.Write("輸入數字: ");
            //a = Convert.ToInt32(Console.Read());

            //if (a < 0 && Array.IndexOf(b, a) != -1)  
            //{
            //    Console.WriteLine("Line1");
            //}
            //else                                       //只要有任一不符合上面if的都會跑到else
            //{
            //    Console.WriteLine("Line2");
            //}
            //Console.ReadKey();
            /////////////////

            // 請使用者 依次輸入號碼，檢查輸入的號碼是否符合遊戲規則 
            while (count < prizeNumber.Length)
            {
                Console.Write($"輸入第{count + 1}個號碼： ");
                inputNumber[count] = Convert.ToInt32(Console.ReadLine());

                // 檢查是否在有效範圍
                if (inputNumber[count] < 1 || inputNumber[count] > 30)
                {
                    Console.Write("輸入無效，需輸入1~30之間的號碼， ");
                    continue;
                }


                // 檢查是否重複輸入
                // Array.IndexOf(inputNumber, inputNumber[0], 0, 0) // output: -1
                if (/*count > 0 &&*/ Array.IndexOf(inputNumber, inputNumber[count], 0, count) != -1)
                {
                    Console.Write("號碼重複，需輸入未輸入過，1~30之間的號碼， ");
                    Console.WriteLine(Array.IndexOf(inputNumber, inputNumber[count]));
                    continue;
                }
                
                // 確定符合規則，繼續輸入下一個 & 檢查
                count++;
            }



            // 產生中獎號碼 & 印出
            Random rand = new Random();

            Console.Write("\n開獎號碼： ");

            for (count = 0; count < prizeNumber.Length; count++)
            {
                prizeNumber[count] = rand.Next(1,31 );

                //檢查抽出的亂數是否重複
                while (Array.IndexOf(prizeNumber, prizeNumber[count], 0, count) != -1)
                {
                    prizeNumber[count] = rand.Next(1, 31);
                }                
            }
            Array.Sort(prizeNumber);

            foreach(int e in prizeNumber)
            {
                Console.Write($"{e} ");
            }



            // check 中獎結果
            Array.Sort(inputNumber);

            Console.Write("\n輸入的號碼有: ");
            foreach (int i in inputNumber)
            {
                Console.Write(i+" ");

                //依序檢查輸入號碼 是否有在中獎號碼組
                if (Array.IndexOf(prizeNumber, i, 0) != -1)
                {
                    checkingQty++;      // 中獎號碼個數
                    checking += Convert.ToString(i) + " ";
                }
            }

            // 輸出結果
            if (checkingQty == 0)
            {
                Console.WriteLine($"\n中{checkingQty}個號碼，再接再勵");
            }
            else if (checkingQty > 0 && checkingQty < 3)
            {
                Console.WriteLine($"\n{checking} ，沒有獎金，再接再勵");
            }
            else if (checkingQty == 3)
            {
                Console.WriteLine($"\n{checking} ，四獎，獎金 {prize[3]} 元");
            }
            else if (checkingQty == 4)
            {
                Console.WriteLine($"\n{checking} ，三獎，獎金 {prize[2]} 元");
            }
            else if (checkingQty == 5)
            {
                Console.WriteLine($"\n {checking} ，二獎，獎金 {prize[1]} 元");
            }
            else
            {
                Console.WriteLine($"\n {checking} ，頭獎，獎金 {prize[0]} 元");
            }

            Console.ReadKey();




            //Array 排序 - Observation *
            // Array.Sort(arr) - 小至大 
            // Array.Sort(arr) → Array.Reverse(arr) - 大至小(先排序，再反轉) 
            // Array.Reverse(arr) - 反轉(沒有排序)**
            // 字串也可用

            //int[] a = new int[] { 3,2,6,4,1 };

            //Console.Write("Origin array is ");
            //foreach (int i in a)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine(" ");

            //Array.Sort(a);

            //Console.Write("Sorted array is ");
            //foreach (int i in a)
            //{
            //    Console.Write($"{i} ");
            //}



            // 輸入3 數字，由大到小排列
            //int[] input= new int[3];
            //for(int i=0; i<input.Length;i++)
            //{
            //    Console.Write($"輸入第{i + 1}個數字： ");
            //    input[i]=Convert.ToInt32(Console.ReadLine());
            //}
            //Array.Sort(input);
            //Array.Reverse(input);

            //Console.Write("由大到小排列： ");
            //foreach (int i in input)
            //{
            //    Console.Write(i+" ");
            //}








            // Array.IndexOf(array, searchTarget, startIndex, count) - Observation * 

            //Console.Write("輸入一數字: ");
            //int input = Convert.ToInt32(Console.ReadLine());
            //int[] a = { 1, 2, 3, 4, 5, 6, };
            //Console.WriteLine($"Array.IndexOf(a,input,0,3) = {Array.IndexOf(a, input, 0, 3)}");


        }
    }
}