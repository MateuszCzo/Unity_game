using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class WolfBite : MonoBehaviour
{
    public TMP_Text textHints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            textHints.SendMessage("ShowHint", "Zosta³eœ zjedzony przez wilka.");
            StartCoroutine(NewScene());
        }
    }
    IEnumerator NewScene()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("Menu");
    }
}
