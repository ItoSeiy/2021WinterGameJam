using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuroraCoordinater : MonoBehaviour
{
    [SerializeField] Vector2[] Apos;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time >= 3.0f)
        {
            this.gameObject.transform.position = Apos[(int)Random.Range(0, Apos.Length)];
            time = 0;
        }
    }
}
