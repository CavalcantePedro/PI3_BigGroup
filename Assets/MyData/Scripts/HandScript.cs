using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour
{
<<<<<<< HEAD
    [SerializeField] private float pointingRange;
=======
    [SerializeField] private float pointRange;

>>>>>>> master
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        PointObjects();
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
=======
       transform.Rotate(new Vector3(Input.GetAxisRaw("Horizontal") , Input.GetAxisRaw("Vertical") , transform.rotation.z));
       PointObjects();
    }
    void PointObjects()
    {
        Ray ray = new Ray (transform.position , transform.forward);
        RaycastHit hit;

        Debug.DrawRay(transform.position, transform.forward, Color.red);

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
>>>>>>> master
    }

    void PointObjects()
	{
		Ray ray =  new Ray (transform.position,transform.forward);
		RaycastHit hit;
		
		if(Physics.Raycast(ray, out hit , pointingRange))
		{
			//Show the possible action
           // print("apontando para : " hit.collider.gameObject.name);

            if(Input.GetKey(KeyCode.A))
            {
                Interact(hit);
            }

		}
	}

    void Interact(RaycastHit objectToInteract)
    {
       // print("interagindo com : " objectToInteract.collider.gameObject.name);
        //objectToInteract.collider.gameObject.SendMessage("Action");
    }
}
