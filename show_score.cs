using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show_score : MonoBehaviour
{
    private GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Target");
    }

    // Update is called once per frame
    void Update()
    {
        count_score scp = target.GetComponent<count_score>();
        this.GetComponent<TextMesh>().text = scp.score.ToString();
    }
}
