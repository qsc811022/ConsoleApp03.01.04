using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp03._01._04
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10, number2 = 99;

            // step 1,先用 temp變數存放 number1 值
            int temp = number1;

            // step 2, 異動 number1 值
            number1 = number2;

            // step 3, 異動 number2 值
            number2 = temp;

            Console.WriteLine($"對調的結果: number1={number1}, number2={number2}");


            //應用時機:

            //有時在做查詢功能時, 例如想找出某一日期區間的訂單, 但使用者居然吧開始 / 結束日的值寫相反, 或者想查詢售價在某二個數值之間的商品, 但把數值大小寫相反; 就會需要把值對調
        }
    }
}
