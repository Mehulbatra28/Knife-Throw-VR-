using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketScript : MonoBehaviour
{
    public XRSocketInteractor socket;
    public GameObject Cube;

    private void OnEnable()
    {
        socket.selectEntered.AddListener(OnObjectPlaced);
      
    }

    private void OnDisable()
    {
        socket.selectEntered.RemoveListener(OnObjectPlaced);
       
    }

    private void OnObjectPlaced(SelectEnterEventArgs args)
    {
        GameObject placedObj = args.interactableObject.transform.gameObject;
        Debug.Log("Placed object: " + placedObj.name);
        Destroy(placedObj);
        Destroy(Cube);


    }

   
}
