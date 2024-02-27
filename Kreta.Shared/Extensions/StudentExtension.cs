﻿using Kreta.Shared.Dtos;
using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.Shared.Extensions
{
    public static class StudentExtension
    {
        public static StudentDto ToDto(this Student student)
        {
            return new StudentDto
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                BirthDay = student.BirthDay,
                PlaceOfBirth = student.PlaceOfBirth,
                IsWoman = student.IsWoman,
                EducationLevel = student.EducationLevelId,
                SchoolYear = student.SchoolYear,
                SchoolClass = student.SchoolClass,
            };
        }

        public static Student ToModel(this StudentDto studentdto)
        {
            return new Student
            {
                Id = studentdto.Id,
                FirstName = studentdto.FirstName,
                LastName = studentdto.LastName,
                BirthDay = studentdto.BirthDay,
                PlaceOfBirth = studentdto.PlaceOfBirth,
                IsWoman = studentdto.IsWoman,
                EducationLevelId = studentdto.EducationLevel,
                SchoolClass = studentdto.SchoolClass,  
                SchoolYear = studentdto.SchoolYear,
            };
        }
    }

}
