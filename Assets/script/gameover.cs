using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameover : MonoBehaviour {

    public static gameover _instance;
    public Text words,sentence;
    public TextEditor te = new TextEditor();

    void Awake()
    {
        _instance = this;
        this.gameObject.SetActive(false);
    }

    public void show()
    {
        this.gameObject.SetActive(true);
    }
    public void copy()
    {
        te.text = sentence.text;
        te.SelectAll();
        te.Copy();
    }
}
