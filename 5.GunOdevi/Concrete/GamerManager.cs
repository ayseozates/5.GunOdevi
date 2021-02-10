using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
       

        public void Save(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Oyuncu sisteme kaydedildi");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız");
            }
            
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu sistemden silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu bilgileri güncellendi");
        }
    }
}
