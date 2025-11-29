using UnityEngine;

public class ExemploInstaciacao : MonoBehaviour
{
    void Start()
    {
        // INTANCIANDO OBJETOS A PARTIR DAS CLASSES

        // 1. cRIANDO UM GERENCIADOR DE JOGO
        GerenciadorJogo gerenciador = new GerenciadorJogo();

        // 2. Criando Personagens (instanciando objetos)
        Guerreiro guerreiro = new Guerreiro("Thor", 5, 15);
        Mago mago = new Mago("Merlin", 3, 20);
        Guerreiro guerreiro2 = new Guerreiro("Conan", 4, 12);

        // 3.Adicionando personagens ao gerenciador
        gerenciador.AdicionarPersonagem(guerreiro);
        gerenciador.AdicionarPersonagem(mago);
        gerenciador.AdicionarPersonagem(guerreiro2);

        // 4. Iniciando a Batalha 
        gerenciador.IniciarBatalha();

        //5.Simulando uma Batalha
        Debug.Log("\n--- AÇOES DA BATALHA ----");

        // Guerreiro ataca Mago
        guerreiro.Atacar(mago);

        // Mago Lança feitiço no Guerreiro
        mago.LancarFeitico(guerreiro);

        // Segundo guerreiro ataca o primeiro
        guerreiro2.Atacar(guerreiro);

        // Mago Cura
        mago.Curar(25);

        // Lista estado Final
        gerenciador.ListarPersonagens();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
