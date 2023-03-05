namespace LMSAPI.Departments;

public record DepartmentCommand(int Id, string Name);
public record DepartmentDto(int Id, string Name, IEnumerable<LecturerDto> Lectures, 
    IEnumerable<CourseDto> Courses, IEnumerable<Class> Classes);
public record DepartmentPageDto(int Id, string Name);

[Processor]
public class DepartmentProcessor
{
    private readonly IDepartmentRepository _departmentRepository;

    public DepartmentProcessor(IDepartmentRepository departmentRepository)
    {
        _departmentRepository = departmentRepository;
    }
    
    public async Task<int> UpsertAsync(DepartmentCommand command)
    {
        var isNew = command.Id == 0;
        Department? department;

        if (isNew)
        {
            department = Department.Create(command.Name);
            await _departmentRepository.AddAsync(department);
            return department.Id;
        }

        department = await _departmentRepository.FindByIdAsync(command.Id);
        if(department is null) throw new NullReferenceException();

        department.HasName(command.Name);
        await _departmentRepository.UpdateAsync(department);
        return department.Id;
    }

    public async Task<DepartmentDto> GetAsync(int id)
    {
        var department = await _departmentRepository.FindByIdAsync(id);
        if (department is null) throw new NullReferenceException();

        return department.Adapt<DepartmentDto>();
    }

    public async Task<PaginatedList<DepartmentPageDto>> GetPageAsync(PaginatedCommand command)
    {
        var page = await _departmentRepository.GetPageAsync(command);
        return page.Adapt<PaginatedList<DepartmentPageDto>>();
    }

    public async Task DeleteAsync(int id)
    {
        var department = await _departmentRepository.FindByIdAsync(id);
        if (department is null) throw new NullReferenceException();

        await _departmentRepository.SoftDeleteAsync(department);
    }
    
    public async Task HardDeleteAsync(int id)
    {
        var department = await _departmentRepository.FindByIdAsync(id);
        if (department is null) throw new NullReferenceException();

        await _departmentRepository.DeleteAsync(department);
    }
}