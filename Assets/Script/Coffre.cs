using UnityEngine;
using UnityEngine.UI;

public class Coffre : MonoBehaviour
{
    public int random;
    public int nbCartes;
    public int gold;
    public int gems;
    public int cartes;
    public int nombreCartes;
    public int nombreCartes1;
    public int nombreCartes2;
    public int nombreCartes3;
    public int nombreCartes4;
    public int carte;
    public int carte1;
    public int carte2;
    public int carte3;
    public int carte4;
    public int carte6;
    public int carte7;
    public string communes;
    public string rares;
    public string epique;
    public string legendaire;

    [Header("Script")]
    public RessourceArchieve ressourceArchieve;
    public BibliothequesCartes bibliothequesCartes;

    [Header("Numéro")]
    public int chevalierNuméro;
    public int recrueRoyalesNuméro;
    public int hordeGargouillesNuméro;
    public int goblinGangNuméro;
    public int gobelinsNuméro;
    public int gobelinsLanceNuméro;
    public int iceSpiritNuméro;
    public int mégaBouleNeigeNuméro;
    public int minionsNuméro;
    public int royalGiantsNuméro;
    public int skeletonsNuméro;
    public int teslaNuméro;
    public int zapNuméro;
    public int friponsNuméro;
    public int eliteBarbariansNuméro;
    public int mortierNuméro;
    public int chauvesSourisNuméro;
    public int canonNuméro;
    public int bombardierNuméro;
    public int barbaresNuméro;
    public int arhersNuméro;
    public int barbarianHutNuméro;
    public int battleRamNuméro;
    public int cochonRoyauxNuméro;
    public int miniPEKKANuméro;
    public int hogRiderNuméro;
    public int goblinHutNuméro;
    public int giantNuméro;
    public int iceGolemNuméro;
    public int machineVolanteNuméro;
    public int megaMinionNuméro;
    public int mousquetaireNuméro;
    public int rocketNuméro;
    public int séismeNuméro;
    public int threeMusketeersNuméro;
    public int tombstoneNuméro;
    public int tourEnferNuméro;
    public int wizardNuméro;
    public int valkNuméro;
    public int furnaceNuméro;
    public int elixirCollecterNuméro;
    public int electrocuteursNuméro;
    public int dartGoblinNuméro;
    public int cageGobelinNuméro;
    public int bombTowerNuméro;
    public int espritsFeuNuméro;
    public int babyDragonNuméro;
    public int bowlerNuméro;
    public int chasseurNuméro;
    public int clonageNuméro;
    public int electroDragonNuméro;
    public int executionnerNuméro;
    public int witchNuméro;
    public int xBowNuméro;
    public int princeNuméro;
    public int princeTenebreuxNuméro;
    public int poisonNuméro;
    public int mirorNuméro;
    public int lightningNuméro;
    public int guardsNuméro;
    public int golemNuméro;
    public int goblinBarrelNuméro;
    public int goblinGéantNuméro;
    public int giantSkeletonNuméro;
    public int pEKKANuméro;
    public int rageNuméro;
    public int sapeursNuméro;
    public int skeletonArmyNuméro;
    public int tornadoNuméro;
    public int fûtBarbareNuméro;
    public int charetteCanonNuméro;
    public int baloonNuméro;
    public int archerMagicNuméro;
    public int banditNuméro;
    public int cavabélierNuméro;
    public int electroWizardNuméro;
    public int zappyNuméro;
    public int princessNuméro;
    public int mégaChevalierNuméro;
    public int lumberJackNuméro;
    public int lavaHoundNuméro;
    public int infernoDragonNuméro;
    public int iceWizardNuméro;
    public int graveyardNuméro;
    public int fantômeRoyalNuméro;
    public int mineurNuméro;
    public int nightWitchNuméro;
    public int logNuméro;

    [Header("Nombre de Cartes")]
    public int chevalierCards;
    public int recrueRoyalesCards;
    public int hordeGargouillesCards;
    public int goblinGangCards;
    public int gobelinsCards;
    public int gobelinsLanceCards;
    public int iceSpiritCards;
    public int mégaBouleNeigeCards;
    public int minionsCards;
    public int royalGiantsCards;
    public int skeletonsCards;
    public int teslaCards;
    public int zapCards;
    public int friponsCards;
    public int eliteBarbariansCards;
    public int mortierCards;
    public int chauvesSourisCards;
    public int canonCards;
    public int bombardierCards;
    public int barbaresCards;
    public int arhersCards;
    public int barbarianHutCard;
    public int battleRamCard;
    public int cochonRoyauxCard;
    public int miniPEKKACard;
    public int hogRiderCard;
    public int goblinHutCard;
    public int giantCard;
    public int iceGolemCard;
    public int machineVolanteCard;
    public int megaMinionCard;
    public int mousquetaireCard;
    public int rocketCard;
    public int séismeCard;
    public int threeMusketeersCard;
    public int tombstoneCard;
    public int tourEnferCard;
    public int wizardCard;
    public int valkCard;
    public int furnaceCard;
    public int elixirCollecterCard;
    public int electrocuteursCard;
    public int dartGoblinCard;
    public int cageGobelinCard;
    public int bombTowerCard;
    public int espritsFeuCards;
    public int babyDragonCard;
    public int bowlerCard;
    public int chasseurCard;
    public int clonageCard;
    public int electroDragonCard;
    public int executionnerCard;
    public int witchCard;
    public int xBowCard;
    public int princeCard;
    public int princeTenebreuxCard;
    public int poisonCard;
    public int mirorCard;
    public int lightningCard;
    public int guardsCard;
    public int golemCard;
    public int goblinBarrelCard;
    public int goblinGéantCard;
    public int giantSkeletonCard;
    public int pEKKACard;
    public int rageCard;
    public int sapeursCard;
    public int skeletonArmyCard;
    public int tornadoCard;
    public int fûtBarbareCard;
    public int charetteCanonCard;
    public int baloonCard;
    public int archerMagicCard;
    public int banditCard;
    public int cavabélierCard;
    public int electroWizardCard;
    public int zappyCard;
    public int princessCard;
    public int mégaChevalierCard;
    public int lumberJackCard;
    public int lavaHoundCard;
    public int infernoDragonCard;
    public int iceWizardCard;
    public int graveyardCard;
    public int fantômeRoyalCard;
    public int mineurCard;
    public int nightWitchCard;
    public int logCard;

    [Header("Game Object")]
    public GameObject chevalier;
    public GameObject recrueRoyales;
    public GameObject hordeGargouilles;
    public GameObject goblinGang;
    public GameObject gobelins;
    public GameObject gobelinsLance;
    public GameObject iceSpirit;
    public GameObject mégaBouleNeige;
    public GameObject minions;
    public GameObject royalGiants;
    public GameObject skeletons;
    public GameObject tesla;
    public GameObject zap;
    public GameObject fripons;
    public GameObject eliteBarbarians;
    public GameObject mortier;
    public GameObject chauvesSouris;
    public GameObject canon;
    public GameObject bombardier;
    public GameObject barbares;
    public GameObject arhers;
    public GameObject espritsFeu;
    public GameObject barbarianHut;
    public GameObject battleRam;
    public GameObject cochonRoyaux;
    public GameObject miniPEKKA;
    public GameObject hogRider;
    public GameObject goblinHut;
    public GameObject giant;
    public GameObject iceGolem;
    public GameObject machineVolante;
    public GameObject megaMinion;
    public GameObject mousquetaire;
    public GameObject rocket;
    public GameObject séisme;
    public GameObject threeMusketeers;
    public GameObject tombstone; 
    public GameObject tourEnfer; 
    public GameObject wizard;
    public GameObject valk;
    public GameObject furnace;
    public GameObject elixirCollecter;
    public GameObject electrocuteurs;
    public GameObject dartGoblin;
    public GameObject cageGobelin;
    public GameObject bombTower;
    public GameObject babyDragon;
    public GameObject bowler;
    public GameObject chasseur;
    public GameObject clonage;
    public GameObject electroDragon;
    public GameObject executionner;
    public GameObject witch;
    public GameObject xBow;
    public GameObject prince;
    public GameObject princeTenebreux;
    public GameObject poison;
    public GameObject miror;
    public GameObject lightning;
    public GameObject guards;
    public GameObject golem;
    public GameObject goblinBarrel;
    public GameObject goblinGéant;
    public GameObject giantSkeleton;
    public GameObject pEKKA;
    public GameObject rage;
    public GameObject sapeurs;
    public GameObject skeletonArmy;
    public GameObject tornado;
    public GameObject fûtBarbare;
    public GameObject charetteCanon;
    public GameObject baloon;
    public GameObject archerMagic;
    public GameObject bandit;
    public GameObject cavabélier;
    public GameObject electroWizard;
    public GameObject zappy;
    public GameObject princess;
    public GameObject mégaChevalier;
    public GameObject lumberJack;
    public GameObject lavaHound;
    public GameObject infernoDragon;
    public GameObject iceWizard;
    public GameObject graveyard;
    public GameObject fantômeRoyal;
    public GameObject mineur;
    public GameObject nightWitch;
    public GameObject log;
    public GameObject interfaceMenu;
    public GameObject flèche;
    public GameObject coffreSuperMagicOpen;
    public GameObject coffreMagicOpen;
    public GameObject coffreLégendaireOpen;
    public GameObject coffreGéantOpen;
    public GameObject coffreOrOpen;
    public GameObject coffreGratuitOpen;
    public GameObject coffreCouronneOpen;
    public GameObject coffreArgentOpen;
    public GameObject coffreEpicOpen;
    public GameObject coffreSuperMagicClose;
    public GameObject coffreMagicClose;
    public GameObject coffreLégendaireClose;
    public GameObject coffreGéantClose;
    public GameObject coffreOrClose;
    public GameObject coffreGratuitClose;
    public GameObject coffreCouronneClose;
    public GameObject coffreArgentClose;
    public GameObject coffreEpicClose;
    public GameObject orCard;
    public GameObject gemsCard2;
    public GameObject gemsCard3;
    public GameObject plusCartes;
    public GameObject texteCartes;
    public GameObject nombreDeCartes;

