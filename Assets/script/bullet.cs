using UnityEngine;
using System.Collections;

public enum bulletType
{
    up,
    down,
    left,
    right,
    leftup,
    rightup,
    leftdown,
    rightdown,
    leftaround_down,
    leftaround_up,
    rightaround_down,
    rightaround_up,
}

public class bullet : MonoBehaviour {


    public float speed = 2;
    public bulletType type;
    private float x = 1;

    // Update is called once per frame
    void Update()
    {
        if (type == bulletType.up)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (transform.position.y > 4.25f)
            {
                Destroy(this.gameObject);
            }
        }
        else if (type == bulletType.down)
        {
            this.transform.eulerAngles = new Vector3(180,0,0);
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (transform.position.y < -4.25f)
            {
                Destroy(this.gameObject);
            }
        }
        else if (type == bulletType.left)
        {
            this.transform.eulerAngles = new Vector3(0, 0, 90);
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (transform.position.x < -2.5f)
            {
                Destroy(this.gameObject);
            }
        } 
        else if (type == bulletType.right)
        {
            this.transform.eulerAngles = new Vector3(0, 0, -90);
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (transform.position.x > 2.5f)
            {
                Destroy(this.gameObject);
            }
        }

        else if(type == bulletType.leftaround_down)
        {
            transform.Translate(new Vector3(x,-1,0) * speed * Time.deltaTime);
            x -= 0.01f;
            if (transform.position.x < -2.92f)
            {
                Destroy(this.gameObject);
            }
        }
        else if (type == bulletType.leftaround_up)
        {
            transform.Translate(new Vector3(x, 1, 0) * speed * Time.deltaTime);
            x -= 0.01f;
            if (transform.position.x < -2.92f)
            {
                Destroy(this.gameObject);
            }
        }
        else if (type == bulletType.rightaround_down)
        {
            transform.Translate(new Vector3(-x, -1, 0) * speed * Time.deltaTime);
            x -= 0.01f;
            if (transform.position.x < -2.92f)
            {
                Destroy(this.gameObject);
            }
        }
        else if (type == bulletType.rightaround_up)
        {
            transform.Translate(new Vector3(-x, 1, 0) * speed * Time.deltaTime);
            x -= 0.01f;
            if (transform.position.x < -2.92f)
            {
                Destroy(this.gameObject);
            }
        }
        else if (type == bulletType.leftup)
        {
            this.transform.eulerAngles = new Vector3(0, 0, 45);
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (transform.position.x < -2.92f)
            {
                Destroy(this.gameObject);
            }
        }
        else if (type == bulletType.leftdown)
        {
            this.transform.eulerAngles = new Vector3(0, 0, 135);
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (transform.position.x < -2.92f)
            {
                Destroy(this.gameObject);
            }
        }
        else if (type == bulletType.rightup)
        {
            this.transform.eulerAngles = new Vector3(0, 0, -45);
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (transform.position.x >2.92f)
            {
                Destroy(this.gameObject);
            }
        }
        else if (type == bulletType.rightdown)
        {
            this.transform.eulerAngles = new Vector3(0, 0, -135);
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (transform.position.x > 2.92f)
            {
                Destroy(this.gameObject);
            }
        }
    }

}
