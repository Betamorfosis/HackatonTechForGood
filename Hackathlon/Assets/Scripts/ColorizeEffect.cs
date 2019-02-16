using UnityEngine;
using UnityEngine.UI;

public class ColorizeEffect : MonoBehaviour
{
    private bool isPressed = false;
    private float timer;
    private RawImage rawImage;
    private Texture2D texture;

	void Start ()
    {
        rawImage = GetComponent<RawImage>();
        texture = new Texture2D(360, 480);
        rawImage.texture = texture;
    }  

    void Update ()
    {
        var mousePos = Input.mousePosition;
        Vector2 mousePercent = new Vector2(mousePos.x / Screen.width, mousePos.y / Screen.height);
        mousePos.z = 50;
        if (isPressed && timer >= 0.0025f)
        {
            for (int y = 0; y < texture.height; y++)
            {
                for (int x = 0; x < texture.width; x++)
                {
                    Vector2 percent = new Vector2(x / (float)texture.width, y / (float)texture.height); 
                    Color pixelColour;
                    if (Vector2.Distance(mousePercent, percent) < 0.1f)
                    { 
                        pixelColour = new Color(0, 0, 0, 0);
                        texture.SetPixel(x, y, pixelColour);
                    }                   
                }
            }
            texture.Apply();
            timer = 0.0f;
        }
        timer += Time.deltaTime;
        if (Input.GetMouseButtonDown(0))
        {
            isPressed = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isPressed = false;
        }
	}
}