    [Header("Text")]
    public Text nombreCarte;
    public Text nombreCarte1;
    
    [Header("Audio Source")]
    public AudioSource rareSoon;
    public AudioSource commonSoon;
    public AudioSource legendarySoon;
    public AudioSource epicSoon;
    public AudioSource goldSoond;
    public AudioSource menuMusic;
    public AudioSource chestMusic;
    public AudioSource freeChestMusic;
    public AudioSource superMagicChestMusic;
    public AudioSource legendaryChestMusic;
    public AudioSource silverChestMusic;
    public AudioSource goldenChestMusic;
    public AudioSource crownChestMusic;
    public AudioSource giantChestMusic;
    public AudioSource epicChestMusic;
    public AudioSource magicChestMusic;

    private void Start()
    {
        chevalierCards = PlayerPrefs.GetInt("ChevalierCards", chevalierCards);
        recrueRoyalesCards = PlayerPrefs.GetInt("RecrueRoyalesCards", recrueRoyalesCards);
        hordeGargouillesCards = PlayerPrefs.GetInt("HordeGargouillesCards", hordeGargouillesCards);
        goblinGangCards = PlayerPrefs.GetInt("GoblinGangCards", goblinGangCards);
        gobelinsCards = PlayerPrefs.GetInt("GobelinsCard", gobelinsCards);
        gobelinsLanceCards = PlayerPrefs.GetInt("GobelinsLanceCard", gobelinsLanceCards);
        iceSpiritCards = PlayerPrefs.GetInt("IceSpiritCards", iceSpiritCards);
        mégaBouleNeigeCards = PlayerPrefs.GetInt("MégaBouleNeigeCards", mégaBouleNeigeCards);
        minionsCards = PlayerPrefs.GetInt("MinionsCards", minionsCards);
        royalGiantsCards = PlayerPrefs.GetInt("RoyalGiantsCards", royalGiantsCards);
        skeletonsCards = PlayerPrefs.GetInt("skeletonsCards", skeletonsCards);
        teslaCards = PlayerPrefs.GetInt("TeslaCards", teslaCards);
        zapCards = PlayerPrefs.GetInt("ZapCards", zapCards);
        friponsCards = PlayerPrefs.GetInt("FriponsCards", friponsCards);
        eliteBarbariansCards = PlayerPrefs.GetInt("EliteBarbariansCards", eliteBarbariansCards);
        mortierCards = PlayerPrefs.GetInt("MortierCards", mortierCards);
        chauvesSourisCards = PlayerPrefs.GetInt("ChauvesSourisCards", chauvesSourisCards);
        canonCards = PlayerPrefs.GetInt("CanonCards", canonCards);
        bombardierCards = PlayerPrefs.GetInt("BombardierCards", bombardierCards);
        barbaresCards = PlayerPrefs.GetInt("BarbaresCards", barbaresCards);
        arhersCards = PlayerPrefs.GetInt("ArchersCard", arhersCards);
        barbarianHutCard = PlayerPrefs.GetInt("BarbarianHutCard", barbarianHutCard);
        battleRamCard = PlayerPrefs.GetInt("BattleRamCard", battleRamCard);
        cochonRoyauxCard = PlayerPrefs.GetInt("CochonRoyauxCard", cochonRoyauxCard);
        miniPEKKACard = PlayerPrefs.GetInt("MiniPEKKACard", miniPEKKACard);
        hogRiderCard = PlayerPrefs.GetInt("HogRiderCard", hogRiderCard);
        goblinHutCard = PlayerPrefs.GetInt("GoblinHutCard", goblinHutCard);
        giantCard = PlayerPrefs.GetInt("GiantCard", giantCard);
        iceGolemCard = PlayerPrefs.GetInt("IceGolemCard", iceGolemCard);
        machineVolanteCard = PlayerPrefs.GetInt("MachineVolanteCard", machineVolanteCard);
        megaMinionCard = PlayerPrefs.GetInt("MegaMinionCard", megaMinionCard);
        mousquetaireCard = PlayerPrefs.GetInt("MousquetaireCard", mousquetaireCard);
        rocketCard = PlayerPrefs.GetInt("RocketCard", rocketCard);
        séismeCard = PlayerPrefs.GetInt("SéismeCard", séismeCard);
        threeMusketeersCard = PlayerPrefs.GetInt("ThreeMusketeersCard", threeMusketeersCard);
        tombstoneCard = PlayerPrefs.GetInt("TombstoneCard", tombstoneCard);
        tourEnferCard = PlayerPrefs.GetInt("TourEnferCard", tourEnferCard);
        wizardCard = PlayerPrefs.GetInt("WizardCard", wizardCard);
        valkCard = PlayerPrefs.GetInt("ValkCard", valkCard);
        furnaceCard = PlayerPrefs.GetInt("FurnaceCard", furnaceCard);
        elixirCollecterCard = PlayerPrefs.GetInt("ElixirCollecterCard", elixirCollecterCard);
        electrocuteursCard = PlayerPrefs.GetInt("ElectrocuteursCard", electrocuteursCard);
        dartGoblinCard = PlayerPrefs.GetInt("DartGoblinCard", dartGoblinCard);
        cageGobelinCard = PlayerPrefs.GetInt("CageGobelinCard", cageGobelinCard);
        bombTowerCard = PlayerPrefs.GetInt("BombTowerCard", bombTowerCard);
        espritsFeuCards = PlayerPrefs.GetInt("EspritsFeuCards", espritsFeuCards);
        babyDragonCard = PlayerPrefs.GetInt("BabyDragonCard", babyDragonCard);
        bowlerCard = PlayerPrefs.GetInt("BowlerCard", bowlerCard);
        chasseurCard = PlayerPrefs.GetInt("ChasseurCard", chasseurCard);
        clonageCard = PlayerPrefs.GetInt("ClonageCard", clonageCard);
        electroDragonCard = PlayerPrefs.GetInt("ElectroDragonCard", electroDragonCard);
        executionnerCard = PlayerPrefs.GetInt("ExecutionnerCard", executionnerCard);
        witchCard = PlayerPrefs.GetInt("WitchCard", witchCard);
        xBowCard = PlayerPrefs.GetInt("XBowCard", xBowCard);
        princeCard = PlayerPrefs.GetInt("PrinceCard", princeCard);
        princeTenebreuxCard = PlayerPrefs.GetInt("PrinceTenebreuxCard", princeTenebreuxCard);
        poisonCard = PlayerPrefs.GetInt("PoisonCard", poisonCard);
        mirorCard = PlayerPrefs.GetInt("MirorCard", mirorCard);
        lightningCard = PlayerPrefs.GetInt("LightningCard", lightningCard);
        guardsCard = PlayerPrefs.GetInt("GuardsCard", guardsCard);
        golemCard = PlayerPrefs.GetInt("GolemCard", golemCard);
        goblinBarrelCard = PlayerPrefs.GetInt("GoblinBarrelCard", goblinBarrelCard);
        goblinGéantCard = PlayerPrefs.GetInt("GoblinGéantCard", goblinGéantCard);
        giantSkeletonCard = PlayerPrefs.GetInt("GiantSkeletonCard", giantSkeletonCard);
        pEKKACard = PlayerPrefs.GetInt("PEKKACard", pEKKACard);
        rageCard = PlayerPrefs.GetInt("RageCard", rageCard);
        sapeursCard = PlayerPrefs.GetInt("SapeursCard", sapeursCard);
        skeletonArmyCard = PlayerPrefs.GetInt("SkeletonArmyCard", skeletonArmyCard);
        tornadoCard = PlayerPrefs.GetInt("TornadoCard", tornadoCard);
        fûtBarbareCard = PlayerPrefs.GetInt("FûtBarbareCard", fûtBarbareCard);
        charetteCanonCard = PlayerPrefs.GetInt("CharetteCanonCard", charetteCanonCard);
        baloonCard = PlayerPrefs.GetInt("BaloonCard", baloonCard);
        archerMagicCard = PlayerPrefs.GetInt("ArcherMagicCard", archerMagicCard);
        banditCard = PlayerPrefs.GetInt("BanditCard", banditCard);
        cavabélierCard = PlayerPrefs.GetInt("CavabélierCard", cavabélierCard);
        electroWizardCard = PlayerPrefs.GetInt("ElectroWizardCard", electroWizardCard);
        zappyCard = PlayerPrefs.GetInt("ZappyCard", zappyCard);
        princessCard = PlayerPrefs.GetInt("PrincessCard", princessCard);
        mégaChevalierCard = PlayerPrefs.GetInt("MégaChevalierCard", mégaChevalierCard);
        lumberJackCard = PlayerPrefs.GetInt("LumberJackCard", lumberJackCard);
        lavaHoundCard = PlayerPrefs.GetInt("LavaHoundCard", lavaHoundCard);
        infernoDragonCard = PlayerPrefs.GetInt("InfernoDragonCard", infernoDragonCard);
        iceWizardCard = PlayerPrefs.GetInt("IceWizardCard", iceWizardCard);
        graveyardCard = PlayerPrefs.GetInt("GraveyardCard", graveyardCard);
        fantômeRoyalCard = PlayerPrefs.GetInt("FantômeRoyalCard", fantômeRoyalCard);
        mineurCard = PlayerPrefs.GetInt("MineurCard", mineurCard);
        nightWitchCard = PlayerPrefs.GetInt("NightWitchCard", nightWitchCard);
        logCard = PlayerPrefs.GetInt("LogCard", logCard);
    }

