using Homework_Generics_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Generics_.Managers
{
    public class GenericsManager<T> : IGeneric<T> where T:IProduct,new()
    {
        protected readonly List<T> _Products;

        public GenericsManager(List<T> values)
        {
            _Products = values;

        }

        public void Add(T product)
        {
            //Console.WriteLine($"Id:{product.Id} name:{product.Name} price:{product.Price} ");
            _Products.Add(product);
            Console.WriteLine($"{product.Id},{product.Name},{product.Price} product added");
        }

        public void Delete(int id)
        {
            _Products.RemoveAt(id);
            Console.WriteLine($"{id} product removed");
        }

        public IEnumerable<T> GetAll()
        {
            return _Products;
        }

        public T GetById(int id)
        {
            T data = _Products[id];

            foreach(T item in _Products)
            {
                if (item.Id == id)
                {
                    return item;
                }

            }
            return data;
        }

        public void Update(int id, T product)
        {
            foreach (var item in _Products)
            {
                if (item.Id == id)
                {
                    item.Name=product.Name;
                    item.Price = product.Price;
                }

            }
            Console.WriteLine("Updated");
        }
    }
}
