using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLV : MonoBehaviour
{
    // Start is called before the first frame update
    public void lv1()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void lv2()
    {
        SceneManager.LoadScene("LV2");
    }

}

