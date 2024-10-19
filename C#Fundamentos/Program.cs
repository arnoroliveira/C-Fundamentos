using C_Fundamentos.Common.Models;

List<string> listaString = new List<string>();
listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

for (int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição N° {contador} - {listaString}");
}









// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 50;
// arrayInteiros[2] = 64;


// // Console.WriteLine ("Percorrendo o Array com o FOR");

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
// }


// Console.WriteLine("Percorrendo o Array com FOREACH");

// int contadorForeach = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição N° {contadorForeach} - {valor}");
//     contadorForeach++;
// }








// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Arnor";
// pessoa1.Idade = 22;
// pessoa1.Apresentar();










//Menu Interativo
// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de Cliente");
//             break;
//         case "2":
//             Console.WriteLine("2 - Busca de cliente");
//             break;
//         case "3":
//             Console.WriteLine("3 - Apagar cliente");
//             break;
//         case "4":
//             Console.WriteLine("4 - Encerrar");
//             exibirMenu = false;
//             break;
//         default:
//             Console.WriteLine("Opção Inválida");
//             break;
//     }
// }

// Console.WriteLine("O programa se encerrou");




// int soma = 0;
// int numero = 0;

// do 
// {
//     Console.WriteLine("Digite um numero (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while (numero != 0); 

// Console.WriteLine($"Total da soma dos numeros digitados é: {soma}");





// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"Execução: {numero} x {contador} = {numero * contador}");
//     contador++;
// }





// int numero = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }







// Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(28, 14);
// calc.Multiplicar(22, 11);
// calc.Dividir(2, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Cosseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(64);



// bool iphone15Pro = false;
// bool cliente = false;

// if (iphone15Pro && cliente == true)
// {
//     Console.WriteLine("Pode Comprar!");
// }
// else if (iphone15Pro || cliente == true)
// {
//     Console.WriteLine("Pode Comprar");
// }

// else
// {
//     Console.WriteLine("Não pode comprar!");
// }






// bool medicoPresente = true;
// bool vagaDisponivel = false;

// if (medicoPresente && vagaDisponivel == true)
// {
//     Console.WriteLine("Terá Consulta!!");
// }

// else
// {
//     Console.WriteLine("Não há vaga. Deve reagendar!!!");
// }





// bool possuiPresencaMinima = true;
// double Media = 7;

// if (possuiPresencaMinima && Media >=7)
// {
//     Console.WriteLine("Aprovado");
// }

// else
// {
//     Console.WriteLine("Reprovado");
// }




// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada Liberada");
// }
// else 
// {
//     Console.WriteLine("Entrada Não Liberada");
// }




// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }




// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||  
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else 
// {
//     Console.WriteLine("Não é uma vogal");
// }





// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }

// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }

// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }

// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }

// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }

// else
// {
//     Console.WriteLine("Não é uma Vogal");
// }








// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 &&quantidadeEmEstoque >= quantidadeCompra;


// Console.WriteLine($"Quantidade em Estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade Compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda Inválida");
// }

// else if (possivelVenda)
// {
//     Console.WriteLine("Venda Realizada");
// }
// else
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque");
// }






// int a = Convert.ToInt32("5");
// int b = 20;

// int c = a + b;
// Console.WriteLine(c);




// int a = 10;
// int b = 20;

// int c = a + b;
// Console.WriteLine(c);



// DateTime dataAtual = DateTime.Now.AddYears(6);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// string apresentacao = "Olá, meu nome é Arnor";

// int quantidade = 1;

// double altura = 1.8;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("valor da variável quantidade: " + quantidade);
// Console.WriteLine("valor da variável altura:" + altura);
// Console.WriteLine("valor da variável preco: " + preco);
// Console.WriteLine("valor da condicao: " + condicao);


// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Arnor";
// pessoa1.Idade = 22;
// pessoa1.Apresentar();