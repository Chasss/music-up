using UnityEngine;
using System.Collections;

public class spawn1 : MonoBehaviour {

    public float framecount = 0;

    public GameObject bullet1;
    public GameObject bullet2;
    public GameObject bullet3;
    public GameObject bullet4;
	
	// Update is called once per frame
	void FixedUpdate () {
        if (!GameController._instance.isGamePause)
        {
            if (GameController._instance.framecount < 2383 || GameController._instance.framecount > 2465 && GameController._instance.framecount <4450)
            {
                if (GameController._instance.framecount > 220)
                {
                    framecount++;
                    if (framecount == 62)
                    {
                        fire();
                        framecount = 0;
                    }
                }
            }
            else framecount = 0;
        }

	
	}

    public void fire()
    {
        float x = Random.Range(-2f, 2f);
        float y = Random.Range(-3.5f, 3.5f);

        GameObject.Instantiate(bullet1, new Vector3(x, y, 0), Quaternion.identity);
        GameObject.Instantiate(bullet2, new Vector3(x, y, 0), Quaternion.identity);
        GameObject.Instantiate(bullet3, new Vector3(x, y, 0), Quaternion.identity);
        GameObject.Instantiate(bullet4, new Vector3(x, y, 0), Quaternion.identity);
    }
}
