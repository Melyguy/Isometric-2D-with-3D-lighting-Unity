using UnityEngine;

public class lighttravel : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public Transform lightSource;
    public float speed = 1.0f;


    void Update()
    {
        if (lightSource != null && startPoint != null && endPoint != null)
        {
            lightSource.position = Vector3.Lerp(startPoint.position, endPoint.position, Mathf.PingPong(Time.time * speed, 1));
        }
    }
}
