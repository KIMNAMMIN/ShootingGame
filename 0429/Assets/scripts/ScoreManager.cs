using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {
    public static int CurrentScore = 0;
    public Rect ScorePosition;
  
    
	// Use this for initialization
	void Start () {
        ScorePosition = new Rect(Screen.width - 110, 10, 100, 30);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        GUI.Label(ScorePosition, "명중:" + CurrentScore.ToString());
    }
}
