using UnityEngine;
using System.Collections;

public class sound1dest : MonoBehaviour {
    public GameObject sound;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1"))
        {

            Instantiate(sound, transform.position, transform.rotation);
            

        }
        
	}
}
