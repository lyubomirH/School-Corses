using MyFirstWebApp.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWebApp.Core.Interfaces
{
	public interface ICarModel
	{
		BodyStyle BodyStyle { get; set; }
		Condition Condition { get; set; }
		string ImageUrl { get; set; }
		string Make { get; set; }
		string Model { get; set; }
		decimal Price { get; set; }
		int Year { get; set; }
	}
}
