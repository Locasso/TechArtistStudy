using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Highlighted : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler
{
     [Header("Animator do Objeto")]
     [SerializeField] private Animator objAnim; //Animator de referência para setar triggers.

     [Header("Strings de controle de animação")]
     [SerializeField] private string pointerEnter; //String para ativar o trigger.
     [SerializeField] private string pointerExit; //String desativar o trigger.

     //Irá chamar toda vez que o mouse entrar em contato com o objeto desta classe.
     public void OnPointerEnter(PointerEventData eventData)
     {
         objAnim.SetTrigger(pointerEnter);
     }
     
     //Irá chamar toda vez que o mouse sair de contato com o objeto desta classe.
     public void OnPointerExit(PointerEventData eventData)
     {
          objAnim.SetTrigger(pointerExit);
     }
}
