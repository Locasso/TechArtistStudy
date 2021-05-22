using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Highlighted : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler
{
     [SerializeField] private Animator xBtnAnim;

     public void OnPointerEnter(PointerEventData eventData)
     {
         xBtnAnim.SetTrigger("Highlighted");
     }
     
     public void OnPointerExit(PointerEventData eventData)
     {
          
     }
}