    void Update()
    {
        nombreCarte.text = "+" + nombreCartes;
        nombreCarte1.text = "+" + nombreCartes;
        nombreDeCartes.GetComponent<Text>().text = nbCartes + "";
    }

    public void CoffreArgent()
    {
        if (nbCartes == 10)
        {
            silverChestMusic.Play();
            coffreArgentOpen.SetActive(true);
            MenuDisparaitre();
            gold = Random.Range(65, 92);
            nbCartes = 2;
            nombreDeCartes.GetComponent<RectTransform>().localPosition = new Vector3(106, -128, 0);
            Or();
        }
        else
        {
            
            nbCartes -= 1;
        }

        if(nbCartes == 1)
        { 
            orCard.SetActive(false);
            nombreCartes = 12;
            Commune();
        }

        if(nbCartes == 0)
        {
            CommuneDisparaitre();
            nombreCartes = 1;
            Rare();
        }

        if(nbCartes == -1)
        {
            //fin
            RareDisparaitre();
            Menu();
            nbCartes = 10;
            coffreArgentClose.SetActive(true);
        }
    }

    public void CoffreOr()
    {
        if (nbCartes == 10)
        {
            goldenChestMusic.Play();
            coffreOrOpen.SetActive(true);
            MenuDisparaitre();
            random = Random.Range(1, 101);
            gold = Random.Range(205, 288);
            nbCartes = 4;
            nombreDeCartes.GetComponent<RectTransform>().localPosition = new Vector3(131, -105, 0);
            Or();
        }
        else
        {
            nbCartes -= 1;
        }

        if(nbCartes == 3)
        {
            orCard.SetActive(false);
            if(random > 11)
            {
                nombreCartes = Random.Range(1, 35);
                nombreCartes2 = nombreCartes;
                Commune();
                carte = cartes;
            }

            if(random < 12)
            {
                nombreCartes = Random.Range(1, 36);
                Commune();
                carte = cartes;
            }
        }

        if(nbCartes == 2)
        {
            CommuneDisparaitre();
            if (random > 11)
            { 
                nombreCartes = Random.Range(1, 36 - nombreCartes2);
                nombreCartes1 = nombreCartes;
                Commune();
                carte1 = cartes;
            }

            if (random < 12)
            {
                nombreCartes = 37 - nombreCartes;
                nombreCartes2 = nombreCartes;
                Commune();
                carte1 = cartes;
            }
        }

        if (nbCartes == 1)
        {
            CommuneDisparaitre();
            nombreCartes = 4;
            Rare();
        }

        if (nbCartes == 0)
        {
            RareDisparaitre();
            if (random > 11)
            {
                nombreCartes = 37 - (nombreCartes1 + nombreCartes2);
                Commune();
            }

            if (random < 12 && random > 1)
            {
                if (random < 11)
                { 
                    nombreCartes = 1;
                    Epic();
                }
            }

            if (random == 1)
            {
                nombreCartes = 1;
                Légendaire();
            }
        }

        if (nbCartes == -1)
        {
            //fin
            CommuneDisparaitre();
            EpicDisparaitre();
            LégendaireDisparaitre();
            Menu();
            nbCartes = 10;
            coffreOrClose.SetActive(true);
            carte = -1;
            carte1 = -1;
        }
    }
    
    public void CoffreSuperMagic()
    {
        if (ressourceArchieve.gems >= 4900)
        {
            if (nbCartes == 10)
            {
                superMagicChestMusic.Play();
                coffreSuperMagicOpen.SetActive(true);
                MenuDisparaitre();
                random = Random.Range(1, 3);
                gold = 5166;
                nombreDeCartes.GetComponent<RectTransform>().localPosition = new Vector3(174, -139, 0);
                nbCartes = 7;
                Or();
            }
            else
            {
                nbCartes -= 1;
            }

            if (nbCartes == 6)
            {
                orCard.SetActive(false);
                if (random == 1)
                {
                    nombreCartes = Random.Range(1, 567);
                    nombreCartes1 = nombreCartes;
                    Commune();
                    carte = cartes;
                }
                
                if (random == 2)
                {
                    CommuneDisparaitre();
                    nombreCartes = Random.Range(1, 565);
                    nombreCartes1 = nombreCartes;
                    Commune();
                    carte = cartes;
                }
            }

            if (nbCartes == 5)
            {
                CommuneDisparaitre();
                if (random == 1)
                {
                    nombreCartes = Random.Range(1, 567 - nombreCartes1);
                    nombreCartes2 = nombreCartes;
                    Commune();
                    carte1 = cartes;
                }

                if (random == 2)
                {
                    nombreCartes = Random.Range(1, 146);
                    nombreCartes2 = nombreCartes;
                    Rare();
                    carte3 = cartes;
                }
            }

            if (nbCartes == 4)
            {
                CommuneDisparaitre();
                RareDisparaitre();
                if (random == 1)
                {
                    nombreCartes = Random.Range(1, 145);
                    nombreCartes3 = nombreCartes;
                    Rare();
                    carte3 = cartes;
                }

                if (random == 2)
                {
                    nombreCartes = Random.Range(1, 147 - nombreCartes2);
                    nombreCartes3 = nombreCartes;
                    Rare();
                }
            }

            if (nbCartes == 3)
            {
                RareDisparaitre();
                if (random == 1)
                {
                    nombreCartes = 567 - (nombreCartes1 + nombreCartes2);
                    Commune();
                    carte2 = cartes;
                }

                if (random == 2)
                {
                    nombreCartes = Random.Range(1, 566 - nombreCartes1);
                    nombreCartes4 = nombreCartes;
                    Commune();
                    carte2 = cartes;
                }
            }

            if (nbCartes == 2)
            {
                CommuneDisparaitre();
                if (random == 1)
                {
                    nombreCartes = Random.Range(1, 146 - nombreCartes3);
                    nombreCartes4 = nombreCartes;
                    Rare();
                    carte4 = cartes;
                }

                if (random == 2)
                {
                    nombreCartes = 567 - (nombreCartes1 + nombreCartes4);
                    Commune();
                }
            }

            if (nbCartes == 1)
            {
                RareDisparaitre();
                CommuneDisparaitre();
                if (random == 1)
                {
                    nombreCartes = 147 - (nombreCartes3 + nombreCartes4);
                    Rare();
                }

                if (random == 2)
                {
                    nombreCartes = 24;
                    Epic();
                }
            }

            if (nbCartes == 0)
            {
                RareDisparaitre();
                EpicDisparaitre();
                if (random == 1)
                {
                    nombreCartes = 24;
                    Epic();
                }

                if (random == 2)
                {
                    nombreCartes = 1;
                    Légendaire();
                }
            }

            if (nbCartes == -1)
            {
                //fin
                ressourceArchieve.gems -= 4900;
                EpicDisparaitre();
                LégendaireDisparaitre();
                Menu();
                nbCartes = 10;
                coffreSuperMagicClose.SetActive(true);
                carte = -1;
                carte1 = -1;
                carte2 = -1;
                carte3 = -1;
                carte4 = -1;
            }
        }
    }

