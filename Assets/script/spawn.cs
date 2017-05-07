using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour
{

    public GameObject bullet;
    private int framecount = 0;

    private float x;

    void FixedUpdate()
    {
        if (!GameController._instance.isGamePause)
        {
                framecount += 1;
            if (GameController._instance.framecount < 2386 || GameController._instance.framecount > 2500 && GameController._instance.framecount <4450)
            {
                if (framecount == 60)
                {
                    framecount = 0;
                }
                else if (framecount == 52)
                {
                    x += 1.5f;
                    fire();
                }
                else if (framecount == 27)
                {
                    x += 1.5f;
                    fire();
                }
                else if (framecount == 6)
                {

                    x = transform.position.x;
                    fire();
                }
            }
            else
            {
                framecount = 0;
            }
        }


    }

    public void fire()
    {
        GameObject.Instantiate(bullet, new Vector3(x, transform.position.y, 0), Quaternion.identity);
    }
}