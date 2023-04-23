using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
   [SerializeField] private GameObject cardBack;
   [SerializeField] private SceneController _controller;

   private int _id;

   public int id
   {
      get { return _id; }
   }
   public void SetCard(int id, Sprite image)
   {
      _id = id;
      GetComponent<SpriteRenderer>().sprite = image;
   }
   
   public void OnMouseDown()
   {
      if (cardBack.activeSelf && _controller.canReveal)
      {
         cardBack.SetActive(false);
         _controller.CardRevealed(this);
      }
   }

   public void Unreveal()
   {
      cardBack.SetActive(true); 
   }
}
