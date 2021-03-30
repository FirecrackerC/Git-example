using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Text question;

    public void OnY()
    {
        question.color = Color.green;
    }

    public void OnN()
    {
        question.color = Color.red;
    }
}
