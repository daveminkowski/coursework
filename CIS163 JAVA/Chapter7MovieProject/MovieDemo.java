// Created by Dave Minkowski on 10/25/2016

	public class MovieDemo {

    public static void main(String[] args){

		Movie movie1 = new Movie();
		movie1.setName("The Accountant");
		movie1.setRating("R");
		movie1.addRating(3);
		movie1.addRating(3);
		movie1.addRating(3);
		movie1.addRating(4);
		movie1.addRating(2);
		System.out.println("Ben Affleck stars in \"" + movie1.getName() + "\", rated " + movie1.getRating() + ". On average, moviegoers rated this film a " + movie1.getAverage() + "... which is" +
		" still higher than Gigli which was rated on 10 scale.");
		System.out.println("");

		Movie movie2 = new Movie();
		movie2.setName("Inferno");
		movie2.addRating(4);
		movie2.addRating(5);
		movie2.addRating(4);
		movie2.addRating(4);
		movie2.addRating(3);
		System.out.println("Tom Hanks stars in \"" + movie2.getName() + "\", rated " + movie2.getRating() + ". On average, moviegoers rated this film a " + movie2.getAverage() + ". This is the " +
		"\"hottest\" film in theaters right now.");
		System.out.println("");

		Movie movie3 = new Movie(); // for this object i was testing out using the sum of reviewers to make the average review formula work with more than 5 reviews, which is why there are so many
		// entries. When adding more than 5 reviews to each movie, the averages could get well above 5, which is the highest rating level and didn't make sense.
		movie3.setName("Deepwater Horizon");
		movie3.addRating(4);
		movie3.addRating(5);
		movie3.addRating(4);
		movie3.addRating(5);
		movie3.addRating(4);
		movie3.addRating(5);
		movie3.addRating(5);
		movie3.addRating(4);
		movie3.addRating(5);
		movie3.addRating(5);
		movie3.addRating(4);
		movie3.addRating(5);
		movie3.addRating(4);
		movie3.addRating(5);
		movie3.addRating(5);
		System.out.println("Mark Wahlberg stars in \"" + movie3.getName() + "\", rated " + movie3.getRating() + ". On average, moviegoers rated this film a " + movie3.getAverage() + ", " +
		"losing more than half a point when fans discovered there was no Ted cameo.");

    }
}
