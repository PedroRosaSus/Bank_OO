using System;


namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {

             Gerente gerenteVinicius = new Gerente (){

                Nome = "Vinicius",
                CPF = "987.987.987-98",
                Salario = 3000 ,
                NumeroDeAgencias = 4
            };
             gerenteVinicius.Bonificacao = gerenteVinicius.Salario;

            Vendedor vendedorBento = new Vendedor()
            {
                Nome = "Bento",
                CPF = "123.123.123-12",
                Salario = 1000 ,
                NumeroClientesAtendidos = 4
            };
            vendedorBento.Bonificacao = vendedorBento.Salario;

            Vendedor vendedorFelipe = new Vendedor()
            {
                Nome = "Felipe",
                CPF = "321.321.321-21",
                Salario = 1000 ,
                NumeroClientesAtendidos = 1
            };
            vendedorFelipe.Bonificacao = vendedorFelipe.Salario;

            Vendedor vendedorLuis = new Vendedor()
            {
                Nome = "Luis",
                CPF = "456.546.567-98" ,
                Salario = 1000 ,
                NumeroClientesAtendidos = 2
            };
            vendedorLuis.Bonificacao = vendedorLuis.Salario;

            ContaCorrente contaPedro = new ContaCorrente ("Pedro Rosa dos Santos","789.987.654-23",345,2500,vendedorBento);
            contaPedro.Conta = 2026;

            ContaCorrente contaLucas = new ContaCorrente ("Lucas","653.460.123-67",345,1500,vendedorFelipe);
            contaLucas.Conta = 5422;

            ContaCorrente contaDimas = new ContaCorrente ("Dimas","531.242.454-11",247,500,vendedorLuis);
            contaDimas.Conta = 3549;
           
            
            Console.WriteLine("----- Contas Correntes -----");
            Console.WriteLine("Conta 1: \nNome: " + contaPedro.Titular + ";" + "\nCPF: " + contaPedro.CPF + ";" + "\nAgência: " + contaPedro.Agencia + ";" + "\nConta: " + contaPedro.Conta + ";" + "\nSaldo: R$" + contaPedro.Saldo + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Conta 2: \nNome: " + contaLucas.Titular + ";" + "\nCPF: " + contaLucas.CPF + ";" + "\nAgência: " + contaLucas.Agencia + ";" + "\nConta: " + contaLucas.Conta + ";" + "\nSaldo: R$" + contaLucas.Saldo + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Conta 3: \nNome: " + contaDimas.Titular + ";" + "\nCPF: " + contaDimas.CPF + ";" + "\nAgência: " + contaDimas.Agencia + ";" + "\nConta: " + contaDimas.Conta + ";" + "\nSaldo: R$" + contaDimas.Saldo + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("----- Funcinários -----");
            Console.WriteLine("Vendedor 1: \nNome: " + vendedorBento.Nome + ";" + "\nCPF: " + vendedorBento.CPF + ";" + "\nSalário: R$" + vendedorBento.Salario + ";" + "\nBonificação Anual R$: " + vendedorBento.Bonificacao + ";" + "\nRemuneração Total Anual: R$" + vendedorBento.RemuneracaoTotal(vendedorBento.Salario,vendedorBento.Bonificacao) + ";" + "\nDias de Férias: " + vendedorBento.CalcularFerias() + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Vendedor 2: \nNome: " + vendedorFelipe.Nome + ";" + "\nCPF: " + vendedorFelipe.CPF + ";" + "\nSalário: R$" + vendedorFelipe.Salario + ";" + "\nBonificação Anual R$: " + vendedorFelipe.Bonificacao + ";" + "\nRemuneração Total Anual: R$" + vendedorFelipe.RemuneracaoTotal(vendedorFelipe.Salario,vendedorFelipe.Bonificacao) + ";" + "\nDias de Férias: " + vendedorFelipe.CalcularFerias() + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Vendedor 3: \nNome: " + vendedorLuis.Nome + ";" + "\nCPF: " + vendedorLuis.CPF + ";" + "\nSalário: R$" + vendedorLuis.Salario + ";" + "\nBonificação Anual R$: " + vendedorLuis.Bonificacao + ";" + "\nRemuneração Total Anual: R$" + vendedorLuis.RemuneracaoTotal(vendedorLuis.Salario,vendedorLuis.Bonificacao) + ";" + "\nDias de Férias: " + vendedorLuis.CalcularFerias() + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Gerente : \nNome: " + gerenteVinicius.Nome + ";" + "\nCPF: " + gerenteVinicius.CPF + ";" + "\nSalário: R$" + gerenteVinicius.Salario + ";" + "\nBonificação Anual R$: " + gerenteVinicius.Bonificacao + ";" + "\nRemuneração Total Anual: R$" + gerenteVinicius.RemuneracaoTotal(gerenteVinicius.Salario,gerenteVinicius.Bonificacao) + ";" + "\nDias de Férias: " + gerenteVinicius.CalcularFerias() + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Total de contas criadas:" + ContaCorrente.TotalContaCriadas + ".");
        }}}
