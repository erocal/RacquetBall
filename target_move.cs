using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class target_move : MonoBehaviour
{
    [SerializeField] private float step;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float curX = this.transform.position.x;
        curX += step;
        if (curX > 0.8f || curX < -0.8f)
            step = -step;

        this.transform.position = new Vector3(curX, transform.position.y, transform.position.z);
    }
}
