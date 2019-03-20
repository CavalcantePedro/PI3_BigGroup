using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour
{
    [SerializeField] private float pointingRange;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PointObjects();
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
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
