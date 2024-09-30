using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        static List<string> dota = new List<string>() {
            "ABADDON", "ALCHEMIST", "ANCIENT APPARITION", "ANTI-MAGE", "ARC WARDEN", "AXE", "BANE", "BATRIDER", "BEASTMASTER", "BLOODSEEKER",
    "BOUNTY HUNTER", "BREWMASTER", "BRISTLEBACK", "BROODMOTHER", "CENTAUR WARRUNNER", "CHAOS KNIGHT", "CHEN", "CLINKZ", "CLOCKWERK", "CRYSTAL MAIDEN",
    "DARK SEER", "DARK WILLOW", "DAZZLE", "DEATH PROPHET", "DISRUPTOR", "DOOM", "DRAGON KNIGHT", "DROW RANGER", "EARTH SPIRIT", "EARTHSHAKER",
    "ELDER TITAN", "EMBER SPIRIT", "ENCHANTRESS", "ENIGMA", "FACELESS VOID", "GRIMSTROKE", "GYROCOPTER", "HOODWINK", "HUSKAR", "INVOKER",
    "IO", "JAKIRO", "JUGGERNAUT", "KEEPER OF THE LIGHT", "KUNKKA", "LEGION COMMANDER", "LESHRAC", "LICH", "LIFE STEALER", "LINA",
    "LION", "LONE DRUID", "LUNA", "LYCAN", "MAGNUS", "MARCI", "MARS", "MEDUSA", "MEEPO", "MIRANA",
    "MONKEY KING", "MORPHLING", "NAGA SIREN", "NATURE'S PROPHET", "NECROPHOS", "NIGHT STALKER", "NYX ASSASSIN", "OGRE MAGI", "OMNIKNIGHT", "ORACLE",
    "OUTWORLD DESTROYER", "PANGOLIER", "PHANTOM ASSASSIN", "PHANTOM LANCER", "PHOENIX", "PRIMAL BEAST", "PUCK", "PUDGE", "PUGNA", "QUEEN OF PAIN",
    "RAZOR", "RIKI", "RUBICK", "SAND KING", "SHADOW DEMON", "SHADOW FIEND", "SHADOW SHAMAN", "SILENCER", "SKYWRATH MAGE", "SLARDAR",
    "SLARK", "SNAPFIRE", "SNIPER", "SPECTRE", "SPIRIT BREAKER", "STORM SPIRIT", "SVEN", "TECHIES", "TEMPLAR ASSASSIN", "TERRORBLADE",
    "TIDEHUNTER", "TIMBERSAW", "TINKER", "TINY", "TREANT PROTECTOR", "TROLL WARLORD", "TUSK", "UNDERLORD", "UNDYING", "URSA",
    "VENOMANCER", "VIPER", "VISAGE", "VOID SPIRIT", "WARLOCK", "WEAVER", "WINDRANGER", "WINTER WYVERN", "WITCH DOCTOR", "WRAITH KING",
    "ZEUS"
        };

        static List<string> actorss = new List<string>() {
    "LEONARDO DICAPRIO", "BRAD PITT", "TOM CRUISE", "JOHNNY DEPP",
    "WILL SMITH", "CHRIS EVANS", "RYAN REYNOLDS", "DENZEL WASHINGTON",
    "SCARLETT JOHANSSON", "MARGOT ROBBIE", "ANGELINA JOLIE",
    "MATTHEW MCCONAUGHEY", "JASON MOMOA", "KEANU REEVES",
    "CHRISTIAN BALE", "MORGAN FREEMAN", "TOM HANKS",
    "JENNIFER LAWRENCE", "EMMA STONE", "JULIA ROBERTS", "NATALIE PORTMAN", "EMMA WATSON",
    "IDRIS ELBA", "VIN DIESEL", "JARED LETO", "JAKE GYLLENHAAL",
    "ZENDAYA"
        };

        static List<string> europeCountries = new List<string>() {
    "ALBANIA", "ANDORRA", "ARMENIA", "AUSTRIA", "AZERBAIJAN",
    "BELARUS", "BELGIUM", "BOSNIA AND HERZEGOVINA", "BULGARIA", "CROATIA",
    "CYPRUS", "CZECH REPUBLIC", "DENMARK", "ESTONIA", "FINLAND",
    "FRANCE", "GEORGIA", "GERMANY", "GREECE", "HUNGARY",
    "ICELAND", "IRELAND", "ITALY", "KAZAKHSTAN", "KOSOVO",
    "LATVIA", "LIECHTENSTEIN", "LITHUANIA", "LUXEMBOURG", "MALTA",
    "MOLDOVA", "MONACO", "MONTENEGRO", "NETHERLANDS", "NORTH MACEDONIA",
    "NORWAY", "POLAND", "PORTUGAL", "ROMANIA", "RUSSIA",
    "SAN MARINO", "SERBIA", "SLOVAKIA", "SLOVENIA", "SPAIN",
    "SWEDEN", "SWITZERLAND", "TURKEY", "UKRAINE", "UNITED KINGDOM",
    "VATICAN CITY"
        };

        static List<string> animalss = new List<string>() {
    "LION", "TIGER", "ELEPHANT", "DOG", "CAT",
    "HORSE", "DOLPHIN", "GIRAFFE", "PANDA", "KANGAROO",
    "MONKEY", "WOLF", "BEAR", "CHEETAH", "ZEBRA",
    "RABBIT", "SQUIRREL", "KOALA", "HIPPOPOTAMUS", "RHINOCEROS",
    "DEER", "EAGLE", "PEACOCK", "PENGUIN", "FOX",
    "SHARK", "WHALE", "CROCODILE", "GORILLA", "CAMEL",
    "CHIMPANZEE", "OSTRICH", "LEOPARD", "HYENA", "OTTER",
    "OWL", "FLAMINGO", "PARROT", "TURTLE", "SNAKE",
    "ALLIGATOR", "BUFFALO", "BADGER", "BAT", "BISON",
    "CHAMELEON", "CHINCHILLA", "DONKEY", "FERRET", "GOAT",
    "HAMSTER", "HEDGEHOG", "JAGUAR", "LEMUR", "LLAMA",
    "MOOSE", "ORANGUTAN", "OCTOPUS", "PELICAN", "POLAR BEAR",
    "SEAL", "STINGRAY", "WALRUS", "WOMBAT", "YAK"
        };


        private void dotaHeroes_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\projekti visual studio\C#\Windows Form Application\game\game\Audio\menuSelect.wav");
            player.Play();
            Hangman form1 = new Hangman();
            form1.words.Clear();   
            form1.words.AddRange(dota);
            form1.label = "DotA Heroes";
            form1.Show();
            this.Hide();
        }

        private void actors_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\projekti visual studio\C#\Windows Form Application\game\game\Audio\menuSelect.wav");
            player.Play();
            Hangman form1 = new Hangman();
            form1.words.Clear();
            form1.words.AddRange(actorss);
            form1.label = "Hollywood Actors";
            form1.Show();
            this.Hide();
        }

        private void countries_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\projekti visual studio\C#\Windows Form Application\game\game\Audio\menuSelect.wav");
            player.Play();
            Hangman form1 = new Hangman();
            form1.words.Clear();
            form1.words.AddRange(europeCountries);
            form1.label = "Europe Countries";
            form1.Show();
            this.Hide();
        }

        private void animals_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\projekti visual studio\C#\Windows Form Application\game\game\Audio\menuSelect.wav");
            player.Play();
            Hangman form1 = new Hangman();
            form1.words.Clear();
            form1.words.AddRange(animalss);
            form1.label = "Animals";
            form1.Show();
            this.Hide();
        }

        private void dotaHeroes_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\projekti visual studio\C#\Windows Form Application\game\game\Audio\menu.wav");
            player.Play();
        }

        private void actors_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\projekti visual studio\C#\Windows Form Application\game\game\Audio\menu.wav");
            player.Play();
        }

        private void countries_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\projekti visual studio\C#\Windows Form Application\game\game\Audio\menu.wav");
            player.Play();
        }

        private void animals_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\projekti visual studio\C#\Windows Form Application\game\game\Audio\menu.wav");
            player.Play();
        }
    }
}
