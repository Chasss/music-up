using UnityEngine;
using System.Collections;

public class player : MonoBehaviour
{

    public float speed = 2;

    public bool animations = true;
    public int frameCountPerSecond = 10;
    public float timer = 0;
    public Sprite[] spriters;

    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        if (animations)
        {

            timer += Time.deltaTime;
            int frameIndex = (int)(timer / (1f / frameCountPerSecond));
            int frame = frameIndex % 2;
            this.GetComponent<SpriteRenderer>().sprite = spriters[frame];
        }

        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 4f)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -4f)
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -2.4f)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 2.4f)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }


    }
}
