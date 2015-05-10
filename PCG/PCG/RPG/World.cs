using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public static class World
    {
        public static readonly List<Location> Locations = new List<Location>();
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<NPC> NPCs = new List<NPC>();

        // Location IDs
        public const int LOCATION_ID_FAIRWHEAT = 1;
        public const int LOCATION_ID_STONEWYNNE = 2;
        public const int LOCATION_ID_LINHOLLOW = 3;
        public const int LOCATION_ID_EDGECASTLE = 4;
        public const int LOCATION_ID_MARSHBRIDGE = 5;

        //NPC IDs
        public const int NPC_ID_PAVEL_HINNANT = 1;
        public const int NPC_ID_CHARMAIN_MOCHIZUKI = 2;
        public const int NPC_ID_BENDIX_GEER = 3;

        //Item IDs
        public const int ITEM_ID_HEALTHPOTION = 1;
        public const int ITEM_ID_FRESHMEAT = 2;

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


            //Add location to the static list
            Locations.Add(fairwheat);
            Locations.Add(stonewynne);
            Locations.Add(linhollow);
            Locations.Add(edgecastle);
            Locations.Add(marshbridge);

			CurrentLocation = fairwheat;
        }

        private static void PopulateItems()
        {
            Item HealthPotion = new Item(ITEM_ID_HEALTHPOTION, "Health Potion");
            Item freshMeat = new Item(ITEM_ID_FRESHMEAT, "Fresh Meat");

            //Add items to the static list
            Items.Add(HealthPotion);
            Items.Add(freshMeat);
        }

        private static void PopulateNPC()
        {
            NPC PAVEL_HINNANT = new NPC(NPC_ID_PAVEL_HINNANT, "Pavel Hinnant", RandomLocation());
            NPC CHARMAIN_MOCHIZUKI = new NPC(NPC_ID_CHARMAIN_MOCHIZUKI, "Charmain Mochizuki", RandomLocation());
            NPC BENDIX_GEER = new NPC(NPC_ID_BENDIX_GEER, "Bendix Geer", RandomLocation());

            //Add NPCs to the static list
            NPCs.Add(PAVEL_HINNANT);
            NPCs.Add(CHARMAIN_MOCHIZUKI);
            NPCs.Add(BENDIX_GEER);
        }       
                
        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }

            return null;
        }

        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static NPC NPCbyID(int id)
        {
            foreach (NPC npc in NPCs)
            {
                if (npc.ID == id)
                {
                    return npc;
                }
            }

            return null;
        }

		public static Item RandomItem() {
			return Items[RandomNumberGenerator.NumberBetween (0, Items.Count)];
		}

		public static Location RandomLocation() {
			return Locations[RandomNumberGenerator.NumberBetween (0, Locations.Count)];
		}

		public static NPC RandomNPC() {
			return NPCs [RandomNumberGenerator.NumberBetween (0, NPCs.Count)];
		}
    }
}
