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

    bool result = IsTrue(real);

    // Chapter 4
        if(result == true){
          result = false;
        }
        if(number < 5){
          number +=1;
        }else{
          number = 0;
        }

    }
  void Greet()
  {
      switch (number)
      {
      case 3:
          print ("3");
          break;
      case 2:
          print ("2");
          break;
      case 1:
          print ("1");
          break;
      default:
          print ("Default");
          break;
      }
  }
  void Array(){
    int[] array1 = new int[] { 1, 3, 5, 7, 9 };

  }
  void StringList(){
    var students = new Dictionary<int, StudentName>()
       {
           { 111, new StudentName { FirstName="Sachin", LastName="Karnik", ID=211 } },
           { 112, new StudentName { FirstName="Dina", LastName="Salimzianova", ID=317 } },
           { 113, new StudentName { FirstName="Andy", LastName="Ruth", ID=198 } }
       };
    List<string> list = new List<string>
            { "1", "2","3", "4", "5"};
    for(int i = 0; i<len(list); i++){
      print(list(i));
    }
    foreach(int i in list){
      print(list(i));
    }
    foreach (int i in students) {
      //print(KeyValuePair.Key + " "+ KeyValuePair.Value);

    }

  }

    // Update is called once per frame
    void Update()
    {

    }

    bool IsTrue(bool real){
      if(real==true){
        return true;
      }
      else{
        return false;
      }
    }
  }
