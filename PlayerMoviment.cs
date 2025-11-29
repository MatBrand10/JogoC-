using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    [SerializeField] private float velocidade = 7;
    private Rigidbody2D rb;
    private float direcao; // pode ser -1 0 1
    [SerializeField] private float salto = 7;
    [SerializeField] private bool pulando = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // update is called once per frame

    void update()
    {
        direcao = Imput.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(direcao * velocidade, rb.linearVelocity.y);

        if (direcao > 0)
        {
            transform.localScale = new Vector2(1f, 1f);
        }
        else if (direcao < 0)
        {
            transform.localScale = new Vector2(-1f, 1f);    
        }
        if (Imput.GetButtonDown("Jump") && pulando == false)
        {
            rb.linearVelocityY = salto;
            pulando = true;
        }

    }
    private  void  OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if(collisionInfo.gameObject.CompareTag("Chao"))
     {
        pulando = false;
     }   
    }
}
