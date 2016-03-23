﻿using GuaGuo.Com.WeixinModels;
using GuaGuo.Com.WeixinOrderProvider.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuaGuo.Com.WeixinOrderProvider.Guests
{
    public static class GuestProvider
    {
        public static void AddGuest(Guest guest)
        {
            using (EntityContext entityContext = new EntityContext())
            {
   
                entityContext.GuestS.Add(guest);
                entityContext.SaveChanges();
            }
        

        }
    }
}