//Criar um programa de chamada que permita registrar presença ou falta para os alunos e que também possibilite a consulta a um determinado aluno para saber se está presente ou com falta.
using System;
class MainClass {
  public static void Main (string[] args) {
    string[] aluno = new string[10];
    bool[] presenca = new bool[10];
    bool escolheuSair = false;
    int opcao = 0, a = 0;
    

    for(int x = 0; x<=9; x++){ //preenchendo presenca
      presenca[x] = false;
    }
    for(int x = 0; x<=9; x++){ //preenchendo aluno
      Console.Write($"Insira o nome do {x+1}° aluno: ");
      aluno[x] = Console.ReadLine();
      Console.Clear();
    }

    while(escolheuSair!=true){
      MostrarMenu();
      opcao = int.Parse(Console.ReadLine());
      Console.Clear();
      switch(opcao){
        default: //opção não existente
          Console.WriteLine("Essa opção não existe! Pressione ENTER para VOLTAR.");
          Console.ReadLine();
          Console.Clear();
        break;

        case 0: //sair
          escolheuSair = true;
          Console.Clear();
        break;

        case 1:
          Console.WriteLine("===========================\n");
          for(int j = 0; j<=9; j++){
            Console.Write($"[{j}] - {aluno[j]}\n");
          }
          Console.WriteLine("===========================\n");
          a = int.Parse(Console.ReadLine());
          Console.Clear();
          while(a<0 || a>9){ //evitando o erro
            Console.Write("O valor inserido é inválido! Selecione de 0 a 9: ");
            a = int.Parse(Console.ReadLine());
            Console.Clear();
          }
          presenca[a] = MarcarPresenca(aluno, presenca, a);
        break;

        case 2:
          MostrarLista(aluno, presenca);
        break;
      }
    }
    
  }

  static void MostrarMenu(){
    Console.WriteLine("====================================\n[1] - Marcar presença/falta\n[2] - Lista de presença\n[0] - Sair\n====================================\n");
  }

  static bool MarcarPresenca(string[] aluno, bool[] presenca, int x){
    int y = 0;
    Console.WriteLine($"{aluno[x]} está presente? [1] - Sim | [2] - Não ");
    y = int.Parse(Console.ReadLine());
    Console.Clear();
    return y == 1 ? true : false;

  }

  static void MostrarLista(string[] aluno, bool[] presenca){
    Console.Clear();
     Console.WriteLine("===========================\n");
      for(int j = 0; j<=9; j++){
        Console.Write($" {aluno[j]} | ");
        if(presenca[j]==true){
          Console.Write("PRESENTE.\n");
        }else{
          Console.Write("FALTOU.\n");
        }
      }
    Console.WriteLine("===========================\n");
    Console.ReadLine();
    Console.Clear();
  }
}
