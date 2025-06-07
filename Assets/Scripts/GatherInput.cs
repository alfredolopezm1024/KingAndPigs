using UnityEngine;
using UnityEngine.InputSystem;

public class GatherInput : MonoBehaviour
{
    private Controls controls;
    private float valueX;
    private float valueY;

    private void Awake()
    {
        controls = new Controls();

    }

    private void OnEnable()
    {
        controls.;
    }

    private void OnDisable()
    {
        controls = null;
    }
}
