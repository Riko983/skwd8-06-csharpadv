﻿using SEDC.Adv.Class03.Excersise.Entities.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Adv.Class03.Excersise.Entities
{
	public class Student : User, IStudent
	{
		public List<int> Grades { get; set; }
		public void PringGrades()
		{
			foreach (int grade in Grades)
			{
				Console.WriteLine(grade);
			}
		}

		public override void PrintUser()
		{
			Console.WriteLine($"Student: {Name} with username {Username} and average grade of {Grades.Sum() / Grades.Count}");
		}
	}
}
