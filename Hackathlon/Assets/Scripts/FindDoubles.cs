using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindDoubles : MonoBehaviour {
    public bool rightAnswer;
    public bool found1;
    public bool found2;
    public bool found3;
    public bool found4;
    public bool victory;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public bool selected1;
    public bool selected2;
    public bool selected3;
    public bool selected4;
    public bool selected5;
    public bool selected6;
    public bool selected7;
    public bool selected8;
    public GameObject ImageComplete;
    public Sprite Hidden1;
    public Sprite Hidden2;
    public Sprite Hidden3;
    public Sprite Hidden4;
    public Sprite Hidden5;
    public Sprite Hidden6;
    public Sprite Hidden7;
    public Sprite Hidden8;
    public Sprite Image1;
    public Sprite Image2;
    public Sprite Image3;
    public Sprite Image4;
    public int chosenImages = 0;
    public int errorsCount = 4;
    public float timer;
    [SerializeField]
    public AudioSource[] audioSources;

    // Use this for initialization
    void Start() {
        timer = 0;
        button1.onClick.AddListener(TaskOnClick1);
        button2.onClick.AddListener(TaskOnClick2);
        button3.onClick.AddListener(TaskOnClick3);
        button4.onClick.AddListener(TaskOnClick4);
        button5.onClick.AddListener(TaskOnClick5);
        button6.onClick.AddListener(TaskOnClick6);
        button7.onClick.AddListener(TaskOnClick7);
        button8.onClick.AddListener(TaskOnClick8);
        ImageComplete.SetActive(false);
        button1.image.sprite = Hidden1;
        button2.image.sprite = Hidden2;
        button3.image.sprite = Hidden3;
        button4.image.sprite = Hidden4;
        button5.image.sprite = Hidden5;
        button6.image.sprite = Hidden6;
        button7.image.sprite = Hidden7;
        button8.image.sprite = Hidden8;
        selected1 = false;
        selected2 = false;
        selected3 = false;
        selected4 = false;
        selected5 = false;
        selected6 = false;
        selected7 = false;
        selected8 = false;
        
        rightAnswer = false;
        found1 = false;
        found2 = false;
        found3 = false;
        found4 = false;
        victory = false;
    }

    void TaskOnClick1()
    {
        button1.image.sprite = Image1;
        chosenImages++;
        selected1 = true;
        Debug.Log("You have clicked the button!");
    }

    void TaskOnClick2()
    {
        button2.image.sprite = Image3;
        chosenImages++;
        selected2 = true;
        Debug.Log("You have clicked the button!");
    }
    void TaskOnClick3()
    {
        button3.image.sprite = Image2;
        chosenImages++;
        selected3 = true;
        Debug.Log("You have clicked the button!");
    }

    void TaskOnClick4()
    {
        button4.image.sprite = Image3;
        chosenImages++;
        selected4 = true;
        Debug.Log("You have clicked the button!");
    }

    void TaskOnClick5()
    {
        button5.image.sprite = Image2;
        chosenImages++;
        selected5 = true;
        Debug.Log("You have clicked the button!");
    }
    void TaskOnClick6()
    {
        button6.image.sprite = Image4;
        chosenImages++;
        selected6 = true;
        Debug.Log("You have clicked the button!");
    }
    void TaskOnClick7()
    {
        button7.image.sprite = Image4;
        chosenImages++;
        selected7 = true;
        Debug.Log("You have clicked the button!");
    }
    void TaskOnClick8()
    {
        button8.image.sprite = Image1;
        chosenImages++;
        selected8 = true;
        Debug.Log("You have clicked the button!");
    }

    // Update is called once per frame
    void Update () {
        if (errorsCount == 0 && !victory)
        {
            Debug.Log("You have found all the errors!");
            ImageComplete.SetActive(true);
            button1.gameObject.SetActive(false);
            button2.gameObject.SetActive(false);
            button3.gameObject.SetActive(false);
            button4.gameObject.SetActive(false);
            button5.gameObject.SetActive(false);
            button6.gameObject.SetActive(false);
            button7.gameObject.SetActive(false);
            button8.gameObject.SetActive(false);
            if (!victory) {
                audioSources[2].Play(0);
                victory = true;
                rightAnswer = false;
                found1 = false;
                found2 = false;
                found3 = false;
                found4 = false;
            }
        }
        if (chosenImages == 2)
        {
            timer += Time.deltaTime;
            if (timer > 1)
            {
                timer = 0;
                chosenImages = 0;
                if (!(selected1 && selected8))
                {
                    selected1 = false;
                    selected8 = false;
                    button1.image.sprite = Hidden1;
                    button8.image.sprite = Hidden8;
                }
                else
                {
                    Debug.Log("Couple Trouvé. Count " + errorsCount);
                    if (!found1) {
                        rightAnswer = true;
                        found1 = true;
                    }
                }
                if (!(selected2 && selected4))
                {
                    selected2 = false;
                    selected4 = false;
                    button2.image.sprite = Hidden2;
                    button4.image.sprite = Hidden4;
                }
                else
                {
                    Debug.Log("Couple Trouvé. Count " + errorsCount);
                    if (!found2)
                    {
                        rightAnswer = true;
                        found2 = true;
                    }
                }
                if (!(selected5 && selected3))
                {
                    selected3 = false;
                    selected5 = false;
                    button3.image.sprite = Hidden3;
                    button5.image.sprite = Hidden5;
                }
                else
                {
                    Debug.Log("Couple Trouvé. Count " + errorsCount);
                    if (!found3)
                    {
                        rightAnswer = true;
                        found3 = true;
                    }
                }
                if (!(selected6 && selected7))
                {
                    selected6 = false;
                    selected7 = false;
                    button6.image.sprite = Hidden6;
                    button7.image.sprite = Hidden7;
                }
                else
                {
                    Debug.Log("Couple Trouvé. Count " + errorsCount);
                    if (!found4)
                    {
                        rightAnswer = true;
                        found4 = true;
                    }
                }

                if (errorsCount != 0) {
                    if (rightAnswer)
                    {
                        audioSources[1].Play(0);
                        rightAnswer = false;
                        errorsCount--;
                    }
                    else
                    {
                        audioSources[0].Play(0);
                    }
                }
            }
        }
	}
}
