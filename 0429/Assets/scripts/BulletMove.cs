using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {
    public float moveSpeed = 10f;
    public float destroyTime = 2f;
	// Use this for initialization
	void Start () {

        Destroy(gameObject, 5f);

	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(0, 0, moveSpeed * Time.deltaTime);

	}
}
