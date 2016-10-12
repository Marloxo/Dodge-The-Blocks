using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{ //Singleton Object
    public static GameManager instance;
    public GameObject RestartButton;
    public float slowness = 10f;
    public static int score = 0;
    public void IncreaseScore() { score++; }
    public void ResetScore() { score = 0; }

    private GameManager() { instance = this; }
    public static GameManager Get_GameManager() { return instance; }
    public void EndGame()
    {
        StartCoroutine(EndLevel());
    }
    IEnumerator EndLevel()
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

        //Stop the Game
        RestartButton.SetActive(true);
        Time.timeScale = 0;
    }
    public void RestartLevel()
    {
        //Alternative: SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        ResetScore();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
