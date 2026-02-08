using System;
using UnityEngine;
using UnityEngine.InputSystem;

[Serializable]
public struct Example
{
    public int A;
    public int B;
    public string C;
}

[RequireComponent(typeof(CameraController))]
public class PlayerInputController : MonoBehaviour
{
    [SerializeField]
    float speed = 0;

    [SerializeField]
    Example example = new Example();

    Vector2 inputVector = Vector2.zero;
    Vector2 lookVector = Vector2.zero;

    Vector3 delta = Vector3.zero;


    CameraController cameraController;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject[] Keys = GameObject.FindGameObjectsWithTag("Key");
        foreach (GameObject Key in Keys)
        {
            MeshRenderer mesh = Key.GetComponent<MeshRenderer>();
            if (mesh != null)
            {
                mesh.material.color = Color.black;
            }
        }

        cameraController = GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        delta.Set(inputVector.x, 0, inputVector.y);
        transform.position += delta * speed * Time.deltaTime;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 value = context.ReadValue<Vector2>();  
        //Debug.Log($"Moved: {value}");
        inputVector = value;
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        Vector2 value = context.ReadValue<Vector2>();
        Debug.Log($"Moved: {value}");
        lookVector = value;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Debug.Log($"Collision with {collision.gameObject.name}");
        }

        if (collision.gameObject.CompareTag("Container"))
        {
            collision.gameObject.GetComponent<Container>().Interact(gameObject);
        }
    }

    private void LateUpdate()
    {
        cameraController.MoveCamera(lookVector);
    }

}
