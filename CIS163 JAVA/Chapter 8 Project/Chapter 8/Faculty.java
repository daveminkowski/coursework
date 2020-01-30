public class Faculty extends Employee
{
    private String title;

    public Faculty( )
    {
        super( );
        title = "Unassigned";
    }
    
    public Faculty(String initialName, int initialEmployeeNumber, String initialDepartment, String initialTitle)
    {
        super(initialName, initialEmployeeNumber, initialDepartment);
        setTitle(initialTitle);
    }
    
    public void reset(String newName, int newEmployeeNumber, String newDepartment, String newTitle)
    {
        reset(newName, newEmployeeNumber, newDepartment, newTitle); 
        setTitle(newTitle); 
    }
    
    public String getTitle( )
    {
        return title;
    }
    
    public void setTitle(String newTitle)
    {
        title = newTitle;
    }    
    public void writeOutput( )
    {
        super.writeOutput( );
        System.out.println("Title: " + title);
    }
 
    public boolean equals(Faculty otherFaculty)
    {
        return equals((Employee)otherFaculty) &&
               (this.title == otherFaculty.title);
    }

}
