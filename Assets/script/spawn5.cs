using UnityEngine;
using System.Collections;

public class spawn5 : MonoBehaviour {

    public GameObject bullet;
    public float angle = 0;
    private float framcount = 9;
    public float x=0;



    // Update is called once per frame
    void Update () {

        if(GameController._instance.framecount >=3510&& GameController._instance.framecount <=3700)
        {
            framcount++;
            if(framcount == 15)
            {
                fire(angle);
                angle -= 15;
                framcount = 0;
            }
        }
	
	}


    void fire(float angle)
    {
        this.transform.eulerAngles = new Vector3(0, 0, angle);
        GameObject.Instantiate(bullet, transform.position, transform.rotation);

    }
}