    public void CoffreMagic()
    {
        if (ressourceArchieve.gems >= 900)
        {
            if (nbCartes == 10)
            {
                magicChestMusic.Play();
                coffreMagicOpen.SetActive(true);
                MenuDisparaitre(); 
                random = Random.Range(1, 101);
                gold = 861;
                nbCartes = 7;
                nombreDeCartes.GetComponent<RectTransform>().localPosition = new Vector3(132, -121, 0);
                Or();
            }
            else
            {
                nbCartes -= 1;
            }

            if (nbCartes == 6)
            {
                orCard.SetActive(false);
                nombreCartes = Random.Range(1, 93);
                nombreCartes1 = nombreCartes;
                Commune();
                carte = cartes;
            }

            if (nbCartes == 5)
            {
                CommuneDisparaitre();
                if (random > 6)
                {
                    nombreCartes = Random.Range(1, 94 - nombreCartes1);
                    nombreCartes2 = nombreCartes;
                    Commune();
                    carte1 = cartes;
                }

                if (random < 7)
                {
                    nombreCartes = Random.Range(1, 23);
                    nombreCartes2 = nombreCartes;
                    Rare();
                    carte3 = cartes;
                }
            }

            if (nbCartes == 4)
            {
                CommuneDisparaitre();
                RareDisparaitre();
                if (random > 6)
                {
                    nombreCartes = Random.Range(1, 22);
                    nombreCartes3 = nombreCartes;
                    Rare();
                    carte3 = cartes;
                }

                if (random < 7)
                {
                    nombreCartes = 24 - nombreCartes2;
                    Rare();
                }
            }

            if (nbCartes == 3)
            {
                RareDisparaitre();
                if (random > 6)
                {
                    nombreCartes = 95 - (nombreCartes1 + nombreCartes2);
                    Commune();
                }

                if (random < 7)
                {
                    nombreCartes = Random.Range(1, 94 - nombreCartes1);
                    nombreCartes3 = nombreCartes;
                    Commune();
                    carte1 = cartes;
                }
            }

            if (nbCartes == 2)
            {
                CommuneDisparaitre();
                if (random > 6)
                {
                    nombreCartes = Random.Range(1, 23 - nombreCartes3);
                    nombreCartes4 = nombreCartes;
                    Rare();
                    carte4 = cartes;
                }

                if (random < 7)
                {
                    nombreCartes = 95 - (nombreCartes1 + nombreCartes3);
                    Commune();
                }
            }

            if (nbCartes == 1)
            {
                RareDisparaitre();
                CommuneDisparaitre();
                if (random > 6)
                {
                    nombreCartes = 24 - (nombreCartes3 + nombreCartes4);
                    Rare();
                }

                if (random < 7)
                {
                    nombreCartes = 4;
                    Epic();
                }
            }

            if (nbCartes == 0)
            {
                RareDisparaitre();
                EpicDisparaitre();
                if (random > 6)
                {
                    nombreCartes = 4;
                    Epic();
                }

                if (random < 7)
                {
                    nombreCartes = 1;
                    Légendaire();
                }
            }

            if (nbCartes == -1)
            {
                //fin
                ressourceArchieve.gems -= 900;
                EpicDisparaitre();
                LégendaireDisparaitre();
                Menu();
                nbCartes = 10;
                coffreMagicClose.SetActive(true);
                carte = -1;
                carte1 = -1;
                carte3 = -1;
                carte4 = -1;
            }
        }
    }

    public void CoffreEpique()
    {
        if (ressourceArchieve.golds >= 10000)
        {
            if (nbCartes == 10)
            {
                
                epicChestMusic.Play();
                coffreEpicOpen.SetActive(true);
                MenuDisparaitre();
                cartes = Random.Range(0, 21);
                nombreCartes = Random.Range(1, 18);
                nombreCartes1 = nombreCartes;
                Epic();
                carte6 = cartes;
                nbCartes = 2;
                nombreDeCartes.GetComponent<RectTransform>().localPosition = new Vector3(131, -131, 0);
            }
            else
            {
                nbCartes -= 1;
            }

            if(nbCartes == 1)
            {
                EpicDisparaitre();
                nombreCartes = Random.Range(1, 19 - nombreCartes1);
                nombreCartes2 = nombreCartes;
                Epic();
                carte7 = cartes;
            }

            if (nbCartes == 0)
            {
                EpicDisparaitre();
                nombreCartes = 19 - (nombreCartes1 + nombreCartes2);
                Epic();
            }

            if (nbCartes == -1)
            {
                //fin
                ressourceArchieve.golds -= 10000;
                EpicDisparaitre();
                Menu();
                nbCartes = 10;
                coffreEpicClose.SetActive(true);
                carte6 = -1;
                carte7 = -1;
            }
        }
    }

    public void CoffreGeant()
    {
        if (ressourceArchieve.gems >= 500)
        {
            if (nbCartes == 10)
            {
                giantChestMusic.Play();
                coffreGéantOpen.SetActive(true);
                MenuDisparaitre();
                random = Random.Range(1, 101);
                gold = 2296;
                nbCartes = 3;
                nombreDeCartes.GetComponent<RectTransform>().localPosition = new Vector3(121, -147, 0);
                Or();
            }
            else
            {
                nbCartes --;
            }

            if (nbCartes == 2)
            {
                orCard.SetActive(false);
                if (random < 23)
                {
                    nombreCartes = 32;
                    Rare();
                }

                if (random > 22)
                {
                    nombreCartes = Random.Range(1, 31);
                    nombreCartes1 = nombreCartes;
                    Rare();
                    carte3 = cartes;
                }
            }

            if (nbCartes == 1)
            {
                RareDisparaitre();
                if (random < 23)
                {
                    nombreCartes = 296;
                    Commune();
                }

                if (random > 22)
                {
                    nombreCartes = 32 - nombreCartes1;
                    Rare();
                }
            }

            if (nbCartes == 0)
            {
                CommuneDisparaitre();
                RareDisparaitre();
                if (random < 23 && random != 21 && random != 22)
                {
                    nombreCartes = 1;
                    Epic();
                }

                if (random == 21 | random == 22)
                {
                    nombreCartes = 1;
                    Légendaire();
                }

                if (random > 21 && random != 21 && random != 22)
                {
                    nombreCartes = 296;
                    Commune();
                }
            }

            if (nbCartes == -1)
            {
                //fin
                ressourceArchieve.gems -= 500;
                EpicDisparaitre();
                LégendaireDisparaitre();
                CommuneDisparaitre();
                Menu();
                nbCartes = 10;
                coffreGéantClose.SetActive(true);
                carte3 = -1;
            }
        }
       
    }

    public void CoffreLegendaire()
    {
        if (ressourceArchieve.gems >= 500)
        {
            if (nbCartes == 10)
            {
                legendaryChestMusic.Play();
                coffreLégendaireOpen.SetActive(true);
                MenuDisparaitre();
                nbCartes = 0;
                nombreDeCartes.GetComponent<RectTransform>().localPosition = new Vector3(136, -130, 0);
                nombreCartes = 1;
                Légendaire();
            }
            else
            {
                nbCartes --;
            }
            
            if (nbCartes == -1)
            {
                //fin
                ressourceArchieve.gems -= 500;
                LégendaireDisparaitre();
                Menu();
                nbCartes = 10;
                coffreLégendaireClose.SetActive(true);
            }
        }
    }

    public void CoffreGratuit()
    {             
        if(nbCartes == 10)
        {
            freeChestMusic.Play();
            coffreGratuitOpen.SetActive(true);
            MenuDisparaitre();
            random = Random.Range(1, 101);
            gold = Random.Range(91, 105);
            Or();

            if (random > 55)
            {
                nbCartes = 2;
            }

            if (random < 56)
            {
                nbCartes = 3;
            }
            nombreDeCartes.GetComponent<RectTransform>().localPosition = new Vector3(120, -122, 0);
        }
        else
        {
            nbCartes -= 1;
        }

        if (nbCartes == 2)
        {
            if(random < 56)
            {
                orCard.SetActive(false);
                if (random < 12)
                {
                    nombreCartes = 12;
                    Commune();
                }
                
                if(random > 11)
                {
                    gems = 2;
                    texteCartes.SetActive(false);
                    Gems();
                }
            }
        }

        if (nbCartes == 1)
        {
            gemsCard2.SetActive(false);
            texteCartes.SetActive(true);
            CommuneDisparaitre();
            if (random < 56)
            {
                if(random > 11)
                {
                    nombreCartes = 12;
                    Commune();
                }

                if(random < 12)
                {
                    nombreCartes = 1;
                    Rare();
                }

            }

            if(random > 55)
            {
                orCard.SetActive(false);
                nombreCartes = 12;
                Commune();
            }
        }

        if (nbCartes == 0)
        {
            CommuneDisparaitre();
            RareDisparaitre();
            if(random > 55)
            {
                nombreCartes = 1;
                Rare();
            }

            if(random < 56)
            {
                if(random > 11)
                {
                    nombreCartes = 1;
                    Rare();
                }

                if(random < 11)
                {
                    nombreCartes = 1;
                    Epic();
                }

                if(random == 11)
                {
                    nombreCartes = 1;
                    Légendaire();
                }

            }

        }

        if(nbCartes == -1)
        {
            //fin
            RareDisparaitre();
            EpicDisparaitre();
            LégendaireDisparaitre();
            Menu();
            nbCartes = 10;
            coffreGratuitClose.SetActive(true);
        }
    }

