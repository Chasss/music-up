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
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            if (transform.position.y < -4.25f)
            {
                Destroy(this.gameObject);
            }
        }
        else if (type == bulletType.left)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (transform.position.x < -2.5f)
            {
                Destroy(this.gameObject);
            }
        } 
        else if (type == bulletType.right)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
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
            transform.Translate(new Vector3(-1, 1, 0) * speed * Time.deltaTime);
            if (transform.position.x < -2.92f)
            {
                Destroy(this.gameObject);
            }
        }
        else if (type == bulletType.leftdown)
        {
            transform.Translate(new Vector3(-1,-1, 0) * speed * Time.deltaTime);
            if (transform.position.x < -2.92f)
            {
                Destroy(this.gameObject);
            }
        }
        else if (type == bulletType.rightup)
        {
            transform.Translate(new Vector3(1, 1, 0) * speed * Time.deltaTime);
            if (transform.position.x >2.92f)
            {
                Destroy(this.gameObject);
            }
        }
        else if (type == bulletType.rightdown)
        {
            transform.Translate(new Vector3(1, -1, 0) * speed * Time.deltaTime);
            if (transform.position.x > 2.92f)
            {
                Destroy(this.gameObject);
            }
        }
    }

}
