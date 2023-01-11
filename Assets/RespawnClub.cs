using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RespawnClub : MonoBehaviour
{
    public XRDirectInteractor rightHand;
    public GameObject rightHandHand;
    public XRDirectInteractor leftHand;
    public GameObject golfClub;
    public Transform golfClubPosition;
    public Vector3 positionOffset;
    public Quaternion rotationOffset;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        IXRSelectInteractable asdf = rightHand.GetOldestInteractableSelected();
        if (asdf == null)
        {
            Debug.Log("asdf");
            golfClubPosition.SetPositionAndRotation(rightHandHand.transform.position + positionOffset, rightHandHand.transform.rotation * rotationOffset);
        }
    }
}
