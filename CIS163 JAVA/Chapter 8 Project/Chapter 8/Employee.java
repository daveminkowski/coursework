
public class Employee extends Person
{
    private int employeeNumber;
    private String department;

    public Employee( )
    {
        super( );
        employeeNumber = 0;
        department = "Unassigned";
    }

    public Employee(String initialName, int initialEmployeeNumber, String initialDepartment)
    {
        super(initialName);
        employeeNumber = initialEmployeeNumber;
        department = initialDepartment;
    }

    public void reset(String newName, int newEmployeeNumber, String newDepartment)
    {
        setName(newName);
        employeeNumber = newEmployeeNumber;
        department = newDepartment;
    }

    public void setEmployeeNumber(int newEmployeeNumber)
    {
        employeeNumber = newEmployeeNumber;
    }
    
     public int getEmployeeNumber( )
    {
        return employeeNumber;
    }
    
    public void setDepartment(String newDepartment)
    {
        department = newDepartment;
    }
    
     public String getDepartment( )
    {
        return department;
    }

    public void writeOutput( )
    {
        System.out.println("Name: " + getName( ));
        System.out.println("Employee Number: " + employeeNumber);
        System.out.println("Department: " + department);
    }

    public boolean equals(Employee otherEmployee)
    {
        return this.hasSameName(otherEmployee) &&
              (this.employeeNumber == otherEmployee.employeeNumber);
    }


    public String toString( )
    {
        return "Name: " + getName( ) +
			   "\nEmployee number: "  + employeeNumber;
    }

}
