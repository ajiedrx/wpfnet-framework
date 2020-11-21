using System;

namespace Velacro.UIElements.Basic {
    public class MyDateTime : IMyDateTime
    {
        private DateTime dateTime;
        public MyDateTime() { }

        public DateTime getDateTime() {
            this.dateTime = new DateTime();
            return this.dateTime;
        }

        public DateTime getDateTime(string _date) { 
            this.dateTime = DateTime.Parse(_date);
            return this.dateTime;
        }

        public DateTime getDateTime(int _year, int _month, int _day) {
            this.dateTime = new DateTime(_year, _month, _day);
            return this.dateTime;
        }

        public DateTime getCurrentDate() {
            this.dateTime = DateTime.Today;
            return this.dateTime;
        }

        public DateTime getCurrentDateAndTime() {
            this.dateTime = DateTime.Now; 
            return this.dateTime; 
        }
    }
}
