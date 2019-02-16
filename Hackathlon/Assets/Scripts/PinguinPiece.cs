using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinguinPiece : MonoBehaviour
{
    [SerializeField]
    private Transform finalPlace;

    private Vector2 initialPosition;

    private float deltaX, deltaY;

    public static bool locked;

    AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && !locked)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;
                        Handheld.Vibrate();
                    }
                    break;
                case TouchPhase.Moved:
                    {
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                        {
                            transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);

                        }
                    }
                    break;
                case TouchPhase.Ended:
                    {
                        if (Mathf.Abs(transform.position.x - finalPlace.position.x) <= 0.5f &&
                            Mathf.Abs(transform.position.y - finalPlace.position.y) <= 0.5f)
                        {
                            transform.position = new Vector2(finalPlace.position.x, finalPlace.position.y);
                            locked = true;
                            audioData.Play(0);
                            Handheld.Vibrate();
                        }
                        else
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                        }
                    }
                    break;
            }
        }
    }
}
