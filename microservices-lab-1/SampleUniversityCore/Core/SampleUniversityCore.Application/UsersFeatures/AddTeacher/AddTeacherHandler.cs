using AutoMapper;
using MediatR;
using SampleUniversityCore.Application.Repositories;
using SampleUniversityCore.Domain.Entities;

namespace SampleUniversityCore.Application.UsersFeatures.AddTeacher;

public class AddTeacherHandler : IRequestHandler<AddTeacherCommand, AddTeacherDTO>
{
    private readonly IMapper _mapper;
    private readonly ITeacherRepository _teacherRepository;

    public AddTeacherHandler(IMapper mapper, ITeacherRepository teacherRepository)
    {
        _mapper = mapper;
        _teacherRepository = teacherRepository;
    }

    public async Task<AddTeacherDTO> Handle(AddTeacherCommand request, CancellationToken cancellationToken)
    {
        var teacher = _mapper.Map<Teacher>(request);
        await _teacherRepository.Create(teacher);
        return _mapper.Map<AddTeacherDTO>(teacher);
    }
}
