using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wave : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Enemy;
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(Enemy, new Vector3(-8.5f + (i * -2.0f), 0.75f, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
