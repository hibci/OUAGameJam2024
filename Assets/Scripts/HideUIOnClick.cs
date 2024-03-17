using UnityEngine;
using UnityEngine.InputSystem; 

public class HideUIOnClick : MonoBehaviour
{
    public Canvas uiCanvas; 

    void Update()
    {
        
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            
            uiCanvas.gameObject.SetActive(false);
        }
    }
}
