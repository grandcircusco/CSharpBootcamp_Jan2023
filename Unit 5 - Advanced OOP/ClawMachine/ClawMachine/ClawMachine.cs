using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClawMachine
{
    public class ClawMachineObj 
    {
        //properties
        public List<Reward> AllRewards { get; set; }
        public decimal CostToPlay { get; set; }
        //constructor
        public ClawMachineObj()
        {
            CostToPlay = 1.50m;
            AllRewards = new List<Reward>()
            {
                new Reward("Cheap candy", 0.50m),
                new Reward("Cheap candy", 0.50m),
                new Reward("Cheap candy", 0.50m),
                new Reward("Candy Bar", 1.00m),
                new Reward("Candy Bar", 1.00m),
                new Reward("Stuffed Animal", 10.00m)
            };
        }
        //methods
        public Reward GetReward()
        {
            Random rand = new Random();
            return AllRewards[rand.Next(0,AllRewards.Count())];
        }

        public bool MadeProfit(Reward r)
        {
            if(r.Value > CostToPlay)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Play()
        {
            Reward result = GetReward();
            Console.WriteLine(result.Name);
            if (MadeProfit(result) == true)
            {
                Console.WriteLine("You made a profit");
            }
            else
            {
                Console.WriteLine("You lost money");
            }
            //string response = MadeProfit(result) == true ? "You made a profit" : "You lost money";
            //Console.WriteLine(response);
        }

    }
}
