using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text score;

    // Update is called once per frame
    void Update()
    {
        //Score divided by the number of block par line
        score.text = "Score: " + (GameManager.score / 4).ToString();
    }
}
