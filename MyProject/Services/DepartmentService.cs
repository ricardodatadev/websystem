using MyProject.Data;
using MyProject.Models;


public class DepartmentService
{
    private readonly MyProjectContext _context;

    public DepartmentService(MyProjectContext context)
    {
        _context = context;
    }

    public List<Department> FindAll()
    {
        return _context.Department.ToList();
    }
}
