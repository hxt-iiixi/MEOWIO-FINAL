using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BTNSounds : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Image Image;
    [SerializeField] private Sprite _default;
    [SerializeField] private AudioClip _compressed, _uncompressed;
    [SerializeField] private AudioSource source;

    public void OnPointerDown(PointerEventData eventData)
    {
        Image.sprite = _default;
        source.PlayOneShot(_compressed);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        
    }
 

}
 