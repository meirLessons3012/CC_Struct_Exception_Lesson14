using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Struct_Exception_Lesson14
{
    internal class Waiter
    {
        public string Name { get; set; }
        public Chef Chef { get; set; }

        public Waiter(string name, Chef chef)
        {
            Name = name;
            Chef = chef;
        }
        public string SendOrderToChef(Dishes dishName, int hour)
        {
            try
            {
                if (Chef.MakeDish(dishName, hour, this))
                    return "here your dish...";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }
    }
}
