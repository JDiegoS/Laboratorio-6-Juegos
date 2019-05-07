using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    bool defeat = false;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Player") == null)
        {
            Defeat();
        }
        if (Time.timeScale == 0.0f && defeat == false)
        {
            Victory();
        }

    }
    public void Restart()
    {

        SceneManager.LoadScene("Game");
    }
    public void Victory()
    {

        transform.Find("Victory").gameObject.SetActive(true);

    }
    public void Defeat()
    {
        defeat = true;
        Time.timeScale = 0.0f;
        transform.Find("Defeat").gameObject.SetActive(true);
        defeat = true;

    }
    private void OnTriggerEnter(Collider other)
    {
        Victory();

    }
}
