using UnityEngine;
using System.Collections;

public class spawn2 : MonoBehaviour {

    public GameObject bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (GameController._instance.framecount > 670 && GameController._instance.framecount < 929 && transform.position.x < 2.4f)
        {
            fire();
            transform.Translate(Vector3.right * Time.deltaTime * 25);
        }
        if (GameController._instance.framecount > 929 && GameController._instance.framecount < 1192 && transform.position.x > -2.4f)
        {
            fire();
            transform.Translate(Vector3.left * Time.deltaTime * 25);
        }
        if (GameController._instance.framecount > 1192 && transform.position.x < 2.4f)
        {
            fire();
            fire2();
            transform.Translate(new Vector3(1,0.5f,0) * Time.deltaTime * 30);
        }
	}

    public void fire()
    {
        GameObject.Instantiate(bullet, transform.position, Quaternion.identity);
    }

    public void fire2()
    {
        GameObject.Instantiate(bullet, new Vector3(-transform.position.x, transform.position.y, 0), Quaternion.identity);
    }
}
