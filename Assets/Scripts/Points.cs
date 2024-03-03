using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Points : MonoBehaviour
{
    public int points = 0;
    public TMP_Text pointsText;
    public void pointsUP()
    {
        points += 100;
        pointsText.text = points.ToString();
    }
}
