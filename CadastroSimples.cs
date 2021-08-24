using System;

namespace CadastroSimples {
    class CadastroSimples {
        static void Main(string[] args) {

            String nome, cpf, sexo, idade;
            int sexo_escolha;
            int w = 0; // define se o programa está rodando ou não.
            int cond = 1; // repete a função de escolha de sexo.

            nome = null;
            cpf = null;
            sexo = null;
            idade = null;

            while (w != 1) {
                Console.WriteLine("# # # # # # # - Olá Seja Bem-vindo(a) - # # # # # # #");
                Console.WriteLine("#                                                   #");
                Console.WriteLine("#                OPÇÕES DISPONÍVEIS                 #");
                Console.WriteLine("#                                                   #");
                Console.WriteLine("#              1 - CADASTRAR UMA PESSOA             #");
                Console.WriteLine("#           2 - EDITAR O CADASTRO EXISTENTE         #");
                Console.WriteLine("#         3 - VISUALIZAR O CADASTRO EXISTENTE       #");
                Console.WriteLine("#           4 - DELETAR O CADASTRO EXISTENTE        #");
                Console.WriteLine("#               5 - SAIR DO PROGRAMA                #");
                Console.WriteLine("#                                                   #");

                Console.Write("#      Escolha a ação que deseja realizar: ");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha) {
                    case 1:

                        if (nome == null && cpf == null && idade == null && sexo == null) {
                            Console.WriteLine("\n# - Iniciando sessão de cadastro...\n");
                            Console.Write("# - Insira seu nome: ");
                            nome = Console.ReadLine();

                            Console.Write("# - Insira sua Idade: ");
                            idade = Console.ReadLine();

                            Console.Write("# - Insira seu CPF (apenas números): ");
                            cpf = Console.ReadLine();

                            while (cond != 0) {
                                Console.WriteLine("# - Selecione seu sexo: ");
                                Console.WriteLine("# [1] - Masculino");
                                Console.WriteLine("# [2] - Feminino");
                                Console.WriteLine("# [3] - Outro...");
                                Console.Write("# - Digite: ");

                                sexo_escolha = int.Parse(Console.ReadLine());

                                if (sexo_escolha == 1) {
                                    sexo = "Masculino";
                                    cond = 0;
                                }
                                else if (sexo_escolha == 2) {
                                    sexo = "Feminino";
                                    cond = 0;
                                }
                                else if (sexo_escolha == 3) {
                                    sexo = "Outro";
                                    cond = 0;
                                }
                                else {
                                    Console.WriteLine("\n[!] - Erro! Você inseriu um valor inválido.\n");
                                    cond = 1;
                                }
                            }

                            Console.WriteLine("\n# # # # # FICHA DE CADASTRO # # # # #");
                            Console.WriteLine("#                                   #");
                            Console.WriteLine("#                                   #");
                            Console.WriteLine("#      NOME: " + nome);
                            Console.WriteLine("#      IDADE: " + idade);
                            Console.WriteLine("#      CPF: " + cpf);
                            Console.WriteLine("#      SEXO: " + sexo);
                            Console.WriteLine("#                                   #");
                            Console.WriteLine("#                                   #");
                            Console.WriteLine("# # # # # FICHA DE CADASTRO # # # # #\n");

                        } else {
                            Console.WriteLine("\n[!] - Erro no Sistema");
                            Console.WriteLine("[!] - Pelo visto você parece ter um cadastro, logo essa opção não pode ser executada!\n");
                        }

                        break;

                    case 2:

                        Console.WriteLine("\n[!] - Erro no sistema");
                        Console.WriteLine("Coming Soon....");

                        break;

                    case 3:

                        Console.WriteLine("\n[!] - Erro no sistema");
                        Console.WriteLine("Coming Soon.....");

                        break;

                    case 4:

                        Console.WriteLine("\n[!] - Erro no sistema");
                        Console.WriteLine("Coming Soon....");

                        break;

                    case 5:

                        w = 1;
                        Console.Write("Pressione enter para fechar o console...");
                        Console.ReadLine();

                        break;

                    default:

                        Console.WriteLine("\n[!] - Erro no Sistema");
                        Console.WriteLine("Você inseriu um valor inválido.\n");

                        break;
                }
            }
        }
    }
}
