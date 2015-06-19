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
        public string Filter { get; set; }

        public string CurrPage { get; set; }

        public string PriceType { get; set; }

        public string EventType { get; set; }

        public string Date_From { get; set; }

        public string Date_To { get; set; }

        public string Duration { get; set; }

        public string Adults { get; set; }

        public string Childs { get; set; }

        public string Child_Age { get; set; }

        public string Standard { get; set; }

        public string Price { get; set; }

        public string Promotions { get; set; }

        public string Grade { get; set; }

        public string Order { get; set; }
        public string Ts { get; set; }
    }
}