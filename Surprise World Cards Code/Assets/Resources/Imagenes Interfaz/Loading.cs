using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour {

    public Transform LoadingBar;

    [SerializeField]    private float currentAmount=0;
    [SerializeField]    private float speed;

    void Update()
    {
        if(currentAmount<100)
        {
            currentAmount += speed * Time.deltaTime;
            Debug.Log((int)currentAmount); 
        }
        else
        {
            Application.LoadLevel("Main_menu");
        }
        LoadingBar.GetComponent<Image>().fillAmount = currentAmount / 100;
    }
}
