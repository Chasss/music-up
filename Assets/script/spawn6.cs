using UnityEngine;
using System.Collections;

public class spawn6 : MonoBehaviour {

    public GameObject []bullet;
    public float time1,endtime;
    private float x = 0;
    private int count = 0;
    

	void FixedUpdate () {
        if (GameController._instance.framecount == time1&& GameController._instance.framecount<endtime)
        {
            fire(x);
            if (count <= 1)
            {
                time1 += 15;
                count++;
            }
            else if (count == 2)
            {
                time1 += 95;
                count = 0;
            }

            if (x==0)
            {
                x += 5f;
            }
            else x = 0;
        }

    }

    void fire(float x)
    {
        if (x==0) fire1();
        else fire2();
    }
    void fire1()
    {
        float y = Random.Range(-3.5f, 3.5f);
        GameObject.Instantiate(bullet[0], new Vector3(transform.position.x+x, y, 0), Quaternion.identity);
        GameObject.Instantiate(bullet[1], new Vector3(transform.position.x+x, y, 0), Quaternion.identity);
        GameObject.Instantiate(bullet[2], new Vector3(transform.position.x+x, y, 0), Quaternion.identity);
    }
    void fire2()
    {
        float y = Random.Range(-3.5f, 3.5f);
        GameObject.Instantiate(bullet[3], new Vector3(transform.position.x+x, y, 0), Quaternion.identity);
        GameObject.Instantiate(bullet[4], new Vector3(transform.position.x+x, y, 0), Quaternion.identity);
        GameObject.Instantiate(bullet[5], new Vector3(transform.position.x+x, y, 0), Quaternion.identity);
    }
}
