using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveY : MonoBehaviour
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
        transform.Translate(0.0f, Speed, 0.0f);
        if (Frame > 100)
        {
            Speed *= -1;
            Frame = 0;
        }
    }
}
