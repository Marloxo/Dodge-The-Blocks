using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float speed = 15f;
    public float mapWidth = 5f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    ///
    //used for physic primary because it's update on fixed time  
    ///
    void FixedUpdate()
    {
        //work cross-platform
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        Vector2 newPosition = rb.position + Vector2.right * x;

        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);
        rb.MovePosition(newPosition);
    }
}
