using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLinguagemDeProgramacaoEstruturada
{
    
    class Program
    {

        static void Main(string[] args)
        {
            //Chama o metodo Menu
            Menu1();
        }

        static void Menu1()//MENU DE QUESTÕES
        {
            //Criação do menu
            Console.Title = "Projeto Linguagem de Programação Estruturada"; //Titulo do console
            Console.ForegroundColor = ConsoleColor.White; //Cor da letra
            Console.BackgroundColor = ConsoleColor.DarkBlue; //Cor de fundo do background
            Console.Clear(); //Limpa Tela
            Console.SetWindowSize(80, 20); //Largura, altura da janela do console
            //Console.BufferHeight = 20; //Buffer de altura do console
            Console.BufferWidth = 80; //Buffer de largura do console
            Console.WriteLine("\n           *********************************************************");
            Console.WriteLine("\n           |          Seja bem-vindo ao resolvendo questões        |");
            Console.WriteLine("\n           |                                                       |");
            Console.WriteLine("\n           |  Questão 1  |  Questão 2  |  Questão 3  |  Questão 4  |");
            Console.WriteLine("\n           |  Questão 5  |  Questão 6  |  Questão 7  |  Questão 8  |");
            Console.WriteLine("\n           |  Questão 11 |  Questão 12 |  Questão 13 |  Questão 14 |");
            Console.WriteLine("\n           |  Questão 15 |  Questão 16 |  Questão 17 |  Questão 18 |");
            Console.WriteLine("\n           *********************************************************");
            Console.Write("\n           |  Digite o número da questão desejada e tecle enter: ");
            String opcao = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            //Condicionais de testes da opção desejada
            if (opcao == "1")
            {
                Questao1();                
            }
            else if (opcao == "2")
            {
                Questao2();
            }
            else if (opcao == "3")
            {
                Questao3();
            }
            else if (opcao == "4")
            {
                Questao4();
            }
            else if (opcao == "5")
            {
                Questao5();
            }
            else if (opcao == "6")
            {
                Questao6();
            }
            else if (opcao == "7")
            {
                Questao7();
            }
            else if (opcao == "8")
            {
                Questao8();
            }
            else if (opcao == "11")
            {
                Questao11();
            }
            else if (opcao == "12")
            {
                Questao12();
            }
            else if (opcao == "13")
            {
                Questao13();
            }
            else if (opcao == "14")
            {
                Questao14();
            }
            else if (opcao == "15")
            {
                Questao15();
            }
            else if (opcao == "16")
            {
                Questao16();
            }
            else if (opcao == "17")
            {
                Questao17();
            }
            else if (opcao == "18")
            {
                Questao18();
            }
            else
            {
                Console.WriteLine("\n A opção digitada não existe! ");
                Console.ReadKey();
                Menu1();
            }
        }

        static void FimDaExecucaoDaQuestao() //Pergunta se o usuario deseja realizar outra operação, ir para o menu ou sair do programa.
        {
            String PerguntaAoUsuario;
            Console.ForegroundColor = ConsoleColor.Yellow; //Cor da letra
            Console.WriteLine("\n ..............................");
            Console.WriteLine("\n  Ir para o MENU ----------> 1");
            Console.WriteLine("\n  Sair do Programa --------> 2");
            Console.Write("\n  Digite a opção desejada: ");
            PerguntaAoUsuario = Console.ReadLine();
            if(PerguntaAoUsuario == "1")
            {
                Menu1();
            }
            else if(PerguntaAoUsuario == "2"){
                //Fecha o console
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n  Digite uma opção válida!");
                FimDaExecucaoDaQuestao();
            }
        }

        static void Questao1()
        {
            /* Questão 1. Escrever um algoritmo que leia o nome e as três notas obtidas por um aluno durante o semestre.
               Calcular a sua média (aritmética), informar o nome e sua menção aprovado (media >= 7),
               Reprovado (media <= 5) e Recuperação (media entre 5.1 a 6.9). */

            String nomeDoAluno = "", suaSituacao = "";
            Double nota01 = 0, nota02 = 0, nota03 = 0, mediaDoAluno = 0;
            Console.WriteLine("\n Questão 1");
            Console.Write("\n Qual é o seu nome? ");
            nomeDoAluno = Console.ReadLine();
            Console.Write("\n Qual foi a primeira nota de sua prova? ");
            nota01 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n Qual foi a segunda nota de sua prova? ");
            nota02 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n Qual foi a terceira nota de sua prova? ");
            nota03 = Convert.ToDouble(Console.ReadLine());
            mediaDoAluno = (nota01 + nota02 + nota03) / 3;
            if (mediaDoAluno >= 7)
            {
                suaSituacao = "aprovado.";
            }
            else
            {
                if (mediaDoAluno <= 5)
                {
                    suaSituacao = "reprovado.";
                }
                else
                {
                    if (mediaDoAluno >= 5.1 && mediaDoAluno <= 6.9)
                    {
                        suaSituacao = "na recuperação.";
                    }
                }
            }
            Console.WriteLine("\n " + nomeDoAluno + " sua media é: " + mediaDoAluno + " e você esta " + suaSituacao);
            //Fim da Questão 1
            // Pergunta se o usuario deseja, ir para o menu ou sair do programa.
            FimDaExecucaoDaQuestao();
        }

        static void Questao2()
        {
            /* Questão 2.   Escrever um algoritmo que leia dois valores inteiros distintos e informe qual é o maior. */

            Int64 Valor1 = 0, Valor2 = 0;
            Console.WriteLine("\n Questão 2");
            Console.Write("\n Informe um valor inteiro: ");
            Valor1 = Convert.ToInt64(Console.ReadLine());
            Console.Write("\n Informe outro valor inteiro: ");
            Valor2 = Convert.ToInt64(Console.ReadLine());
            if(Valor1 > Valor2)
            {
                Console.WriteLine("\n O maior valor é: " + Valor1);
            }
            else if(Valor1 < Valor2)
            {
               Console.WriteLine("\n O maior valor é: " + Valor2);
            }
            else if (Valor1 == Valor2)
            {
               Console.WriteLine("\n Os valores são iguais: " + Valor1 + " = " + Valor2);
            }
            // Pergunta se o usuario deseja, ir para o menu ou sair do programa.
            FimDaExecucaoDaQuestao();
        }

        static void Questao3()
        {
            /*  Questão 3. Elabore um algoritmo que leia do teclado o sexo de uma pessoa. Se o sexo digitado
                for M ou F, escrever na tela “Sexo válido!”. Caso contrário, informar “Sexo inválido!”   */

            Console.WriteLine("\n Questão 3");
            Console.Write("\n Digite seu sexo - Feminino -> F | M <- Masculino : ");
            String generoSexual = Console.ReadLine();
            if (generoSexual == "F" || generoSexual == "f" || generoSexual == "M" || generoSexual == "m")
            {
                Console.WriteLine("\n Sexo válido!");
            }
            else
            {
                Console.WriteLine("\n Sexo inválido!");
            }
            //Fim da Questão 3
            // Pergunta se o usuario deseja, ir para o menu ou sair do programa.
            FimDaExecucaoDaQuestao();
        }

        static void Questao4()
        {
            /*  Questão 4. Faça um programa que receba dois números e execute as operações listadas a seguir de acordo com a escolha do usuário.
                
                ESCOLHA DO USUÁRIO      OPERAÇÂO ARITMÉTICAS
                    -> 1                MÉDIA ENTRE OS NÚMEROS DIGITADOS
                    -> 2                DIFERENÇA DO MAIOR PELO MENOR
                    -> 3                PRODUTO ENTRE OS NÚMEROS DIGITADOS
                    -> 4                DIVISÃO DO PRIMEIRO PELO SEGUNDO

                Se a opção digitada for invalida, mostrar uma mensagem de erro e terminar a execução do programa. Lembre-se de que na operação 4
                o segundo número deve ser diferente de zero. */

            double num1, num2;
            string opcao;
            Console.WriteLine("\n Questão 4 - Realizar operações entre dois números.");
            Console.Write("\n Informe o primeiro número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Informe o segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("\n O número deve ser diferente de 0.");
                Console.Write("\n Informe o segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            }
            Console.Write("\n Selecione de 1 a 4 para o que deseja fazer: \n\n 1 - Média entre os números digitados.\n \n 2 - Diferença do maior pelo menor\n \n 3 - Produto entre os números digitados\n \n 4 - Divisão do primeiro pelo segundo\n\n Digite a opção desejada: ");
            opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.WriteLine("\n A média entre os números é de: " + (num1 + num2) / 2);
            }
            else if (opcao == "2" && num1 > num2)
            {
                Console.WriteLine("\n A diferença entre os números é: " + num1 % num2);
            }
            else if (opcao == "2" && num2 > num1)
            {
                Console.WriteLine("\n A diferença entre os números é: " + num2 % num1);
            }
            else if (opcao == "2" && num1 == num2)
            {
                Console.WriteLine("\n A diferença entre os números é: " + +num1 % num2);
            }
            else if (opcao == "3")
            {
                Console.WriteLine("\n O produto entre os números digitados é de: " + num1 * num2);
            }
            else if (opcao == "4")
            {
                Console.WriteLine("\n A divisão do primeiro número pelo segundo é: " + num1 / num2);
            }
            else
            {
                Console.WriteLine("\n Opção selecionada é inválida!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            // Pergunta se o usuario deseja, ir para o menu ou sair do programa.
            FimDaExecucaoDaQuestao();
        }

        static void Questao5()
        {
            // 5. Elabore um algoritmo que leia dois números inteiros e mostre o resultado da diferença do maior valor pelo menor.

            Console.WriteLine("\n Questão 5");
            Int64 valorDeN1 = 0, valorDeN2 = 0, diferencaDosValores = 0; //<- Variaveis
            Console.WriteLine("\n Informe dois números inteiros para calcular a diferença do maior pelo menor.");
            Console.Write("\n Informe N1: ");
            valorDeN1 = Convert.ToInt64(Console.ReadLine());
            Console.Write("\n Informe N2: ");
            valorDeN2 = Convert.ToInt64(Console.ReadLine());
            if (valorDeN1 > valorDeN2)
            {
                diferencaDosValores = valorDeN1 - valorDeN2;
            }
            else
            {
                if (valorDeN2 > valorDeN1)
                {
                    diferencaDosValores = valorDeN2 - valorDeN1;
                }
                else
                {
                    if (valorDeN2 == valorDeN1)
                    {
                        diferencaDosValores = valorDeN1 - valorDeN2;
                    }
                }
            }
            Console.WriteLine("\n A diferença dos valores foi: " + diferencaDosValores);
            //Fim da Questão 5
            // Pergunta se o usuario deseja, ir para o menu ou sair do programa.
            FimDaExecucaoDaQuestao();
        }

        static void Questao6()
        {
            /* Questão 6. Uma empresa decide dar um aumento de 30 % aos funcionários com salários inferiores a
               R$ 500,00. Faça um programa que receba o salário do funcionário e mostre o valor do salário
               reajustado ou uma mensagem, caso o funcionário não tenha direito ao aumento. */

            Double salarioDoFuncionario = 0, reajusteDeSalario = 0;
            Console.WriteLine("\n Questão 6 - Reajuste de Salário.");
            Console.Write("\n Digite seu salário: R$");
            salarioDoFuncionario = Convert.ToDouble(Console.ReadLine());
            if(salarioDoFuncionario < 500)
            {
                reajusteDeSalario = (salarioDoFuncionario * 30 / 100);
                salarioDoFuncionario = salarioDoFuncionario + reajusteDeSalario;
                Console.Clear();
                Console.WriteLine("\n -> Seu salário foi reajustado em 30% .");
                Console.WriteLine("\n -> Salário antigo de: R$" + (salarioDoFuncionario - reajusteDeSalario));
                Console.WriteLine("\n -> Reajuste [30%] de: R$" + reajusteDeSalario);
                Console.WriteLine("\n -> Novo salário é de: R$" + salarioDoFuncionario);
            }
            else
            {
                Console.WriteLine("\n Seu salário não possui reajuste neste momento.");
            }
            // Pergunta se o usuario deseja, ir para o menu ou sair do programa.
            FimDaExecucaoDaQuestao();
        }

        static void Questao7()
        {
            /* Questão 7.Elabore um algoritmo para ler 4 notas de um aluno (de 1 a 10) e o sexo(M ou F)
            do aluno.Após calcular a média das notas, apresentar a mensagem: Se for masculino,
            o resultado deverá ser precedido de “Caro aluno, seu resultado é: “. Se for feminino,
            o resultado deverá ser precedido de “Cara aluna, seu resultado é: “. Se o aluno tiver
            obtido média maior ou igual a 6 está “Aprovado”, caso contrário, “Reprovado”. */

            Console.WriteLine("\n Questão 7");
            Double primeraNota = 0, segundaNota = 0, terceiraNota = 0, quartaNota = 0, calculadorDeMedia = 0;//<- Variaveis
            String sexoAluno, situacaoDoAluno;//<- Variaveis
            Console.WriteLine("\n Calculador de média de aluno");
            Console.Write("\n Informe sua primeira nota: ");
            primeraNota = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n Informe sua segunda nota: ");
            segundaNota = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n Informe sua terceira nota: ");
            terceiraNota = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n Informe sua quarta nota: ");
            quartaNota = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n Qual é o seu sexo? (F/M) : ");
            sexoAluno = Console.ReadLine();
            calculadorDeMedia = (primeraNota + segundaNota + terceiraNota + quartaNota) / 4;
            if (sexoAluno == "F" || sexoAluno == "f")
            {
                sexoAluno = "Cara aluna";
            }
            else
            {
                if (sexoAluno == "M" || sexoAluno == "m")
                {
                    sexoAluno = "Caro aluno";
                }
            }
            if (calculadorDeMedia >= 6)
            {
                situacaoDoAluno = "Aprovado.";
            }
            else
            {
                situacaoDoAluno = "Reprovado.";
            }
            Console.WriteLine("\n " + sexoAluno + ", seu resultado é " + calculadorDeMedia + " e você esta " + situacaoDoAluno);
            //Fim da Questão 7
            // Pergunta se o usuario deseja, ir para o menu ou sair do programa.
            FimDaExecucaoDaQuestao();
        }

        static void Questao8()
        {
            /* Questão 8. A escola “APRENDER” faz o pagamento de seus professores por hora/aula.
                Faça um algoritmo que calcule e exiba o salário de um professor.
                Sabe-se que o valor da hora/aula segue a tabela abaixo:
                a. Professor Nível 1 R$12,00 por hora/aula
                b. Professor Nível 2 R$17,00 por hora/aula
                c. Professor Nível 3 R$25,00 por hora/aula */

            double horasTrabalhadas, salarioTotal;
            string nivelProfessor;
            Console.WriteLine("\n Questão 8 \n\n Calcular o salário de um professor da escola APRENDER.");
            Console.Write("\n Informe o seu nível hierarquico: ");
            nivelProfessor = Console.ReadLine();
            Console.Write("\n Informe a quantidade de horas trabalhadas no mês: ");
            horasTrabalhadas = Convert.ToDouble(Console.ReadLine());
            if (nivelProfessor == "1")
            {
                salarioTotal = 12.0 * horasTrabalhadas;
                Console.WriteLine("\n O seu salário no mês é de: R${0}", salarioTotal);
            }
            else if (nivelProfessor == "2")
            {
                salarioTotal = 17.0 * horasTrabalhadas;
                Console.WriteLine("\n O seu salário no mês é de: R${0}", salarioTotal);
            }
            else if (nivelProfessor == "3")
            {
                salarioTotal = 25.0 * horasTrabalhadas;
                Console.WriteLine("\n O seu salário no mês é de: R${0}", salarioTotal);
            }
            // Pergunta se o usuario deseja, ir para o menu ou sair do programa.
            FimDaExecucaoDaQuestao();
        }

        static void Questao11()
        {
            /* Questão 11. Faça um algoritmo que leia um número e mostre uma mensagem
               indicando se este número é par ou ímpar e se é positivo ou negativo. */

            Console.WriteLine("\n Questão 11");
            Int64 verificandoNumero = 0;
            String tipoParImpar, tipoPositivaNegativo;
            Console.WriteLine("\n Verifica se número é positivo ou negativo e se ele é par ou ímpar");
            Console.Write("\n Digite um número: ");
            verificandoNumero = Convert.ToInt64(Console.ReadLine());
            if ((verificandoNumero % 2) == 0)
            {
                tipoParImpar = "par";
            }
            else
            {
                tipoParImpar = "ímpar";
            }
            if (verificandoNumero > 0)
            {
                tipoPositivaNegativo = "positivo.";
            }
            else
            {
                tipoPositivaNegativo = "negativo.";
            }
            Console.WriteLine("\n Número " + tipoParImpar + " e ele é " + tipoPositivaNegativo);
            //Fim da Questão 11
            // Pergunta se o usuario deseja, ir para o menu ou sair do programa.
            FimDaExecucaoDaQuestao();
        }

        static void Questao12()
        {
            /* Questão 12. Dados três valores X, Y e Z, verificar se eles podem ser os comprimentos dos
               lados de um triângulo e,se forem verificar se é um triângulo equilátero, isósceles ou escalenos.
               Se eles não formarem um triângulo, escrever a mensagem. Considere as seguintes propriedades:
               a. O comprimento de cada lado em um triângulo é menor que a soma dos outros dois lados;
               b. Equiláteros: tem os comprimentos dos três lados iguais;
               c. Isósceles: tem os comprimentos de dois lados iguais;
               d. Escaleno: tem os comprimentos dos três lados diferentes. */

            double valorX, valorY, valorZ;

            Console.WriteLine("\n Questão 12 - Realizar calculo de um triângulo.");
            Console.Write("\n Informe o valor de X: ");
            valorX = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n Informe o valor de Y: ");
            valorY = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n Informe o valor de Z: ");
            valorZ = Convert.ToDouble(Console.ReadLine());

            // Condição no qual verifica se os valores pertencem a um triângulo, como pedido na questão
            if (valorX > valorY + valorZ || valorY > valorX + valorZ || valorZ > valorX + valorY)
            {
                Console.WriteLine("\n Os valores digitados não pertencem a um triângulo");
            }

            // Condição correspondente a um triangulo equilátero
            else if (valorX == valorY && valorY == valorZ && valorZ == valorX)
            {
                Console.WriteLine("\n Os valores correspondem a um triângulo Equilátero!");
            }
            else if (valorX == valorY || valorY == valorZ || valorZ == valorX)
            {
                Console.WriteLine("\n Os valores correspondem a um triângulo Isósceles!");
            }
            else if (valorX != valorY && valorY != valorZ && valorZ != valorX)
            {
                Console.WriteLine("\n Os valores correspondem a um triângulo Escaleno");
            }
            // Pergunta se o usuario deseja, ir para o menu ou sair do programa.
            FimDaExecucaoDaQuestao();
        }

        static void Questao13()
        {
            /* Questão 13. Construa um algoritmo que calcule o peso ideal de uma pessoa. Dados de entrada: altura e sexo.
               Fórmulas para cálculo do peso:  a.peso ideal de homem = (72,7 x altura) -58 | b.peso ideal da mulher = (62,1 x altura) -44,7 */

            Console.WriteLine("\n Questão 13");
            Double suaAltura = 0, seuPeso = 0;
            String seuSexo;
            Console.Write("\n Qual é a sua altura? ");
            suaAltura = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n Qual é o seu sexo? Homem ou Mulher : ");
            seuSexo = Console.ReadLine();
            if (seuSexo == "Homem" || seuSexo == "homem" || seuSexo == "h" || seuSexo == "H")
            {
                seuPeso = (72.7 * suaAltura) - 58;
            }
            else
            {
                if (seuSexo == "Mulher" || seuSexo == "mulher" || seuSexo == "m" || seuSexo == "M")
                {
                    seuPeso = (62.1 * suaAltura) - 44.7;
                }
                else
                {
                    Console.WriteLine(" Erro, sexo digitado não existe!");
                }
            }
            Console.WriteLine("\n Seu peso é de " + seuPeso + "Kg");
            //Fim da Questão 13
            // Pergunta se o usuario deseja, ir para o menu ou sair do programa.
            FimDaExecucaoDaQuestao();
        }

        static void Questao14()
        {
            /* Questão 14.  Faça um programa que receba a idade de um nadador
               e mostre a sua categoria usando as regras a seguir. */

            int idade;
            Console.WriteLine("\n Questão 14 - Definir categoria de um nadador.");
            Console.Write("\n Informe a sua idade: ");
            idade = Convert.ToInt16(Console.ReadLine());

            if (idade == 5 || idade <= 7)
            {
                Console.WriteLine("\n Você faz parte da categoria Infantil!");
            }

            else if (idade == 8 || idade <= 10)
            {
                Console.WriteLine("\n Você faz parte da categoria Juvenil!");
            }

            else if (idade == 11 || idade <= 15)
            {
                Console.WriteLine("\n Você faz parte da categoria Adolescente!");
            }

            else if (idade == 16 || idade <= 30)
            {
                Console.WriteLine("\n Você faz parte da categoria Adulto!");
            }

            else if (idade > 30)
            {
                Console.WriteLine("\n Você faz parte da categoria Sênior!");
            }
            // Pergunta se o usuario deseja, ir para o menu ou sair do programa.
            FimDaExecucaoDaQuestao();
        }

        static void Questao15()
        {
            /*  Questão 15. Num determinado Estado, para transferências de veículos, o DETRAN cobra uma taxa de 1%
                para carros fabricados antes de 1990 e uma taxa de 1.5% para os fabricados de 1990 em diante,
                taxa esta incidindo sobre o valor de tabela do carro. O algoritmo abaixo lê o ano e o preço
                carro e a seguir calcula e imprime imposto a ser pago. */

            Console.WriteLine("\n Questão 15");
            Double anoDoCarro = 0, valorDoCarro = 0, taxaDeTransferencia = 0;
            Console.WriteLine("\n Transferencia de veículos - DETRAN");
            Console.Write("\n Qual o ano do veículo? ");
            anoDoCarro = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n Qual o valor de tabela do carro? R$");
            valorDoCarro = Convert.ToDouble(Console.ReadLine());
            if (anoDoCarro < 1990)
            {
                taxaDeTransferencia = (valorDoCarro * 1) / 100;
            }
            else
            {
                if (anoDoCarro >= 1990)
                {
                    taxaDeTransferencia = (valorDoCarro * 1.5) / 100;
                }
            }
            Console.WriteLine("\n A taxa a ser paga para transferencia do veículo é: R$" + taxaDeTransferencia);
            //Fim da Questão 15
            // Pergunta se o usuario deseja, ir para o menu ou sair do programa.
            FimDaExecucaoDaQuestao();
        }

        static void Questao16()
        {
            /*  Questão 16. Uma empresa concederá um aumento de salário aos seus funcionários,
                variável de acordo com o cargo, conforme a tabela abaixo. Faça um algoritmo
                que leia o salário e o cargo de um funcionário e calcule o novo salário.
                Se o cargo do funcionário não estiver na tabela, ele deverá, então, receber
                40% de aumento. Mostre o salário antigo, o novo salário e a diferença.
                CODIGO      CARGO       PERCENTUAL
                101         GERENTE     10%  
                102         ENGENHEIRO  20%
                103         TÉCNICO     30% */

            double salarioAntigo, salarioNovo;
            string codigoCargo;

            Console.WriteLine("\n Questão 16 - Calcular salário por cargo.");
            Console.WriteLine("\n   CÓDIGO    CARGO NA EMPRESA");
            Console.WriteLine("\n     101      <- Gerente");
            Console.WriteLine("\n     102      <- Engenheiro");
            Console.WriteLine("\n     103      <- Técnico");
            Console.Write("\n Informe o código do seu cargo: ");
            codigoCargo = Console.ReadLine();

            Console.Write("\n Informe o seu salário atual: ");
            salarioAntigo = Convert.ToDouble(Console.ReadLine());

            if (codigoCargo == "101")
            {
                Console.WriteLine("\n Cargo encontrado: Gerente!");
                salarioNovo = ((10 / 100.0) * salarioAntigo) + salarioAntigo;
                Console.WriteLine("\n O seu salário passará de R$ {0} para R$ {1},\n e o aumento foi de: R$ " + (salarioNovo - salarioAntigo), salarioAntigo, salarioNovo);
            }
            else if (codigoCargo == "102")
            {
                Console.WriteLine("\n Cargo encontrado: Engenheiro!");
                salarioNovo = ((20.0 / 100.0) * salarioAntigo) + salarioAntigo;
                Console.WriteLine("\n O seu salário passará de R$ {0} para R$ {1},\n e o aumento foi de: R$ " + (salarioNovo - salarioAntigo), salarioAntigo, salarioNovo);
            }
            else if (codigoCargo == "103")
            {
                Console.WriteLine("\n Cargo encontrado: Técnico!");
                salarioNovo = ((30.0 / 100.0) * salarioAntigo) + salarioAntigo;
                Console.WriteLine("\n O seu salário passará de R$ {0} para R$ {1},\n e o aumento foi de: R$ " + (salarioNovo - salarioAntigo), salarioAntigo, salarioNovo);
            }
            else
            {
                Console.Write("\n Informe o seu cargo na empresa: ");
                codigoCargo = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\n Cargo encontrado: " + codigoCargo);
                salarioNovo = ((40.0 / 100.0) * salarioAntigo) + salarioAntigo;
                Console.WriteLine("\n O seu salário passará de R$ {0} para {1}, e o aumento foi de: R$ " + (salarioNovo - salarioAntigo), salarioAntigo, salarioNovo);
            }
            // Pergunta se o usuario deseja, ir para o menu ou sair do programa.
            FimDaExecucaoDaQuestao();
        }

        static void Questao17()
        {
            /*  Questão 17. Um banco concederá um crédito especial aos seus clientes, variável com o saldo médio no último ano.
                Faça um algoritmo que leia o saldo médio de um cliente e calcule o valor do crédito de acordo com a tabela abaixo.
                Mostre uma mensagem informando o saldo médio e o valor do crédito. 
                Saldo médio    Percentual
                de 0 a 200     nenhum crédito
                de 201 a 400   20% do valor do saldo médio
                de 401 a 600   30% do valor do saldo médio
                acima de 601   40% do valor do saldo médio */

            Double saldoMedio = 0, valorDoCreditoEspecial = 0;
            Console.WriteLine("\n Questão 17");
            Console.WriteLine("\n Crédito Especial");
            Console.Write("\n Digite seu nome: ");
            String nomeDoCliente = Console.ReadLine();
            Console.Write("\n Informe seu saldo médio: R$");
            saldoMedio = Convert.ToDouble(Console.ReadLine());
            if (saldoMedio == 0 && saldoMedio <= 200)
            {
                valorDoCreditoEspecial = 0;
            }
            if (saldoMedio >= 201 && saldoMedio <= 400)
            {
                valorDoCreditoEspecial = (saldoMedio * 20) / 100;
            }
            if (saldoMedio >= 401 && saldoMedio <= 600)
            {
                valorDoCreditoEspecial = (saldoMedio * 30) / 100;
            }
            if (saldoMedio >= 601)
            {
                valorDoCreditoEspecial = (saldoMedio * 40) / 100;
            }
            Console.WriteLine("\n " + nomeDoCliente + " seu saldo médio é R$" + saldoMedio + " e o seu crédito especial é de R$" + valorDoCreditoEspecial);
            // Fim da Questão 17
            // Pergunta se o usuario deseja, ir para o menu ou sair do programa.
            FimDaExecucaoDaQuestao();
        }

        static void Questao18()
        {
            /* Questão 18.  Criar um programa para identificar o valor a ser pago por um plano de saúde
               dada a idade do conveniado considerando que todos pagam R$ 100 mais um adicional conforme
               a seguinte tabela: 1) crianças com menos de 10 anos pagam R$80; 2) conveniados com idade
               entre 10 e 30 anos pagam R$50; 3) conveniados com idade entre 40 e 60 anos pagam R$ 95;
               e 4) conveniados com mais de 60 anos pagam R$130. */

            int idadeCliente;
            Console.WriteLine("\n Questão 18 - Calcular valor a ser pago no plano por idade.");
            Console.Write("\n Informe a sua idade: ");
            idadeCliente = Convert.ToInt32(Console.ReadLine());

            ClasseDaQuestao18 varDaClasse = new ClasseDaQuestao18
            {
                idadeClienteClasse = idadeCliente
            };

            varDaClasse.VerificaIdadeCliente();
            
            // Pergunta se o usuario deseja, ir para o menu ou sair do programa.
            FimDaExecucaoDaQuestao();
        }
    }

    class ClasseDaQuestao18
    {
        public int idadeClienteClasse { get; set; }
        
        public void VerificaIdadeCliente()
        {
            if (idadeClienteClasse < 10)
            {
                Console.WriteLine("\n O valor mensal do plano é de: R$ " + (100.0 + 80.0));
            }
            else if (idadeClienteClasse == 10 || idadeClienteClasse <= 39)
            {
                Console.WriteLine("\n O valor mensal do plano é de: R$ " + (100.0 + 50.0));
            }
            else if (idadeClienteClasse == 40 || idadeClienteClasse <= 60)
            {
                Console.WriteLine("\n O valor mensal do plano é de:  R$ " + (100.0 + 95.0));
            }
            else if (idadeClienteClasse > 60)
            {
                Console.WriteLine("\n O valor mensal do plano é de: R$ " + (100.0 + 130.0));
            }
        }

    }

}
