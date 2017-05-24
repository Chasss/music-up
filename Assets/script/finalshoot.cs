using UnityEngine;
using System.Collections;

public class finalshoot : MonoBehaviour {

    public GameObject bullet;
    public float speed;
    public float bulletrate = 0.3f;
    public float starttime, endtime;

    private void Start()
    {
        this.transform.eulerAngles = new Vector3(0, 0, -135);
    }
    void FixedUpdate () {

        if (GameController._instance.framecount >= starttime && GameController._instance.framecount <= endtime)
        {
            this.transform.eulerAngles += new Vector3(0, 0, 1);
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (GameController._instance.framecount == starttime) startfire();
            if (GameController._instance.framecount == endtime) stopfire();

        }

    }

    public void fire()
    {
        GameObject.Instantiate(bullet, transform.position, Quaternion.identity);
    }
    public void startfire()
    {
        InvokeRepeating("fire", 0, bulletrate);
    }
    public void stopfire()
    {
        CancelInvoke("fire");
    }
}
