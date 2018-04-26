using FlightFinder.Shared;

namespace FlightFinder.Server
{
    public class SampleData
    {
        public readonly static Spaceport[] Spaceports = new[]
        {
            // Doctor Who ©British Broadcasting Corporation (BBC)
            // http://www.doctorwho.tv/
            new Spaceport { Code = "GAL", DisplayName = "Gallifrey", IsEarthSpaceport = false },
            new Spaceport { Code = "SKA", DisplayName = "Skaro", IsEarthSpaceport = false },
            new Spaceport { Code = "ALZ", DisplayName = "Alzarius", IsEarthSpaceport = false },
            new Spaceport { Code = "SKO", DisplayName = "Skonnos", IsEarthSpaceport = false },
            new Spaceport { Code = "ARG", DisplayName = "Argolis", IsEarthSpaceport = false },
            new Spaceport { Code = "CAS", DisplayName = "Castrovalva", IsEarthSpaceport = false },
            new Spaceport { Code = "DIP", DisplayName = "Diplos", IsEarthSpaceport = false },
            new Spaceport { Code = "KAR", DisplayName = "Karn", IsEarthSpaceport = false },
            new Spaceport { Code = "LOG", DisplayName = "Logopolis", IsEarthSpaceport = false },
            new Spaceport { Code = "MIN", DisplayName = "Minyos", IsEarthSpaceport = false },
            new Spaceport { Code = "RIB", DisplayName = "Ribos", IsEarthSpaceport = false },
            new Spaceport { Code = "SKR", DisplayName = "Skaar", IsEarthSpaceport = false },
            new Spaceport { Code = "TAR", DisplayName = "Tara", IsEarthSpaceport = false },
            new Spaceport { Code = "TRA", DisplayName = "Traken", IsEarthSpaceport = false },
            new Spaceport { Code = "USU", DisplayName = "Usurius", IsEarthSpaceport = false },
            new Spaceport { Code = "VAM", DisplayName = "Vampire Planet", IsEarthSpaceport = false },
            new Spaceport { Code = "ZAN", DisplayName = "Zanak", IsEarthSpaceport = false },
            new Spaceport { Code = "ZEO", DisplayName = "Zeos", IsEarthSpaceport = false },
            new Spaceport { Code = "ZET", DisplayName = "Zeta Minor", IsEarthSpaceport = false },
            new Spaceport { Code = "VOG", DisplayName = "Voga", IsEarthSpaceport = false },

            // Dune ©1965 Herbert Properties LLC
            // http://www.dunenovels.com/novel/dune
            new Spaceport { Code = "ARR", DisplayName = "Arrakis", IsEarthSpaceport = false },
            new Spaceport { Code = "CAL", DisplayName = "Caladan", IsEarthSpaceport = false },
            new Spaceport { Code = "GIE", DisplayName = "Giedi Prime", IsEarthSpaceport = false },
            new Spaceport { Code = "KAI", DisplayName = "Kaitain", IsEarthSpaceport = false },

            // Chronicles of Riddick ©2004 Universal Pictures Home Entertainment
            // https://www.uphe.com/movies/the-chronicles-of-riddick
            new Spaceport { Code = "CRE", DisplayName = "Crematoria", IsEarthSpaceport = false },
            new Spaceport { Code = "HEL", DisplayName = "Helion Prime", IsEarthSpaceport = false },

            // Serenity ©2005 Universal Pictures Home Entertainment
            // https://www.uphe.com/movies/serenity
            new Spaceport { Code = "MIR", DisplayName = "Miranda", IsEarthSpaceport = false },

            // Star Trek ©1966-1969, 1987-1994 Desilu Productions, Norway Corporation, 
            // Paramount Television, Paramount Pictures
            // http://www.startrek.com/
            new Spaceport { Code = "VUL", DisplayName = "Vulcan", IsEarthSpaceport = false },
            new Spaceport { Code = "ROM", DisplayName = "Romulus", IsEarthSpaceport = false },
            new Spaceport { Code = "BET", DisplayName = "Betazed", IsEarthSpaceport = false },
            new Spaceport { Code = "BOP", DisplayName = "Borg Prime", IsEarthSpaceport = false },
            new Spaceport { Code = "OMT", DisplayName = "Omicron Theta", IsEarthSpaceport = false },
            new Spaceport { Code = "PRA", DisplayName = "Praxis", IsEarthSpaceport = false },
            new Spaceport { Code = "RUP", DisplayName = "Rura Penthe", IsEarthSpaceport = false },
            new Spaceport { Code = "ZY3", DisplayName = "Zytchin III", IsEarthSpaceport = false },

            // Star Wars ©1977, 1980, 1983 Lucasfilm, Twentieth Century Fox
            // https://www.starwars.com/
            new Spaceport { Code = "TAT", DisplayName = "Tatooine", IsEarthSpaceport = false },
            new Spaceport { Code = "ALD", DisplayName = "Alderaan", IsEarthSpaceport = false },
            new Spaceport { Code = "DAG", DisplayName = "Dagobah", IsEarthSpaceport = false },
            new Spaceport { Code = "END", DisplayName = "Endor", IsEarthSpaceport = false },
            new Spaceport { Code = "HOT", DisplayName = "Hoth", IsEarthSpaceport = false },
            new Spaceport { Code = "YAV", DisplayName = "Yavin 4", IsEarthSpaceport = false },

            // Forbidden Planet ©1956 Metro-Goldwyn-Mayer (MGM)
            // https://www.mgm.com/
            new Spaceport { Code = "AL4", DisplayName = "Altair IV", IsEarthSpaceport = false },

            // Lexx ©1997-2002 Salter Street Films International, TiMe Film- und TV-Produktions GmbH,
            // Chum Television, Silverlight Ltd.
            new Spaceport { Code = "FIR", DisplayName = "Fire", IsEarthSpaceport = false },

            // Starship Troopers ©1997 TriStar Pictures ,Touchstone Pictures, Big Bug Pictures, 
            // Digital Image Associates
            // http://www.sonypictures.com/movies/starshiptroopers/
            new Spaceport { Code = "KLE", DisplayName = "Klendathu", IsEarthSpaceport = false },

            // Solar System
            new Spaceport { Code = "VEN", DisplayName = "Venus", IsEarthSpaceport = false },
            new Spaceport { Code = "MAR", DisplayName = "Mars", IsEarthSpaceport = false },
            new Spaceport { Code = "PLU", DisplayName = "Pluto", IsEarthSpaceport = false },

            // Superman ©1978 Dovemead Films, Film Export A.G., International Film Production
            // https://www.warnerbros.com/superman-movie
            new Spaceport { Code = "KRY", DisplayName = "Krypton", IsEarthSpaceport = false },

            // Alien ©1979 Brandywine Productions, Twentieth Century-Fox Productions
            // https://www.foxmovies.com/movies/alien
            new Spaceport { Code = "LV426", DisplayName = "LV-426", IsEarthSpaceport = false },
            new Spaceport { Code = "FIO", DisplayName = "Fiorina 'Fury' 161", IsEarthSpaceport = false },

            // Babylon 5 ©1994-1998 Babylonian Productions, Warner Bros. Television
            // https://www.warnerbros.com/tv/babylon-5-complete-series-and-movies-collection
            new Spaceport { Code = "EP3", DisplayName = "Epsilon 3", IsEarthSpaceport = false },

            // Battlestar Galactica ©1978-1979 Glen A. Larson Productions, Universal Television
            // http://www.battlestargalactica.com/
            new Spaceport { Code = "CAP", DisplayName = "Caprica", IsEarthSpaceport = false },

            // Blake's 7 ©1978-1981 British Broadcasting Corporation (BBC)
            // https://www.bbc.co.uk/programmes/p00t1cyg
            new Spaceport { Code = "CYG", DisplayName = "Cygnus Alpha", IsEarthSpaceport = false },

            // Spaceballs ©1987 Brooksfilms, Metro-Goldwyn-Mayer (MGM)
            // https://www.mgm.com/#/our-titles/1873/Spaceballs
            new Spaceport { Code = "BALLS", DisplayName = "Spaceball", IsEarthSpaceport = false },

            // The Dark Crystal ©1982  Incorporated Television Company (ITC), 
            // Jim Henson Productions, Henson Organisation
            // http://www.darkcrystal.com/
            new Spaceport { Code = "THR", DisplayName = "Thra", IsEarthSpaceport = false },

            // Flash Gordon ©1980  Starling Films, Dino De Laurentiis Company, Famous Films (II)
            // https://www.uphe.com/movies/flash-gordon
            new Spaceport { Code = "MON", DisplayName = "Mongo", IsEarthSpaceport = false },
            new Spaceport { Code = "ARB", DisplayName = "Arboria", IsEarthSpaceport = false },
            new Spaceport { Code = "FRI", DisplayName = "Frigia", IsEarthSpaceport = false },

            // Mork and Mindy ©1978  Henderson Productions, Miller-Milkis Productions, 
            // Paramount Television
            // https://www.facebook.com/paramountTV/
            new Spaceport { Code = "ORK", DisplayName = "Ork", IsEarthSpaceport = false },

            // The Fifth Element ©1997 Gaumont
            // http://www.sonypictures.com/movies/thefifthelement/
            new Spaceport { Code = "FHL", DisplayName = "Fhloston", IsEarthSpaceport = false },

            // Red Dwarf ©1988-2018 British Broadcasting Corporation (BBC)
            // https://www.bbc.co.uk/programmes/b008ncn6
            new Spaceport { Code = "RIM", DisplayName = "Rimmerworld", IsEarthSpaceport = false },

            // Galaxy Quest ©1999 DreamWorks, Gran Via Productions
            // http://www.paramount.com/movies/galaxy-quest
            new Spaceport { Code = "THE", DisplayName = "Thermia", IsEarthSpaceport = false },

            // Earth
            new Spaceport { Code = "ATL", DisplayName = "Hartsfield–Jackson Atlanta Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "PEK", DisplayName = "Beijing Capital Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "DXB", DisplayName = "Dubai Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "LAX", DisplayName = "Los Angeles Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "HND", DisplayName = "Tokyo Haneda Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "ORD", DisplayName = "O'Hare Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "LHR", DisplayName = "London Heathrow", IsEarthSpaceport = true },
            new Spaceport { Code = "HKG", DisplayName = "Hong Kong Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "PVG", DisplayName = "Shanghai Pudong Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "CDG", DisplayName = "Charles de Gaulle", IsEarthSpaceport = true },
            new Spaceport { Code = "DFW", DisplayName = "Dallas/Fort Worth Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "AMS", DisplayName = "Amsterdam Schiphol", IsEarthSpaceport = true },
            new Spaceport { Code = "FRA", DisplayName = "Frankfurt", IsEarthSpaceport = true },
            new Spaceport { Code = "IST", DisplayName = "Istanbul Atatürk", IsEarthSpaceport = true },
            new Spaceport { Code = "CAN", DisplayName = "Guangzhou Baiyun Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "JFK", DisplayName = "John F. Kennedy Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "SIN", DisplayName = "Singapore Changi", IsEarthSpaceport = true },
            new Spaceport { Code = "DEN", DisplayName = "Denver Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "ICN", DisplayName = "Seoul Incheon Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "BKK", DisplayName = "Suvarnabhumi", IsEarthSpaceport = true },
            new Spaceport { Code = "DEL", DisplayName = "Indira Gandhi Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "CGK", DisplayName = "Soekarno–Hatta Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "SFO", DisplayName = "San Francisco Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "KUL", DisplayName = "Kuala Lumpur Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "MAD", DisplayName = "Madrid Barajas", IsEarthSpaceport = true },
            new Spaceport { Code = "LAS", DisplayName = "McCarran Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "CTU", DisplayName = "Chengdu Shuangliu Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "SEA", DisplayName = "Seattle-Tacoma Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "BOM", DisplayName = "Chhatrapati Shivaji Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "MIA", DisplayName = "Miami Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "CLT", DisplayName = "Charlotte Douglas Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "YYZ", DisplayName = "Toronto Pearson Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "BCN", DisplayName = "Barcelona–El Prat", IsEarthSpaceport = true },
            new Spaceport { Code = "PHX", DisplayName = "Phoenix Sky Harbor Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "LGW", DisplayName = "London Gatwick", IsEarthSpaceport = true },
            new Spaceport { Code = "TPE", DisplayName = "Taiwan Taoyuan Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "MUC", DisplayName = "Munich", IsEarthSpaceport = true },
            new Spaceport { Code = "SYD", DisplayName = "Sydney Kingsford-Smith", IsEarthSpaceport = true },
            new Spaceport { Code = "KMG", DisplayName = "Kunming Changshui Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "SZX", DisplayName = "Shenzhen Bao'an Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "MCO", DisplayName = "Orlando Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "FCO", DisplayName = "Leonardo da Vinci–Fiumicino", IsEarthSpaceport = true },
            new Spaceport { Code = "IAH", DisplayName = "George Bush Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "MEX", DisplayName = "Benito Juárez Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "SHA", DisplayName = "Shanghai Hongqiao Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "EWR", DisplayName = "Newark Liberty Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "MNL", DisplayName = "Ninoy Aquino Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "NRT", DisplayName = "Narita Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "MSP", DisplayName = "Minneapolis/St Paul Interplanetary", IsEarthSpaceport = true },
            new Spaceport { Code = "DOH", DisplayName = "Hamad Interplanetary", IsEarthSpaceport = true },
        };
        
        public readonly static string[] Spacelines = new[]
        {
            "American Spacelines",
            "British Spaceways",
            "Delta Express Rocket",
            "Emirates Warpspeed",
            "Etihad Cosmos",
            "RocketBlue",
            "KLM Starliner",
            "Singapore Spaceways",
            "Qantas Starship",
            "Virgin Intergalactic",
        };
    }
}
