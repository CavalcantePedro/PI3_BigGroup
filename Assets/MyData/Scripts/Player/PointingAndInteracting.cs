using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointingAndInteracting : MonoBehaviour
{
    [SerializeField] private float pointRange;

    [SerializeField] private TextMesh possibleActionText;

    [SerializeField] private InteractibleObject[] interactibleObjects;

    void Update()
    {       
       PointObjects();
    }
    void PointObjects()
    {
        Ray ray = new Ray (transform.position , transform.forward);
        RaycastHit hit;

        Debug.DrawRay(transform.position, transform.up * -1, Color.red);


        if(Physics.Raycast(ray , out hit , pointRange))
        {
            //se o objeto é interativel, mostre a ação que podemos exercer sobre ele
            if(hit.collider.CompareTag("Interactible"))
            {
                StartCoroutine(ShowActionDescription(hit.collider.gameObject.name));
            }

            //se não, esconda os textos
            else 
            {
              possibleActionText.text = "";           
            }
            
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

    IEnumerator ShowActionDescription(string pointingAt)
    {
        for(int i = 0 ; i < interactibleObjects.Length ; i++)
        {
            if(pointingAt == interactibleObjects[i].objectName)
                {
                    possibleActionText.text = interactibleObjects[i].actionDescription;
                }
        }
        return null;
    }
}
