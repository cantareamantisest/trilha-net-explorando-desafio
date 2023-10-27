using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

hospedes.AddRange(new List<Pessoa>
{
    new Pessoa{ Nome = "João Paulo", Sobrenome = "Oliveira"},
    new Pessoa { Nome = "Antonio Carlos", Sobrenome = "Alves"},
    new Pessoa { Nome = "Simone", Sobrenome = "Pereira"}
});

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 11);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Valor da diária: {suite.ValorDiaria}");
Console.WriteLine($"Dias reservados: {reserva.DiasReservados}");
Console.WriteLine($"Quantidade hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor total da hospedagem: {reserva.CalcularValorDiaria()}");
Console.WriteLine("Pressione enter para continuar....");
Console.ReadKey();