    public void CoffreCouronne()
    {
        if (nbCartes == 10)
        {
            crownChestMusic.Play();
            coffreCouronneOpen.SetActive(true);
            MenuDisparaitre();
            random = Random.Range(1, 101);
            gold = Random.Range(574, 657);
            nbCartes = 5;
            nombreDeCartes.GetComponent<RectTransform>().localPosition = new Vector3(120, -127, 0);
            Or();
        }
        else
        {
            nbCartes -= 1;
        }

        if (nbCartes == 4)
        {
            orCard.SetActive(false);
            if (random < 12)
            {
                nombreCartes = Random.Range(1, 73);
                nombreCartes1 = nombreCartes;
                Commune();
                carte = cartes;
            }

            if (random > 11 && random < 56)
            {
                nombreCartes = Random.Range(1, 72);
                nombreCartes1 = nombreCartes;
                Commune();
                carte = cartes;
            }

            if (random > 55)
            {
                gems = 3;
                texteCartes.SetActive(false);
                Gems();
            }
        }

        if (nbCartes == 3)
        {
            gemsCard3.SetActive(false);
            texteCartes.SetActive(true);
            CommuneDisparaitre();
            if (random < 12)
            {
                nombreCartes = Random.Range(1, 7);
                nombreCartes2 = nombreCartes;
                Rare();
                carte3 = cartes;
            }

            if (random > 11 && random < 56)
            {
                nombreCartes = Random.Range(1, 73 - nombreCartes1);
                nombreCartes2 = nombreCartes;
                Commune();
                carte1 = cartes;
            }

            if (random > 55)
            {
                nombreCartes = Random.Range(1, 73);
                nombreCartes1 = nombreCartes;
                Commune();
                carte = cartes;
            }
        }

        if (nbCartes == 2)
        {
            RareDisparaitre();
            CommuneDisparaitre();
            if (random < 12)
            {
                nombreCartes = 74 - nombreCartes1;
                nombreCartes3 = nombreCartes;
                Commune();
            }

            if (random > 11 && random < 56)
            {
                nombreCartes = Random.Range(1, 7);
                nombreCartes3 = nombreCartes;
                Rare();
                carte3 = cartes;
            }
            
            if (random > 55)
            {
                nombreCartes = Random.Range(1, 7);
                nombreCartes2 = nombreCartes;
                Rare();
                carte3 = cartes;
            }
        }

        if (nbCartes == 1)
        {
            CommuneDisparaitre();
            RareDisparaitre();
            if (random < 12)
            {
                nombreCartes = 8 - nombreCartes2;
                Rare();
            }

            if (random > 11 && random < 56)
            {
                nombreCartes = 74 - (nombreCartes1 + nombreCartes2);
                Commune();
            }

            if (random > 55)
            {
                nombreCartes = 74 - nombreCartes1;
                nombreCartes3 = nombreCartes;
                Commune();
            }
        }

        if (nbCartes == 0)
        {
            RareDisparaitre();
            CommuneDisparaitre();
            if (random < 11)
            {
                nombreCartes = 1;
                Epic();
            }

            if (random == 11)
            {
                nombreCartes = 1;
                Légendaire();
            }

            if (random > 11 && random < 56)
            {
                nombreCartes = 8 - nombreCartes3;
                Rare();
            }

            if (random > 55)
            {
                nombreCartes = 8 - nombreCartes2;
                Rare();
            }
        }

        if (nbCartes == -1)
        {
            //fin
            EpicDisparaitre();
            RareDisparaitre();
            LégendaireDisparaitre();
            Menu();
            nbCartes = 10;
            coffreCouronneClose.SetActive(true);
            carte = -1;
            carte1 = -1;
            carte3 = -1;
        }
    }
    
    void Commune()
    {
        commonSoon.Play();
        cartes = Random.Range(0, 21);
        if (carte == cartes | carte1 == cartes | carte2 == cartes)
        {
            if (cartes != 21 )
            {
                cartes++;
            }
            else
            {
                cartes = 0;
            }
            
            if (carte == cartes | carte1 == cartes | carte2 == cartes)
            {
                if (cartes != 21)
                {
                    cartes++;
                }
                else
                {
                    cartes = 0;
                }
                
                if (carte == cartes | carte1 == cartes | carte2 == cartes)
                {
                    if (cartes != 21)
                    {
                        cartes++;
                    }
                    else
                    {
                        cartes = 0;
                    }
                }
            }
        }

        if (cartes == 0)
        {
            chevalier.SetActive(true);
            chevalierCards += nombreCartes;
            bibliothequesCartes.Classement(chevalier, communes, chevalierCards, chevalierNuméro);
            PlayerPrefs.SetInt("ChevalierCards", chevalierCards);
        }
        
        if(cartes == 1)
        {
            recrueRoyales.SetActive(true);
            recrueRoyalesCards += nombreCartes;
            bibliothequesCartes.Classement(recrueRoyales, communes, recrueRoyalesCards, recrueRoyalesNuméro);
            PlayerPrefs.SetInt("RecrueRoyalesCards", recrueRoyalesCards);
        }

        if(cartes == 2)
        {
            hordeGargouilles.SetActive(true);
            hordeGargouillesCards += nombreCartes;
            bibliothequesCartes.Classement(hordeGargouilles, communes, hordeGargouillesCards, hordeGargouillesNuméro);
            PlayerPrefs.SetInt("HordeGargouillesCards", hordeGargouillesCards);
        }
        
        if(cartes == 3)
        {
            goblinGang.SetActive(true);
            goblinGangCards += nombreCartes;
            bibliothequesCartes.Classement(goblinGang, communes, goblinGangCards, goblinGangNuméro);
            PlayerPrefs.SetInt("GoblinGangCards", goblinGangCards);
        }

        if(cartes == 4)
        {
            gobelins.SetActive(true);
            gobelinsCards += nombreCartes;
            bibliothequesCartes.Classement(gobelins, communes, gobelinsCards, gobelinsNuméro);
            PlayerPrefs.SetInt("GobelinsCards", gobelinsCards);
        }

        if (cartes == 5)
        {
            gobelinsLance.SetActive(true);
            gobelinsLanceCards += nombreCartes;
            bibliothequesCartes.Classement(gobelinsLance, communes, gobelinsLanceCards, gobelinsLanceNuméro);
            PlayerPrefs.SetInt("GobelinsLanceCards", gobelinsLanceCards);
        }

        if (cartes == 7)
        {
           iceSpirit.SetActive(true);
           iceSpiritCards += nombreCartes;
           bibliothequesCartes.Classement(iceSpirit, communes, iceSpiritCards, iceSpiritNuméro);
           PlayerPrefs.SetInt("IceSpiritCards", iceSpiritCards);
        }

        if (cartes == 8)
        {
            mégaBouleNeige.SetActive(true);
            mégaBouleNeigeCards += nombreCartes;
            bibliothequesCartes.Classement(mégaBouleNeige, communes, mégaBouleNeigeCards, mégaBouleNeigeNuméro);
            PlayerPrefs.SetInt("MégaBouleNeigeCards", mégaBouleNeigeCards);
        }

        if (cartes == 9)
        {
            minions.SetActive(true);
            minionsCards += nombreCartes;
            bibliothequesCartes.Classement(minions, communes, minionsCards, minionsNuméro);
            PlayerPrefs.SetInt("MinionsCards", minionsCards);
        }

        if (cartes == 10)
        {
            royalGiants.SetActive(true); 
            royalGiantsCards += nombreCartes;
            bibliothequesCartes.Classement(royalGiants, communes, royalGiantsCards, royalGiantsNuméro);
            PlayerPrefs.SetInt("RoyalGiantsCards", royalGiantsCards);
        }

        if (cartes == 11)
        {
            skeletons.SetActive(true);
            skeletonsCards += nombreCartes;
            bibliothequesCartes.Classement(skeletons, communes, skeletonsCards, skeletonsNuméro);
            PlayerPrefs.SetInt("SkeletonsCards", skeletonsCards);
        }

        if (cartes == 12)
        {
            tesla.SetActive(true);
            teslaCards += nombreCartes;
            bibliothequesCartes.Classement(tesla, communes, teslaCards, teslaNuméro);
            PlayerPrefs.SetInt("TeslaCards", teslaCards);
        }

        if (cartes == 13)
        {
            zap.SetActive(true);
            zapCards += nombreCartes;
            bibliothequesCartes.Classement(zap, communes, zapCards, zapNuméro);
            PlayerPrefs.SetInt("ZapCards", zapCards);
        }

        if (cartes == 14)
        {
            fripons.SetActive(true);
            friponsCards += nombreCartes;
            bibliothequesCartes.Classement(fripons, communes, friponsCards, friponsNuméro);
            PlayerPrefs.SetInt("FriponCards", friponsCards);
        }

        if (cartes == 15)
        {
            eliteBarbarians.SetActive(true);
            eliteBarbariansCards += nombreCartes;
            bibliothequesCartes.Classement(eliteBarbarians, communes, eliteBarbariansCards, eliteBarbariansNuméro);
            PlayerPrefs.SetInt("EliteBarbariansCards", eliteBarbariansCards);
        }

        if (cartes == 16)
        {
            mortier.SetActive(true);
            mortierCards += nombreCartes;
            bibliothequesCartes.Classement(mortier, communes, mortierCards, mortierNuméro);
            PlayerPrefs.SetInt("MortierCards", mortierCards);
        }

        if (cartes == 17)
        {
            chauvesSouris.SetActive(true);
            chauvesSourisCards += nombreCartes;
            bibliothequesCartes.Classement(chauvesSouris, communes, chauvesSourisCards, chauvesSourisNuméro);
            PlayerPrefs.SetInt("ChauveSourisCards", chauvesSourisCards);
        }

        if (cartes == 18)
        {
            canon.SetActive(true);
            canonCards += nombreCartes;
            bibliothequesCartes.Classement(canon, communes, canonCards, canonNuméro);
            PlayerPrefs.SetInt("CanonCards", canonCards);
        }

        if (cartes == 19)
        {
            bombardier.SetActive(true);
            bombardierCards += nombreCartes;
            bibliothequesCartes.Classement(bombardier, communes, bombardierCards,bombardierNuméro);
            PlayerPrefs.SetInt("BombardierCards", bombardierCards);
        }

        if (cartes == 20)
        {
            barbares.SetActive(true);
            barbaresCards += nombreCartes;
            bibliothequesCartes.Classement(barbares, communes, barbaresCards, barbaresNuméro);
            PlayerPrefs.SetInt("BarbaresCards", barbaresCards);
        }

        if (cartes == 21)
        {
            arhers.SetActive(true);
            arhersCards += nombreCartes;
            bibliothequesCartes.Classement(arhers, communes, arhersCards, arhersNuméro);
            PlayerPrefs.SetInt("archersCards", arhersCards);
        }

        if (cartes == 6)
        {
            espritsFeu.SetActive(true);
            espritsFeuCards += nombreCartes;
            bibliothequesCartes.Classement(espritsFeu, communes, espritsFeuCards, espritsFeuNuméro);
            PlayerPrefs.SetInt("EspritsFeuCards", espritsFeuCards);
        }
    }

