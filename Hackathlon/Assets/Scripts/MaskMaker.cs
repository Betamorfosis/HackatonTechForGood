using UnityEngine;

public class MaskMaker : MonoBehaviour
{
    public GameObject GameObjectMask;
    private float TimerCreate;
    
	void Start ()
    {
        TimerCreate = 0.0f;
    }
	
	void Update ()
    {
        TimerCreate += Time.deltaTime;
        if (TimerCreate >= 0.25f)
        {
            GameObject instance = Instantiate(GameObjectMask, transform.position, Quaternion.Euler(Vector3.zero));
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePos.x, mousePos.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(9999, 9999, transform.position.z);
        }


	}
}
