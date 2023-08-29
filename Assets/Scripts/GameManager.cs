using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{


    private int Count = 0;
    public Text CounterText;

    // Start is called before the first frame update
    void Start()
    {

        Count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoints(int pointsToAdd)
    {
        Count += pointsToAdd;
        CounterText.text = "Count : " + Count;
    }
}
