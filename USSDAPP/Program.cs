using System;

namespace USSDAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DigiCash\n");
            string[] OptionList = new string[] { "Send Money", "Send Money to Non-bKash User", "Mobile Recharge", "Payment", "Cash Out", "Pay Bill", "Get Tk 75 bonus now", "My bKash", "Reset PIN" };

            for (int i = 0; i < OptionList.Length; i++)
            {
                Console.WriteLine(i + ". " + OptionList[i]);
            }
        }
    }
}
