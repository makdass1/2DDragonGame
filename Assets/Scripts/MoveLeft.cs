
using System;
using UnityEditor;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float Speed;
    private  Enemy enemy;
    private void Awake()
    {
         enemy = GetComponent<Enemy>();
    }

    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * Speed , Space.World) ;

        if (transform.position.x < -24)
        {
            transform.position += Vector3.right * 30;
            ShowRandomSprite();
            enemy?.Respawn();

        }
    }
    private void ShowRandomSprite()
    {

        int index = UnityEngine.Random.Range(0, 3);
        int childCount = transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            Transform child = transform.GetChild(i);
            bool shouldShow = index == i;
            child.gameObject.SetActive(shouldShow);
        }
    }
    private void OnEnable()
    {
        ShowRandomSprite();
    }

}