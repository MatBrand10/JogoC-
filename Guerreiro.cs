using UnityEngine;

public class Guerreiro : Personagem
{
    private int forca;
    private int defesa;
    public Guerreiro(string nome, int nivel, int forca)
        : base(nome, nivel, 100 + (nivel * 20)) // Vida base + bónus por nível
       
    {
        this.forca = forca;
        this.defesa = 10 + (nivel * 2);
    }

    // Sobrescrevendo método da classe pai
    public override void Apresentar()
    {
        Debug.Log($"Eu sou {nome}, o Guerreiro nível {nivel}! Força: {forca}");
    }

    // Método específico do Guerreiro
    public void Atacar(Personagem alvo)
    {
        int dano = forca * 2;
        Debug.Log($"{nome} ataca {alvo.Nome} causando {dano} de dano!");
        alvo.ReceberDano(dano);
    }

    public void Defender()
    {
        defesa += 5;
        Debug.Log($"{nome} assume posição defensiva!Defesa: {defesa}");
    }
}