    void CommuneDisparaitre()
    { 
        chevalier.SetActive(false);
        recrueRoyales.SetActive(false);
        hordeGargouilles.SetActive(false);
        goblinGang.SetActive(false);
        gobelins.SetActive(false);
        gobelinsLance.SetActive(false);
        iceSpirit.SetActive(false);
        mégaBouleNeige.SetActive(false);
        minions.SetActive(false);
        royalGiants.SetActive(false);
        skeletons.SetActive(false);
        tesla.SetActive(false);
        zap.SetActive(false);
        fripons.SetActive(false);
        eliteBarbarians.SetActive(false); 
        mortier.SetActive(false);
        chauvesSouris.SetActive(false);
        canon.SetActive(false);
        bombardier.SetActive(false);
        barbares.SetActive(false);
        arhers.SetActive(false);
        espritsFeu.SetActive(false);
    }

    void Rare()
    {
        rareSoon.Play();
        cartes = Random.Range(0, 22);
        if (carte3 == cartes | carte4 == cartes)
        {
            if (cartes != 22)
            {
                cartes++;
            }
            else
            {
                cartes = 0;
            }

            if (carte3 == cartes | carte4 == cartes)
            {
                if (cartes != 22)
                {
                    cartes++;
                }
                else
                {
                    cartes = 0;
                }

                if (carte3 == cartes | carte4 == cartes)
                {
                    if (cartes != 22)
                    {
                        cartes++;
                    }
                    else
                    {
                        cartes = 0;
                    }
                }
            }
        }

        if (cartes == 0)
        {
            barbarianHut.SetActive(true);
            barbarianHutCard += nombreCartes;
            bibliothequesCartes.Classement(barbarianHut, rares, barbarianHutCard, barbarianHutNuméro);
            PlayerPrefs.SetInt("BarbarianHutCard", barbarianHutCard);
        }

        if (cartes == 1)
        {
            battleRam.SetActive(true);
            battleRamCard += nombreCartes;
            bibliothequesCartes.Classement(battleRam, rares, battleRamCard, battleRamNuméro);
            PlayerPrefs.SetInt("BattleRamCard", battleRamCard);
        }

        if (cartes == 2)
        {
            cochonRoyaux.SetActive(true);
            cochonRoyauxCard += nombreCartes;
            bibliothequesCartes.Classement(cochonRoyaux, rares, cochonRoyauxCard, cochonRoyauxNuméro);
            PlayerPrefs.SetInt("CochonRoyauxCard", cochonRoyauxCard);
        }

        if (cartes == 3)
        {
            miniPEKKA.SetActive(true);
            miniPEKKACard += nombreCartes;
            bibliothequesCartes.Classement(miniPEKKA, rares, miniPEKKACard, miniPEKKANuméro);
            PlayerPrefs.SetInt("MiniPEKKACard", miniPEKKACard);
        }

        if (cartes == 4)
        {
            hogRider.SetActive(true);
            hogRiderCard += nombreCartes;
            bibliothequesCartes.Classement(hogRider, rares, hogRiderCard, hogRiderNuméro);
            PlayerPrefs.SetInt("HogRiderCard", hogRiderCard);
        }

        if (cartes == 5)
        {
            goblinHut.SetActive(true);
            goblinHutCard += nombreCartes;
            bibliothequesCartes.Classement(goblinHut, rares, goblinHutCard, goblinHutNuméro);
            PlayerPrefs.SetInt("GoblinHutCard", goblinHutCard);
        }

        if (cartes == 7)
        {
            giant.SetActive(true);
            giantCard += nombreCartes;
            bibliothequesCartes.Classement(giant, rares, giantCard, giantNuméro);
            PlayerPrefs.SetInt("GiantCard", giantCard);
        }

        if (cartes == 8)
        {
            iceGolem.SetActive(true);
            iceGolemCard += nombreCartes;
            bibliothequesCartes.Classement(iceGolem, rares, iceGolemCard, iceGolemNuméro);
            PlayerPrefs.SetInt("IceGolemCard", iceGolemCard);
        }

        if (cartes == 9)
        {
            machineVolante.SetActive(true);
            machineVolanteCard += nombreCartes;
            bibliothequesCartes.Classement(machineVolante, rares, machineVolanteCard, machineVolanteNuméro);
            PlayerPrefs.SetInt("MachineVolanteCard", machineVolanteCard);
        }

        if (cartes == 10)
        {
            megaMinion.SetActive(true);
            megaMinionCard += nombreCartes;
            bibliothequesCartes.Classement(megaMinion, rares, megaMinionCard, megaMinionCard);
            PlayerPrefs.SetInt("MegaMinionCard", megaMinionCard);
        }

        if (cartes == 11)
        {
            mousquetaire.SetActive(true);
            mousquetaireCard += nombreCartes;
            bibliothequesCartes.Classement(mousquetaire, rares, mousquetaireCard, mousquetaireNuméro);
            PlayerPrefs.SetInt("MousquetaireCard", mousquetaireCard);
        }

        if (cartes == 12)
        {
            rocket.SetActive(true);
            rocketCard += nombreCartes;
            bibliothequesCartes.Classement(rocket, rares, rocketCard, rocketNuméro);
            PlayerPrefs.SetInt("RocketCard", rocketCard);
        }

        if (cartes == 13)
        {
            séisme.SetActive(true);
            séismeCard += nombreCartes;
            bibliothequesCartes.Classement(séisme, rares, séismeCard, séismeNuméro);
            PlayerPrefs.SetInt("SéismeCard", séismeCard);
        }

        if (cartes == 14)
        {
            threeMusketeers.SetActive(true);
            threeMusketeersCard += nombreCartes;
            bibliothequesCartes.Classement(threeMusketeers, rares, threeMusketeersCard, threeMusketeersNuméro);
            PlayerPrefs.SetInt("ThreeMusketeersCard", threeMusketeersCard);
        }

        if (cartes == 15)
        {
            tombstone.SetActive(true);
            tombstoneCard += nombreCartes;
            bibliothequesCartes.Classement(tombstone, rares, tombstoneCard, tombstoneNuméro);
            PlayerPrefs.SetInt("TombstoneCard", tombstoneCard);
        }

        if (cartes == 16)
        {
            tourEnfer.SetActive(true);
            tourEnferCard += nombreCartes;
            bibliothequesCartes.Classement(tourEnfer, rares, tourEnferCard, tourEnferNuméro);
            PlayerPrefs.SetInt("TourEnferCard", tourEnferCard);
        }

        if (cartes == 17)
        {
            wizard.SetActive(true);
            wizardCard += nombreCartes;
            bibliothequesCartes.Classement(wizard, rares, wizardCard, wizardNuméro);
            PlayerPrefs.SetInt("WizardCard", wizardCard);
        }

        if (cartes == 18)
        {
            furnace.SetActive(true);
            furnaceCard += nombreCartes;
            bibliothequesCartes.Classement(furnace, rares, furnaceCard, furnaceNuméro);
            PlayerPrefs.SetInt("FurnaceCard", furnaceCard);
        }

        if (cartes == 19)
        {
            elixirCollecter.SetActive(true);
            elixirCollecterCard += nombreCartes;
            bibliothequesCartes.Classement(elixirCollecter, rares, elixirCollecterCard, elixirCollecterNuméro);
            PlayerPrefs.SetInt("ElixirCollecterCard", elixirCollecterCard);
        }

        if (cartes == 20)
        {
            electrocuteurs.SetActive(true);
            electrocuteursCard += nombreCartes;
            bibliothequesCartes.Classement(electrocuteurs, rares, electrocuteursCard, electrocuteursNuméro);
            PlayerPrefs.SetInt("ElectrocuteurCard", electrocuteursCard);
        }

        if (cartes == 21)
        {
            dartGoblin.SetActive(true);
            dartGoblinCard += nombreCartes;
            bibliothequesCartes.Classement(dartGoblin, rares, dartGoblinCard, dartGoblinNuméro);
            PlayerPrefs.SetInt("DartGoblinCard", dartGoblinCard);
        }

        if (cartes == 6)
        {
            cageGobelin.SetActive(true);
            cageGobelinCard += nombreCartes;
            bibliothequesCartes.Classement(cageGobelin, rares, cageGobelinCard, cageGobelinNuméro);
            PlayerPrefs.SetInt("CageGoblinCard", cageGobelinCard);
        }

        if (cartes == 22)
        {
            bombTower.SetActive(true);
            bombTowerCard += nombreCartes;
            bibliothequesCartes.Classement(bombTower, rares, bombTowerCard, bombTowerNuméro);
            PlayerPrefs.SetInt("BombTowerCard", bombTowerCard);
        }
    }

