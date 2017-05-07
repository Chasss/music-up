using UnityEngine;
using System.Collections;

public class BackgrondTransform : MonoBehaviour
{

    public static float movespeed = 1.5f;

    // Update is called once per frame
    void Update()
    {

        this.transform.Translate(Vector3.down * movespeed * Time.deltaTime);
        Vector3 position = this.transform.position;
        if (position.y <= -8f)
        {
            this.transform.position = new Vector3(position.x, position.y + 16f, position.z);
        }
    }
}