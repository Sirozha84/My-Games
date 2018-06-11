﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace My_Game_Collection
{
    public class DLC
    {
        public DateTime date;
        public string platform;
        public string name;
        public int price;

        public DLC()
        {
            date = DateTime.Now;
        }

        public DLC(DLC dlc)
        {
            date = dlc.date;
            platform = dlc.platform;
            name = dlc.name;
            price = dlc.price;
        }

        public ListViewItem listItem()
        {
            string[] labels = {date.ToString("dd.MM.yyyy"),
                platform, name, price.ToString()};
            ListViewItem item = new ListViewItem(labels);
            item.Tag = this;
            return item;
        }
    }

    class DLCDateComparer : IComparer<DLC>
    {
        public int Compare(DLC o1, DLC o2)
        {
            return o1.date > o2.date ? 1 : -1;
        }
    }
}
