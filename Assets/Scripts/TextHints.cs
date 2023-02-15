using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextHints : MonoBehaviour
{
    float timer = 0.0f;
    public float time = 4.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TMP_Text guiText = GetComponent<TMP_Text>();
        if (guiText.enabled)
        {
            timer += Time.deltaTime;
            if (timer >= time)
            {
                guiText.enabled = false;
                timer = 0.0f;
            }
        }
    }

    void ShowHint(string message)
    {
        TMP_Text guiText = GetComponent<TMP_Text>();
        guiText.text = message;
        if (!guiText.enabled)
        {
            guiText.enabled = true;
        }
    }
}
