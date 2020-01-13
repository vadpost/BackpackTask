﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpackTask
{
    class Backpack
    {
        /*Далі стоворюємо клас Backpack , який становить і перебирає всі
         набори предметів і вибирає з них найкращий (його загальна маса не більше W,
         а вартість серед відповідних за масою наборів - максимальна).*/
        private List<Item> bestItems = null;
        //У полях зберігається: кращий набір предметів для рюкзака, максимальна маса рюкзака і загальна вартість предметів кращого набору bestItems відповідно.

        private double maxW;

        private double bestPrice;

        public Backpack(double _maxW)
        {
            maxW = _maxW;
        }
        
        // створення всіх наборів перестановок значень
        public void MakeAllSets(List<Item> items)
        {
            if (items.Count > 0)
                CheckSet(items);

            for (int i = 0; i < items.Count; i++)
            {
                List<Item> newSet = new List<Item>(items);

                newSet.RemoveAt(i);

                MakeAllSets(newSet);
            }

        }

        // перевірка, чи є даний набір кращим рішенням завдання
        private void CheckSet(List<Item> items)
        {
            if (bestItems == null)
            {
                if (CalcWeigth(items) <= maxW)
                {
                    bestItems = items;
                    bestPrice = CalcPrice(items);
                }
            }
            else
            {
                if(CalcWeigth(items) <= maxW && CalcPrice(items) > bestPrice)
                {
                    bestItems = items;
                    bestPrice = CalcPrice(items);
                }
            }
        }

        // обчислює загальну вагу набору предметів
        private double CalcWeigth(List<Item> items)
        {
            double sumW = 0;

            foreach(Item i in items)
            {
                sumW += i.weigth;

            }

            return sumW;
        }

        // обчислює загальну вартість набору предметів
        private double CalcPrice(List<Item> items)
        {
            double sumPrice = 0;

            foreach (Item i in items)
            {
                sumPrice += i.price;
            }

            return sumPrice;
        }
        
        // повертає рішення задачі (набір предметів)
        public List<Item> GetBestSet()
        {
            return bestItems;
        }
    }

}