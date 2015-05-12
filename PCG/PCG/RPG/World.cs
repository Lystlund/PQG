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
        
        //Quality system

        //Quality 1

        public static readonly List<Item> FarmerItems = new List<Item>();
        public static readonly List<Enemies> FarmerEnemies = new List<Enemies>();

        public static readonly List<Item> BardItems = new List<Item>();
        public static readonly List<Skills> BardSkills = new List<Skills>();
        public static readonly List<Enemies> BardEnemies = new List<Enemies>();

        public static readonly List<Item> BlacksmithItems = new List<Item>();
        public static readonly List<Skills> BlacksmithSkills = new List<Skills>();

        public static readonly List<Item> MerchantItems = new List<Item>();
        public static readonly List<Enemies> MerchantEnemies = new List<Enemies>();

        public static readonly List<Item> GuardItems = new List<Item>();
        public static readonly List<Enemies> GuardEnemies = new List<Enemies>();

        //Quality 2

        public static readonly List<Item> MayorItems = new List<Item>();
        public static readonly List<Skills> MayorSkills = new List<Skills>();
        public static readonly List<Enemies> MayorEnemies = new List<Enemies>();

        public static readonly List<Item> KnightItems = new List<Item>();
        public static readonly List<Enemies> KnightEnemies = new List<Enemies>();

        public static readonly List<Item> PriestItems = new List<Item>();
        public static readonly List<Skills> PriestSkills = new List<Skills>();
        public static readonly List<Enemies> PriestEnemies = new List<Enemies>();

        //Quality 3

        public static readonly List<Item> KingItems = new List<Item>();
        public static readonly List<Enemies> KingEnemies = new List<Enemies>();


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
        public const int ITEM_ID_SEEDS = 21;
        public const int ITEM_ID_FARMING = 22;
        public const int ITEM_ID_FOOD = 23;
        public const int ITEM_ID_INSTRUMENTS = 24;
        public const int ITEM_ID_OLDSONGS = 25;
        public const int ITEM_ID_LORE = 26;
        public const int ITEM_ID_COSTUMES = 27;
        public const int ITEM_ID_MASK = 28;



        public static Location CurrentLocation { get; set; } 

        static World()
        {
            PopulateLocations();
            PopulateItems();
            PopulateNPC();
            PopulateQuality();
        }

        private static void PopulateQuality()
        {
            //Quality 1
            //FARMER
            Item Seeds = new Item(ITEM_ID_SEEDS, "Seeds");
            Item FarmingTools = new Item(ITEM_ID_FARMING, "Farming Tools");
            Item Food = new Item(ITEM_ID_FOOD, "Food");
            FarmerItems.Add(Seeds);
            FarmerItems.Add(FarmingTools);
            FarmerItems.Add(Food);

            Enemies Rats = new Enemies("Rats");
            Enemies Boar = new Enemies("Boar");
            Enemies Moles = new Enemies("Moles");
            Enemies Critter = new Enemies("Critter");
            FarmerEnemies.Add(Rats);
            FarmerEnemies.Add(Boar);
            FarmerEnemies.Add(Moles);
            FarmerEnemies.Add(Critter);

            //BARD
            Item Instruments = new Item(ITEM_ID_INSTRUMENTS, "Instruments");
            Item songs = new Item(ITEM_ID_OLDSONGS, "Old Songs");
            Item lore = new Item(ITEM_ID_LORE, "Written Lore");
            Item costume = new Item(ITEM_ID_COSTUMES, "Costume");
            Item mask = new Item(ITEM_ID_MASK, "Mask");
            BardItems.Add(Instruments);
            BardItems.Add(songs);
            BardItems.Add(lore);
            BardItems.Add(costume);
            BardItems.Add(mask);

            Skills learnLute = new Skills("Lute");
            Skills learnflute = new Skills("Flute");
            Skills learnDrums = new Skills("Drums");
            BardSkills.Add(learnLute);
            BardSkills.Add(learnflute);
            BardSkills.Add(learnDrums);

            Enemies Bandits = new Enemies("Bandits");
            Enemies Soldiers = new Enemies("Soldiers");
            Enemies Highwaymen = new Enemies("Highwaymen");
            BardEnemies.Add(Bandits);
            BardEnemies.Add(Soldiers);
            BardEnemies.Add(Highwaymen);

            //BLACKSMITH
            Item Ores = new Item(29, "Ore");
            Item Bars = new Item(30, "Bars");
            Item Weapons = new Item(31, "Weapon");
            Item Armor = new Item(32, "Armor");
            BlacksmithItems.Add(Ores);
            BlacksmithItems.Add(Bars);
            BlacksmithItems.Add(Weapons);
            BlacksmithItems.Add(Armor);

            Skills Smithing = new Skills("Smithing");
            Skills Smelting = new Skills("Smelting");
            Skills Mining = new Skills("Mining");
            BlacksmithSkills.Add(Smithing);
            BlacksmithSkills.Add(Smelting);
            BlacksmithSkills.Add(Mining);

            //MERCHANT
            Item Goods = new Item(33, "Goods");
            Item Jewelry = new Item(ITEM_ID_JEWELRY, "Jewelry");
            Item Silk = new Item(ITEM_ID_SILK, "Silk");
            Item Spices = new Item(ITEM_ID_SPICES, "Spices");
            Item Gold = new Item(ITEM_ID_GOLD, "Gold");
            MerchantItems.Add(Goods);
            MerchantItems.Add(Jewelry);
            MerchantItems.Add(Silk);
            MerchantItems.Add(Spices);
            MerchantItems.Add(Gold);

            Enemies spiders = new Enemies("Spiders");
            MerchantEnemies.Add(Rats);
            MerchantEnemies.Add(spiders);

            //GUARD
            Item Shackles = new Item(34, "Shackles");
            Item Cage = new Item(35, "Cage on Wheels");
            Item Keys = new Item(36, "Keys");
            Item Torch = new Item(37, "Torch");
            Item Gunpowder = new Item(38, "Gunpowder");
            GuardItems.Add(Weapons);
            GuardItems.Add(Shackles);
            GuardItems.Add(Cage);
            GuardItems.Add(Keys);
            GuardItems.Add(Torch);
            GuardItems.Add(Gunpowder);

            Enemies Orcs = new Enemies("Orcs");
            Enemies Undead = new Enemies("Undead");
            GuardEnemies.Add(Bandits);
            GuardEnemies.Add(Soldiers);
            GuardEnemies.Add(Orcs);
            GuardEnemies.Add(Undead);


            //Quality 2
            //MAYOR
            Item books = new Item(ITEM_ID_BOOK, "Books");
            Item blueprints = new Item(39, "Blueprints");
            Item paintings = new Item(40, "Paintings");
            Item wine = new Item(41, "Wine");
            MayorItems.Add(books);
            MayorItems.Add(blueprints);
            MayorItems.Add(paintings);
            MayorItems.Add(wine);

            Skills studyLanguage = new Skills("study Language");
            Skills studyMath = new Skills("study Math");
            Skills alchemy = new Skills("experiment with Alchemy");
            MayorSkills.Add(studyLanguage);
            MayorSkills.Add(studyMath);
            MayorSkills.Add(alchemy);

            Enemies moth = new Enemies("Moth");
            Enemies political = new Enemies("Political Opposition");
            MayorEnemies.Add(Rats);
            MayorEnemies.Add(spiders);
            MayorEnemies.Add(moth);
            MayorEnemies.Add(Highwaymen);
            MayorEnemies.Add(political);

            //KNIGHT
            Item artifact = new Item(42, "Artifact");
            Item MayorsSigil = new Item(43, "Mayors Sigil");
            Item HolyRelic = new Item(44, "Holy Relic");
            KnightItems.Add(artifact);
            KnightItems.Add(MayorsSigil);
            KnightItems.Add(HolyRelic);
            KnightItems.Add(Torch);
            KnightItems.Add(Gunpowder);

            Enemies Ogres = new Enemies("Ogres");
            Enemies Wyvern = new Enemies("Wyvern");
            Enemies Witch = new Enemies("Witch");
            Enemies Bears = new Enemies("Bears");
            Enemies Trolls = new Enemies("Trolls");
            KnightEnemies.Add(Highwaymen);
            KnightEnemies.Add(Bandits);
            KnightEnemies.Add(Ogres);
            KnightEnemies.Add(Wyvern);
            KnightEnemies.Add(Witch);
            KnightEnemies.Add(Bears);
            KnightEnemies.Add(Trolls);

            //PRIEST
            Item Tome = new Item(ITEM_ID_TOME, "Tome");
            Item Scripture = new Item(ITEM_ID_SCRIPTURE, "Scripture");
            Item HolyBook = new Item(45, "Holy Book");
            PriestItems.Add(Tome);
            PriestItems.Add(Scripture);
            PriestItems.Add(HolyRelic);
            PriestItems.Add(HolyBook);

            Skills Rituals = new Skills("Holy Ritual");
            Skills Science = new Skills("Science");
            Skills Sanctifying = new Skills("Sanctifying liquids");

            PriestSkills.Add(studyLanguage);
            PriestSkills.Add(Rituals);
            PriestSkills.Add(Science);
            PriestSkills.Add(Sanctifying);

            Enemies Cultists = new Enemies("Cultists");
            Enemies Infidels = new Enemies("Infidels");
            Enemies Sinners = new Enemies("Sinners");

            PriestEnemies.Add(Cultists);
            PriestEnemies.Add(Infidels);
            PriestEnemies.Add(Sinners);
            PriestEnemies.Add(Undead);

            //Quality 3
            //KING

            Item legendaryArtifact = new Item(46, "Legendary Artifact");
            Item Gems = new Item(47, "Mystical Gem");
            Item MagicalItem = new Item(48, "Magical Item");
            KingItems.Add(legendaryArtifact);
            KingItems.Add(Gems);
            KingItems.Add(MagicalItem);

            Enemies Pretender = new Enemies("Pretender");
            Enemies BanditLeader = new Enemies("Bandit Leader");
            Enemies Rival = new Enemies("Rival");
            Enemies Archmage = new Enemies("Archmage");
            Enemies Dragon = new Enemies("Dragon");
            KingEnemies.Add(Pretender);
            KingEnemies.Add(BanditLeader);
            KingEnemies.Add(Rival);
            KingEnemies.Add(Archmage);
            KingEnemies.Add(Dragon);
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
            NPC PAVEL_HINNANT = new NPC(NPC_ID_PAVEL_HINNANT, "Pavel Hinnant", RandomLocation(), NPC.job.Farmer);
            NPC CHARMAIN_MOCHIZUKI = new NPC(NPC_ID_CHARMAIN_MOCHIZUKI, "Charmain Mochizuki", RandomLocation(), NPC.job.Bard);
            NPC BENDIX_GEER = new NPC(NPC_ID_BENDIX_GEER, "Bendix Geer", RandomLocation(), NPC.job.Blacksmith);
            NPC RUBEN_LOHRENZ = new NPC(NPC_ID_RUBEN_LOHRENZ, "Ruben Lohrenz", RandomLocation(), NPC.job.Merchant);
            NPC FLETCHER_BRAY = new NPC(NPC_ID_FLETCHER_BRAY, "Fletcher Bray", RandomLocation(), NPC.job.Guard);
            NPC AEGIDIUS_DRECHSLER = new NPC(NPC_ID_AEGIDIUS_DRECHSLER, "Aegidius Drechsler", RandomLocation(), NPC.job.Mayor);
            NPC MBALI_BAUER = new NPC(NPC_ID_MBALI_BAUER, "Mbali Bauer", RandomLocation(), NPC.job.Knight);
            NPC AULAY_NICHOLSON = new NPC(NPC_ID_AULAY_NICHOLSON, "Aulay Nicholson", RandomLocation(), NPC.job.Priest);
            NPC GERTRUIDA_CRESPO = new NPC(NPC_ID_GERTRUIDA_CRESPO, "Gertruida Crespo", RandomLocation(), NPC.job.King);
           // NPC CORRIE_NARDOVINO = new NPC(NPC_ID_CORRIE_NARDOVINO, "Corrie Nardovino", RandomLocation(), NPC.job.Farmer);

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
           // NPCs.Add(CORRIE_NARDOVINO);

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

		public static NPC RandomNPC(int input = 0) {

            if (input == 0)
            {
                return NPCs[RandomNumberGenerator.NumberBetween(0, NPCs.Count)];
            }
            else if (input == 1)
            {
                return NPCs[RandomNumberGenerator.NumberBetween(0, 5)];
            }
            else if (input == 2)
            {
                return NPCs[RandomNumberGenerator.NumberBetween(5, 8)];
            }
            else
            {
                return NPCs[RandomNumberGenerator.NumberBetween(8, 8)];
            }
		}
    }
}
