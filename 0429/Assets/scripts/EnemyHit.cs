using UnityEngine;
using System.Collections;

public class EnemyHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Bullet"){
            Destroy(gameObject);
            Destroy(col.gameObject); //bullet
        }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
