
using UnityEngine;

public class CameraRotateAndRevolve : MonoBehaviour
{
    public Transform player;  // The player/cube to orbit around
    public float distance = 5.0f;  // Distance from the player
    public float rotationSpeed = 100.0f; // Speed of rotation

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RotateAndRevolve(90);  // Rotate and revolve by 90 degrees when pressing 'R' key
        }
    }
    void RotateAndRevolve(float angle)
    {
        // Calculate the new position by rotating the offset around the Y-axis (up axis)
        Quaternion rotation = Quaternion.Euler(0, angle, 0);
        offset = rotation * offset;

        // Set the camera's new position
        transform.position = player.position + offset;

        // Rotate the camera to look at the player
        transform.LookAt(player);
    }
}
