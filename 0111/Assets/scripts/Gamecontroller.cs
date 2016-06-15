using UnityEngine;
using System.Collections;

public class Gamecontroller : MonoBehaviour {

    public GameObject hazard;
    public float startWait= 1; //소소한 기능. inspect 창에 띄울 수 있다.
    public float spawnWait = 0.75f;
    public float waveWait = 2;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnWaves());
        Destroy(gameObject, 30f);
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);

        while (true) { 
            for (int i = 0; i < 10; i++) { 
               
                Vector3 SpawnPosition = new Vector3(Random.Range(-70,120), Random.Range(0,10), Random.Range(-20,170)); //어디에 리젠 시킬지.
                Quaternion SpawnRotation = Quaternion.Euler(new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360))); //회전함수
                Instantiate(hazard, SpawnPosition, SpawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                // 할꺼 하셈
                 Application.Quit();
            }
        }
    }
}
