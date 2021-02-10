using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager1 = new GamerManager(new UserValidationManager());
            Gamer gamer1 = new Gamer() {
                GamerId= 1, 
                BirthYear = 1986,
                FirstName = "Ayşe ",
                LastName = "Yararlı", 
                GamerTc = 12345};

            gamerManager1.Save(gamer1);
            gamerManager1.Update(gamer1);
            gamerManager1.Delete(gamer1);

            GamerManager gamerManager2 = new GamerManager(new UserValidationManager());
            Gamer gamer2 = new Gamer() { GamerId = 1, BirthYear = 1986, FirstName = "Fatma ", LastName = "Yararlı", GamerTc = 123456 };
            gamerManager1.Save(gamer2);

            Game game1 = new Game() { GameId = 2, GameName = "SuDoku", Price = 650 };
            Game game2 = new Game() { GameId=3, GameName = "CandyCrush", Price = 450 };
     


            Campaign campaign1 = new Campaign() { CampaignName = "YENİ ÜYE KAMPANYASI", DiscountRate = 30, CampaignId = 1 };
            Campaign campaign2 = new Campaign() { CampaignName = "SEVGİLİLER GÜNÜ KAMPANYASI", DiscountRate = 50, CampaignId = 2 };


            CampaignManager campaignManager = new CampaignManager();

            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Update(campaign1);
            campaignManager.Update(campaign2);
            campaignManager.Delete(campaign1);
            campaignManager.Delete(campaign2);

           OrderManager orderManager = new OrderManager();
            orderManager.Orders(game1, gamer2);
            orderManager.CampaignOrders(game2, gamer1, campaign2);
        }
    }
}
