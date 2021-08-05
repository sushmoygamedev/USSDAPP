using System;

namespace USSDAPP
{
    public enum USSDMENU
    {
        SEND_MONEY = 1,
        SEND_MONEY_TO_NON_BKASH_USER = 2,
        MY_BKASH = 3,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DigiCash\n");
            string[] OptionList = new string[] { "Send Money", "Send Money to Non-bKash User", "Mobile Recharge", "Payment", "Cash Out", "Pay Bill", "Get Tk 75 bonus now", "My bKash", "Reset PIN" };
            string[] OptionMyBkash = new string[] { "Check Balance", "Request Statement", "Change PIN" };

            USSDMENU OptionSelection = USSDMENU.MY_BKASH;
            switch(OptionSelection)
            {
                case USSDMENU.SEND_MONEY:
                    for (int i = 0; i < OptionList.Length; i++)
                    {
                        Console.WriteLine(OptionList[i]);
                    }
                    break;
                case USSDMENU.MY_BKASH:
                    for (int i = 0; i < OptionMyBkash.Length; i++)
                    {
                        Console.WriteLine(OptionMyBkash[i]);
                    }
                    break;
            }
            
        }
    }
}
