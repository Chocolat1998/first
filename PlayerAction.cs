using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    Rigidbody2D rigid;
    Camera Camera;
    Vector2 MousePosition;
    Vector2 RoundPosition;
    Vector2 PlayerPosition;
    Transform PlayerTransform;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        Camera = GameObject.Find("Main Camera").GetComponent<Camera>();
        PlayerTransform = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPosition = PlayerTransform.position;
        if (Input.GetMouseButtonDown(0))
        {
            MousePosition = Input.mousePosition;
            MousePosition = Camera.ScreenToWorldPoint(MousePosition);
            MousePosition[0] += 0.5f;
            MousePosition[1] += 0.5f;
            RoundPosition[0] = Mathf.RoundToInt(MousePosition[0]);
            RoundPosition[1] = Mathf.RoundToInt(MousePosition[1]);
            RoundPosition[0] += -0.5f;
            RoundPosition[1] += -0.5f;

            if (Mathf.Abs(RoundPosition[0]-PlayerPosition[0])<=1 & Mathf.Abs(RoundPosition[1] - PlayerPosition[1])<=1)
            {
                transform.position = RoundPosition;
            }

        }
    }
}
