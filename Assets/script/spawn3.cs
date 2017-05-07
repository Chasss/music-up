using UnityEngine;
using System.Collections;

public class spawn3 : MonoBehaviour {

    public GameObject bullet;
    public GameObject bullet2;

    public int startframe = 1509;
    public int endframe = 1760;

    public int startframe1 = 2008;
    public int endframe1 = 2260;


    public float bulletrate = 0.3f;
    public float bullet2rate = 0.3f;

	// Update is called once per frame
	void Update () {
        if (GameController._instance.framecount == startframe)
        {
            startfire();
        }
        if (GameController._instance.framecount == endframe)
        {
            stopfire();
        }
        if (GameController._instance.framecount == startframe1)
        {
            startfire2();
        }
        if (GameController._instance.framecount == endframe1)
        {
            stopfire2();
        }
        if (GameController._instance.framecount == 2460 || GameController._instance.framecount == 2476 || GameController._instance.framecount == 2492)
        {
            fire();
            fire2();
        }
	}
    
    public void fire()
    {
          GameObject.Instantiate(bullet, transform.position, Quaternion.identity);
    }
    public void fire2()
    {
        GameObject.Instantiate(bullet2, new Vector3 (-transform.position.x,transform.position.y,0), Quaternion.identity);
    }

    public void startfire()
    {
        InvokeRepeating("fire", 0, bulletrate);
    }

    public void stopfire()
    {
        CancelInvoke("fire");
    }

    public void startfire2()
    {
        InvokeRepeating("fire2", 0, bullet2rate);
    }

    public void stopfire2()
    {
        CancelInvoke("fire2");
    }
}
