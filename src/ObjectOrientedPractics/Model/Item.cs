using System;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
	/// <summary>
	/// Хранит данные о товаре.
	/// </summary>
	public class Item
	{
		/// <summary>
		/// ID товара.
		/// </summary>
		private readonly int _id;

		/// <summary>
		/// Название товара.
		/// </summary>
		private string _name;

		/// <summary>
		/// Информация о товаре.
		/// </summary>
		private string _info;

		/// <summary>
		/// Цена товара.
		/// </summary>
		private int _cost;
		
		/// <summary>
		/// Возвращает ID товара.
		/// </summary>
		public int Id
        {
			get 
			{ 
				return _id; 
			}
        }

		/// <summary>
		/// Возвращает и задает название товара.
		/// </summary>
		public string Name
        {
			get 
			{ 
				return _name; 
			}
            set 
			{
				ValueValidator.AssertStringNotNull(value, nameof(Name));
				ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
				_name = value; 
			}
        }

		/// <summary>
		/// Возвращает и задает информацию о товаре.
		/// </summary>
		public string Info
        {
			get 
			{ 
				return _info; 
			}
			set 
			{
				ValueValidator.AssertStringNotNull(value, nameof(Info));
				ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
				_info = value; 
			}
        }

		/// <summary>
		/// Возвращает и задает стоимость товара.
		/// </summary>
		public int Cost
        {
			get 
			{ 
				return _cost;
			}
			set 
			{
				ValueValidator.AssertValueOnPositive(value, nameof(Cost));
				ValueValidator.AssertValueInRange(value, 0, 100000, nameof(Cost));
				_cost = value; 
			}
        }

		/// <summary>
		/// Создает экземпляр <see cref="Item"/>
		/// </summary>
		public Item()
        {
			_id = IdGenerator.GetNextID();
			Name = $"Товар {_id}";
			Info = "Не заполнено";
			Cost = 0;
		}

		/// <summary>
		/// Создает экземпляр <see cref="Item"/>
		/// </summary>
		/// <param name="name">Название. До 200 символов.</param>
		/// <param name="info">Информация. до 1000 символов.</param>
		/// <param name="cost">Стоимость товара. от 0 до 100000.</param>
		public Item(string name, string info, int cost)
        {
			_id = IdGenerator.GetNextID();
			Name = name;
			Info = info;
			Cost = cost;
        }

	}
}