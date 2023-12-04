using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageRandomizer : MonoBehaviour
{
    public GameObject image;
    void Start()
    {
        RectTransform imageRect = image.GetComponent<RectTransform>();

        float canvasWidth = GetComponent<RectTransform>().rect.width;
        float canvasHeight = GetComponent<RectTransform>().rect.height;

        float randomX = Random.Range(-canvasWidth / 2f, canvasWidth / 2f);
        float randomY = Random.Range(-canvasHeight / 2f, canvasHeight / 2f);

        imageRect.anchoredPosition = new Vector2(randomX, randomY);
    }

    
}
