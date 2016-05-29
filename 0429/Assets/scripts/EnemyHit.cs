using UnityEngine;
using System.Collections;

public class EnemyHit : MonoBehaviour {

    public ParticleSystem explosion;

	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Bullet"){
            Destroy(gameObject);
            Destroy(col.gameObject); //bullet
            Instantiate(explosion, transform.position, Quaternion.identity);
            ScoreManager.CurrentScore++;
       }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
