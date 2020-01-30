// Created by Dave Minkowski on 10/23/2016

    public class Movie
    {
        private String name;					// both strings are private, must create accessors and mutators to retrieve and manipulate these values.
        private String ratingMPAA;				// both strings are private, must create accessors and mutators to retrieve and manipulate these values.

        private int fanRated1 = 0, 				// sets integer values for viewer ratings
					fanRated2 = 0,
					fanRated3 = 0,
					fanRated4 = 0,
					fanRated5 = 0;

        public void setName(String movieTitle)			//MUTATOR METHOD setName(): passes a new name 'movieTitle' from client program or main method to set the private variable 'name'
        {
            name = movieTitle;							//(private variable = variable set in client program)
        }
        public String getName()							// ACCESSOR METHOD getName(): "getName" returns the value for the "name" variable
		{
			return name;								// will return a value for "name" when accessed from outside program or main method.
		}
        public void setRating(String movieRating)	// MUTATOR METHOD setRating(): passes a new MPAA rating 'movieRating' from client program or main method to set the private variable "ratingMPAA"
        {
            ratingMPAA = movieRating;					//(private variable = variable set in client program or main method)
        }
        public String getRating()						// ACCESSOR METHOD getRating(): "getRating" returns the value for the "ratingMPAA" variable
		{
			return ratingMPAA;							// will return a value for "ratingMPAA" (given as 'movieRating') when accessed from outside program or main method.
		}
		public void addRating(int viewerRating)			//METHOD: Add a viewer rating to a movie
		{
			if ((viewerRating < 1) || (viewerRating > 5)) 	// if rating is < 1 OR > 5, cancel. Ratings must be from 1-5, other answers will not satisfy the rating requirement. This makes sure
															// the program only accepts the correct input. However, if the rating is between 1 and 5, execute this switch statement:
			return;
			switch (viewerRating) {                    	// switch statement to increase the appropriate rating based on the input

				case 1:									// if rating was 1, increase the total count of 1 star ratings by 1
					fanRated1++;
					break;
				case 2:									// if rating was 2, increase the total count of 2 star ratings by 1
					fanRated2++;
					break;
				case 3:									// if rating was 3, increase the total count of 3 star ratings by 1, etc
					fanRated3++;
					break;
				case 4:
					fanRated4++;
					break;
				case 5:
					fanRated5++;
					break;
			}
		}
		public double getAverage()	// gets the average of all the ratings. Each value is only a count, so they must be multiplied by their "star" value to evenly weight the average rating.
									// example: if there were five 5-star ratings given but we only divided by 5 without multiplying them by their "weight", the average would still be 1.
		{	// This is used to display the average rating in the main method below.
			double totalReviews = ((fanRated1 + fanRated2 + fanRated3 + fanRated4 + fanRated5));
			return (fanRated1 + 2*fanRated2 + 3*fanRated3 + 4* fanRated4 + 5*fanRated5) / totalReviews;
		}
		// main method to add values to our instance variables then output the results. Everything from this line down can be added to its own class and be run as a client program.
		public static void main(String[] args)

		{
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
			movie2.setRating("PG-13");
			movie2.addRating(4);
			movie2.addRating(5);
			movie2.addRating(4);
			movie2.addRating(4);
			movie2.addRating(3);
			System.out.println("Tom Hanks stars in \"" + movie2.getName() + "\", rated " + movie2.getRating() + ". On average, moviegoers rated this film a " + movie2.getAverage() + ". This is the " +
			"\"hottest\" film in theaters right now.");
			System.out.println("");

			Movie movie3 = new Movie(); // for this object I was testing out using the sum of reviewers to make the average review formula work with more than 5 reviews, which is why there are so many
			// entries. When adding more than 5 reviews to each movie, the averages could get well above 5, which is the highest rating level and didn't make sense.
			movie3.setName("Deepwater Horizon");
			movie3.setRating("PG-13");
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