    void RareDisparaitre()
    {
        barbarianHut.SetActive(false);
        battleRam.SetActive(false);
        cochonRoyaux.SetActive(false);
        miniPEKKA.SetActive(false);
        hogRider.SetActive(false);
        goblinHut.SetActive(false); 
        giant.SetActive(false);
        iceGolem.SetActive(false);
        machineVolante.SetActive(false);
        megaMinion.SetActive(false);
        mousquetaire.SetActive(false);
        rocket.SetActive(false);
        séisme.SetActive(false);
        threeMusketeers.SetActive(false);
        tombstone.SetActive(false);
        tourEnfer.SetActive(false);
        wizard.SetActive(false);
        furnace.SetActive(false);
        elixirCollecter.SetActive(false);
        electrocuteurs.SetActive(false);
        dartGoblin.SetActive(false);
        cageGobelin.SetActive(false);
        bombTower.SetActive(false);
    }

    void Epic()
    {
        epicSoon.Play();
        cartes = Random.Range(0, 24);

        if (carte6 == cartes | carte7 == cartes)
        {
            if (cartes != 22)
            {
                cartes++;
            }
            else
            {
                cartes = 0;
            }

            if (carte6 == cartes | carte7 == cartes)
            {
                if (cartes != 22)
                {
                    cartes++;
                }
                else
                {
                    cartes = 0;
                }

                if (carte6 == cartes | carte7 == cartes)
                {
                    if (cartes != 22)
                    {
                        cartes++;
                    }
                    else
                    {
                        cartes = 0;
                    }
                }
            }
        }
        if (cartes == 0)
        {
            babyDragon.SetActive(true);
            babyDragonCard += nombreCartes;
            bibliothequesCartes.Classement(babyDragon, epique, babyDragonCard, babyDragonNuméro);
            PlayerPrefs.SetInt("BabyDragonCard", babyDragonCard);
        }

        if (cartes == 1)
        {
            bowler.SetActive(true);
            bowlerCard += nombreCartes;
            bibliothequesCartes.Classement(bowler, epique, bowlerCard, bowlerNuméro);
            PlayerPrefs.SetInt("BowlerCard", bowlerCard);
        }

        if (cartes == 2)
        {
            chasseur.SetActive(true);
            chasseurCard += nombreCartes;
            bibliothequesCartes.Classement(chasseur, epique, chasseurCard, chasseurNuméro);
            PlayerPrefs.SetInt("ChasseurCard", chasseurCard);
        }

        if (cartes == 3)
        {
            clonage.SetActive(true);
            clonageCard += nombreCartes;
            bibliothequesCartes.Classement(clonage, epique, clonageCard, clonageNuméro);
            PlayerPrefs.SetInt("ClonageCard", clonageCard);
        }

        if (cartes == 4)
        {
            electroDragon.SetActive(true);
            electroDragonCard += nombreCartes;
            bibliothequesCartes.Classement(electroDragon, epique, electroDragonCard, electroDragonNuméro);
            PlayerPrefs.SetInt("ElectroDragonCard", electroDragonCard);
        }

        if (cartes == 5)
        {
            executionner.SetActive(true);
            executionnerCard += nombreCartes;
            bibliothequesCartes.Classement(executionner, epique, executionnerCard, executionnerNuméro);
            PlayerPrefs.SetInt("ExecutionnerCard", executionnerCard);
        }

        if (cartes == 7)
        {
            witch.SetActive(true);
            witchCard += nombreCartes;
            bibliothequesCartes.Classement(witch, epique, witchCard, witchNuméro);
            PlayerPrefs.SetInt("WitchCard", witchCard);
        }

        if (cartes == 8)
        {
            xBow.SetActive(true);
            xBowCard += nombreCartes;
            bibliothequesCartes.Classement(xBow, epique, xBowCard, xBowNuméro);
            PlayerPrefs.SetInt("XBowCard", xBowCard);
        }

        if (cartes == 9)
        {
            prince.SetActive(true);
            princeCard += nombreCartes;
            bibliothequesCartes.Classement(prince, epique, princeCard, princeNuméro);
            PlayerPrefs.SetInt("PrinceCard", princeCard);
        }

        if (cartes == 10)
        {
            princeTenebreux.SetActive(true);
            princeTenebreuxCard += nombreCartes;
            bibliothequesCartes.Classement(princeTenebreux, epique, princeTenebreuxCard, princeTenebreuxNuméro);
            PlayerPrefs.SetInt("PrinceTenebreuxCard", princeTenebreuxCard);
        }

        if (cartes == 11)
        {
            miror.SetActive(true);
            mirorCard += nombreCartes;
            bibliothequesCartes.Classement(miror, epique, mirorCard, mirorNuméro);
            PlayerPrefs.SetInt("MirorCard", mirorCard);
        }

        if (cartes == 12)
        {
            lightning.SetActive(true);
            lightningCard += nombreCartes;
            bibliothequesCartes.Classement(lightning, epique, lightningCard, lightningNuméro);
            PlayerPrefs.SetInt("LightingCard", lightningCard);
        }

        if (cartes == 13)
        {
            guards.SetActive(true);
            guardsCard += nombreCartes;
            bibliothequesCartes.Classement(guards, epique, guardsCard, guardsNuméro);
            PlayerPrefs.SetInt("GuardsCard", guardsCard);
        }

        if (cartes == 14)
        {
            golem.SetActive(true);
            golemCard += nombreCartes;
            bibliothequesCartes.Classement(golem, epique, golemCard, golemNuméro);
            PlayerPrefs.SetInt("GolemCard", golemCard);
        }

        if (cartes == 15)
        {
            goblinGéant.SetActive(true);
            goblinGéantCard += nombreCartes;
            bibliothequesCartes.Classement(goblinGéant, epique, goblinGéantCard, goblinGéantNuméro);
            PlayerPrefs.SetInt("GoblinGéantCard", goblinGéantCard);
        }

        if (cartes == 16)
        {
            giantSkeleton.SetActive(true);
            giantSkeletonCard += nombreCartes;
            bibliothequesCartes.Classement(giantSkeleton, epique, giantSkeletonCard, giantSkeletonNuméro);
            PlayerPrefs.SetInt("GiantSkeletonCard", giantSkeletonCard);
        }

        if (cartes == 17)
        {
            goblinBarrel.SetActive(true);
            goblinBarrelCard += nombreCartes;
            bibliothequesCartes.Classement(goblinBarrel, epique, goblinBarrelCard, goblinBarrelNuméro);
            PlayerPrefs.SetInt("GoblinBarrelCard", goblinBarrelCard);
        }

        if (cartes == 18)
        {
            pEKKA.SetActive(true);
            pEKKACard += nombreCartes;
            bibliothequesCartes.Classement(pEKKA, epique, pEKKACard, pEKKANuméro);
            PlayerPrefs.SetInt("PEKKACard", pEKKACard);
        }

        if (cartes == 19)
        {
            rage.SetActive(true);
            rageCard += nombreCartes;
            bibliothequesCartes.Classement(rage, epique, rageCard, rageNuméro);
            PlayerPrefs.SetInt("RageCard", rageCard);
        }

        if (cartes == 20)
        {
            sapeurs.SetActive(true);
            sapeursCard += nombreCartes;
            bibliothequesCartes.Classement(sapeurs, epique, sapeursCard, sapeursNuméro);
            PlayerPrefs.SetInt("SapeursCard", sapeursCard);
        }

        if (cartes == 21)
        {
            skeletonArmy.SetActive(true);
            skeletonArmyCard += nombreCartes;
            bibliothequesCartes.Classement(skeletonArmy, epique, skeletonArmyCard, skeletonArmyNuméro);
            PlayerPrefs.SetInt("SkeletonArmyCard", skeletonArmyCard);
        }

        if (cartes == 6)
        {
            tornado.SetActive(true);
            tornadoCard += nombreCartes;
            bibliothequesCartes.Classement(tornado, epique, tornadoCard, tornadoNuméro);
            PlayerPrefs.SetInt("TornadoCard", tornadoCard);
        }

        if (cartes == 22)
        {
            fûtBarbare.SetActive(true);
            fûtBarbareCard += nombreCartes;
            bibliothequesCartes.Classement(fûtBarbare, epique, fûtBarbareCard, fûtBarbareNuméro);
            PlayerPrefs.SetInt("FûtBarbareCard", fûtBarbareCard);
        }

        if (cartes == 23)
        {
            charetteCanon.SetActive(true);
            charetteCanonCard += nombreCartes;
            bibliothequesCartes.Classement(charetteCanon, epique, charetteCanonCard, charetteCanonNuméro);
            PlayerPrefs.SetInt("CharetteCanonCard", charetteCanonCard);
        }

        if (cartes == 24)
        {
            baloon.SetActive(true);
            baloonCard += nombreCartes;
            bibliothequesCartes.Classement(baloon, epique, baloonCard, baloonNuméro);
            PlayerPrefs.SetInt("BaloonCard", baloonCard);
        }
    }

