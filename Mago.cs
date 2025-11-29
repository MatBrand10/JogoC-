using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Mago : Personagem
{
    private int inteligencia;
    private int mana;
    private int manaMaxima;

    public Mago(string nome, int nivel, int inteligencia)
        : base(nome, nivel, 60 + (nivel * 10))
    {
        this.inteligencia = inteligencia;
        this.manaMaxima = 50 + (nivel * 15);
        this.mana = manaMaxima;
    }

    public override void Apresentar()
    {
        Debug.Log($"Eu sou {nome}, o Mago nível {nivel}! INT: {inteligencia}");
    }

    public void LancarFeitico(Personagem alvo)
    {
        if (mana >= 10)
        {
            int dano = inteligencia * 3;
            mana -= 10;
            Debug.Log($"{nome} lança um feitiço em {alvo.Nome}! Dano: {dano}");
            alvo.ReceberDano(dano);
        }
        else
        {
            Debug.Log($"{nome} não tem mana suficiente!");
        }
    }

    public void Meditar()
    {
        mana = manaMaxima;
        Debug.Log($"{nome} medita e recupera toda a mana!");
    }
}