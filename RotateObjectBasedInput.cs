using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class RotateObjectBasedInput : MonoBehaviour {
    public GameObject RotateTarget;

    private bool _isRotating;

    private void Start() {
        RotateTarget = gameObject;
    }
    private void Update() {
        if (RotateTarget && _isRotating) {
            var rotation = Quaternion.Euler(0, -Input.mousePosition.x, 0);
            RotateTarget.transform.rotation = rotation;
        }
    }


    private void OnMouseDown() {
        _isRotating = true;
    }

    private void OnMouseUp() {
        _isRotating = false;
    }
}
