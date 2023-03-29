using UnityEngine;
using UnityEngine.UI;

public class BibliothequesCartes : MonoBehaviour
{
    public Bibliothèques[] bibliothèques;
    public Coffre coffre;
    private GameObject nombreMaxCartes;
    private GameObject bar;
    private GameObject buttonLevelUp;
    private GameObject buttonLevelUpText;
    private GameObject levelText;
    public RessourceArchieve ressourceArchieve;
    public AudioSource levelUp;

    public void Start()
    {
        for (int i = 0; i < bibliothèques.Length; i++)
        {
            if (i == 0)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes0", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level0", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro0", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes0", bibliothèques[i].raretéCartes);
            }

            if (i == 1)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes1", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level1", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro1", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes1", bibliothèques[i].raretéCartes);
            }

            if (i == 2)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes2", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level2", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro2", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes2", bibliothèques[i].raretéCartes);
            }

            if (i == 3)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes3", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level3", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro3", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes3", bibliothèques[i].raretéCartes);
            }

            if (i == 4)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes4", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level4", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro4", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes4", bibliothèques[i].raretéCartes);
            }

            if (i == 5)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes5", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level5", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro5", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes5", bibliothèques[i].raretéCartes);
            }

            if (i == 6)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes6", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level6", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro6", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes6", bibliothèques[i].raretéCartes);
            }

            if (i == 7)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes7", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level7", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro7", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes7", bibliothèques[i].raretéCartes);
            }

            if (i == 8)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes8", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level8", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro8", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes8", bibliothèques[i].raretéCartes);
            }

            if (i == 9)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes9", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level9", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro9", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes9", bibliothèques[i].raretéCartes);
            }

            if (i == 10)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes10", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level10", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro10", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes10", bibliothèques[i].raretéCartes);
            }

            if (i == 11)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes11", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level11", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro11", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes11", bibliothèques[i].raretéCartes);
            }

            if (i == 12)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("cartes12", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level12", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro12", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes12", bibliothèques[i].raretéCartes);
            }

            if (i == 13)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes13", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level13", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro13", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes13", bibliothèques[i].raretéCartes);
            }

            if (i == 14)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes14", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level14", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro14", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes14", bibliothèques[i].raretéCartes);
            }

            if (i == 15)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes15", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level15", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro15", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes15", bibliothèques[i].raretéCartes);
            }

            if (i == 16)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes16", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level16", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro16", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes16", bibliothèques[i].raretéCartes);
            }

            if (i == 17)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes17", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level17", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro17", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes17", bibliothèques[i].raretéCartes);
            }

            if (i == 18)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes18", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level18", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro18", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes18", bibliothèques[i].raretéCartes);
            }

            if (i == 19)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes19", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level19", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro19", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes19", bibliothèques[i].raretéCartes);
            }

            if (i == 20)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes20", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level20", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro20", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes20", bibliothèques[i].raretéCartes);
            }

            if (i == 21)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes21", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level21", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro21", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes21", bibliothèques[i].raretéCartes);
            }

            if (i == 22)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes22", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level22", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro22", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes22", bibliothèques[i].raretéCartes);
            }

            if (i == 23)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes23", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level23", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro23", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes23", bibliothèques[i].raretéCartes);
            }

            if (i == 24)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes24", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level24", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro24", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes24", bibliothèques[i].raretéCartes);
            }

            if (i == 25)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes25", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level25", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro25", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes25", bibliothèques[i].raretéCartes);
            }

            if (i == 26)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes26", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level26", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro26", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes26", bibliothèques[i].raretéCartes);
            }

            if (i == 27)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes27", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level27", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro27", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes27", bibliothèques[i].raretéCartes);
            }

            if (i == 28)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes28", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level28", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro28", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes28", bibliothèques[i].raretéCartes);
            }

            if (i == 29)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes29", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level29", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro29", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes29", bibliothèques[i].raretéCartes);
            }

            if (i == 30)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes30", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level30", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro30", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes30", bibliothèques[i].raretéCartes);
            }

            if (i == 31)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes31", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level31", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro31", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes31", bibliothèques[i].raretéCartes);
            }

            if (i == 32)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes32", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Cartes32", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro32", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes32", bibliothèques[i].raretéCartes);
            }

            if (i == 33)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes33", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level33", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro33", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes33", bibliothèques[i].raretéCartes);
            }

            if (i == 34)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes34", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level34", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro34", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes34", bibliothèques[i].raretéCartes);
            }

            if (i == 35)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes35", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level35", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro35", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes35", bibliothèques[i].raretéCartes);
            }

            if (i == 36)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes36", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level36", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro36", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes36", bibliothèques[i].raretéCartes);
            }

            if (i == 37)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes37", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level37", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro37", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes37", bibliothèques[i].raretéCartes);
            }

            if (i == 38)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes38", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level38", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro38", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes38", bibliothèques[i].raretéCartes);
            }

            if (i == 39)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes39", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level39", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro39", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes39", bibliothèques[i].raretéCartes);
            }

            if (i == 40)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes40", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level40", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro40", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes40", bibliothèques[i].raretéCartes);
            }

            if (i == 41)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes41", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level41", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro41", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes41", bibliothèques[i].raretéCartes);
            }

            if (i == 42)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes42", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level42", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro42", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes42", bibliothèques[i].raretéCartes);
            }

            if (i == 43)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes43", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level43", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro43", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes43", bibliothèques[i].raretéCartes);
            }

            if (i == 44)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes44", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level44", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro44", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes44", bibliothèques[i].raretéCartes);
            }

            if (i == 45)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes45", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level45", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro45", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes45", bibliothèques[i].raretéCartes);
            }

            if (i == 46)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes46", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level46", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro46", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes46", bibliothèques[i].raretéCartes);
            }

            if (i == 47)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes47", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level47", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro47", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes47", bibliothèques[i].raretéCartes);
            }

            if (i == 48)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes48", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level48", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro48", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes48", bibliothèques[i].raretéCartes);
            }

            if (i == 49)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes49", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level49", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro49", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes49", bibliothèques[i].raretéCartes);
            }

            if (i == 50)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes50", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level50", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro50", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes50", bibliothèques[i].raretéCartes);
            }

            if (i == 51)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes51", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level51", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro51", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes51", bibliothèques[i].raretéCartes);
            }

            if (i == 52)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes52", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level52", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro52", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes52", bibliothèques[i].raretéCartes);
            }

            if (i == 53)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes53", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level53", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro53", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes53", bibliothèques[i].raretéCartes);
            }

            if (i == 54)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes54", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level54", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro54", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes54", bibliothèques[i].raretéCartes);
            }

            if (i == 55)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes55", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level55", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro55", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes55", bibliothèques[i].raretéCartes);
            }

            if (i == 56)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes56", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level56", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro56", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes56", bibliothèques[i].raretéCartes);
            }

            if (i == 57)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes57", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level57", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro57", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes57", bibliothèques[i].raretéCartes);
            }

            if (i == 58)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes58", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level58", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro58", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes58", bibliothèques[i].raretéCartes);
            }

            if (i == 59)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes59", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level59", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro59", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes59", bibliothèques[i].raretéCartes);
            }

            if (i == 60)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes60", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level60", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro60", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes60", bibliothèques[i].raretéCartes);
            }

            if (i == 61)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes61", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level61", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro61", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes61", bibliothèques[i].raretéCartes);
            }

            if (i == 62)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes62", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level62", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro62", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes62", bibliothèques[i].raretéCartes);
            }

            if (i == 63)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes63", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level63", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro63", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes63", bibliothèques[i].raretéCartes);
            }

            if (i == 64)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes64", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level64", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro64", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes64", bibliothèques[i].raretéCartes);
            }

            if (i == 65)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes65", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level65", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro65", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes65", bibliothèques[i].raretéCartes);
            }

            if (i == 66)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes66", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level66", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro66", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes66", bibliothèques[i].raretéCartes);
            }

            if (i == 67)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes67", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level67", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro67", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes67", bibliothèques[i].raretéCartes);
            }

            if (i == 68)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes68", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level68", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro68", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes68", bibliothèques[i].raretéCartes);
            }

            if (i == 69)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes69", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level69", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro69", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes69", bibliothèques[i].raretéCartes);
            }

            if (i == 70)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes70", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level70", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro70", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes70", bibliothèques[i].raretéCartes);
            }

            if (i == 71)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes71", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level71", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro71", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes71", bibliothèques[i].raretéCartes);
            }

            if (i == 72)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes72", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level72", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro72", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes72", bibliothèques[i].raretéCartes);
            }

            if (i == 73)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes73", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level73", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro73", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes73", bibliothèques[i].raretéCartes);
            }

            if (i == 74)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes74", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level74", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro74", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes74", bibliothèques[i].raretéCartes);
            }

            if (i == 75)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes75", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level75", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro75", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes75", bibliothèques[i].raretéCartes);
            }

            if (i == 76)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes76", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level76", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro76", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes76", bibliothèques[i].raretéCartes);
            }

            if (i == 77)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes77", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level77", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro77", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes77", bibliothèques[i].raretéCartes);
            }

            if (i == 78)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes78", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level78", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro78", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes78", bibliothèques[i].raretéCartes);
            }

            if (i == 79)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes79", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level79", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro79", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes79", bibliothèques[i].raretéCartes);
            }

            if (i == 80)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes80", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level80", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro80", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes80", bibliothèques[i].raretéCartes);
            }

            if (i == 81)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes81", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level81", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro81", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes81", bibliothèques[i].raretéCartes);
            }

            if (i == 82)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes82", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level82", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro82", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes82", bibliothèques[i].raretéCartes);
            }

            if (i == 83)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes83", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level83", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro83", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes83", bibliothèques[i].raretéCartes);
            }

            if (i == 84)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes84", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level84", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro84", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes84", bibliothèques[i].raretéCartes);
            }

            if (i == 85)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes85", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level85", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro85", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes85", bibliothèques[i].raretéCartes);
            }

            if (i == 86)
            {
                bibliothèques[i].cartes = PlayerPrefs.GetInt("Cartes86", bibliothèques[i].cartes);
                bibliothèques[i].level = PlayerPrefs.GetInt("Level86", bibliothèques[i].level);
                bibliothèques[i].numéros = PlayerPrefs.GetInt("Numéro86", bibliothèques[i].numéros);
                bibliothèques[i].raretéCartes = PlayerPrefs.GetString("RaretéCartes86", bibliothèques[i].raretéCartes);
            }

            if (bibliothèques[i].numéros == 88)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.chevalier.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 1)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.recrueRoyales.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 2)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.hordeGargouilles.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 3)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.goblinGang.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 4)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.gobelins.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 5)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.gobelinsLance.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 6)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.iceSpirit.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 7)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.mégaBouleNeige.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 8)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.minions.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 9)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.royalGiants.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 10)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.skeletons.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 11)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.tesla.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 12)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.zap.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 13)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.fripons.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 14)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.eliteBarbarians.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 15)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.mortier.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 16)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.chauvesSouris.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 17)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.canon.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 18)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.bombardier.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 19)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.barbares.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 20)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.arhers.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 45)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.espritsFeu.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 21)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.barbarianHut.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 22)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.battleRam.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 23)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.cochonRoyaux.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 24)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.miniPEKKA.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 25)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.hogRider.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 26)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.goblinHut.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 27)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.giant.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 28)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.iceGolem.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 29)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.machineVolante.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 30)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.megaMinion.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 31)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.mousquetaire.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 32)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.rocket.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 34)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.threeMusketeers.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 33)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.séisme.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 35)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.tombstone.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 36)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.tourEnfer.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 37)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.wizard.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 38)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.valk.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 39)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.furnace.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 40)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.elixirCollecter.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 41)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.electrocuteurs.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 42)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.dartGoblin.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 43)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.cageGobelin.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 44)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.bombTower.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 46)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.babyDragon.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 47)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.bowler.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 48)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.chasseur.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 49)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.clonage.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 50)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.electroDragon.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 51)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.executionner.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 52)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.witch.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 53)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.xBow.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 54)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.prince.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 55)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.princeTenebreux.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 56)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.poison.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 57)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.miror.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 58)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.lightning.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 59)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.guards.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 60)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.golem.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 61)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.goblinBarrel.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 62)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.goblinGéant.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 63)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.giantSkeleton.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 64)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.pEKKA.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 65)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.rage.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 66)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.sapeurs.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 67)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.skeletonArmy.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 68)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.tornado.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 69)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.fûtBarbare.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 70)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.charetteCanon.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 71)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.baloon.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 72)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.archerMagic.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 73)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.bandit.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 74)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.cavabélier.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 75)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.electroWizard.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 76)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.zappy.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 77)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.princess.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 78)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.mégaChevalier.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 79)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.lumberJack.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 80)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.lavaHound.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 81)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.infernoDragon.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 82)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.iceWizard.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 83)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.graveyard.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 84)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.fantômeRoyal.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 85)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.mineur.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 86)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.nightWitch.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 87)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = coffre.log.GetComponent<Image>().sprite;
            }

            if (bibliothèques[i].numéros == 0)
            {
                bibliothèques[i].emplacementCartes.SetActive(false);
            }
            else
            {
                bibliothèques[i].emplacementCartes.SetActive(true);
                bibliothèques[i].emplacementCartes.tag = bibliothèques[i].raretéCartes;
                Comptabiliser(i, bibliothèques[i].cartes);
            }
        }
    }

    public void Classement(GameObject nouvelleCarte, string rareté, int nombreCartes, int numéro)
    {
        for (int i = 0; i < bibliothèques.Length; i++)
        { 
            if (bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite == nouvelleCarte.GetComponent<Image>().sprite)
            {
                if (bibliothèques[i].raretéCartes == "Commune")
                {
                    if (bibliothèques[i].level == 2)
                    {
                        nombreCartes -= 2;
                    }

                    if (bibliothèques[i].level == 3)
                    {
                        nombreCartes -= 6;
                    }

                    if (bibliothèques[i].level == 4)
                    {
                        nombreCartes -= 16;
                    }

                    if (bibliothèques[i].level == 5)
                    {
                        nombreCartes -= 36;
                    }

                    if (bibliothèques[i].level == 6)
                    {
                        nombreCartes -= 86;
                    }

                    if (bibliothèques[i].level == 7)
                    {
                        nombreCartes -= 186;
                    }

                    if (bibliothèques[i].level == 8)
                    {
                        nombreCartes -= 386;
                    }

                    if (bibliothèques[i].level == 9)
                    {
                        nombreCartes -= 786;
                    }

                    if (bibliothèques[i].level == 10)
                    {
                        nombreCartes -= 1586;
                    }

                    if (bibliothèques[i].level == 11)
                    {
                        nombreCartes -= 2586;
                    }

                    if (bibliothèques[i].level == 12)
                    {
                        nombreCartes -= 4586;
                    }

                    if (bibliothèques[i].level == 13)
                    {
                        nombreCartes -= 9586;
                    }
                }

                if (bibliothèques[i].raretéCartes == "Rare")
                {
                    if (bibliothèques[i].level == 4)
                    {
                        nombreCartes -= 2;
                    }

                    if (bibliothèques[i].level == 5)
                    {
                        nombreCartes -= 6;
                    }

                    if (bibliothèques[i].level == 6)
                    {
                        nombreCartes -= 16;
                    }

                    if (bibliothèques[i].level == 7)
                    {
                        nombreCartes -= 36;
                    }

                    if (bibliothèques[i].level == 8)
                    {
                        nombreCartes -= 86;
                    }

                    if (bibliothèques[i].level == 9)
                    {
                        nombreCartes -= 186;
                    }

                    if (bibliothèques[i].level == 10)
                    {
                        nombreCartes -= 386;
                    }

                    if (bibliothèques[i].level == 11)
                    {
                        nombreCartes -= 786;
                    }

                    if (bibliothèques[i].level == 12)
                    {
                        nombreCartes -= 1586;
                    }

                    if (bibliothèques[i].level == 13)
                    {
                        nombreCartes -= 2586;
                    }
                }

                if (bibliothèques[i].raretéCartes == "Epique")
                {
                    if (bibliothèques[i].level == 7)
                    {
                        nombreCartes -= 2;
                    }

                    if (bibliothèques[i].level == 8)
                    {
                        nombreCartes -= 6;
                    }

                    if (bibliothèques[i].level == 9)
                    {
                        nombreCartes -= 16;
                    }

                    if (bibliothèques[i].level == 10)
                    {
                        nombreCartes -= 36;
                    }

                    if (bibliothèques[i].level == 11)
                    {
                        nombreCartes -= 86;
                    }

                    if (bibliothèques[i].level == 12)
                    {
                        nombreCartes -= 186;
                    }

                    if (bibliothèques[i].level == 13)
                    {
                        nombreCartes -= 386;
                    }
                }

                if (bibliothèques[i].raretéCartes == "Légendaire")
                {
                    if (bibliothèques[i].level == 10)
                    {
                        nombreCartes -= 2;
                    }

                    if (bibliothèques[i].level == 11)
                    {
                        nombreCartes -= 6;
                    }

                    if (bibliothèques[i].level == 12)
                    {
                        nombreCartes -= 16;
                    }

                    if (bibliothèques[i].level == 13)
                    {
                        nombreCartes -= 36;
                    }
                }

                Comptabiliser(i, nombreCartes);
                bibliothèques[i].cartes = nombreCartes;

                Sauvegarder(i);
                break;
            }
            if (bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite == null)
            {
                bibliothèques[i].emplacementCartes.GetComponent<Image>().sprite = nouvelleCarte.GetComponent<Image>().sprite;
                bibliothèques[i].emplacementCartes.SetActive(true);
                bibliothèques[i].emplacementCartes.tag = (rareté);
                bibliothèques[i].raretéCartes = (rareté);
                bibliothèques[i].numéros = numéro;

                if (bibliothèques[i].emplacementCartes.tag == "Commune")
                {
                    bibliothèques[i].level = 1;
                }

                if (bibliothèques[i].emplacementCartes.tag == "Rare")
                {
                    bibliothèques[i].level = 3;
                }

                if (bibliothèques[i].emplacementCartes.tag == "Epique")
                {
                    bibliothèques[i].level = 6;
                }

                if (bibliothèques[i].emplacementCartes.tag == "Légendaire")
                {
                    bibliothèques[i].level = 9;
                }

                Comptabiliser(i, nombreCartes);
                bibliothèques[i].cartes = nombreCartes;

                Sauvegarder(i);
                break;
            }
        }
    }

    void Comptabiliser(int i, int nombreCartes)
    {
        nombreMaxCartes = bibliothèques[i].emplacementCartes.transform.Find("Barre de Niveaux/Nb Cartes Text").gameObject;
        bar = bibliothèques[i].emplacementCartes.transform.Find("Barre de Niveaux/Image").gameObject;
        buttonLevelUp = bibliothèques[i].emplacementCartes.transform.Find("Barre de Niveaux/Button Level Up").gameObject;
        buttonLevelUpText = bibliothèques[i].emplacementCartes.transform.Find("Barre de Niveaux/Button Level Up/Button Level Up Text").gameObject;
        levelText = bibliothèques[i].emplacementCartes.transform.Find("Barre de Niveaux/Level").gameObject;
        levelText.GetComponent<Text>().text = "Niveau " + bibliothèques[i].level;

        if (bibliothèques[i].emplacementCartes.tag == "Commune")
        {
            if (bibliothèques[i].level == 1)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/2";
                if (nombreCartes / 2f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 2f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "5";
                }
            }

            if (bibliothèques[i].level == 2)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/4";
                if (nombreCartes / 4f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 4f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "20";
                }
            }

            if (bibliothèques[i].level == 3)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/10";
                if (nombreCartes / 10f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 10f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "50";
                }
            }

            if (bibliothèques[i].level == 4)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/20";
                if (nombreCartes / 20f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 20f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "150";
                }
            }

            if (bibliothèques[i].level == 5)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/50";
                if (nombreCartes / 50f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 50f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "400";
                }
            }

            if (bibliothèques[i].level == 6)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/100";
                if (nombreCartes / 100f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 100f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "1000";
                }
            }

            if (bibliothèques[i].level == 7)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/200";
                if (nombreCartes / 200f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 200f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "2000";
                }
            }

            if (bibliothèques[i].level == 8)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/400";
                if (nombreCartes / 400f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 400f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "4000";
                }
            }

            if (bibliothèques[i].level == 9)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/800";
                if (nombreCartes / 800f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 800f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "8000";
                }
            }

            if (bibliothèques[i].level == 10)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/1000";
                if (nombreCartes / 1000f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 1000f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "20k";
                }
            }

            if (bibliothèques[i].level == 11)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/2000";
                if (nombreCartes / 2000f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 2000f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "50k";
                }
            }

            if (bibliothèques[i].level == 12)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/5000";
                if (nombreCartes / 5000f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 5000f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "100k";
                }
            }

            if (bibliothèques[i].level == 13)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/250";
                bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                buttonLevelUp.SetActive(false);
            }
        }

        if (bibliothèques[i].emplacementCartes.tag == "Rare")
        {
            if (bibliothèques[i].level == 3)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/2";
                if (nombreCartes / 2f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 2f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "50";
                }
            }

            if (bibliothèques[i].level == 4)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/4";
                if (nombreCartes / 4f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 4f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "150";
                }
            }

            if (bibliothèques[i].level == 5)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/10";
                if (nombreCartes / 10f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 10f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "400";
                }
            }

            if (bibliothèques[i].level == 6)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/20";
                if (nombreCartes / 20f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 20f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "1000";
                }
            }

            if (bibliothèques[i].level == 7)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/50";
                if (nombreCartes / 50f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 50f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "2000";
                }
            }

            if (bibliothèques[i].level == 8)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/100";
                if (nombreCartes / 100f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 100f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "4000";
                }
            }

            if (bibliothèques[i].level == 9)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/200";
                if (nombreCartes / 200f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 200f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "8000";
                }
            }

            if (bibliothèques[i].level == 10)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/400";
                if (nombreCartes / 400f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 400f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "20k";
                }
            }

            if (bibliothèques[i].level == 11)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/800";
                if (nombreCartes / 800f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 800f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "50k";
                }
            }

            if (bibliothèques[i].level == 12)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/1000";
                if (nombreCartes / 1000f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 1000f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "100k";
                }
            }

            if (bibliothèques[i].level == 13)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/50";
                bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                buttonLevelUp.SetActive(false);
            }
        }

        if (bibliothèques[i].emplacementCartes.tag == "Epique")
        {
            if (bibliothèques[i].level == 6)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/2";
                if (nombreCartes / 2f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 2f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "1000";
                }
            }

            if (bibliothèques[i].level == 7)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/4";
                if (nombreCartes / 4f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 4f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "2000";
                }
            }

            if (bibliothèques[i].level == 8)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/10";
                if (nombreCartes / 10f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 10f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "4000";
                }
            }

            if (bibliothèques[i].level == 9)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/20";
                if (nombreCartes / 20f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 20f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "8000";
                }
            }

            if (bibliothèques[i].level == 10)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/50";
                if (nombreCartes / 50f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 50f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "20k";
                }
            }

            if (bibliothèques[i].level == 11)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/100";
                if (nombreCartes / 100f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 100f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "50k";
                }
            }

            if (bibliothèques[i].level == 12)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/200";
                if (nombreCartes / 200f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 200f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "100k";
                }
            }

            if (bibliothèques[i].level == 13)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/10";
                bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                buttonLevelUp.SetActive(false);
            }
        }

        if (bibliothèques[i].emplacementCartes.tag == "Légendaire")
        {
            if (bibliothèques[i].level == 9)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/2";
                if (nombreCartes / 2f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 2f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "8000";
                }
            }

            if (bibliothèques[i].level == 10)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/4";
                if (nombreCartes / 4f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 4f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "20k";
                }
            }

            if (bibliothèques[i].level == 11)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/10";
                if (nombreCartes / 10f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 10f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = "50k";
                }
            }

            if (bibliothèques[i].level == 12)
            {
                nombreMaxCartes.GetComponent<Text>().text = nombreCartes + "/20";
                if (nombreCartes / 20f < 1)
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(nombreCartes / 20f, 1, 1);
                    buttonLevelUp.SetActive(false);
                }
                else
                {
                    bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                    buttonLevelUp.SetActive(true);
                    buttonLevelUpText.GetComponent<Text>().text = nombreCartes + "/1";
                }
            }

            if (bibliothèques[i].level == 13)
            {
                nombreMaxCartes.GetComponent<Text>().text = "Niveaux Max";
                bar.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                buttonLevelUp.SetActive(false);
            }
        }

        Sauvegarder(i);
    }

    public void Augmenter(GameObject carte)
    {
        for (int i = 0; i < bibliothèques.Length; i++)
        {
            if (bibliothèques[i].emplacementCartes.name == carte.name)
            {
                if (bibliothèques[i].raretéCartes == "Commune")
                { 
                    if (bibliothèques[i].level == 1 && bibliothèques[i].cartes >= 2 && ressourceArchieve.golds >= 5)
                    { 
                        bibliothèques[i].cartes -= 2;
                        ressourceArchieve.golds -= 5;
                        ressourceArchieve.xP += 4;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 2 && bibliothèques[i].cartes >= 4 && ressourceArchieve.golds >= 20)
                    {
                        bibliothèques[i].cartes -= 4;
                        ressourceArchieve.golds -= 20;
                        ressourceArchieve.xP += 5;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 3 && bibliothèques[i].cartes >= 10 && ressourceArchieve.golds >= 50)
                    {
                        bibliothèques[i].cartes -= 10;
                        ressourceArchieve.golds -= 50;
                        ressourceArchieve.xP += 6;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 4 && bibliothèques[i].cartes >= 20 && ressourceArchieve.golds >= 150)
                    {
                        bibliothèques[i].cartes -= 20;
                        ressourceArchieve.golds -= 150;
                        ressourceArchieve.xP += 10;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 5 && bibliothèques[i].cartes >= 50 && ressourceArchieve.golds >= 400)
                    {
                        bibliothèques[i].cartes -= 50;
                        ressourceArchieve.golds -= 400;
                        ressourceArchieve.xP += 25;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 6 && bibliothèques[i].cartes >= 100 && ressourceArchieve.golds >= 1000)
                    {
                        bibliothèques[i].cartes -= 100;
                        ressourceArchieve.golds -= 1000;
                        ressourceArchieve.xP += 50;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 7 && bibliothèques[i].cartes >= 200 && ressourceArchieve.golds >= 2000)
                    {
                        bibliothèques[i].cartes -= 200;
                        ressourceArchieve.golds -= 2000;
                        ressourceArchieve.xP += 100;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 8 && bibliothèques[i].cartes >= 400 && ressourceArchieve.golds >= 4000)
                    {
                        bibliothèques[i].cartes -= 400;
                        ressourceArchieve.golds -= 4000;
                        ressourceArchieve.xP += 200;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 9 && bibliothèques[i].cartes >= 800 && ressourceArchieve.golds >= 8000)
                    {
                        bibliothèques[i].cartes -= 800;
                        ressourceArchieve.golds -= 8000;
                        ressourceArchieve.xP += 400;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 10 && bibliothèques[i].cartes >= 1000 && ressourceArchieve.golds >= 20000)
                    {
                        bibliothèques[i].cartes -= 1000;
                        ressourceArchieve.golds -= 20000;
                        ressourceArchieve.xP += 600;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 11 && bibliothèques[i].cartes >= 2000 && ressourceArchieve.golds >= 50000)
                    {
                        bibliothèques[i].cartes -= 2000;
                        ressourceArchieve.golds -= 50000;
                        ressourceArchieve.xP += 800;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 12 && bibliothèques[i].cartes >= 5000 && ressourceArchieve.golds >= 100000)
                    {
                        bibliothèques[i].cartes -= 5000;
                        ressourceArchieve.golds -= 100000;
                        ressourceArchieve.xP += 1600;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }
                }
                
                if (bibliothèques[i].raretéCartes == "Rare")
                {
                    if (bibliothèques[i].level == 3 && bibliothèques[i].cartes >= 2 && ressourceArchieve.golds >= 50)
                    {
                        bibliothèques[i].cartes -= 2;
                        ressourceArchieve.golds -= 50;
                        ressourceArchieve.xP += 6;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 4 && bibliothèques[i].cartes >= 4 && ressourceArchieve.golds >= 150)
                    {
                        bibliothèques[i].cartes -= 4;
                        ressourceArchieve.golds -= 150;
                        ressourceArchieve.xP += 10;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 5 && bibliothèques[i].cartes >= 10 && ressourceArchieve.golds >= 400)
                    {
                        bibliothèques[i].cartes -= 10;
                        ressourceArchieve.golds -= 400;
                        ressourceArchieve.xP += 25;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 6 && bibliothèques[i].cartes >= 20 && ressourceArchieve.golds >= 1000)
                    {
                        bibliothèques[i].cartes -= 20;
                        ressourceArchieve.golds -= 1000;
                        ressourceArchieve.xP += 50;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 7 && bibliothèques[i].cartes >= 50 && ressourceArchieve.golds >= 2000)
                    {
                        bibliothèques[i].cartes -= 50;
                        ressourceArchieve.golds -= 2000;
                        ressourceArchieve.xP += 100;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 8 && bibliothèques[i].cartes >= 100 && ressourceArchieve.golds >= 4000)
                    {
                        bibliothèques[i].cartes -= 100;
                        ressourceArchieve.golds -= 4000;
                        ressourceArchieve.xP += 200;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 9 && bibliothèques[i].cartes >= 200 && ressourceArchieve.golds >= 8000)
                    {
                        bibliothèques[i].cartes -= 200;
                        ressourceArchieve.golds -= 8000;
                        ressourceArchieve.xP += 400;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 10 && bibliothèques[i].cartes >= 400 && ressourceArchieve.golds >= 20000)
                    {
                        bibliothèques[i].cartes -= 400;
                        ressourceArchieve.golds -= 20000;
                        ressourceArchieve.xP += 600;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 11 && bibliothèques[i].cartes >= 800 && ressourceArchieve.golds >= 50000)
                    {
                        bibliothèques[i].cartes -= 800;
                        ressourceArchieve.golds -= 50000;
                        ressourceArchieve.xP += 800;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 12 && bibliothèques[i].cartes >= 1000 && ressourceArchieve.golds >= 100000)
                    {
                        bibliothèques[i].cartes -= 1000;
                        ressourceArchieve.golds -= 100000;
                        ressourceArchieve.xP += 1600;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }
                }

                if (bibliothèques[i].raretéCartes == "Epique")
                {
                    if (bibliothèques[i].level == 6 && bibliothèques[i].cartes >= 2 && ressourceArchieve.golds >= 1000)
                    {
                        bibliothèques[i].cartes -= 2;
                        ressourceArchieve.golds -= 1000;
                        ressourceArchieve.xP += 50;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 7 && bibliothèques[i].cartes >= 4 && ressourceArchieve.golds >= 2000)
                    {
                        bibliothèques[i].cartes -= 4;
                        ressourceArchieve.golds -= 2000;
                        ressourceArchieve.xP += 100;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 8 && bibliothèques[i].cartes >= 10 && ressourceArchieve.golds >= 4000)
                    {
                        bibliothèques[i].cartes -= 10;
                        ressourceArchieve.golds -= 4000;
                        ressourceArchieve.xP += 200;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 9 && bibliothèques[i].cartes >= 20 && ressourceArchieve.golds >= 8000)
                    {
                        bibliothèques[i].cartes -= 20;
                        ressourceArchieve.golds -= 8000;
                        ressourceArchieve.xP += 400;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 10 && bibliothèques[i].cartes >= 50 && ressourceArchieve.golds >= 20000)
                    {
                        bibliothèques[i].cartes -= 50;
                        ressourceArchieve.golds -= 20000;
                        ressourceArchieve.xP += 600;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 11 && bibliothèques[i].cartes >= 100 && ressourceArchieve.golds >= 50000)
                    {
                        bibliothèques[i].cartes -= 100;
                        ressourceArchieve.golds -= 50000;
                        ressourceArchieve.xP += 800;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 12 && bibliothèques[i].cartes >= 200 && ressourceArchieve.golds >= 100000)
                    {
                        bibliothèques[i].cartes -= 200;
                        ressourceArchieve.golds -= 100000;
                        ressourceArchieve.xP += 1600;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }
                }

                if (bibliothèques[i].raretéCartes == "Légendaire")
                {
                    if (bibliothèques[i].level == 9 && bibliothèques[i].cartes >= 2 && ressourceArchieve.golds >= 8000)
                    {
                        bibliothèques[i].cartes -= 2;
                        ressourceArchieve.golds -= 8000;
                        ressourceArchieve.xP += 400;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 10 && bibliothèques[i].cartes >= 4 && ressourceArchieve.golds >= 20000)
                    {
                        bibliothèques[i].cartes -= 4;
                        ressourceArchieve.golds -= 20000;
                        ressourceArchieve.xP += 600;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 11 && bibliothèques[i].cartes >= 10 && ressourceArchieve.golds >= 50000)
                    {
                        bibliothèques[i].cartes -= 10;
                        ressourceArchieve.golds -= 50000;
                        ressourceArchieve.xP += 800;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }

                    if (bibliothèques[i].level == 12 && bibliothèques[i].cartes >= 20 && ressourceArchieve.golds >= 100000)
                    {
                        bibliothèques[i].cartes -= 20;
                        ressourceArchieve.golds -= 100000;
                        ressourceArchieve.xP += 1600;
                        bibliothèques[i].level++;
                        levelUp.Play();
                        Comptabiliser(i, bibliothèques[i].cartes);
                        break;
                    }
                }

                Sauvegarder(i);
                break;
            }
        }
    }

    void Sauvegarder(int i)
    {
        if (i == 0)
        {
            PlayerPrefs.SetInt("Cartes0", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level0", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro0", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes0", bibliothèques[i].raretéCartes);
        }

        if (i == 1)
        {
            PlayerPrefs.SetInt("Cartes1", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level1", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro1", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes1", bibliothèques[i].raretéCartes);
        }

        if (i == 2)
        {
            PlayerPrefs.SetInt("Cartes2", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level2", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro2", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes2", bibliothèques[i].raretéCartes);
        }

        if (i == 3)
        {
            PlayerPrefs.SetInt("Cartes3", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level3", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro3", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes3", bibliothèques[i].raretéCartes);
        }

        if (i == 4)
        {
            PlayerPrefs.SetInt("Cartes4", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level4", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro4", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes4", bibliothèques[i].raretéCartes);
        }

        if (i == 5)
        {
            PlayerPrefs.SetInt("Cartes5", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level5", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro5", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes5", bibliothèques[i].raretéCartes);
        }

        if (i == 6)
        {
            PlayerPrefs.SetInt("Cartes6", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level6", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro6", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes6", bibliothèques[i].raretéCartes);
        }

        if (i == 7)
        {
            PlayerPrefs.SetInt("Cartes7", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level7", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro7", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes7", bibliothèques[i].raretéCartes);
        }

        if (i == 8)
        {
            PlayerPrefs.SetInt("Cartes8", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level8", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro8", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes8", bibliothèques[i].raretéCartes);
        }

        if (i == 9)
        {
            PlayerPrefs.SetInt("Cartes9", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level9", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro9", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes9", bibliothèques[i].raretéCartes);
        }

        if (i == 10)
        {
            PlayerPrefs.SetInt("Cartes10", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level10", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro10", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes10", bibliothèques[i].raretéCartes);
        }

        if (i == 11)
        {
            PlayerPrefs.SetInt("Cartes11", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level11", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro11", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes11", bibliothèques[i].raretéCartes);
        }

        if (i == 12)
        {
            PlayerPrefs.SetInt("cartes12", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level12", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro12", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes12", bibliothèques[i].raretéCartes);
        }

        if (i == 13)
        {
            PlayerPrefs.SetInt("Cartes13", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level13", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro13", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes13", bibliothèques[i].raretéCartes);
        }

        if (i == 14)
        {
            PlayerPrefs.SetInt("Cartes14", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level14", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro14", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes14", bibliothèques[i].raretéCartes);
        }

        if (i == 15)
        {
            PlayerPrefs.SetInt("Cartes15", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level15", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro15", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes15", bibliothèques[i].raretéCartes);
        }

        if (i == 16)
        {
            PlayerPrefs.SetInt("Cartes16", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level16", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro16", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes16", bibliothèques[i].raretéCartes);
        }

        if (i == 17)
        {
            PlayerPrefs.SetInt("Cartes17", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level17", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro17", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes17", bibliothèques[i].raretéCartes);
        }

        if (i == 18)
        {
            PlayerPrefs.SetInt("Cartes18", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level18", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro18", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes18", bibliothèques[i].raretéCartes);
        }

        if (i == 19)
        {
            PlayerPrefs.SetInt("Cartes19", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level19", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro19", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes19", bibliothèques[i].raretéCartes);
        }

        if (i == 20)
        {
            PlayerPrefs.SetInt("Cartes20", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level20", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro20", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes20", bibliothèques[i].raretéCartes);
        }

        if (i == 21)
        {
            PlayerPrefs.SetInt("Cartes21", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level21", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro21", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes21", bibliothèques[i].raretéCartes);
        }

        if (i == 22)
        {
            PlayerPrefs.SetInt("Cartes22", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level22", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro22", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes22", bibliothèques[i].raretéCartes);
        }

        if (i == 23)
        {
            PlayerPrefs.SetInt("Cartes23", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level23", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro23", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes23", bibliothèques[i].raretéCartes);
        }

        if (i == 24)
        {
            PlayerPrefs.SetInt("Cartes24", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level24", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro24", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes24", bibliothèques[i].raretéCartes);
        }

        if (i == 25)
        {
            PlayerPrefs.SetInt("Cartes25", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level25", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro25", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes25", bibliothèques[i].raretéCartes);
        }

        if (i == 26)
        {
            PlayerPrefs.SetInt("Cartes26", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level26", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro26", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes26", bibliothèques[i].raretéCartes);
        }

        if (i == 27)
        {
            PlayerPrefs.SetInt("Cartes27", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level27", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro27", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes27", bibliothèques[i].raretéCartes);
        }

        if (i == 28)
        {
            PlayerPrefs.SetInt("Cartes28", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level28", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro28", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes28", bibliothèques[i].raretéCartes);
        }

        if (i == 29)
        {
            PlayerPrefs.SetInt("Cartes29", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level29", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro29", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes29", bibliothèques[i].raretéCartes);
        }

        if (i == 30)
        {
            PlayerPrefs.SetInt("Cartes30", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level30", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro30", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes30", bibliothèques[i].raretéCartes);
        }

        if (i == 31)
        {
            PlayerPrefs.SetInt("Cartes31", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level31", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro31", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes31", bibliothèques[i].raretéCartes);
        }

        if (i == 32)
        {
            PlayerPrefs.SetInt("Cartes32", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Cartes32", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro32", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes32", bibliothèques[i].raretéCartes);
        }

        if (i == 33)
        {
            PlayerPrefs.SetInt("Cartes33", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level33", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro33", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes33", bibliothèques[i].raretéCartes);
        }

        if (i == 34)
        {
            PlayerPrefs.SetInt("Cartes34", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level34", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro34", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes34", bibliothèques[i].raretéCartes);
        }

        if (i == 35)
        {
            PlayerPrefs.SetInt("Cartes35", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level35", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro35", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes35", bibliothèques[i].raretéCartes);
        }

        if (i == 36)
        {
            PlayerPrefs.SetInt("Cartes36", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level36", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro36", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes36", bibliothèques[i].raretéCartes);
        }

        if (i == 37)
        {
            PlayerPrefs.SetInt("Cartes37", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level37", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro37", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes37", bibliothèques[i].raretéCartes);
        }

        if (i == 38)
        {
            PlayerPrefs.SetInt("Cartes38", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level38", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro38", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes38", bibliothèques[i].raretéCartes);
        }

        if (i == 39)
        {
            PlayerPrefs.SetInt("Cartes39", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level39", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro39", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes39", bibliothèques[i].raretéCartes);
        }

        if (i == 40)
        {
            PlayerPrefs.SetInt("Cartes40", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level40", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro40", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes40", bibliothèques[i].raretéCartes);
        }

        if (i == 41)
        {
            PlayerPrefs.SetInt("Cartes41", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level41", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro41", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes41", bibliothèques[i].raretéCartes);
        }

        if (i == 42)
        {
            PlayerPrefs.SetInt("Cartes42", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level42", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro42", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes42", bibliothèques[i].raretéCartes);
        }

        if (i == 43)
        {
            PlayerPrefs.SetInt("Cartes43", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level43", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro43", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes43", bibliothèques[i].raretéCartes);
        }

        if (i == 44)
        {
            PlayerPrefs.SetInt("Cartes44", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level44", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro44", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes44", bibliothèques[i].raretéCartes);
        }

        if (i == 45)
        {
            PlayerPrefs.SetInt("Cartes45", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level45", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro45", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes45", bibliothèques[i].raretéCartes);
        }

        if (i == 46)
        {
            PlayerPrefs.SetInt("Cartes46", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level46", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro46", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes46", bibliothèques[i].raretéCartes);
        }

        if (i == 47)
        {
            PlayerPrefs.SetInt("Cartes47", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level47", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro47", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes47", bibliothèques[i].raretéCartes);
        }

        if (i == 48)
        {
            PlayerPrefs.SetInt("Cartes48", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level48", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro48", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes48", bibliothèques[i].raretéCartes);
        }

        if (i == 49)
        {
            PlayerPrefs.SetInt("Cartes49", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level49", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro49", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes49", bibliothèques[i].raretéCartes);
        }

        if (i == 50)
        {
            PlayerPrefs.SetInt("Cartes50", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level50", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro50", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes50", bibliothèques[i].raretéCartes);
        }

        if (i == 51)
        {
            PlayerPrefs.SetInt("Cartes51", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level51", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro51", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes51", bibliothèques[i].raretéCartes);
        }

        if (i == 52)
        {
            PlayerPrefs.SetInt("Cartes52", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level52", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro52", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes52", bibliothèques[i].raretéCartes);
        }

        if (i == 53)
        {
            PlayerPrefs.SetInt("Cartes53", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level53", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro53", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes53", bibliothèques[i].raretéCartes);
        }

        if (i == 54)
        {
            PlayerPrefs.SetInt("Cartes54", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level54", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro54", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes54", bibliothèques[i].raretéCartes);
        }

        if (i == 55)
        {
            PlayerPrefs.SetInt("Cartes55", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level55", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro55", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes55", bibliothèques[i].raretéCartes);
        }

        if (i == 56)
        {
            PlayerPrefs.SetInt("Cartes56", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level56", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro56", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes56", bibliothèques[i].raretéCartes);
        }

        if (i == 57)
        {
            PlayerPrefs.SetInt("Cartes57", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level57", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro57", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes57", bibliothèques[i].raretéCartes);
        }

        if (i == 58)
        {
            PlayerPrefs.SetInt("Cartes58", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level58", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro58", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes58", bibliothèques[i].raretéCartes);
        }

        if (i == 59)
        {
            PlayerPrefs.SetInt("Cartes59", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level59", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro59", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes59", bibliothèques[i].raretéCartes);
        }

        if (i == 60)
        {
            PlayerPrefs.SetInt("Cartes60", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level60", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro60", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes60", bibliothèques[i].raretéCartes);
        }

        if (i == 61)
        {
            PlayerPrefs.SetInt("Cartes61", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level61", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro61", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes61", bibliothèques[i].raretéCartes);
        }

        if (i == 62)
        {
            PlayerPrefs.SetInt("Cartes62", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level62", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro62", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes62", bibliothèques[i].raretéCartes);
        }

        if (i == 63)
        {
            PlayerPrefs.SetInt("Cartes63", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level63", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro63", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes63", bibliothèques[i].raretéCartes);
        }

        if (i == 64)
        {
            PlayerPrefs.SetInt("Cartes64", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level64", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro64", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes64", bibliothèques[i].raretéCartes);
        }

        if (i == 65)
        {
            PlayerPrefs.SetInt("Cartes65", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level65", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro65", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes65", bibliothèques[i].raretéCartes);
        }

        if (i == 66)
        {
            PlayerPrefs.SetInt("Cartes66", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level66", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro66", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes66", bibliothèques[i].raretéCartes);
        }

        if (i == 67)
        {
            PlayerPrefs.SetInt("Cartes67", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level67", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro67", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes67", bibliothèques[i].raretéCartes);
        }

        if (i == 68)
        {
            PlayerPrefs.SetInt("Cartes68", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level68", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro68", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes68", bibliothèques[i].raretéCartes);
        }

        if (i == 69)
        {
            PlayerPrefs.SetInt("Cartes69", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level69", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro69", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes69", bibliothèques[i].raretéCartes);
        }

        if (i == 70)
        {
            PlayerPrefs.SetInt("Cartes70", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level70", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro70", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes70", bibliothèques[i].raretéCartes);
        }

        if (i == 71)
        {
            PlayerPrefs.SetInt("Cartes71", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level71", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro71", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes71", bibliothèques[i].raretéCartes);
        }

        if (i == 72)
        {
            PlayerPrefs.SetInt("Cartes72", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level72", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro72", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes72", bibliothèques[i].raretéCartes);
        }

        if (i == 73)
        {
            PlayerPrefs.SetInt("Cartes73", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level73", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro73", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes73", bibliothèques[i].raretéCartes);
        }

        if (i == 74)
        {
            PlayerPrefs.SetInt("Cartes74", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level74", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro74", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes74", bibliothèques[i].raretéCartes);
        }

        if (i == 75)
        {
            PlayerPrefs.SetInt("Cartes75", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level75", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro75", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes75", bibliothèques[i].raretéCartes);
        }

        if (i == 76)
        {
            PlayerPrefs.SetInt("Cartes76", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level76", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro76", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes76", bibliothèques[i].raretéCartes);
        }

        if (i == 77)
        {
            PlayerPrefs.SetInt("Cartes77", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level77", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro77", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes77", bibliothèques[i].raretéCartes);
        }

        if (i == 78)
        {
            PlayerPrefs.SetInt("Cartes78", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level78", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro78", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes78", bibliothèques[i].raretéCartes);
        }

        if (i == 79)
        {
            PlayerPrefs.SetInt("Cartes79", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level79", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro79", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes79", bibliothèques[i].raretéCartes);
        }

        if (i == 80)
        {
            PlayerPrefs.SetInt("Cartes80", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level80", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro80", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes80", bibliothèques[i].raretéCartes);
        }

        if (i == 81)
        {
            PlayerPrefs.SetInt("Cartes81", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level81", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro81", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes81", bibliothèques[i].raretéCartes);
        }

        if (i == 82)
        {
            PlayerPrefs.SetInt("Cartes82", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level82", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro82", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes82", bibliothèques[i].raretéCartes);
        }

        if (i == 83)
        {
            PlayerPrefs.SetInt("Cartes83", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level83", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro83", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes83", bibliothèques[i].raretéCartes);
        }

        if (i == 84)
        {
            PlayerPrefs.SetInt("Cartes84", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level84", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro84", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes84", bibliothèques[i].raretéCartes);
        }

        if (i == 85)
        {
            PlayerPrefs.SetInt("Cartes85", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level85", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro85", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes85", bibliothèques[i].raretéCartes);
        }

        if (i == 86)
        {
            PlayerPrefs.SetInt("Cartes86", bibliothèques[i].cartes);
            PlayerPrefs.SetInt("Level86", bibliothèques[i].level);
            PlayerPrefs.SetInt("Numéro86", bibliothèques[i].numéros);
            PlayerPrefs.SetString("RaretéCartes86", bibliothèques[i].raretéCartes);
        }
    }
}

[System.Serializable]
public struct Bibliothèques
{ 
    public GameObject emplacementCartes;
    public string raretéCartes;
    public int cartes;
    public int level;
    public int numéros;
}