using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TitleColor : MonoBehaviour
{
    public float speed = 1f;
    private TextMeshProUGUI textComponent;

    void Start()
    {
        textComponent = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        float hue = Time.time * speed % 1f;
        Color color = Color.HSVToRGB(hue, 1f, 1f);
        textComponent.color = color;
    }

}
