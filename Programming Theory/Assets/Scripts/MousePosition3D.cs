using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MousePosition3D : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private LayerMask layerMask;

    [SerializeField] private TextMeshProUGUI myTitleText;
    
    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            MakeItJump();
        }
    }
    private void MakeItJump()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue,layerMask))
        {
            transform.position = raycastHit.point;
            Debug.Log(raycastHit.transform.name);
            myTitleText.text = "This is a " + raycastHit.transform.name;
            if(raycastHit.transform.tag == "Animal")
            {
                raycastHit.transform.GetComponent<AnimalBehaviour>().Jump();
            }
        }

    }
}
