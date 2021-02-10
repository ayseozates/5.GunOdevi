using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+ " Kampanya eklendi"+ " İndirim Oranı: "+campaign.DiscountRate);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Kampanya silindi" + " İndirim Oranı: " + campaign.DiscountRate);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Kampanya güncellendi" + "  Yeni İndirim Oranı: " + campaign.DiscountRate);
        }
    }
}
