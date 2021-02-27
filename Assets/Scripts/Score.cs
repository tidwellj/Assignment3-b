using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
//using System.Collections.Generic.List;
public class Score : MonoBehaviour
{
	public static ArrayList a1 = new ArrayList();
  // ArrayList<int> a1 = new ArrayList<int>();
	
	public static int CurrentScore = SaveJson.expo3;
	public static int oldscore = 0;
	public static int newscore = 0;
	public static int highest = 0;
	public Text scoreText;

	void awake()
    {

	}

	void Start()
	{

		if (CurrentScore == 0)
		{
			SaveJson.expo3 = 0;
			int scoreit = SaveJson.expo3 = 0;
			scoreText.text = CurrentScore.ToString();
			a1.Add(scoreit);
		}
		else if (CurrentScore !=0)
		{
			newscore = CurrentScore + SaveJson.expo3;
			scoreText.text = newscore.ToString();
			a1.Add(newscore);
			
		}
		
		



	}
	public void Update()
    {
		a1.Sort();
		a1.Reverse();

		Debug.Log(a1[0]);
	}


}