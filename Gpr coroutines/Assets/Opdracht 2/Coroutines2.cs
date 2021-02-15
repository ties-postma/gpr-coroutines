using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Fade");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Fade ()
    {
        Debug.Log("Coroutine update");
        yield return new WaitForSeconds(.5f);

        for (float ft = 1f; ft >= 0; ft -= 0.1f)
        {
        Debug.Log("Coroutine update2");
        yield return new WaitForSeconds(.5f);
        }

        Debug.Log("Coroutine update3");
        yield return new WaitForSeconds(.5f);
    }
}