using HTC.UnityPlugin.Vive;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class serve : MonoBehaviour
{

    [SerializeField] private GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ViveInput.GetPressDown(HandRole.RightHand, ControllerButton.Grip) ||
           Input.GetKey("a") )
        {
            GameObject newBall = Instantiate(Ball);
            newBall.transform.position = this.transform.position;
            Vector3 dir = this.transform.forward;
            newBall.GetComponent<Rigidbody>().AddForce(dir*800);
            Destroy(newBall, 10);
        }
    }
}
