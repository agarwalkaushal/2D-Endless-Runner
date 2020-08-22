using UnityEngine;

public class SpawnVehicles : MonoBehaviour
{
    public Sprite[] vehicleSprites;
    public GameObject vehiclePrefab;

    float spawnTime = 0f;
    float spawnDelay = 1f;
    int speed = -10;
    
    void Start()
    {
        InvokeRepeating("spawnVehicle", spawnTime, spawnDelay);
    }

    void spawnVehicle()
    {
        int i = Random.Range(0, vehicleSprites.Length);
        int pos = Random.Range(0, 2);
        Quaternion rotation = Quaternion.Euler(180, 0, 0);

        GameObject vehicle = Instantiate(vehiclePrefab, new Vector3(pos == 0 ? -1.5f : 1.5f, 14f, 0), rotation);

        SpriteRenderer img = vehicle.GetComponent<SpriteRenderer>();
        img.sprite = vehicleSprites[i];

        Rigidbody2D rb = vehicle.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0.0f, speed);
    }
}

