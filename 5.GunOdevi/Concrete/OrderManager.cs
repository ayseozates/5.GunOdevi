using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class OrderManager : IOrderService
    {
      
        public void CampaignOrders(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(game.GameName+" Oyununu "+ gamer.FirstName+" adlı oyuncu "+ campaign.CampaignName+" adlı kampanya ile aldı");
        }

        public void Orders(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + " Oyununu " + gamer.FirstName + " adlı oyuncu  aldı");
        }
    }
}
