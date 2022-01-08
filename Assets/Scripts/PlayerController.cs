using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Comment from Github.com HELLO
        // Comment from Nishchhal from his machine which says Hello

        Debug.Log("Start on Player");
        Debug.Log("Start on Player");
        Debug.Log("Start on Player");
        Debug.Log("Start on Player");
        Debug.Log("Start on Player");
        Debug.Log("Start on Player");
        Debug.Log("Start on Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % 40 == 0)
        {
            Debug.Log("Update on Player");
            Debug.Log("Update on Player");
        }
    }
}
