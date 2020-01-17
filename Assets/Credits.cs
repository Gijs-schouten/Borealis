using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour {
	private bool crawling = true;

	private float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (!crawling) return;

		transform.Translate(Vector3.up * Time.deltaTime * speed);
		if (gameObject.transform.position.y > 0) {
			crawling = false;
		}
	}
}
