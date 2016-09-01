using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float slowness = 10f;
    private GameManager()
    {
        instance = this;
    }
    public static GameManager Get_GameManager()
    {
        return instance;
    }
    public void EndGame()
    {
        StartCoroutine(RestartLevel());
    }
    IEnumerator RestartLevel()
    {
        //////before 1 sec//////

        ///The scale at which the time is passing.
        /// This can be used for slow motion effects.
        // Time.timeScale = 1;  //Regular Time
        // Time.timeScale = 2;  //twice quickly
        // Time.timeScale = 0;  //Time isn't moving 

        //Slow-down the time and the time between the frames
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        //To keep on the new time measure
        //And make sure we wait exactly the specific time 
        //		(reqardless to the new time measure)
        yield return new WaitForSeconds(1f / slowness);

        //////after 1 sec//////

        //return time movement to Normal!!
        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;



        //Alternative: SceneManager.LoadScene(0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
