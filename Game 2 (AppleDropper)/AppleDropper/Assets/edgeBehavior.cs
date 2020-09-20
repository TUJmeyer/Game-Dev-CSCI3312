using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class edgeBehavior : MonoBehaviour
{
    private List<GameObject> playerList;
    public GameObject playerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        playerList = new List<GameObject>();
        for (int i = 0; i < 3; i++)
        {
            GameObject players = Instantiate<GameObject>(playerPrefab);
            Vector3 position = players.transform.position;
            position.y = transform.position.y + 1.0f + (i * 1.0f);
            players.transform.position = position;
            playerList.Add(players);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("apple"))
        {
            if (playerList.Count - 1 > -1)
            {
                Destroy(playerList[playerList.Count - 1]);
                playerList.RemoveAt(playerList.Count - 1 );
            }
            Destroy(collision.gameObject);
            if (playerList.Count -1 == -1)
            {
                Time.timeScale = 0;
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Additive);
            }
        }
    }
}
