using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour
{
    public float gravityScaleFactor = 20f;
    void Start()
    {
        //Increase the speed of gravity by time
        // divided by "gravityScaleFactor" to decrease the speed of change
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / gravityScaleFactor;
    }
    void Update()
    {
        if (transform.position.y < -2f)
        {
            Destroy(gameObject);
        }
    }
}
