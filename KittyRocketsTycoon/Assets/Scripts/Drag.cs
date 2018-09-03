using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WARMachine.Variables;

public class Drag : MonoBehaviour
{

    public float speed;
    public float yBuffer;
    public bool dragAndDrop;
    //public bool savedLovation;
    public FloatReference SaveLocationX;
    
   // public Renderer rend;

    void Start()
    {
        //rend = GetComponent<Renderer>();
        yBuffer = yBuffer + transform.position.y;
        if (SaveLocationX != null)
            SaveLocationX.Variable.Value = transform.position.x;
    }
    // Update is called once per frame
    void Update ()
    {
        if(dragAndDrop)
            FollowMouse();
        

    }

    void FollowMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

//
  //          mousePosition.x - transform.position.x,
  //          mousePosition.y - transform.position.y);

        // this.transform.up = direction;//small rotation
        
        this.transform.position = new Vector3(Mathf.Lerp(mousePosition.x, transform.position.x, Time.deltaTime * speed),  yBuffer, transform.position.z);//smooth follow x follow
                                                                                                                                                         
        //    this.transform.position = new Vector3(Mathf.Lerp(mousePosition.x, transform.position.x, Time.deltaTime * speed), Mathf.Lerp(mousePosition.y, transform.position.y, Time.deltaTime * speed) + yBuffer, transform.position.z);//smooth follow
        if (SaveLocationX != null)
            SaveLocationX.Variable.Value = transform.position.x;

    }

    private void OnMouseDrag()
    {
        //rend.material.color -= Color.white * Time.deltaTime;
        dragAndDrop = true;
    }

    void OnMouseUp()
    {
        // If your mouse hovers over the GameObject with the script attached, output this message
        dragAndDrop = false;
    }

}
