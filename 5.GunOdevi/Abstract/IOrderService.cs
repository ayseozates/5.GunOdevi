using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IOrderService
    {
        void Orders(Game game, Gamer gamer);
        void CampaignOrders(Game game, Gamer gamer,Campaign campaign);
    }
}
