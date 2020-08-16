using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float dir;
    int speed = 3;
    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)) dir = 1;
        if (Input.GetKeyDown(KeyCode.A)) dir = -1;
        rb2d.velocity = new Vector2(dir * speed, 0);
    }
}
