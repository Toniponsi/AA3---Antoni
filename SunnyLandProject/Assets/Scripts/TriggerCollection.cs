using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerCollection : MonoBehaviour
{
    
    [Header("Events")]
    [Space]
    public UnityEvent OnCollectEvent;

    bool collected = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // In a 2D game, this method is called slightly different,
    // as you can see ... 
    void OnCollisionEnter2D(Collision2D collision) {
        if (!collected) {
            collected = true;
             OnCollectEvent.Invoke();
            Destroy(gameObject);    
        }            
    }
}
