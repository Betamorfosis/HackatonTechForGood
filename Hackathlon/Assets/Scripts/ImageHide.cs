using UnityEngine;
using UnityEngine.UI;

public class ImageHide : MonoBehaviour {

    public Button button;
    public Sprite Image1;
    // Use this for initialization
    void Start () {
        button.onClick.AddListener(TaskOnClick);
        button.image.sprite = Image1;
    }
    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button!");
    }
    // Update is called once per frame
    void Update () {
		
	}
}
