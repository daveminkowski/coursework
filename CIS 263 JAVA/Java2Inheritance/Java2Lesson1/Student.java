

package com.company;

public class Student extends Person{

    private int studentId;

    public int getId()
    {
        return studentId;
    }

    public void setStudentId(int inputId)
    {
        studentId = inputId;
    }

    @Override
    public void displayDetails(){
        super.displayDetails();
        System.out.println(super.getName() + "'s student ID is " + getId() + ".");
    }
}
