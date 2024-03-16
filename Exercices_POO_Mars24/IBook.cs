using System;
using System.Runtime.CompilerServices;

namespace Exercices_POO_Mars24
{
	public interface IBook
	{
		public string Title { get; set; }
		public string Author { get; set; }
		public string Reference { get; set; }

		public void CheckOut();

		public void CheckIn();

		public bool IsCheckedOut();


	}
}

