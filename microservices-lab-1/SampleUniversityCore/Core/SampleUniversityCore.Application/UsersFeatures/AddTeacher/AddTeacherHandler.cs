using AutoMapper;
using MediatR;
using SampleUniversityCore.Application.ExternalServices;
using SampleUniversityCore.Application.Repositories;
using SampleUniversityCore.Domain.Entities;

namespace SampleUniversityCore.Application.UsersFeatures.AddTeacher;

public class AddTeacherHandler : IRequestHandler<AddTeacherCommand, AddTeacherDTO>
{
    private readonly IMapper _mapper;
    private readonly ITeacherRepository _teacherRepository;
    private readonly IUsersService _usersService;

    public AddTeacherHandler(IMapper mapper, ITeacherRepository teacherRepository, IUsersService usersService)
    {
        _mapper = mapper;
        _teacherRepository = teacherRepository;
        _usersService = usersService;
    }

    public async Task<AddTeacherDTO> Handle(AddTeacherCommand request, CancellationToken cancellationToken)
    {
        var teacher = _mapper.Map<Teacher>(request);
        var createUserReq = _mapper.Map<CreateUserDTO>(request);
        var createdUserId = await _usersService.CreateUser(createUserReq);
        // manage errors here, use retry policies, etc.
        teacher.UserId = createdUserId;

        await _teacherRepository.Create(teacher);
        return _mapper.Map<AddTeacherDTO>(teacher);
    }
}
