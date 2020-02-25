using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sidemove : MonoBehaviour
{
    private int Frame;
    [SerializeField]
    private float Speed;
    // Start is called before the first frame update
    void Start()
    {
        Frame = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Frame++;
        transform.Translate(Speed, 0.0f, 0.0f);
        if (Frame > 100)
        {
            Speed *= -1;
            Frame = 0;
        }
    }
}
