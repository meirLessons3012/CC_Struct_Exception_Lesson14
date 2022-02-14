using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Struct_Exception_Lesson14
{
    internal class Chef
    {

        public int Counter { get; set; }
        public Dishes Dish { get; set; }

        public bool MakeDish(Dishes dishName, int hour, Waiter waiter)
        {
            try
            {
                Dish = dishName;
                switch (dishName)
                {
                    case Dishes.Falafel:
                        if (Stock.Pitot < 1)
                            throw new PitotOutOfStockException("no pitot in stock");
                        if (Stock.Falafel < 5)
                            throw new FalafelOutOfStockException("no falafels in stock");
                        Stock.Falafel -= 5;
                        Stock.Pitot--;
                        return true;
                    case Dishes.Shawarma:
                        if (Stock.Lafot < 1)
                            throw new LafotOutOfStockException("no lafot in stock");
                        Stock.Lafot--;
                            return true;
                }
                return false;
            }
            catch (PitotOutOfStockException ex)
            {
                BuyItems("Pitot");
                MakeDish(dishName, hour, waiter);
            }
            catch (LafotOutOfStockException ex)
            {
                BuyItems("Lafot");
                MakeDish(dishName, hour, waiter);
            }
            catch(FalafelOutOfStockException ex)
            {
                throw new DishNotValidException("sorry, but your dish is not valid for now...", ex);
            }
            return false;
        }

        private void BuyItems(string item)
        {
            switch (item)
            {
                case "Lafot":
                    Stock.Lafot += 20;
                    break;
                case "Pitot":
                    Stock.Pitot += 20;
                    break;
            }
        }
    }
}
