using TARpe22MauiPlanets.Models;


namespace TARpe22MauiPlanets.Services
{
    internal static class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Männi-laimi ja karamelli jäätise parfe",
                HeroImage = "pinelime.jpg",
                Description = "Männi-laimi ja karamelli jäätise parfe on võrratu magustoit, milles on ühendatud männi- " +
                "laimi värskendav maitse ning karamelli magusus, kihiti koos kreemja jäätisega. " +
                "Need maitsvad kihid kihistatakse parfee klaasi, " +
                "luues visuaalselt ahvatleva magustoidu, mis rõhutab iga kihi elavaid värve ja tekstuure. " +
                "Kreemja jäätise, männi-laimi ja karamelli kombinatsioon moodustab tõeliselt vastupandamatu roa, " +
                "mis rahuldab kindlasti iga magusaisu. ",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
            {
                "https://img.delicious.com.au/fxc52y2X/w759-h506-cfill/del/2023/11/cheats-pine-lime-and-caramel-ice-cream-parfaits-201069-2.jpg"
        }
    },

            new()
            {
                Name = "Magus Filipiinide tofu (taho)",
                HeroImage = "taho.jpg",
                Description = "Taho on traditsiooniline magustoit Filipiinidelt, mis koosneb pehmest tofu-köögiviljast,  " +
                "mida serveeritakse sooja pruuni suhkru ja tapiokapärlikesegu, " +
                "sageli koos vaniljeekstrakti lisanditega. See annab talle rikkaliku ja magusa maitse ning unikaalse tekstuuri, mis sulab suus. " +
                "Taho on populaarne tänavatoit ja hommikusöök Filipiinidel ning seda " +
                "serveeritakse tavaliselt plastiktopsis või klaasist kaussides,  " +
                "pakkudes kohalikele ja turistidele meeldivat maitseelamust. " ,
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
            {
                "https://flouredframe.com/wp-content/uploads/2020/01/GOG_4150-1.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg"
        }
    },

            new()
            {
                Name = "Banoffee kreemipuding valge šokolaadiga",
                HeroImage = "pudding.jpg",
                Description = "Banoffee kreemipuding valge šokolaadi puruga on võrratu magustoit, mis hellitab maitsemeeli  " +
                "oma kreemise banaanipudingi, küpsete banaaniviilude ja luksusliku toffeesiirupiga kihtidega. " +
                "Pealispinnaks on helde kogus krõbedat valge šokolaadi puru, pakkudes igas suutäies  " +
                "harmoonilist maitse- ja tekstuurielamust. Kas siis nautida pärast eineid või maiustusena igal ajal " +
                "päeval, see magustoit lubab rahuldada ka kõige nõudlikuma maitsemeeli oma rikkaliku ja  " +
                "kreemise headusega. ",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://www.crazyforcrust.com/wp-content/uploads/2023/11/banoffee-pie-recipe-5.jpg"
                }
            },

            new()
            {
                Name = " Karamelliseeritud banaan ja jäätisega",
                HeroImage = "butterscotch.jpg",
                Description = "Võikreemikaste koos karamelliseeritud võiga banaanide ja jäätisega on nauditav magustoit, mis " +
                            "ühendab rikkaliku võikreemikastme karamelliseeritud banaanide ja kreemja jäätisega. " +
                            "Kaste pakub luksuslikku segu võist, pruunist suhkrust ja koorest, luues sametise magususe, mis katavad " +
                            "iga lusikatäie. Koos karamelliseeritud võiga banaanidega pakub see magustoit võrratut maitsete " +
                            "ja tekstuuride kontrasti, samal ajal kui jahe, siidine jäätis pakub igale ampsule värskendavat " +
                            "lõpetust. Ideaalne võimalus rahuldada magusa isu, pakkudes samal ajal soojade, kleepuvate " +
                            "kastme ja jahe, kreemja jäätise indulgentset kombinatsiooni." ,
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://bojongourmet.com/wp-content/uploads/2013/08/boozy-banana-butterscotch-ice-cream-231.jpg"
                }
            },

            new()
            {
                Name = "Suve marjageel",
                HeroImage = "kook.jpg",
                Description = "Suve marjageel on värskendav magustoit, mille maitse on täis värskete marjade elavat maitset.  " +
                "Valmistatud marjapüree ja želatiini seguga, pakub see geel magusat ja hapukat maitsekooslust. " +
                "Selle ehet meenutav välimus ja kerge tekstuur teevad sellest ideaalse maiuse kuumadel " +
                "suvepäevadel, olgu siis nautides seda omaette või koos kuhjaga vahukoorega lisandiks " +
                "indulgentsusele.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://images.squarespace-cdn.com/content/6057bede2adaca3d2461a22d/1629544997851-QNNF19CJXCGHN0S09SUH/summer+berry+jelly.jpg?format=1500w&content-type=image%2Fjpeg"
                }
            },

            new()
            {
                Name = " Kõrvitsa Alfredo",
                HeroImage = "pasta1.jpg",
                Description = "Kõrvitsa Alfredo on kreemine pastaroog, millel on hooajaline keerdkäik. See sisaldab sametist " +
                            "Alfredo kastet, mis on rikastatud kõrvitsapüreega, luues rikkaliku ja maitseküllase kastme koos " +
                            "sügisesete vürtside aroomidega. See lohutav roog sobib suurepäraselt pasta juurde ning pakub " +
                            "nauditavat kombinatsiooni kreemjast tekstuurist ja soolakast kõrvitsa maitselisest aroomist. " +
                            "Täiuslik hubaste sügisõhtute jaoks, see on maitsvaim viis hooaja maitsete tähistamiseks.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://pinchofyum.com/wp-content/uploads/Edited-Pumpkin-Alfredo-Recipe.jpg"
                }
            },

            new()
            {
                Name = " Smash-burgerid",
                HeroImage = "smashburgers.jpg",
                Description = "Smash-burgerid on suussulav nauding, tuntud oma lihtsuse ja maitserikka löögiga. Need burgerid " +
                "valmistatakse, purustades hakklihakuuli kuumale grillpannile, mis annab krõbeda, " +
                "karamelliseeritud välispinna, samas säilitades seest mahlase ja õrna struktuuri. Õhuke pihv tagab " +
                "maksimaalse kokkupuute küpsetuspinnaga, luues maitsva koore, mis rõhutab hakkliha maitset. " +
                "Serveerituna pehmel kuklil koos klassikaliste lisanditega nagu lehtsalat, tomat, sibulad ja juust, " +
                "pakuvad smash-burgerid täiuslikku tasakaalu tekstuuride ja maitsete vahel, muutes nad " +
                "lemmikuks burgerisõprade seas kõikjal.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://images.squarespace-cdn.com/content/v1/5e80e64f9327941b94517c20/1620874432492-S8B297TIPAUD9HL80NG7/Smash+Burger.jpg"
                }
            },

            new()
            {
                Name = " Apelsiniga Tai veiseliha vardad",
                HeroImage = "thaibeef.jpg",
                Description = "Apelsiniga Tai veiseliha vardad on ahvatlev maitsekombinatsioon, kus kohtuvad apelsini värskus " +
                "ja Tai köögi aromaatne vürtsikus. Õhukeselt viilutatud veiseliha marineeritakse elava segu sees, " +
                "mis koosneb apelsinimahlast, sojakastmest, küüslaugust, ingverist ja Tai tšillist, andes lihale " +
                "sügava maitsekihi. Need vardad keeratakse grillimiseks ja küpsetatakse täiuslikkuseni, kus liha " +
                "karamelliseerub ja omandab suitsuse maitse, jäädes siiski seespool mahlane ja õrn. Need vardad " +
                "pakuvad täiuslikku tasakaalu magusa, soolase ja vürtsika maitse vahel, muutes need " +
                "suurepäraseks eelroaks või pearoaks igasugusel üritusel.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://ourbestbites.com/wp-content/uploads/2009/05/OrangeThaiBeefSkewers.jpeg"
                }
            },

            new()
            {
                Name = " Lasanje rullid",
                HeroImage = "lasagnarollup.jpg",
                Description = "Lasanje rullid on lõbus keerdkäik klassikalisele Itaalia roale, pakkudes kõiki traditsioonilise lasanje " +
                            "maitseid individuaalsetes portsjonites. Selle asemel, et koostisosi kihtidena küpsetusnõusse " +
                            "laduda, keedetakse lasanje nuudlid, seejärel määritakse need ricotta juustuseguga, keeratakse " +
                            "rulli ning paigutatakse küpsetusnõusse. Seejärel ülevalatakse need rikkaliku marinara kastme ja " +
                            "mozzarella juustuga enne küpsetamist kuldpruuniks. Need rullid on mitte ainult visuaalselt " +
                            "atraktiivsed, vaid ka uskumatult maitsvad, pakkudes igas ampsus täiuslikku tasakaalu kreemja " +
                            "juustu, sügava kastme ja õrna pasta vahel. Ideaalne serveerimiseks üritustel või hubase " +
                            "pereõhtusöögi jaoks.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://thecozycook.com/wp-content/uploads/2022/03/Lasagna-Roll-Ups-f.jpg"
                }
            },

            new()
            {
                Name = " Orzo carbonara",
                HeroImage = "orzo.jpg",
                Description = "Orzo carbonara on võluv keerdkäik klassikalisele Itaalia pastaroale, carbonarale. Selle asemel, et " +
                            "kasutada traditsioonilist spagetti või fettuccinet, sisaldab see retsept orzo-pastat, mis on väike, " +
                            "riisitera-kujuline pasta. Orzo keedetakse al dente'ks ja seejärel segatakse kreemja kastmega, mis " +
                            "on valmistatud munadest, Parmesani juustust, krõbedast pancetast või peekonist ning mustast " +
                            "piprast. Tulemuseks on lohutav ja kreemine pastaroog rikkaliku suitsuse maitsega, mis kindlasti " +
                            "rahuldab igasuguse isu. Ideaalne kiireks ja maitsekaks õhtusöögiks nädala keskel.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://www.halfbakedharvest.com/wp-content/uploads/2020/04/20-Minute-Orzo-Carbonara-with-Crispy-Prosciutto-and-Burrata-1.jpg"
                }
            },

            new()
            {
                Name = " Kreeka orzosalat (orzo-fetasalat)",
                HeroImage = "orzosalad.jpeg",
                Description = "Kreeka orzosalat, tuntud ka kui orzo-fetasalat, on värske ja maitsev roog, mis ühendab orzo pastat " +
                            "erinevate Vahemere-inspireeritud koostisosadega. Keedetud orzo segatakse tükeldatud kurkide, " +
                            "kirsstomatite, punaste sibulate, Kalamata oliivide ja murdunud feta juustuga, kõik maitsestatud" +
                            "värskendava vinegretiga, mis on valmistatud oliiviõlist, sidrunimahlast, küüslaugust ja " +
                            "maitsetaimedest nagu oregano ja petersell. Tulemuseks on särav ja värviline salat täiusliku " +
                            "tasakaaluga happeliste, soolaste ja värske maitse vahel. See on ideaalne lisand grillitud lihadele " +
                            "või kerge ja rahuldava pearoana omaette.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://www.cookingclassy.com/wp-content/uploads/2022/03/orzo-salad-33-500x375.jpg"
                }
            },

            new()
            {
                Name = " Kanatiivad mee ja küüslauguga",
                HeroImage = "wings.jpg",
                Description = "Kanatiivad mee ja küüslauguga on ahvatlev kombinatsioon magusatest ja soolastest maitsetest, mis " +
                            "rõõmustavad teie maitsemeeli. Need krõbedad kanatiivad on kaetud kleepuva mee-" +
                            "küüslaugukastmega, mis koosneb meest, sojakastmest, küüslaugust ja teistest vürtsidest. " +
                            "Tulemuseks on sõrmedele limpsimiseks roog, mis on täiuslik eelroaks, mängupäevadeks või igaks " +
                            "sündmuseks, kus soovite pakkuda maitsvaid ja sõltuvusttekitavaid maitseid. Kas serveeritud " +
                            "suupistena või pearoana, on need tiivad kindlasti rahva lemmikud.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://thesaltymarshmallow.com/wp-content/uploads/2021/01/honey-garlic-wings1.jpg"
                }
            },

            new()
            {
                Name = " Jõhvikakanaliha",
                HeroImage = "chicken.jpg",
                Description = "Jõhvikakanaliha on võluv roog, mis ühendab jõhvikate hapuka magususe soolase kanalihaga. " +
                            "Õrnad kanafileed või -reied valmistatakse maitsvas jõhvikakastmes, mis on valmistatud " +
                            "jõhvikamahlast, apelsinikoorest, meest ja aromaatsetest maitseainetest nagu kaneel ja nelk. " +
                            "Tulemuseks on suurepärane roog, millel on täiuslik tasakaal magusate ja soolaste maitsete vahel. " +
                            "See roog sobib suurepäraselt hubaseks õhtusöögiks kodus või eriliseks puhuks, pakkudes " +
                            "klassikaliste kanaroogade unikaalset pööret.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://www.wellplated.com/wp-content/uploads/2015/11/Sticky-Cranberry-Chicken-Thighs.-The-whole-meal-cooks-in-one-pan-and-is-healthy-AND-delicious.-Winner-dinner.jpg"
                }
            },

            new()
            {
                Name = " Makaroni- ja juustupallid",
                HeroImage = "bites.jpg",
                Description = "Makaroni- ja juustupallid on lõbus ning maitsev pööre." +
                            "Need ampsusuurused hõrgutised sisaldavad kreemjat makaroni ja juustu, " +
                            "mis on kaetud leivaga ning küpsetatud või praetud kuldseks täiuslikkuseks. Iga amps on täidetud " +
                            "sulava juustu ja õrna pasta maitsetega, pakkudes rahuldavalt krõbedat välispinda ning kreemjat ja " +
                            "indulgentset sisemust. Ideaalne pidudeks, näksimiseks või isegi lisandina.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://www.southernliving.com/thmb/s7cN-ETQ2rHd4U_WUU53kfQMcSw=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/FriedMacandCheeseBites-30_preview_scale_100_ppi_150_quality_100-3f5853dcac754be1abcd36884ea887cc.jpg"
                }
            },

            new()
            {
                Name = " Fettuccine mereandidega",
                HeroImage = "mereannid.jpg",
                Description = "Kõrvitsa Alfredo on kreemine pastaroog, millel on hooajaline keerdkäik. See sisaldab sametist " +
                            "Alfredo kastet, mis on rikastatud kõrvitsapüreega, luues rikkaliku ja maitseküllase kastme koos " +
                            "sügisesete vürtside aroomidega. See lohutav roog sobib suurepäraselt pasta juurde ning pakub " +
                            "nauditavat kombinatsiooni kreemjast tekstuurist ja soolakast kõrvitsa maitselisest aroomist. " +
                            "Täiuslik hubaste sügisõhtute jaoks, see on maitsvaim viis hooaja maitsete tähistamiseks.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://reluctantentertainer.com/wp-content/uploads/2022/08/best-Seafood-Fettuccine-Alfredo.jpeg"
                }
            },

            new()
            {
                Name = " Kanatekiila fettuccini ",
                HeroImage = "tekiila.jpg",
                Description = "Kanatekiila fettuccini on särav ja maitserikas pastaroog, mis ühendab pehme fettuccine " +
                            "pastavormi mahlaste kanatükkidega ning vürtsika tekiila-laimikastmega. Kana pruunistatakse " +
                            "kuldpruuniks ja seejärel hautatakse kastmes, mis on valmistatud tekiilast, laimimahlast, " +
                            "küüslaugust ja koorest, luues kreemja ja värskendava maitseprofiili. See roog on sageli " +
                            "kaunistatud värskete koriandrilehtede ja riivitud Parmesani juustuga, mis lisab sügavust maitsele. " +
                            "Iga amps on maitsvate kanatükkide, värskendava tsitruselise maitse ja kreemja kastme nauditav " +
                            "kombinatsioon, muutes selle ideaalseks valikuks meeldejääva eine jaoks.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://www.alilyloveaffair.com/wp-content/uploads/2020/02/Chicken-Tequila-Fettuccine-1-1-of-1.jpg"
                }
            },

            new()
            {
                Name = " Kodune lasanje",
                HeroImage = "homemadelasagne.jpg",
                Description = "Isetehtud lasanje on klassikaline Itaalia lohutustoit, mis koosneb pastakihtidest, rikkalikust " +
                            "tomatikastmest, maitserohkest lihast (näiteks hakklihast või vorstist), kreemjast ricotta juustust ja " +
                            "sulavast mozzarellast. Iga kiht pannakse hoolikalt kokku ja küpsetatakse kuldseks ja mullitavaks, " +
                            "tulemuseks on rammus ja rahuldustpakkuv eine, mis sobib suurepäraselt jagamiseks pere ja " +
                            "sõpradega. Oma lohutavate maitsete ja rikkaliku tekstuuri tõttu saab isetehtud lasanjest kindlasti " +
                            "igas kodus lemmikroog.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://pinchofyum.com/wp-content/uploads/Edited-Pumpkin-Alfredo-Recipe.jpg"
                }
            },

            new()
            {
                Name = " Ameerika lasanje",
                HeroImage = "ameerikalasanja.jpg",
                Description = "Ameerika lasanje on rammus ja lohutav roog, mis koosneb lasanje pastakihtidest, maitsestatud " +
                            "hakklihast või vorstist, happelisest tomatikastmest, kreemjast ricotta juustust ja sulavast " +
                            "mozzarellast. Sageli sisaldab see ka täiendavaid koostisosi nagu sibulad, küüslauk ja ürdid, lisades " +
                            "maitset sügavust. Küpsetatakse kuni mullitavaks ja kuldseks, see roog on paljude Ameerika " +
                            "kodude lemmik lohutustoit, pakkudes igas ampsus rahuldustpakkuvat maitsete ja tekstuuride " +
                            "segu.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://recipes.net/wp-content/uploads/2023/07/american-lasagna_def3a9431f11c8d03abee0b6d9662a64.jpeg"
                }
            },

            new()
            {
                Name = " Rigatoni salajase kastmega on pastaroog",
                HeroImage = "rigatoni.jpg",
                Description = "Rigatoni al Segreto ehk Rigatoni salajase kastmega on pastaroog, mis pakub varjatud üllatusi.  " +
                            "Sellel on rikkalik ja maitsva kastme retsept, mille koostisosad on hästi hoitud saladus. Rigatoni " +
                            "pasta segatakse selle salapärase kastmega, luues maitseelamuse, mis paneb teid naasma roogi " +
                            "avastama. See on salapärane ja maitserohke roog, mis rõõmustab igat gurmaani.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://img.freepik.com/premium-photo/rigatoni-al-segreto-rigatoni-with-secret-sauce-italian-recipe_198067-166364.jpg"
                }
            },

            new()
            {
                Name = " Fettuccine Carbonara",
                HeroImage = "pasta2.jpg",
                Description = "Fettuccine Carbonara on klassikaline Itaalia pastaroog, mis on tuntud oma lihtsuse ja rikkalike " +
                            "maitsete poolest. See koosneb õrnadest fettuccine nuudlitest, mis on kaetud kreemja kastmega, " +
                            "valmistatud munadest, riivitud Parmesani juustust, krõbedast pancetast või peekonist ning " +
                            "värskest mustast piprast. Pasta soojus küpsetab munad, luues siidise kastme, mis kleepub iga " +
                            "nuudlikeere külge. Tulemuseks on dekadentne ja rahuldustpakkuv roog, mis tasakaalustab " +
                            "täiuslikult kastme kreemja rikkuse krõbeda panceta soolase krõmpsuga. Fettuccine Carbonara on " +
                            "ajatu lemmik, mis alati vaimustab.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://myfoodbook.com.au/sites/default/files/styles/schema_img/public/recipe_photo/Kitc20153598_0.jpg"
                }
            },
    };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizedPlanets = planets.OrderBy(item => random.Next());

            return randomizedPlanets.Take(2).ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}