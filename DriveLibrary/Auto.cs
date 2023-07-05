using System;

namespace DriveLibrary
{
    //Сантурян
    public class Auto : IComparable<Auto>
    {
        public string Title { get; set; }
        public string Number { get; set; }
        public Auto(string title, string number) 
        {
            Title = title;
            Number = number;
        }
        //сделал string, т.к. есть возможность получения данных
        public string Show() => $"Title: {Title}\nNumber: {Number}";

        public int CompareTo(Auto other)=>Title.CompareTo(other.Title);
    }
}
