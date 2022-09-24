using Locatudo.Dominio.Executores;
using Locatudo.Dominio.Testes.Customizacoes;
using FluentAssertions;
using AutoFixture;
using Locatudo.Dominio.Executores.Comandos.Entradas;
using Locatudo.Dominio.Executores.Comandos.Saidas;

namespace Locatudo.Dominio.Testes.Executores
{
    public class TestesExecutorCadastrarEquipamento
    {
        private readonly ComandoCadastrarEquipamento _comandoValido = new ("Equipamento teste 123");

        [Theory, AutoMoq]
        public void Comando_Valido_CadastrarEquipamento(IFixture fixture)
        {
            //Arrange
            var executor = fixture.Create<ExecutorCadastrarEquipamento>();

            //Act
            var resultado = executor.Executar(_comandoValido);

            //Assert
            resultado.Successo.Should().BeTrue("Resultados com sucesso devem ter o valor da propriedade Sucesso igual a verdadeiro");
            resultado.Dado
                .Should().NotBeNull("Resultados com sucesso devem ter valor não nulo na propridade Dado")
                .And.BeOfType<DadoRespostaComandoCadastrarEquipamento>("Resultados com sucesso devem ter a propriedade Dado de um tipo específico")
                .Which.Should().Match<DadoRespostaComandoCadastrarEquipamento>(x => x.Nome.Equals(_comandoValido.Nome), "O nome do novo equipamento deve ser igual ao que foi passado no comando");
        }
    }
}
