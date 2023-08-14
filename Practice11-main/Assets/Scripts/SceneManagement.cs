using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{   
    public void Scene(int Index)
    {
        SceneManager.LoadScene(Index);
    }   

    public void ThisScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NextScene()
    {
        if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            SceneManager.LoadScene(0);           
        }
        else      
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }               
    }
}
