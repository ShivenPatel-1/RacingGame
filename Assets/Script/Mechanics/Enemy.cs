using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  public GameObject Player;
  public float speed;

  private float distance; 

  void Start()
  {

  }

  void Update()
  {
    distance = Vector2.Distance(transform.position, Player.transform.position);
    Vector2 direction = transform.position - Player.transform.position;
    direction.Normalize();
    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

    transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
    transform.rotation = Quaternion.Euler(Vector3.forward * angle);
  }
}