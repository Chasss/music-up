using UnityEngine;
using System.Collections;

public class spawn5 : MonoBehaviour {

    public GameObject[] bullet;

    public float x=0;


	
	// Update is called once per frame
	void Update () {

        if(GameController._instance.framecount == 2913)
        {
            x = transform.position.x;
            fire();
        }
        else if(GameController._instance.framecount == 2931)
        {
            x+=1.5f;
            fire();
        }
        else if (GameController._instance.framecount == 2949)
        {
            x += 1.5f;
            fire();
        }
	
	}


    void fire()
    {
        GameObject.Instantiate(bullet[0], new Vector3(x, transform.position.y, 0), Quaternion.identity);
        GameObject.Instantiate(bullet[1], new Vector3(x, transform.position.y, 0), Quaternion.identity);
        GameObject.Instantiate(bullet[2], new Vector3(x, transform.position.y, 0), Quaternion.identity);
        GameObject.Instantiate(bullet[3], new Vector3(x, transform.position.y, 0), Quaternion.identity);
        GameObject.Instantiate(bullet[4], new Vector3(x, transform.position.y, 0), Quaternion.identity);
        GameObject.Instantiate(bullet[5], new Vector3(x, transform.position.y, 0), Quaternion.identity);
        GameObject.Instantiate(bullet[6], new Vector3(x, transform.position.y, 0), Quaternion.identity);
        GameObject.Instantiate(bullet[7], new Vector3(x, transform.position.y, 0), Quaternion.identity);

    }
}
