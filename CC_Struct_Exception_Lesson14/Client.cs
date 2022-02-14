using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Struct_Exception_Lesson14
{
    internal class Client
    {
        public Waiter Waiter { get; set; }

        public Client(Waiter waiter)
        {
            Waiter = waiter;
        }
        public void OrderDish(Dishes dishName)
        {
            try
            {
                string result = Waiter.SendOrderToChef(dishName, DateTime.Now.Hour);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
