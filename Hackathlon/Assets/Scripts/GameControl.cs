using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private GameObject winDisplayObject;
    AudioSource audioData;
    public static bool finished;
    public static bool playedTheFinalSound;

    // Start is called before the first frame update
    void Start()
    {
        finished = false;
        playedTheFinalSound = false;
        TridentPiece.locked = false;
        NibsPiece.locked = false;
        PinguinPiece.locked = false;
        winDisplayObject.SetActive(false);
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        finished = TridentPiece.locked && NibsPiece.locked && PinguinPiece.locked;
        if (finished && !playedTheFinalSound)
        {
            audioData.Play(0);
            winDisplayObject.SetActive(true);
            playedTheFinalSound = true;
        }
    }
}
