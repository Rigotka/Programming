using System;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
	public class Item
	{
		private readonly int _id;

		private string _name;

		private string _info;

		private int _cost;
		
		public int Id
        {
			get 
			{ 
				return _id; 
			}
        }

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

		public Item(string name, string info, int cost)
        {
			_id = IdGenerator.GetNextID();
			Name = name;
			Info = info;
			Cost = cost;
        }

	}
}