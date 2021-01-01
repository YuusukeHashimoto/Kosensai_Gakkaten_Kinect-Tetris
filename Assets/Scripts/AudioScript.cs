using UnityEngine;
using System.Collections;

public class AudioScript : MonoBehaviour {

    public AudioClip se1, se2, se3,se4;
    public static bool isDeleted,isValid, isMoved, isRotated;
    
    // Use this for initialization

   
    public static void RowDeleted()
    {
        isDeleted = true;
    }

    public static void goingmayway()
    {
        isValid = true;
    }

    public static void Moved()
    {
        isMoved = true;
    }

    public static void Rotated()
    {
        isRotated = true;
    }

    void Start()
    {
       
    }

    // Update is called once per frame
    
    void Update () {

        if (isDeleted)
        {
            GetComponent<AudioSource>().PlayOneShot(se3);
            isDeleted = false;
        }
        if (isValid)
        {
            GetComponent<AudioSource>().PlayOneShot(se4);
            isValid = false;
        }
        else if (isMoved)
        {
            GetComponent<AudioSource>().PlayOneShot(se1);
            isMoved = false;
        }
        else if (isRotated)
        {
            GetComponent<AudioSource>().PlayOneShot(se2);
            isRotated = false;
        }

    }

    

        



        }
