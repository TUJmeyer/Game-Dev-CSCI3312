using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PlayerBehavior : MonoBehaviour
{
    public int score;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPos.y = transform.position.y;
        newPos.z = transform.position.z;

        transform.position = newPos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("apple"))
        {
            Destroy(collision.gameObject);
            addScore();
        }
    }
    void addScore()
    {
        score += 10;
        GameObject.Find("score").GetComponent<Text>().text = score.ToString();
    }
}
