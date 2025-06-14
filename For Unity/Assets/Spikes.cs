using UnityEngine;

public class Spikes : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        HeroKnight hero = collision.GetComponent<HeroKnight>();

        if (hero != null)
        {
            hero.Die();
        }
    }
}
