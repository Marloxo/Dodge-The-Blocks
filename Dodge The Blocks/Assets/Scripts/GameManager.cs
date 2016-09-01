using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
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
        //Alternative: SceneManager.LoadScene(0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
