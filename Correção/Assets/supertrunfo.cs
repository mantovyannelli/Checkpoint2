using UnityEngine;

public class supertrunfo : MonoBehaviour
{
    int[] j1 = new int[3];
    int[] j2 = new int[3];

    string[] atributos = new string[] { "F", "V", "I" };
    int rodadas = 0;

    string[] historico = new string[5];

    bool jogando = true;


    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && rodadas < 5)
        {
           
            //define o atributo da rodada
            string atributoatual = atributos[Random.Range(0, atributos.Length)];

            //cria as cartas da rodada (cada carta será criada na sua rodada)
            for (int i = 0; i < 3; i++)
            {
                j1[i] = Random.Range(1, 10);
                j2[i] = Random.Range(1, 10);
            }

            print("Atributo da rodada: " + atributoatual);
            print("Carta J1: " + "F= " + j1[0] + " V= " + j1[1] + " I= "+ j1[2]);
            print("Carta J2: " + "F= " + j2[0] + " V= " + j2[1] + " I= " + j2[2]);

            //Verifica o resultado da rodada
            if (atributoatual == "F")
            {
                if (j1[0] == j2[0])
                {
                    historico[rodadas] = "Empate";
                    print("Empate");
                }
                else
                {
                    if (j1[0] > j2[0])
                    {
                        historico[rodadas] = "Jogador 1 vence a rodada";
                        print("Jogador 1 vence a rodada");
                    }
                    else
                    {
                        print("Jogador 2 vence a rodada");
                    }
                }
            }

            else if (atributoatual == "V")
            {
                if (j1[1] == j2[1])
                {
                    historico[rodadas] = "Empate";
                    print("Empate");
                }
                else
                {
                    if (j1[1] > j2[1])
                    {
                        historico[rodadas] = "Jogador 1 vence a rodada";
                        print("Jogador 1 vence a rodada");
                    }
                    else
                    {
                        print("Jogador 2 vence a rodada");
                    }
                }
            }

            else
            {
                if (j1[2] == j2[2])
                {
                    historico[rodadas] = "Empate";
                    print("Empate");
                }
                else
                {
                    if (j1[2] > j2[2])
                    {
                        historico[rodadas] = "Jogador 1 vence a rodada";
                        print("Jogador 1 vence a rodada");
                    }
                    else
                    {
                        print("Jogador 2 vence a rodada");
                    }
                }
            }

            //Registra uma rodada
            rodadas++;

            if (rodadas == 5 && jogando == true)
            {
                jogando = false;
            }

            print("--------------------------------------");
        }

        else if (jogando == false)
        {

            print("Histórico da partida");

            foreach(string h in historico)
            {
                print(h);
            }
        }
    }
}
