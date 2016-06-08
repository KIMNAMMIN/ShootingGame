using UnityEngine;
using System.Collections;

public class DestroyParticle : MonoBehaviour {

    ParticleSystem ps;
	// Use this for initialization
	void Start () {

        ps = GetComponent<ParticleSystem>();

	}
	
	// Update is called once per frame
	void Update () {

        if (ps.IsAlive() == false)//파티클 연산이 끝난 상태
        {
            Destroy(gameObject);
        }

	}
}
