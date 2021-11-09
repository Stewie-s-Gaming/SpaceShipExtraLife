using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOnTrigger2DPlayer : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [SerializeField] int hitPoints = 3;
    const int hitLimit = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            GameObject heart = GameObject.Find("Heart" + hitPoints);
            Destroy(heart);
            hitPoints--;
            if (hitPoints == hitLimit)
            {
                Destroy(this.gameObject);
                Destroy(other.gameObject);
            }
        }
    }

    private void Update()
    {
        /* Just to show the enabled checkbox in Editor */
    }
}
