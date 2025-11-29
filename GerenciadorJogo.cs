using System.Collections.Generic;
using UnityEngine;

public class GerenciadorJogo : MonoBehaviour
{
    private List<Personagem> personagens;

    public GerenciadorJogo()
    {
        personagens = new List<Personagem>();
    }

    public void AdicionarPersonagem(Personagem personagem)
    {
        personagens.Add(personagem);
        Debug.Log($"Personagem {personagem.Nome} adicionado ao jogo!");
    }

    public void IniciarBatalha()
    {
        Debug.Log("=== BATALHA INICIADA ===");

        foreach (var personagem in personagens)
        {
            personagem.Apresentar();
        }
    }

    public void ListarPersonagens()
    {
        Debug.Log("=== PERSONAGENS NO JOGO ===");
        foreach (var personagem in personagens)
        {
            string status = personagem.EstaVivo ? "Vivo" : "Morto";
            Debug.Log($"{personagem.Nome} - N�vel {personagem.Nivel} - {status}");
        }
    }
}