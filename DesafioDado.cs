//Bom dia!

//Desafio: Jogo de dados
//Descrição: O objetivo é criar um jogo simples onde dois jogadores podem
//jogar dados e a aplicação informa qual dos jogadores tirou o maior número.
//Regras de criação:
//★ Ao rodar a aplicação deve-se perguntar o nome dos dois jogadores.
//★ O jogo deve guardar o nome dos dois jogadores e não pode aceitar
//nomes iguais.
//★ O jogo terá 3 rodadas, o jogador que tirar o maior número no dados na
//maioria das jogadas vence a partida.
//
//★ Em caso de empate nenhum jogador faz pontos.
//★ A cada rodada a aplicação deve mostrar quem foi o vencedor.
//★ Um placar deve ser exibido a cada rodada para que os jogadores
//acompanhem os resultados. Exemplo: “Julia: 0 pontos” “Magna: 2
//pontos”.
//★ Ao final da terceira rodada a aplicação deve informar quem foi o
//vencedor ou se foi um empate.

using System;

public class Exercicio2
{
	public static void Main()
	{
		string user1 = " ", user2 = " ", resp="S";
		int dado1, dado2 , somaDado1 = 0, somaDado2 = 0, i , qntRdd;
		Random dado = new();
        while (resp == "S" || resp == "s") 
		{ 
			while (user1 == user2) 
			{
				Console.WriteLine("================================");
				Console.WriteLine("Insira o nome do Jogador 1: ");
				user1 = Console.ReadLine();
				Console.WriteLine("================================");
				Console.WriteLine("Insira o nome do Jogador 2: ");
				user2 = Console.ReadLine();
				Console.WriteLine("================================");
				Console.Clear();
			}
			Console.WriteLine("================================");
			Console.WriteLine("Escolha o numero de rodadas: ");
			qntRdd = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("================================");
			Console.WriteLine("Rolem os dados !!");
			Console.WriteLine("================================");
			
			for ( i = 1; i <= qntRdd; i++)
			{
				Console.WriteLine("Rodada " + i);
				Console.WriteLine(user1 + ": " + somaDado1 + " pontos  || " + user2 + ": " + somaDado2 + " pontos.");
				Console.WriteLine("======================================");
				Thread.Sleep(3000);
				dado1 = dado.Next(1, 6);
				Console.WriteLine(user1 + " jogou os dados: " + dado1);
				Console.WriteLine("======================================");
				Thread.Sleep(3000);
				dado2 = dado.Next(1, 6);
				Console.WriteLine(user2 + " jogou os dados: " + dado2);
				Console.WriteLine("======================================");
				Thread.Sleep(3000);
	
				if (dado1 > dado2) 
	            {
					Console.WriteLine(user1 + " ganhou a rodada.");
					somaDado1++;
	            }
				else if (dado2 > dado1)
	            {
					Console.WriteLine(user2 + " ganhou a rodada.");
					somaDado2++;
	            }
				else
	            {
					Console.WriteLine("Rodada de empate.");
	            }
				Thread.Sleep(3000);
				Console.Clear();
			}
			if (somaDado1 == somaDado2)
			{
				Console.WriteLine("Empate !!!!");
			}
			else if (somaDado1 <= somaDado2)
			{
				Console.WriteLine(user2 + " foi o grande vencedor da partida !!"); //Comentario
			}
			else
			{
				Console.WriteLine(user1 + "  foi o grande vencedor da partida !!");
			}
			Console.WriteLine("Quer jogar denovo?(S para sim e n para não)");
			resp = Console.ReadLine();
			somaDado1 = 0; 
			somaDado2 = 0;
			Console.Clear();
		}
	}

    private static Random Random()
    {
        throw new NotImplementedException();
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}
