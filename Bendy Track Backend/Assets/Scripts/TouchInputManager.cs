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
        if (Input.GetMouseButton(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

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
