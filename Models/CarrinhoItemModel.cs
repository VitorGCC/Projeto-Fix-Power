using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjetoDs.Models
{
    public class CarrinhoItemModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public int Categoria { get; set; }
    }
    public class Cart
{
    public List<CarrinhoItemModel> Items { get; set; } = new List<CarrinhoItemModel>();

    public void AddItem(CarrinhoItemModel item)
    {
        var existingItem = Items.FirstOrDefault(i => i.Id == item.Id);
        if (existingItem != null)
        {
            existingItem.Quantidade += item.Quantidade;
        }
        else
        {
            Items.Add(item);
        }
    }

    public decimal Total => Items.Sum(i => i.Preco * i.Quantidade);
}
}