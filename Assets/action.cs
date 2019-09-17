using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class action : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vb1;
    public GameObject vb2;
    public GameObject vb3;
    public GameObject vb4;

    public Canvas can;

    public Transform obj;
    void Start()
    {
        vb1 = GameObject.Find("downarrow");
        vb2 = GameObject.Find("uparrow");
        vb3 = GameObject.Find("rightarrow");
        vb4 = GameObject.Find("leftarrow");

        can.enabled = false;

        vb1.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        vb2.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        vb3.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        vb4.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.gameObject.name == "downarrow")
        {
            can.enabled = false;
            obj.transform.Translate(0, 0, 0.2f);
        }else if (vb.gameObject.name == "uparrow")
        {
            can.enabled = false;
            obj.transform.Translate(0, 0, -0.2f);
        }else if (vb.gameObject.name == "rightarrow")
        {
            can.enabled = false;
            obj.transform.Translate(0.2f, 0, 0);
        }
        else
        {
            can.enabled = false;
            obj.transform.Translate(-0.2f, 0, 0);
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("button released");
    }



    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "endpoint")
        {
            Debug.Log("endddddd");
            can.enabled = true;
        }
    }

    void Update()
    {
        
    }
}
