using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PermanentUI : MonoBehaviour
{
    //Player Stats
    public int cherries = 0;
    public int health = 5;
    public TextMeshProUGUI cherryText;
    public Text healthAmount;

    public static PermanentUI perm;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);

        //Singleton
        if (!perm)
        {
            perm = this;
        }
        else
            Destroy(gameObject);
    }

    public void Reset()
    {
        
        cherryText.text = cherries.ToString();
    }
}
