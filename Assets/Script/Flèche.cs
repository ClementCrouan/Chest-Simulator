using UnityEngine;

public class Flèche : MonoBehaviour
{
    public Flèche flèche;
    public int numéro;
    public GameObject coffreGratuit;
    public GameObject coffreArgent;
    public GameObject coffreOr;
    public GameObject coffreCouronne;
    public GameObject coffreGeant;
    public GameObject coffreMagique;
    public GameObject coffreSuperMagique;
    public GameObject coffreEpique;
    public GameObject coffreLegendaire;
    public GameObject flècheFin;

    public int numeroDeCoffre;
    private int numéroFlèche;

    // Start is called before the first frame update
    void Start()
    {
        numéroFlèche = numéro;
    }

    // Update is called once per frame
    void Update()
    {
        if(numeroDeCoffre == 0)
        {
            coffreGratuit.SetActive(true);
            coffreArgent.SetActive(false);
            coffreOr.SetActive(false);
            coffreCouronne.SetActive(false);
            coffreGeant.SetActive(false);
            coffreMagique.SetActive(false);
            coffreSuperMagique.SetActive(false);
            coffreEpique.SetActive(false);
            coffreLegendaire.SetActive(false);
            if(numéro == 0 && numéroFlèche == 0)
            {
                flècheFin.SetActive(true);
            }
        }

        if(numeroDeCoffre == 1)
        {
            coffreGratuit.SetActive(false);
            coffreArgent.SetActive(true);
            coffreOr.SetActive(false);
            coffreCouronne.SetActive(false);
            coffreGeant.SetActive(false);
            coffreMagique.SetActive(false);
            coffreSuperMagique.SetActive(false);
            coffreEpique.SetActive(false);
            coffreLegendaire.SetActive(false);
            flècheFin.SetActive(false);
        }

        if(numeroDeCoffre == 2)
        {
            coffreGratuit.SetActive(false);
            coffreArgent.SetActive(false);
            coffreOr.SetActive(true);
            coffreCouronne.SetActive(false);
            coffreGeant.SetActive(false);
            coffreMagique.SetActive(false);
            coffreSuperMagique.SetActive(false);
            coffreEpique.SetActive(false);
            coffreLegendaire.SetActive(false);
            flècheFin.SetActive(false);
        }

        if(numeroDeCoffre == 3)
        {
            coffreGratuit.SetActive(false);
            coffreArgent.SetActive(false);
            coffreOr.SetActive(false);
            coffreCouronne.SetActive(true);
            coffreGeant.SetActive(false);
            coffreMagique.SetActive(false);
            coffreSuperMagique.SetActive(false);
            coffreEpique.SetActive(false);
            coffreLegendaire.SetActive(false);
            flècheFin.SetActive(false);
        }

        if(numeroDeCoffre == 4)
        {
            coffreGratuit.SetActive(false);
            coffreArgent.SetActive(false);
            coffreOr.SetActive(false);
            coffreCouronne.SetActive(false);
            coffreGeant.SetActive(true);
            coffreMagique.SetActive(false);
            coffreSuperMagique.SetActive(false);
            coffreEpique.SetActive(false);
            coffreLegendaire.SetActive(false);
            flècheFin.SetActive(false);
        }

        if(numeroDeCoffre == 5)
        {
            coffreGratuit.SetActive(false);
            coffreArgent.SetActive(false);
            coffreOr.SetActive(false);
            coffreCouronne.SetActive(false);
            coffreGeant.SetActive(false);
            coffreMagique.SetActive(true);
            coffreSuperMagique.SetActive(false);
            coffreEpique.SetActive(false);
            coffreLegendaire.SetActive(false);
            flècheFin.SetActive(false);
        }

        if(numeroDeCoffre == 6)
        {
            coffreGratuit.SetActive(false);
            coffreArgent.SetActive(false);
            coffreOr.SetActive(false);
            coffreCouronne.SetActive(false);
            coffreGeant.SetActive(false);
            coffreMagique.SetActive(false);
            coffreSuperMagique.SetActive(true);
            coffreEpique.SetActive(false);
            coffreLegendaire.SetActive(false);
            flècheFin.SetActive(false);
        }

        if(numeroDeCoffre == 7)
        {
            coffreGratuit.SetActive(false);
            coffreArgent.SetActive(false);
            coffreOr.SetActive(false);
            coffreCouronne.SetActive(false);
            coffreGeant.SetActive(false);
            coffreMagique.SetActive(false);
            coffreSuperMagique.SetActive(false);
            coffreEpique.SetActive(true);
            coffreLegendaire.SetActive(false);
            flècheFin.SetActive(false);
        }

        if(numeroDeCoffre == 8)
        {
            coffreGratuit.SetActive(false);
            coffreArgent.SetActive(false);
            coffreOr.SetActive(false);
            coffreCouronne.SetActive(false);
            coffreGeant.SetActive(false);
            coffreGeant.SetActive(false);
            coffreMagique.SetActive(false);
            coffreSuperMagique.SetActive(false);
            coffreEpique.SetActive(false);
            coffreLegendaire.SetActive(true);
            if(numéro == 1 && numéroFlèche == 1)
            {
                flècheFin.SetActive(true);
            }
        }
    }

    public void Turn()
    {
        if (numéro == 0)
        {
            numeroDeCoffre -= 1;
            flèche.numeroDeCoffre -= 1;
            numéroFlèche = 0;
        }

        if (numéro == 1)
        {
            numeroDeCoffre += 1;
            flèche.numeroDeCoffre += 1;
            numéroFlèche = 1;
        }
    }
}
