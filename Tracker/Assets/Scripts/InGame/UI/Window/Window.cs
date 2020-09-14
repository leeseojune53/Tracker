using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Window : MonoBehaviour, IPointerDownHandler
{
    public GameObject[] gameObjects;
    public void OnPointerDown(PointerEventData data)
    {
        gameObjects[0].SetActive(true);
        gameObjects[1].SetActive(true);
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && gameObjects[0].activeSelf)
        {
            gameObjects[0].SetActive(false);
            gameObjects[1].SetActive(false);
        }
    }
}
