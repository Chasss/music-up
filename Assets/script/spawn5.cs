using UnityEngine;
using System.Collections;

public class spawn5 : MonoBehaviour {

    public GameObject bullet;
    public float angle = 0;
    private float framcount;
    public float []start_shoottime;
    public int shootspeed = 5;



    void Start()
    {
        framcount = shootspeed - 1;
    }
    // Update is called once per frame
    void Update () {

        if(GameController._instance.framecount >= start_shoottime[0] && GameController._instance.framecount <= start_shoottime[0]+100|| GameController._instance.framecount >= start_shoottime[1] && GameController._instance.framecount <= start_shoottime[1] + 100 || GameController._instance.framecount >=start_shoottime[2] && GameController._instance.framecount <= start_shoottime[2] + 100)
        {
            if (GameController._instance.framecount == start_shoottime[1] || GameController._instance.framecount == start_shoottime[1]) framcount = shootspeed-1;
            framcount++;
            if(framcount == shootspeed)
            {
                fire(angle);
                angle -= 10;
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
