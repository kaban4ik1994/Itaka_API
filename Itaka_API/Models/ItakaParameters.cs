using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itaka_API.Models
{
    /*
     * filter = typeof filter !== 'undefined' ? filter : '';
	currpage = typeof currpage !== 'undefined' ? currpage : 1;
	pricetype = typeof pricetype !== 'undefined' ? pricetype : 'person';
	eventtype = typeof eventtype !== 'undefined' ? eventtype : 0;
	date_from = typeof date_from !== 'undefined' ? date_from : '';
	date_to = typeof date_to !== 'undefined' ? date_to : '';
	duration = typeof duration !== 'undefined' ? duration : '';
	adults = typeof adults !== 'undefined' ? adults : 2;
	childs = typeof childs !== 'undefined' ? childs : 0;
	child_age = typeof child_age !== 'undefined' ? child_age : ["12.06.2010"];
	standard = typeof standard !== 'undefined' ? standard : '';
	price = typeof price !== 'undefined' ? price : '';
	promotions = typeof promotions !== 'undefined' ? promotions : ["itakihit"];
	grade = typeof grade !== 'undefined' ? grade : '';
	order = typeof order !== 'undefined' ? order : "recommended|asc";
     */

    public class ItakaParameters
    {
        public ItakaParameters()
        {
            this.Destinations = new List<string>();
            this.Child_Age = new List<string>();
            this.Promotions = new List<string>();
        }

        public string Filter { get; set; }

        public string CurrPage { get; set; }

        public string PriceType { get; set; }

        public string EventType { get; set; }

        public string Date_From { get; set; }

        public string Date_To { get; set; }

        public string Duration { get; set; }

        public string Adults { get; set; }

        public string Childs { get; set; }

        public List<string> Child_Age { get; set; }

        public string Standard { get; set; }

        public string Price { get; set; }

        public List<string> Promotions { get; set; }

        public string Grade { get; set; }

        public string Order { get; set; }
        
        public string Ts { get; set; }

        public List<string> Destinations { get; set; }

        public override string ToString()
        {
            var stringDestinations = Destinations.Aggregate(string.Empty, (current, destination) => current + string.Format("destinations[]={0}&", destination));
            var stringPromotions = Promotions.Aggregate(string.Empty, (current, promotion) => current + string.Format("promotions[]={0}&", promotion));
            var stringChildAges = Child_Age.Aggregate(string.Empty, (current, value) => current + string.Format("child_age[]={0}&", value));
            var result = stringChildAges + stringDestinations + stringPromotions;
            result +=
                string.Format(
                    "filter={0}&currpage={1}&pricetype={2}&eventtype={3}&date_from={4}&date_to={5}&duration={6}&adults={7}&childs={8}&standard={9}&price={10}&grade={11}&order={12}&ts={13}",
                    this.Filter, this.CurrPage, this.PriceType, this.EventType, this.Date_From, this.Date_To,
                    this.Duration, this.Adults, this.Childs, this.Standard, this.Price, this.Grade, this.Order, this.Ts);

            return result;
        }
    }
}