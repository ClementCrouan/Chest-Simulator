using UnityEngine;

public class LevelUp : MonoBehaviour
{
    Vector2 startPoint, endPoint;
    Vector3 positionDépart, positionFin;
    bool touchStart = false;
    public Transform player;
    public float speed;

    public void Start()
    {
        positionDépart = player.position;
        positionFin = new Vector3(360, 4640, 0);
    }

    private void OnMouseDown()
    {
        startPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDrag()
    {
        touchStart = true;
        endPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseUp()
    {
        touchStart = false;
    }

    private void Update()
    {
        if (player.position.y < positionDépart.y)
        {
            player.position = positionDépart;
        }

        if (player.position.y > positionFin.y)
        {
            player.position = positionFin;
        }

        if (touchStart)
        {
            Vector2 offset = endPoint - startPoint;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1f);
            direction = new Vector2(0, direction.y);
            MovePlayer(direction);
        }
    }

    void MovePlayer(Vector2 dir)
    {
        player.Translate(dir * Time.deltaTime * speed);
    }
}
