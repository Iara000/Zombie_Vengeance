﻿using UnityEngine;
public class SwipeController : MonoBehaviour
{
    public Vector2 firstPosition;
    private Vector2 secondPosition;
    public Vector2 moveDirection;
    public bool isControlling = false;
	void Update ()
    {
        if(Input.GetMouseButtonDown(0))
        {
            isControlling = true;
            firstPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if(Input.GetMouseButtonUp(0))
        {
            isControlling = false;
            secondPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moveDirection = new Vector2(secondPosition.x - firstPosition.x, secondPosition.y - firstPosition.y);
        }
	}
}