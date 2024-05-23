using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int EggCounter;
    public static int ChickCounter;
    public static int HenCounter;
    public static int RoosterCounter;

    public static float timer;
    public TMP_Text EggValue;
    public TMP_Text ChickValue;
    public TMP_Text HenValue;
    public TMP_Text RoosterValue;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        EggValue.SetText(EggCounter.ToString());
        ChickValue.SetText(ChickCounter.ToString());
        HenValue.SetText(HenCounter.ToString());
        RoosterValue.SetText(RoosterCounter.ToString());
    }
}
