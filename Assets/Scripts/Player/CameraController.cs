using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    GameObject cameraObject;

    [SerializeField]
    float speed = 1.0f;

   
    Quaternion cameraRotation = Quaternion.identity;

    private void Start()
    {
        cameraObject = GameObject.FindGameObjectWithTag("MainCamera");
    }

    public void MoveCamera(Vector2 input)
    {
        Vector3 RotAngles = cameraObject.transform.rotation.eulerAngles;
        Vector3 delta = new Vector3(input.y, -input.x, 0) * speed * Time.deltaTime;
        RotAngles += delta;
        cameraRotation = Quaternion.Euler(RotAngles);
        cameraObject.transform.rotation = cameraRotation;
    }
}
