using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class InterfaceManager : MonoBehaviour
{
    public static InterfaceManager instance;
                
    public GameObject window;
    public Text coinText;

    public void Start()
    {
        instance = this;
    }

    private void Update()
    {
        coinText.text = GameManager.instance.coin.ToString()+" $";
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
    public void ActiveUI()
    {
        window.SetActive(true);
    }
}
