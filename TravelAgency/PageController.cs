using System;

namespace TravelAgency
{
    class PageController
    {
        public static void Home()
        {
            Home home = new Home();
            home.Show();
        }

        public static void HomeAdmin()
        {
            HomeAdmin homeAdmin = new HomeAdmin();
            homeAdmin.Show();
        }

        public static void Offers()
        {
            Offers offers = new Offers();
            offers.Show();
        }

        public static void Contracts()
        {
            Contracts contracts = new Contracts();
            contracts.Show();
        }

        public static void Clients()
        {
            Clients clients = new Clients();
            clients.Show();
        }

        public static void Payments()
        {
            Payments payments = new Payments();
            payments.Show();
        }

        public static void Hotels()
        {
            Hotels hotels = new Hotels();
            hotels.Show();
        }

        public static void TouristGuides()
        {
            TouristGuides touristGuides = new TouristGuides();
            touristGuides.Show();
        }

        public static void Logout()
        {
            User.Username = "";
            Start start = new Start();
            start.Show();
        }

        public static void AddClient()
        {
            AddClient addClient = new AddClient();
            addClient.Show();
        }

        public static void AddHotel()
        {
            AddHotel addHotel = new AddHotel();
            addHotel.Show();
        }

        public static void AddNewClient()
        {
            AddNewClient addNewClient = new AddNewClient();
            addNewClient.Show();
        }

        public static void AddNewHotel()
        {
            AddNewHotel addNewHotel = new AddNewHotel();
            addNewHotel.Show();
        }

        public static void AddNewOffer()
        {
            AddNewOffer addNewOffer = new AddNewOffer();
            addNewOffer.Show();
        }

        public static void AddNewTouristGuide()
        {
            AddNewTouristGuide addNewTouristGuide = new AddNewTouristGuide();
            addNewTouristGuide.Show();
        }

        public static void AddTouristGuide()
        {
            AddTouristGuide addTouristGuide = new AddTouristGuide();
            addTouristGuide.Show();
        }

        public static void CreateContract(int id, string country, string city, int days, string room, string meals, DateTime date_departure, DateTime date_return, int hotel_id, decimal price, decimal transport_price, int tourist_guide_id)
        {
            CreateContract createContract = new CreateContract(id, country, city, days, room, meals, date_departure, date_return, hotel_id, price, transport_price, tourist_guide_id);
            createContract.Show();
        }

        public static void DisplayClient(int id)
        {
            DisplayClient displayClient = new DisplayClient(id);
            displayClient.Show();
        }

        public static void DisplayContract(int id)
        {
            DisplayContract displayContract = new DisplayContract(id);
            displayContract.Show();
        }

        public static void DisplayHotel(int id)
        {
            DisplayHotel displayHotel = new DisplayHotel(id);
            displayHotel.Show();
        }

        public static void DisplayOffer(int id)
        {
            DisplayOffer displayOffer = new DisplayOffer(id);
            displayOffer.Show();
        }

        public static void DisplayPayment(int id)
        {
            DisplayPayment displayPayment = new DisplayPayment(id);
            displayPayment.Show();
        }

        public static void DisplayTouristGuide(int id)
        {
            DisplayTouristGuide displayTouristGuide = new DisplayTouristGuide(id);
            displayTouristGuide.Show();
        }

        public static void DisplayEmployee(int id)
        {
            DisplayEmployee displayEmployee = new DisplayEmployee(id);
            displayEmployee.Show();
        }

        public static void AddNewEmployee()
        {
            AddNewEmployee addNewEmployee = new AddNewEmployee();
            addNewEmployee.Show();
        }
    }
}
