﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Game_Collection
{
    public class Event
    {
        public DateTime date;
        public string platform;
        public int even;
        public int hours;
        public string comment;

        public static string[] events = { "Не пройдена", "Пройдена", "Бесконечная" };

        public Event()
        {
            date = DateTime.Now;
        }

        public Event(Event ev)
        {
            date = ev.date;
            platform = ev.platform;
            even = ev.even;
            hours = ev.hours;
            comment = ev.comment;
        }

        public ListViewItem listItem()
        {
            string[] labels = {date.ToString("dd.MM.yyyy"),
                platform, events[even], hours.ToString(), comment};
            ListViewItem item = new ListViewItem(labels);
            item.Tag = this;
            return item;
        }
    }

    class EventDateComparer : IComparer<Event>
    {
        public int Compare(Event o1, Event o2)
        {
            return o1.date > o2.date ? 1 : -1;
        }
    }
}
