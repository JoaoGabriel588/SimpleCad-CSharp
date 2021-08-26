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
                    case 1: // Cadastro

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
                            Console.WriteLine($"#      NOME: {nome}");
                            Console.WriteLine($"#      IDADE: {idade}");
                            Console.WriteLine($"#      CPF: {cpf}");
                            Console.WriteLine($"#      SEXO: {sexo}");
                            Console.WriteLine("#                                   #");
                            Console.WriteLine("#                                   #");
                            Console.WriteLine("# # # # # FICHA DE CADASTRO # # # # #\n");

                        } else {
                            Console.WriteLine("\n[!] - Erro no Sistema");
                            Console.WriteLine("[!] - Pelo visto você parece ter um cadastro, logo essa opção não pode ser executada!\n");
                        }

                        break;

                    case 2: // Edição

                        Console.WriteLine("\n[!] - Erro no sistema");
                        Console.WriteLine("Coming Soon....\n");

                        break;

                    case 3: // Verificação

                        Console.WriteLine("\nProcessando visualização de dados...\n");

                        if (nome == null && cpf == null && idade == null && sexo == null) {
                            Console.WriteLine("[!] - Erro no sistema.");
                            Console.WriteLine("[!] - Motivo: Você não pode visualizar se nem todos os campos estão preenchidos!\n");
                        } else {
                            Console.WriteLine("# # # # # # # # # TELA DE VISUALIZAÇÃO # # # # # # # # #");
                            Console.WriteLine("#                                                      #");
                            Console.WriteLine("#                                                      #");
                            Console.WriteLine($"#      Nome Registrado: {nome}");
                            Console.WriteLine($"#      Idade Registrada: {idade}");
                            Console.WriteLine($"#      CPF Registrado: {cpf}");
                            Console.WriteLine($"#      Sexo Registrado: {sexo}");
                            Console.WriteLine("#                                                      #");
                            Console.WriteLine("#                                                      #");
                            Console.WriteLine("# # # # # # # # # TELA DE VISUALIZAÇÃO # # # # # # # # #\n");
                        }

                        break;

                    case 4: // Apagar

                        Console.WriteLine("\n# - Processando ação de deletar dados...\n");

                        if (nome == null && cpf == null && idade == null && sexo == null) {
                            Console.WriteLine("[!] - Erro no sistema.");
                            Console.WriteLine("[!] - Não é possível apagar os dados, é preciso que haja um cadastro no sistema para realizar essa ação!\n");
                        } else {
                            Console.WriteLine("# - Você deseja apagar todos os dados cadastrados?");
                            
                            Console.WriteLine("# [1] - Sim");
                            Console.WriteLine("# [2] - Não");
                            Console.Write("# - Selecione: ");
                            int escolha_D = int.Parse(Console.ReadLine());

                            switch (escolha_D) { 

                                case 1:

                                    nome = null;
                                    cpf = null;
                                    idade = null;
                                    sexo = null;

                                    Console.WriteLine("# - Apaguei todos os dados cadastrados no sistema!\n");
                                    break;
                                case 2:

                                    Console.WriteLine("# - Certo, não apaguei nenhum dado do sistema!\n");

                                    break;

                                default:

                                    Console.WriteLine("[!] - Erro no sistema.");
                                    Console.WriteLine("[!] - Você inseriu um valor inválido!\n");

                                    break;
                            }

                        }

                        break;

                    case 5: // Sair

                        w = 1;
                        Console.Write("Pressione enter para fechar o console...");
                        Console.ReadLine();

                        break;

                    default: // Valor inválido

                        Console.WriteLine("\n[!] - Erro no Sistema");
                        Console.WriteLine("Você inseriu um valor inválido.\n");

                        break;
                }
            }
        }
    }
}
