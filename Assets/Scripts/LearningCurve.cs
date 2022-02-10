using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
  public int number;
  private string line;
  private bool real;

    // Start is called before the first frame update
    void Start()
    {
    //Chapter 2

    /* Creates 4 different variables consisting of
     * a integer, float, string, and boolean.
    */
    int number = 1;
    //float long = 5.4f;
    string line = "Hello";
    bool real = false;
    Debug.Log(real);

    string starter = $"{line} World";
    }

    // Update is called once per frame
    void Update()
    {

    }
  }
