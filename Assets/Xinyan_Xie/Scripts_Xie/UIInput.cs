using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using StarterAssets;

public class UIInput : MonoBehaviour
{
    public Vector2 move;
    public Vector2 look;
    public bool jump;
    public bool sprint;

    [Header("Movement Settings")]
    public bool analogMovement;

    [Header("Mouse Cursor Settings")]
    public bool cursorLocked = true;
    public bool cursorInputForLook = true;
    public bool isMoving;
    public bool isRotating;
    public Transform cameraRoot;

    public void MoveUp()
    {
        move = Vector2.up;
        isMoving = true;
    }
    public void MoveDown()
    {
        move = Vector2.down;
        isMoving = true;
    }

    public void RotateLeft()
    {
        look= Vector2.up;
        isRotating= true;
    }
    public void RotateRight()
    {
        look = Vector2.down;
        isRotating = true;
    }

    public void Bigger()
    {
        transform.localScale *= 1.05f;
    }

    public void Smaller()
    {
        transform.localScale /= 1.05f;
    }

    public void Reset()
    {
        StartCoroutine(ResetRotate());
    }

    private void Update()
    {
        if (!isMoving)
        {
            move = Vector2.zero;
        }
        else
        {
            isMoving = false;
        }
        if (!isRotating)
        {
            look = Vector2.zero;
        }
        else
        {
            isRotating = false;
        }
    }

    IEnumerator ResetRotate()
    {
        transform.localScale = Vector3.one;
        GetComponent<ThirdPersonController>().MoveSpeed = 0;
        while (Mathf.Abs(cameraRoot.localRotation.eulerAngles.y) > 0.5f)
        {
            isMoving = true;
            move = Vector2.up*0.001f;
            yield return null;
        }
        print("Õ£÷π¡À");
        GetComponent<ThirdPersonController>().MoveSpeed = 2;
        move = Vector2.zero;
        isMoving = false;
        yield break;

    }
}
