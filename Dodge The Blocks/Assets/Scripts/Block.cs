using UnityEngine;
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
            //Get GameManager and Increase score
            var _Manager = GameManager.Get_GameManager();
            _Manager.IncreaseScore();
            Destroy(gameObject);
        }
    }
}
