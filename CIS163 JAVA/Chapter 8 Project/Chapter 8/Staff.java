public class Staff extends Employee
{
    private int payGrade; //1-20
                       
    public Staff( )
    {
        super( );
        payGrade = 1;
    }
    
    public Staff(String initialName, int initialEmployeeNumber, String initialDepartment, int initialPayGrade)
    {
        super(initialName, initialEmployeeNumber, initialDepartment);
        payGrade = initialPayGrade;
    }
    
    public void reset(String newName, int newEmployeeNumber, String newDepartment,int newPayGrade)
    {
        reset(newName, newEmployeeNumber, newDepartment, newPayGrade);
        setPayGrade(newPayGrade);
    }
    
    public int getPayGrade( )
    {
        return payGrade;
    }
    
    public void setPayGrade(int newPayGrade)
    {
        if ((1 <= newPayGrade) && (newPayGrade <= 20)) //1-20
            payGrade = newPayGrade;
        else
        {
            System.out.println("Illegal payGrade!");
            System.exit(0);
        }
    }
    
    public void writeOutput( )
    {
        super.writeOutput( );
        System.out.println("Pay Grade: " + payGrade);
    }
 
    public boolean equals(Staff otherStaff)
    {
        return equals((Employee)otherStaff) &&
               (this.payGrade == otherStaff.payGrade);
    }

}
