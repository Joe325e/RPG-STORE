﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rpg_store
{
    internal class Item

    {

        //ItemId,Type,Name

        private int itemId;
        private string itemType;
        private string itemName;
        private int Cost;



        public int ItemId { get => itemId; set => itemId = value; }

        public string ItemType { get => itemType; set => itemType = value; }

        public string ItemName { get => itemName; set => itemName = value; }

        public int cost { get => cost; set => cost = value; }



        public Item()

        {



        }



        public Item(int itemId, string itemType, string itemName)

        {

            ItemId = itemId;

            ItemType = itemType;

            ItemName = itemName;

        }



        public virtual void PrintDetails()

        {

            Util.Prompt("--------------");

            Util.Prompt($" {itemId}, A Splended {itemType} called {itemName}");

        }

    }
}