    void EpicDisparaitre()
    {
        babyDragon.SetActive(false);
        bowler.SetActive(false);
        chasseur.SetActive(false);
        clonage.SetActive(false);
        electroDragon.SetActive(false);
        executionner.SetActive(false);
        witch.SetActive(false);
        xBow.SetActive(false);
        prince.SetActive(false);
        princeTenebreux.SetActive(false);
        miror.SetActive(false);
        lightning.SetActive(false);
        guards.SetActive(false);
        golem.SetActive(false);
        goblinGéant.SetActive(false);
        giantSkeleton.SetActive(false);
        goblinBarrel.SetActive(false);
        pEKKA.SetActive(false);
        rage.SetActive(false);
        sapeurs.SetActive(false);
        skeletonArmy.SetActive(false);
        tornado.SetActive(false);
        fûtBarbare.SetActive(false);
        charetteCanon.SetActive(false);
        baloon.SetActive(false);
    }

    void Légendaire()
    {
        legendarySoon.Play();
        cartes = Random.Range(0, 16);
        if (cartes == 0)
        {
            archerMagic.SetActive(true);
            archerMagicCard += nombreCartes;
            bibliothequesCartes.Classement(archerMagic, legendaire, archerMagicCard, archerMagicNuméro);
            PlayerPrefs.SetInt("ArcherMagicCard", archerMagicCard);
        }

        if (cartes == 1)
        {
            bandit.SetActive(true);
            banditCard += nombreCartes;
            bibliothequesCartes.Classement(bandit, legendaire, banditCard, banditNuméro);
            PlayerPrefs.SetInt("BanditCard", banditCard);
        }

        if (cartes == 2)
        {
            cavabélier.SetActive(true);
            cavabélierCard += nombreCartes;
            bibliothequesCartes.Classement(cavabélier, legendaire, cavabélierCard, cavabélierNuméro);
            PlayerPrefs.SetInt("CavabélierCard", cavabélierCard);
        }

        if (cartes == 3)
        {
            electroWizard.SetActive(true);
            electroWizardCard += nombreCartes;
            bibliothequesCartes.Classement(electroWizard, legendaire, electroWizardCard, electroWizardNuméro);
            PlayerPrefs.SetInt("ElectroWizardCard", electroWizardCard);
        }

        if (cartes == 4)
        {
            zappy.SetActive(true);
            zappyCard += nombreCartes;
            bibliothequesCartes.Classement(zappy, legendaire, zappyCard, zappyNuméro);
            PlayerPrefs.SetInt("ZappyCard", zappyCard);
        }

        if (cartes == 5)
        {
            princess.SetActive(true);
            princessCard += nombreCartes;
            bibliothequesCartes.Classement(princess, legendaire, princessCard, princessNuméro);
            PlayerPrefs.SetInt("PrincessCard", princessCard);
        }

        if (cartes == 7)
        {
            mégaChevalier.SetActive(true);
            mégaChevalierCard += nombreCartes;
            bibliothequesCartes.Classement(mégaChevalier, legendaire, mégaChevalierCard, mégaChevalierNuméro);
            PlayerPrefs.SetInt("MégaChevalierCard", mégaChevalierCard);
        }

        if (cartes == 8)
        {
            lumberJack.SetActive(true);
            lumberJackCard += nombreCartes;
            bibliothequesCartes.Classement(lumberJack, legendaire, lumberJackCard, lumberJackNuméro);
            PlayerPrefs.SetInt("LumberJackCard", lumberJackCard);
        }

        if (cartes == 9)
        {
            lavaHound.SetActive(true);
            lavaHoundCard += nombreCartes;
            bibliothequesCartes.Classement(lavaHound, legendaire, lavaHoundCard, lavaHoundNuméro);
            PlayerPrefs.SetInt("LavaHoundCard", lavaHoundCard);
        }

        if (cartes == 10)
        {
            infernoDragon.SetActive(true);
            infernoDragonCard += nombreCartes;
            bibliothequesCartes.Classement(infernoDragon, legendaire, infernoDragonCard, infernoDragonNuméro);
            PlayerPrefs.SetInt("InfernoDragonCard", infernoDragonCard);
        }

        if (cartes == 11)
        {
            iceWizard.SetActive(true);
            iceWizardCard += nombreCartes;
            bibliothequesCartes.Classement(iceWizard, legendaire, iceWizardCard, iceWizardNuméro);
            PlayerPrefs.SetInt("IceWizardCard", iceWizardCard);
        }

        if (cartes == 12)
        {
            graveyard.SetActive(true);
            graveyardCard += nombreCartes;
            bibliothequesCartes.Classement(graveyard, legendaire, graveyardCard, graveyardNuméro);
            PlayerPrefs.SetInt("GraveyardCard", graveyardCard);
        }

        if (cartes == 13)
        {
            fantômeRoyal.SetActive(true);
            fantômeRoyalCard += nombreCartes;
            bibliothequesCartes.Classement(fantômeRoyal, legendaire, fantômeRoyalCard, fantômeRoyalNuméro);
            PlayerPrefs.SetInt("FantômeRoyalCard", fantômeRoyalCard);
        }

        if (cartes == 14)
        {
            mineur.SetActive(true);
            mineurCard += nombreCartes;
            bibliothequesCartes.Classement(mineur, legendaire, mineurCard, mineurNuméro);
            PlayerPrefs.SetInt("MineurCard", mineurCard);
        }

        if (cartes == 15)
        {
            nightWitch.SetActive(true);
            nightWitchCard += nombreCartes;
            bibliothequesCartes.Classement(nightWitch, legendaire, nightWitchCard, nightWitchNuméro);
            PlayerPrefs.SetInt("NightWitchCard", nightWitchCard);
        }

        if (cartes == 16)
        {
            log.SetActive(true);
            logCard += nombreCartes;
            bibliothequesCartes.Classement(log, legendaire, logCard, logNuméro);
            PlayerPrefs.SetInt("LogCard", logCard);
        }
    }

    void LégendaireDisparaitre()
    {
        archerMagic.SetActive(false); 
        bandit.SetActive(false);
        cavabélier.SetActive(false);
        electroWizard.SetActive(false);
        zappy.SetActive(false);
        princess.SetActive(false);
        mégaChevalier.SetActive(false);
        lumberJack.SetActive(false);
        lavaHound.SetActive(false);
        infernoDragon.SetActive(false);
        iceWizard.SetActive(false);
        graveyard.SetActive(false);
        fantômeRoyal.SetActive(false);
        mineur.SetActive(false);
        nightWitch.SetActive(false);
        log.SetActive(false);
    }

    void MenuDisparaitre()
    {
        menuMusic.Pause();
        chestMusic.Play();
        interfaceMenu.SetActive(false);
        flèche.SetActive(false);
        plusCartes.SetActive(true);
        coffreSuperMagicClose.SetActive(false);
        coffreMagicClose.SetActive(false);
        coffreLégendaireClose.SetActive(false);
        coffreGéantClose.SetActive(false);
        coffreOrClose.SetActive(false);
        coffreGratuitClose.SetActive(false);
        coffreCouronneClose.SetActive(false);
        coffreArgentClose.SetActive(false);
        coffreEpicClose.SetActive(false);
        nombreDeCartes.SetActive(true);
    }

    void Menu()
    {
        menuMusic.UnPause();
        chestMusic.Stop();
        interfaceMenu.SetActive(true);
        flèche.SetActive(true);
        plusCartes.SetActive(false);
        coffreSuperMagicOpen.SetActive(false);
        coffreMagicOpen.SetActive(false);
        coffreLégendaireOpen.SetActive(false);
        coffreGéantOpen.SetActive(false);
        coffreOrOpen.SetActive(false);
        coffreGratuitOpen.SetActive(false);
        coffreCouronneOpen.SetActive(false);
        coffreArgentOpen.SetActive(false);
        coffreEpicOpen.SetActive(false);
        nombreDeCartes.SetActive(false);
    }
    
    void Or()
    {
        goldSoond.Play();
        nombreCartes = gold;
        ressourceArchieve.golds += gold;
        orCard.SetActive(true);
    }

    void Gems()
    {
        goldSoond.Play();
        nombreCartes = gems;
        ressourceArchieve.gems += gems;
        if (gems == 2)
        {
            gemsCard2.SetActive(true);
        }

        if (gems == 3)
        {
            gemsCard3.SetActive(true);
        }
    }
}
