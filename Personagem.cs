using UnityEngine;

public class Personagem : MonoBehaviour
{
    // Campos (atributos)

    protected string nome;

    protected int nivel;

    protected int pontosVida;

    protected int pontosVidaMaximos;

    // Construtor

    public Personagem (string nome, int nivel, int pontosVidaMaximos)
    
    {
        this.nome = nome;
        this.nivel = nivel;
        this.pontosVidaMaximos = pontosVidaMaximos;
        this.pontosVida = pontosVidaMaximos;
    }
   
    // Métodos
    public virtual void Apresentar()
    
    {
        Debug.Log($"Eu sou {nome}, nivel {nivel}!");
    }

    public void ReceberDano(int dano)
    
    {
        pontosVida -= dano;
        if(pontosVida < 0) pontosVida = 0;
        Debug.Log($"{nome} recebeu {dano} de dano. Vida:{pontosVida}/{pontosVidaMaximos}");
    }

    public void Curar(int cura)

    {
        pontosVida += cura;
        if (pontosVida > pontosVidaMaximos) pontosVida = pontosVidaMaximos;
        Debug.Log($"{nome} curou {cura} pontos. Vida: {pontosVida}/{pontosVidaMaximos}");
    }

    // Propriedades (getters).
    public string Nome => nome;
    public int Nivel => nivel;
    public int PontosVida => pontosVida;
    public bool EstaVivo => pontosVida > 0;
    
}