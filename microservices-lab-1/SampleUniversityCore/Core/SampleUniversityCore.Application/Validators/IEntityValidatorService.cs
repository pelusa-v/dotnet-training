using System.Linq.Expressions;
using SampleUniversityCore.Application.Services.DTOs;
using SampleUniversityCore.Domain.Entities;

namespace SampleUniversityCore.Application.Validators;

public interface IEntityBasicValidatorService
{
    Task<ResultDTO<T>> ValidateCourseAsync<T>(ResultDTO<T> result, Expression<Func<CourseSection, bool>> predicate);
}
