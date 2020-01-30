package com.company;
public class DemoStackTrace {

    public static void main (String[] args) {

        methodA(); //line6
    }

    public static void methodA()
    {
        System.out.println("In methodA()");
        methodB(); //line12
    }

    public static void methodB()
    {
        System.out.println("In methodB()");
        methodC(); //line18
    }

    public static void methodC()
    {
        System.out.println("In methodC()");
        int[] array = {0, 1, 2};
        System.out.println(array[3]); // line25
    }
}
