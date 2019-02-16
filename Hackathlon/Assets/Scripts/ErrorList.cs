using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ErrorList : MonoBehaviour {
    public Button button1;
    public Button button2;
    public Button button3;
    public Sprite Image1;
    public Sprite Image2;
    public Sprite Image3;
    public int errorsCount = 3;

    void Start()
    {
        button1.onClick.AddListener(TaskOnClick1);
        button2.onClick.AddListener(TaskOnClick2);
        button3.onClick.AddListener(TaskOnClick3);
        button1.image.sprite = Image1;
        button2.image.sprite = Image2;
        button3.image.sprite = Image3;
    }
    void TaskOnClick1()
    {
        button1.gameObject.SetActive(false);
        errorsCount--;
        Debug.Log("You have clicked the button!");
    }

    void TaskOnClick2()
    {
        button2.gameObject.SetActive(false);
        errorsCount--;
        Debug.Log("You have clicked the button!");
    }
    void TaskOnClick3()
    {
        button3.gameObject.SetActive(false);
        errorsCount--;
        Debug.Log("You have clicked the button!");
    }

    private void Update()
    {
        if (errorsCount == 0) {
            Debug.Log("You have found all the errors!");
        }
    }
}
