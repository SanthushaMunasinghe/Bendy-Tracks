using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInputManager : MonoBehaviour
{
    private GameplayManager gameplayManager;

    private Camera mainCamera;
    public LayerMask interactableLayer;

    void Awake()
    {
        gameplayManager = GetComponent<GameplayManager>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = mainCamera.ScreenPointToRay(touch.position);

                RaycastHit hit;

                // Use the layer mask in the raycast
                if (Physics.Raycast(ray, out hit, Mathf.Infinity, interactableLayer))
                {
                    if (hit.collider.tag == "Unlock")
                    {
                        UnlockStation unlockStation = hit.collider.GetComponent<UnlockStation>();
                        gameplayManager.UnlockStation(unlockStation.price, unlockStation.index, unlockStation.gameObject);
                    }
                }
            }
        }
    }
}
