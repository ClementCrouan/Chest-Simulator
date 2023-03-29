using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RessourceArchieve : MonoBehaviour
{
    public int golds;
    public int gems;
    public float xP = 0;
    public Text gemsTexte;
    public Text goldTexte;
    public Text xpTexte;
    public AudioSource gemsSound;
    public AudioSource goldSound;
    public RectTransform barXP;
    public int levelTour = 1;
    private int levelXP2 = 50;
    private int levelXP3 = 100;
    private int levelXP4 = 200;
    private int levelXP5 = 400;
    private int levelXP6 = 1000;
    private int levelXP7 = 2000;
    private int levelXP8 = 5000;
    private int levelXP9 = 10000;
    private int levelXP10 = 30000;
    private int levelXP11 = 40000;
    private int levelXP12 = 80000;
    private string levelXP13 = "Niveau Max.";
    public float xPMax = 20;
    public Text textLevelTour;
    int tic = 0;

    // Start is called before the first frame update
    void Start()
    {
        golds = PlayerPrefs.GetInt("Gold", golds);
        gems = PlayerPrefs.GetInt("Gems", gems);
        levelTour = PlayerPrefs.GetInt("Level", levelTour);
        xP = PlayerPrefs.GetFloat("XP", xP);
        xPMax = PlayerPrefs.GetFloat("XPMax", xPMax);

        textLevelTour.text = levelTour + "";
        if (levelTour != 13)
        {
            xpTexte.text = xP + "/" + xPMax;
            barXP.localScale = new Vector3(xP / xPMax, 1, 1);
        }
        else
        {
            xpTexte.text = levelXP13;
            barXP.localScale = new Vector3(1, 1, 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        gemsTexte.text = "" + gems;
        goldTexte.text = "" + golds;
        tic++;
        
        if (tic == 60)
        {
            PlayerPrefs.SetInt("Gold", golds);
            PlayerPrefs.SetInt("Gems", gems);
            PlayerPrefs.SetInt("Level", levelTour);
            PlayerPrefs.SetFloat("XP", xP);
            PlayerPrefs.SetFloat("XPMax", xPMax);
            tic = 0;
        }

        if (xP / xPMax < 1)
        {
            if (levelTour != 13)
            {
                xpTexte.text = xP + "/" + xPMax;
                barXP.localScale = new Vector3(xP / xPMax, 1, 1);
            }
            else 
            {
                xpTexte.text = levelXP13;
                barXP.localScale = new Vector3(1, 1, 1);
            }
        }
        else
        {
            if (xP >= xPMax && levelTour == 1)
            {
                xP -= xPMax;
                xPMax = levelXP2;
                textLevelTour.text = 2 + "";
            }

            if (xP >= xPMax && levelTour == 2)
            {
                xP -= xPMax;
                xPMax = levelXP3;
                textLevelTour.text = 3 + "";
            }

            if (xP >= xPMax && levelTour == 3)
            {
                xP -= xPMax;
                xPMax = levelXP4;
                textLevelTour.text = 4 + "";
            }

            if (xP >= xPMax && levelTour == 4)
            {
                xP -= xPMax;
                xPMax = levelXP5;
                textLevelTour.text = 5 + "";
            }

            if (xP >= xPMax && levelTour == 5)
            {
                xP -= xPMax;
                xPMax = levelXP6;
                textLevelTour.text = 6 + "";
            }

            if (xP >= xPMax && levelTour == 6)
            {
                xP -= xPMax;
                xPMax = levelXP7;
                textLevelTour.text = 7 + "";
            }

            if (xP >= xPMax && levelTour == 7)
            {
                xP -= xPMax;
                xPMax = levelXP8;
                textLevelTour.text = 8 + "";
            }

            if (xP >= xPMax && levelTour == 8)
            {
                xP -= xPMax;
                xPMax = levelXP9;
                textLevelTour.text = 9 + "";
            }

            if (xP >= xPMax && levelTour == 9)
            {
                xP -= xPMax;
                xPMax = levelXP10;
                textLevelTour.text = 10 + "";
            }

            if (xP >= xPMax && levelTour == 10)
            {
                xP -= xPMax;
                xPMax = levelXP11;
                textLevelTour.text = 11 + "";
            }

            if (xP >= xPMax && levelTour == 11)
            {
                xP -= xPMax;
                xPMax = levelXP12;
                textLevelTour.text = 12 + "";
            }

            if (xP >= xPMax && levelTour == 12)
            {
                xP -= xPMax;
                textLevelTour.text = 13 + "";
            }

            if (levelTour != 13)
            {
                levelTour++;
            }
        }
    }

    public void Réglage()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadSceneAsync(0);
    }

    public void Golds1000()
    {
        goldSound.Play();
        golds += 1000;
    }

    public void Golds10000()
    {
        goldSound.Play();
        golds += 10000;
    }

    public void Golds100000()
    {
        goldSound.Play();
        golds += 100000;
    }

    public void Gems6500()
    {
        gemsSound.Play();
        gems += 6500;
    }

    public void Gems2500()
    {
        gemsSound.Play();
        gems += 2500;
    }

    public void Gems1200()
    {
        gemsSound.Play();
        gems += 1200;
    }

    public void Gems80()
    {
        gemsSound.Play();
        gems += 80;
    }

    public void Gems500()
    {
        gemsSound.Play();
        gems += 500;
    }

    public void Gems14000()
    {
        gemsSound.Play();
        gems += 14000;
    }
}