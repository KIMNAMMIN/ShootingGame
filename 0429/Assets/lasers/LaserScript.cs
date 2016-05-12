using UnityEngine;
using System.Collections;

public class LaserScript : MonoBehaviour {

    LineRenderer line;
	// Use this for initialization
	void Start () {

        line = gameObject.GetComponent<LineRenderer>();
        line.enabled = false;

       // Screen.lockCursor = true;



	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1"))
        {
            StopCoroutine("FireLaser");
            StartCoroutine("FireLaser");
        }

	}

    IEnumerator FireLaser() //
    {
        line.enabled = true;
        while (Input.GetButton("Fire1")) //눌러져 있는 동안
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            line.SetPosition(0, ray.origin); // 레이저의 시작점 설정

            if (Physics.Raycast(ray, out hit, 100)) //어떠한 물체에 부딪힌다면
            { 
                line.SetPosition(1, hit.point); //그곳이 끝 점이 된다.
                if (hit.rigidbody)//rigidbody에 부딪힌다면 그곳에 힘을 가한다.
                {
                    hit.rigidbody.AddForceAtPosition(transform.forward * 20, hit.point);
                }
            }
            else
                line.SetPosition(1,ray.GetPoint(100));

            yield return null; //keep looping
        }

        line.enabled = false;
    }
}
