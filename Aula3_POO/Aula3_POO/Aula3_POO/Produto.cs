namespace Aula3_POO
{
    public class Produto
    {
        private double _preco; //o private so permite que esta variável seja executada neste código
        public string Nome { get; set; } // adiciona comandos para pegar a propriedade do objeto (get) e mudar a propriedade do objeto (set)
        public double Preco { get => _preco; set => _preco = value > 0 ? value : 0; }
        public string Descricao { get => $"Nome: {Nome} - Preço: {Preco:0.00}"; }
    }
}
