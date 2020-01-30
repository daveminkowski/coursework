public class PolymorphismDemo
{
	public static void main(String[] args)
	{
		Person[] people = new Person[10];

		people[0] = new Undergraduate("Cotty, Manny", 4910, 1);
		people[1] = new Undergraduate("Kick, Anita", 9931, 2);
		people[2] = new Student("DeBanque, Robin", 8812);
		people[3] = new Undergraduate("Bugg, June", 9901, 4);
      people[4] = new Staff(); //blank object with default values for Staff Class
      people[5] = new Staff("Doe, John", 75321,"Applied Mathematics", 19);
		people[6] = new Staff("Minkowski, David", 12345,"Computer Science", 1);
		people[7] = new Faculty();//blank object with default values for Faculty Class
		people[8] = new Faculty("Minkowski, David", 12345,"Computer Science", "World Record Holder of Java Programming Errors");
      people[9] = new Faculty("T, Mr.", 19820,"Athletics", "Pitier of Fools, Manager of Jibba-Jabba");
      
		for (Person p : people)
		{
			p.writeOutput();
			System.out.println();
		}
	}
}