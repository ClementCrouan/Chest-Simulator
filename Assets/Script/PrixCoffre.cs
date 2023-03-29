using UnityEngine;

public class PrixCoffre : MonoBehaviour
{
    public RessourceArchieve ressourceArchieve;
    public bool open;
    public GameObject gems4900;
    public GameObject gems900;
    public GameObject gems500;
    public GameObject golds10000;
    public GameObject gems501;

    // Update is called once per frame
    void Update()
    {
        if (ressourceArchieve.gems >= 4900)
        {
            gems4900.SetActive(true);
            open = true;
        }
        else
        {
            gems4900.SetActive(false);
            open = false;
        }

        if (ressourceArchieve.gems >= 900)
        {
            gems900.SetActive(true);
            open = true;
        }
        else
        {
            gems900.SetActive(false);
            open = false;
        }

        if (ressourceArchieve.gems >= 500)
        {
            gems500.SetActive(true);
            gems501.SetActive(true);
            open = true;
        }
        else
        {
            gems500.SetActive(false);
            gems501.SetActive(false);
            open = false;
        }

        if (ressourceArchieve.golds >= 10000)
        {
            golds10000.SetActive(true);
            open = true;
        }
        else
        {
            golds10000.SetActive(false);
            open = false;
        }
    }
}
