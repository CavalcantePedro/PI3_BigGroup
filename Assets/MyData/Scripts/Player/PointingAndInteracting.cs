using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointingAndInteracting : MonoBehaviour
{
    [SerializeField] private float pointRange;

    [SerializeField] private TextMesh interactionText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //transform.Rotate(new Vector3(Input.GetAxisRaw("Horizontal") , Input.GetAxisRaw("Vertical") , transform.rotation.z));
       PointObjects();
    }
    void PointObjects()
    {
        Ray ray = new Ray (transform.position , transform.forward);
        RaycastHit hit;

        Debug.DrawRay(transform.position, transform.up * -1, Color.red);

        if(Physics.Raycast(ray , out hit , pointRange))
        {
            //show object action
            print("u are pointing at: " + hit.collider.gameObject.name);
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Interact(hit);
            }
        }
    }

    void Interact(RaycastHit objectToInteract)
    {
        print("u  are interacting with: " + objectToInteract.collider.gameObject.name);
        //objectToInteract.collider.gameObject.SendMessage("Action");
    }
}
