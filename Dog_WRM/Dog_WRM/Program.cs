using System;

namespace Dog_WRM
{
    class Program
    {
        static void Main(string[] args)
        {
			Dog Dog1 = new Dog();
			Console.WriteLine("Testing program for Class Dog");
			Console.WriteLine("Type in dog's age:");
			String age = Console.ReadLine();
			Dog1.setAge(int.Parse(age));
			Console.WriteLine("Type in dog's name:");
			String name = Console.ReadLine();
			Dog1.setName(name);

			Console.WriteLine("Age in human years: " + Dog1.getAge());
			Console.WriteLine("Age in dog years: "+ Dog1.calcDogYears());
			Console.WriteLine("Name: " + Dog1.getName());
			Console.WriteLine("ToString Test: " + Dog1.toString());
		}
    }

	/**
 * This class models a Dog.
 * @author Wade Muncy
 * @version 1.0
 * PP1
 * Project Version #1
 */
	public class Dog
	{

		private int age;
		private String name;

		/**
		 * Empty-argument constructor to put object
		 * into a consistent state.
		 */
		public Dog()
		{
			age = 0;
			name = "";
		}//end constructor

		/**
		 * Constructor accepts the age and
		 * name of the dog. This is the preferred
		 * constructor.
		 * @param age
		 * @param name
		 */
		public Dog(int age, String name)
		{

			this.setAge(age);
			this.setName(name);

		}//end constructor

		public int calcDogYears()
		{
			int dogYears = 15 + (this.age - 1) * 7;
			return dogYears;
		}

		/**
		 * Getter for age
		 * @return
		 */
		public int getAge()
		{
			return age;
		}//end getAge

		/**
		 * Setter for age
		 * Checks the bounds so 
		 * @param age
		 */
		public void setAge(int age)
		{
			if (age < 0)
				this.age = 0;
			else
				this.age = age;
		}//end setAge

		/**
		 * Getter for name
		 * @return
		 */
		public String getName()
		{
			return name;
		}//end getName

		/**
		 * Setter for name. Ensures that only
		 * alpha characters are allowed in the name.
		 * @param name
		 */
		public void setName(String name)
		{
			bool valid = true;
			char[] n = name.ToCharArray();

			foreach (char c in n)
			{
				if (!char.IsLetter(c))
				{
					valid = false;
					break;
				}
			}

			if (valid)
				this.name = name;
			else
				this.name = "";

		}//end setName

		
		public String toString()
		{
			return "Dog [age=" + age + ", name=" + name + "]";
		}//end toString

	}//end class
}
