using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARController : DefaultTrackableEventHandler
{

     string thisName;

    [SerializeField] GameObject objectToShow;


    ImageTargetBehaviour thisImageBehaviour;


    protected void Awake()
    {
        thisImageBehaviour = GetComponent<ImageTargetBehaviour>();

    }
    protected override void Start()
    {
        base.Start();
        
        
    }

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        print("Encontrado el marcador: " + thisImageBehaviour.ImageTarget.Name);
        if(objectToShow != null)
        {

            objectToShow.GetComponent<InteractiveARObject>().Interact();

        }
    }
    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        if (thisImageBehaviour.ImageTarget != null)
        {
            print("Perdido el marcadorasdasd: " + thisImageBehaviour.ImageTarget.Name);
        }
        if (objectToShow != null)
            objectToShow.GetComponent<InteractiveARObject>().StopInteraction();

    }
}
