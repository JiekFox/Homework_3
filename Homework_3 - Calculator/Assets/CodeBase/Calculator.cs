using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public float FirstNumber, SecondNumber, Result;

    public int Choose;
    
    void Start()
    {
        switch(Choose){
            case 1:
                Result = FirstNumber + SecondNumber;
                Debug.Log("Result of summary is " + Result);
                break;
            case 2:
                Result = FirstNumber - SecondNumber;
                Debug.Log("Result of substracion is " + Result);
                break;
            case 3:
                Result = FirstNumber * SecondNumber;
                Debug.Log("Result of multiply is " + Result);
                break;
            case 4:
                Result = FirstNumber / SecondNumber;
                Debug.Log("Result of division is " + Result);
                break;            
            default:
                Debug.Log("Error choose");
                break;
        } 
    }
    

}