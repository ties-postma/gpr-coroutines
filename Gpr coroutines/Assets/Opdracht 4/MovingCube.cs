using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour
{
    public Transform start;
    public Transform end;
    private float startTime;
    private float speed = 2f;
    private float journeyLength;
    private float test;
    private void Start()
    {
        this.transform.position = new Vector3(0, 0, 0);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            startTime = Time.time;
            StartCoroutine("Move");
        }
    }

    IEnumerator Move()
    {
        journeyLength = Vector3.Distance(start.position, end.position);
        for (float i = start.position.x; i <= 1f; i = test)
        {
            float distCovered = (Time.time - startTime) * speed;
            test = distCovered / journeyLength;
            this.transform.position = Vector3.Lerp(start.position, end.position, test);
            yield return 0;
        }
    }
}