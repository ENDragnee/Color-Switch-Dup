using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playeR : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public SpriteRenderer sp;
    public string color;

    public Color red=Color.red;
    public Color cyan=Color.cyan;
    public Color magenta=Color.blue;
    public Color yellow=Color.yellow;

    public float magitiude=5f;

    private void Start()
    {
        sp.color = red;
        color="red";
    }

    private void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.up * magitiude;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent<obsT>(out obsT obs))
        {
            if(obs.color!=color)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

        if(collision.gameObject.TryGetComponent<colorSwitcher>(out colorSwitcher switcher))
        {
            sp.color = switcher.color;
            color = switcher.colorName;
            Destroy(switcher.gameObject);
        }
    }
}
