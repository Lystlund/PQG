using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public static class World
    {
        public static readonly List<List<Location>> Locations = new List<List<Location>>();
        public static readonly List<Location> City = new List<Location>();
        public static readonly List<Location> Places = new List<Location>();

        public static readonly List<List<Item>> Items = new List<List<Item>>();
        public static readonly List<Item> Readable = new List<Item>();
        public static readonly List<Item> Consumable = new List<Item>();
        public static readonly List<Item> Valuables = new List<Item>();
        public static readonly List<Item> Materials = new List<Item>();
        
        public static readonly List<NPC> NPCs = new List<NPC>();
        public static bool SubQuestDone = false;

        // Location IDs
        public const int LOCATION_ID_FAIRWHEAT = 1;
        public const int LOCATION_ID_STONEWYNNE = 2;
        public const int LOCATION_ID_LINHOLLOW = 3;
        public const int LOCATION_ID_EDGECASTLE = 4;
        public const int LOCATION_ID_MARSHBRIDGE = 5;
        public const int LOCATION_ID_CAMP = 6;
        public const int LOCATION_ID_RUIN = 7;
        public const int LOCATION_ID_CAVE = 8;
        public const int LOCATION_ID_MANSION = 9;
        public const int LOCATION_ID_FOREST = 10; 

        //NPC IDs
        public const int NPC_ID_PAVEL_HINNANT = 1;
        public const int NPC_ID_CHARMAIN_MOCHIZUKI = 2;
        public const int NPC_ID_BENDIX_GEER = 3;
        public const int NPC_ID_RUBEN_LOHRENZ = 4;
        public const int NPC_ID_FLETCHER_BRAY = 5;
        public const int NPC_ID_AEGIDIUS_DRECHSLER = 6;
        public const int NPC_ID_MBALI_BAUER = 7;
        public const int NPC_ID_AULAY_NICHOLSON = 8;
        public const int NPC_ID_GERTRUIDA_CRESPO = 9;
        public const int NPC_ID_CORRIE_NARDOVINO = 10;


        //Item IDs
        public const int ITEM_ID_HEALTHPOTION = 1;
        public const int ITEM_ID_FRESHMEAT = 2;
        public const int ITEM_ID_BOOK = 3;
        public const int ITEM_ID_JEWELRY = 4;
        public const int ITEM_ID_TIMBER_WOOD = 5;
        public const int ITEM_ID_TOME = 6;
        public const int ITEM_ID_SCROLL = 7;
        public const int ITEM_ID_RUNE = 8;
        public const int ITEM_ID_TORCH = 9;
        public const int ITEM_ID_EXPLOSIVES = 10;
        public const int ITEM_ID_MANAPOTION = 11;
        public const int ITEM_ID_SILK = 12;
        public const int ITEM_ID_SPICES = 13;
        public const int ITEM_ID_ART = 14;
        public const int ITEM_ID_GOLD = 15;
        public const int ITEM_ID_STONE = 16;
        public const int ITEM_ID_IRON = 17;
        public const int ITEM_ID_CLAY = 18;
        public const int ITEM_ID_LEATHER = 19;
        public const int ITEM_ID_SCRIPTURE = 20;

        public static Location CurrentLocation { get; set; } 

        static World()
        {
            PopulateLocations();
            PopulateItems();
            PopulateNPC();
        }

        private static void PopulateLocations()
        {
            Location fairwheat = new Location(LOCATION_ID_FAIRWHEAT, "Fairwheat");
            Location stonewynne = new Location(LOCATION_ID_STONEWYNNE, "Stonewynne");
            Location linhollow = new Location(LOCATION_ID_LINHOLLOW, "Linhollow");
            Location edgecastle = new Location(LOCATION_ID_EDGECASTLE, "Edgecastle");
            Location marshbridge = new Location(LOCATION_ID_MARSHBRIDGE, "Marshbridge");

            //Add locations to the static city list
            City.Add(fairwheat);
            City.Add(stonewynne);
            City.Add(linhollow);
            City.Add(edgecastle);
            City.Add(marshbridge);

            Location camp = new Location(LOCATION_ID_CAMP, "Bandit Camp");
            Location ruin = new Location(LOCATION_ID_RUIN, "Old Ruin");
            Location cave = new Location(LOCATION_ID_CAVE, "Troll Cave");
            Location mansion = new Location(LOCATION_ID_MANSION, "Haunted Mansion");
            Location forest = new Location(LOCATION_ID_FOREST, "Dark Forest");

            //add locations to the static places list
            Places.Add(camp);
            Places.Add(ruin);
            Places.Add(cave);
            Places.Add(mansion);
            Places.Add(forest);

            Locations.Add(City);
            Locations.Add(Places);

            CurrentLocation = fairwheat;
        }

        private static void PopulateItems()
        {
            Item HealthPotion = new Item(ITEM_ID_HEALTHPOTION, "Health Potion");
            Item freshMeat = new Item(ITEM_ID_FRESHMEAT, "Fresh Meat");
            Item Book = new Item(ITEM_ID_BOOK, "Book");
            Item Jewelry = new Item(ITEM_ID_JEWELRY, "Jewelry");
            Item Timber = new Item(ITEM_ID_TIMBER_WOOD, "Timber Wood");
            Item Scripture = new Item(ITEM_ID_SCRIPTURE, "Scripture");
            Item Tome = new Item(ITEM_ID_TOME, "Tome");
            Item Scroll = new Item(ITEM_ID_SCROLL, "Scroll");
            Item Rune = new Item(ITEM_ID_RUNE, "Rune");
            Item Torch = new Item(ITEM_ID_TORCH, "Torch");
            Item Explosives = new Item(ITEM_ID_EXPLOSIVES, "Explosives");
            Item ManaPotion = new Item(ITEM_ID_MANAPOTION, "Mana Potion");
            Item Silk = new Item(ITEM_ID_SILK, "Silk");
            Item Spices = new Item(ITEM_ID_SPICES, "Spices");
            Item Art = new Item(ITEM_ID_ART, "Art");
            Item Gold = new Item(ITEM_ID_GOLD, "Gold");
            Item Stone = new Item(ITEM_ID_STONE, "Stone");
            Item Iron = new Item(ITEM_ID_IRON, "Iron ore");
            Item Clay = new Item(ITEM_ID_CLAY, "Clay");
            Item Leather = new Item(ITEM_ID_LEATHER, "Leather");
           
          
            //Add items to the static list
            Consumable.Add(HealthPotion);
            Consumable.Add(freshMeat);
            Consumable.Add(ManaPotion);
            Consumable.Add(Torch);
            Consumable.Add(Explosives);

            Readable.Add(Book);
            Readable.Add(Scripture);
            Readable.Add(Scroll);
            Readable.Add(Rune);
            Readable.Add(Tome);

            Valuables.Add(Jewelry);
            Valuables.Add(Silk);
            Valuables.Add(Spices);
            Valuables.Add(Gold);
            Valuables.Add(Art);

            Materials.Add(Timber);
            Materials.Add(Stone);
            Materials.Add(Clay);
            Materials.Add(Leather);
            Materials.Add(Iron);

            Items.Add(Readable);
            Items.Add(Consumable);
            Items.Add(Valuables);
            Items.Add(Materials);

        }

        private static void PopulateNPC()
        {
            NPC PAVEL_HINNANT = new NPC(NPC_ID_PAVEL_HINNANT, "Pavel Hinnant", RandomLocation());
            NPC CHARMAIN_MOCHIZUKI = new NPC(NPC_ID_CHARMAIN_MOCHIZUKI, "Charmain Mochizuki", RandomLocation());
            NPC BENDIX_GEER = new NPC(NPC_ID_BENDIX_GEER, "Bendix Geer", RandomLocation());
            NPC RUBEN_LOHRENZ = new NPC(NPC_ID_RUBEN_LOHRENZ, "Ruben Lohrenz", RandomLocation());
            NPC FLETCHER_BRAY = new NPC(NPC_ID_FLETCHER_BRAY, "Fletcher Bray", RandomLocation());
            NPC AEGIDIUS_DRECHSLER = new NPC(NPC_ID_AEGIDIUS_DRECHSLER, "Aegidius Drechsler", RandomLocation());
            NPC MBALI_BAUER = new NPC(NPC_ID_MBALI_BAUER, "Mbali Bauer", RandomLocation());
            NPC AULAY_NICHOLSON = new NPC(NPC_ID_AULAY_NICHOLSON, "Aulay Nicholson", RandomLocation());
            NPC GERTRUIDA_CRESPO = new NPC(NPC_ID_GERTRUIDA_CRESPO, "Gertruida Crespo", RandomLocation());
            NPC CORRIE_NARDOVINO = new NPC(NPC_ID_CORRIE_NARDOVINO, "Corrie Nardovino", RandomLocation());

            //Add NPCs to the static list
            NPCs.Add(PAVEL_HINNANT);
            NPCs.Add(CHARMAIN_MOCHIZUKI);
            NPCs.Add(BENDIX_GEER);
            NPCs.Add(RUBEN_LOHRENZ);
            NPCs.Add(FLETCHER_BRAY);
            NPCs.Add(AEGIDIUS_DRECHSLER);
            NPCs.Add(MBALI_BAUER);
            NPCs.Add(AULAY_NICHOLSON);
            NPCs.Add(GERTRUIDA_CRESPO);
            NPCs.Add(CORRIE_NARDOVINO);

            RandomNumberGenerator.NumberBetween(0, Items.Count);
        }       

		public static Item RandomItem(int input = 0) {
            if (input == 0){
                return Items[0][RandomNumberGenerator.NumberBetween(0, Readable.Count)];
            } else if (input == 1)
            {
                return Items[1][RandomNumberGenerator.NumberBetween(0, Consumable.Count)];
            } else if (input == 2)
            {
                return Items[2][RandomNumberGenerator.NumberBetween(0, Valuables.Count)];
            } else
            {
                return Items[3][RandomNumberGenerator.NumberBetween(0, Materials.Count)];
            }
        }

		public static Location RandomLocation(int input = 0) {
            if (input != 0)
            {
                return Locations[1][RandomNumberGenerator.NumberBetween(0, Places.Count)];
            }
            else{
                return Locations[0][RandomNumberGenerator.NumberBetween(0, City.Count)];
            }       
		}

		public static NPC RandomNPC() {
			return NPCs [RandomNumberGenerator.NumberBetween (0, NPCs.Count)];
		}
    }
}
