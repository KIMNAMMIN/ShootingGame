using UnityEngine;
using System.Collections;

public class TimeManager : MonoBehaviour {
    float timeLeft = 30;
    public Rect TimePosition;
    public Rect EndPosition;
    public Rect ScorePosition;
    public Rect rPosition;

    public GameObject Gun;
    public GameObject teddy;

    public static bool restart;
    
    
	// Use this for initialization
	void Start () {
        restart = false;
        TimePosition = new Rect(Screen.width - 110, 25, 130, 30); //x, y, z ?
        EndPosition = new Rect(Screen.width - 300, 45, 130, 30);
        ScorePosition = new Rect(Screen.width - 600, 120, 130, 30);
        rPosition = new Rect(Screen.width - 600, 220, 130, 30);

        
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 0;
            Destroy(Gun);
            Destroy(teddy);
            restart = true;
            
        }
        if (restart == true)
        {
            if(Input.GetKeyDown(KeyCode.R)==true)
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
	}
    void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 50;
        if (timeLeft==0) GUI.Label(EndPosition, "GAME OVER",myStyle);
        if (timeLeft==0) GUI.Label(ScorePosition, "그대 점수는" + ScoreManager.CurrentScore.ToString()+"점ㅋ", myStyle);
        if (timeLeft == 0) GUI.Label(rPosition, "다시 할려면 r 눌러요" , myStyle);
        GUI.Label(TimePosition, "남은시간:" + timeLeft.ToString());
    }
}
