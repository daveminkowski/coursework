// Created by Dave Minkowski on 10/23/2016

    public class Movie {

        private String name;					// both strings are private, must create accessors and mutators to retrieve and manipulate these values.
        private String ratingMPAA;				// both strings are private, must create accessors and mutators to retrieve and manipulate these values.

//       private int fanRated1 = 0, 				// sets integer values for viewer ratings
//					fanRated2 = 0,
//					fanRated3 = 0,
//					fanRated4 = 0,
//					fanRated5 = 0;
		private int[] ratings; // creates an integer array named ratings

		public Movie(){ // constructor to set movie names to be blank and the ratings to be PG-13 by default. (If the movies are not given explicit values.
			name = "";
			ratingMPAA = "PG-13";
			ratings = new int[5]; // initializes the ratings array to hold 5 elements
			//sets each rating array value to 0 by default. ;
			for (int r = 0; r < 5; r++){
				ratings[r] = 0;
			}
		}


        public void setName(String movieTitle){			//MUTATOR METHOD setName(): passes a new name 'movieTitle' from client program or main method to set the private variable 'name'

            name = movieTitle;							//(private variable = variable set in client program)
        }
        public String getName(){						// ACCESSOR METHOD getName(): "getName" returns the value for the "name" variable

			return name;								// will return a value for "name" when accessed from outside program or main method.
		}
        public void setRating(String movieRating){	// MUTATOR METHOD setRating(): passes a new MPAA rating 'movieRating' from client program or main method to set the private variable "ratingMPAA"

            ratingMPAA = movieRating;					//(private variable = variable set in client program or main method)
        }
        public String getRating(){						// ACCESSOR METHOD getRating(): "getRating" returns the value for the "ratingMPAA" variable

			return ratingMPAA;							// will return a value for "ratingMPAA" (given as 'movieRating') when accessed from outside program or main method.
		}
		public void addRating(int viewerRating){		//METHOD: Add a viewer rating to a movie
			if ((viewerRating < 1) || (viewerRating > 5)) 	// if rating is < 1 OR > 5, cancel. Ratings must be from 1-5, other answers will not satisfy the rating requirement. This makes sure
				return;											// the program only accepts the correct input. However, if the rating is between 1 and 5, increment the array below:

			// this array below replaced the entire switch statement we had before. This is subtracting 1 from each rating because array numbering actually starts at 0.
			// This will increase the number of ratings for each rating entry by 1. eg: increase # of 1 star ratings by 1, or the number of 4 star ratings by 1, etc.
			ratings[viewerRating-1]++;
		}

		public double getAverage(){

			// this double value finds the total number of reviews.
			double totalReviews = ((ratings[0] + ratings[1] + ratings[2] + ratings[3] + ratings[4]));
			// this divides the sum of the value of the reviews by the total number of reviews.
			return (ratings[0] + 2*ratings[1] + 3*ratings[2] + 4* ratings[3] + 5*ratings[4]) / totalReviews;
		}

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
