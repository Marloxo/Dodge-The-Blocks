using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float speed = 15f;
	public float mapWidth =5f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        //work cross-platform
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        rb.MovePosition(rb.position + Vector2.right * x);
    }
}
