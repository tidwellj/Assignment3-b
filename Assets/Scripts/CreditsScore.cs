
using UnityEngine;
using UnityEngine.UI;

public class CreditsScore : MonoBehaviour
{
    public Text creditScoreText;
    // Start is called before the first frame update
    void Start()
    {
        //creditScoreText.text = Score.CurrentScore.ToString();
        creditScoreText.text = Score.a1[0].ToString();
    }

    
}
