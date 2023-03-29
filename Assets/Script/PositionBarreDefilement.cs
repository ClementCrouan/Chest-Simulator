using UnityEngine;

public class PositionBarreDefilement : MonoBehaviour
{

    public RectTransform barreDefilement;
    public RectTransform iconChest;
    public RectTransform iconCards;
    public RectTransform iconShop;

    public void IconChest()
    { 
        barreDefilement.position = new Vector2(iconChest.position.x, iconChest.position.y);
    }

    public void IconShop()
    {
        barreDefilement.position = new Vector2(iconShop.position.x, iconShop.position.y);
    }

    public void IconCards()
    {
        barreDefilement.position = new Vector2(iconCards.position.x, iconCards.position.y);
    }
}
