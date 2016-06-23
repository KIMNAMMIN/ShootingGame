using UnityEngine;
using System.Collections;

public class TimeManager : MonoBehaviour {
    float timeLeft = 30;
    public Rect TimePosition;
    public Rect EndPosition;
    public Rect ScorePosition;

    public GameObject Gun;
    public GameObject teddy;
    
    
    
	// Use this for initialization
	void Start () {
        TimePosition = new Rect(Screen.width - 110, 25, 130, 30);
        EndPosition = new Rect(Screen.width - 300, 45, 130, 30);
        ScorePosition = new Rect(Screen.width - 600, 120, 130, 30);

        
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 0;
            Destroy(Gun);
            Destroy(teddy);
            
        }
	}
    void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 50;
        if (timeLeft==0) GUI.Label(EndPosition, "GAME OVER",myStyle);
        if (timeLeft==0) GUI.Label(ScorePosition, "그대 점수는" + ScoreManager.CurrentScore.ToString()+"점ㅋ", myStyle);
        if (timeLeft == 0) if (GUI.Button(new Rect(Screen.width - 1200, 10, 130, 70), "다시시작"))
            {
                Application.LoadLevel(Application.loadedLevel);
                ScoreManager.CurrentScore = 0;
            }
                
            
        GUI.Label(TimePosition, "남은시간:" + timeLeft.ToString());
    }
}

