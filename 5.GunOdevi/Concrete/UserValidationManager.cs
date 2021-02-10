using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
   public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
           if(gamer.GamerId==1 && gamer.BirthYear==1986 && gamer.FirstName=="Ayşe" && gamer.LastName=="Yararlı" && gamer.GamerTc==12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
