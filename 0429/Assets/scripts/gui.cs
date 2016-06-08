using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class first : MonoBehaviour 
{
    public void GoToLevel(string level)
    {
        SceneManager.LoadScene("1play");
    }   
}