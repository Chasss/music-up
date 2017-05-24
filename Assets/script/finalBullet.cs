using UnityEngine;
using System.Collections;

public class finalBullet : MonoBehaviour {

    public GameObject player,bullet;
    public float shootTime,starttime,endtime;
    private bool isgetposition = false;
    private Vector3 playerPosition,startposition;
    private Vector3 speed;
    public float bulletrate = 5;

    private void Start()
    {
        player = GameObject.Find("player");
        startposition = transform.position;
        starttime = GameController._instance.framecount;
    }
    void FixedUpdate () {

        if (GameController._instance.framecount >=shootTime)
        {
            if (!isgetposition)
            {
                playerPosition = player.transform.position;
                speed = (playerPosition - this.transform.position) / 50;
                isgetposition = true;
            }
            transform.Translate(speed);
        }
        if((GameController._instance.framecount == shootTime+ bulletrate || GameController._instance.framecount==starttime+ bulletrate) && GameController._instance.framecount <= endtime)
        {
            fire();
        }
        if (transform.position.x > 2.92f||transform.position.x < -2.92f|| transform.position.y > 4.25f|| transform.position.y < -4.25f)
        {
            Destroy(this.gameObject);
        }

    }
    public void fire()
    {
        GameObject.Instantiate(bullet, startposition, Quaternion.identity);
    }
}
