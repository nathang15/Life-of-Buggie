
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform target;
    
    public Vector3 offset;
    [Range(1,10)]
    public float smoothfactor;
    public Vector3 minValue, maxValue;
    // public Vector2 maxPosition;
    // public Vector2 minPosition;
    // Start is called before the first frame update
    private void FixedUpdate(){
        Follow();
    }
    void Follow(){
        Vector3 targetPosition = target.position + offset;
        Vector3 boundPosition = new Vector3(Mathf.Clamp(targetPosition.x, minValue.x, maxValue.x), Mathf.Clamp(targetPosition.y, minValue.y, maxValue.y), Mathf.Clamp(targetPosition.z, minValue.z, maxValue.z));
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, boundPosition, smoothfactor*Time.fixedDeltaTime);
        transform.position = smoothedPosition;
    }


}
