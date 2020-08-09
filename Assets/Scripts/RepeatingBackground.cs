using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    float roadVerticalLength = 10f;
    int speed = -3;
    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(0, speed);
    }

    void Update()
    {
        if (transform.position.y < -roadVerticalLength)
        {
            RepositionBackground();
        }
    }

    private void RepositionBackground()
    {
        Vector2 groundOffset = new Vector2(0, roadVerticalLength * 2f);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}

