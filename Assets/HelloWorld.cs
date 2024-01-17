using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string MyMessage;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello World!");//只输出一次
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hello World!");//疯狂输出
        Debug.Log(MyMessage);
    }
}
