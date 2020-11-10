using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
namespace Rpg_store
{

    internal class Game

    {

        public static Random myRandom = new Random();

        //static Item[] masterInventory = LoadInventory("AnimalsOnly.csv").ToArray();

        /// <summary>

        /// Tha main Game Method

        /// </summary>


        public static void Test()
        {
            IEnumerable<Item> records;
            using (var reader = new StreamReader("path\\to\\file.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                 records = csv.GetRecords<Item>();
                

            }
            
            foreach(int T in )
            

            


            

            

        }/*
        internal static void Play()

        {

            bool isRunning = true;



            Util.Prompt("Welcome to my basic rpg store.");

            //TODO: Initialize things here

            Item[] storeInventory;

            List<Item> playerInventory;



            storeInventory = LoadInventory("store.csv", true).ToArray();

            playerInventory = LoadInventory("player.csv", true);



            storeInventory = GetFullDetails(storeInventory);

            playerInventory = GetFullDetails(playerInventory.ToArray()).ToList<Item>();



            Util.Prompt("Welcome to the pet shop. We got all source of great pets to buy from", true);



            ShowHelp();



            while (isRunning)

            {

                string cmd = Util.Ask("\nWhat do you want do bucko ?").ToLower();

                switch (cmd)

                {

                    case "quit":

                        SaveInventory(storeInventory, "store.csv");

                        SaveInventory(playerInventory.ToArray(), "player.csv");

                        isRunning = false;



                        break;

                    case "help":

                        ShowHelp();

                        break;



                    case "show stock":

                        Util.Prompt("My Stock List is right here....", true);

                        ShowInventory(storeInventory);

                        break;



                    case "inv":

                        Util.Prompt("You have the following in your bag of holding....", true);

                        ShowInventory(playerInventory.ToArray());

                        break;



                    case "trade":

                        ShowInventory(storeInventory);

                        Util.Prompt("Ok then bucko type in the Item ID of the item you want and it's all yours.");

                        int choice1 = 0;

                        while (choice1 == 0)

                        {

                            string itemIDStr = Util.Ask("Item ID>");

                            int.TryParse(itemIDStr, out choice1);

                        }

                        Util.Prompt("-------------");

                        ShowInventory(playerInventory.ToArray());



                        Util.Prompt($"Bucko type in the Item ID of the item you want to give me in exchange for" +

                            $"{storeInventory.First<Item>(iiii => iiii.ItemId == choice1).ItemName}.");



                        int choice2 = 0;

                        while (choice2 == 0)

                        {

                            string itemIDStr = Util.Ask("Item ID>");

                            int.TryParse(itemIDStr, out choice2);

                        }

                        Util.Prompt("-------------");

                        //Swap the 2 items

                        for (int i = 0; i < 10; i++)

                        {

                            if (storeInventory[i].ItemId == choice1)

                            {

                                playerInventory.Add(storeInventory[i]);

                                storeInventory[i] = playerInventory.First<Item>(iiii => iiii.ItemId == choice2);

                                playerInventory.RemoveAll(iiii => iiii.ItemId == choice2);

                            }

                        }





                        break;







                    default:

                        break;

                }

            }

        }



        /// <summary>

        /// Shows the help text

        /// </summary>

        static void ShowHelp()

        {

            Util.Prompt("help shows this help text");

            Util.Prompt("show stock, Shows the vendor stock");

            Util.Prompt("inv shows your inventory");

            Util.Prompt("trade initiate trade");

            Util.Prompt("quit saves both invs and quits");

        }



        static Item[] GetFullDetails(Item[] _items)

        {

            Item[] items2 = new Item[_items.Length];

            for (int i = 0; i < _items.Length; i++)

            {

                items2[i] = masterInventory.First<Item>(iiii => iiii.ItemId == _items[i].ItemId);

            }

            return items2;

        }



        /// <summary>

        /// Shows an inventory

        /// </summary>

        /// <param name="_items"></param>

        static void ShowInventory(Item[] _items)

        {

            foreach (Item it in _items)

            {

                it.PrintDetails();

            }



        }





        static void SaveInventory(Item[] _items, string _fileName)

        {

            using (var writer = new StreamWriter(_fileName))

            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))

            {

                csv.WriteRecords(_items);

            }

        }



        private static List<Item> LoadInventory(string _fileName, bool _generateIfNull = false)

        {

            List<Item> tmpItems = new List<Item>();

            try

            {

                using (var reader = new StreamReader(_fileName))

                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))

                {

                    csv.Configuration.HasHeaderRecord = true;

                    csv.Configuration.MissingFieldFound = null;

                    Item it = null;

                    csv.Read();

                    csv.ReadHeader();



                    while (csv.Read())

                    {

                        switch (csv.GetField("ItemType"))

                        {

                            case "Mammals":

                                it = csv.GetRecord<Mammals>();



                                break;

                            case "Bow":

                                it = csv.GetRecord<Birds>();

                                break;

                            case "Reptiles":

                                it = csv.GetRecord<Reptiles>();

                                break;

                            case "Fish":

                                it = csv.GetRecord<Fish>();

                                break;



                            default:

                                break;

                        }

                        tmpItems.Add(it);

                    }

                }

            }

            catch (Exception)

            {



                //Here if we want we should generate either an empty inventory

                //or a random inventory.

                if (_generateIfNull)

                {

                    List<Item> tmpMasterList = Game.masterInventory.ToList<Item>();

                    for (int i = 0; i < 10; i++)

                    {

                        int r = myRandom.Next(0, tmpMasterList.Count);

                        tmpItems.Add(tmpMasterList.ElementAt(r));

                        tmpMasterList.RemoveAt(r);

                    }



                    using (var writer = new StreamWriter(_fileName))

                    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))

                    {

                        csv.WriteRecords(tmpItems);

                    }



                }

                else

                {





                }



            }

            return tmpItems;

        }

   */ }
}

   

