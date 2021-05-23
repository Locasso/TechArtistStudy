using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Highlighted : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler
{
     [Header("Animator do Objeto")]
     [SerializeField] private Animator objAnim;
     [Header("Strings de controle de animação")]
     [SerializeField] private string pointerEnter;
     [SerializeField] private string pointerExit;

     public void OnPointerEnter(PointerEventData eventData)
     {
         objAnim.SetTrigger(pointerEnter);
     }
     
     public void OnPointerExit(PointerEventData eventData)
     {
          objAnim.SetTrigger(pointerExit);
     }
}
