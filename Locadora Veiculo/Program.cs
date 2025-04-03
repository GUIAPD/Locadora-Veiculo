
using Locadora_Veiculo;

class Program
{
    public static void Main(String[] args)
    {
        try
        {
            List<Veiculo> listadeveiculos = new List<Veiculo>();
            int loop = 0;
            var veiculos = new Veiculo();
            while (loop == 0)
            {
                Console.WriteLine("1 - Carro");
                Console.WriteLine("2 - Moto");
                Console.WriteLine("3 - Caminhão");
                Console.WriteLine("4 - Ver pedidos");
                Console.WriteLine("Digite a opção que deseja: ");
                int opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        int numpedido = listadeveiculos.Count() + 1;
                        Console.WriteLine("Cadastre o modelo: ");
                        string modelo = Console.ReadLine();
                        Console.WriteLine("Cadastre a Marca: ");
                        string marca = Console.ReadLine();
                        Console.WriteLine("Cadastre o ano: ");
                        int ano = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Cadastre o Valor: ");
                        decimal valorAluguelDia = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Cadastre a quantidade de dias: ");
                        int dias = Convert.ToInt32(Console.ReadLine());
                        Carro carro = new Carro
                        {
                            Numpedido = numpedido,
                            Modelo = modelo,
                            Marca = marca,
                            Ano = ano,
                            ValorAluguelDia = valorAluguelDia,
                            Dias = dias,
                        };
                        listadeveiculos.Add(carro);
                        Limpar();
                        break;
                    case 2:
                        numpedido = listadeveiculos.Count() + 1;
                        Console.WriteLine("Cadastre o modelo: ");
                        modelo = Console.ReadLine();
                        Console.WriteLine("Cadastre a Marca: ");
                        marca = Console.ReadLine();
                        Console.WriteLine("Cadastre o ano: ");
                        ano = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Cadastre o Valor: ");
                        valorAluguelDia = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Cadastre a quantidade de dias: ");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Moto moto = new Moto
                        {
                            Numpedido = numpedido,
                            Modelo = modelo,
                            Marca = marca,
                            Ano = ano,
                            ValorAluguelDia = valorAluguelDia,
                            Dias = dias
                        };
                        listadeveiculos.Add(moto);
                        Limpar();
                        break;
                    case 3:
                        numpedido = listadeveiculos.Count() + 1;
                        Console.WriteLine("Cadastre o modelo: ");
                        modelo = Console.ReadLine();
                        Console.WriteLine("Cadastre a Marca: ");
                        marca = Console.ReadLine();
                        Console.WriteLine("Cadastre o ano: ");
                        ano = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Cadastre o Valor: ");
                        valorAluguelDia = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Cadastre a quantidade de dias: ");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Caminhão caminhao = new Caminhão
                        {
                            Numpedido = numpedido,
                            Modelo = modelo,
                            Marca = marca,
                            Ano = ano,
                            ValorAluguelDia = valorAluguelDia,
                            Dias = dias
                        };
                        listadeveiculos.Add(caminhao);
                        Limpar();
                        break;
                    case 4:
                        foreach (var item in listadeveiculos)
                        {
                            Console.WriteLine(item.Numpedido);
                        }
                        int escolha = int.Parse(Console.ReadLine());
                        veiculos = listadeveiculos.FirstOrDefault(x => x.Numpedido == escolha);
                        Console.WriteLine($"pedido nª {veiculos.Numpedido}");
                        Console.WriteLine($"Veículo: {veiculos.Modelo} | Marca: {veiculos.Marca} | Ano: {veiculos.Ano} | Custo por {veiculos.Dias} dias: R$ {veiculos.CalcularAluguel(veiculos.Dias)}");
                        Console.WriteLine("Digite 0 para continuar ou qualquer outro numero para encerar.");
                        loop = int.Parse(Console.ReadLine());
                        Limpar();
                        break;

                }
            }
        }
        catch (Exception ex)
        { 
            Console.WriteLine(ex.Message); 
        }
                
    }
    static void Limpar()
    {
        Console.WriteLine("Digite algo para continuar: ");
        Console.ReadLine();
        Console.Clear();
    }
}
