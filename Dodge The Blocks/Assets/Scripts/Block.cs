using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < -2f)
        {
            Destroy(gameObject);
        }
    }
}
