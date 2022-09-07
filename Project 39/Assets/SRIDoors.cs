using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRIDoors : MonoBehaviour
{
  public bool isAuto;
  public Animator anim;

  private void OnTriggerEnter(Collider other)
  {
    if(other.tag == "Player")
    {
      anim.SetBool("Open", true);
    }
  }

  private void OnTriggerExit(Collider other)
  {
    if(other.tag == "Player")
    {
      anim.SetBool("Open", false);
    }
  }

  void Start()
  {

  }
  void Update()
  {

  }
}
