using System;
using System.Collections.Generic;
namespace SalonBeauty
{
    public class Client
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public List<string> VisitHistory { get; set; }
        public Client(int id, string fullName, string phone)
        {
            Id = id;
            FullName = fullName;
            Phone = phone;
            VisitHistory = new List<string>();
        }
        public void AddVisit(string serviceName)
        {
            VisitHistory.Add(serviceName);
            Console.WriteLine($"Услуга '{serviceName}' добавлена в историю клиента {FullName}.");
        }
    }
}
