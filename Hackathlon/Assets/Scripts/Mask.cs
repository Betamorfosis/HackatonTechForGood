using UnityEngine;

public class Mask : MonoBehaviour
{
    void Update()
    {
        transform.localScale = transform.localScale - new Vector3(0.1f, 0.1f, 0.1f);
        if (transform.localScale.x <= 0.01f)
        {
            Destroy(gameObject);
        }
    }
}
