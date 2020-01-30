package com.company;

public class Main {

    public static void main(String[] args) {

        Dog myDog = new Dog();
        Cow myCow = new Cow();
        Snake mySnake = new Snake();

        myDog.setName("My Dog Chop");
        myCow.setName("My Cow Elsie");
        mySnake.setName("My Snake Sammy");

        System.out.print(myDog.getName() + " says ");
        myDog.speak();

        System.out.print(myCow.getName() + " says ");
        myCow.speak();

        System.out.print(mySnake.getName() + " says ");
        mySnake.speak();

    }
}
