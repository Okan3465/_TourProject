using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccessLayer.Concrate.EFCore.EfCoreRouteRepository;

namespace DataAccessLayer.Concrate.EFCore
{
    public class SeedDatabase
    {
        public static void Seed()
        {
            var context = new TurContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Routes.Count() == 0)
                {
                    context.Routes.AddRange(Routes);
                }

                if (context.Tickets.Count() == 0)
                {
                    context.Tickets.AddRange(Tickets);
                }

                if (context.Cities.Count() == 0)
                {
                    context.Cities.AddRange(Cities);
                }            
                context.SaveChanges();
            }
        }

        private static Route[] Routes =
        {
            new Route() {Start="İstanbul",Route1="İzmit",Route2="Bursa",Route3="Eskişehir",Finish="Ankara",date="27.06.2022",Time="18:00",ImageUrl="1.jpg",Price=200 },
             new Route() {Start="Ankara",Route1="Kahramanmaraş",Route2="Gaziantep",Route3="Şanlıurfa",Finish="Mardin",date="27.06.2022",Time="15:00",ImageUrl="2.jpg",Price=400 }
        };

        private static Ticket[] Tickets =
        {
            new Ticket() {Name="Veli",Surname="Seyrek",Mail="veli@gmail.com",From="İstanbul",To="Ankara",SeatNo=1,Price=200,RouteId=1},
            new Ticket() {Name="Doğukan",Surname="Durkaya",Mail="dogukan@gmail.com",From="İstanbul",To="Bursa",SeatNo=10,Price=100,RouteId=1},
            new Ticket() {Name="Yasemin",Surname="Mutlu",Mail="yasemin@gmail.com",From="İstanbul",To="İzmit",SeatNo=1,Price=200,RouteId=1},
            new Ticket() {Name="Esra",Surname="Topçuoğlu",Mail="esra@gmail.com",From="İstanbul",To="Eskişehir",SeatNo=1,Price=200,RouteId=1},
            new Ticket() {Name="Ahmet",Surname="Yıldız",Mail="ahmetyıldız@gmail.com",From="Bursa",To="Ankara",SeatNo=1,Price=200,RouteId=1},
            new Ticket() {Name="Okan",Surname="Karakoç",Mail="okan@gmail.com",From="Ankara",To="Şanlıurfa",SeatNo=1,Price=200,RouteId=2},
            new Ticket() {Name="Salih",Surname="Demir",Mail="salih@gmail.com",From="Ankara",To="Kahramanmaraş",SeatNo=1,Price=200,RouteId=2},
            new Ticket() {Name="Murat",Surname="Yıldırım",Mail="murat@gmail.com",From="Ankara",To="Gaziantep",SeatNo=1,Price=200,RouteId=2},
            new Ticket() {Name="Ömer",Surname="Duman",Mail="omerduman@gmail.com",From="Ankara",To="Mardin",SeatNo=1,Price=200,RouteId=2},
            new Ticket() {Name="Sezen",Surname="Aksu",Mail="veli@gmail.com",From="Gaziantep",To="Mardin",SeatNo=1,Price=200,RouteId=2},
        };

        private static City[] Cities =
        {
            new City() {CityName="İstanbul"},
            new City() {CityName="İzmit"},
            new City() {CityName="Bursa"},
            new City() {CityName="Eskişehir"},
            new City() {CityName="Ankara"},
            new City() {CityName="Kahramanmaraş"},
            new City() {CityName="Gaziantep"},
            new City() {CityName="Şanlıurfa"},
            new City() {CityName="Mardin"}
        };

     
    }
}
