using UnityEngine.SceneManagement;
using UnityEngine;

public class ClickSelect : MonoBehaviour
{
    public Camera mainCamera;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Select();
        }
    }

    private void Select()
    {
        RaycastHit hit;
        if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit, 100f))
        {
            print(hit.transform.name);
            if(hit.transform.name == "3x3Corner (8)")
            {
                SceneManager.LoadSceneAsync(2);
            }
        }
    }

  
}
