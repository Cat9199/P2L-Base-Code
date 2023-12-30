using UnityEngine;

public class RotateModel : MonoBehaviour
{
    private Touch touch;
    public float rotateSpeedModifier = 0.3f;

    void Update()
    {
        if (Input.touchCount == 1)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                float rotationY = touch.deltaPosition.x * rotateSpeedModifier;
                transform.Rotate(0f, rotationY, 0f, Space.World);
            }
        }
    }
}
