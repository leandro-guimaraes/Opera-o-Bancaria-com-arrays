using System;

namespace Operação_bancaria_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##############################\r\n        BANCO SHARP   \r\n##############################");

            double[] saldo = new double[5];
            string[] contas = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("DIGITE O NUMERO DA CONTA PARA CADASTRO Nº" + i);
                contas[i] = Console.ReadLine();
                Console.WriteLine("INSIRA O SALDO DA CONTA " + i );
                saldo[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("  ## ESCOLHA UMA OPERAÇÃO ## ");
            Console.WriteLine("");
            Console.WriteLine(" -> SACAR  (1) ");
            Console.WriteLine(" -> DEPOSITAR   (2) ");
            Console.WriteLine(" -> TRANSFERIR  (3) ");
            Console.WriteLine(" -> FINALIZAR  (4) ");
            Console.WriteLine("");
            int opcao = int.Parse(Console.ReadLine().ToString());


            if (opcao > 0)
            {
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("DIGITE A CONTA PARA SAQUE: ");
                        string contaDebito = Console.ReadLine();

                        for (int i = 0; i < 5; i++)
                        {
                            if (contaDebito == contas[i])
                            {
                                Console.WriteLine("DIGITE O VALOR PARA SAQUE");
                                double valorDebito = Convert.ToDouble(Console.ReadLine());
                                if (saldo[i] >= valorDebito)
                                {
                                    saldo[i] = saldo[i] - valorDebito;
                                    Console.WriteLine("SAQUE REALIZADO.");
                                }
                                else
                                {
                                    Console.WriteLine("SALDO INSUFIENTE.");
                                }
                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("DIGITE A CONTA PARA REALIZAR O SAQUE: ");
                        string contaSaque = Console.ReadLine();

                        for (int i = 0; i < 5; i++)
                        {
                            if (contaSaque == contas[i])
                            {
                                Console.WriteLine("DIGITE O VALOR PARA DEPÓSITO R$ ");
                                double valorDeposito = Convert.ToDouble(Console.ReadLine());
                                saldo[i] = saldo[i] + valorDeposito;
                                Console.WriteLine("DEPÓSITO REALIZADO");

                            }
                        }

                        break;

                    case 3:
                        Console.WriteLine("DIGITE A CONTA DE ORIGEM DA TRANSFERÊNCIA: ");
                        string contaOrigemTransfer = Console.ReadLine();

                        Console.WriteLine("DIGITE A CONTA DE DESTINO: ");
                        string contaDestinoTransfer = Console.ReadLine();

                        string contaOrigemEncontrada = string.Empty;
                        int posicaoOrigem = 0;

                        string contaDestinoEncontrada = string.Empty;
                        int posicaoDestino = 0;

                        if (contaOrigemTransfer != contaDestinoTransfer)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                               
                                if (contaOrigemTransfer == contas[i])
                                {
                                    Console.WriteLine("CONTA DE ORIGEM ENCONTRADA.");
                                    contaOrigemEncontrada = contas[i];
                                    posicaoOrigem = i;
                                }
                               
                                if (contaDestinoTransfer == contas[i])
                                {
                                    Console.WriteLine("CONTA DE DESTINO ENCONTRADA.");
                                    contaDestinoEncontrada = contas[i];
                                    posicaoDestino = i;
                                }
                            }

                            if (!string.IsNullOrEmpty(contaOrigemEncontrada) && !string.IsNullOrEmpty(contaDestinoEncontrada))
                            {
                                Console.WriteLine("INFORME O VALOR PARA TRANSFERÊNCIA ");
                                double valorTransfer = Convert.ToDouble(Console.ReadLine());
                                if (saldo[posicaoOrigem] >= valorTransfer)
                                {
                                    saldo[posicaoOrigem] = saldo[posicaoOrigem] - valorTransfer;
                                    saldo[posicaoDestino] += valorTransfer;
                                    Console.WriteLine("VALOR TRANSFERIDO ");
                                }
                            }
                            else
                            {
                                Console.WriteLine("UMA DAS CONTAS, OU AS DUAS CONTAS NÃO FORAM ENCONTRADAS.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("INFORME CONTAS DIFERENTES.");
                        }


                        Console.WriteLine("  ## ESCOLHA UMA OPERAÇÃO ## ");
                        Console.WriteLine("");
                        Console.WriteLine(" -> SACAR  (1) ");
                        Console.WriteLine(" -> DEPOSITAR   (2) ");
                        Console.WriteLine(" -> TRANSFERIR  (3) ");
                        Console.WriteLine(" -> FINALIZAR  (0) ");
                        Console.WriteLine("");
                        opcao = Convert.ToInt32(Console.ReadLine());

                        break;
                }

            }
        }
    }
    enum Operacao
    {
        Sair,
        Sacar,
        Depositar,
        Transferir
    }







}              
















             
