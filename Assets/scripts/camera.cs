using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    float camRotation = 0f;
    public Transform CamTransform;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        camRotation -= mouseY;
        camRotation = Mathf.Clamp(camRotation, -90f, 90f);
        CamTransform.localRotation = Quaternion.Euler(new Vector3(camRotation, 0f, 0f));
        transform.rotation = Quaternion.Euler(transform.eulerAngles + new Vector3(0f, mouseX, 0f));
    }
}
